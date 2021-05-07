using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassADO;
using ClassBL;

namespace TP4
{
    public partial class FCommande : MetroFramework.Forms.MetroForm
    {
        public Produit produit;
        public LigneCommande lcSelected;
        public FCommande()
        {
            InitializeComponent();
        }

        private void FCommande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientLigneCommande.LigneCommande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.ligneCommandeTableAdapter.Fill(this.bd_ClientLigneCommande.LigneCommande);
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);
            this.Affiche_Ligne_Commande();
            Pan_LigC.Visible = true;


        }

        private void Nouv_Cde_Click(object sender, EventArgs e)
        {
            int numCmd = int.Parse(Txt_NumCde.Text);
            DateTime dteCmd = Date_Cde.Value.Date;
            if (string.IsNullOrEmpty(numCmd.ToString()))
            {
                MessageBox.Show("Numero commande invalid");
            }
            else if (string.IsNullOrEmpty(dteCmd.ToString()))
            {
                MessageBox.Show("Date commande invalid");
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_Cin.Text))
                {
                    MessageBox.Show("CIN client invalid");
                }
                else
                {
                    Client cl = ClientADO.Recherche_cin(int.Parse(Txt_Cin.Text));
                    if (cl != null)
                    {
                        Commande cmd = new Commande
                        {
                            Num_Cde = numCmd,
                            Date_Cde = dteCmd,
                            CIN_Cl = int.Parse(Txt_Cin.Text),
                        };
                        CommandeADO.Inserer(cmd);
                        Pan_LigC.Visible = true;
                        MessageBox.Show("Commande inserer");

                    }
                    else
                    {
                        MessageBox.Show("Client introuvable");
                    }

                }

            }
        }

        private void Vider_Cde_Click(object sender, EventArgs e)
        {
            Txt_NumCde.Clear();
            Date_Cde.ResetText();
        }

        private void Txt_NumCde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                int numCmd = int.Parse(Txt_NumCde.Text);
                if (!string.IsNullOrEmpty(numCmd.ToString()))
                {
                    Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(numCmd);
                    if (cmd != null)
                    {
                        Client cl = ClientADO.Recherche_cin(cmd.CIN_Cl);
                        if (cl != null)
                        {
                            Txt_Cin.Text = cl.CIN_Cl.ToString();
                            Txt_Nom.Text = cl.Nom_Cl;
                            Txt_Pren.Text = cl.Pren_Cl;
                            Txt_Vil.Text = cl.Ville_Cl;
                            Txt_Tel.Text = cl.Tel_Cl;
                        }
                    }
                    else
                    {
                        Nouv_Cde_Click(sender, e);
                    }
                }
            }
        }

        private void Vider_Clt_Click(object sender, EventArgs e)
        {
            Txt_Cin.Clear();
            Txt_Nom.Clear();
            Txt_Pren.Clear();
            Txt_Vil.Clear();
            Txt_Tel.Clear();
        }

        private void Affiche_Ligne_Commande()
        {
            Txt_TotCde.Clear();
            Dg_Prod.Rows.Clear();
            List<LigneCommande> ligneCmd = LigneCommandeADO.Liste_LigneCommande();
            if (ligneCmd != null)
            {
                long totalCmds = 0;
                foreach (LigneCommande lc in ligneCmd)
                {
                    Produit pd = ProduitADO.Recherche_Ref(lc.RefProd);
                    Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(lc.NumCde);
                    // Ref ligcmd | design | prix | quantité | total
                    long totalCmd = pd.PrixV_Prod * lc.Qte;
                    totalCmds += totalCmd;
                    Dg_Prod.Rows.Add(cmd.Num_Cde, pd.Desig_Prod, pd.PrixV_Prod, lc.Qte, totalCmd);
                }
                Txt_TotCde.Text = totalCmds.ToString();
            }
        }

        private void Nouv_Lig_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_NumCde.Text))
            {
                Commande cmd = CommandeADO.Recherche_Commande_Num_Cde(int.Parse(Txt_NumCde.Text));
                if (cmd != null)
                {
                    if (!string.IsNullOrEmpty(Txt_Qte.Text))
                    {
                        FListe_Prod fc = new FListe_Prod();
                        fc.ShowDialog();
                        if (FListe_Prod.produit != null)
                        {
                            this.produit = FListe_Prod.produit;
                            if (produit != null)
                            {
                                LigneCommande lc = new LigneCommande
                                {
                                    NumCde = int.Parse(Txt_NumCde.Text),
                                    RefProd = this.produit.Ref_Prod,
                                    Qte = int.Parse(Txt_Qte.Text)
                                };
                                LigneCommandeADO.Inserer(lc);
                                Affiche_Ligne_Commande();
                                MessageBox.Show("Ligne Commande inserer");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selectioner un produit");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserer une qunatité");
                    }
                }
                else
                {
                    MessageBox.Show("Inserer une commande");
                }
            }
            else
            {
                MessageBox.Show("Inserer une commande");
            }

        }

        private void Nouv_Clt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Cin.Text))
            {
                Client cl = ClientADO.Recherche_cin(int.Parse(Txt_Cin.Text));
                if (cl != null)
                {
                    Txt_Cin.Text = cl.CIN_Cl.ToString();
                    Txt_Nom.Text = cl.Nom_Cl;
                    Txt_Pren.Text = cl.Pren_Cl;
                    Txt_Vil.Text = cl.Ville_Cl;
                    Txt_Tel.Text = cl.Tel_Cl;
                }
            }

        }

        private void Dg_Prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int refe = int.Parse(Dg_Prod.Rows[index].Cells[0].Value.ToString());
            String desig = Dg_Prod.Rows[index].Cells[1].Value.ToString();
            int prix = int.Parse(Dg_Prod.Rows[index].Cells[2].Value.ToString());
            int qte = int.Parse(Dg_Prod.Rows[index].Cells[3].Value.ToString());
            int total = int.Parse(Dg_Prod.Rows[index].Cells[4].Value.ToString());
            lcSelected = LigneCommandeADO.LigneCommande(refe);

        }

        private void Supp_Lig_Click(object sender, EventArgs e)
        {
            if(lcSelected != null)
            {
                DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer la ligne commande ", "Supprimer ligne commande", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LigneCommandeADO.Supprimer(lcSelected.NumCde);
                    Affiche_Ligne_Commande();
                    MessageBox.Show("Ligne commande supprimer avec succées!");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("Selectioner une ligne commande!");
            }
        }

        private void Modif_Lig_Click(object sender, EventArgs e)
        {
            if (lcSelected != null)
            {
                LigneCommandeADO.Modifier(lcSelected);
                MessageBox.Show("Ligne commande modifier avec succées!");
            } else
            {
                MessageBox.Show("Selectioner une ligne commande!");
            }
        }
    }
}
