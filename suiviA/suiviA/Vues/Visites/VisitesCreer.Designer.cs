namespace Vues
{
    partial class VisitesCreer
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
            this.lblCreerVisite = new System.Windows.Forms.Label();
            this.lblCabinet = new System.Windows.Forms.Label();
            this.cboxCabinet = new System.Windows.Forms.ComboBox();
            this.cboxMedecin = new System.Windows.Forms.ComboBox();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.calendrierDate = new System.Windows.Forms.MonthCalendar();
            this.rdbtnOui = new System.Windows.Forms.RadioButton();
            this.rdbtnNon = new System.Windows.Forms.RadioButton();
            this.lblHeureArrivee = new System.Windows.Forms.Label();
            this.txtHeureArrivee = new System.Windows.Forms.TextBox();
            this.lblDeuxPoints1 = new System.Windows.Forms.Label();
            this.txtMinuteArrivee = new System.Windows.Forms.TextBox();
            this.txtMinuteDebut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeureDebut = new System.Windows.Forms.TextBox();
            this.lblHeureDebut = new System.Windows.Forms.Label();
            this.txtMinuteDepart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeureDepart = new System.Windows.Forms.TextBox();
            this.lblHeureDepart = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpboxRDV = new System.Windows.Forms.GroupBox();
            this.grpboxRDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreerVisite
            // 
            this.lblCreerVisite.AutoSize = true;
            this.lblCreerVisite.BackColor = System.Drawing.Color.Transparent;
            this.lblCreerVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreerVisite.Location = new System.Drawing.Point(12, 12);
            this.lblCreerVisite.Name = "lblCreerVisite";
            this.lblCreerVisite.Size = new System.Drawing.Size(254, 37);
            this.lblCreerVisite.TabIndex = 0;
            this.lblCreerVisite.Text = "Créer une visite";
            // 
            // lblCabinet
            // 
            this.lblCabinet.AutoSize = true;
            this.lblCabinet.BackColor = System.Drawing.Color.Transparent;
            this.lblCabinet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinet.Location = new System.Drawing.Point(17, 72);
            this.lblCabinet.Name = "lblCabinet";
            this.lblCabinet.Size = new System.Drawing.Size(90, 29);
            this.lblCabinet.TabIndex = 1;
            this.lblCabinet.Text = "Cabinet";
            // 
            // cboxCabinet
            // 
            this.cboxCabinet.FormattingEnabled = true;
            this.cboxCabinet.Location = new System.Drawing.Point(82, 69);
            this.cboxCabinet.Name = "cboxCabinet";
            this.cboxCabinet.Size = new System.Drawing.Size(255, 37);
            this.cboxCabinet.TabIndex = 2;
            this.cboxCabinet.SelectedIndexChanged += new System.EventHandler(this.cboxCabinet_SelectedIndexChanged);
            // 
            // cboxMedecin
            // 
            this.cboxMedecin.FormattingEnabled = true;
            this.cboxMedecin.Location = new System.Drawing.Point(576, 65);
            this.cboxMedecin.Name = "cboxMedecin";
            this.cboxMedecin.Size = new System.Drawing.Size(255, 37);
            this.cboxMedecin.TabIndex = 4;
            this.cboxMedecin.SelectedIndexChanged += new System.EventHandler(this.cboxMedecin_SelectedIndexChanged);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(505, 68);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(100, 29);
            this.lblMedecin.TabIndex = 3;
            this.lblMedecin.Text = "Médecin";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(17, 140);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(170, 29);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date de la visite";
            // 
            // calendrierDate
            // 
            this.calendrierDate.Location = new System.Drawing.Point(21, 158);
            this.calendrierDate.Name = "calendrierDate";
            this.calendrierDate.TabIndex = 6;
            // 
            // rdbtnOui
            // 
            this.rdbtnOui.AutoSize = true;
            this.rdbtnOui.Location = new System.Drawing.Point(25, 49);
            this.rdbtnOui.Name = "rdbtnOui";
            this.rdbtnOui.Size = new System.Drawing.Size(73, 33);
            this.rdbtnOui.TabIndex = 8;
            this.rdbtnOui.TabStop = true;
            this.rdbtnOui.Text = "Oui";
            this.rdbtnOui.UseVisualStyleBackColor = true;
            // 
            // rdbtnNon
            // 
            this.rdbtnNon.AutoSize = true;
            this.rdbtnNon.Location = new System.Drawing.Point(113, 49);
            this.rdbtnNon.Name = "rdbtnNon";
            this.rdbtnNon.Size = new System.Drawing.Size(80, 33);
            this.rdbtnNon.TabIndex = 9;
            this.rdbtnNon.TabStop = true;
            this.rdbtnNon.Text = "Non";
            this.rdbtnNon.UseVisualStyleBackColor = true;
            // 
            // lblHeureArrivee
            // 
            this.lblHeureArrivee.AutoSize = true;
            this.lblHeureArrivee.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureArrivee.Location = new System.Drawing.Point(300, 192);
            this.lblHeureArrivee.Name = "lblHeureArrivee";
            this.lblHeureArrivee.Size = new System.Drawing.Size(165, 29);
            this.lblHeureArrivee.TabIndex = 10;
            this.lblHeureArrivee.Text = "Heure d\'arrivée";
            // 
            // txtHeureArrivee
            // 
            this.txtHeureArrivee.Location = new System.Drawing.Point(415, 189);
            this.txtHeureArrivee.MaxLength = 2;
            this.txtHeureArrivee.Name = "txtHeureArrivee";
            this.txtHeureArrivee.Size = new System.Drawing.Size(31, 37);
            this.txtHeureArrivee.TabIndex = 11;
            this.txtHeureArrivee.Text = "00";
            this.txtHeureArrivee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeureArrivee_KeyPress);
            // 
            // lblDeuxPoints1
            // 
            this.lblDeuxPoints1.AutoSize = true;
            this.lblDeuxPoints1.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuxPoints1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDeuxPoints1.Location = new System.Drawing.Point(452, 192);
            this.lblDeuxPoints1.Name = "lblDeuxPoints1";
            this.lblDeuxPoints1.Size = new System.Drawing.Size(19, 29);
            this.lblDeuxPoints1.TabIndex = 12;
            this.lblDeuxPoints1.Text = ":";
            // 
            // txtMinuteArrivee
            // 
            this.txtMinuteArrivee.Location = new System.Drawing.Point(471, 189);
            this.txtMinuteArrivee.MaxLength = 2;
            this.txtMinuteArrivee.Name = "txtMinuteArrivee";
            this.txtMinuteArrivee.Size = new System.Drawing.Size(31, 37);
            this.txtMinuteArrivee.TabIndex = 13;
            this.txtMinuteArrivee.Text = "00";
            this.txtMinuteArrivee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuteArrivee_KeyPress);
            // 
            // txtMinuteDebut
            // 
            this.txtMinuteDebut.Location = new System.Drawing.Point(471, 230);
            this.txtMinuteDebut.MaxLength = 2;
            this.txtMinuteDebut.Name = "txtMinuteDebut";
            this.txtMinuteDebut.Size = new System.Drawing.Size(31, 37);
            this.txtMinuteDebut.TabIndex = 17;
            this.txtMinuteDebut.Text = "00";
            this.txtMinuteDebut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuteDebut_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(452, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = ":";
            // 
            // txtHeureDebut
            // 
            this.txtHeureDebut.Location = new System.Drawing.Point(415, 230);
            this.txtHeureDebut.MaxLength = 2;
            this.txtHeureDebut.Name = "txtHeureDebut";
            this.txtHeureDebut.Size = new System.Drawing.Size(31, 37);
            this.txtHeureDebut.TabIndex = 15;
            this.txtHeureDebut.Text = "00";
            this.txtHeureDebut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeureDebut_KeyPress);
            // 
            // lblHeureDebut
            // 
            this.lblHeureDebut.AutoSize = true;
            this.lblHeureDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDebut.Location = new System.Drawing.Point(300, 233);
            this.lblHeureDebut.Name = "lblHeureDebut";
            this.lblHeureDebut.Size = new System.Drawing.Size(167, 29);
            this.lblHeureDebut.TabIndex = 14;
            this.lblHeureDebut.Text = "Heure de début";
            // 
            // txtMinuteDepart
            // 
            this.txtMinuteDepart.Location = new System.Drawing.Point(471, 270);
            this.txtMinuteDepart.MaxLength = 2;
            this.txtMinuteDepart.Name = "txtMinuteDepart";
            this.txtMinuteDepart.Size = new System.Drawing.Size(31, 37);
            this.txtMinuteDepart.TabIndex = 21;
            this.txtMinuteDepart.Text = "00";
            this.txtMinuteDepart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuteDepart_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(452, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = ":";
            // 
            // txtHeureDepart
            // 
            this.txtHeureDepart.Location = new System.Drawing.Point(415, 270);
            this.txtHeureDepart.MaxLength = 2;
            this.txtHeureDepart.Name = "txtHeureDepart";
            this.txtHeureDepart.Size = new System.Drawing.Size(31, 37);
            this.txtHeureDepart.TabIndex = 19;
            this.txtHeureDepart.Text = "00";
            this.txtHeureDepart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeureDepart_KeyPress);
            // 
            // lblHeureDepart
            // 
            this.lblHeureDepart.AutoSize = true;
            this.lblHeureDepart.BackColor = System.Drawing.Color.Transparent;
            this.lblHeureDepart.Location = new System.Drawing.Point(300, 273);
            this.lblHeureDepart.Name = "lblHeureDepart";
            this.lblHeureDepart.Size = new System.Drawing.Size(174, 29);
            this.lblHeureDepart.TabIndex = 18;
            this.lblHeureDepart.Text = "Heure de départ";
            // 
            // btnValider
            // 
            this.btnValider.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnValider.Location = new System.Drawing.Point(314, 398);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(132, 40);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpboxRDV
            // 
            this.grpboxRDV.BackColor = System.Drawing.Color.Transparent;
            this.grpboxRDV.Controls.Add(this.rdbtnNon);
            this.grpboxRDV.Controls.Add(this.rdbtnOui);
            this.grpboxRDV.Location = new System.Drawing.Point(585, 192);
            this.grpboxRDV.Name = "grpboxRDV";
            this.grpboxRDV.Size = new System.Drawing.Size(192, 100);
            this.grpboxRDV.TabIndex = 23;
            this.grpboxRDV.TabStop = false;
            this.grpboxRDV.Text = "Visite sur rendez-vous ?";
            this.grpboxRDV.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VisitesCreer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vues.Properties.Resources.laboratoire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 546);
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
            this.Controls.Add(this.lblCreerVisite);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VisitesCreer";
            this.Text = "Créer une visite";
            this.Load += new System.EventHandler(this.VisitesCreer_Load);
            this.grpboxRDV.ResumeLayout(false);
            this.grpboxRDV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreerVisite;
        private System.Windows.Forms.Label lblCabinet;
        private System.Windows.Forms.ComboBox cboxCabinet;
        private System.Windows.Forms.ComboBox cboxMedecin;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar calendrierDate;
        private System.Windows.Forms.RadioButton rdbtnOui;
        private System.Windows.Forms.RadioButton rdbtnNon;
        private System.Windows.Forms.Label lblHeureArrivee;
        private System.Windows.Forms.TextBox txtHeureArrivee;
        private System.Windows.Forms.Label lblDeuxPoints1;
        private System.Windows.Forms.TextBox txtMinuteArrivee;
        private System.Windows.Forms.TextBox txtMinuteDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeureDebut;
        private System.Windows.Forms.Label lblHeureDebut;
        private System.Windows.Forms.TextBox txtMinuteDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeureDepart;
        private System.Windows.Forms.Label lblHeureDepart;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpboxRDV;
    }
}