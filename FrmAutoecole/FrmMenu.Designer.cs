namespace FrmAutoecole
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
  
            label2 = new Label();
            lblImmat = new Label();
            grbVehicule = new GroupBox();
            btnValiderV = new Button();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            lblEtat = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtCouleur = new TextBox();
            lblCouleur = new Label();
            txtImmat = new TextBox();
            grbLecon = new GroupBox();
            lblLecon = new Label();
            btnValiderF = new Button();
            chkEtat = new CheckBox();
            dtpHeure = new DateTimePicker();
            dtpLecon = new DateTimePicker();
            label11 = new Label();
            txtVehicule = new TextBox();
            lblVehicule = new Label();
            txtEleve = new TextBox();
            lblEleve = new Label();
            groupBox3 = new GroupBox();
            textNom = new TextBox();
            lblNom = new Label();
            textPrenom = new TextBox();
            lblPrenom = new Label();
            textBox6 = new TextBox();
            lblCredit = new Label();
            dtpInscription = new DateTimePicker();
            btnValiderE = new Button();
            lblInscription = new Label();
            grbVehicule.SuspendLayout();
            grbLecon.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 141);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 141);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // lblImmat
            // 
            lblImmat.AutoSize = true;
            lblImmat.Location = new Point(21, 28);
            lblImmat.Name = "lblImmat";
            lblImmat.Size = new Size(42, 15);
            lblImmat.TabIndex = 2;
            lblImmat.Text = "Immat";
            // 
            // grbVehicule
            // 
            grbVehicule.Controls.Add(btnValiderV);
            grbVehicule.Controls.Add(checkBox1);
            grbVehicule.Controls.Add(label8);
            grbVehicule.Controls.Add(label7);
            grbVehicule.Controls.Add(lblEtat);
            grbVehicule.Controls.Add(txtModel);
            grbVehicule.Controls.Add(lblModel);
            grbVehicule.Controls.Add(txtCouleur);
            grbVehicule.Controls.Add(lblCouleur);
            grbVehicule.Controls.Add(txtImmat);
            grbVehicule.Controls.Add(lblImmat);
            grbVehicule.Location = new Point(12, 41);
            grbVehicule.Name = "grbVehicule";
            grbVehicule.Size = new Size(330, 254);
            grbVehicule.TabIndex = 3;
            grbVehicule.TabStop = false;
            grbVehicule.Text = "Vehicule";
            // 
            // btnValiderV
            // 
            btnValiderV.Location = new Point(156, 209);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(89, 23);
            btnValiderV.TabIndex = 15;
            btnValiderV.TabStop = false;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = true;
            btnValiderV.Click += btnValiderV_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(113, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Check Etat";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 209);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 174);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 10;
            // 
            // lblEtat
            // 
            lblEtat.AutoSize = true;
            lblEtat.Location = new Point(36, 139);
            lblEtat.Name = "lblEtat";
            lblEtat.Size = new Size(27, 15);
            lblEtat.TabIndex = 9;
            lblEtat.Text = "Etat";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(113, 94);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 7;
            txtModel.Text = "textmodel";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(22, 94);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 6;
            lblModel.Text = "model";
            // 
            // txtCouleur
            // 
            txtCouleur.Location = new Point(113, 56);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.Size = new Size(100, 23);
            txtCouleur.TabIndex = 5;
            txtCouleur.Text = "txtCouleur";
            // 
            // lblCouleur
            // 
            lblCouleur.AutoSize = true;
            lblCouleur.Location = new Point(21, 57);
            lblCouleur.Name = "lblCouleur";
            lblCouleur.Size = new Size(49, 15);
            lblCouleur.TabIndex = 4;
            lblCouleur.Text = "Couleur";
            // 
            // txtImmat
            // 
            txtImmat.Location = new Point(113, 27);
            txtImmat.Name = "txtImmat";
            txtImmat.Size = new Size(100, 23);
            txtImmat.TabIndex = 3;
            txtImmat.Text = "txtmax";
            // 
            // grbLecon
            // 
            grbLecon.Controls.Add(lblLecon);
            grbLecon.Controls.Add(btnValiderF);
            grbLecon.Controls.Add(chkEtat);
            grbLecon.Controls.Add(dtpHeure);
            grbLecon.Controls.Add(dtpLecon);
            grbLecon.Controls.Add(label11);
            grbLecon.Controls.Add(txtVehicule);
            grbLecon.Controls.Add(lblVehicule);
            grbLecon.Controls.Add(txtEleve);
            grbLecon.Controls.Add(lblEleve);
            grbLecon.Location = new Point(257, 343);
            grbLecon.Name = "grbLecon";
            grbLecon.Size = new Size(346, 217);
            grbLecon.TabIndex = 4;
            grbLecon.TabStop = false;
            grbLecon.Text = "Lecon";
            // 
            // lblLecon
            // 
            lblLecon.AutoSize = true;
            lblLecon.Location = new Point(45, 85);
            lblLecon.Name = "lblLecon";
            lblLecon.Size = new Size(39, 15);
            lblLecon.TabIndex = 18;
            lblLecon.Text = "Lecon";
            // 
            // btnValiderF
            // 
            btnValiderF.Location = new Point(177, 166);
            btnValiderF.Name = "btnValiderF";
            btnValiderF.Size = new Size(79, 24);
            btnValiderF.TabIndex = 17;
            btnValiderF.Text = "Valider";
            btnValiderF.UseVisualStyleBackColor = true;
            // 
            // chkEtat
            // 
            chkEtat.AutoSize = true;
            chkEtat.Location = new Point(46, 166);
            chkEtat.Name = "chkEtat";
            chkEtat.Size = new Size(82, 19);
            chkEtat.TabIndex = 16;
            chkEtat.Text = "Check Etat";
            chkEtat.UseVisualStyleBackColor = true;
            // 
            // dtpHeure
            // 
            dtpHeure.Location = new Point(113, 114);
            dtpHeure.Name = "dtpHeure";
            dtpHeure.Size = new Size(98, 23);
            dtpHeure.TabIndex = 15;
            dtpHeure.Tag = "dtpHeure";
            // 
            // dtpLecon
            // 
            dtpLecon.Location = new Point(113, 85);
            dtpLecon.Name = "dtpLecon";
            dtpLecon.Size = new Size(100, 23);
            dtpLecon.TabIndex = 14;
            dtpLecon.Tag = "dtpLecon";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 114);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 9;
            label11.Text = "Heure";
            // 
            // txtVehicule
            // 
            txtVehicule.Location = new Point(113, 56);
            txtVehicule.Name = "txtVehicule";
            txtVehicule.Size = new Size(100, 23);
            txtVehicule.TabIndex = 5;
            txtVehicule.Text = "Vehicule";
            // 
            // lblVehicule
            // 
            lblVehicule.AutoSize = true;
            lblVehicule.Location = new Point(40, 56);
            lblVehicule.Name = "lblVehicule";
            lblVehicule.Size = new Size(51, 15);
            lblVehicule.TabIndex = 4;
            lblVehicule.Text = "Vehicule";
            // 
            // txtEleve
            // 
            txtEleve.Location = new Point(113, 27);
            txtEleve.Name = "txtEleve";
            txtEleve.Size = new Size(100, 23);
            txtEleve.TabIndex = 3;
            txtEleve.Text = "Eleve";
            // 
            // lblEleve
            // 
            lblEleve.AutoSize = true;
            lblEleve.Location = new Point(45, 27);
            lblEleve.Name = "lblEleve";
            lblEleve.Size = new Size(34, 15);
            lblEleve.TabIndex = 2;
            lblEleve.Text = "Eleve";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblInscription);
            groupBox3.Controls.Add(btnValiderE);
            groupBox3.Controls.Add(dtpInscription);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(lblCredit);
            groupBox3.Controls.Add(textPrenom);
            groupBox3.Controls.Add(lblPrenom);
            groupBox3.Controls.Add(textNom);
            groupBox3.Controls.Add(lblNom);
            groupBox3.Location = new Point(506, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 274);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eleve";
            // 
            // textNom
            // 
            textNom.Location = new Point(140, 22);
            textNom.Name = "textNom";
            textNom.Size = new Size(100, 23);
            textNom.TabIndex = 5;
            textNom.Text = "1";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(48, 23);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 4;
            lblNom.Text = "Nom";
            // 
            // textPrenom
            // 
            textPrenom.Location = new Point(140, 66);
            textPrenom.Name = "textPrenom";
            textPrenom.Size = new Size(100, 23);
            textPrenom.TabIndex = 7;
            textPrenom.Text = "2";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(48, 67);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 6;
            lblPrenom.Text = "Prénom";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(140, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            textBox6.Text = "3";
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Location = new Point(48, 113);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(39, 15);
            lblCredit.TabIndex = 8;
            lblCredit.Text = "Crédit";
            // 
            // dtpInscription
            // 
            dtpInscription.Location = new Point(139, 161);
            dtpInscription.Name = "dtpInscription";
            dtpInscription.Size = new Size(143, 23);
            dtpInscription.TabIndex = 10;
            // 
            // btnValiderE
            // 
            btnValiderE.Location = new Point(90, 225);
            btnValiderE.Name = "btnValiderE";
            btnValiderE.Size = new Size(111, 22);
            btnValiderE.TabIndex = 11;
            btnValiderE.Text = "Valider";
            btnValiderE.UseVisualStyleBackColor = true;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Location = new Point(20, 167);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(100, 15);
            lblInscription.TabIndex = 12;
            lblInscription.Text = "Date d'inscription";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 642);
            Controls.Add(groupBox3);
            Controls.Add(grbLecon);
            Controls.Add(grbVehicule);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMenu";
            Text = "Form1";
            grbVehicule.ResumeLayout(false);
            grbVehicule.PerformLayout();
            grbLecon.ResumeLayout(false);
            grbLecon.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblImmat;
        private GroupBox grbVehicule;
        private TextBox txtCouleur;
        private Label lblCouleur;
        private TextBox txtImmat;
        private Label lblEtat;
        private TextBox txtModel;
        private Label lblModel;
        private Label label8;
        private Label label7;
        private GroupBox grbLecon;
        private Label label11;
        private TextBox txtVehicule;
        private Label lblVehicule;
        private TextBox txtEleve;
        private Label lblEleve;
        private Button btnValiderV;
        private CheckBox checkBox1;
        private DateTimePicker dtpLecon;
        private DateTimePicker dtpHeure;
        private Label lblLecon;
        private Button btnValiderF;
        private CheckBox chkEtat;
        private GroupBox groupBox3;
        private TextBox textBox6;
        private Label lblCredit;
        private TextBox textPrenom;
        private Label lblPrenom;
        private TextBox textNom;
        private Label lblNom;
        private DateTimePicker dtpInscription;
        private Button btnValiderE;
        private Label lblInscription;
=======
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Form1";
        }

        #endregion
>>>>>>> 6ebb0e31ae27bf7d6e3fa844b3d83e01a81fcc7d
    }
}