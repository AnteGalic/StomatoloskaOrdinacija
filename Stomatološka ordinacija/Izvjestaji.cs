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

namespace Stomatološka_ordinacija
{
    public partial class Izvjestaji : DevExpress.XtraEditors.XtraForm
    {
        public Izvjestaji()
        {
            InitializeComponent();
        }

        private void Izvjestaji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stomatoloskaOrdinacijaDataSet.detaljan_view' table. You can move, or remove it, as needed.
            this.detaljan_viewTableAdapter.Fill(this.stomatoloskaOrdinacijaDataSet.detaljan_view);

        }
    }
}