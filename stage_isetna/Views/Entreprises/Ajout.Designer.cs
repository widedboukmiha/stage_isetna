namespace stage_isetna.Views.Entreprises
{
    partial class Ajout
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
            this.btAjouter = new System.Windows.Forms.Button();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.nomEntreprise = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.idEntreprise = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAjouter
            // 
            this.btAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouter.Location = new System.Drawing.Point(263, 439);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(119, 32);
            this.btAjouter.TabIndex = 23;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // comboVille
            // 
            this.comboVille.FormattingEnabled = true;
            this.comboVille.Items.AddRange(new object[] {
            "Tunis",
            "Manouba",
            "Ariana",
            "Ben arous",
            "Bizerte",
            "Beja ",
            "Jandouba ",
            "Kef",
            "Kasserine",
            "Gafsa",
            "Sfax",
            "Soussa",
            "Monastir",
            "Mednine ",
            "Tataouine",
            "Mahdia ",
            "Sidi bouzid",
            "Zaghouan",
            "Siliana",
            "Tozeur",
            "Nabeul",
            "Kebili",
            "Kairouan",
            "Gabes"});
            this.comboVille.Location = new System.Drawing.Point(394, 286);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(243, 21);
            this.comboVille.TabIndex = 22;
            // 
            // nomEntreprise
            // 
            this.nomEntreprise.Location = new System.Drawing.Point(394, 209);
            this.nomEntreprise.Name = "nomEntreprise";
            this.nomEntreprise.Size = new System.Drawing.Size(243, 20);
            this.nomEntreprise.TabIndex = 21;
            this.nomEntreprise.TextChanged += new System.EventHandler(this.nomEntreprise_TextChanged);
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(394, 360);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(243, 20);
            this.telephone.TabIndex = 20;
            this.telephone.TextChanged += new System.EventHandler(this.telephone_TextChanged);
            this.telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telephone_KeyPress);
            // 
            // idEntreprise
            // 
            this.idEntreprise.Location = new System.Drawing.Point(394, 133);
            this.idEntreprise.Name = "idEntreprise";
            this.idEntreprise.Size = new System.Drawing.Size(243, 20);
            this.idEntreprise.TabIndex = 19;
            this.idEntreprise.TextChanged += new System.EventHandler(this.idEntreprise_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(304, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ajouter Entreprise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(210, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "N° Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(258, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(198, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom Entreprise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Entreprise";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(437, 439);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(119, 32);
            this.btAnnuler.TabIndex = 25;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.comboVille);
            this.Controls.Add(this.nomEntreprise);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.idEntreprise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajout";
            this.Text = "Ajouter Entreprise";
            this.Load += new System.EventHandler(this.Ajout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.ComboBox comboVille;
        private System.Windows.Forms.TextBox nomEntreprise;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox idEntreprise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnnuler;
    }
}