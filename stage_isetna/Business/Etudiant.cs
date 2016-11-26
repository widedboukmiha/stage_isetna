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
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime AnneeUniv { get; set; }
        public int GroupId { get; set; }

        public Group Group { get; set; }

        public Etudiant(int group)
        {
            GroupId = group;
            Group = new DataAccess.GroupeDA().Get(GroupId);
        }
    }
}
