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
                new DataAccess.GroupeDA().Update(Id, txtNom.Text);
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

            var element = new DataAccess.GroupeDA().Get(Id);
            txtNom.Text = element.Nom;

            int i = 0;
            foreach (ComboboxItem item in comboBox1.Items)
            {
                if (Convert.ToInt32(item.Value) == element.NiveauId)
                {
                    comboBox1.SelectedIndex = i;
                }

                i++;
            }

            i = 0;
            foreach (ComboboxItem item in comboBox2.Items)
            {
                if (Convert.ToInt32(item.Value) == element.FiliereId)
                {
                    comboBox2.SelectedIndex = i;
                }

                i++;
            }
        }
    }
}
