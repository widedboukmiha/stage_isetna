using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (new DataAccess.UsersDA().checkedLogin(txtNom.Text, textBox1.Text))
            {
                this.Hide();
                new Accueil().ShowDialog();
                Application.Exit();
            } else
            {
                MessageBox.Show("Login ou mot de passe non valid!");
            }
        }
    }
}
