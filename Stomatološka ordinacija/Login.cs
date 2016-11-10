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

namespace Stomatološka_ordinacija
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        string kon = @"Data Source=ANTE\SQLEXPRESS;Initial Catalog=StomatoloskaOrdinacija;Integrated Security=True";

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KorisnickoIme.Clear();
            Lozinka.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection konekcija = new SqlConnection(kon);
                SqlCommand komand = new SqlCommand("Select * from Korisnik where KorisnickoIme=@KorisnickoIme and Lozinka=@Lozinka", konekcija);
                komand.Parameters.AddWithValue("@KorisnickoIme", KorisnickoIme.Text);
                komand.Parameters.AddWithValue("@Lozinka", Lozinka.Text);
                konekcija .Open();
                SqlDataAdapter adapt = new SqlDataAdapter(komand);
                DataSet dataset = new DataSet();
                adapt.Fill(dataset);
                konekcija.Close();
                int count = dataset.Tables[0].Rows.Count;
                
                if (count == 1)
                {
                    XtraMessageBox.Show("Uspješno ste se prijavili!");
                    this.Hide();
                        Form2 stomatoloska = new Form2();
                        stomatoloska.Show();
                }
                else
                {
                    XtraMessageBox.Show("Netočno korisničko ime ili lozinka!");
                    KorisnickoIme.Clear();
                    Lozinka.Clear();
                   
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
     }
   }
 }
    

    