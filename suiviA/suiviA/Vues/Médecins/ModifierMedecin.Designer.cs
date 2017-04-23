namespace Vues
{
    partial class ModifierMedecin
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
            this.lblModifierMedecin = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModifierMedecin
            // 
            this.lblModifierMedecin.AutoSize = true;
            this.lblModifierMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblModifierMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierMedecin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblModifierMedecin.Location = new System.Drawing.Point(10, 21);
            this.lblModifierMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifierMedecin.Name = "lblModifierMedecin";
            this.lblModifierMedecin.Size = new System.Drawing.Size(225, 25);
            this.lblModifierMedecin.TabIndex = 34;
            this.lblModifierMedecin.Text = "Modifier un médecin";
            // 
            // btnValider
            // 
            this.btnValider.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnValider.Location = new System.Drawing.Point(291, 243);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(119, 52);
            this.btnValider.TabIndex = 44;
            this.btnValider.Text = "Valider la modification";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(239, 174);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(255, 20);
            this.txtPrenom.TabIndex = 41;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPrenom.Location = new System.Drawing.Point(175, 177);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 19);
            this.lblPrenom.TabIndex = 40;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(239, 130);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(255, 20);
            this.txtNom.TabIndex = 39;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNom.Location = new System.Drawing.Point(194, 133);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 19);
            this.lblNom.TabIndex = 38;
            this.lblNom.Text = "Nom";
            // 
            // ModifierMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 454);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblModifierMedecin);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "ModifierMedecin";
            this.Text = "ModifierMedecin";
            this.Load += new System.EventHandler(this.ModifierMedecin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModifierMedecin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
    }
}