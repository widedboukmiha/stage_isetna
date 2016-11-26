using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stage_isetna.Business;
using stage_isetna.Views.Filiere;
using stage_isetna.Views.Groupe;
using stage_isetna.Views.Niveau;
using stage_isetna.Views.Stage;
using System.IO;
using Excel;
using stage_isetna.Views.Utilisateurs;
using System.Data.SqlClient;

namespace stage_isetna
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Views.Groupe.Ajouter().ShowDialog();
            dataGridViewGroupe.DataSource = new DataAccess.GroupeDA().Find(rechercheNomGroupe.Text);
        }

        private void btnAjoutStage_Click_1(object sender, EventArgs e)
        {
            new Views.Stage.Ajouter().ShowDialog();
            dataGridView3.DataSource = new DataAccess.StageDA().Find(textBox9.Text);
        }

        private void adfiliere_Click_1(object sender, EventArgs e)
        {
            new Views.Filiere.Ajouter().ShowDialog();
            dataGridViewNiveau.DataSource = new DataAccess.FiliereDA().Find(nomNiveauRecherche.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Views.Niveau.Ajouter().ShowDialog();
            dataGridViewNiveau.DataSource = new DataAccess.NiveauDA().Find(nomNiveauRecherche.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Views.Entreprises.Ajouter().ShowDialog();
            dataGridEntreprise.DataSource = new DataAccess.EntrepriseDA().Find(nomEntrepriseNom.Text);
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AfficherUtilisateur ad = new AfficherUtilisateur();
            ad.Show();

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

            reload();

            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[5].Visible = false;
            dataGridView3.Columns[6].Visible = false;
            dataGridView3.Columns[7].Visible = false;
            dataGridViewEtudiant.Columns[9].HeaderText = "Annee Universitaire";
            dataGridViewEtudiant.Columns[10].Visible = false;
            dataGridViewGroupe.Columns[2].Visible = false;
            dataGridViewGroupe.Columns[3].Visible = false;
        }

        private void reload()
        {
            dataGridView3.DataSource = new DataAccess.StageDA().Get();
            dataGridViewEtudiant.DataSource = new DataAccess.EtudiantDA().Get();
            dataGridViewGroupe.DataSource = new DataAccess.GroupeDA().Get();
            dataGridEntreprise.DataSource = new DataAccess.EntrepriseDA().Get();
            dataGridViewFiliere.DataSource = new DataAccess.FiliereDA().Get();
            dataGridViewNiveau.DataSource = new DataAccess.NiveauDA().Get();
            dataGridTypes.DataSource = new DataAccess.TypeDA().Get();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEtudiant.Columns.Contains("button") && e.ColumnIndex == dataGridViewEtudiant.Columns["button"].Index)//Specify which column contains Button in DGV
            {
                MessageBox.Show("Row " + (e.RowIndex + 1) + " Of " + (e.ColumnIndex + 1) + " th Column button clicked ");
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewFiliere.Columns.Contains("upd") && e.ColumnIndex == dataGridViewFiliere.Columns["upd"].Index)
            //Specify which column contains Button in DGV
            {
                //  MessageBox.Show("hi");
                //ModifierFiliere updfiliere = new ModifierFiliere();
                //updfiliere.Show();
                MessageBox.Show("Row " + (e.RowIndex + 1) + " Of " + (e.ColumnIndex + 1) + " th Column button clicked ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Excel Files | *.xls;*.xlsx;*.xlsm";
            if (ope.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            FileStream stream = new FileStream(ope.FileName, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();
            DataClasses1DataContext conn = new DataClasses1DataContext();
            foreach (DataTable table in result.Tables)
            {
                Etudiant addtable = new stage_isetna.Etudiant();

                foreach (DataRow dr in table.Rows)
                {
                    addtable = new Etudiant()
                    {
                        Id = 0,
                        Cin = Convert.ToString(dr[0]),
                        Nom = Convert.ToString(dr[1]),
                        Prenom = Convert.ToString(dr[2]),
                        DateNaissance = DateTime.Parse(dr[3].ToString()),
                        Adresse = Convert.ToString(dr[4]),
                        CodePostal = Convert.ToString(dr[5]),
                        Tel = Convert.ToString(dr[6]),
                        Email = Convert.ToString(dr[7]),
                        NiveauId = new DataAccess.NiveauDA().Get(Convert.ToString(dr[8])).Id,
                        FiliereId = new DataAccess.FiliereDA().Get(Convert.ToString(dr[9])).Id,
                        GroupId = new DataAccess.GroupeDA().Get(Convert.ToString(dr[10])).Id,
                    };

                    conn.Etudiants.InsertOnSubmit(addtable);
                }
                conn.SubmitChanges();
                excelReader.Close();
                stream.Close();

                MessageBox.Show(conn.Etudiants.Contains(addtable).ToString());
                MessageBox.Show("les etudiants sont ajoutès ");
            }
        }

        private void rechercheNomGroupe_TextChanged(object sender, EventArgs e)
        {
            dataGridViewGroupe.DataSource = new DataAccess.GroupeDA().Find(rechercheNomGroupe.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblheure.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            dataGridEntreprise.DataSource = new DataAccess.EntrepriseDA().Find(nomEntrepriseNom.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            dataGridViewNiveau.DataSource = new DataAccess.NiveauDA().Find(nomNiveauRecherche.Text);
        }

        private void dataGridViewNiveau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Niveau.Modifier(Convert.ToInt16(dataGridViewNiveau.Rows[dataGridViewNiveau.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridViewNiveau.DataSource = new DataAccess.NiveauDA().Find(nomNiveauRecherche.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            dataGridViewFiliere.DataSource = new DataAccess.FiliereDA().Find(textBox10.Text);
        }

        private void dataGridViewFiliere_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Filiere.Modifier(Convert.ToInt16(dataGridViewFiliere.Rows[dataGridViewFiliere.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridViewFiliere.DataSource = new DataAccess.FiliereDA().Find(textBox10.Text);
        }

        private void dataGridViewGroupe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Groupe.Modifier(Convert.ToInt16(dataGridViewGroupe.Rows[dataGridViewGroupe.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridViewGroupe.DataSource = new DataAccess.GroupeDA().Find(rechercheNomGroupe.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Views.Etudiants.Ajouter().ShowDialog();
            dataGridViewEtudiant.DataSource = new DataAccess.EtudiantDA().Find(NomTypeRecherche.Text);
        }

        private void dataGridEntreprise_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Entreprises.Modifier(Convert.ToInt16(dataGridEntreprise.Rows[dataGridEntreprise.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridEntreprise.DataSource = new DataAccess.EntrepriseDA().Find(nomEntrepriseNom.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            parametres parm = new parametres();
            parm.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Views.Type.Ajouter().ShowDialog();
            dataGridTypes.DataSource = new DataAccess.TypeDA().Find(NomTypeRecherche.Text);
        }

        private void dataGridTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Type.Modifier(Convert.ToInt16(dataGridTypes.Rows[dataGridTypes.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridTypes.DataSource = new DataAccess.TypeDA().Find(NomTypeRecherche.Text);
        }

        private void dataGridViewEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Etudiants.Modifier(Convert.ToInt16(dataGridViewEtudiant.Rows[dataGridViewEtudiant.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridViewEtudiant.DataSource = new DataAccess.EtudiantDA().Find(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewEtudiant.DataSource = new DataAccess.EtudiantDA().Find(textBox1.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = new DataAccess.StageDA().Find(textBox9.Text);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            new Views.Stage.Modifier(Convert.ToInt16(dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells[0].Value)).ShowDialog();
            dataGridView3.DataSource = new DataAccess.StageDA().Find(textBox9.Text);
        }

        private void TypeStages_Enter(object sender, EventArgs e)
        {
            dataGridTypes.DataSource = new DataAccess.TypeDA().Get();
        }

        private void Filiéres_Enter(object sender, EventArgs e)
        {
            dataGridViewFiliere.DataSource = new DataAccess.FiliereDA().Get();
        }

        private void Niveaux_Enter(object sender, EventArgs e)
        {
            dataGridViewNiveau.DataSource = new DataAccess.NiveauDA().Get();
        }

        private void Groupes_Enter(object sender, EventArgs e)
        {
            dataGridViewGroupe.DataSource = new DataAccess.GroupeDA().Get();
        }

        private void Entreprises_Enter(object sender, EventArgs e)
        {
            dataGridEntreprise.DataSource = new DataAccess.EntrepriseDA().Get();
        }

        private void Etudiants_Enter(object sender, EventArgs e)
        {
            dataGridViewEtudiant.DataSource = new DataAccess.EtudiantDA().Get();
        }

        private void Stages_Enter(object sender, EventArgs e)
        {
            dataGridView3.DataSource = new DataAccess.StageDA().Get();
        }
    }
}


