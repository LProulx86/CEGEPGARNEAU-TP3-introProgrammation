using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Proulx_Laurent
{
    public partial class Form1 : Form
    {
        // Chemin du dossier
        public const string chemin = "C:\\data-420-04A-FX\\TP3\\";
        // Fichier Equipes
        public const string fichierEquipe = "equipes.csv";
        // Fichier Rencontre (sommaire)
        public const string fichierRencontres = "rencontres.csv";
        // Vecteur Struct de toutes les équipes
        public Equipe[] vectEquipe;
        // Matrice de toutes les rencontres
        public string[,] matriceRencontres;
        // Variable de chaine de caractere de sélection de la division
        public string filtreListeDivision;
        // Vecteur des des rencontre pour une équipe avec filtre(si appliqué)
        public static string[] vectSommaireRencontres;
        // Struct équipe visible selon division sélectioné
        public Equipe[] vectListEquipe;
        // initialisation de l'index (Equipe Complet) ref: vectListEquipe
        public int index = -1;
        // Valeure initiale des filtres (-1 = filtre absent)
        public const string resetFiltre = "-1";
        public Form1()
        {
            InitializeComponent();
        }

        // Chargement des fichiers equipes.csv et rencontres.csv + affichage des equipes
        private void Form1_Load(object sender, EventArgs e)
        {
            vectEquipe = LibNHL.ChargementEquipe(chemin + fichierEquipe);
            matriceRencontres = LibNHL.ChargementRencontres(chemin + fichierRencontres);
            AfficherListeEquipe();
        }

        // recherche de l'équipe sélectionné, affichage des statistiques et des sommaires
        private void lstEquipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEquipes.SelectedIndex < 0)
            {
                return;
            }

            // code de l'équipe sélectioné
            string sigleSelection = vectListEquipe[lstEquipes.SelectedIndex].Code.Trim();

            // index du vecteur Equipe complet de l'équipe sélectioné
            index = LibNHL.IndexVectEquipes(sigleSelection, vectEquipe);

            // Affiche les statistiques de l'equipe
            AfficherStatistique(index);

            //Affiche la liste du sommaire des rencontre pour l'équipe (sans filtres)
            AfficherSomaire(vectEquipe[index].Code, false, false);

            // Rend disponible les boutons
            btnFiltrer.Enabled = true;
            btnEnregistrer.Enabled = true;
        }
        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            // Vérification si les filtres sont activés
            bool filtreVic = false;
            bool filtredef = false;
            if (chkActiveFiltreVictoires.Checked)
            {
                filtreVic = true;
            }
            if (chkActiveFiltreDefaites.Checked)
            {
                filtredef = true;
            }
            // Message d'oubli d'activation des filtres
            if (!(filtreVic || filtredef))
            {
                MessageBox.Show("Aucun filtre n'est actif",
                    "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //Affiche la liste du sommaire des rencontre pour l'équipe filtré
            AfficherSomaire(vectEquipe[index].Code, filtreVic, filtredef);
        }

        // sélection de la division atlantique (défaut)
        private void optAtlantique_CheckedChanged(object sender, EventArgs e)
        {
            if (optAtlantique.Checked)
            {
                // nettoyage de la liste
                lstEquipes.Items.Clear();
                // Enregistrement de la sélection
                filtreListeDivision = "atl";
                // Afficher la sélection
                AfficherListeEquipe();
            }
        }

        // sélection de la division central (voir commentaires division atlantique)
        private void optCentral_CheckedChanged(object sender, EventArgs e)
        {
            if (optCentral.Checked)
            {
                lstEquipes.Items.Clear();
                filtreListeDivision = "cen";
                AfficherListeEquipe();
            }
        }

        // sélection de la division Metro (voir commentaires division atlantique)
        private void optMetro_CheckedChanged(object sender, EventArgs e)
        {
            if (optMetro.Checked)
            {
                lstEquipes.Items.Clear();
                filtreListeDivision = "met";
                AfficherListeEquipe();
            }
        }

        // sélection de la division Pacifique (voir commentaires division atlantique)
        private void optPacifique_CheckedChanged(object sender, EventArgs e)
        {
            if (optPacifique.Checked)
            {
                lstEquipes.Items.Clear();
                filtreListeDivision = "pac";
                AfficherListeEquipe();
            }
        }

        // sélection de toutes les divisions (voir commentaires division atlantique)
        private void optToutes_CheckedChanged(object sender, EventArgs e)
        {
            if (optToutes.Checked)
            {
                lstEquipes.Items.Clear();
                filtreListeDivision = "tous";
                AfficherListeEquipe();
            }
        }

        // Affiche les equipes selon la division sélectionée
        private void AfficherListeEquipe()
        {
            // Vecteur Equipe filtrer selon la division.
            vectListEquipe = LibNHL.AfficherListeEquipe(filtreListeDivision, vectEquipe);
            
            // Affichage des équipes
            for (int i = 0; i < vectListEquipe.Length; i++)
            {
                string nomPlage = vectListEquipe[i].Nom + " (" + vectListEquipe[i].Code + ")";
                lstEquipes.Items.Add(nomPlage);
            }
        }

        /// <summary>
        /// Affiche les statistiques de l'équipe sélectioné.
        /// </summary>
        /// <param name="index">Index de l'équipe à afficher</param>
        private void AfficherStatistique(int index)
        {
            // Affiche le titre de la Groupebox
            string textgbo = string.Format("Statistiques pour les {0} ({1})", vectEquipe[index].Nom, vectEquipe[index].Code);
            gboStats.Text = textgbo;

            // Calcul du nombre de partie joué.
            int nbpartie = vectEquipe[index].Victoires + vectEquipe[index].Nulles + vectEquipe[index].Defaites;

            // Affichage des statistiques
            lblParties.Text = nbpartie.ToString();
            lblVictoires.Text = vectEquipe[index].Victoires.ToString();
            lblNulles.Text = vectEquipe[index].Nulles.ToString();
            lblDefaites.Text = vectEquipe[index].Defaites.ToString();
        }
        /// <summary>
        /// Affichage et filtre du sommaire des rencontres
        /// </summary>
        /// <param name="index">Index de l'équipe sélectionné</param>
        /// <param name="filtreVic">Activation du filtre victoire</param>
        /// <param name="filtreDef">Activation du filtre défaite</param>
        private void AfficherSomaire(string code, bool filtreVic, bool filtreDef)
        {
            // Nettoyage de la liste
            lstRencontres.Items.Clear();

            // Initialisation des valeurs de filtre (-1 = filtre non actif)
            int vicMax = -1;
            int vicMin = -1;
            int defMax = -1;
            int defMin = -1;

            //attribution des valeurs si filtre activé
            if (chkActiveFiltreVictoires.Checked && filtreVic)
            {
                vicMax = Convert.ToInt32(txtMaxFiltreVictoires.Text);
                vicMin = Convert.ToInt32(txtMinFiltreVictoires.Text);
            }
            if (chkActiveFiltreDefaites.Checked && filtreDef)
            {
                defMax = Convert.ToInt32(txtMaxFiltreDefaites.Text);
                defMin = Convert.ToInt32(txtMinFiltreDefaites.Text);
            }
            
            // création du vecteur du sommaire filtré
            vectSommaireRencontres = LibNHL.SommaireRencontre(matriceRencontres, vectEquipe, code, vicMax, vicMin, defMax, defMin);
           
            // Affichage des sommaires
            for (int i = 0; i < vectSommaireRencontres.Length; i++)
            {
                lstRencontres.Items.Add(vectSommaireRencontres[i]);
            }
        }

        // Effacement des filtres
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // remise à zéro ( -1 en fait )
            txtMaxFiltreVictoires.Text = resetFiltre;
            txtMinFiltreVictoires.Text = resetFiltre;
            txtMaxFiltreDefaites.Text = resetFiltre;
            txtMinFiltreDefaites.Text = resetFiltre;
            
            // décoché les filtres actifs
            chkActiveFiltreVictoires.Checked = false;
            chkActiveFiltreDefaites.Checked = false;
            
            // Affichage des sommaires sans filtre
            AfficherSomaire(vectEquipe[index].Code, false, false);
        }

        // Ouverture du dialog pour enregistrement du fichier
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //ouverture de la boite de dialog
            Enregistrement Enregistrer = new Enregistrement();

            // message lorsque enregistrement réussit
            if (Enregistrer.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("L'historique des rencontres a été enregistrer",
                    "Succes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
        }

        // activation/désactivation des textbox de filtre victoire
        private void chkActiveFiltreVictoires_CheckedChanged(object sender, EventArgs e)
        {
            // activation
            if (chkActiveFiltreVictoires.Checked)
            {
                txtMaxFiltreVictoires.Enabled = true;
                txtMinFiltreVictoires.Enabled = true;
            }

            // désactivation
            else
            {
                txtMaxFiltreVictoires.Enabled = false;
                txtMinFiltreVictoires.Enabled = false;
            }
        }

        // activation/désactivation des textbox de filtre défaite
        private void chkActiveFiltreDefaites_CheckedChanged(object sender, EventArgs e)
        {
            // activation
            if (chkActiveFiltreVictoires.Checked)
            {
                txtMaxFiltreDefaites.Enabled = true;
                txtMinFiltreDefaites.Enabled = true;
            }

            // désactivation
            else
            {
                txtMaxFiltreDefaites.Enabled = false;
                txtMinFiltreDefaites.Enabled = false;
            }
        }
    }
}
