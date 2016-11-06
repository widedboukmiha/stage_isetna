using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.Business
{

    class Etudiant
    {
        private String cin;
        private String nom;
        private String prenom;
        private String date_naissance;
        private String adresse;
        private String ville;
        private int code_postal;
        private String num_telephone;
        private String groupe;
        private String filiere;
        private String departement;
        private String email;
        public Etudiant()
        {

        }
        public Etudiant(String cin,String nom,String prenom,String date_naissance,String adresse,String ville,
            int code_postal, String num_telephone, String groupe,String filiere,String departement,String email)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.adresse = adresse;
            this.ville = ville;
            this.code_postal = code_postal;
            this.num_telephone = num_telephone;
            this.groupe = groupe;
            this.filiere = filiere;
            this.departement = departement;
            this.email = email;
        }

        public String getCin()
        {
            return this.cin;
        }

        public void setCin(String cin)
        {
            this.cin = cin;
        }

        public String getNom()
        {
            return this.nom;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }

        public String setDate_naissance()
        {
            return this.date_naissance;
        }

        public void setDate_naissance(String date_naissance)
        {
            this.date_naissance = date_naissance;
        }

        public String getAdresse()
        {
            return this.adresse;
        }

        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }

        public void setVille(String ville)
        {
            this.ville = ville;
        }

        public String getVille()
        {
            return this.ville;
        }

        public void setDepartement(String departement)
        {
            this.departement = departement;
        }

        public String getDepartement()
        {
            return this.departement;
        }

        public int getCode_postal()
        {
            return this.code_postal;
        }

        public void setCode_postal(int code_postal)
        {
            this.code_postal = code_postal;
        }

        public String getTelephone()
        {
            return this.num_telephone;
        }

        public void setTelephone(String num_telephone)
        {
            this.num_telephone = num_telephone;
        }

        public String getEmail()
        {
            return this.email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setFiliere(String filiere)
        {
            this.filiere = filiere;
        }

        public String getFiliere()
        {
            return this.filiere;
        }

        public String getGroupe()
        {
            return this.groupe;
        }

        public void setGroupe(String groupe)
        {
            this.groupe = groupe;
        }
    }
}
