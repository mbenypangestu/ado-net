using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuransi
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void nasabahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNasabah form_nasabah = new FormNasabah();
            form_nasabah.MdiParent = this;
            form_nasabah.Show();
            form_nasabah.Focus();
        }

        private void setoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetoran form_setoran = new FormSetoran();
            form_setoran.MdiParent = this;
            form_setoran.Show();
            form_setoran.Focus();
        }

        private void pembayaranKlaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembayaranKlaim form_klaim = new FormPembayaranKlaim();
            form_klaim.MdiParent = this;
            form_klaim.Show();
            form_klaim.Focus();
        }

        private void jenisAsuransiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JenisAsuransi formJenisAsuransi = new JenisAsuransi();
            formJenisAsuransi.MdiParent = this;
            formJenisAsuransi.Show();
            formJenisAsuransi.Focus();
        }
    }
}
