using stage_isetna.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.DataAccess
{
    class EntreprisesDA
    {
        public static List<Entreprise> Retrive ()
        {
            return new List<Entreprise>();
        }

        public static Entreprise Retrive(string condition)
        {
            return new Entreprise();
        }

        public static bool Create(Entreprise entreprise)
        {
            return true;
        }

        public static bool Update(Entreprise entreprise)
        {
            return true;
        }

        public static bool Delete(Entreprise entreprise)
        {
            return true;
        }
    }
}
