using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace stage_isetna.DataAccess
{
    class EntrepriseDA
    {
        SqlConnection conString = new SqlConnection(Properties.Settings.Default.chaineHabib);
        public EntrepriseDA()
        {

        }
        public List<stage_isetna.Business.Entreprise> Retrive()
        {
            List<stage_isetna.Business.Entreprise> listEntreprise = new List<stage_isetna.Business.Entreprise>();
            try
            {
                string req = string.Format("SELECT * FROM Entreprise");
                conString.Open();
                SqlCommand cmd = new SqlCommand(req, conString);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    MessageBox.Show(Reader.GetInt32(0) + "");
                    listEntreprise.Add(new stage_isetna.Business.Entreprise(Reader.GetInt32(0), Reader.GetString(1), Reader.GetString(2), Reader.GetString(3), Reader.GetString(4)));
                }
                Reader.Close();

                conString.Close();
            }
            catch (Exception ex)
            {

            }

            return listEntreprise;
        }

        private int afficheMax()
        {
            int r = 0;
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.chaineHabib); // ya jmé3a lazim t7otou chaine de connexion imté3kom fi el blassa hadhi 
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select Max(id) from Entreprise";
            cn.Open();
            r = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            return r;
        }

        public Boolean Insert(stage_isetna.Business.Entreprise e)
        {
            try
            {
                conString.Open();
                string strQuery = "INSERT INTO Entreprise  VALUES (@id, @nomEntreprise,@adresse,@ville,@numTel)";
                SqlCommand cmd = new SqlCommand(strQuery, conString);
                cmd.Parameters.AddWithValue("@id", afficheMax()+1);
                cmd.Parameters.AddWithValue("@nomEntreprise", e.Nom);
                cmd.Parameters.AddWithValue("@adresse", e.Adresse);
                cmd.Parameters.AddWithValue("@ville", e.Ville);
                cmd.Parameters.AddWithValue("@numTel", e.NumTel);
                cmd.Connection = conString;
                cmd.ExecuteNonQuery();
                conString.Close();
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
                conString.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Entreprise set nomEntreprise='" + en.Nom + "'," + "telephone='" + en.NumTel + "',adresse='" + en.Adresse + "' where id=" + id, conString);
                SqlDataReader Reader = cmd.ExecuteReader();
                conString.Close();
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
            connexion.ConnectionString = Properties.Settings.Default.chaineHabib;
            try
            {
                string req = string.Format("DELETE FROM Entreprise WHERE id = " + id);
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

        public void afficheGrid(DataGridView v)
        {
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select Nom,Adresse,Ville,numTel from Entreprise ", conString);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Entreprise");
                tab1 = dtst.Tables["Entreprise"];
                v.DataSource = tab1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchGrid(DataGridView v, string value)
        {
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select Nom,Adresse,Ville,numTel from Entreprise where nom like'" + value + "%'", conString);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Entreprise");
                tab1 = dtst.Tables["Entreprise"];
                v.DataSource = tab1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

