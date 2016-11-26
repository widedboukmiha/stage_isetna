using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Group
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int NiveauId { get; set; }
        public int FiliereId { get; set; }

        public Niveau Niveau { get; set; }
        public Filiere Filiere { get; set; }

        public Group (int niveau, int filiere)
        {
            NiveauId = niveau;
            Niveau = new DataAccess.NiveauDA().Get(NiveauId);

            FiliereId = filiere;
            Filiere = new DataAccess.FiliereDA().Get(FiliereId);
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
