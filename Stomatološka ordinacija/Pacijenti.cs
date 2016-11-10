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
using DevExpress.XtraGrid.Views.Grid;

namespace Stomatološka_ordinacija
{
    public partial class Pacijenti : DevExpress.XtraEditors.XtraForm
    {
        public Pacijenti()
        {
            InitializeComponent();
        }
        SqlConnection konekcija = new SqlConnection(@"Data Source=ANTE\SQLEXPRESS;Initial Catalog=StomatoloskaOrdinacija;Integrated Security=True");

        private void pacijentiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentiBindingSource.EndEdit();
        }

        private void Pacijenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stomatoloskaOrdinacijaDataSet.Pacijenti' table. You can move, or remove it, as needed.
            this.pacijentiTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.Pacijenti);
            Brisanje.Enabled = false;
            Izmjena.Enabled = false;
        }

        private void pacijentiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stomatoloskaOrdinacijaDataSet);
        }
        private void Novi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Jmbg.Text) || string.IsNullOrWhiteSpace(Ime.Text) || string.IsNullOrWhiteSpace(Prezime.Text) || string.IsNullOrWhiteSpace(MjestoStanovanja.Text) || string.IsNullOrWhiteSpace(Opcina.Text) || string.IsNullOrWhiteSpace(MjestoRodenja.Text) || string.IsNullOrWhiteSpace(BrojTelefona.Text) || Jmbg.Text.Length < 13 || Jmbg.Text.Length > 13)
                {
                    XtraMessageBox.Show("Molimo ispravno popunite polja");
                }
                else
                {
                    novipacijent();
                }
            }
            catch(Exception exe)
            {
                XtraMessageBox.Show(exe.ToString());
            }
            }
        private void Brisanje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Želite li izbrisati odabranog pacijenta?", "Poruka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                brisi();
                Pacijenti_Load(null, null);
            }
            else
            {
                refresirajboxove();
            }
        }
        private void Izmjena_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show("Želite spremiti izmjene", "Poruka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                azuriraj();
            }
            else
            {
                refresirajboxove();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            refresirajboxove();
        }
        private void novipacijent()
        {
            try
            {
                if (Jmbg.Text.Length < 13 || Jmbg.Text.Length > 13)
                {
                    XtraMessageBox.Show("JMBG mora sadržavati 13 znamenki!!!");
                }    
                else
                {
                    using (SqlCommand kom = new SqlCommand("Insert into Pacijenti (JMBG,Ime,Prezime,MjestoStanovanja,Općina,DatumRođenja,MjestoRođenja,BrojTelefona)  Values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8)", konekcija))
                    {

                        kom.Parameters.AddWithValue("@val1", Jmbg.Text);
                        kom.Parameters.AddWithValue("@val2", Ime.Text);
                        kom.Parameters.AddWithValue("@val3", Prezime.Text);
                        kom.Parameters.AddWithValue("@val4", MjestoStanovanja.Text);
                        kom.Parameters.AddWithValue("@val5", Opcina.Text);
                        kom.Parameters.AddWithValue("@val6", DatumRodenja.DateTime.Date);
                        kom.Parameters.AddWithValue("@val7", MjestoRodenja.Text);
                        kom.Parameters.AddWithValue("@val8", BrojTelefona.Text);

                        if (konekcija.State == ConnectionState.Closed)
                        {
                            konekcija.Open();
                            kom.ExecuteNonQuery();
                            XtraMessageBox.Show("Uspješno dodan novi pacijent");
                        }
                        else
                        {
                            kom.ExecuteNonQuery();
                            XtraMessageBox.Show("Uspješno dodan novi pacijent");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString());
            }
            finally
            {
                refresirajboxove();
                
            }
        }
        private void brisi()
        {
            try
            {
                using (SqlCommand kom = new SqlCommand("DELETE FROM Pacijenti Where JMBG = @JMBG", konekcija))
                {
                    kom.Parameters.AddWithValue("@JMBG",Jmbg.Text);
                    if (konekcija.State == ConnectionState.Closed)
                        konekcija.Open();
                    kom.ExecuteNonQuery();
                    XtraMessageBox.Show("Uspjesno ste izbrisali pacijenta!!!");
                }

            }
            finally
            {
                refresirajboxove();
            }
        }
        private void azuriraj()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Jmbg.Text)|| string.IsNullOrWhiteSpace(Ime.Text) || string.IsNullOrWhiteSpace(Prezime.Text) || string.IsNullOrWhiteSpace(MjestoStanovanja.Text) || string.IsNullOrWhiteSpace(Opcina.Text) || string.IsNullOrWhiteSpace(MjestoRodenja.Text) || string.IsNullOrWhiteSpace(BrojTelefona.Text) || Jmbg.Text.Length < 13 || Jmbg.Text.Length > 13)
                {
                    XtraMessageBox.Show("Molimo ispravno popunite polja");
                }
                else
                {
                    using (SqlCommand kom = new SqlCommand("Update Pacijenti SET JMBG=@JMBG,Ime=@Ime,Prezime=@Prezime,MjestoStanovanja=@MjestoStanovanja,Općina=@Općina,DatumRođenja=@DatumRođenja,MjestoRođenja=@MjestoRođenja,BrojTelefona=@BrojTelefona where JMBG=@JMBG", konekcija))
                    {
                        kom.Parameters.AddWithValue("@JMBG", Jmbg.Text);
                        kom.Parameters.AddWithValue("@Ime", Ime.Text);
                        kom.Parameters.AddWithValue("@Prezime", Prezime.Text);
                        kom.Parameters.AddWithValue("@MjestoStanovanja", MjestoStanovanja.Text);
                        kom.Parameters.AddWithValue("@Općina", Opcina.Text);
                        kom.Parameters.AddWithValue("@DatumRođenja", DatumRodenja.DateTime.Date);
                        kom.Parameters.AddWithValue("@MjestoRođenja", MjestoRodenja.Text);
                        kom.Parameters.AddWithValue("@BrojTelefona", BrojTelefona.Text);

                        if (konekcija.State == ConnectionState.Closed)
                        {
                            konekcija.Open();
                            kom.ExecuteNonQuery();
                            XtraMessageBox.Show("Uspješno ste izmjenili podatke o pacijentu");
                        }
                        else
                        {
                            kom.ExecuteNonQuery();
                            
                        }
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString());
            }
            finally
            {
                refresirajboxove();
               
            }
        }
        private void refresirajboxove()
        {
            Pacijenti_Load(null, null);
            Jmbg.Clear();
            Ime.Clear();
            Prezime.Clear();
            MjestoStanovanja.Clear();
            Opcina.Clear();
            DatumRodenja.ResetText();
            MjestoRodenja.Clear();
            BrojTelefona.Clear();
        }
        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Brisanje.Enabled = true;
            Izmjena.Enabled = true;
            Jmbg.Text = gridView1.GetDataRow(e.RowHandle)["JMBG"].ToString();
            Ime.Text = gridView1.GetDataRow(e.RowHandle)["Ime"].ToString();
            Prezime.Text = gridView1.GetDataRow(e.RowHandle)["Prezime"].ToString();
            MjestoStanovanja.Text = gridView1.GetDataRow(e.RowHandle)["MjestoStanovanja"].ToString();
            Opcina.Text = gridView1.GetDataRow(e.RowHandle)["Općina"].ToString();
            DatumRodenja.DateTime = Convert.ToDateTime(gridView1.GetDataRow(e.RowHandle)["DatumRođenja"].ToString()).Date;
            MjestoRodenja.Text = gridView1.GetDataRow(e.RowHandle)["MjestoRođenja"].ToString();
            BrojTelefona.Text = gridView1.GetDataRow(e.RowHandle)["BrojTelefona"].ToString();

        }
        private void Jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <'0' || e.KeyChar > '9' || e.KeyChar == '.' )
            {
                e.Handled = true;
                XtraMessageBox.Show("Ovo polje prihvaća samo brojeve od 1-9!!!");
            }
            else
            {
                e.Handled = false;  
            }
        }
        private void ProvjeriJMBG()
        {
            SqlCommand command = new SqlCommand("select JMBG from Pacijenti", konekcija);
            if (konekcija.State == ConnectionState.Closed)
                konekcija.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {

                string x = (read["JMBG"]).ToString();
                if (Jmbg.Text == x)
                {
                    XtraMessageBox.Show("'" + Jmbg.Text + "' već postoji u bazi");
                    Jmbg.Text = "";
                }

            }
            read.Close();

        }
        private void Ime_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeriJMBG();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DetaljiPacijenta detalji = new DetaljiPacijenta();
            detalji.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Izvjestaji izvjestaj = new Izvjestaji();
            izvjestaj.ShowDialog();
        }
    }
}