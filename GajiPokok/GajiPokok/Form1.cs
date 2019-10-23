using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GajiPokok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jam = int.Parse(this.textBox1.Text);
            int masa = int.Parse(this.textBox2.Text);
            double hasil_gaji;

            Gaji gaji = new Gaji(jam, masa);
            hasil_gaji = gaji.countGaji();
            MessageBox.Show("Gaji Anda : " + hasil_gaji, "Gaji", MessageBoxButtons.OK);
        }
    }
}
