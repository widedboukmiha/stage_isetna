namespace stage_isetna.Views.Utilisateurs
{
    partial class AfficherUtilisateur
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
            this.AjouterUser = new System.Windows.Forms.Button();
            this.ModifierUser = new System.Windows.Forms.Button();
            this.SupprimerUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // AjouterUser
            // 
            this.AjouterUser.Location = new System.Drawing.Point(570, 61);
            this.AjouterUser.Name = "AjouterUser";
            this.AjouterUser.Size = new System.Drawing.Size(140, 41);
            this.AjouterUser.TabIndex = 0;
            this.AjouterUser.Text = "Ajouter Utilisateurs";
            this.AjouterUser.UseVisualStyleBackColor = true;
            this.AjouterUser.Click += new System.EventHandler(this.AjouterUser_Click);
            // 
            // ModifierUser
            // 
            this.ModifierUser.Location = new System.Drawing.Point(570, 153);
            this.ModifierUser.Name = "ModifierUser";
            this.ModifierUser.Size = new System.Drawing.Size(140, 41);
            this.ModifierUser.TabIndex = 1;
            this.ModifierUser.Text = "Modifier Utilisateur";
            this.ModifierUser.UseVisualStyleBackColor = true;
            this.ModifierUser.Click += new System.EventHandler(this.ModifierUser_Click);
            // 
            // SupprimerUser
            // 
            this.SupprimerUser.Location = new System.Drawing.Point(570, 234);
            this.SupprimerUser.Name = "SupprimerUser";
            this.SupprimerUser.Size = new System.Drawing.Size(140, 41);
            this.SupprimerUser.TabIndex = 2;
            this.SupprimerUser.Text = "Supprimer Utilisateur";
            this.SupprimerUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(521, 324);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // AfficherUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 480);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.SupprimerUser);
            this.Controls.Add(this.ModifierUser);
            this.Controls.Add(this.AjouterUser);
            this.Name = "AfficherUtilisateur";
            this.Text = "AfficherUtilisateur";
            this.Load += new System.EventHandler(this.AfficherUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AjouterUser;
        private System.Windows.Forms.Button ModifierUser;
        private System.Windows.Forms.Button SupprimerUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}