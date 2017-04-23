namespace Vues.Visites
{
    partial class VisitesRUD2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVoirVisite = new System.Windows.Forms.Label();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.grpboxFiltre = new System.Windows.Forms.GroupBox();
            this.cboxVisites = new System.Windows.Forms.ComboBox();
            this.lblVisites = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblDateVisite = new System.Windows.Forms.Label();
            this.lblVisiteProgrammee = new System.Windows.Forms.Label();
            this.txtHeureDepart = new System.Windows.Forms.TextBox();
            this.lblHeureDepart = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.txtHeureArrivee = new System.Windows.Forms.TextBox();
            this.lblHeureArrivee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateVisite = new System.Windows.Forms.TextBox();
            this.txtVisiteProgrammee = new System.Windows.Forms.TextBox();
            this.txtMedecin = new System.Windows.Forms.TextBox();
            this.grpboxFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoirVisite
            // 
            this.lblVoirVisite.AutoSize = true;
            this.lblVoirVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirVisite.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirVisite.Location = new System.Drawing.Point(16, 13);
            this.lblVoirVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoirVisite.Name = "lblVoirVisite";
            this.lblVoirVisite.Size = new System.Drawing.Size(287, 25);
            this.lblVoirVisite.TabIndex = 24;
            this.lblVoirVisite.Text = "Voir ou modifier une visite";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(575, 51);
            this.cboxVille.Margin = new System.Windows.Forms.Padding(4);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(339, 27);
            this.cboxVille.TabIndex = 41;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(516, 56);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 40;
            this.lblVille.Text = "Ville";
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(131, 57);
            this.cboxCP.Margin = new System.Windows.Forms.Padding(4);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(339, 27);
            this.cboxCP.TabIndex = 39;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(8, 56);
            this.lblCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 38;
            this.lblCP.Text = "Code Postal";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(575, 107);
            this.cboxMedecin.Margin = new System.Windows.Forms.Padding(4);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(339, 27);
            this.cboxMedecin.TabIndex = 37;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(489, 110);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 36;
            this.lblMedecin.Text = "Médecin";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(131, 107);
            this.cboxCabinet.Margin = new System.Windows.Forms.Padding(4);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(339, 27);
            this.cboxCabinet.TabIndex = 35;
            this.cboxCabinet.SelectedIndexChanged += new System.EventHandler(this.cboxCabinet_SelectedIndexChanged);
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.Color.White;
            this.lblCabinet.Location = new System.Drawing.Point(35, 110);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 34;
            this.lblCabinet.Text = "Cabinet";
            // 
            // grpboxFiltre
            // 
            this.grpboxFiltre.BackColor = System.Drawing.Color.Transparent;
            this.grpboxFiltre.Controls.Add(this.lblCP);
            this.grpboxFiltre.Controls.Add(this.cboxVille);
            this.grpboxFiltre.Controls.Add(this.lblCabinet);
            this.grpboxFiltre.Controls.Add(this.lblVille);
            this.grpboxFiltre.Controls.Add(this.cboxCabinet);
            this.grpboxFiltre.Controls.Add(this.cboxCP);
            this.grpboxFiltre.Controls.Add(this.lblMedecin);
            this.grpboxFiltre.Controls.Add(this.cboxMedecin);
            this.grpboxFiltre.ForeColor = System.Drawing.Color.White;
            this.grpboxFiltre.Location = new System.Drawing.Point(23, 72);
            this.grpboxFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxFiltre.Name = "grpboxFiltre";
            this.grpboxFiltre.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxFiltre.Size = new System.Drawing.Size(969, 167);
            this.grpboxFiltre.TabIndex = 42;
            this.grpboxFiltre.TabStop = false;
            this.grpboxFiltre.Text = "Filtre";
            // 
            // cboxVisites
            // 
            this.cboxVisites.FormattingEnabled = true;
            this.cboxVisites.Location = new System.Drawing.Point(115, 295);
            this.cboxVisites.Margin = new System.Windows.Forms.Padding(4);
            this.cboxVisites.Name = "cboxVisites";
            this.cboxVisites.Size = new System.Drawing.Size(773, 27);
            this.cboxVisites.TabIndex = 43;
            this.cboxVisites.SelectedIndexChanged += new System.EventHandler(this.cboxVisites_SelectedIndexChanged);
            // 
            // lblVisites
            // 
            this.lblVisites.AutoSize = true;
            this.lblVisites.BackColor = System.Drawing.Color.Transparent;
            this.lblVisites.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisites.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisites.Location = new System.Drawing.Point(405, 263);
            this.lblVisites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisites.Name = "lblVisites";
            this.lblVisites.Size = new System.Drawing.Size(153, 19);
            this.lblVisites.TabIndex = 44;
            this.lblVisites.Text = "Choisissez votre visite";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSupprimer.Location = new System.Drawing.Point(775, 518);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(217, 79);
            this.btnSupprimer.TabIndex = 46;
            this.btnSupprimer.Text = "Supprimer la visite";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModifier.Location = new System.Drawing.Point(775, 431);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(217, 79);
            this.btnModifier.TabIndex = 45;
            this.btnModifier.Text = "Modifier la visite";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblDateVisite
            // 
            this.lblDateVisite.AutoSize = true;
            this.lblDateVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblDateVisite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateVisite.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateVisite.Location = new System.Drawing.Point(17, 488);
            this.lblDateVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateVisite.Name = "lblDateVisite";
            this.lblDateVisite.Size = new System.Drawing.Size(123, 19);
            this.lblDateVisite.TabIndex = 47;
            this.lblDateVisite.Text = "Date de la visite :";
            // 
            // lblVisiteProgrammee
            // 
            this.lblVisiteProgrammee.AutoSize = true;
            this.lblVisiteProgrammee.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteProgrammee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteProgrammee.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteProgrammee.Location = new System.Drawing.Point(19, 548);
            this.lblVisiteProgrammee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteProgrammee.Name = "lblVisiteProgrammee";
            this.lblVisiteProgrammee.Size = new System.Drawing.Size(143, 19);
            this.lblVisiteProgrammee.TabIndex = 48;
            this.lblVisiteProgrammee.Text = "Visite programmée ?";
            // 
            // txtHeureDepart
            // 
            this.txtHeureDepart.Location = new System.Drawing.Point(540, 544);
            this.txtHeureDepart.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeureDepart.MaxLength = 2;
            this.txtHeureDepart.Name = "txtHeureDepart";
            this.txtHeureDepart.ReadOnly = true;
            this.txtHeureDepart.Size = new System.Drawing.Size(76, 27);
            this.txtHeureDepart.TabIndex = 58;
            // 
            // lblHeureDepart
            // 
            this.lblHeureDepart.AutoSize = true;
            this.lblHeureDepart.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDepart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureDepart.ForeColor = System.Drawing.Color.White;
            this.lblHeureDepart.Location = new System.Drawing.Point(405, 546);
            this.lblHeureDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeureDepart.Name = "lblHeureDepart";
            this.lblHeureDepart.Size = new System.Drawing.Size(114, 19);
            this.lblHeureDepart.TabIndex = 57;
            this.lblHeureDepart.Text = "Heure de départ";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(540, 485);
            this.txtHeureDebut.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeureDebut.MaxLength = 2;
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.ReadOnly = true;
            this.txtHeureDebut.Size = new System.Drawing.Size(76, 27);
            this.txtHeureDebut.TabIndex = 54;
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDebut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureDebut.ForeColor = System.Drawing.Color.White;
            this.lblHeureDebut.Location = new System.Drawing.Point(405, 488);
            this.lblHeureDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(109, 19);
            this.lblHeureDebut.TabIndex = 53;
            this.lblHeureDebut.Text = "Heure de début";
            // 
            // txtHeureArrivee
            // 
            this.txtHeureArrivee.Location = new System.Drawing.Point(540, 425);
            this.txtHeureArrivee.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeureArrivee.MaxLength = 2;
            this.txtHeureArrivee.Name = "txtHeureArrivee";
            this.txtHeureArrivee.ReadOnly = true;
            this.txtHeureArrivee.Size = new System.Drawing.Size(76, 27);
            this.txtHeureArrivee.TabIndex = 50;
            // 
            // lblHeureArrivee
            // 
            this.lblHeureArrivee.AutoSize = true;
            this.lblHeureArrivee.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureArrivee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureArrivee.ForeColor = System.Drawing.Color.White;
            this.lblHeureArrivee.Location = new System.Drawing.Point(405, 428);
            this.lblHeureArrivee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeureArrivee.Name = "lblHeureArrivee";
            this.lblHeureArrivee.Size = new System.Drawing.Size(109, 19);
            this.lblHeureArrivee.TabIndex = 49;
            this.lblHeureArrivee.Text = "Heure d\'arrivée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(19, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Médecin";
            // 
            // txtDateVisite
            // 
            this.txtDateVisite.Location = new System.Drawing.Point(154, 486);
            this.txtDateVisite.Name = "txtDateVisite";
            this.txtDateVisite.ReadOnly = true;
            this.txtDateVisite.Size = new System.Drawing.Size(123, 27);
            this.txtDateVisite.TabIndex = 62;
            // 
            // txtVisiteProgrammee
            // 
            this.txtVisiteProgrammee.Location = new System.Drawing.Point(169, 545);
            this.txtVisiteProgrammee.Name = "txtVisiteProgrammee";
            this.txtVisiteProgrammee.ReadOnly = true;
            this.txtVisiteProgrammee.Size = new System.Drawing.Size(44, 27);
            this.txtVisiteProgrammee.TabIndex = 63;
            // 
            // txtMedecin
            // 
            this.txtMedecin.Location = new System.Drawing.Point(91, 428);
            this.txtMedecin.Name = "txtMedecin";
            this.txtMedecin.ReadOnly = true;
            this.txtMedecin.Size = new System.Drawing.Size(231, 27);
            this.txtMedecin.TabIndex = 64;
            // 
            // VisitesRUD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 699);
            this.Controls.Add(this.txtMedecin);
            this.Controls.Add(this.txtVisiteProgrammee);
            this.Controls.Add(this.txtDateVisite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeureDepart);
            this.Controls.Add(this.lblHeureDepart);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.lblHeureDebut);
            this.Controls.Add(this.txtHeureArrivee);
            this.Controls.Add(this.lblHeureArrivee);
            this.Controls.Add(this.lblVisiteProgrammee);
            this.Controls.Add(this.lblDateVisite);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblVisites);
            this.Controls.Add(this.cboxVisites);
            this.Controls.Add(this.grpboxFiltre);
            this.Controls.Add(this.lblVoirVisite);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitesRUD2";
            this.Text = "Voir ou modifier une visite";
            this.Load += new System.EventHandler(this.VisitesRUD2_Load);
            this.grpboxFiltre.ResumeLayout(false);
            this.grpboxFiltre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoirVisite;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.GroupBox grpboxFiltre;
        private System.Windows.Forms.ComboBox cboxVisites;
        private System.Windows.Forms.Label lblVisites;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblDateVisite;
        private System.Windows.Forms.Label lblVisiteProgrammee;
        private System.Windows.Forms.TextBox txtHeureDepart;
        private System.Windows.Forms.Label lblHeureDepart;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.TextBox txtHeureArrivee;
        private System.Windows.Forms.Label lblHeureArrivee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateVisite;
        private System.Windows.Forms.TextBox txtVisiteProgrammee;
        private System.Windows.Forms.TextBox txtMedecin;
    }
}