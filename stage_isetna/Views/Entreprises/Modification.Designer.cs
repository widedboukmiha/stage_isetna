namespace stage_isetna.Views.Entreprises
{
    partial class Modification
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
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.comboVille = new System.Windows.Forms.ComboBox();
            this.nomEntreprise = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.idEntreprise = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(443, 444);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(119, 32);
            this.btAnnuler.TabIndex = 35;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btModifier
            // 
            this.btModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.Location = new System.Drawing.Point(251, 444);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(119, 32);
            this.btModifier.TabIndex = 34;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            // 
            // comboVille
            // 
            this.comboVille.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            this.comboVille.Location = new System.Drawing.Point(382, 291);
            this.comboVille.Name = "comboVille";
            this.comboVille.Size = new System.Drawing.Size(243, 29);
            this.comboVille.TabIndex = 33;
            // 
            // nomEntreprise
            // 
            this.nomEntreprise.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nomEntreprise.Location = new System.Drawing.Point(382, 214);
            this.nomEntreprise.Name = "nomEntreprise";
            this.nomEntreprise.Size = new System.Drawing.Size(243, 29);
            this.nomEntreprise.TabIndex = 32;
            // 
            // telephone
            // 
            this.telephone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.telephone.Location = new System.Drawing.Point(382, 365);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(243, 29);
            this.telephone.TabIndex = 31;
            // 
            // idEntreprise
            // 
            this.idEntreprise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEntreprise.Location = new System.Drawing.Point(382, 138);
            this.idEntreprise.Name = "idEntreprise";
            this.idEntreprise.Size = new System.Drawing.Size(243, 29);
            this.idEntreprise.TabIndex = 30;
            this.idEntreprise.TextChanged += new System.EventHandler(this.idEntreprise_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(292, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 37);
            this.label7.TabIndex = 29;
            this.label7.Text = "Modifier Entreprise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(198, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "N° Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(246, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(186, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nom Entreprise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id Entreprise";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 521);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.comboVille);
            this.Controls.Add(this.nomEntreprise);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.idEntreprise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modification";
            this.Text = "Modifier Entreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.ComboBox comboVille;
        private System.Windows.Forms.TextBox nomEntreprise;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox idEntreprise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}