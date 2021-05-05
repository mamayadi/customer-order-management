using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class FCommande : MetroFramework.Forms.MetroForm
    {
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

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NumCde_Click(object sender, EventArgs e)
        {

        }

        private void Nouv_Cde_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Date_Cde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Vider_Cde_Click(object sender, EventArgs e)
        {

        }
    }
}
