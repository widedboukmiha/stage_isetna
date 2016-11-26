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
        public static void Create(string Nom, string prenom, string mail, string cin, string adresse, string codeposte, string datenaiss, string groupe, string tel)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Etudiant] VALUES ((SELECT MAX(Id) + 1 FROM [Etudiant]) , '{0}' ,'{1}' , '{2}', '{3}' , '{4}', '{5}' , '{6}' , '{7}', '{10}' )", cin, Nom, prenom, datenaiss, adresse, codeposte, tel, mail, groupe);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        cmd.CommandText = String.Format("INSERT INTO [Etudiant] VALUES (1 , '{0}' ,'{1}' , '{2}', '{3}' , '{4}', '{5}' , '{6}' , '{7}', '{10}' )", cin, Nom, prenom, datenaiss, adresse, codeposte, tel, mail, groupe);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public static List<Business.Etudiant> Get()
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiant", new SqlConnection(conString)))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }

            //var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Business.Etudiant { Id = dataRow.Field<int>("Id"), Cin = dataRow.Field<string>("Cin"), Nom = dataRow.Field<string>("Nom"), Prenom = dataRow.Field<string>("Prenom"), DateNaissance = dataRow.Field<string>("DateNaissance"), Adresse = dataRow.Field<string>("Adresse"), CodePostal = dataRow.Field<string>("CodePostal"), Tel = dataRow.Field<string>("Tel"), Email = dataRow.Field<string>("Email"), NiveauId = dataRow.Field<int>("NiveauId").ToString(), FiliereId = dataRow.Field<int>("FiliereId").ToString(), GroupId = dataRow.Field<string>("GroupId").ToString() }).ToList();
            return new List<Business.Etudiant>();
        }


    }

}



