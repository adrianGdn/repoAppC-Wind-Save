namespace Vues
{
    partial class AccueilUtilisateur
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.medecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUnMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirOuModifierUnMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirOuModifierUnCabinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medecinsToolStripMenuItem,
            this.cabinetsToolStripMenuItem,
            this.affectationsToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1001, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // medecinsToolStripMenuItem
            // 
            this.medecinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnMedecinToolStripMenuItem,
            this.voirOuModifierUnMedecinToolStripMenuItem});
            this.medecinsToolStripMenuItem.Name = "medecinsToolStripMenuItem";
            this.medecinsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.medecinsToolStripMenuItem.Text = "Médecins";
            // 
            // creerUnMedecinToolStripMenuItem
            // 
            this.creerUnMedecinToolStripMenuItem.Name = "creerUnMedecinToolStripMenuItem";
            this.creerUnMedecinToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.creerUnMedecinToolStripMenuItem.Text = "Créer un médecin";
            this.creerUnMedecinToolStripMenuItem.Click += new System.EventHandler(this.creerUnMedecinToolStripMenuItem_Click);
            // 
            // voirOuModifierUnMedecinToolStripMenuItem
            // 
            this.voirOuModifierUnMedecinToolStripMenuItem.Name = "voirOuModifierUnMedecinToolStripMenuItem";
            this.voirOuModifierUnMedecinToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.voirOuModifierUnMedecinToolStripMenuItem.Text = "Voir ou modifier un médecin";
            this.voirOuModifierUnMedecinToolStripMenuItem.Click += new System.EventHandler(this.voirOuModifierUnMedecinToolStripMenuItem_Click);
            // 
            // cabinetsToolStripMenuItem
            // 
            this.cabinetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnCabinetToolStripMenuItem,
            this.voirOuModifierUnCabinetToolStripMenuItem});
            this.cabinetsToolStripMenuItem.Name = "cabinetsToolStripMenuItem";
            this.cabinetsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cabinetsToolStripMenuItem.Text = "Cabinets";
            // 
            // créerUnCabinetToolStripMenuItem
            // 
            this.créerUnCabinetToolStripMenuItem.Name = "créerUnCabinetToolStripMenuItem";
            this.créerUnCabinetToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.créerUnCabinetToolStripMenuItem.Text = "Créer un cabinet";
            this.créerUnCabinetToolStripMenuItem.Click += new System.EventHandler(this.creerUnCabinetToolStripMenuItem_Click);
            // 
            // voirOuModifierUnCabinetToolStripMenuItem
            // 
            this.voirOuModifierUnCabinetToolStripMenuItem.Name = "voirOuModifierUnCabinetToolStripMenuItem";
            this.voirOuModifierUnCabinetToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.voirOuModifierUnCabinetToolStripMenuItem.Text = "Voir ou modifier un cabinet";
            this.voirOuModifierUnCabinetToolStripMenuItem.Click += new System.EventHandler(this.voirOuModifierUnCabinetToolStripMenuItem_Click);
            // 
            // affectationsToolStripMenuItem
            // 
            this.affectationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem});
            this.affectationsToolStripMenuItem.Name = "affectationsToolStripMenuItem";
            this.affectationsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.affectationsToolStripMenuItem.Text = "Affectations";
            // 
            // affecterUnVisiteurÀUnMédecinToolStripMenuItem
            // 
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem.Name = "affecterUnVisiteurÀUnMédecinToolStripMenuItem";
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem.Text = "Affecter un visiteur à un médecin";
            this.affecterUnVisiteurÀUnMédecinToolStripMenuItem.Click += new System.EventHandler(this.affecterUnVisiteurÀUnMédecinToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // AccueilUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 657);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "AccueilUtilisateur";
            this.Text = "AccueilUtilisateur";
            this.Load += new System.EventHandler(this.AccueilUtilisateur_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem medecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabinetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerUnMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirOuModifierUnMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirOuModifierUnCabinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affecterUnVisiteurÀUnMédecinToolStripMenuItem;
    }
}