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
    public partial class Supprimer : Form
    {
        private int Id;

        public Supprimer(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                new DataAccess.NiveauDA().Delete(Id);
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
    }
}
