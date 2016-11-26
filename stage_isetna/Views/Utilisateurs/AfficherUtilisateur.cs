using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stage_isetna.Business;

namespace stage_isetna.Views.Utilisateurs
{
    public partial class AfficherUtilisateur : Form
    {
        public AfficherUtilisateur()
        {
            InitializeComponent();
        }

        private void AjouterUser_Click(object sender, EventArgs e)
        {
            AjouterUtilisateur adduser = new AjouterUtilisateur();
            adduser.Show();

        }

        private void ModifierUser_Click(object sender, EventArgs e)
        {
            ModifierUtilisateurs upduser = new ModifierUtilisateurs();
            upduser.Show();
        }

        private void AfficherUtilisateur_Load(object sender, EventArgs e)
        {
            List<Users> listUser; 
            listUser = DataAccess.UserDA.Get();
            dataGridViewUsers.DataSource = listUser; 
        }
    }
}
