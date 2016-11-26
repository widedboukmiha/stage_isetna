using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stage_isetna.DataAccess
{
    class StageDA
    {
        //private string conString = Properties.Settings.Default.chaine;
        //private string conString = Properties.Settings.Default.chaineHabib;
        //private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";

        public void Create(DateTime DateDebut, DateTime DateFin, double Note, bool Etat, int TypeId, int EtudiantId, int EntrepriseId)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Stage] VALUES ((SELECT MAX(Id) + 1 FROM [Stage]), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", DateDebut, DateFin, Note, Etat, TypeId, EtudiantId, EntrepriseId);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Stage] VALUES (1, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", DateDebut, DateFin, Note, Etat, TypeId, EtudiantId, EntrepriseId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Business.Stage> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Stage]", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Stage(dataRow.Field<int>("TypeId"), dataRow.Field<int>("EtudiantId"), dataRow.Field<int>("EntrepriseId"))
            {
                Id = dataRow.Field<int>("Id"),
                DateDebut = dataRow.Field<DateTime>("DateDebut"),
                DateFin = dataRow.Field<DateTime>("DateFin"),
                Etat = dataRow.Field<bool>("Etat"),
                Note = dataRow.Field<decimal>("Note")
            }).ToList();

            return list;
        }

        public Business.Stage Get(int Id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Stage] WHERE Id = " + Id.ToString(), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Stage(dataRow.Field<int>("TypeId"), dataRow.Field<int>("EtudiantId"), dataRow.Field<int>("EntrepriseId"))
            {
                Id = dataRow.Field<int>("Id"),
                DateDebut = dataRow.Field<DateTime>("DateDebut"),
                DateFin = dataRow.Field<DateTime>("DateFin"),
                Etat = dataRow.Field<bool>("Etat"),
                Note = dataRow.Field<decimal>("Note")
            }).ToList();

            return list[0];
        }

        public bool Get(string Cin)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT [Stage].* FROM [Stage], [Etudiant] WHERE [Stage].EtudiantId = [Etudiant].Id AND Cin = '" + Cin + "'", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Stage(dataRow.Field<int>("TypeId"), dataRow.Field<int>("EtudiantId"), dataRow.Field<int>("EntrepriseId"))
            {
                Id = dataRow.Field<int>("Id"),
                DateDebut = dataRow.Field<DateTime>("DateDebut"),
                DateFin = dataRow.Field<DateTime>("DateFin"),
                Etat = dataRow.Field<bool>("Etat"),
                Note = dataRow.Field<decimal>("Note")
            }).ToList();

            return list.Count > 0;
        }

        public void Update(int Id, DateTime DateDebut, DateTime DateFin, double Note, bool Etat, int TypeId, int EtudiantId, int EntrepriseId)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Stage] SET DateDebut = '{1}', DateFin = '{2}', Note = '{3}', Etat = '{4}', TypeId = '{5}', EtudiantId = '{6}', EntrepriseId = '{7}' WHERE Id = {0}", Id, DateDebut, DateFin, Note, Etat, TypeId, EtudiantId, EntrepriseId);
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
                    cmd.CommandText = String.Format("DELETE FROM [Stage] WHERE Id = {0}", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Stage> Find(string query)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT [Stage].* FROM [Stage], [Etudiant], [Type], [Entreprise] WHERE ([Entreprise].Id = [Stage].EntrepriseId AND [Etudiant].Id = [Stage].EtudiantId AND [Type].Id = [Stage].TypeId) AND ([Etudiant].Cin LIKE '%" + query + "%' OR [Type].Nom LIKE '%" + query + "%' OR [Entreprise].Nom LIKE '%" + query + "%' OR DateDebut LIKE '%" + query + "%' OR DateFin LIKE '%" + query + "%' OR Note LIKE '%" + query + "%')", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Stage(dataRow.Field<int>("TypeId"), dataRow.Field<int>("EtudiantId"), dataRow.Field<int>("EntrepriseId"))
            {
                Id = dataRow.Field<int>("Id"),
                DateDebut = dataRow.Field<DateTime>("DateDebut"),
                DateFin = dataRow.Field<DateTime>("DateFin"),
                Etat = dataRow.Field<bool>("Etat"),
                Note = dataRow.Field<decimal>("Note")
            }).ToList();

            return list;
        }
    }
}
