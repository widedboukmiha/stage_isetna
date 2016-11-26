using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Stage
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
            int type = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value);
            int etudiant = Convert.ToInt32((comboBox2.SelectedItem as ComboboxItem).Value);
            int entreprise = Convert.ToInt32((comboBox3.SelectedItem as ComboboxItem).Value);

            new DataAccess.StageDA().Update(
                Id,
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                double.Parse(textBox1.Text),
                true,
                type,
                etudiant,
                entreprise
            );

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            var types = from @group in new DataAccess.TypeDA().Get()
                        select new ComboboxItem()
                        {
                            Text = @group.Nom,
                            Value = @group.Id
                        };

            var etudiants = from @group in new DataAccess.EtudiantDA().Get()
                            select new ComboboxItem()
                            {
                                Text = @group.Cin,
                                Value = @group.Id
                            };

            var entreprises = from @group in new DataAccess.EntrepriseDA().Get()
                              select new ComboboxItem()
                              {
                                  Text = @group.Nom,
                                  Value = @group.Id
                              };

            comboBox1.DataSource = types.ToList();
            comboBox2.DataSource = etudiants.ToList();
            comboBox3.DataSource = entreprises.ToList();

            var element = new DataAccess.StageDA().Get(Id);

            dateTimePicker1.Value = element.DateDebut;
            dateTimePicker2.Value = element.DateFin;
            textBox1.Text = element.Note.ToString();

            int i = 0;
            foreach (ComboboxItem item in comboBox1.Items)
            {
                if (Convert.ToInt32(item.Value) == element.TypeId)
                {
                    comboBox1.SelectedIndex = i;
                }

                i++;
            }

            i = 0;
            foreach (ComboboxItem item in comboBox2.Items)
            {
                if (Convert.ToInt32(item.Value) == element.EtudiantId)
                {
                    comboBox1.SelectedIndex = i;
                }

                i++;
            }

            i = 0;
            foreach (ComboboxItem item in comboBox3.Items)
            {
                if (Convert.ToInt32(item.Value) == element.EntrepriseId)
                {
                    comboBox1.SelectedIndex = i;
                }

                i++;
            }
        }
    }
}
