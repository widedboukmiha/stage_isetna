using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stage_isetna.Views
{
    public class TestUnitaire
    {



        public static void EnableButton(Button btn)
        {

            btn.Enabled = true;

        }

        public static bool VerifChaineVide(string chaine_caractere)
        {

            if (string.IsNullOrEmpty(chaine_caractere) == false)
            {

                return false;
            }
            else
            {
                return true;
            }

        }


        public static bool VerifMail(string mail)
        {
            Regex expr = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(mail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool VerifChaine(string donnee)
        {
            Regex reg = new Regex(@"[a-zA-Z]");

            if (!reg.IsMatch(donnee))
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool VerifCin(string cin)
        {
            int x;
            bool res = Int32.TryParse(cin, out x);
            if ((cin.Length > 8) | (cin.Length < 8) | (res == false))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}


