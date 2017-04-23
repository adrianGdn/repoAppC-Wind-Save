namespace Vues
{
    partial class ModifierVisite
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
            this.txtMinuteDepart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeureDepart = new System.Windows.Forms.TextBox();
            this.lblHeureDepart = new System.Windows.Forms.Label();
            this.txtMinuteDebut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.txtMinuteArrivee = new System.Windows.Forms.TextBox();
            this.lblDeuxPoints1 = new System.Windows.Forms.Label();
            this.txtHeureArrivee = new System.Windows.Forms.TextBox();
            this.lblHeureArrivee = new System.Windows.Forms.Label();
            this.calendrierDate = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.lblModifierVisite = new System.Windows.Forms.Label();
            this.grpboxRDV = new System.Windows.Forms.GroupBox();
            this.rdbtnNon = new System.Windows.Forms.RadioButton();
            this.rdbtnOui = new System.Windows.Forms.RadioButton();
            this.grpboxRDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnValider.Location = new System.Drawing.Point(310, 394);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(132, 40);
            this.btnValider.TabIndex = 45;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMinuteDepart
            // 
            this.txtMinuteDepart.Location = new System.Drawing.Point(467, 266);
            this.txtMinuteDepart.MaxLength = 2;
            this.txtMinuteDepart.Name = "txtMinuteDepart";
            this.txtMinuteDepart.Size = new System.Drawing.Size(31, 20);
            this.txtMinuteDepart.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(448, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = ":";
            // 
            // txtHeureDepart
            // 
            this.txtHeureDepart.Location = new System.Drawing.Point(411, 266);
            this.txtHeureDepart.MaxLength = 2;
            this.txtHeureDepart.Name = "txtHeureDepart";
            this.txtHeureDepart.Size = new System.Drawing.Size(31, 20);
            this.txtHeureDepart.TabIndex = 42;
            // 
            // lblHeureDepart
            // 
            this.lblHeureDepart.AutoSize = true;
            this.lblHeureDepart.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDepart.Location = new System.Drawing.Point(321, 269);
            this.lblHeureDepart.Name = "lblHeureDepart";
            this.lblHeureDepart.Size = new System.Drawing.Size(84, 13);
            this.lblHeureDepart.TabIndex = 41;
            this.lblHeureDepart.Text = "Heure de départ";
            // 
            // txtMinuteDebut
            // 
            this.txtMinuteDebut.Location = new System.Drawing.Point(467, 226);
            this.txtMinuteDebut.MaxLength = 2;
            this.txtMinuteDebut.Name = "txtMinuteDebut";
            this.txtMinuteDebut.Size = new System.Drawing.Size(31, 20);
            this.txtMinuteDebut.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(448, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = ":";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(411, 226);
            this.txtHeureDebut.MaxLength = 2;
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(31, 20);
            this.txtHeureDebut.TabIndex = 38;
            this.txtHeureDebut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeureDebut_KeyPress);
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDebut.Location = new System.Drawing.Point(321, 229);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(81, 13);
            this.lblHeureDebut.TabIndex = 37;
            this.lblHeureDebut.Text = "Heure de début";
            // 
            // txtMinuteArrivee
            // 
            this.txtMinuteArrivee.Location = new System.Drawing.Point(467, 185);
            this.txtMinuteArrivee.MaxLength = 2;
            this.txtMinuteArrivee.Name = "txtMinuteArrivee";
            this.txtMinuteArrivee.Size = new System.Drawing.Size(31, 20);
            this.txtMinuteArrivee.TabIndex = 36;
            this.txtMinuteArrivee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuteArrivee_KeyPress);
            // 
            // lblDeuxPoints1
            // 
            this.lblDeuxPoints1.AutoSize = true;
            this.lblDeuxPoints1.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuxPoints1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDeuxPoints1.Location = new System.Drawing.Point(448, 188);
            this.lblDeuxPoints1.Name = "lblDeuxPoints1";
            this.lblDeuxPoints1.Size = new System.Drawing.Size(10, 13);
            this.lblDeuxPoints1.TabIndex = 35;
            this.lblDeuxPoints1.Text = ":";
            // 
            // txtHeureArrivee
            // 
            this.txtHeureArrivee.Location = new System.Drawing.Point(411, 185);
            this.txtHeureArrivee.MaxLength = 2;
            this.txtHeureArrivee.Name = "txtHeureArrivee";
            this.txtHeureArrivee.Size = new System.Drawing.Size(31, 20);
            this.txtHeureArrivee.TabIndex = 34;
            this.txtHeureArrivee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeureArrivee_KeyPress);
            // 
            // lblHeureArrivee
            // 
            this.lblHeureArrivee.AutoSize = true;
            this.lblHeureArrivee.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureArrivee.Location = new System.Drawing.Point(321, 188);
            this.lblHeureArrivee.Name = "lblHeureArrivee";
            this.lblHeureArrivee.Size = new System.Drawing.Size(79, 13);
            this.lblHeureArrivee.TabIndex = 33;
            this.lblHeureArrivee.Text = "Heure d\'arrivée";
            // 
            // calendrierDate
            // 
            this.calendrierDate.Location = new System.Drawing.Point(17, 154);
            this.calendrierDate.Name = "calendrierDate";
            this.calendrierDate.TabIndex = 29;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(13, 135);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 19);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date de la visite";
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(465, 65);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(255, 21);
            this.cboxMedecin.TabIndex = 27;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(394, 68);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(65, 19);
            this.lblMedecin.TabIndex = 26;
            this.lblMedecin.Text = "Médecin";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(78, 65);
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
            this.lblCabinet.Location = new System.Drawing.Point(13, 68);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(59, 19);
            this.lblCabinet.TabIndex = 24;
            this.lblCabinet.Text = "Cabinet";
            // 
            // lblModifierVisite
            // 
            this.lblModifierVisite.AutoSize = true;
            this.lblModifierVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblModifierVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierVisite.Location = new System.Drawing.Point(12, 9);
            this.lblModifierVisite.Name = "lblModifierVisite";
            this.lblModifierVisite.Size = new System.Drawing.Size(186, 25);
            this.lblModifierVisite.TabIndex = 23;
            this.lblModifierVisite.Text = "Modifier la visite";
            // 
            // grpboxRDV
            // 
            this.grpboxRDV.BackColor = System.Drawing.Color.Transparent;
            this.grpboxRDV.Controls.Add(this.rdbtnNon);
            this.grpboxRDV.Controls.Add(this.rdbtnOui);
            this.grpboxRDV.Location = new System.Drawing.Point(545, 182);
            this.grpboxRDV.Name = "grpboxRDV";
            this.grpboxRDV.Size = new System.Drawing.Size(289, 100);
            this.grpboxRDV.TabIndex = 46;
            this.grpboxRDV.TabStop = false;
            this.grpboxRDV.Text = "Visite sur rendez-vous ?";
            // 
            // rdbtnNon
            // 
            this.rdbtnNon.AutoSize = true;
            this.rdbtnNon.Location = new System.Drawing.Point(113, 49);
            this.rdbtnNon.Name = "rdbtnNon";
            this.rdbtnNon.Size = new System.Drawing.Size(45, 17);
            this.rdbtnNon.TabIndex = 9;
            this.rdbtnNon.TabStop = true;
            this.rdbtnNon.Text = "Non";
            this.rdbtnNon.UseVisualStyleBackColor = true;
            // 
            // rdbtnOui
            // 
            this.rdbtnOui.AutoSize = true;
            this.rdbtnOui.Location = new System.Drawing.Point(25, 49);
            this.rdbtnOui.Name = "rdbtnOui";
            this.rdbtnOui.Size = new System.Drawing.Size(41, 17);
            this.rdbtnOui.TabIndex = 8;
            this.rdbtnOui.TabStop = true;
            this.rdbtnOui.Text = "Oui";
            this.rdbtnOui.UseVisualStyleBackColor = true;
            // 
            // ModifierVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 480);
            this.Controls.Add(this.grpboxRDV);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMinuteDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeureDepart);
            this.Controls.Add(this.lblHeureDepart);
            this.Controls.Add(this.txtMinuteDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeureDebut);
            this.Controls.Add(this.lblHeureDebut);
            this.Controls.Add(this.txtMinuteArrivee);
            this.Controls.Add(this.lblDeuxPoints1);
            this.Controls.Add(this.txtHeureArrivee);
            this.Controls.Add(this.lblHeureArrivee);
            this.Controls.Add(this.calendrierDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboxMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cboxCabinet);
            this.Controls.Add(this.lblCabinet);
            this.Controls.Add(this.lblModifierVisite);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "ModifierVisite";
            this.Text = "ModifierVisite";
            this.Load += new System.EventHandler(this.ModifierVisite_Load);
            this.grpboxRDV.ResumeLayout(false);
            this.grpboxRDV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMinuteDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeureDepart;
        private System.Windows.Forms.Label lblHeureDepart;
        private System.Windows.Forms.TextBox txtMinuteDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.TextBox txtMinuteArrivee;
        private System.Windows.Forms.Label lblDeuxPoints1;
        private System.Windows.Forms.TextBox txtHeureArrivee;
        private System.Windows.Forms.Label lblHeureArrivee;
        private System.Windows.Forms.MonthCalendar calendrierDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.Label lblModifierVisite;
        private System.Windows.Forms.GroupBox grpboxRDV;
        private System.Windows.Forms.RadioButton rdbtnNon;
        private System.Windows.Forms.RadioButton rdbtnOui;
    }
}