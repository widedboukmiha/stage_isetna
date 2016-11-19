using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using stage_isetna.Views.Filiere;
using stage_isetna.Views.Groupe;
using stage_isetna.Views.Niveau;

namespace stage_isetna
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil ());
        }
    }
}
