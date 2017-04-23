namespace Vues
{
    partial class Affectation
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
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.dgvMedecin = new System.Windows.Forms.DataGridView();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.btnAffecter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.BackColor = System.Drawing.Color.Transparent;
            this.lblAffectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAffectation.Location = new System.Drawing.Point(9, 9);
            this.lblAffectation.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(125, 25);
            this.lblAffectation.TabIndex = 56;
            this.lblAffectation.Text = "Affectation";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.BackColor = System.Drawing.Color.Transparent;
            this.lblVisiteur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.ForeColor = System.Drawing.Color.White;
            this.lblVisiteur.Location = new System.Drawing.Point(15, 112);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(59, 19);
            this.lblVisiteur.TabIndex = 63;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(19, 134);
            this.dgvVisiteur.MultiSelect = false;
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteur.Size = new System.Drawing.Size(372, 309);
            this.dgvVisiteur.TabIndex = 64;
            // 
            // dgvMedecin
            // 
            this.dgvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecin.Location = new System.Drawing.Point(448, 134);
            this.dgvMedecin.MultiSelect = false;
            this.dgvMedecin.Name = "dgvMedecin";
            this.dgvMedecin.ReadOnly = true;
            this.dgvMedecin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedecin.Size = new System.Drawing.Size(372, 309);
            this.dgvMedecin.TabIndex = 66;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.Color.White;
            this.lblMedecin.Location = new System.Drawing.Point(444, 112);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 65;
            this.lblMedecin.Text = "Médecin";
            // 
            // btnAffecter
            // 
            this.btnAffecter.BackColor = System.Drawing.SystemColors.Control;
            this.btnAffecter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAffecter.Location = new System.Drawing.Point(265, 32);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(292, 46);
            this.btnAffecter.TabIndex = 67;
            this.btnAffecter.Text = "Affecter le visiteur au médecin";
            this.btnAffecter.UseVisualStyleBackColor = false;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 465);
            this.Controls.Add(this.btnAffecter);
            this.Controls.Add(this.dgvMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.lblAffectation);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Affectation";
            this.Text = "Affectation";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.DataGridView dgvMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Button btnAffecter;
    }
}