using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Filiere
{
    public partial class ModifierFiliere : Form
    {
        public ModifierFiliere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                DataAccess.FiliereDA.Update(id, txtNom.Text);
                MessageBox.Show("Ajouter Filiere Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
