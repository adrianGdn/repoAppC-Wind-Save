namespace Vues
{
    partial class MedecinCreer
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
            this.lblCreerMedecin = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAssocier = new System.Windows.Forms.Button();
            this.btnValiderVisiteur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreerMedecin
            // 
            this.lblCreerMedecin.AutoSize = true;
            this.lblCreerMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblCreerMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCreerMedecin.Location = new System.Drawing.Point(13, 9);
            this.lblCreerMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreerMedecin.Name = "lblCreerMedecin";
            this.lblCreerMedecin.Size = new System.Drawing.Size(198, 25);
            this.lblCreerMedecin.TabIndex = 24;
            this.lblCreerMedecin.Text = "Créer un médecin";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(84, 61);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(255, 27);
            this.cboxCabinet.TabIndex = 26;
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCabinet.Location = new System.Drawing.Point(19, 64);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 25;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNom.Location = new System.Drawing.Point(19, 112);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 19);
            this.lblNom.TabIndex = 27;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(84, 109);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(255, 27);
            this.txtNom.TabIndex = 28;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(84, 153);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(255, 27);
            this.txtPrenom.TabIndex = 30;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrenom.Location = new System.Drawing.Point(19, 156);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 19);
            this.lblPrenom.TabIndex = 29;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVisiteur.Location = new System.Drawing.Point(487, 64);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(187, 19);
            this.lblVisiteur.TabIndex = 31;
            this.lblVisiteur.Text = "Visiteur associé (optionnel)";
            this.lblVisiteur.Visible = false;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(415, 86);
            this.dgvVisiteur.MultiSelect = false;
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteur.Size = new System.Drawing.Size(377, 336);
            this.dgvVisiteur.TabIndex = 32;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(123, 331);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(159, 64);
            this.btnValider.TabIndex = 33;
            this.btnValider.Text = "Valider la création";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAssocier
            // 
            this.btnAssocier.Location = new System.Drawing.Point(123, 230);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(159, 68);
            this.btnAssocier.TabIndex = 34;
            this.btnAssocier.Text = "Associer un visiteur maintenant (optionnel)";
            this.btnAssocier.UseVisualStyleBackColor = true;
            this.btnAssocier.Click += new System.EventHandler(this.btnAssocier_Click);
            // 
            // btnValiderVisiteur
            // 
            this.btnValiderVisiteur.Location = new System.Drawing.Point(123, 331);
            this.btnValiderVisiteur.Name = "btnValiderVisiteur";
            this.btnValiderVisiteur.Size = new System.Drawing.Size(159, 62);
            this.btnValiderVisiteur.TabIndex = 35;
            this.btnValiderVisiteur.Text = "Valider la création";
            this.btnValiderVisiteur.UseVisualStyleBackColor = true;
            this.btnValiderVisiteur.Visible = false;
            this.btnValiderVisiteur.Click += new System.EventHandler(this.btnValiderVisiteur_Click);
            // 
            // MedecinCreer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.btnValiderVisiteur);
            this.Controls.Add(this.btnAssocier);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblCreerMedecin);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedecinCreer";
            this.Text = "CreerMedecin";
            this.Load += new System.EventHandler(this.MedecinCreer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreerMedecin;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.Button btnValiderVisiteur;
    }
}