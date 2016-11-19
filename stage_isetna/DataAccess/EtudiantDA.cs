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
        
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.chaine);
        SqlCommand cmd = new SqlCommand();
        protected SqlDataAdapter da = new SqlDataAdapter();
        protected SqlDataReader dr;
        protected DataSet ds = new DataSet();

        public List<stage_isetna.Business.Etudiant> Retrive()
         {
             List<stage_isetna.Business.Etudiant> listEtudiant = new List<stage_isetna.Business.Etudiant>();
             return listEtudiant;
         }
      

      public Boolean Insert(stage_isetna.Business.Etudiant e)
         {
             try
             {
                 cn.Open();
                 string strQuery = "INSERT INTO Entreprise  VALUES (@cin, @nom,@tel,@prenom,@date_naissance,@adresse,@ville,@code_postal,@num_telephone,@groupe,@filiere,@departement,@email)";
                 SqlCommand cmd = new SqlCommand(strQuery, cn);
                DataAccess.NiveauDA IDNiveau = new DataAccess.NiveauDA();
                 cmd.Parameters.AddWithValue("@cin", e.Cin);
                 cmd.Parameters.AddWithValue("@nom", e.Nom);
                 cmd.Parameters.AddWithValue("@prenom", e.Prenom);
                 cmd.Parameters.AddWithValue("@date_naissance", e.DateNaissance);
                 cmd.Parameters.AddWithValue("@adresse", e.Adresse);
                 cmd.Parameters.AddWithValue("@ville", e.CodePostal);
                 cmd.Parameters.AddWithValue("@code_postal", e.Tel);
                 cmd.Parameters.AddWithValue("@num_telephone", e.Email);
                 //cmd.Parameters.AddWithValue("@groupe", );
                 //cmd.Parameters.AddWithValue("@filiere", );
                 //cmd.Parameters.AddWithValue("@departement", );
                 //cmd.Parameters.AddWithValue("@email",);
                 cmd.Connection = cn;
                 cmd.ExecuteNonQuery();
                 cn.Close();
                 return true;
             }
             catch (Exception ex)
             {
                 String er = ex.Message;
                 return false;
             }
         }

         public Boolean Update(int id, stage_isetna.Business.Etudiant et)
         {
             return false;
         }

         public Boolean Remove(String cin)
         {
             return false;
         }
        public void seconnecter()
        {
            try
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn = new SqlConnection(Properties.Settings.Default.chaine);
                    cn.Open();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }

        //-----------
        public void deconnecter()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public void remplircombo(ComboBox cmb, string table, string chrAffich, string chrcach)
        {
            try
            {
                cmd.CommandText = "select DISTINCT " + chrcach + "," + chrAffich + " FROM " + table;
                seconnecter();
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                cmb.Items.Add("--Faites votre choix--");
                cmb.Text = "--Faites votre choix--";
                while (dr.Read())
                {
                    cmb.Items.Add(dr[chrAffich]);
                    cmb.ValueMember = dr[chrcach].ToString();
                    cmb.DisplayMember = dr[chrAffich].ToString();



                }
                dr.Close();
                deconnecter();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

        }

        public void viderFromAjout(Panel f)
        {
            foreach (Control ctl in f.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ctl.Text = "";
                }
                if (ctl.GetType() == typeof(ComboBox))
                {
                    ctl.Text = "--Faites votre choix--";
                }

            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
       

    }

}

    

