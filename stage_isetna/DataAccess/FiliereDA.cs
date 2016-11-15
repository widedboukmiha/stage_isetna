using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.DataAccess
{
   class FiliereDA
    {
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        public static void Create(int id , string nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO Filiere VALUES ('" + id + "', '" + nom + "')");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public  static List<Business.Filiere> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Filiere", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Filiere { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list;
        }

        public Business.Filiere Get(int id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Filiere WHERE Id = " + id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Filiere { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list[0];
        }

        public static void Update(int id, string nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE Filiere SET Nom = '{1}' WHERE Id = {0}",  id , nom);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Filiere WHERE Id = {0})", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
