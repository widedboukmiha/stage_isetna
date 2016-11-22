using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.DataAccess
{
    class TypeDA
    {
        //private string conString = Properties.Settings.Default.chaine;
        //private string conString = Properties.Settings.Default.chaineHabib;
        //private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";

        public void Create(string Nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO [Type] VALUES ((SELECT MAX(Id) + 1 FROM [Type]), '{0}')", Nom);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Type> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Type]", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Type { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list;
        }

        public Business.Type Get(int Id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Type] WHERE Id = " + Id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Type { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list[0];
        }
        public Business.Type Get(string Nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Type] WHERE Nom = '" + Nom + "'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }


            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Type { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list[0];
        }

        public void Update(int Id, string Nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Type] SET Nom = '{0}' WHERE Id = {1}", Nom, Id);
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
                    cmd.CommandText = String.Format("DELETE FROM [Type] WHERE Id = {0}", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Type> Find(string Nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Type] WHERE Nom LIKE '%" + Nom + "%'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Type { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list;
        }
    }
}
