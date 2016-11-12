using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace stage_isetna.DataAccess
{
    class GroupeDA
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ch);
        public List<stage_isetna.Business.Groupe> Retrive()
        {
            List<stage_isetna.Business.Groupe> listGroupe =new List<Business.Groupe>();
            try
            {
                string req = string.Format("SELECT * FROM Groupe");
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    
                    listGroupe.Add(new stage_isetna.Business.Groupe(Reader.GetString(0), Reader.GetString(1)));
                }
                Reader.Close();

                cn.Close();
                return listGroupe;
            }
            catch (Exception ex)
            {

            }
            return listGroupe;


        }

        public Boolean Insert(stage_isetna.Business.Groupe g)
        {
            try
            {
                cn.Open();
                string strQuery = "INSERT INTO Groupe  VALUES (@id, @nomGroupe)";
                SqlCommand cmd = new SqlCommand(strQuery, cn);
                cmd.Parameters.AddWithValue("@id", g.getId_Groupe());
                cmd.Parameters.AddWithValue("@nomGroue",g.getNom_Groupe());
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

        public Boolean Update(int id, stage_isetna.Business.Groupe g)
        {

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Entreprise set NomGroupe='" + g.getNom_Groupe().ToString() + "' where id='"+id+"'" );
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
                string req = string.Format("DELETE FROM Groupe WHERE id = " + id);
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

