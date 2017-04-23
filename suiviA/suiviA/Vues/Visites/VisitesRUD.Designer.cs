namespace Vues
{
    partial class VisitesRUD
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
            this.components = new System.ComponentModel.Container();
            this.calendrierDate = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblVoirVisite = new System.Windows.Forms.Label();
            this.cboxVille = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cboxCP = new System.Windows.Forms.ComboBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.dgvListeVisites = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.visiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVisites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // calendrierDate
            // 
            this.calendrierDate.Location = new System.Drawing.Point(18, 173);
            this.calendrierDate.Name = "calendrierDate";
            this.calendrierDate.TabIndex = 29;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(24, 156);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 19);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date de la visite";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(438, 96);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(255, 21);
            this.cboxMedecin.TabIndex = 27;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedecin.Location = new System.Drawing.Point(367, 99);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 26;
            this.lblMedecin.Text = "Médecin";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(105, 96);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(255, 21);
            this.cboxCabinet.TabIndex = 25;
            this.cboxCabinet.SelectedIndexChanged += new System.EventHandler(this.cboxCabinet_SelectedIndexChanged);
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(39, 96);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 24;
            this.lblCabinet.Text = "Cabinet";
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
            this.lblVoirVisite.TabIndex = 23;
            this.lblVoirVisite.Text = "Voir ou modifier une visite";
            // 
            // cboxVille
            // 
            this.cboxVille.FormattingEnabled = true;
            this.cboxVille.Location = new System.Drawing.Point(438, 58);
            this.cboxVille.Name = "cboxVille";
            this.cboxVille.Size = new System.Drawing.Size(255, 21);
            this.cboxVille.TabIndex = 33;
            this.cboxVille.SelectedIndexChanged += new System.EventHandler(this.cboxVille_SelectedIndexChanged);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVille.Location = new System.Drawing.Point(394, 61);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 32;
            this.lblVille.Text = "Ville";
            // 
            // cboxCP
            // 
            this.cboxCP.FormattingEnabled = true;
            this.cboxCP.Location = new System.Drawing.Point(105, 62);
            this.cboxCP.Name = "cboxCP";
            this.cboxCP.Size = new System.Drawing.Size(255, 21);
            this.cboxCP.TabIndex = 31;
            this.cboxCP.SelectedIndexChanged += new System.EventHandler(this.cboxCP_SelectedIndexChanged);
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCP.Location = new System.Drawing.Point(13, 61);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 30;
            this.lblCP.Text = "Code Postal";
            this.lblCP.Click += new System.EventHandler(this.lblRegion_Click);
            // 
            // dgvListeVisites
            // 
            this.dgvListeVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeVisites.Location = new System.Drawing.Point(371, 173);
            this.dgvListeVisites.MultiSelect = false;
            this.dgvListeVisites.Name = "dgvListeVisites";
            this.dgvListeVisites.ReadOnly = true;
            this.dgvListeVisites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeVisites.Size = new System.Drawing.Size(510, 435);
            this.dgvListeVisites.TabIndex = 34;
            // 
            // btnModifier
            // 
            this.btnModifier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModifier.Location = new System.Drawing.Point(47, 463);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(163, 54);
            this.btnModifier.TabIndex = 36;
            this.btnModifier.Text = "Modifier la visite";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSupprimer.Location = new System.Drawing.Point(47, 523);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(163, 54);
            this.btnSupprimer.TabIndex = 37;
            this.btnSupprimer.Text = "Supprimer la visite";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // visiteBindingSource
            // 
            this.visiteBindingSource.DataSource = typeof(Classes_Metiers.Visite);
            // 
            // VisitesRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 648);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgvListeVisites);
            this.Controls.Add(this.cboxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.cboxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.calendrierDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboxMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblVoirVisite);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "VisitesRUD";
            this.Text = "VisitesRUD";
            this.Load += new System.EventHandler(this.VisitesRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeVisites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calendrierDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblVoirVisite;
        private System.Windows.Forms.ComboBox cboxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cboxCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.DataGridView dgvListeVisites;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource visiteBindingSource;
    }
}