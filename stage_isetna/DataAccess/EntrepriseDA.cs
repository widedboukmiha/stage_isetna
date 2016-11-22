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
        //private string conString = Properties.Settings.Default.chaine;
        //private string conString = Properties.Settings.Default.chaineHabib;
        //private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";

        public void Create(string Nom, string Adresse, string Ville, string NumTel)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO [Entreprise] VALUES ((SELECT MAX(Id) + 1 FROM [Entreprise]), '{0}', '{1}', '{2}', '{3}')", Nom, Adresse, Ville, NumTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Entreprise> Get()
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

        public Business.Entreprise Get(int Id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Entreprise] WHERE Id = " + Id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Entreprise
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom"),
                Adresse = dataRow.Field<string>("Adresse"),
                Ville = dataRow.Field<string>("Ville"),
                NumTel = dataRow.Field<string>("NumTel")
            }).ToList();

            return list[0];
        }
        public Business.Entreprise Get(string Nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Entreprise] WHERE Nom = '" + Nom + "'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }


            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Entreprise
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom"),
                Adresse = dataRow.Field<string>("Adresse"),
                Ville = dataRow.Field<string>("Ville"),
                NumTel = dataRow.Field<string>("NumTel")
            }).ToList();

            return list[0];
        }

        public void Update(int Id, string Nom, string Adresse, string Ville, string NumTel)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Entreprise] SET Nom = '{1}', Adresse = '{2}', Ville = '{3}', NumTel = '{4}' WHERE Id = {0}", Id, Nom, Adresse, Ville, NumTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM [Entreprise] WHERE Id = {0}", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Entreprise> Find(string Nom, string Adresse, string Ville, string NumTel)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Entreprise] WHERE Nom LIKE '%" + Nom + "%' OR Adresse LIKE '%" + Adresse + "%' OR Ville LIKE '%" + Ville + "%' OR NumTel LIKE '%" + NumTel + "%'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Entreprise
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom"),
                Adresse = dataRow.Field<string>("Adresse"),
                Ville = dataRow.Field<string>("Ville"),
                NumTel = dataRow.Field<string>("NumTel")
            }).ToList();

            return list;
        }
    }
}
