
namespace TP4
{
    partial class FListe_Prod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListe_Prod));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Ref = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Desig = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_Categ = new MetroFramework.Controls.MetroComboBox();
            this.produitBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bdClientDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ClientDataSet = new TP4.Bd_ClientDataSet();
            this.Vider = new System.Windows.Forms.PictureBox();
            this.Rechercher = new System.Windows.Forms.PictureBox();
            this.Ajouter = new System.Windows.Forms.PictureBox();
            this.Supprimer = new System.Windows.Forms.PictureBox();
            this.Modifier = new System.Windows.Forms.PictureBox();
            this.Dg_Prod = new MetroFramework.Controls.MetroGrid();
            this.refProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desigProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new TP4.Bd_ClientDataSetTableAdapters.ProduitTableAdapter();
            this.produitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Référence";
            // 
            // Txt_Ref
            // 
            // 
            // 
            // 
            this.Txt_Ref.CustomButton.Image = null;
            this.Txt_Ref.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Ref.CustomButton.Name = "";
            this.Txt_Ref.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Ref.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Ref.CustomButton.TabIndex = 1;
            this.Txt_Ref.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Ref.CustomButton.UseSelectable = true;
            this.Txt_Ref.CustomButton.Visible = false;
            this.Txt_Ref.Lines = new string[0];
            this.Txt_Ref.Location = new System.Drawing.Point(129, 74);
            this.Txt_Ref.MaxLength = 32767;
            this.Txt_Ref.Name = "Txt_Ref";
            this.Txt_Ref.PasswordChar = '\0';
            this.Txt_Ref.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Ref.SelectedText = "";
            this.Txt_Ref.SelectionLength = 0;
            this.Txt_Ref.SelectionStart = 0;
            this.Txt_Ref.ShortcutsEnabled = true;
            this.Txt_Ref.Size = new System.Drawing.Size(75, 23);
            this.Txt_Ref.TabIndex = 1;
            this.Txt_Ref.UseSelectable = true;
            this.Txt_Ref.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Ref.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(243, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Désignation";
            // 
            // Txt_Desig
            // 
            // 
            // 
            // 
            this.Txt_Desig.CustomButton.Image = null;
            this.Txt_Desig.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Desig.CustomButton.Name = "";
            this.Txt_Desig.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Desig.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Desig.CustomButton.TabIndex = 1;
            this.Txt_Desig.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Desig.CustomButton.UseSelectable = true;
            this.Txt_Desig.CustomButton.Visible = false;
            this.Txt_Desig.Lines = new string[0];
            this.Txt_Desig.Location = new System.Drawing.Point(327, 74);
            this.Txt_Desig.MaxLength = 32767;
            this.Txt_Desig.Name = "Txt_Desig";
            this.Txt_Desig.PasswordChar = '\0';
            this.Txt_Desig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Desig.SelectedText = "";
            this.Txt_Desig.SelectionLength = 0;
            this.Txt_Desig.SelectionStart = 0;
            this.Txt_Desig.ShortcutsEnabled = true;
            this.Txt_Desig.Size = new System.Drawing.Size(75, 23);
            this.Txt_Desig.TabIndex = 3;
            this.Txt_Desig.UseSelectable = true;
            this.Txt_Desig.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Desig.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(430, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Catégorie";
            // 
            // Cmb_Categ
            // 
            this.Cmb_Categ.DataSource = this.produitBindingSource3;
            this.Cmb_Categ.DisplayMember = "Categ_Prod";
            this.Cmb_Categ.FormattingEnabled = true;
            this.Cmb_Categ.ItemHeight = 23;
            this.Cmb_Categ.Location = new System.Drawing.Point(504, 71);
            this.Cmb_Categ.Name = "Cmb_Categ";
            this.Cmb_Categ.Size = new System.Drawing.Size(121, 29);
            this.Cmb_Categ.TabIndex = 5;
            this.Cmb_Categ.UseSelectable = true;
            this.Cmb_Categ.SelectedIndexChanged += new System.EventHandler(this.Cmb_Categ_SelectedIndexChanged);
            // 
            // produitBindingSource3
            // 
            this.produitBindingSource3.DataMember = "Produit";
            this.produitBindingSource3.DataSource = this.bdClientDataSetBindingSource;
            // 
            // bdClientDataSetBindingSource
            // 
            this.bdClientDataSetBindingSource.DataSource = this.bd_ClientDataSet;
            this.bdClientDataSetBindingSource.Position = 0;
            // 
            // bd_ClientDataSet
            // 
            this.bd_ClientDataSet.DataSetName = "Bd_ClientDataSet";
            this.bd_ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vider
            // 
            this.Vider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Vider.BackgroundImage")));
            this.Vider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Vider.ImageLocation = "";
            this.Vider.InitialImage = ((System.Drawing.Image)(resources.GetObject("Vider.InitialImage")));
            this.Vider.Location = new System.Drawing.Point(662, 55);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(71, 60);
            this.Vider.TabIndex = 7;
            this.Vider.TabStop = false;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rechercher.BackgroundImage")));
            this.Rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rechercher.Location = new System.Drawing.Point(42, 141);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(67, 50);
            this.Rechercher.TabIndex = 8;
            this.Rechercher.TabStop = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajouter.BackgroundImage")));
            this.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ajouter.Location = new System.Drawing.Point(42, 216);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(67, 50);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.TabStop = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supprimer.BackgroundImage")));
            this.Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Supprimer.Location = new System.Drawing.Point(42, 286);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(67, 50);
            this.Supprimer.TabIndex = 10;
            this.Supprimer.TabStop = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Modifier.BackgroundImage")));
            this.Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Modifier.Location = new System.Drawing.Point(42, 355);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(67, 50);
            this.Modifier.TabIndex = 11;
            this.Modifier.TabStop = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Dg_Prod
            // 
            this.Dg_Prod.AllowUserToResizeRows = false;
            this.Dg_Prod.AutoGenerateColumns = false;
            this.Dg_Prod.BackgroundColor = System.Drawing.Color.White;
            this.Dg_Prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Prod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refProdDataGridViewTextBoxColumn,
            this.desigProdDataGridViewTextBoxColumn,
            this.categProdDataGridViewTextBoxColumn,
            this.prixVProdDataGridViewTextBoxColumn,
            this.qteStockDataGridViewTextBoxColumn});
            this.Dg_Prod.DataSource = this.produitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Prod.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_Prod.EnableHeadersVisualStyles = false;
            this.Dg_Prod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Prod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dg_Prod.Location = new System.Drawing.Point(129, 141);
            this.Dg_Prod.Name = "Dg_Prod";
            this.Dg_Prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Prod.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_Prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Prod.Size = new System.Drawing.Size(542, 264);
            this.Dg_Prod.TabIndex = 12;
            this.Dg_Prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Prod_CellContentClick);
            this.Dg_Prod.DoubleClick += new System.EventHandler(this.Dg_Prod_DoubleClick);
            // 
            // refProdDataGridViewTextBoxColumn
            // 
            this.refProdDataGridViewTextBoxColumn.DataPropertyName = "Ref_Prod";
            this.refProdDataGridViewTextBoxColumn.HeaderText = "Ref_Prod";
            this.refProdDataGridViewTextBoxColumn.Name = "refProdDataGridViewTextBoxColumn";
            // 
            // desigProdDataGridViewTextBoxColumn
            // 
            this.desigProdDataGridViewTextBoxColumn.DataPropertyName = "Desig_Prod";
            this.desigProdDataGridViewTextBoxColumn.HeaderText = "Desig_Prod";
            this.desigProdDataGridViewTextBoxColumn.Name = "desigProdDataGridViewTextBoxColumn";
            // 
            // categProdDataGridViewTextBoxColumn
            // 
            this.categProdDataGridViewTextBoxColumn.DataPropertyName = "Categ_Prod";
            this.categProdDataGridViewTextBoxColumn.HeaderText = "Categ_Prod";
            this.categProdDataGridViewTextBoxColumn.Name = "categProdDataGridViewTextBoxColumn";
            // 
            // prixVProdDataGridViewTextBoxColumn
            // 
            this.prixVProdDataGridViewTextBoxColumn.DataPropertyName = "PrixV_Prod";
            this.prixVProdDataGridViewTextBoxColumn.HeaderText = "PrixV_Prod";
            this.prixVProdDataGridViewTextBoxColumn.Name = "prixVProdDataGridViewTextBoxColumn";
            // 
            // qteStockDataGridViewTextBoxColumn
            // 
            this.qteStockDataGridViewTextBoxColumn.DataPropertyName = "Qte_Stock";
            this.qteStockDataGridViewTextBoxColumn.HeaderText = "Qte_Stock";
            this.qteStockDataGridViewTextBoxColumn.Name = "qteStockDataGridViewTextBoxColumn";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.bd_ClientDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitBindingSource1
            // 
            this.produitBindingSource1.DataMember = "Produit";
            this.produitBindingSource1.DataSource = this.bd_ClientDataSet;
            // 
            // produitBindingSource2
            // 
            this.produitBindingSource2.DataMember = "Produit";
            this.produitBindingSource2.DataSource = this.bd_ClientDataSet;
            // 
            // FListe_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dg_Prod);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.Cmb_Categ);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Txt_Desig);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Txt_Ref);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FListe_Prod";
            this.Text = "Liste des Produits";
            this.Load += new System.EventHandler(this.FListe_Prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdClientDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_Ref;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Txt_Desig;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox Cmb_Categ;
        private System.Windows.Forms.PictureBox Vider;
        private System.Windows.Forms.PictureBox Rechercher;
        private System.Windows.Forms.PictureBox Ajouter;
        private System.Windows.Forms.PictureBox Supprimer;
        private System.Windows.Forms.PictureBox Modifier;
        private MetroFramework.Controls.MetroGrid Dg_Prod;
        private Bd_ClientDataSet bd_ClientDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Bd_ClientDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn refProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desigProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produitBindingSource2;
        private System.Windows.Forms.BindingSource produitBindingSource1;
        private System.Windows.Forms.BindingSource bdClientDataSetBindingSource;
        private System.Windows.Forms.BindingSource produitBindingSource3;
    }
}