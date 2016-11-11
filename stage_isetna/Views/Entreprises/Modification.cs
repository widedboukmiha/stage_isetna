using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views.Entreprises
{
    public partial class Modification : Form
    {
        public Modification()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            idEntreprise.Clear();
            nomEntreprise.Clear();
            telephone.Clear();
        }

        private void idEntreprise_TextChanged(object sender, EventArgs e)
        {
            if((idEntreprise.Text!="")&&(nomEntreprise.Text!="")&&(telephone.Text!=""))
            {
                btModifier.Enabled = true;
            }
            else
            {
                btModifier.Enabled = false;
            }
        }
    }
}
