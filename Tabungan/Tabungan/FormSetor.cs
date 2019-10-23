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
    public partial class FormSetor : Form
    {
        Tabungan t;
        public FormSetor(Tabungan t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int setor = int.Parse(textBox1.Text);
            if (setor <= 5000)
            {
                MessageBox.Show("Gagal simpan uang");
            }
            else {
                t.simpanUang(setor);
                MessageBox.Show("Berhasil Menyimpan Uang" + t.cekSaldo().ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(t);
            formMenu.Show();
            this.Hide();
        }
    }
}
