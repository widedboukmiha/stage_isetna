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
        //SqlConnection conString = new SqlConnection(Properties.Settings.Default.chaineHabib);
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        public EntrepriseDA()
        {

        }
        public static List<Business.Entreprise> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Entreprise]", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Entreprise {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom"),
                Adresse = dataRow.Field<string>("Adresse"),
                Ville = dataRow.Field<string>("Ville"),
                NumTel = dataRow.Field<string>("NumTel")
            }).ToList();
            return list;
        }

        private static int afficheMax()
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

        public static bool Create(Business.Entreprise e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Entreprise] VALUES ((SELECT MAX(Id) + 1 FROM [Group]), '{0}', '{1}', '{2}', '{3}')", e.Nom, e.Adresse, e.Ville, e.NumTel);
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean Update(int id, stage_isetna.Business.Entreprise en)
        {

            try
            {
                SqlConnection conString = new SqlConnection(EntrepriseDA.conString);
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

