﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Utilisateurs
{
    public partial class ModifierUtilisateurs : Form
    {
        public ModifierUtilisateurs()
        {
            InitializeComponent();
        }

        private void Adduser_Click(object sender, EventArgs e)
        {
            try
            {

                DataAccess.UsersDA.Update(txtId.Text , txtId.Text, txtNom.Text, txtPrenom.Text, txtMail.Text, txtLogin.Text, txtPass.Text);
                MessageBox.Show("Users Modifier Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
