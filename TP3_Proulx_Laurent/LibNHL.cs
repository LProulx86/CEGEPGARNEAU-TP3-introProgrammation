using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP3_Proulx_Laurent
{
    class LibNHL
    {
        /// <summary>
        /// Chargement des équipes dans le vecteur Equipe
        /// </summary>
        /// <param name="cheminFichier">Chemin complet avec nom du fichier et extension</param>
        /// <returns> Vecteur Struct Equipe avec toutes les équipes</returns>
        public static Equipe[] ChargementEquipe(string cheminFichier)
        {
            // ouverture - lecture - fermeture du flux
            StreamReader fichier = new StreamReader(cheminFichier);
            string fichierLue = fichier.ReadToEnd();
            fichier.Close();

            // Séparation de la lecture en plusieurs lignes
            string[] vectFichierLue = fichierLue.Replace('\r', ' ').Split('\n');

            // Vérification du nombre de ligne utile
            int enteteDerniereLigne = -1;
            if (vectFichierLue[vectFichierLue.Length - 1] == "")
            {
                enteteDerniereLigne = -2;
            }

            // Initialisation du vecteur
            Equipe[] vectEquipe = new Equipe[vectFichierLue.Length + enteteDerniereLigne];

            // Écriture des données
            for (int i = 0; i < vectEquipe.Length; i++)
            {
                string[] ligneTempo = vectFichierLue[i + 1].Split(';');

                string[] overallTempo = ligneTempo[4].Split('-');

                vectEquipe[i].Nom = ligneTempo[1].Trim();
                vectEquipe[i].Code = ligneTempo[2].Trim();
                vectEquipe[i].Division = ligneTempo[3].Trim();
                vectEquipe[i].Victoires = Convert.ToInt32(overallTempo[0]);
                vectEquipe[i].Defaites = Convert.ToInt32(overallTempo[1]);
                vectEquipe[i].Nulles = Convert.ToInt32(overallTempo[2]);
            }

            return vectEquipe;

        }

        /// <summary>
        /// Chargement du fichier des sommaires de rencontre
        /// </summary>
        /// <param name="cheminFichier">Chemin complet avec nom du fichier et extension</param>
        /// <returns> Matrice de chaine de caractère de toutes les confrontations</returns>
        public static string[,] ChargementRencontres(string cheminFichier)
        {
            // ouverture - lecture - fermeture du flux
            StreamReader fichier = new StreamReader(cheminFichier);
            string fichierLue = fichier.ReadToEnd();
            fichier.Close();

            // Séparation de la lecture en plusieurs lignes
            string[] vectFichierLue = fichierLue.Replace('\r', ' ').Split('\n');

            // vérification du nombre de lignes utile
            int enteteDerniereLigne = -1;
            if (vectFichierLue[vectFichierLue.Length - 1] == " ")
            {
                enteteDerniereLigne = -2;
            }

            // nombre de lignes dans le fichier (sans entete)
            int nbLigne = vectFichierLue.Length + enteteDerniereLigne;
            
            // nombre de colonnes dans le fichier
            int nbcolonne = vectFichierLue[1].Split(';').Length;
            
            // initialisation de la matrice (élimination d'une colonne (1ere))
            string[,] matriceRencontres = new string[nbLigne, nbcolonne - 1];

            // Remplissage de la matrice
            for (int i = 0; i < matriceRencontres.GetLength(0); i++)
            {
                string[] vectcolonne = vectFichierLue[i].Split(';');
                for (int j = 0; j < matriceRencontres.GetLength(1); j++)
                {
                    // j+1 -> décalage vers la droite
                    matriceRencontres[i, j] = vectcolonne[j + 1];
                }
            }

            return matriceRencontres;

        }

        /// <summary>
        /// Filtrage et Affichage des équipes selon la division sélectionée
        /// </summary>
        /// <param name="filtreEquipe">Division sélectionée</param>
        /// <param name="vectEquipe"> Vecteur struct Equipe complet</param>
        /// <returns> Vecteur struct Equipe partiel selon le filtre division</returns>
        public static Equipe[] AfficherListeEquipe(string filtreEquipe, Equipe[] vectEquipe)
        {
            // vecteur Equipe temporaire
            Equipe[] listeEquipe = new Equipe[40];
            // Variable de décompte
            int count = 0;

            // Filtre des équipes selon division
            for (int i = 0; i < vectEquipe.Length; i++)
            {
                if (vectEquipe[i].Division == filtreEquipe || filtreEquipe == "tous")
                {
                    listeEquipe[count] = vectEquipe[i];
                    count++;
                }
            }

            // nouveau vecteur de la bonne grandeur
            Equipe[] listeFinale = new Equipe[count];

            // Enregistrement du nouveau vecteur
            for (int i = 0; i < listeFinale.Length; i++)
            {
                listeFinale[i] = listeEquipe[i];
            }

            return listeFinale;
        }

        /// <summary>
        /// Trouve l'index de l'équipe sélectionné dans le vecteur Equipe complet
        /// </summary>
        /// <param name="sigleEquipe">Sigle de l'équipe sélectionné</param>
        /// <param name="vectEquipe">Vecteur struct Equipe complet</param>
        /// <returns>un index</returns>
        public static int IndexVectEquipes(string sigleEquipe, Equipe[] vectEquipe)
        {
            // initialisation de la valeur
            int index = -1;

            // recherche de l'index avec le sigle
            for (int i = 0; i < vectEquipe.Length; i++)
            {
                if (vectEquipe[i].Code.Contains(sigleEquipe))
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        /// <summary>
        /// Création d'un vecteur filtré du sommaire des rencontres
        /// </summary>
        /// <param name="matriceRencontre">Matrice complète</param>
        /// <param name="vectEquipe">Vecteur Struct Equipe complet (initiale)</param>
        /// <param name="index"> Index de l'équipe sélectioné</param>
        /// <param name="vicMax"> Filtre du nombre de victoires max</param>
        /// <param name="vicMin"> Filtre du nombre de victoires min</param>
        /// <param name="defMax"> Filtre du nombre de défaites max</param>
        /// <param name="defMin"> Filtre du nombre de défaites min</param>
        /// <returns> Vecteur des sommaires selon les filtres appliqués</returns>
        public static string[] SommaireRencontre(string[,] matriceRencontre, Equipe[] vectEquipe, string code, int vicMax, int vicMin, int defMax, int defMin)
        {
            // vecteur temporaire des sommaires
            string[] vectSommaire = new string[matriceRencontre.GetLength(0)];

            // Entete latéral (colonne) décalage vers la droite
            int index = IndexVectEquipes(code, vectEquipe) + 1;

            // Variable de comptage
            int count = 0;

            // Filtrage + enregistrement des sommaires
            for (int i = 1; i < vectSommaire.Length; i++)
            {
                // Élimination de la rencontre contre soi-même
                if (i == index) continue;

                // valeur combiné (V-D-N)
                string valeurSomaire = matriceRencontre[index, i];

                // Conversion du sommaire en entier utilisable
                int victoire = Convert.ToInt32(valeurSomaire.Substring(0, 1));
                int defaite = Convert.ToInt32(valeurSomaire.Substring(2, 1));

                // Filtres booléen
                bool maxV = (victoire <= vicMax || vicMax == -1);
                bool minV = (victoire >= vicMin || vicMin == -1);
                bool maxD = (defaite <= defMax || defMax == -1);
                bool minD = (defaite >= defMin || defMin == -1);

                // Application des filtres
                if (maxV && minV && maxD && minD)
                {
                    // enregistrement formaté des sommaires valides
                    vectSommaire[count] = string.Format("{0,-30}{1}", vectEquipe[i - 1].Nom, matriceRencontre[index, i]);
                    count++;
                }

            }

            // Création du vecteur final de bonne grandeur
            string[] SommaireFinal = new string[count];
            for (int i = 0; i < SommaireFinal.Length; i++)
            {
                SommaireFinal[i] = vectSommaire[i];
            }

            return SommaireFinal;
        }

        /// <summary>
        /// Enregistrement d'un fichier selon le sommaire des rencontres affichées (filtré)
        /// </summary>
        /// <param name="nomFichier"> Nom du fichier par l'utilisateur</param>
        /// <param name="cheminFichier"> Chemin du fichier (dossier seulement)</param>
        /// <param name="equipes"> Vecteur filtré du sommaires des équipes</param>
        public static void EnregistrementSommaireRencontres(string nomFichier, string cheminFichier, string[] equipes)
        {
            // chemin du fichier
            string chemin = cheminFichier + nomFichier.ToLower().Trim() + ".csv";

            StreamWriter enregistrerSommaire = new StreamWriter(chemin, true);

            // Entete
            enregistrerSommaire.WriteLine("equipe, nb - rencontres, victoires, défaites, nulles");

            // Création de la ligne et écriture
            for (int i = 0; i < equipes.Length; i++)
            {
                // conversition en entier pour calcul
                int victoires = Convert.ToInt32(equipes[i].Substring(equipes[i].Length - 6, 1));
                int defaites = Convert.ToInt32(equipes[i].Substring(equipes[i].Length - 4, 1));
                int nulles = Convert.ToInt32(equipes[i].Substring(equipes[i].Length - 2, 1));
                string nbrencontre = Convert.ToString(victoires + defaites + nulles);

                // Extraction du nom de l'équipe
                string nom = equipes[i].Substring(0, 30).Trim();

                // Enregistrement de la ligne
                string ligneEnregistrement = nom + ", "
                    + nbrencontre + ", "
                    + victoires + ", "
                    + defaites + ", "
                    + nulles;
                enregistrerSommaire.WriteLine(ligneEnregistrement);
            }

            enregistrerSommaire.Close();
        }
    }
}
