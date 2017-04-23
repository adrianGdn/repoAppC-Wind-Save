namespace Vues.Cabinets
{
    partial class CabinetRU
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
            this.lblVille = new System.Windows.Forms.Label();
            this.lblVoirModifierCabinet = new System.Windows.Forms.Label();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.dgvMedecin = new System.Windows.Forms.DataGridView();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.dgvCabinet = new System.Windows.Forms.DataGridView();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(55, 87);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 54;
            this.lblVille.Text = "Ville";
            // 
            // lblVoirModifierCabinet
            // 
            this.lblVoirModifierCabinet.AutoSize = true;
            this.lblVoirModifierCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblVoirModifierCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoirModifierCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVoirModifierCabinet.Location = new System.Drawing.Point(16, 13);
            this.lblVoirModifierCabinet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVoirModifierCabinet.Name = "lblVoirModifierCabinet";
            this.lblVoirModifierCabinet.Size = new System.Drawing.Size(295, 25);
            this.lblVoirModifierCabinet.TabIndex = 51;
            this.lblVoirModifierCabinet.Text = "Voir ou modifier un cabinet";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(100, 88);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(255, 21);
            this.cboxVille.TabIndex = 55;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(17, 171);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(118, 19);
            this.lblMedecin.TabIndex = 58;
            this.lblMedecin.Text = "Médecin associé";
            // 
            // dgvMedecin
            // 
            this.dgvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecin.Location = new System.Drawing.Point(21, 193);
            this.dgvMedecin.MultiSelect = false;
            this.dgvMedecin.Name = "dgvMedecin";
            this.dgvMedecin.ReadOnly = true;
            this.dgvMedecin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedecin.Size = new System.Drawing.Size(381, 174);
            this.dgvMedecin.TabIndex = 59;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(21, 411);
            this.dgvVisiteur.MultiSelect = false;
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteur.Size = new System.Drawing.Size(381, 174);
            this.dgvVisiteur.TabIndex = 61;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteur.Location = new System.Drawing.Point(17, 389);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(112, 19);
            this.lblVisiteur.TabIndex = 60;
            this.lblVisiteur.Text = "Visiteur associé";
            // 
            // dgvCabinet
            // 
            this.dgvCabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabinet.Location = new System.Drawing.Point(538, 61);
            this.dgvCabinet.MultiSelect = false;
            this.dgvCabinet.Name = "dgvCabinet";
            this.dgvCabinet.ReadOnly = true;
            this.dgvCabinet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCabinet.Size = new System.Drawing.Size(381, 524);
            this.dgvCabinet.TabIndex = 63;
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(534, 39);
            this.lblCabinet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 62;
            this.lblCabinet.Text = "Cabinet";
            // 
            // btnRechercher
            // 
            this.btnRechercher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRechercher.Location = new System.Drawing.Point(431, 252);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(85, 44);
            this.btnRechercher.TabIndex = 64;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModifier.Location = new System.Drawing.Point(431, 323);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(85, 44);
            this.btnModifier.TabIndex = 65;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(100, 61);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(81, 21);
            this.cboxCP.TabIndex = 67;
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
            this.lblCP.TabIndex = 66;
            this.lblCP.Text = "Code Postal";
            // 
            // CabinetRU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 643);
            this.Controls.Add(this.cboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.dgvMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblVoirModifierCabinet);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "CabinetRU";
            this.Text = "CabinetRU";
            this.Load += new System.EventHandler(this.CabinetRU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblVoirModifierCabinet;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.DataGridView dgvMedecin;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.DataGridView dgvCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
    }
}