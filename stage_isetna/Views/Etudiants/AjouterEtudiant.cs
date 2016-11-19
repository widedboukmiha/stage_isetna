using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stage_isetna.Views;

namespace stage_isetna
{
    public partial class AjouterEtudiant : Form
    {
        public AjouterEtudiant()
        {
            InitializeComponent();
        }
        private void enablebtnAjout()
        {
            if (TestUnitaire.VerifChaineVide(txtcin.Text) && TestUnitaire.VerifChaineVide(txtnom.Text) && TestUnitaire.VerifChaineVide(txtprenom.Text))

                TestUnitaire.EnableButton(btnAjouter);

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
                MessageBox.Show("Vérifier le numéro du carte d'identité !!"+ex.Message);
                txtcin.Text = "";
            }
        }





        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            if (TestUnitaire.VerifChaine(txtnom.Text))
            {
                errorProvider1.SetError(this.txtnom, "Name is required.");
            }
            else
            {
                errorProvider1.SetError(this.txtnom, string.Empty);
            }
            enablebtnAjout();
        }



        private void txtprenom_TextChanged(object sender, EventArgs e)
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

        private void txtdate_TextChanged(object sender, EventArgs e)
        {
            enablebtnAjout();
        }

        private void txtadr_TextChanged(object sender, EventArgs e)
        {
            enablebtnAjout();
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (TestUnitaire.VerifCin(txttel.Text) == true)
                {
                    errorProvider1.SetError(this.txttel, "Name is required.");

                }
                else
                {
                    errorProvider1.SetError(this.txttel, String.Empty);
                }
                enablebtnAjout();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Vérifier le numéro du carte d'identité !!"+ex.Message);
                txtcin.Text = "";
            }
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtcin.Clear();
            txtnom.Clear();
            txtmail.Clear();
            txtadr.Clear();
            txttel.Clear();
            txtprenom.Clear();

            txtcodepost.Clear();
            comboNi.SelectedItem = -1;
            comboFiliere.SelectedItem = false;
            comboGroupe.SelectedItem = false;
            comboVille.SelectedItem = -1
                ;
        }
        DataAccess.EtudiantDA etud = new DataAccess.EtudiantDA();
        private void AjouterEtudiant_Load(object sender, EventArgs e)
        {
            etud.remplircombo(comboGroupe, "[Group]", "Nom", "Id");
            etud.remplircombo(comboFiliere, "Filiere", "Nom", "Id");
            etud.remplircombo(comboNi, "Niveau", "Nom", "Id");
        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            etud.viderFromAjout(panel2);
        }
    }
}
