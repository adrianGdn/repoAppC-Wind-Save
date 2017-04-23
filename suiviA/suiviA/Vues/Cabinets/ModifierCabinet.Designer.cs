namespace Vues.Cabinets
{
    partial class ModifierCabinet
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
            this.btnValider = new System.Windows.Forms.Button();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblModifierCabinet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(265, 328);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(134, 42);
            this.btnValider.TabIndex = 58;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(179, 248);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(220, 20);
            this.txtCodePostal.TabIndex = 57;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.Color.White;
            this.lblCP.Location = new System.Drawing.Point(85, 251);
            this.lblCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(86, 19);
            this.lblCP.TabIndex = 56;
            this.lblCP.Text = "Code postal";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(179, 200);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(220, 20);
            this.txtVille.TabIndex = 55;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.Color.Transparent;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.Color.White;
            this.lblVille.Location = new System.Drawing.Point(131, 208);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 54;
            this.lblVille.Text = "Ville";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(179, 82);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(406, 96);
            this.txtAdresse.TabIndex = 53;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.Color.White;
            this.lblAdresse.Location = new System.Drawing.Point(108, 85);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(61, 19);
            this.lblAdresse.TabIndex = 52;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblModifierCabinet
            // 
            this.lblModifierCabinet.AutoSize = true;
            this.lblModifierCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblModifierCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierCabinet.ForeColor = System.Drawing.Color.White;
            this.lblModifierCabinet.Location = new System.Drawing.Point(12, 17);
            this.lblModifierCabinet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModifierCabinet.Name = "lblModifierCabinet";
            this.lblModifierCabinet.Size = new System.Drawing.Size(214, 25);
            this.lblModifierCabinet.TabIndex = 51;
            this.lblModifierCabinet.Text = "Modifier un cabinet";
            // 
            // ModifierCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblModifierCabinet);
            this.Name = "ModifierCabinet";
            this.Text = "ModifierCabinet";
            this.Load += new System.EventHandler(this.ModifierCabinet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblModifierCabinet;
    }
}