using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace stage_isetna.DataAccess
{
    class FiliereDA
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ch);
        public List<stage_isetna.Business.Filiere> Retrive()
        {
            List<stage_isetna.Business.Filiere> listGroupe =new List<Business.Filiere>();
            try
            {
                string req = string.Format("SELECT * FROM Filiere");
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    
                    listGroupe.Add(new stage_isetna.Business.Filiere(Reader.GetString(0), Reader.GetString(1)));
                }
                Reader.Close();

                cn.Close();
                return listFiliere;
            }
            catch (Exception ex)
            {

            }
            return listFiliere;


        }

        public Boolean Insert(stage_isetna.Business.Groupe f)
        {
            try
            {
                cn.Open();
                string strQuery = "INSERT INTO Groupe  VALUES (@id, @nomFiliere)";
                SqlCommand cmd = new SqlCommand(strQuery, cn);
                cmd.Parameters.AddWithValue("@id", f.getId_Groupe());
                cmd.Parameters.AddWithValue("@nomFiliere",f.getNom_Groupe());
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

        public Boolean Update(int id, stage_isetna.Business.Filiere f)
        {

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Filiere set nomFiliere='" + f.getNom_Filiere().ToString() + "' where id='"+id+"'" );
                SqlDataReader Reader = cmd.ExecuteReader();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                String er = ex.Message;
                return false;
            }
        }

        public Boolean Remove(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = Properties.Settings.Default.ch;
            try
            {
                string req = string.Format("DELETE FROM Filiere WHERE id = " + id);
                cmd.Connection = connexion;
                connexion.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                connexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

