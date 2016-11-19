using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace stage_isetna.DataAccess
{
    class UsersDA
    {
        //private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private static string conString = Properties.Settings.Default.chaineHabib;
        public static void Create(string Cin , string Nom , string Prenom , string Mail , string Login , string Password)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO [Users] VALUES ((SELECT MAX(Id) + 1 FROM [Users]), '{0}' , '{1}' , '{2}' , '{3}', '{4}' , '{5}')", Cin ,Nom , Prenom , Mail ,Login , Password );
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Business.Users> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT Id , Cin , Nom , Prenom , Mail , Login FROM Users", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Users { Id = dataRow.Field<int>("Id"), Cin = dataRow.Field<string>("Cin"), Nom = dataRow.Field<string>("Nom"), Prenom = dataRow.Field<string>("Prenom"), Mail = dataRow.Field<string>("Mail"), Login = dataRow.Field<string>("Login") }).ToList();
            return list;
        }

        public static bool VerifierCin(int id , string Cin )
        {


            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT Cin  FROM Users where Id = " + id , new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                //DataTable table = new DataTable();
                //table.Load(cmd.ExecuteReader());
                //ds.Tables.Add(table);


                if (cmd.Parameters["@Id"].Value == id.ToString())
                {
                    return true; 

                }

                else
                {
                    return false; 
                }
            }
           


        }

        public static void Update(  string Cin, string Nom, string Prenom, string Mail, string Login, string Password)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE Users SET Cin = '{1}' , Nom ='{2}' , Prenom = '{3}', Mail = '{4}' , Login = '{5}' , Password = '{6}' WHERE Cin = {1}" ,  Cin , Nom , Prenom , Mail , Login , Password);
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
                    cmd.CommandText = String.Format("DELETE FROM Users WHERE Id = {0})", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
