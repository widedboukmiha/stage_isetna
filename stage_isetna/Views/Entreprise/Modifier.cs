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
    public partial class Modifier : Form
    {
        private int Id;

        public Modifier(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Supprimer(Id).ShowDialog();
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            new DataAccess.EntrepriseDA().Update(
                Id,
                txtNom.Text,
                textBox1.Text,
                comboBox1.Text,
                textBox3.Text
            );

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
