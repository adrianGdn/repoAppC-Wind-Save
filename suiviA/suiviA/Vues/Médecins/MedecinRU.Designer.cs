namespace Vues
{
    partial class MedecinRU
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvListeMedecin = new System.Windows.Forms.DataGridView();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblVoirVisite = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(244, 541);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(163, 54);
            this.btnModifier.TabIndex = 51;
            this.btnModifier.Text = "Modifier le médecin";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(45, 541);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(163, 54);
            this.btnRechercher.TabIndex = 50;
            this.btnRechercher.Text = "Rechercher le médecin";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgvListeMedecin
            // 
            this.dgvListeMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeMedecin.Location = new System.Drawing.Point(476, 194);
            this.dgvListeMedecin.Name = "dgvListeMedecin";
            this.dgvListeMedecin.ReadOnly = true;
            this.dgvListeMedecin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeMedecin.Size = new System.Drawing.Size(431, 417);
            this.dgvListeMedecin.TabIndex = 49;
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(433, 61);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(255, 21);
            this.cboxVille.TabIndex = 48;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(389, 64);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 47;
            this.lblVille.Text = "Ville";
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(488, 172);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 41;
            this.lblMedecin.Text = "Médecin";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(100, 95);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(255, 21);
            this.cboxCabinet.TabIndex = 40;
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(35, 98);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 39;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblVoirVisite
            // 
            this.lblVoirVisite.AutoSize = true;
            this.lblVoirVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirVisite.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirVisite.Location = new System.Drawing.Point(7, 12);
            this.lblVoirVisite.Name = "lblVoirVisite";
            this.lblVoirVisite.Size = new System.Drawing.Size(287, 25);
            this.lblVoirVisite.TabIndex = 38;
            this.lblVoirVisite.Text = "Voir ou modifier une visite";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(12, 194);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteur.Size = new System.Drawing.Size(415, 326);
            this.dgvVisiteur.TabIndex = 53;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteur.Location = new System.Drawing.Point(12, 172);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(112, 19);
            this.lblVisiteur.TabIndex = 52;
            this.lblVisiteur.Text = "Visiteur associé";
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(100, 61);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(255, 21);
            this.cboxCP.TabIndex = 55;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(8, 60);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 54;
            this.lblCP.Text = "Code Postal";
            // 
            // MedecinRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 658);
            this.Controls.Add(this.cboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvListeMedecin);
            this.Controls.Add(this.cboxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblVoirVisite);
            this.Name = "MedecinRU";
            this.Text = "MedecinRU";
            this.Load += new System.EventHandler(this.MedecinRU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvListeMedecin;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblVoirVisite;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
    }
}