using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stage_isetna.Views.Filiere;
using stage_isetna.Views.Groupe;
using stage_isetna.Views.Niveau;
using stage_isetna.Views.Stage;

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
    }
}

