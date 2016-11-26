using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Data;


namespace stage_isetna.DataAccess
{
    class EtudiantDA
    {
        //private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wided boukmiha\\Documents\\GitHub\\stage_isetna\\stage_isetna\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        private static string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\stage_isetna\\stage_isetna\\Database\\Database.mdf;Integrated Security=True";
        public EtudiantDA()
        {

        }
        public void Create(string Nom, string prenom, string mail, string cin, string adresse, string codeposte, DateTime datenaiss, int groupe, string tel, DateTime anneeuniv)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Etudiant] VALUES ((SELECT MAX(Id) + 1 FROM [Etudiant]) , '{0}' ,'{1}' , '{2}', '{3}' , '{4}', '{5}' , '{6}' , '{7}', '{8}', '{9}' )", Nom, prenom, cin, datenaiss, adresse, codeposte, tel, mail, anneeuniv, groupe);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Etudiant] VALUES (1 , '{0}' ,'{1}' , '{2}', '{3}' , '{4}', '{5}' , '{6}' , '{7}', '{8}', '{9}' )", Nom, prenom, cin, datenaiss, adresse, codeposte, tel, mail, anneeuniv, groupe);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public List<Business.Etudiant> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiant", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Etudiant(dataRow.Field<int>("GroupId"))
            {
                Id = dataRow.Field<int>("Id"),
                Cin = dataRow.Field<string>("Cin"),
                Nom = dataRow.Field<string>("Nom"),
                Prenom = dataRow.Field<string>("Prenom"),
                DateNaissance = dataRow.Field<DateTime>("DateNaissance"),
                Adresse = dataRow.Field<string>("Adresse"),
                CodePostal = dataRow.Field<string>("CodePostal"),
                Tel = dataRow.Field<string>("Tel"),
                Email = dataRow.Field<string>("Email"),
                AnneeUniv = dataRow.Field<DateTime>("AnneeUniv")
            }).ToList();
            return list;
        }

        public Business.Etudiant Get(int Id)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiant WHERE Id = " + Id, new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Etudiant(dataRow.Field<int>("GroupId"))
            {
                Id = dataRow.Field<int>("Id"),
                Cin = dataRow.Field<string>("Cin"),
                Nom = dataRow.Field<string>("Nom"),
                Prenom = dataRow.Field<string>("Prenom"),
                DateNaissance = dataRow.Field<DateTime>("DateNaissance"),
                Adresse = dataRow.Field<string>("Adresse"),
                CodePostal = dataRow.Field<string>("CodePostal"),
                Tel = dataRow.Field<string>("Tel"),
                Email = dataRow.Field<string>("Email"),
                AnneeUniv = dataRow.Field<DateTime>("AnneeUniv")
            }).ToList();
            return list[0];
        }

        public void Update(int Id, string Nom, string prenom, string mail, string cin, string adresse, string codeposte, DateTime datenaiss, int groupe, string tel)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("UPDATE [Etudiant] SET Nom = '{1}', Prenom = '{2}', Cin = '{3}', DateNaissance = '{4}', Adresse = '{5}', CodePostal = '{6}', Tel = '{7}', Email = '{8}', GroupId = '{9}' WHERE Id = {0}", Id, Nom, prenom, cin, datenaiss, adresse, codeposte, tel, mail, groupe);
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
                    cmd.CommandText = String.Format("DELETE FROM [Etudiant] WHERE Id = {0}", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Business.Etudiant> Find(string query)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM [Etudiant] WHERE Nom LIKE '%{0}%' OR Prenom LIKE '%{0}%' OR Cin LIKE '%{0}%' OR DateNaissance LIKE '%{0}%' OR Adresse LIKE '%{0}%' OR CodePostal LIKE '%{0}%' OR Tel LIKE '%{0}%' OR Email LIKE '%{0}%' OR GroupId LIKE '%{0}%'", query), new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Etudiant(dataRow.Field<int>("GroupId"))
            {
                Id = dataRow.Field<int>("Id"),
                Cin = dataRow.Field<string>("Cin"),
                Nom = dataRow.Field<string>("Nom"),
                Prenom = dataRow.Field<string>("Prenom"),
                DateNaissance = dataRow.Field<DateTime>("DateNaissance"),
                Adresse = dataRow.Field<string>("Adresse"),
                CodePostal = dataRow.Field<string>("CodePostal"),
                Tel = dataRow.Field<string>("Tel"),
                Email = dataRow.Field<string>("Email"),
                AnneeUniv = dataRow.Field<DateTime>("AnneeUniv")
            }).ToList();
            return list;
        }
    }
}



