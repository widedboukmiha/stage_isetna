using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.DataAccess
{
    class NiveauDA
    {
        private string conString = "";
        public void Create(Business.Niveau niveau)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO Niveau VALUES (NULL, '{0}')", niveau.Nom);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Niveau> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Niveau", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Niveau { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
           return list;
        }

        public Business.Niveau Get(int id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Niveau WHERE Id = " + id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Niveau { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list[0];
        }

        public void Update(int id, Business.Niveau niveau)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE Niveau SET Nom = '{0}' WHERE Id = {1}", niveau.Nom, id);
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
                    cmd.CommandText = String.Format("DELETE FROM Niveau WHERE Id = {0})", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
