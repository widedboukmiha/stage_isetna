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
    public partial class ModifierEtudiant : Form
    {
        public ModifierEtudiant()
        {
            InitializeComponent();
        }


        private void enablebtnAjout()
        {
            if (TestUnitaire.VerifChaineVide(txtcin.Text) && TestUnitaire.VerifChaineVide(txtnom.Text) && TestUnitaire.VerifChaineVide(txtprenom.Text))

                TestUnitaire.EnableButton(btnModifier);

        }








        private void txtnom_TextChanged_1(object sender, EventArgs e)
        {
            if (TestUnitaire.VerifChaine(txtnom.Text) == false)
            {
                errorProvider1.SetError(this.txtnom, "Name is required.");
            }
            else
            {
                errorProvider1.SetError(this.txtnom, string.Empty);
            }
            enablebtnAjout();
        }



        private void txtprenom_TextChanged_1(object sender, EventArgs e)
        {
            if (TestUnitaire.VerifChaine(txtprenom.Text))
            {
                errorProvider1.SetError(this.txtprenom, "Name is required.");

            }
            else
            {
                errorProvider1.SetError(this.txtprenom, string.Empty);

            }
            enablebtnAjout();
        }

        private void txtdate_TextChanged_1(object sender, EventArgs e)
        {
            enablebtnAjout();
        }

        private void txtadr_TextChanged_1(object sender, EventArgs e)
        {
            enablebtnAjout();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            txtcin.Clear();
            txtnom.Clear();
            txtmail.Clear();
            txtadr.Clear();
            txttel.Clear();
            txtprenom.Clear();
            txtdate.Clear();
            txtcodepost.Clear();
            comboDep.SelectedItem = -1;
            comboFiliere.SelectedItem = false;
            comboGroupe.SelectedItem = false;
            comboVille.SelectedItem = -1;

        }



        private void txttel_TextChanged_2(object sender, EventArgs e)
        {
            try
            {


                if (TestUnitaire.VerifCin(txtcin.Text) == true)
                {
                    errorProvider1.SetError(this.txttel, "Name is required.");

                }
                else
                {
                    errorProvider1.SetError(this.txttel, String.Empty);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Vérifier le numéro du carte d'identité !!");
                txttel.Text = "";
            }
        }

        private void txtmail_TextChanged_1(object sender, EventArgs e)
        {
            if (TestUnitaire.VerifMail(txtmail.Text))
            {
                errorProvider1.SetError(this.txtmail, "Mail is required.");

            }
            else
            {
                errorProvider1.SetError(this.txtmail, String.Empty);
            }
            enablebtnAjout();
        }

        private void txtcin_TextChanged(object sender, EventArgs e)
        {


            try
            {


                if (TestUnitaire.VerifCin(txtcin.Text) == true)
                {
                    errorProvider1.SetError(this.txtcin, "Name is required.");

                }
                else
                {
                    errorProvider1.SetError(this.txtcin, String.Empty);
                }
                enablebtnAjout();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Vérifier le numéro du carte d'identité !!");
                txtcin.Text = "";
            }
        }
    }
}
