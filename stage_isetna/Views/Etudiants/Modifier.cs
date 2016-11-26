using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Etudiants
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
            int group = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value);

            new DataAccess.EtudiantDA().Update(
                Id,
                txtNom.Text,
                textBox1.Text,
                textBox7.Text,
                textBox3.Text,
                textBox5.Text,
                textBox4.Text,
                dateTimePicker1.Value,
                group,
                textBox6.Text
            );

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            var groupes = from @group in new DataAccess.GroupeDA().Get()
                          select new ComboboxItem()
                          {
                              Text = @group.Nom,
                              Value = @group.Id
                          };

            comboBox1.DataSource = groupes.ToList();

            var element = new DataAccess.EtudiantDA().Get(Id);

            txtNom.Text = element.Nom;
            textBox1.Text = element.Prenom;
            textBox3.Text = element.Cin;
            textBox4.Text = element.CodePostal;
            textBox5.Text = element.Adresse;
            textBox6.Text = element.Tel;
            textBox7.Text = element.Email;

            int i = 0;
            foreach (ComboboxItem item in comboBox1.Items)
            {
                if (Convert.ToInt32(item.Value) == element.GroupId)
                {
                    comboBox1.SelectedIndex = i;
                }

                i++;
            }
        }
    }
}
