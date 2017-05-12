namespace Vues
{
    partial class Connexion
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMessageErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(637, 274);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Identifiant";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(637, 322);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(203, 20);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.SystemColors.Window;
            this.btnConnexion.Location = new System.Drawing.Point(657, 399);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(157, 41);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageErreur.ForeColor = System.Drawing.Color.Red;
            this.lblMessageErreur.Location = new System.Drawing.Point(610, 242);
            this.lblMessageErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(0, 19);
            this.lblMessageErreur.TabIndex = 6;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 657);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.KeyPreview = true;
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connexion_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMessageErreur;
    }
}