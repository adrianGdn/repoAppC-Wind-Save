namespace Vues.Médecins
{
    partial class MedecinRU2
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
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cboxVisiteur = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCabinetDuMedecin = new System.Windows.Forms.Label();
            this.lblVisiteurAssocie = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCabinet = new System.Windows.Forms.TextBox();
            this.txtVisiteur = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVoirVisite
            // 
            this.lblVoirVisite.AutoSize = true;
            this.lblVoirVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirVisite.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirVisite.Location = new System.Drawing.Point(12, 9);
            this.lblVoirVisite.Name = "lblVoirVisite";
            this.lblVoirVisite.Size = new System.Drawing.Size(287, 25);
            this.lblVoirVisite.TabIndex = 39;
            this.lblVoirVisite.Text = "Voir ou modifier une visite";
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(129, 53);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(255, 21);
            this.cboxCP.TabIndex = 61;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(37, 52);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 60;
            this.lblCP.Text = "Code Postal";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(462, 53);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(255, 21);
            this.cboxVille.TabIndex = 59;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(418, 56);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 58;
            this.lblVille.Text = "Ville";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(130, 89);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(255, 21);
            this.cboxCabinet.TabIndex = 57;
            this.cboxCabinet.SelectedIndexChanged += new System.EventHandler(this.cboxCabinet_SelectedIndexChanged);
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(65, 92);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 56;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.SteelBlue;
            this.lblVisiteur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteur.Location = new System.Drawing.Point(12, 123);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(112, 19);
            this.lblVisiteur.TabIndex = 62;
            this.lblVisiteur.Text = "Visiteur associé";
            // 
            // cboxVisiteur
            // 
            this.cboxVisiteur.FormattingEnabled = true;
            this.cboxVisiteur.Location = new System.Drawing.Point(130, 123);
            this.cboxVisiteur.Name = "cboxVisiteur";
            this.cboxVisiteur.Size = new System.Drawing.Size(338, 21);
            this.cboxVisiteur.TabIndex = 63;
            this.cboxVisiteur.SelectedIndexChanged += new System.EventHandler(this.cboxVisiteur_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(316, 180);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(152, 19);
            this.lblMedecin.TabIndex = 64;
            this.lblMedecin.Text = "Choisissez le médecin";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(204, 202);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(363, 21);
            this.cboxMedecin.TabIndex = 65;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNom.Location = new System.Drawing.Point(99, 276);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 19);
            this.lblNom.TabIndex = 66;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrenom.Location = new System.Drawing.Point(80, 306);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 19);
            this.lblPrenom.TabIndex = 67;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblCabinetDuMedecin
            // 
            this.lblCabinetDuMedecin.AutoSize = true;
            this.lblCabinetDuMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinetDuMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinetDuMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinetDuMedecin.Location = new System.Drawing.Point(79, 339);
            this.lblCabinetDuMedecin.Name = "lblCabinetDuMedecin";
            this.lblCabinetDuMedecin.Size = new System.Drawing.Size(59, 19);
            this.lblCabinetDuMedecin.TabIndex = 68;
            this.lblCabinetDuMedecin.Text = "Cabinet";
            // 
            // lblVisiteurAssocie
            // 
            this.lblVisiteurAssocie.AutoSize = true;
            this.lblVisiteurAssocie.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteurAssocie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteurAssocie.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteurAssocie.Location = new System.Drawing.Point(26, 371);
            this.lblVisiteurAssocie.Name = "lblVisiteurAssocie";
            this.lblVisiteurAssocie.Size = new System.Drawing.Size(112, 19);
            this.lblVisiteurAssocie.TabIndex = 69;
            this.lblVisiteurAssocie.Text = "Visiteur associé";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(144, 277);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(240, 20);
            this.txtNom.TabIndex = 70;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(144, 307);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(240, 20);
            this.txtPrenom.TabIndex = 71;
            // 
            // txtCabinet
            // 
            this.txtCabinet.Location = new System.Drawing.Point(144, 340);
            this.txtCabinet.Name = "txtCabinet";
            this.txtCabinet.ReadOnly = true;
            this.txtCabinet.Size = new System.Drawing.Size(240, 20);
            this.txtCabinet.TabIndex = 72;
            // 
            // txtVisiteur
            // 
            this.txtVisiteur.Location = new System.Drawing.Point(144, 372);
            this.txtVisiteur.Name = "txtVisiteur";
            this.txtVisiteur.ReadOnly = true;
            this.txtVisiteur.Size = new System.Drawing.Size(240, 20);
            this.txtVisiteur.TabIndex = 73;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(492, 306);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(163, 54);
            this.btnModifier.TabIndex = 75;
            this.btnModifier.Text = "Modifier le médecin";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // MedecinRU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 464);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtVisiteur);
            this.Controls.Add(this.txtCabinet);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblVisiteurAssocie);
            this.Controls.Add(this.lblCabinetDuMedecin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cboxMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboxVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.cboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.cboxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblVoirVisite);
            this.Name = "MedecinRU2";
            this.Text = "MedecinRU2";
            this.Load += new System.EventHandler(this.MedecinRU2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoirVisite;
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.ComboBox cboxVisiteur;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCabinetDuMedecin;
        private System.Windows.Forms.Label lblVisiteurAssocie;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCabinet;
        private System.Windows.Forms.TextBox txtVisiteur;
        private System.Windows.Forms.Button btnModifier;
    }
}