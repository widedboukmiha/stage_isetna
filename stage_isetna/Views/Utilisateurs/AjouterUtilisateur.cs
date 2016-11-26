using System;
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
    public partial class AjouterUtilisateur : Form
    {
        public AjouterUtilisateur()
        {
            InitializeComponent();
        }

        private void Adduser_Click(object sender, EventArgs e)
        {

            try
            {

                DataAccess.UserDA.Create(txtCin.Text , txtNom.Text , txtPrenom.Text , txtMail.Text , txtLogin.Text , txtPass.Text);
                MessageBox.Show("Ajouter Filiere Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
