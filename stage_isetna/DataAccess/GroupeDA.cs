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
    class GroupeDA
    {
        //private string conString = Properties.Settings.Default.chaine;
        //private string conString = Properties.Settings.Default.chaineHabib;
        //private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";

        public void Create(string nom, int niveau, int filiere)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO [Group] VALUES ((SELECT MAX(Id) + 1 FROM [Group]), '{0}', '{1}', '{2}')", nom, filiere, niveau);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Group> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group(dataRow.Field<int>("NiveauId"), dataRow.Field<int>("FiliereId")) {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom")
            }).ToList();
            return list;
        }
        
        public Business.Group Get(int Id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE Id = " + Id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group(dataRow.Field<int>("NiveauId"), dataRow.Field<int>("FiliereId"))
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom")
            }).ToList();
            return list[0];
        }

        public Business.Group Get(string Nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE Nom = '" + Nom + "'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group(dataRow.Field<int>("NiveauId"), dataRow.Field<int>("FiliereId"))
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom")
            }).ToList();
            return list[0];
        }



        public void Update(int Id, string Nom)

        {
            using (SqlConnection con = new SqlConnection(conString))

            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Group] SET Nom = '{0}' WHERE Id = {1}", Nom, Id);
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
                    cmd.CommandText = String.Format("DELETE FROM [Group] WHERE Id = {0}", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public List<Business.Group> Find(string Nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE Nom LIKE '%" + Nom + "%'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group(dataRow.Field<int>("NiveauId"), dataRow.Field<int>("FiliereId"))
            {
                Id = dataRow.Field<int>("Id"),
                Nom = dataRow.Field<string>("Nom")
            }).ToList();
            return list;
        }
    }
}
