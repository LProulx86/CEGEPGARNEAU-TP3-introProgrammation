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
    public partial class Enregistrement : Form
    {
        public string nomFichier;

        public Enregistrement()
        {
            InitializeComponent();
        }

        // annulation de l'enregistrement
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Bouton enregistrement
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // vérification d'un entrer
            if (txtNomFichier.Text != "")
            {
                nomFichier = txtNomFichier.Text;
                this.DialogResult = DialogResult.OK;
                // Enregistrement du sommaire des rencontres
                LibNHL.EnregistrementSommaireRencontres(nomFichier, Form1.chemin, Form1.vectSommaireRencontres);
                this.Close();
            }
            else
            {
                // Message valeur non nulle
                MessageBox.Show("Entrez un nom de fichier non nulle", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
