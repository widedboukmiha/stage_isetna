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
            //int id = int.Parse(idEntreprise.Text.ToString());
            string nom = nomEntreprise.Text.ToString();
            string ville = comboVille.SelectedItem.ToString();
            string adresse = adresseEntreprise.Text.ToString();
            string tel = telephone.Text.ToString();
            stage_isetna.Business.Entreprise en = new stage_isetna.Business.Entreprise(0, nom, ville, adresse, tel);
            stage_isetna.DataAccess.EntrepriseDA enDA = new stage_isetna.DataAccess.EntrepriseDA();
            Boolean test = DataAccess.EntrepriseDA.Create(en);
            if(test==true)
            {
                MessageBox.Show("Insertion effectué avec succeés");
            }
            else
            {
                MessageBox.Show("Insertion echoué");
            }
            Application.Restart();
        }

       

        private void nomEntreprise_TextChanged(object sender, EventArgs e)
        {
            if ((nomEntreprise.Text != "") && (telephone.Text != "") && (adresseEntreprise.Text != ""))
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
            if ((nomEntreprise.Text != "") && (telephone.Text != "") && (adresseEntreprise.Text != ""))
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

        private void adresse_TextChanged(object sender, EventArgs e)
        {
            if ((nomEntreprise.Text != "") && (telephone.Text != "")&&(adresseEntreprise.Text!=""))
            {
                btAjouter.Enabled = true;
            }
            else
            {
                btAjouter.Enabled = false;
            }
        }
    }
}
