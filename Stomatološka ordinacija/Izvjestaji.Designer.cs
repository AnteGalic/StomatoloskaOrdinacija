namespace Stomatološka_ordinacija
{
    partial class Izvjestaji
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
            this.stomatoloskaOrdinacijaDataSet = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSet();
            this.detaljan_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detaljan_viewTableAdapter = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.detaljan_viewTableAdapter();
            this.tableAdapterManager = new Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager();
            this.detaljan_viewGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJMBG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjestoStanovanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpćina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumRođenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMjestoRođenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrojTelefona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCeljust = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStrana = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetaljanOpis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatumDodavanja = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stomatoloskaOrdinacijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljan_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljan_viewGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stomatoloskaOrdinacijaDataSet
            // 
            this.stomatoloskaOrdinacijaDataSet.DataSetName = "StomatoloskaOrdinacijaDataSet";
            this.stomatoloskaOrdinacijaDataSet.EnforceConstraints = false;
            this.stomatoloskaOrdinacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaljan_viewBindingSource
            // 
            this.detaljan_viewBindingSource.DataMember = "detaljan view";
            this.detaljan_viewBindingSource.DataSource = this.stomatoloskaOrdinacijaDataSet;
            // 
            // detaljan_viewTableAdapter
            // 
            this.detaljan_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DetaljiTableAdapter = null;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PacijentiTableAdapter = null;
            this.tableAdapterManager.ResourcesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stomatološka_ordinacija.StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detaljan_viewGridControl
            // 
            this.detaljan_viewGridControl.DataSource = this.detaljan_viewBindingSource;
            this.detaljan_viewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detaljan_viewGridControl.Location = new System.Drawing.Point(0, 0);
            this.detaljan_viewGridControl.MainView = this.gridView1;
            this.detaljan_viewGridControl.Name = "detaljan_viewGridControl";
            this.detaljan_viewGridControl.Size = new System.Drawing.Size(1098, 449);
            this.detaljan_viewGridControl.TabIndex = 1;
            this.detaljan_viewGridControl.UseEmbeddedNavigator = true;
            this.detaljan_viewGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJMBG,
            this.colIme,
            this.colPrezime,
            this.colMjestoStanovanja,
            this.colOpćina,
            this.colDatumRođenja,
            this.colMjestoRođenja,
            this.colBrojTelefona,
            this.colCeljust,
            this.colStrana,
            this.colZub,
            this.colDetaljanOpis,
            this.colDatumDodavanja});
            this.gridView1.GridControl = this.detaljan_viewGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colJMBG
            // 
            this.colJMBG.FieldName = "JMBG";
            this.colJMBG.Name = "colJMBG";
            this.colJMBG.OptionsColumn.AllowEdit = false;
            this.colJMBG.OptionsColumn.ReadOnly = true;
            this.colJMBG.Visible = true;
            this.colJMBG.VisibleIndex = 0;
            // 
            // colIme
            // 
            this.colIme.FieldName = "Ime";
            this.colIme.Name = "colIme";
            this.colIme.OptionsColumn.AllowEdit = false;
            this.colIme.OptionsColumn.ReadOnly = true;
            this.colIme.Visible = true;
            this.colIme.VisibleIndex = 1;
            // 
            // colPrezime
            // 
            this.colPrezime.FieldName = "Prezime";
            this.colPrezime.Name = "colPrezime";
            this.colPrezime.OptionsColumn.AllowEdit = false;
            this.colPrezime.OptionsColumn.ReadOnly = true;
            this.colPrezime.Visible = true;
            this.colPrezime.VisibleIndex = 2;
            // 
            // colMjestoStanovanja
            // 
            this.colMjestoStanovanja.FieldName = "MjestoStanovanja";
            this.colMjestoStanovanja.Name = "colMjestoStanovanja";
            this.colMjestoStanovanja.OptionsColumn.AllowEdit = false;
            this.colMjestoStanovanja.OptionsColumn.ReadOnly = true;
            this.colMjestoStanovanja.Visible = true;
            this.colMjestoStanovanja.VisibleIndex = 3;
            // 
            // colOpćina
            // 
            this.colOpćina.FieldName = "Općina";
            this.colOpćina.Name = "colOpćina";
            this.colOpćina.OptionsColumn.AllowEdit = false;
            this.colOpćina.OptionsColumn.ReadOnly = true;
            this.colOpćina.Visible = true;
            this.colOpćina.VisibleIndex = 4;
            // 
            // colDatumRođenja
            // 
            this.colDatumRođenja.FieldName = "DatumRođenja";
            this.colDatumRođenja.Name = "colDatumRođenja";
            this.colDatumRođenja.OptionsColumn.AllowEdit = false;
            this.colDatumRođenja.OptionsColumn.ReadOnly = true;
            this.colDatumRođenja.Visible = true;
            this.colDatumRođenja.VisibleIndex = 5;
            // 
            // colMjestoRođenja
            // 
            this.colMjestoRođenja.FieldName = "MjestoRođenja";
            this.colMjestoRođenja.Name = "colMjestoRođenja";
            this.colMjestoRođenja.OptionsColumn.AllowEdit = false;
            this.colMjestoRođenja.OptionsColumn.ReadOnly = true;
            this.colMjestoRođenja.Visible = true;
            this.colMjestoRođenja.VisibleIndex = 6;
            // 
            // colBrojTelefona
            // 
            this.colBrojTelefona.FieldName = "BrojTelefona";
            this.colBrojTelefona.Name = "colBrojTelefona";
            this.colBrojTelefona.OptionsColumn.AllowEdit = false;
            this.colBrojTelefona.OptionsColumn.ReadOnly = true;
            this.colBrojTelefona.Visible = true;
            this.colBrojTelefona.VisibleIndex = 7;
            // 
            // colCeljust
            // 
            this.colCeljust.FieldName = "Celjust";
            this.colCeljust.Name = "colCeljust";
            this.colCeljust.OptionsColumn.AllowEdit = false;
            this.colCeljust.OptionsColumn.ReadOnly = true;
            this.colCeljust.Visible = true;
            this.colCeljust.VisibleIndex = 8;
            // 
            // colStrana
            // 
            this.colStrana.FieldName = "Strana";
            this.colStrana.Name = "colStrana";
            this.colStrana.OptionsColumn.AllowEdit = false;
            this.colStrana.OptionsColumn.ReadOnly = true;
            this.colStrana.Visible = true;
            this.colStrana.VisibleIndex = 9;
            // 
            // colZub
            // 
            this.colZub.FieldName = "Zub";
            this.colZub.Name = "colZub";
            this.colZub.OptionsColumn.AllowEdit = false;
            this.colZub.OptionsColumn.ReadOnly = true;
            this.colZub.Visible = true;
            this.colZub.VisibleIndex = 10;
            // 
            // colDetaljanOpis
            // 
            this.colDetaljanOpis.FieldName = "DetaljanOpis";
            this.colDetaljanOpis.Name = "colDetaljanOpis";
            this.colDetaljanOpis.OptionsColumn.AllowEdit = false;
            this.colDetaljanOpis.OptionsColumn.ShowCaption = false;
            this.colDetaljanOpis.Visible = true;
            this.colDetaljanOpis.VisibleIndex = 11;
            // 
            // colDatumDodavanja
            // 
            this.colDatumDodavanja.FieldName = "DatumDodavanja";
            this.colDatumDodavanja.Name = "colDatumDodavanja";
            this.colDatumDodavanja.OptionsColumn.AllowEdit = false;
            this.colDatumDodavanja.OptionsColumn.ReadOnly = true;
            this.colDatumDodavanja.Visible = true;
            this.colDatumDodavanja.VisibleIndex = 12;
            // 
            // Izvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 449);
            this.Controls.Add(this.detaljan_viewGridControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Izvjestaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvjestaji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Izvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stomatoloskaOrdinacijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljan_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaljan_viewGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StomatoloskaOrdinacijaDataSet stomatoloskaOrdinacijaDataSet;
        private System.Windows.Forms.BindingSource detaljan_viewBindingSource;
        private StomatoloskaOrdinacijaDataSetTableAdapters.detaljan_viewTableAdapter detaljan_viewTableAdapter;
        private StomatoloskaOrdinacijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl detaljan_viewGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colJMBG;
        private DevExpress.XtraGrid.Columns.GridColumn colIme;
        private DevExpress.XtraGrid.Columns.GridColumn colPrezime;
        private DevExpress.XtraGrid.Columns.GridColumn colMjestoStanovanja;
        private DevExpress.XtraGrid.Columns.GridColumn colOpćina;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumRođenja;
        private DevExpress.XtraGrid.Columns.GridColumn colMjestoRođenja;
        private DevExpress.XtraGrid.Columns.GridColumn colBrojTelefona;
        private DevExpress.XtraGrid.Columns.GridColumn colCeljust;
        private DevExpress.XtraGrid.Columns.GridColumn colStrana;
        private DevExpress.XtraGrid.Columns.GridColumn colZub;
        private DevExpress.XtraGrid.Columns.GridColumn colDetaljanOpis;
        private DevExpress.XtraGrid.Columns.GridColumn colDatumDodavanja;
    }
}