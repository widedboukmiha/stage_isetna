using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Stage
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal Note { get; set; }
        public bool Etat { get; set; }
        public int TypeId { get; set; }
        public int EtudiantId { get; set; }
        public int EntrepriseId { get; set; }
        public virtual Type Type { get; set;}
        public virtual Etudiant Etudiant { get; set; }
        public virtual Entreprise Entreprise { get; set; }

        public Stage(int type, int etudiant, int entreprise)
        {
            TypeId = type;
            EtudiantId = etudiant;
            EntrepriseId = entreprise;

            Type = new DataAccess.TypeDA().Get(TypeId);
            Etudiant = new DataAccess.EtudiantDA().Get(EtudiantId);
            Entreprise = new DataAccess.EntrepriseDA().Get(EntrepriseId);
        }
    }
}
