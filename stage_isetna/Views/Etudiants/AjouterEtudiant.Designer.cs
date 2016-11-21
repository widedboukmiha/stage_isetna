namespace stage_isetna
{
    partial class AjouterEtudiant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterEtudiant));
            this.txtcodepost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboFiliere = new System.Windows.Forms.ComboBox();
            this.comboNi = new System.Windows.Forms.ComboBox();
            this.comboGroupe = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtcin = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodepost
            // 
            this.txtcodepost.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtcodepost.Location = new System.Drawing.Point(328, 489);
            this.txtcodepost.Name = "txtcodepost";
            this.txtcodepost.Size = new System.Drawing.Size(315, 25);
            this.txtcodepost.TabIndex = 35;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(181, 489);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 30);
            this.label23.TabIndex = 34;
            this.label23.Text = "Code Postal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // comboFiliere
            // 
            this.comboFiliere.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboFiliere.FormattingEnabled = true;
            this.comboFiliere.Location = new System.Drawing.Point(869, 364);
            this.comboFiliere.Name = "comboFiliere";
            this.comboFiliere.Size = new System.Drawing.Size(315, 25);
            this.comboFiliere.TabIndex = 31;
            // 
            // comboNi
            // 
            this.comboNi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboNi.FormattingEnabled = true;
            this.comboNi.Location = new System.Drawing.Point(869, 433);
            this.comboNi.Name = "comboNi";
            this.comboNi.Size = new System.Drawing.Size(315, 25);
            this.comboNi.TabIndex = 30;
            this.comboNi.SelectedIndexChanged += new System.EventHandler(this.comboDep_SelectedIndexChanged);
            // 
            // comboGroupe
            // 
            this.comboGroupe.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboGroupe.FormattingEnabled = true;
            this.comboGroupe.Location = new System.Drawing.Point(869, 305);
            this.comboGroupe.Name = "comboGroupe";
            this.comboGroupe.Size = new System.Drawing.Size(315, 25);
            this.comboGroupe.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 119);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.Location = new System.Drawing.Point(747, 637);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(231, 40);
            this.btnAnnuler.TabIndex = 27;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.TextChanged += new System.EventHandler(this.button3_Click);
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.Location = new System.Drawing.Point(442, 637);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(222, 40);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(214, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 30);
            this.label13.TabIndex = 25;
            this.label13.Text = "Adresse";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(869, 243);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(315, 25);
            this.txtmail.TabIndex = 24;
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(738, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Groupe *";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(738, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 30);
            this.label15.TabIndex = 19;
            this.label15.Text = "Filiére *";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(738, 433);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 30);
            this.label16.TabIndex = 18;
            this.label16.Text = "Niveau *";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(738, 240);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 30);
            this.label17.TabIndex = 17;
            this.label17.Text = "Email";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txttel.Location = new System.Drawing.Point(869, 171);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(315, 25);
            this.txttel.TabIndex = 16;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // txtadr
            // 
            this.txtadr.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtadr.Location = new System.Drawing.Point(328, 425);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(315, 25);
            this.txtadr.TabIndex = 13;
            this.txtadr.TextChanged += new System.EventHandler(this.txtadr_TextChanged);
            // 
            // txtprenom
            // 
            this.txtprenom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtprenom.Location = new System.Drawing.Point(328, 299);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(315, 25);
            this.txtprenom.TabIndex = 11;
            this.txtprenom.TextChanged += new System.EventHandler(this.txtprenom_TextChanged);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtnom.Location = new System.Drawing.Point(328, 227);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(315, 25);
            this.txtnom.TabIndex = 10;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // txtcin
            // 
            this.txtcin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcin.Location = new System.Drawing.Point(328, 166);
            this.txtcin.Name = "txtcin";
            this.txtcin.Size = new System.Drawing.Size(315, 25);
            this.txtcin.TabIndex = 9;
            this.txtcin.TextChanged += new System.EventHandler(this.txtcin_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(134, 360);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 30);
            this.label18.TabIndex = 8;
            this.label18.Text = "Date de Naissance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(214, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 30);
            this.label19.TabIndex = 7;
            this.label19.Text = "Prenom *";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(219, 225);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 30);
            this.label20.TabIndex = 6;
            this.label20.Text = "Nom *";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(219, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 30);
            this.label21.TabIndex = 5;
            this.label21.Text = "Cin *";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(732, 175);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 30);
            this.label24.TabIndex = 2;
            this.label24.Text = "Téléphone";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(562, 47);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(229, 37);
            this.label25.TabIndex = 0;
            this.label25.Text = "Ajouter Etudiant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.txtcodepost);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboFiliere);
            this.panel2.Controls.Add(this.comboNi);
            this.panel2.Controls.Add(this.comboGroupe);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.btnAjouter);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtmail);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txttel);
            this.panel2.Controls.Add(this.txtadr);
            this.panel2.Controls.Add(this.txtprenom);
            this.panel2.Controls.Add(this.txtnom);
            this.panel2.Controls.Add(this.txtcin);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 733);
            this.panel2.TabIndex = 31;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtdate.Location = new System.Drawing.Point(328, 370);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(315, 25);
            this.txtdate.TabIndex = 36;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 733);
            this.Controls.Add(this.panel2);
            this.Name = "AjouterEtudiant";
            this.Text = "Ajouter Etudiant";
            this.Load += new System.EventHandler(this.AjouterEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodepost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboFiliere;
        private System.Windows.Forms.ComboBox comboNi;
        private System.Windows.Forms.ComboBox comboGroupe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtcin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtdate;
    }
}