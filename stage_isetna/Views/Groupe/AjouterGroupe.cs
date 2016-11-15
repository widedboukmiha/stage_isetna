using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Groupe
{
    public partial class AjouterGroupe : Form
    {
        public AjouterGroupe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataAccess.GroupeDA.Create( txtNom.Text);
                MessageBox.Show("Ajouter Filiere Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
