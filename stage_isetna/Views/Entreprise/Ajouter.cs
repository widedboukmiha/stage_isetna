using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Entreprises
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            new DataAccess.EntrepriseDA().Create(
                txtNom.Text,
                textBox1.Text,
                comboBox1.Text,
                textBox3.Text
            );

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
