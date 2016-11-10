using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;

namespace Stomatološka_ordinacija
{
    public partial class DetaljiPacijenta : DevExpress.XtraEditors.XtraForm
    {
        public DetaljiPacijenta()
        {
            InitializeComponent();
        }
        SqlConnection konekcija = new SqlConnection(@"Data Source=ANTE\SQLEXPRESS;Initial Catalog=StomatoloskaOrdinacija;Integrated Security=True");

        private void DetaljiPacijenta_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.detaljiTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.Detalji);
                this.pacijentiTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.Pacijenti);
                celjustcombo();
                stranacombo();
                zubi();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        private void Spremi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Da li želite spremiti?? ", "Poruka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                spremi();
            }
            else
            {
                
            }
            
        }
       
        DateTime vrijeme = DateTime.Now.Date;
        private void spremi()
        {
            try
            {
                    using (SqlCommand kom = new SqlCommand("Insert into Detalji (DetaljanOpis,Celjust,Strana,Zub,JMBG,DatumDodavanja)  Values(@val1,@val2,@val3,@val4,@val5,@val6)", konekcija))
                    {
 
                       kom.Parameters.AddWithValue("@val1", memoEdit1.Text.ToString());
                       kom.Parameters.AddWithValue("@val2", label1.Text);
                       kom.Parameters.AddWithValue("@val3", label2.Text);
                       kom.Parameters.AddWithValue("@val4", label3.Text);
                       kom.Parameters.AddWithValue("@val5", jMBGTextBox.Text.ToString());
                       kom.Parameters.AddWithValue("@val6", vrijeme);

                    if (konekcija.State == ConnectionState.Closed)
                        {
                            konekcija.Open();
                            kom.ExecuteNonQuery();
                            XtraMessageBox.Show("Uspješno spremljeno.");
                        }
                        else
                        {
                            kom.ExecuteNonQuery();
                            XtraMessageBox.Show("Uspješno spremljeno.");
                        }
                    }              
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString());
            }
            finally
            {
                refresiraj();
            }
          }
       
        public void refresiraj()
        {
            memoEdit1.Text = "";
            CeljustCombo.Refresh();
            StranaCombo.Refresh();
            ZubCombo.Refresh();
            DetaljiPacijenta_Load(null, null);
        }
       public void celjustcombo()
        {
            celjust[] lista = new celjust[]  {
                                        new celjust("Gore"),
                                        new celjust("Dolje")
                                        
                                     };
            CeljustCombo.DataSource = lista;
            CeljustCombo.DisplayMember = "imeceljust";
            CeljustCombo.ValueMember = "imeceljust";
            
        }
       public void stranacombo()
        {
            strana[] stranazuba = new strana[]  {
                                        new strana("Desno"),
                                        new strana("Lijevo")

                                     };
            StranaCombo.DataSource = stranazuba;    
            StranaCombo.DisplayMember = "stranaceljusti";
            StranaCombo.ValueMember = "stranaceljusti";
        }
        public void zubi()
        {
            brojzubi[] broj = new brojzubi[]  {
                                        new brojzubi("1"),
                                        new brojzubi("2"),
                                        new brojzubi("3"),
                                        new brojzubi("4"),
                                        new brojzubi("5"),
                                        new brojzubi("6"),
                                        new brojzubi("7"),
                                        new brojzubi("8")

                                     };
            ZubCombo.DataSource = broj;
            ZubCombo.DisplayMember = "brojzuba";
            ZubCombo.ValueMember = "brojzuba";    
        }   
        private void CeljustCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label1.Text = CeljustCombo.SelectedValue.ToString();
        }
        private void StranaCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label2.Text = StranaCombo.SelectedValue.ToString();
        }
        private void ZubCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            label3.Text = ZubCombo.SelectedValue.ToString();
        }
        private void pacijentiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stomatoloskaOrdinacijaDataSet);

        }
        private void pacijentiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stomatoloskaOrdinacijaDataSet);

        }
        private void pacijentiBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stomatoloskaOrdinacijaDataSet);

        }
        internal class strana
        {
            public string stranaceljusti { get; set; }
            public strana (string s)
            {
                stranaceljusti = s;
            }
        }
        internal class brojzubi
        {
            public string brojzuba { get; set; }
            public brojzubi(string i)
            {
                brojzuba = i;
            }
        }
        internal class celjust
        {
            public string imeceljust { get; set; }
            public celjust(string i)
            {
                imeceljust = i;
            }
        }

       
    }
}
