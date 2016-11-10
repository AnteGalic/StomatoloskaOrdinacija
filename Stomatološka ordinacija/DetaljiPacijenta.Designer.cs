namespace Stomatološka_ordinacija
{
    partial class DetaljiPacijenta
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
            System.Windows.Forms.Label jMBGLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetaljiPacijenta));
            this.stomatoloskaOrdinacijaDataSet = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSet();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Spremi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacijentiTableAdapter = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.PacijentiTableAdapter();
            this.tableAdapterManager = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager();
            this.detaljiTableAdapter = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.DetaljiTableAdapter();
            this.pacijentiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJMBG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpćina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjestoStanovanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumRođenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjestoRođenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojTelefona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detaljiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detaljiGridControl = new DevExpress.XtraGrid.GridControl();
            this.pacijentiDetaljiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJMBG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetaljanOpis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumDodavanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCeljust = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStrana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jMBGTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.CeljustCombo = new System.Windows.Forms.ComboBox();
            this.StranaCombo = new System.Windows.Forms.ComboBox();
            this.ZubCombo = new System.Windows.Forms.ComboBox();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.Celjust = new System.Windows.Forms.Label();
            this.Strana = new System.Windows.Forms.Label();
            this.Zub = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            jMBGLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stomatoloskaOrdinacijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiDetaljiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // jMBGLabel
            // 
            jMBGLabel.AutoSize = true;
            jMBGLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            jMBGLabel.Location = new System.Drawing.Point(827, 165);
            jMBGLabel.Name = "jMBGLabel";
            jMBGLabel.Size = new System.Drawing.Size(44, 14);
            jMBGLabel.TabIndex = 32;
            jMBGLabel.Text = "JMBG:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            imeLabel.Location = new System.Drawing.Point(837, 215);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 14);
            imeLabel.TabIndex = 34;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            prezimeLabel.Location = new System.Drawing.Point(813, 265);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(58, 14);
            prezimeLabel.TabIndex = 35;
            prezimeLabel.Text = "Prezime:";
            // 
            // stomatoloskaOrdinacijaDataSet
            // 
            this.stomatoloskaOrdinacijaDataSet.DataSetName = "StomatoloskaOrdinacijaDataSet";
            this.stomatoloskaOrdinacijaDataSet.EnforceConstraints = false;
            this.stomatoloskaOrdinacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.Spremi,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1252, 141);
            // 
            // Spremi
            // 
            this.Spremi.Caption = "Spremi ";
            this.Spremi.Glyph = ((System.Drawing.Image)(resources.GetObject("Spremi.Glyph")));
            this.Spremi.Id = 1;
            this.Spremi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("Spremi.LargeGlyph")));
            this.Spremi.Name = "Spremi";
            this.Spremi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Spremi_ItemClick);
            // 
            
            
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Uredi";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Spremi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Spremi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Spremi promjene";
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataMember = "Pacijenti";
            this.pacijentiBindingSource.DataSource = this.stomatoloskaOrdinacijaDataSet;
            // 
            // pacijentiTableAdapter
            // 
            this.pacijentiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetaljiTableAdapter = this.detaljiTableAdapter;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PacijentiTableAdapter = this.pacijentiTableAdapter;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detaljiTableAdapter
            // 
            this.detaljiTableAdapter.ClearBeforeFill = true;
            // 
            // pacijentiGridControl
            // 
            this.pacijentiGridControl.DataSource = this.pacijentiBindingSource;
            this.pacijentiGridControl.Location = new System.Drawing.Point(12, 147);
            this.pacijentiGridControl.MainView = this.gridView1;
            this.pacijentiGridControl.MenuManager = this.ribbonControl1;
            this.pacijentiGridControl.Name = "pacijentiGridControl";
            this.pacijentiGridControl.Size = new System.Drawing.Size(733, 279);
            this.pacijentiGridControl.TabIndex = 30;
            this.pacijentiGridControl.UseEmbeddedNavigator = true;
            this.pacijentiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJMBG1,
            this.colIme,
            this.colPrezime,
            this.colOpćina,
            this.colMjestoStanovanja,
            this.colDatumRođenja,
            this.colMjestoRođenja,
            this.colBrojTelefona});
            this.gridView1.GridControl = this.pacijentiGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colJMBG1
            // 
            this.colJMBG1.FieldName = "JMBG";
            this.colJMBG1.Name = "colJMBG1";
            this.colJMBG1.OptionsColumn.ReadOnly = true;
            this.colJMBG1.Visible = true;
            this.colJMBG1.VisibleIndex = 0;
            // 
            // colIme
            // 
            this.colIme.FieldName = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.OptionsColumn.ReadOnly = true;
            this.colIme.Visible = true;
            this.colIme.VisibleIndex = 1;
            // 
            // colPrezime
            // 
            this.colPrezime.FieldName = "Prezime";
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.OptionsColumn.ReadOnly = true;
            this.colPrezime.Visible = true;
            this.colPrezime.VisibleIndex = 2;
            // 
            // colOpćina
            // 
            this.colOpćina.FieldName = "Općina";
            this.colOpćina.Name = "colOpćina";
            this.colOpćina.OptionsColumn.ReadOnly = true;
            // 
            // colMjestoStanovanja
            // 
            this.colMjestoStanovanja.FieldName = "MjestoStanovanja";
            this.colMjestoStanovanja.Name = "colMjestoStanovanja";
            this.colMjestoStanovanja.OptionsColumn.ReadOnly = true;
            this.colMjestoStanovanja.Visible = true;
            this.colMjestoStanovanja.VisibleIndex = 3;
            // 
            // colDatumRođenja
            // 
            this.colDatumRođenja.FieldName = "DatumRođenja";
            this.colDatumRođenja.Name = "colDatumRođenja";
            this.colDatumRođenja.OptionsColumn.ReadOnly = true;
            this.colDatumRođenja.Visible = true;
            this.colDatumRođenja.VisibleIndex = 4;
            // 
            // colMjestoRođenja
            // 
            this.colMjestoRođenja.FieldName = "MjestoRođenja";
            this.colMjestoRođenja.Name = "colMjestoRođenja";
            this.colMjestoRođenja.OptionsColumn.ReadOnly = true;
            // 
            // colBrojTelefona
            // 
            this.colBrojTelefona.FieldName = "BrojTelefona";
            this.colBrojTelefona.Name = "colBrojTelefona";
            this.colBrojTelefona.OptionsColumn.ReadOnly = true;
            // 
            // detaljiBindingSource
            // 
            this.detaljiBindingSource.DataMember = "Pacijenti_Detalji";
            this.detaljiBindingSource.DataSource = this.pacijentiBindingSource;
            // 
            // detaljiGridControl
            // 
            this.detaljiGridControl.DataSource = this.pacijentiDetaljiBindingSource;
            this.detaljiGridControl.Location = new System.Drawing.Point(12, 432);
            this.detaljiGridControl.MainView = this.gridView2;
            this.detaljiGridControl.MenuManager = this.ribbonControl1;
            this.detaljiGridControl.Name = "detaljiGridControl";
            this.detaljiGridControl.Size = new System.Drawing.Size(733, 220);
            this.detaljiGridControl.TabIndex = 30;
            this.detaljiGridControl.UseEmbeddedNavigator = true;
            this.detaljiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // pacijentiDetaljiBindingSource
            // 
            this.pacijentiDetaljiBindingSource.DataMember = "Pacijenti_Detalji";
            this.pacijentiDetaljiBindingSource.DataSource = this.pacijentiBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalj,
            this.colJMBG,
            this.colDetaljanOpis,
            this.colDatumDodavanja,
            this.colCeljust,
            this.colStrana,
            this.colZub});
            this.gridView2.GridControl = this.detaljiGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDetalj
            // 
            this.colIdDetalj.FieldName = "IdDetalj";
            this.colIdDetalj.Name = "colIdDetalj";
            this.colIdDetalj.OptionsColumn.ReadOnly = true;
            this.colIdDetalj.Width = 137;
            // 
            // colJMBG
            // 
            this.colJMBG.FieldName = "JMBG";
            this.colJMBG.Name = "colJMBG";
            this.colJMBG.OptionsColumn.ReadOnly = true;
            // 
            // colDetaljanOpis
            // 
            this.colDetaljanOpis.FieldName = "DetaljanOpis";
            this.colDetaljanOpis.Name = "colDetaljanOpis";
            this.colDetaljanOpis.OptionsColumn.ReadOnly = true;
            this.colDetaljanOpis.Visible = true;
            this.colDetaljanOpis.VisibleIndex = 3;
            this.colDetaljanOpis.Width = 361;
            // 
            // colDatumDodavanja
            // 
            this.colDatumDodavanja.FieldName = "DatumDodavanja";
            this.colDatumDodavanja.Name = "colDatumDodavanja";
            this.colDatumDodavanja.OptionsColumn.ReadOnly = true;
            this.colDatumDodavanja.Visible = true;
            this.colDatumDodavanja.VisibleIndex = 4;
            this.colDatumDodavanja.Width = 133;
            // 
            // colCeljust
            // 
            this.colCeljust.FieldName = "Celjust";
            this.colCeljust.Name = "colCeljust";
            this.colCeljust.OptionsColumn.ReadOnly = true;
            this.colCeljust.Visible = true;
            this.colCeljust.VisibleIndex = 0;
            this.colCeljust.Width = 85;
            // 
            // colStrana
            // 
            this.colStrana.FieldName = "Strana";
            this.colStrana.Name = "colStrana";
            this.colStrana.OptionsColumn.ReadOnly = true;
            this.colStrana.Visible = true;
            this.colStrana.VisibleIndex = 1;
            this.colStrana.Width = 141;
            // 
            // colZub
            // 
            this.colZub.FieldName = "Zub";
            this.colZub.Name = "colZub";
            this.colZub.OptionsColumn.ReadOnly = true;
            this.colZub.Visible = true;
            this.colZub.VisibleIndex = 2;
            this.colZub.Width = 102;
            // 
            // jMBGTextBox
            // 
            this.jMBGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentiBindingSource, "JMBG", true));
            this.jMBGTextBox.Enabled = false;
            this.jMBGTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jMBGTextBox.Location = new System.Drawing.Point(877, 163);
            this.jMBGTextBox.Name = "jMBGTextBox";
            this.jMBGTextBox.Size = new System.Drawing.Size(219, 22);
            this.jMBGTextBox.TabIndex = 33;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentiBindingSource, "Ime", true));
            this.imeTextBox.Enabled = false;
            this.imeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTextBox.Location = new System.Drawing.Point(877, 212);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(219, 22);
            this.imeTextBox.TabIndex = 35;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentiBindingSource, "Prezime", true));
            this.prezimeTextBox.Enabled = false;
            this.prezimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeTextBox.Location = new System.Drawing.Point(877, 262);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(219, 22);
            this.prezimeTextBox.TabIndex = 36;
            // 
            // CeljustCombo
            // 
            this.CeljustCombo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CeljustCombo.FormattingEnabled = true;
            this.CeljustCombo.Location = new System.Drawing.Point(877, 316);
            this.CeljustCombo.Name = "CeljustCombo";
            this.CeljustCombo.Size = new System.Drawing.Size(162, 22);
            this.CeljustCombo.TabIndex = 37;
            this.CeljustCombo.SelectionChangeCommitted += new System.EventHandler(this.CeljustCombo_SelectionChangeCommitted);
            // 
            // StranaCombo
            // 
            this.StranaCombo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StranaCombo.FormattingEnabled = true;
            this.StranaCombo.Location = new System.Drawing.Point(877, 367);
            this.StranaCombo.Name = "StranaCombo";
            this.StranaCombo.Size = new System.Drawing.Size(162, 22);
            this.StranaCombo.TabIndex = 38;
            this.StranaCombo.SelectionChangeCommitted += new System.EventHandler(this.StranaCombo_SelectionChangeCommitted);
            // 
            // ZubCombo
            // 
            this.ZubCombo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZubCombo.FormattingEnabled = true;
            this.ZubCombo.Location = new System.Drawing.Point(877, 414);
            this.ZubCombo.Name = "ZubCombo";
            this.ZubCombo.Size = new System.Drawing.Size(98, 22);
            this.ZubCombo.TabIndex = 39;
            this.ZubCombo.SelectionChangeCommitted += new System.EventHandler(this.ZubCombo_SelectionChangeCommitted);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(877, 487);
            this.memoEdit1.MenuManager = this.ribbonControl1;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(363, 181);
            this.memoEdit1.TabIndex = 40;
            // 
            // Celjust
            // 
            this.Celjust.AutoSize = true;
            this.Celjust.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Celjust.Location = new System.Drawing.Point(815, 319);
            this.Celjust.Name = "Celjust";
            this.Celjust.Size = new System.Drawing.Size(53, 14);
            this.Celjust.TabIndex = 41;
            this.Celjust.Text = "Čeljust:";
            // 
            // Strana
            // 
            this.Strana.AutoSize = true;
            this.Strana.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Strana.Location = new System.Drawing.Point(819, 367);
            this.Strana.Name = "Strana";
            this.Strana.Size = new System.Drawing.Size(52, 14);
            this.Strana.TabIndex = 42;
            this.Strana.Text = "Strana:";
            // 
            // Zub
            // 
            this.Zub.AutoSize = true;
            this.Zub.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zub.Location = new System.Drawing.Point(834, 417);
            this.Zub.Name = "Zub";
            this.Zub.Size = new System.Drawing.Size(34, 14);
            this.Zub.TabIndex = 43;
            this.Zub.Text = "Zub:";
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis.Location = new System.Drawing.Point(779, 488);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(92, 14);
            this.Opis.TabIndex = 44;
            this.Opis.Text = "Detaljan Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1080, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1080, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1080, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // DetaljiPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.Zub);
            this.Controls.Add(this.Strana);
            this.Controls.Add(this.Celjust);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.ZubCombo);
            this.Controls.Add(this.StranaCombo);
            this.Controls.Add(this.CeljustCombo);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(jMBGLabel);
            this.Controls.Add(this.jMBGTextBox);
            this.Controls.Add(this.detaljiGridControl);
            this.Controls.Add(this.pacijentiGridControl);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetaljiPacijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji Pacijenta";
            this.Load += new System.EventHandler(this.DetaljiPacijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stomatoloskaOrdinacijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiDetaljiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StomatoloskaOrdinacijaDataSet stomatoloskaOrdinacijaDataSet;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem Spremi;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private StomatoloskaOrdinacijaDataSetTableAdapters.PacijentiTableAdapter pacijentiTableAdapter;
        private StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StomatoloskaOrdinacijaDataSetTableAdapters.DetaljiTableAdapter detaljiTableAdapter;
        private DevExpress.XtraGrid.GridControl pacijentiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource detaljiBindingSource;
        private DevExpress.XtraGrid.GridControl detaljiGridControl;
        private System.Windows.Forms.BindingSource pacijentiDetaljiBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalj;
        private DevExpress.XtraGrid.Columns.GridColumn colJMBG;
        private DevExpress.XtraGrid.Columns.GridColumn colDetaljanOpis;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumDodavanja;
        private DevExpress.XtraGrid.Columns.GridColumn colCeljust;
        private DevExpress.XtraGrid.Columns.GridColumn colStrana;
        private DevExpress.XtraGrid.Columns.GridColumn colZub;
        private DevExpress.XtraGrid.Columns.GridColumn colJMBG1;
        private DevExpress.XtraGrid.Columns.GridColumn colIme;
        private DevExpress.XtraGrid.Columns.GridColumn colPrezime;
        private DevExpress.XtraGrid.Columns.GridColumn colOpćina;
        private DevExpress.XtraGrid.Columns.GridColumn colMjestoStanovanja;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumRođenja;
        private DevExpress.XtraGrid.Columns.GridColumn colMjestoRođenja;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojTelefona;
        private System.Windows.Forms.TextBox jMBGTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.ComboBox CeljustCombo;
        private System.Windows.Forms.ComboBox StranaCombo;
        private System.Windows.Forms.ComboBox ZubCombo;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.Label Celjust;
        private System.Windows.Forms.Label Strana;
        private System.Windows.Forms.Label Zub;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}