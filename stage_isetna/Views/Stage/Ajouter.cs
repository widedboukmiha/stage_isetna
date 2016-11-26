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
            int type = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value);
            int etudiant = Convert.ToInt32((comboBox2.SelectedItem as ComboboxItem).Value);
            int entreprise = Convert.ToInt32((comboBox3.SelectedItem as ComboboxItem).Value);

            new DataAccess.StageDA().Create(
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

        private void Ajouter_Load(object sender, EventArgs e)
        {
            var types = from type in new DataAccess.TypeDA().Get()
                        select new ComboboxItem()
                        {
                            Text = type.Nom,
                            Value = type.Id
                        };

            var entreprises = from entreprise in new DataAccess.EntrepriseDA().Get()
                              select new ComboboxItem()
                              {
                                  Text = entreprise.Nom,
                                  Value = entreprise.Id
                              };

            var etudiants = from etudiant in new DataAccess.EtudiantDA().Get()
                            where etudiant.AnneeUniv == DateTime.Now.Year + " - " + (DateTime.Now.Year + 1)
                            select new ComboboxItem()
                            {
                                Text = etudiant.Cin,
                                Value = etudiant.Id
                            };

            comboBox1.DataSource = types.ToList();
            comboBox2.DataSource = etudiants.ToList();
            comboBox3.DataSource = entreprises.ToList();
        }
    }
}
