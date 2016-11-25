using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";

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
                   }
        DataAccess.EtudiantDA etud = new DataAccess.EtudiantDA();
        private void AjouterEtudiant_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapniveau = new SqlDataAdapter("select * from Niveau", conString);
            DataSet dtniveau = new DataSet();
            adapniveau.Fill(dtniveau, "Niveau");
            comboNi.DataSource = dtniveau.Tables[0];
            comboNi.DisplayMember = "Nom"; 
            comboNi.ValueMember = "Id";


            //SqlDataAdapter adapgroupe = new SqlDataAdapter("select * from Group", conString);
            //DataSet dtgroupe = new DataSet();
            //adapgroupe.Fill(dtgroupe, "Group");
            //comboGroupe.DataSource = dtgroupe.Tables[0];
            //comboGroupe.DisplayMember = "Nom";
            //comboGroupe.ValueMember = "Id";



            SqlDataAdapter adapfiliere = new SqlDataAdapter("select * from Filiere", conString);
            DataSet dtfiliere = new DataSet();
            adapfiliere.Fill(dtfiliere, "Filiere");
            comboFiliere.DataSource = dtfiliere.Tables[0];
            comboFiliere.DisplayMember = "Nom";
            comboFiliere.ValueMember = "Id";

        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //etud.viderFromAjout(panel2);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int fil, niv, grou;
            try
            {
                //DataAccess.EtudiantDA.Create(txtnom.Text , txtprenom.Text , txtmail.Text , txtcin.Text , txtadr.Text , txtcodepost.Text , txtdate.Text , comboFiliere.SelectedValue.ToString(), comboNi.SelectedValue.ToString() , comboGroupe.SelectedValue.ToString() , txttel.Text);
                MessageBox.Show("Ajouter Etudiant Avec Succées");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
