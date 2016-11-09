using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace stage_isetna.DataAccess
{
    class EntrepriseDA  
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.ch);
        public  List<stage_isetna.Business.Entreprise> Retrive()
        {
            List<stage_isetna.Business.Entreprise> listEntreprise=new List<stage_isetna.Business.Entreprise>();
            try
            {
                string req = string.Format("SELECT * FROM Entreprise");
                cn.Open();
                SqlCommand cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                MessageBox.Show(Reader.GetInt32(0)+"");
                    listEntreprise.Add(new stage_isetna.Business.Entreprise(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3)));
                }
                Reader.Close();
            
                cn.Close();
            }
           catch (Exception ex)
            { 
             
            }

            return listEntreprise;
        }

        public Boolean Insert(stage_isetna.Business.Entreprise e)
        {
            try
            {
                cn.Open();
                string strQuery = "INSERT INTO Entreprise  VALUES (@id, @nomEntreprise,@tel,@adresse)";
                SqlCommand cmd = new SqlCommand(strQuery, cn);
                cmd.Parameters.AddWithValue("@id", e.getId());
                cmd.Parameters.AddWithValue("@nomEntreprise", e.getnomEntreprise());
                cmd.Parameters.AddWithValue("@tel", e.getTelephone());
                cmd.Parameters.AddWithValue("@adresse", e.getAdresse());
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

        public Boolean Update(int id, stage_isetna.Business.Entreprise en)
        {
            
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Entreprise set nomEntreprise='"+en.getnomEntreprise()+"',"+"telephone='"+en.getTelephone()+"',adresse='"+en.getAdresse()+"' where id="+id, cn);
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
                string req = string.Format("DELETE FROM Entreprise WHERE id = " + id );
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

