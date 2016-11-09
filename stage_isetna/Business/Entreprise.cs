using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{
    public class Entreprise
    {
        
        private int id;
        private String nomEntreprise;
        private String adresse;
        private String telephone;

        public Entreprise()
        {

        }

        public Entreprise(int id,String nomEntreprise,String adresse,String telephone)
        {
            this.id = id;
            this.nomEntreprise = nomEntreprise;
            this.adresse = adresse;
            this.telephone = telephone;
        }
        public int getId()
        {
            return id;
        }

        public String getnomEntreprise()
        {
            return nomEntreprise;
        }
        public String getTelephone()
        {
            return telephone;
        }
        public String getAdresse()
        {
            return adresse;
        }
    }
}
