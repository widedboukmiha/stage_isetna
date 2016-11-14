using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace stage_isetna.DataAccess
{
    class EtudiantDA
    {
       /* SqlConnection cn = new SqlConnection(Properties.Settings.Default.ch);

        public List<stage_isetna.Business.Etudiant> Retrive()
        {
            List<stage_isetna.Business.Etudiant> listEtudiant = new List<stage_isetna.Business.Etudiant>();
            return listEtudiant;
        }

        public Boolean Insert(stage_isetna.Business.Etudiant e)
        {
            try
            {
                cn.Open();
                string strQuery = "INSERT INTO Entreprise  VALUES (@cin, @nom,@tel,@prenom,@date_naissance,@adresse,@ville,@code_postal,@num_telephone,@groupe,@filiere,@departement,@email)";
                SqlCommand cmd = new SqlCommand(strQuery, cn);
                cmd.Parameters.AddWithValue("@cin", e.getCin());
                cmd.Parameters.AddWithValue("@nom", e.getNom());
                cmd.Parameters.AddWithValue("@prenom", e.getPrenom());
                cmd.Parameters.AddWithValue("@date_naissance", e.getDate_naissance());
                cmd.Parameters.AddWithValue("@adresse", e.getAdresse());
                cmd.Parameters.AddWithValue("@ville", e.getVille());
                cmd.Parameters.AddWithValue("@code_postal", e.getCode_postal());
                cmd.Parameters.AddWithValue("@num_telephone", e.getTelephone());
                cmd.Parameters.AddWithValue("@groupe", e.getGroupe());
                cmd.Parameters.AddWithValue("@filiere", e.getFiliere());
                cmd.Parameters.AddWithValue("@departement", e.getDepartement());
                cmd.Parameters.AddWithValue("@email", e.getEmail());
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                String er = ex.Message;
                return false;
            }
        }

        public Boolean Update(int id, stage_isetna.Business.Etudiant et)
        {
            return false;
        }

        public Boolean Remove(String cin)
        {
            return false;
        }*/

    }
}
