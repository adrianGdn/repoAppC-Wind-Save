namespace Vues.Cabinets
{
    partial class CabinetRU2
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
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblVoirVisite = new System.Windows.Forms.Label();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblVilleCabinet = new System.Windows.Forms.Label();
            this.lblCPCabinet = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(105, 49);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(255, 21);
            this.cboxCP.TabIndex = 70;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(13, 48);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 69;
            this.lblCP.Text = "Code Postal";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(438, 49);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(255, 21);
            this.cboxVille.TabIndex = 68;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(394, 52);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 67;
            this.lblVille.Text = "Ville";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(106, 85);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(255, 21);
            this.cboxMedecin.TabIndex = 66;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(34, 87);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 65;
            this.lblMedecin.Text = "Médecin";
            // 
            // lblVoirVisite
            // 
            this.lblVoirVisite.AutoSize = true;
            this.lblVoirVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirVisite.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirVisite.Location = new System.Drawing.Point(12, 9);
            this.lblVoirVisite.Name = "lblVoirVisite";
            this.lblVoirVisite.Size = new System.Drawing.Size(295, 25);
            this.lblVoirVisite.TabIndex = 64;
            this.lblVoirVisite.Text = "Voir ou modifier un cabinet";
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(353, 189);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(166, 19);
            this.lblCabinet.TabIndex = 73;
            this.lblCabinet.Text = "Choisissez votre cabinet";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(210, 211);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(450, 21);
            this.cboxCabinet.TabIndex = 74;
            // 
            // lblVilleCabinet
            // 
            this.lblVilleCabinet.AutoSize = true;
            this.lblVilleCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblVilleCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVilleCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVilleCabinet.Location = new System.Drawing.Point(74, 283);
            this.lblVilleCabinet.Name = "lblVilleCabinet";
            this.lblVilleCabinet.Size = new System.Drawing.Size(38, 19);
            this.lblVilleCabinet.TabIndex = 75;
            this.lblVilleCabinet.Text = "Ville";
            // 
            // lblCPCabinet
            // 
            this.lblCPCabinet.AutoSize = true;
            this.lblCPCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCPCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCPCabinet.Location = new System.Drawing.Point(26, 318);
            this.lblCPCabinet.Name = "lblCPCabinet";
            this.lblCPCabinet.Size = new System.Drawing.Size(86, 19);
            this.lblCPCabinet.TabIndex = 76;
            this.lblCPCabinet.Text = "Code Postal";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAdresse.Location = new System.Drawing.Point(51, 350);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(61, 19);
            this.lblAdresse.TabIndex = 77;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(118, 284);
            this.txtVille.Name = "txtVille";
            this.txtVille.ReadOnly = true;
            this.txtVille.Size = new System.Drawing.Size(194, 20);
            this.txtVille.TabIndex = 78;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(118, 319);
            this.txtCP.Name = "txtCP";
            this.txtCP.ReadOnly = true;
            this.txtCP.Size = new System.Drawing.Size(134, 20);
            this.txtCP.TabIndex = 79;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(118, 351);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(421, 20);
            this.txtAdresse.TabIndex = 80;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(617, 285);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(163, 54);
            this.btnModifier.TabIndex = 81;
            this.btnModifier.Text = "Modifier le cabinet";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // CabinetRU2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 475);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblCPCabinet);
            this.Controls.Add(this.lblVilleCabinet);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.cboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.cboxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.cboxMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.lblVoirVisite);
            this.Name = "CabinetRU2";
            this.Text = "CabinetRU2";
            this.Load += new System.EventHandler(this.CabinetRU2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label lblVoirVisite;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblVilleCabinet;
        private System.Windows.Forms.Label lblCPCabinet;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Button btnModifier;
    }
}