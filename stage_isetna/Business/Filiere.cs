using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_Stage_ISET_CHARGUIA.Business
{
    class Filiere
    {
        private String id_filiere;
        private String nom_filiere;

        public Filiere(String id_filiere, String nom_filiere)
        {
            this.id_filiere = id_filiere;
            this.nom_filiere = nom_filiere;
        }

        public String getId_filiere()
        {
            return id_filiere;
        }

        public String getNom_filiere()
        {
            return nom_filiere;
        }

        public void setId_filiere(String id_filiere)
        {
            this.id_filiere = id_filiere;
        }

        public void setNom_filiere(String nom_filiere)
        {
            this.nom_filiere = nom_filiere;
        }

        public String toString()
        {
            return "Id_filiere=" + id_filiere + ", nom_filiere=" + nom_filiere;

        }




    }
}
