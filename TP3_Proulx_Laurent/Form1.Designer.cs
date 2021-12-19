namespace TP3_Proulx_Laurent
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gboDivision = new System.Windows.Forms.GroupBox();
            this.optToutes = new System.Windows.Forms.RadioButton();
            this.optPacifique = new System.Windows.Forms.RadioButton();
            this.optMetro = new System.Windows.Forms.RadioButton();
            this.optCentral = new System.Windows.Forms.RadioButton();
            this.optAtlantique = new System.Windows.Forms.RadioButton();
            this.chkActiveFiltreVictoires = new System.Windows.Forms.CheckBox();
            this.gboEquipes = new System.Windows.Forms.GroupBox();
            this.lstEquipes = new System.Windows.Forms.ListBox();
            this.gboStats = new System.Windows.Forms.GroupBox();
            this.lblNulles = new System.Windows.Forms.Label();
            this.lblDefaites = new System.Windows.Forms.Label();
            this.lblVictoires = new System.Windows.Forms.Label();
            this.lblParties = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboSommaire = new System.Windows.Forms.GroupBox();
            this.gboFiltreDefaites = new System.Windows.Forms.GroupBox();
            this.txtMaxFiltreDefaites = new System.Windows.Forms.TextBox();
            this.txtMinFiltreDefaites = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkActiveFiltreDefaites = new System.Windows.Forms.CheckBox();
            this.gboFiltreVictoires = new System.Windows.Forms.GroupBox();
            this.txtMaxFiltreVictoires = new System.Windows.Forms.TextBox();
            this.txtMinFiltreVictoires = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.lstRencontres = new System.Windows.Forms.ListBox();
            this.gboDivision.SuspendLayout();
            this.gboEquipes.SuspendLayout();
            this.gboStats.SuspendLayout();
            this.gboSommaire.SuspendLayout();
            this.gboFiltreDefaites.SuspendLayout();
            this.gboFiltreVictoires.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Enabled = false;
            this.btnFiltrer.Location = new System.Drawing.Point(835, 63);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(180, 82);
            this.btnFiltrer.TabIndex = 0;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(1029, 63);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(180, 82);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.Location = new System.Drawing.Point(835, 589);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(374, 95);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer Rapport";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // gboDivision
            // 
            this.gboDivision.Controls.Add(this.optToutes);
            this.gboDivision.Controls.Add(this.optPacifique);
            this.gboDivision.Controls.Add(this.optMetro);
            this.gboDivision.Controls.Add(this.optCentral);
            this.gboDivision.Controls.Add(this.optAtlantique);
            this.gboDivision.Location = new System.Drawing.Point(42, 47);
            this.gboDivision.Name = "gboDivision";
            this.gboDivision.Size = new System.Drawing.Size(462, 327);
            this.gboDivision.TabIndex = 3;
            this.gboDivision.TabStop = false;
            this.gboDivision.Text = "Divisions:";
            // 
            // optToutes
            // 
            this.optToutes.AutoSize = true;
            this.optToutes.Checked = true;
            this.optToutes.Location = new System.Drawing.Point(7, 268);
            this.optToutes.Name = "optToutes";
            this.optToutes.Size = new System.Drawing.Size(139, 36);
            this.optToutes.TabIndex = 5;
            this.optToutes.TabStop = true;
            this.optToutes.Text = "Toutes";
            this.optToutes.UseVisualStyleBackColor = true;
            this.optToutes.CheckedChanged += new System.EventHandler(this.optToutes_CheckedChanged);
            // 
            // optPacifique
            // 
            this.optPacifique.AutoSize = true;
            this.optPacifique.Location = new System.Drawing.Point(6, 215);
            this.optPacifique.Name = "optPacifique";
            this.optPacifique.Size = new System.Drawing.Size(171, 36);
            this.optPacifique.TabIndex = 4;
            this.optPacifique.TabStop = true;
            this.optPacifique.Text = "Pacifique";
            this.optPacifique.UseVisualStyleBackColor = true;
            this.optPacifique.CheckedChanged += new System.EventHandler(this.optPacifique_CheckedChanged);
            // 
            // optMetro
            // 
            this.optMetro.AutoSize = true;
            this.optMetro.Location = new System.Drawing.Point(6, 161);
            this.optMetro.Name = "optMetro";
            this.optMetro.Size = new System.Drawing.Size(233, 36);
            this.optMetro.TabIndex = 3;
            this.optMetro.TabStop = true;
            this.optMetro.Text = "Métropolitaine";
            this.optMetro.UseVisualStyleBackColor = true;
            this.optMetro.CheckedChanged += new System.EventHandler(this.optMetro_CheckedChanged);
            // 
            // optCentral
            // 
            this.optCentral.AutoSize = true;
            this.optCentral.Location = new System.Drawing.Point(6, 108);
            this.optCentral.Name = "optCentral";
            this.optCentral.Size = new System.Drawing.Size(144, 36);
            this.optCentral.TabIndex = 2;
            this.optCentral.TabStop = true;
            this.optCentral.Text = "Central";
            this.optCentral.UseVisualStyleBackColor = true;
            this.optCentral.CheckedChanged += new System.EventHandler(this.optCentral_CheckedChanged);
            // 
            // optAtlantique
            // 
            this.optAtlantique.AutoSize = true;
            this.optAtlantique.Location = new System.Drawing.Point(6, 49);
            this.optAtlantique.Name = "optAtlantique";
            this.optAtlantique.Size = new System.Drawing.Size(181, 36);
            this.optAtlantique.TabIndex = 1;
            this.optAtlantique.TabStop = true;
            this.optAtlantique.Text = "Atlantique";
            this.optAtlantique.UseVisualStyleBackColor = true;
            this.optAtlantique.CheckedChanged += new System.EventHandler(this.optAtlantique_CheckedChanged);
            // 
            // chkActiveFiltreVictoires
            // 
            this.chkActiveFiltreVictoires.AutoSize = true;
            this.chkActiveFiltreVictoires.Location = new System.Drawing.Point(158, 0);
            this.chkActiveFiltreVictoires.Name = "chkActiveFiltreVictoires";
            this.chkActiveFiltreVictoires.Size = new System.Drawing.Size(131, 36);
            this.chkActiveFiltreVictoires.TabIndex = 0;
            this.chkActiveFiltreVictoires.Text = "Activé";
            this.chkActiveFiltreVictoires.UseVisualStyleBackColor = true;
            this.chkActiveFiltreVictoires.CheckedChanged += new System.EventHandler(this.chkActiveFiltreVictoires_CheckedChanged);
            // 
            // gboEquipes
            // 
            this.gboEquipes.Controls.Add(this.lstEquipes);
            this.gboEquipes.Location = new System.Drawing.Point(49, 381);
            this.gboEquipes.Name = "gboEquipes";
            this.gboEquipes.Size = new System.Drawing.Size(455, 709);
            this.gboEquipes.TabIndex = 4;
            this.gboEquipes.TabStop = false;
            this.gboEquipes.Text = "Équipes";
            // 
            // lstEquipes
            // 
            this.lstEquipes.FormattingEnabled = true;
            this.lstEquipes.ItemHeight = 31;
            this.lstEquipes.Location = new System.Drawing.Point(7, 38);
            this.lstEquipes.Name = "lstEquipes";
            this.lstEquipes.Size = new System.Drawing.Size(442, 655);
            this.lstEquipes.TabIndex = 0;
            this.lstEquipes.SelectedIndexChanged += new System.EventHandler(this.lstEquipes_SelectedIndexChanged);
            // 
            // gboStats
            // 
            this.gboStats.Controls.Add(this.lblNulles);
            this.gboStats.Controls.Add(this.lblDefaites);
            this.gboStats.Controls.Add(this.lblVictoires);
            this.gboStats.Controls.Add(this.lblParties);
            this.gboStats.Controls.Add(this.label4);
            this.gboStats.Controls.Add(this.label3);
            this.gboStats.Controls.Add(this.label2);
            this.gboStats.Controls.Add(this.label1);
            this.gboStats.Location = new System.Drawing.Point(541, 47);
            this.gboStats.Name = "gboStats";
            this.gboStats.Size = new System.Drawing.Size(1230, 327);
            this.gboStats.TabIndex = 5;
            this.gboStats.TabStop = false;
            this.gboStats.Text = "Statistiques pour les \"";
            // 
            // lblNulles
            // 
            this.lblNulles.AutoSize = true;
            this.lblNulles.Location = new System.Drawing.Point(383, 257);
            this.lblNulles.Name = "lblNulles";
            this.lblNulles.Size = new System.Drawing.Size(31, 32);
            this.lblNulles.TabIndex = 7;
            this.lblNulles.Text = "0";
            // 
            // lblDefaites
            // 
            this.lblDefaites.AutoSize = true;
            this.lblDefaites.Location = new System.Drawing.Point(383, 190);
            this.lblDefaites.Name = "lblDefaites";
            this.lblDefaites.Size = new System.Drawing.Size(31, 32);
            this.lblDefaites.TabIndex = 6;
            this.lblDefaites.Text = "0";
            // 
            // lblVictoires
            // 
            this.lblVictoires.AutoSize = true;
            this.lblVictoires.Location = new System.Drawing.Point(383, 122);
            this.lblVictoires.Name = "lblVictoires";
            this.lblVictoires.Size = new System.Drawing.Size(31, 32);
            this.lblVictoires.TabIndex = 5;
            this.lblVictoires.Text = "0";
            // 
            // lblParties
            // 
            this.lblParties.AutoSize = true;
            this.lblParties.Location = new System.Drawing.Point(383, 53);
            this.lblParties.Name = "lblParties";
            this.lblParties.Size = new System.Drawing.Size(31, 32);
            this.lblParties.TabIndex = 4;
            this.lblParties.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nulles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Défaites:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Victoires:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Parties jouées:";
            // 
            // gboSommaire
            // 
            this.gboSommaire.Controls.Add(this.gboFiltreDefaites);
            this.gboSommaire.Controls.Add(this.gboFiltreVictoires);
            this.gboSommaire.Controls.Add(this.lblV);
            this.gboSommaire.Controls.Add(this.lstRencontres);
            this.gboSommaire.Controls.Add(this.btnFiltrer);
            this.gboSommaire.Controls.Add(this.btnEffacer);
            this.gboSommaire.Controls.Add(this.btnEnregistrer);
            this.gboSommaire.Location = new System.Drawing.Point(541, 381);
            this.gboSommaire.Name = "gboSommaire";
            this.gboSommaire.Size = new System.Drawing.Size(1230, 709);
            this.gboSommaire.TabIndex = 6;
            this.gboSommaire.TabStop = false;
            this.gboSommaire.Text = "Sommaire Rencontres";
            // 
            // gboFiltreDefaites
            // 
            this.gboFiltreDefaites.Controls.Add(this.txtMaxFiltreDefaites);
            this.gboFiltreDefaites.Controls.Add(this.txtMinFiltreDefaites);
            this.gboFiltreDefaites.Controls.Add(this.label7);
            this.gboFiltreDefaites.Controls.Add(this.label8);
            this.gboFiltreDefaites.Controls.Add(this.chkActiveFiltreDefaites);
            this.gboFiltreDefaites.Location = new System.Drawing.Point(835, 387);
            this.gboFiltreDefaites.Name = "gboFiltreDefaites";
            this.gboFiltreDefaites.Size = new System.Drawing.Size(374, 168);
            this.gboFiltreDefaites.TabIndex = 5;
            this.gboFiltreDefaites.TabStop = false;
            this.gboFiltreDefaites.Text = "Défaites";
            // 
            // txtMaxFiltreDefaites
            // 
            this.txtMaxFiltreDefaites.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaxFiltreDefaites.Enabled = false;
            this.txtMaxFiltreDefaites.Location = new System.Drawing.Point(97, 111);
            this.txtMaxFiltreDefaites.Name = "txtMaxFiltreDefaites";
            this.txtMaxFiltreDefaites.Size = new System.Drawing.Size(271, 38);
            this.txtMaxFiltreDefaites.TabIndex = 3;
            this.txtMaxFiltreDefaites.Text = "-1";
            // 
            // txtMinFiltreDefaites
            // 
            this.txtMinFiltreDefaites.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMinFiltreDefaites.Enabled = false;
            this.txtMinFiltreDefaites.Location = new System.Drawing.Point(97, 51);
            this.txtMinFiltreDefaites.Name = "txtMinFiltreDefaites";
            this.txtMinFiltreDefaites.Size = new System.Drawing.Size(271, 38);
            this.txtMinFiltreDefaites.TabIndex = 3;
            this.txtMinFiltreDefaites.Text = "-1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Min:";
            // 
            // chkActiveFiltreDefaites
            // 
            this.chkActiveFiltreDefaites.AutoSize = true;
            this.chkActiveFiltreDefaites.Location = new System.Drawing.Point(158, 0);
            this.chkActiveFiltreDefaites.Name = "chkActiveFiltreDefaites";
            this.chkActiveFiltreDefaites.Size = new System.Drawing.Size(131, 36);
            this.chkActiveFiltreDefaites.TabIndex = 0;
            this.chkActiveFiltreDefaites.Text = "Activé";
            this.chkActiveFiltreDefaites.UseVisualStyleBackColor = true;
            this.chkActiveFiltreDefaites.CheckedChanged += new System.EventHandler(this.chkActiveFiltreDefaites_CheckedChanged);
            // 
            // gboFiltreVictoires
            // 
            this.gboFiltreVictoires.Controls.Add(this.txtMaxFiltreVictoires);
            this.gboFiltreVictoires.Controls.Add(this.txtMinFiltreVictoires);
            this.gboFiltreVictoires.Controls.Add(this.label6);
            this.gboFiltreVictoires.Controls.Add(this.label5);
            this.gboFiltreVictoires.Controls.Add(this.chkActiveFiltreVictoires);
            this.gboFiltreVictoires.Location = new System.Drawing.Point(835, 186);
            this.gboFiltreVictoires.Name = "gboFiltreVictoires";
            this.gboFiltreVictoires.Size = new System.Drawing.Size(368, 168);
            this.gboFiltreVictoires.TabIndex = 5;
            this.gboFiltreVictoires.TabStop = false;
            this.gboFiltreVictoires.Text = "Victoires";
            // 
            // txtMaxFiltreVictoires
            // 
            this.txtMaxFiltreVictoires.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaxFiltreVictoires.Enabled = false;
            this.txtMaxFiltreVictoires.Location = new System.Drawing.Point(97, 111);
            this.txtMaxFiltreVictoires.Name = "txtMaxFiltreVictoires";
            this.txtMaxFiltreVictoires.Size = new System.Drawing.Size(265, 38);
            this.txtMaxFiltreVictoires.TabIndex = 3;
            this.txtMaxFiltreVictoires.Text = "-1";
            // 
            // txtMinFiltreVictoires
            // 
            this.txtMinFiltreVictoires.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMinFiltreVictoires.Enabled = false;
            this.txtMinFiltreVictoires.Location = new System.Drawing.Point(97, 51);
            this.txtMinFiltreVictoires.Name = "txtMinFiltreVictoires";
            this.txtMinFiltreVictoires.Size = new System.Drawing.Size(265, 38);
            this.txtMinFiltreVictoires.TabIndex = 3;
            this.txtMinFiltreVictoires.Text = "-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Min:";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(579, 54);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(120, 32);
            this.lblV.TabIndex = 4;
            this.lblV.Text = "V - D - N";
            // 
            // lstRencontres
            // 
            this.lstRencontres.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRencontres.FormattingEnabled = true;
            this.lstRencontres.ItemHeight = 36;
            this.lstRencontres.Location = new System.Drawing.Point(12, 113);
            this.lstRencontres.Name = "lstRencontres";
            this.lstRencontres.Size = new System.Drawing.Size(731, 580);
            this.lstRencontres.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1866, 1312);
            this.Controls.Add(this.gboSommaire);
            this.Controls.Add(this.gboStats);
            this.Controls.Add(this.gboEquipes);
            this.Controls.Add(this.gboDivision);
            this.Name = "Form1";
            this.Text = "Statistiques NHL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboDivision.ResumeLayout(false);
            this.gboDivision.PerformLayout();
            this.gboEquipes.ResumeLayout(false);
            this.gboStats.ResumeLayout(false);
            this.gboStats.PerformLayout();
            this.gboSommaire.ResumeLayout(false);
            this.gboSommaire.PerformLayout();
            this.gboFiltreDefaites.ResumeLayout(false);
            this.gboFiltreDefaites.PerformLayout();
            this.gboFiltreVictoires.ResumeLayout(false);
            this.gboFiltreVictoires.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.GroupBox gboDivision;
        private System.Windows.Forms.RadioButton optAtlantique;
        private System.Windows.Forms.CheckBox chkActiveFiltreVictoires;
        private System.Windows.Forms.RadioButton optToutes;
        private System.Windows.Forms.RadioButton optPacifique;
        private System.Windows.Forms.RadioButton optMetro;
        private System.Windows.Forms.RadioButton optCentral;
        private System.Windows.Forms.GroupBox gboEquipes;
        private System.Windows.Forms.ListBox lstEquipes;
        private System.Windows.Forms.GroupBox gboStats;
        private System.Windows.Forms.Label lblNulles;
        private System.Windows.Forms.Label lblDefaites;
        private System.Windows.Forms.Label lblVictoires;
        private System.Windows.Forms.Label lblParties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboSommaire;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.ListBox lstRencontres;
        private System.Windows.Forms.GroupBox gboFiltreVictoires;
        private System.Windows.Forms.GroupBox gboFiltreDefaites;
        private System.Windows.Forms.TextBox txtMaxFiltreDefaites;
        private System.Windows.Forms.TextBox txtMinFiltreDefaites;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkActiveFiltreDefaites;
        private System.Windows.Forms.TextBox txtMaxFiltreVictoires;
        private System.Windows.Forms.TextBox txtMinFiltreVictoires;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

