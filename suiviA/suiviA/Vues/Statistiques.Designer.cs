namespace Vues
{
    partial class Statistiques
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
            this.lblStatistique = new System.Windows.Forms.Label();
            this.lblVisiteMedecin = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.txtNbrVisitesMedecin = new System.Windows.Forms.TextBox();
            this.lblNbrVisitesTotal = new System.Windows.Forms.Label();
            this.txtNbrVisitesTotal = new System.Windows.Forms.TextBox();
            this.lblTempsParJour = new System.Windows.Forms.Label();
            this.calendrierTempsVisite = new System.Windows.Forms.MonthCalendar();
            this.txtTempsParJour = new System.Windows.Forms.TextBox();
            this.txtNbrVisiteJour = new System.Windows.Forms.TextBox();
            this.lblNbrVisitesJour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatistique
            // 
            this.lblStatistique.AutoSize = true;
            this.lblStatistique.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistique.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatistique.Location = new System.Drawing.Point(19, 13);
            this.lblStatistique.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStatistique.Name = "lblStatistique";
            this.lblStatistique.Size = new System.Drawing.Size(136, 25);
            this.lblStatistique.TabIndex = 51;
            this.lblStatistique.Text = "Statistiques";
            // 
            // lblVisiteMedecin
            // 
            this.lblVisiteMedecin.AutoSize = true;
            this.lblVisiteMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteMedecin.Location = new System.Drawing.Point(20, 61);
            this.lblVisiteMedecin.Name = "lblVisiteMedecin";
            this.lblVisiteMedecin.Size = new System.Drawing.Size(245, 19);
            this.lblVisiteMedecin.TabIndex = 52;
            this.lblVisiteMedecin.Text = "Nombre de visites pour ce médecin :";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(24, 83);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(417, 27);
            this.cboxMedecin.TabIndex = 53;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // txtNbrVisitesMedecin
            // 
            this.txtNbrVisitesMedecin.Location = new System.Drawing.Point(460, 83);
            this.txtNbrVisitesMedecin.Name = "txtNbrVisitesMedecin";
            this.txtNbrVisitesMedecin.ReadOnly = true;
            this.txtNbrVisitesMedecin.Size = new System.Drawing.Size(52, 27);
            this.txtNbrVisitesMedecin.TabIndex = 54;
            // 
            // lblNbrVisitesTotal
            // 
            this.lblNbrVisitesTotal.AutoSize = true;
            this.lblNbrVisitesTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblNbrVisitesTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNbrVisitesTotal.Location = new System.Drawing.Point(273, 125);
            this.lblNbrVisitesTotal.Name = "lblNbrVisitesTotal";
            this.lblNbrVisitesTotal.Size = new System.Drawing.Size(168, 19);
            this.lblNbrVisitesTotal.TabIndex = 55;
            this.lblNbrVisitesTotal.Text = "Nombre total de visites :";
            // 
            // txtNbrVisitesTotal
            // 
            this.txtNbrVisitesTotal.Location = new System.Drawing.Point(460, 117);
            this.txtNbrVisitesTotal.Name = "txtNbrVisitesTotal";
            this.txtNbrVisitesTotal.ReadOnly = true;
            this.txtNbrVisitesTotal.Size = new System.Drawing.Size(52, 27);
            this.txtNbrVisitesTotal.TabIndex = 56;
            // 
            // lblTempsParJour
            // 
            this.lblTempsParJour.AutoSize = true;
            this.lblTempsParJour.BackColor = System.Drawing.Color.Transparent;
            this.lblTempsParJour.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTempsParJour.Location = new System.Drawing.Point(264, 234);
            this.lblTempsParJour.Name = "lblTempsParJour";
            this.lblTempsParJour.Size = new System.Drawing.Size(232, 19);
            this.lblTempsParJour.TabIndex = 57;
            this.lblTempsParJour.Text = "Temps passé en visite sur ce jour :";
            // 
            // calendrierTempsVisite
            // 
            this.calendrierTempsVisite.Location = new System.Drawing.Point(25, 225);
            this.calendrierTempsVisite.Name = "calendrierTempsVisite";
            this.calendrierTempsVisite.TabIndex = 58;
            this.calendrierTempsVisite.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrierTempsVisite_DateChanged);
            // 
            // txtTempsParJour
            // 
            this.txtTempsParJour.Location = new System.Drawing.Point(502, 231);
            this.txtTempsParJour.Name = "txtTempsParJour";
            this.txtTempsParJour.ReadOnly = true;
            this.txtTempsParJour.Size = new System.Drawing.Size(108, 27);
            this.txtTempsParJour.TabIndex = 59;
            // 
            // txtNbrVisiteJour
            // 
            this.txtNbrVisiteJour.Location = new System.Drawing.Point(502, 265);
            this.txtNbrVisiteJour.Name = "txtNbrVisiteJour";
            this.txtNbrVisiteJour.ReadOnly = true;
            this.txtNbrVisiteJour.Size = new System.Drawing.Size(52, 27);
            this.txtNbrVisiteJour.TabIndex = 61;
            // 
            // lblNbrVisitesJour
            // 
            this.lblNbrVisitesJour.AutoSize = true;
            this.lblNbrVisitesJour.BackColor = System.Drawing.Color.Transparent;
            this.lblNbrVisitesJour.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNbrVisitesJour.Location = new System.Drawing.Point(290, 268);
            this.lblNbrVisitesJour.Name = "lblNbrVisitesJour";
            this.lblNbrVisitesJour.Size = new System.Drawing.Size(206, 19);
            this.lblNbrVisitesJour.TabIndex = 60;
            this.lblNbrVisitesJour.Text = "Nombre de visites sur ce jour :";
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 491);
            this.Controls.Add(this.txtNbrVisiteJour);
            this.Controls.Add(this.lblNbrVisitesJour);
            this.Controls.Add(this.txtTempsParJour);
            this.Controls.Add(this.calendrierTempsVisite);
            this.Controls.Add(this.lblTempsParJour);
            this.Controls.Add(this.txtNbrVisitesTotal);
            this.Controls.Add(this.lblNbrVisitesTotal);
            this.Controls.Add(this.txtNbrVisitesMedecin);
            this.Controls.Add(this.cboxMedecin);
            this.Controls.Add(this.lblVisiteMedecin);
            this.Controls.Add(this.lblStatistique);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistique;
        private System.Windows.Forms.Label lblVisiteMedecin;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.TextBox txtNbrVisitesMedecin;
        private System.Windows.Forms.Label lblNbrVisitesTotal;
        private System.Windows.Forms.TextBox txtNbrVisitesTotal;
        private System.Windows.Forms.Label lblTempsParJour;
        private System.Windows.Forms.MonthCalendar calendrierTempsVisite;
        private System.Windows.Forms.TextBox txtTempsParJour;
        private System.Windows.Forms.TextBox txtNbrVisiteJour;
        private System.Windows.Forms.Label lblNbrVisitesJour;
    }
}