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
    class ProduitADO
    {
        public void Inserer(Produit p)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Produit (Ref_Prod,Desig_Prod,Categ_Prod," +
                "PrixV_Prod,Qte_Stock) values (@Ref,@Desig,@Categ,@Prix,@Qte)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdaj.Parameters.AddWithValue("@Desig", p.Desig_Prod);
            cmdaj.Parameters.AddWithValue("@Categ", p.Categ_Prod);
            cmdaj.Parameters.AddWithValue("@Prix", p.PrixV_Prod);
            cmdaj.Parameters.AddWithValue("@Qte", p.Qte_Stock);
            cmdaj.ExecuteNonQuery();
        }

        public void Supprimer(int Ref)
        {
            string req = "Select * from Produit where Ref_Prod=@Ref";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Ref", Ref);
            cmdsupp.ExecuteNonQuery();
        }

        public void Modifier(Produit p)
        {
            string req = "update Produit set Ref_Prod=@Ref, Desig_Prod=@Desig,Categ_Prod=@Categ," +
                "PrixV_Prod=@Prix, Qte_Stock=@Qte where Ref_Prod=@Ref";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Ref", p.Ref_Prod);
            cmdmaj.Parameters.AddWithValue("@Desig", p.Desig_Prod);
            cmdmaj.Parameters.AddWithValue("@Categ", p.Categ_Prod);
            cmdmaj.Parameters.AddWithValue("@Prix", p.PrixV_Prod);
            cmdmaj.Parameters.AddWithValue("@Qte", p.Qte_Stock);
            cmdmaj.ExecuteNonQuery();
        }

        public static bool Existe_Produit(int Ref)
        {
            SqlCommand cverif = new SqlCommand("select * from Produit where Ref_Prod = @Ref");
            cverif.Parameters.AddWithValue("@Ref", Ref);
            SqlDataReader drverif = cverif.ExecuteReader();
            var res = drverif.HasRows;
            drverif.Close();
            return res;
        }

        public static DataTable Liste_Produit()
        {
            DataTable dtcl = new DataTable();
            string req = "select * from Produit";
            SqlDataAdapter da = new SqlDataAdapter(req, Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }

        public static DataTable Liste_Desig(string Desig)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Desig_Prod=@Desig", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Desig", Desig);
            da.Fill(dtpr);
            return dtpr;
        }

        public static DataTable Liste_Categ_Prod(string Categ_Pro)
        {
            DataTable dtpr = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Produit where Categ_Prod=@Categ", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Categ", Categ_Pro);
            da.Fill(dtpr);
            return dtpr;
        }
    }
}
