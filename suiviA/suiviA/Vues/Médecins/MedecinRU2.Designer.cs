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
            this.lblVoirMedecin = new System.Windows.Forms.Label();
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
            // lblVoirMedecin
            // 
            this.lblVoirMedecin.AutoSize = true;
            this.lblVoirMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirMedecin.Location = new System.Drawing.Point(18, 14);
            this.lblVoirMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoirMedecin.Name = "lblVoirMedecin";
            this.lblVoirMedecin.Size = new System.Drawing.Size(444, 37);
            this.lblVoirMedecin.TabIndex = 39;
            this.lblVoirMedecin.Text = "Voir ou modifier un médecin";
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(194, 82);
            this.cboxCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(380, 28);
            this.cboxCP.TabIndex = 61;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(56, 80);
            this.lblCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(129, 29);
            this.lblCP.TabIndex = 60;
            this.lblCP.Text = "Code Postal";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(693, 82);
            this.cboxVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(380, 28);
            this.cboxVille.TabIndex = 59;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(627, 86);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(57, 29);
            this.lblVille.TabIndex = 58;
            this.lblVille.Text = "Ville";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(195, 137);
            this.cboxCabinet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(380, 28);
            this.cboxCabinet.TabIndex = 57;
            this.cboxCabinet.SelectedIndexChanged += new System.EventHandler(this.cboxCabinet_SelectedIndexChanged);
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(98, 142);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(90, 29);
            this.lblCabinet.TabIndex = 56;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.SteelBlue;
            this.lblVisiteur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteur.Location = new System.Drawing.Point(18, 189);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(165, 29);
            this.lblVisiteur.TabIndex = 62;
            this.lblVisiteur.Text = "Visiteur associé";
            // 
            // cboxVisiteur
            // 
            this.cboxVisiteur.FormattingEnabled = true;
            this.cboxVisiteur.Location = new System.Drawing.Point(195, 189);
            this.cboxVisiteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxVisiteur.Name = "cboxVisiteur";
            this.cboxVisiteur.Size = new System.Drawing.Size(505, 28);
            this.cboxVisiteur.TabIndex = 63;
            this.cboxVisiteur.SelectedIndexChanged += new System.EventHandler(this.cboxVisiteur_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(474, 277);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(225, 29);
            this.lblMedecin.TabIndex = 64;
            this.lblMedecin.Text = "Choisissez le médecin";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(306, 311);
            this.cboxMedecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(542, 28);
            this.cboxMedecin.TabIndex = 65;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNom.Location = new System.Drawing.Point(148, 425);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 29);
            this.lblNom.TabIndex = 66;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrenom.Location = new System.Drawing.Point(120, 471);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(90, 29);
            this.lblPrenom.TabIndex = 67;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblCabinetDuMedecin
            // 
            this.lblCabinetDuMedecin.AutoSize = true;
            this.lblCabinetDuMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinetDuMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinetDuMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinetDuMedecin.Location = new System.Drawing.Point(118, 522);
            this.lblCabinetDuMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinetDuMedecin.Name = "lblCabinetDuMedecin";
            this.lblCabinetDuMedecin.Size = new System.Drawing.Size(90, 29);
            this.lblCabinetDuMedecin.TabIndex = 68;
            this.lblCabinetDuMedecin.Text = "Cabinet";
            // 
            // lblVisiteurAssocie
            // 
            this.lblVisiteurAssocie.AutoSize = true;
            this.lblVisiteurAssocie.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteurAssocie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteurAssocie.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteurAssocie.Location = new System.Drawing.Point(39, 571);
            this.lblVisiteurAssocie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteurAssocie.Name = "lblVisiteurAssocie";
            this.lblVisiteurAssocie.Size = new System.Drawing.Size(165, 29);
            this.lblVisiteurAssocie.TabIndex = 69;
            this.lblVisiteurAssocie.Text = "Visiteur associé";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(216, 426);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(358, 26);
            this.txtNom.TabIndex = 70;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(216, 472);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(358, 26);
            this.txtPrenom.TabIndex = 71;
            // 
            // txtCabinet
            // 
            this.txtCabinet.Location = new System.Drawing.Point(216, 523);
            this.txtCabinet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCabinet.Name = "txtCabinet";
            this.txtCabinet.ReadOnly = true;
            this.txtCabinet.Size = new System.Drawing.Size(358, 26);
            this.txtCabinet.TabIndex = 72;
            // 
            // txtVisiteur
            // 
            this.txtVisiteur.Location = new System.Drawing.Point(216, 572);
            this.txtVisiteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVisiteur.Name = "txtVisiteur";
            this.txtVisiteur.ReadOnly = true;
            this.txtVisiteur.Size = new System.Drawing.Size(358, 26);
            this.txtVisiteur.TabIndex = 73;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(738, 471);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(244, 83);
            this.btnModifier.TabIndex = 75;
            this.btnModifier.Text = "Modifier le médecin";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // MedecinRU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 714);
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
            this.Controls.Add(this.lblVoirMedecin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MedecinRU2";
            this.Text = "MedecinRU2";
            this.Load += new System.EventHandler(this.MedecinRU2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoirMedecin;
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