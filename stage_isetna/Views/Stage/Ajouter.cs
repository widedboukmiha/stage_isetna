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
        }
    }
}
