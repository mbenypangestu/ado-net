using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabungan
{
    public partial class FormTarik : Form
    {
        Tabungan t;
        public FormTarik(Tabungan t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(t);
            formMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.ambilRupiah(int.Parse(textBox1.Text));
            MessageBox.Show("Berhasil Mengambil Uang" + t.cekSaldo().ToString());
        }
    }
}
