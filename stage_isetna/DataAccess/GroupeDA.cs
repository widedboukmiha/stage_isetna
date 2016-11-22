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
        // private static string conString = Properties.Settings.Default.chaineHabib;
        // private static string conString = Properties.Settings.Default.chaine;
        //private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        public GroupeDA()
        {

        }
        public static void Create(string Nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("INSERT INTO [Group] VALUES ((SELECT MAX(Id) + 1 FROM [Group]), '{0}')", Nom);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Business.Group> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list;
        }


        public Business.Group Get(int id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE Id = " + id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }


            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();
            return list[0];
        }
        public Business.Group Get(string nom)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE Nom = '" + nom + "'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }


            var liste = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Group { Id = dataRow.Field<int>("Id"), Nom = dataRow.Field<string>("Nom") }).ToList();

            return liste[0];
        }


        public static void Update(int id, String Nom)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Group] SET Nom = '{0}' WHERE Id = {1}", Nom, id);
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
                    cmd.CommandText = String.Format("DELETE FROM [Group] WHERE Id = {0})", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void searchGrid(DataGridView v, string value)
        {
            //Recherhce
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select * from Groupe where nom like'" + value + "%'", conString);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Groupe");
                tab1 = dtst.Tables["Groupe"];
                v.DataSource = tab1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
