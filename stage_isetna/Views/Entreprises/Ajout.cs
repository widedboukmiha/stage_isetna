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
    public partial class Ajout : Form
    {
        public Ajout()
        {
            InitializeComponent();
        }

        private void Ajout_Load(object sender, EventArgs e)
        {
            btAjouter.Enabled = false;
            comboVille.Items.Add("Selectionner une ville");
            comboVille.Items.Add("Ariana");
            comboVille.Items.Add("Tunis");
            comboVille.Items.Add("Ben Arous");
            comboVille.Items.Add("Manouba");
            comboVille.Items.Add("Bizerte");
            comboVille.Items.Add("Nabeul");
            comboVille.Items.Add("Sousse");
            comboVille.Items.Add("Monasstir");
            comboVille.Items.Add("Mahdia");
            comboVille.Items.Add("Sfax");
            comboVille.Items.Add("Gabes");
            comboVille.Items.Add("Mednin");
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboVille.SelectedItem.ToString());
        }

        private void idEntreprise_TextChanged(object sender, EventArgs e)
        {
            if ((idEntreprise.Text != "") && (nomEntreprise.Text != "") && (telephone.Text != ""))
            {
                btAjouter.Enabled = true;
            }
            else
            {
                btAjouter.Enabled = false;
            }
        }

        private void nomEntreprise_TextChanged(object sender, EventArgs e)
        {
            if ((idEntreprise.Text != "") && (nomEntreprise.Text != "") && (telephone.Text != ""))
            {
                btAjouter.Enabled = true;
            }
            else
            {
                btAjouter.Enabled = false;
            }
        }

        private void telephone_TextChanged(object sender, EventArgs e)
        {
            if ((idEntreprise.Text != "") && (nomEntreprise.Text != "") && (telephone.Text != ""))
            {
                btAjouter.Enabled = true;
            }
            else
            {
                btAjouter.Enabled = false;
            }
        }

        private void telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8)
            {
                e.KeyChar = (char)0;
            }
        }
    }
}
