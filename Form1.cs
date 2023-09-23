using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTiga3
{
    public partial class FrmTiga : Form
    {
        public FrmTiga()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = TxtNama.Text;
            var pendidikan = CmbPndk.Text; ;
            var pekerjaan = List.Text;

            txtPsn1.Text = string.Format("Haloo... {0}", nama);
            txtPsn2.Text = string.Format("Pendidikan Anda {0}, benar?? ", pendidikan);
            txtPsn3.Text = string.Format("Anda Seorang {0}, Hebattt !!! ",pekerjaan);
        }
    }
}
