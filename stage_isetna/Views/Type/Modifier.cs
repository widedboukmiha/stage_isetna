using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Type
{
    public partial class Modifier : Form
    {
        private int Id;

        public Modifier(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                new DataAccess.TypeDA().Update(Id, txtNom.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Supprimer(Id).ShowDialog();
            this.Close();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            var element = new DataAccess.TypeDA().Get(Id);
            txtNom.Text = element.Nom;
        }
    }
}
