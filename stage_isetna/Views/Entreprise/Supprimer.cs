﻿using System;
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
    public partial class Supprimer : Form
    {
        private int Id;

        public Supprimer(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            new DataAccess.EntrepriseDA().Delete(Id);
            this.Close();
        }
    }
}
