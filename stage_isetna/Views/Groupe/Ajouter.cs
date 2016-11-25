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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                int niveau = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value);
                int filiere = Convert.ToInt32((comboBox2.SelectedItem as ComboboxItem).Value);

                new DataAccess.GroupeDA().Create(txtNom.Text, niveau, filiere);
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

        private void Ajouter_Load(object sender, EventArgs e)
        {
            var niveaux = from niveau in new DataAccess.NiveauDA().Get()
                          select new ComboboxItem()
                          {
                              Text = niveau.Nom,
                              Value = niveau.Id
                          };
            var filieres = from filiere in new DataAccess.FiliereDA().Get()
                           select new ComboboxItem()
                           {
                               Text = filiere.Nom,
                               Value = filiere.Id
                           };

            comboBox1.DataSource = niveaux.ToList();
            comboBox2.DataSource = filieres.ToList();
        }
    }
}
