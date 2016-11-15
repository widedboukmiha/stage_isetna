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

namespace stage_isetna
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AjouterGroupe addgrp = new AjouterGroupe();
            addgrp.Show();
        }

        private void btnAjoutStage_Click_1(object sender, EventArgs e)
        {
            AjouterStage ajoutstage = new AjouterStage();
            ajoutstage.Show();
        }

        private void adfiliere_Click_1(object sender, EventArgs e)
        {

            AjouterFiliere addfiliere = new AjouterFiliere();
            addfiliere.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AjouterNiveau nv = new AjouterNiveau();
            nv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stage_isetna.Views.Entreprises.Ajout ajoutEntreprise = new stage_isetna.Views.Entreprises.Ajout();
            ajoutEntreprise.Show();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AjouterEtudiant ad = new AjouterEtudiant();
            ad.Show();

        }

   

        private void Accueil_Load(object sender, EventArgs e)
        {
            //List<Filiere> listFiliere;
            //List<Group> listGroupe;
            //List<Niveau> listNiveau;

            //listFiliere = DataAccess.FiliereDA.Get();
            //listGroupe = DataAccess.GroupeDA.Get();
            //listNiveau = DataAccess.NiveauDA.Get();

            //dataGridView4.DataSource = listFiliere;
            //dataGridViewGroupe.DataSource = listGroupe;


            //DataGridViewButtonColumn detg = new DataGridViewButtonColumn();
            //dataGridViewGroupe.Columns.Add(detg);
            //detg.Text = "Detaille";
            //detg.Name = "button";
            //detg.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn updg = new DataGridViewButtonColumn();
            //dataGridViewGroupe.Columns.Add(updg);
            //updg.Text = "modifier";
            //updg.Name = "button";
            //updg.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn supg = new DataGridViewButtonColumn();
            //dataGridViewGroupe.Columns.Add(supg);
            //supg.Text = "Supprimer";
            //supg.Name = "button";
            //supg.UseColumnTextForButtonValue = true;


            //DataGridViewButtonColumn det = new DataGridViewButtonColumn();
            //dataGridView4.Columns.Add(det);
            // det.Text = "Detaille";
            //det.Name = "button";          
            //det.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn upd = new DataGridViewButtonColumn();
            //dataGridView4.Columns.Add(upd);
            //upd.Text = "modifier";
            //upd.Name = "button";
            //upd.UseColumnTextForButtonValue = true;

            //DataGridViewButtonColumn sup = new DataGridViewButtonColumn();
            //dataGridView4.Columns.Add(sup);
            //sup.Text = "Supprimer";
            //sup.Name = "button";
            //sup.UseColumnTextForButtonValue = true;



        }


        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifierFiliere updfiliere = new ModifierFiliere();
            if (dataGridView4.Columns.Contains("upd") && e.ColumnIndex == dataGridView4.Columns["upd"].Index)//Specify which column contains Button in DGV
            {
                MessageBox.Show("hi");
               
                //updfiliere.Show();
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
                    addtable = new Etudiant() {
                        Id = 0,
                        Cin = Convert.ToString(dr[0]),
                        Nom = Convert.ToString(dr[1]),
                        Prenom = Convert.ToString(dr[2]),
                        DateNaissance = DateTime.Parse(dr[3].ToString()),
                        Adresse = Convert.ToString(dr[4]),
                        CodePostal = Convert.ToString(dr[5]),
                        Tel = Convert.ToString(dr[6]),
                        Email = Convert.ToString(dr[7]),
                        NiveauId = Convert.ToInt32(dr[8]),
                        FiliereId = Convert.ToInt32(dr[9]),
                        GroupId = Convert.ToInt32(dr[10])
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
    }
    }


