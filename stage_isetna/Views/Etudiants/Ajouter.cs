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
                int group = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value);

                new DataAccess.EtudiantDA().Create(
                    txtNom.Text,
                    textBox1.Text,
                    textBox7.Text,
                    textBox3.Text,
                    textBox5.Text,
                    textBox4.Text,
                    dateTimePicker1.Value,
                    group,
                    textBox6.Text,
                    DateTime.Now
                );
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
            var groupes = from @group in new DataAccess.GroupeDA().Get()
                          select new ComboboxItem()
                          {
                              Text = @group.Nom,
                              Value = @group.Id
                          };

            comboBox1.DataSource = groupes.ToList();
        }
    }
}
