using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    class Entreprise
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;

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

        public Entreprise(int v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
