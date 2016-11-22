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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    int id = Int32.Parse(txtId.Text);
            //    DataAccess.FiliereDA.Create(id, txtFiliere.Text);
            //    MessageBox.Show("Ajouter Filiere Avec Succées");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                DataAccess.FiliereDA.Create(txtFiliere.Text);
                MessageBox.Show("Ajouter Filiere Avec Succées");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtId.Text = "";
            txtFiliere.Text = "";
        }
    }
}
