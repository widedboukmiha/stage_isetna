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
    public partial class ModifierGroupe : Form
    {
        public ModifierGroupe()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);
                DataAccess.GroupeDA.Update(id, txtNom.Text);
                MessageBox.Show("Modifier Groupe Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
