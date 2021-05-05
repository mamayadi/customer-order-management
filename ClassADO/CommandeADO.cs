using ClassBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassADO
{
    class CommandeADO
    {
        public void Inserer(Commande c)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Commande (Num_Cde,Date_Cde,CIN_CI)" +
                " values (@Num,@Date,@Cin)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Num", c.Num_Cde);
            cmdaj.Parameters.AddWithValue("@Date", c.Date_Cde);
            cmdaj.Parameters.AddWithValue("@Cin", c.CIN_Cl);
            cmdaj.ExecuteNonQuery();
        }

        public void Supprimer(int Num_Cde)
        {
            string req = "Select * from Commande where Num_Cde=@Num_Cde";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Num_Cde", Num_Cde);
            cmdsupp.ExecuteNonQuery();
        }

        public void Modifier(Commande c)
        {
            string req = "update Commande set Num_Cde=@Num, Date_Cde=@Date,CIN_CI=@Cin";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Num", c.Num_Cde);
            cmdmaj.Parameters.AddWithValue("@Date", c.Date_Cde);
            cmdmaj.Parameters.AddWithValue("@Cin", c.CIN_Cl);
            cmdmaj.ExecuteNonQuery();
        }

        public static bool Existe_Commande(int Num_Cde)
        {
            SqlCommand cverif = new SqlCommand("select * from Commande where Num_Cde=@Num");
            cverif.Parameters.AddWithValue("@Num", Num_Cde);
            SqlDataReader drverif = cverif.ExecuteReader();
            var res = drverif.HasRows;
            drverif.Close();
            return res;
        }

        public static DataTable Liste_Commande()
        {
            DataTable dtcl = new DataTable();
            string req = "select * from Commande";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Liste_Commande_Num(int Num_Cde)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Commande where Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", Num_Cde);
            da.Fill(dtpr);
            return dtpr;
        }

        public static DataTable Liste_Commande_CIN(int CIN_CI)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Commande where CIN_CI=@Cin", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Cin", CIN_CI);
            da.Fill(dtpr);
            return dtpr;
        }
    }
}
