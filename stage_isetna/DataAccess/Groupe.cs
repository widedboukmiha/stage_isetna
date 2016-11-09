using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_Stage_ISET_CHARGUIA.Business
{
    class Groupe
    {
        private String id_Groupe;
        private String nom_Groupe;

        public Groupe(String id_Groupe, String nom_Groupe)
        {
            this.id_Groupe = id_Groupe;
            this.nom_Groupe = nom_Groupe;

        }

        public String getId_Groupe()
        {
            return id_Groupe;
        }
        public String getNom_Groupe()
        {
            return nom_Groupe;
        }

        public void setId_Groupe(String id_Groupe)
        {
            this.id_Groupe = id_Groupe;
        }

        public void setNom_Groupe(String nom_Groupe)
        {
            this.nom_Groupe = nom_Groupe;
        }

         public String toString()
        {
            return "id_Groupe=" + id_Groupe + ", nom_Groupe=" + nom_Groupe;
                    
        }


    }
   
}
