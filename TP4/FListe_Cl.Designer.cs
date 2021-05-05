
namespace TP4
{
    partial class FListe_Cl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListe_Cl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_Cin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Vil = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.testttt = new MetroFramework.Controls.MetroLabel();
            this.Txt_Nom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Tel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Pren = new MetroFramework.Controls.MetroTextBox();
            this.Ajouter = new System.Windows.Forms.PictureBox();
            this.Modifier = new System.Windows.Forms.PictureBox();
            this.Supprimer = new System.Windows.Forms.PictureBox();
            this.Rechercher = new System.Windows.Forms.PictureBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Dg_Clt = new MetroFramework.Controls.MetroGrid();
            this.cINClDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pren_Cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeClDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telClDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ClientDataSet3 = new TP4.Bd_ClientDataSet3();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter1 = new TP4.Bd_ClientDataSet3TableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Cin
            // 
            // 
            // 
            // 
            this.Txt_Cin.CustomButton.Image = null;
            this.Txt_Cin.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Cin.CustomButton.Name = "";
            this.Txt_Cin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Cin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Cin.CustomButton.TabIndex = 1;
            this.Txt_Cin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Cin.CustomButton.UseSelectable = true;
            this.Txt_Cin.CustomButton.Visible = false;
            this.Txt_Cin.Lines = new string[0];
            this.Txt_Cin.Location = new System.Drawing.Point(61, 67);
            this.Txt_Cin.MaxLength = 32767;
            this.Txt_Cin.Name = "Txt_Cin";
            this.Txt_Cin.PasswordChar = '\0';
            this.Txt_Cin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Cin.SelectedText = "";
            this.Txt_Cin.SelectionLength = 0;
            this.Txt_Cin.SelectionStart = 0;
            this.Txt_Cin.ShortcutsEnabled = true;
            this.Txt_Cin.Size = new System.Drawing.Size(75, 23);
            this.Txt_Cin.TabIndex = 0;
            this.Txt_Cin.UseSelectable = true;
            this.Txt_Cin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Cin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CIN";
            // 
            // Txt_Vil
            // 
            this.Txt_Vil.AutoSize = true;
            this.Txt_Vil.Location = new System.Drawing.Point(22, 131);
            this.Txt_Vil.Name = "Txt_Vil";
            this.Txt_Vil.Size = new System.Drawing.Size(33, 19);
            this.Txt_Vil.TabIndex = 3;
            this.Txt_Vil.Text = "Ville";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(61, 131);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // testttt
            // 
            this.testttt.AutoSize = true;
            this.testttt.Location = new System.Drawing.Point(192, 67);
            this.testttt.Name = "testttt";
            this.testttt.Size = new System.Drawing.Size(39, 19);
            this.testttt.TabIndex = 5;
            this.testttt.Text = "Nom";
            // 
            // Txt_Nom
            // 
            // 
            // 
            // 
            this.Txt_Nom.CustomButton.Image = null;
            this.Txt_Nom.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Nom.CustomButton.Name = "";
            this.Txt_Nom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nom.CustomButton.TabIndex = 1;
            this.Txt_Nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nom.CustomButton.UseSelectable = true;
            this.Txt_Nom.CustomButton.Visible = false;
            this.Txt_Nom.Lines = new string[0];
            this.Txt_Nom.Location = new System.Drawing.Point(237, 67);
            this.Txt_Nom.MaxLength = 32767;
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.PasswordChar = '\0';
            this.Txt_Nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nom.SelectedText = "";
            this.Txt_Nom.SelectionLength = 0;
            this.Txt_Nom.SelectionStart = 0;
            this.Txt_Nom.ShortcutsEnabled = true;
            this.Txt_Nom.Size = new System.Drawing.Size(75, 23);
            this.Txt_Nom.TabIndex = 4;
            this.Txt_Nom.UseSelectable = true;
            this.Txt_Nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(163, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Téléphone";
            // 
            // Txt_Tel
            // 
            // 
            // 
            // 
            this.Txt_Tel.CustomButton.Image = null;
            this.Txt_Tel.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Tel.CustomButton.Name = "";
            this.Txt_Tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Tel.CustomButton.TabIndex = 1;
            this.Txt_Tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Tel.CustomButton.UseSelectable = true;
            this.Txt_Tel.CustomButton.Visible = false;
            this.Txt_Tel.Lines = new string[0];
            this.Txt_Tel.Location = new System.Drawing.Point(237, 131);
            this.Txt_Tel.MaxLength = 32767;
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.PasswordChar = '\0';
            this.Txt_Tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Tel.SelectedText = "";
            this.Txt_Tel.SelectionLength = 0;
            this.Txt_Tel.SelectionStart = 0;
            this.Txt_Tel.ShortcutsEnabled = true;
            this.Txt_Tel.Size = new System.Drawing.Size(75, 23);
            this.Txt_Tel.TabIndex = 6;
            this.Txt_Tel.UseSelectable = true;
            this.Txt_Tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(351, 67);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Prénom";
            // 
            // Txt_Pren
            // 
            // 
            // 
            // 
            this.Txt_Pren.CustomButton.Image = null;
            this.Txt_Pren.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Txt_Pren.CustomButton.Name = "";
            this.Txt_Pren.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Pren.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Pren.CustomButton.TabIndex = 1;
            this.Txt_Pren.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Pren.CustomButton.UseSelectable = true;
            this.Txt_Pren.CustomButton.Visible = false;
            this.Txt_Pren.Lines = new string[0];
            this.Txt_Pren.Location = new System.Drawing.Point(413, 67);
            this.Txt_Pren.MaxLength = 32767;
            this.Txt_Pren.Name = "Txt_Pren";
            this.Txt_Pren.PasswordChar = '\0';
            this.Txt_Pren.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Pren.SelectedText = "";
            this.Txt_Pren.SelectionLength = 0;
            this.Txt_Pren.SelectionStart = 0;
            this.Txt_Pren.ShortcutsEnabled = true;
            this.Txt_Pren.Size = new System.Drawing.Size(75, 23);
            this.Txt_Pren.TabIndex = 8;
            this.Txt_Pren.UseSelectable = true;
            this.Txt_Pren.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Pren.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Ajouter
            // 
            this.Ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ajouter.BackgroundImage")));
            this.Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ajouter.InitialImage = null;
            this.Ajouter.Location = new System.Drawing.Point(343, 104);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(52, 50);
            this.Ajouter.TabIndex = 10;
            this.Ajouter.TabStop = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Modifier.BackgroundImage")));
            this.Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Modifier.InitialImage = ((System.Drawing.Image)(resources.GetObject("Modifier.InitialImage")));
            this.Modifier.Location = new System.Drawing.Point(401, 104);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(52, 50);
            this.Modifier.TabIndex = 11;
            this.Modifier.TabStop = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supprimer.BackgroundImage")));
            this.Supprimer.InitialImage = ((System.Drawing.Image)(resources.GetObject("Supprimer.InitialImage")));
            this.Supprimer.Location = new System.Drawing.Point(459, 104);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(52, 50);
            this.Supprimer.TabIndex = 12;
            this.Supprimer.TabStop = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("Rechercher.Image")));
            this.Rechercher.InitialImage = ((System.Drawing.Image)(resources.GetObject("Rechercher.InitialImage")));
            this.Rechercher.Location = new System.Drawing.Point(517, 104);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(52, 50);
            this.Rechercher.TabIndex = 13;
            this.Rechercher.TabStop = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-186, 198);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 150);
            this.metroGrid1.TabIndex = 14;
            // 
            // Dg_Clt
            // 
            this.Dg_Clt.AllowUserToResizeRows = false;
            this.Dg_Clt.AutoGenerateColumns = false;
            this.Dg_Clt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Clt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Clt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Clt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Clt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dg_Clt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cINClDataGridViewTextBoxColumn,
            this.Pren_Cl,
            this.nomClDataGridViewTextBoxColumn,
            this.villeClDataGridViewTextBoxColumn,
            this.telClDataGridViewTextBoxColumn});
            this.Dg_Clt.DataSource = this.cLIENTBindingSource1;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Clt.DefaultCellStyle = dataGridViewCellStyle11;
            this.Dg_Clt.EnableHeadersVisualStyles = false;
            this.Dg_Clt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Clt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Clt.Location = new System.Drawing.Point(23, 188);
            this.Dg_Clt.Name = "Dg_Clt";
            this.Dg_Clt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Clt.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dg_Clt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Clt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Clt.Size = new System.Drawing.Size(586, 239);
            this.Dg_Clt.TabIndex = 15;
            this.Dg_Clt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Clt_CellContentClick);
            // 
            // cINClDataGridViewTextBoxColumn
            // 
            this.cINClDataGridViewTextBoxColumn.DataPropertyName = "CIN_Cl";
            this.cINClDataGridViewTextBoxColumn.HeaderText = "CIN_Cl";
            this.cINClDataGridViewTextBoxColumn.Name = "cINClDataGridViewTextBoxColumn";
            // 
            // Pren_Cl
            // 
            this.Pren_Cl.DataPropertyName = "Pren_Cl";
            this.Pren_Cl.HeaderText = "Pren_Cl";
            this.Pren_Cl.Name = "Pren_Cl";
            // 
            // nomClDataGridViewTextBoxColumn
            // 
            this.nomClDataGridViewTextBoxColumn.DataPropertyName = "Nom_Cl";
            this.nomClDataGridViewTextBoxColumn.HeaderText = "Nom_Cl";
            this.nomClDataGridViewTextBoxColumn.Name = "nomClDataGridViewTextBoxColumn";
            // 
            // villeClDataGridViewTextBoxColumn
            // 
            this.villeClDataGridViewTextBoxColumn.DataPropertyName = "Ville_Cl";
            this.villeClDataGridViewTextBoxColumn.HeaderText = "Ville_Cl";
            this.villeClDataGridViewTextBoxColumn.Name = "villeClDataGridViewTextBoxColumn";
            // 
            // telClDataGridViewTextBoxColumn
            // 
            this.telClDataGridViewTextBoxColumn.DataPropertyName = "Tel_Cl";
            this.telClDataGridViewTextBoxColumn.HeaderText = "Tel_Cl";
            this.telClDataGridViewTextBoxColumn.Name = "telClDataGridViewTextBoxColumn";
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.bd_ClientDataSet3;
            // 
            // bd_ClientDataSet3
            // 
            this.bd_ClientDataSet3.DataSetName = "Bd_ClientDataSet3";
            this.bd_ClientDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            // 
            // cLIENTTableAdapter1
            // 
            this.cLIENTTableAdapter1.ClearBeforeFill = true;
            // 
            // FListe_Cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dg_Clt);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Txt_Pren);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Txt_Tel);
            this.Controls.Add(this.testttt);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.Txt_Vil);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Txt_Cin);
            this.Name = "FListe_Cl";
            this.Text = "Liste des Clients";
            this.Load += new System.EventHandler(this.FListe_Cl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ClientDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Txt_Cin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Txt_Vil;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel testttt;
        private MetroFramework.Controls.MetroTextBox Txt_Nom;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox Txt_Tel;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Txt_Pren;
        private System.Windows.Forms.PictureBox Ajouter;
        private System.Windows.Forms.PictureBox Modifier;
        private System.Windows.Forms.PictureBox Supprimer;
        private System.Windows.Forms.PictureBox Rechercher;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid Dg_Clt;
        
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn prenClDataGridViewTextBoxColumn;
        private Bd_ClientDataSet3 bd_ClientDataSet3;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
        private Bd_ClientDataSet3TableAdapters.CLIENTTableAdapter cLIENTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINClDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pren_Cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeClDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telClDataGridViewTextBoxColumn;
    }
}