using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Entreprise
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string NumTel { get; set; }

        public Entreprise(int Id,string Nom,string Adresse,string Ville,string NumTel)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Adresse = Adresse;
            this.Ville = Ville;
            this.NumTel = NumTel;
        }

        public Entreprise() { }

        public override string ToString()
        {
            return Nom;
        }
    }
}
