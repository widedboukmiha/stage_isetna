using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Etudiant
    {
        public int Id { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public int NiveauId { get; set; }
        public int FiliereId { get; set; }
        public int GroupId { get; set; }

        public Niveau Niveau { get; set; }
        public Filiere Filiere { get; set; }
        public Group Group { get; set; }

        public Etudiant(int niveau, int filiere, int group)
        {
            NiveauId = niveau;
            FiliereId = filiere;
            GroupId = group;

            Niveau = new DataAccess.NiveauDA().Get(NiveauId);
            Filiere = new DataAccess.FiliereDA().Get(FiliereId);
            Group = new DataAccess.GroupeDA().Get(GroupId);
        }
    }
}
