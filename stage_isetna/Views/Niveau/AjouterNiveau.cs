using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Niveau
{
    public partial class AjouterNiveau : Form
    {
        public AjouterNiveau()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.NiveauDA.Create(txtNom.Text);
                MessageBox.Show("Ajouter Niveau Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
