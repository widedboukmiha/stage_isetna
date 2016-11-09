using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna
{
    public partial class Entreprise : Form
    {
        public Entreprise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stage_isetna.DataAccess.EntrepriseDA en = new stage_isetna.DataAccess.EntrepriseDA();
            List<stage_isetna.Business.Entreprise> l=en.Retrive();
            foreach(stage_isetna.Business.Entreprise el in l)
            {
                MessageBox.Show(el.getId()+" "+ el.getnomEntreprise()+" "+el.getTelephone());
                label1.Text = el.getId() + " " + el.getnomEntreprise() + " " + el.getTelephone();
            }
            //stage_isetna.Business.Entreprise en = new stage_isetna.Business.Entreprise(2, "Igarashi", "Japan", "71596");
            //stage_isetna.DataAccess.EntrepriseDA eDA = new stage_isetna.DataAccess.EntrepriseDA();
            //Boolean test= eDA.Update(2,en);
            //if(test==true)
            //{
              // MessageBox.Show("Insertion effectué avec  succes");
            //}
            //else
            //{
                //MessageBox.Show("Insertion echoué");
            //}
        }
    }
}
