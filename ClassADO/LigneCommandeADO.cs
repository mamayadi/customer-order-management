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
    class LigneCommandeADO
    {
        public void Inserer(LigneCommande lc)
        {
            SqlCommand cmdaj = new SqlCommand("insert into LigneCommande (Num_Cde,Ref_Prod,Qte)" +
                " values (@Num,@Ref,@Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Num", lc.NumCde);
            cmdaj.Parameters.AddWithValue("@Ref", lc.RefProd);
            cmdaj.Parameters.AddWithValue("@Qte", lc.Qte);
            cmdaj.ExecuteNonQuery();
        }

        public void Supprimer(int NumCde)
        {
            string req = "Select * from LigneCommande where Num_Cde=@Num_Cde";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Num_Cde", NumCde);
            cmdsupp.ExecuteNonQuery();
        }

        public void Modifier(LigneCommande lc)
        {
            string req = "update Commande set Num_Cde=@Num, Ref_Prod=@Date,Qte=@Cin";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Num", lc.NumCde);
            cmdmaj.Parameters.AddWithValue("@Ref", lc.RefProd);
            cmdmaj.Parameters.AddWithValue("@Qte", lc.Qte);
            cmdmaj.ExecuteNonQuery();
        }

        public static bool Existe_LigneCommande(int Num_Cde)
        {
            SqlCommand cverif = new SqlCommand("select * from LigneCommande where Num_Cde=@Num");
            cverif.Parameters.AddWithValue("@Num", Num_Cde);
            SqlDataReader drverif = cverif.ExecuteReader();
            var res = drverif.HasRows;
            drverif.Close();
            return res;
        }

        public static DataTable Liste_LigneCommande()
        {
            DataTable dtcl = new DataTable();
            string req = "select * from LigneCommande";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Liste_LigneCommande_Num(int NumCde)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NumCde);
            da.Fill(dtpr);
            return dtpr;
        }

        public static DataTable Liste_LigneCommande_CIN(int RefProd)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCommande where Ref_Prod=@RefProd", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@RefProd", RefProd);
            da.Fill(dtpr);
            return dtpr;
        }
    }
}
