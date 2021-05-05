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
    public partial class FListe_Prod : MetroFramework.Forms.MetroForm
    {
        public FListe_Prod()
        {
            InitializeComponent();
        }

        private void FListe_Prod_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bd_ClientDataSet.Produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.bd_ClientDataSet.Produit);

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            FProduit fc = new FProduit();
            fc.MdiParent = this;
            fc.Show();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            FProduit fc = new FProduit();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
