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
    public partial class FormMenu : Form
    {
        Tabungan t;
        public FormMenu(Tabungan t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormSaldo formSaldo = new FormSaldo(t);
            formSaldo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTransfer formTransfer = new FormTransfer(t);
            formTransfer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTarik formTarik = new FormTarik(t);
            formTarik.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSetor formSetor = new FormSetor(t);
            formSetor.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormDollar form = new FormDollar(t);
            form.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FormDollar form = new FormDollar(t);
            form.Show();
            this.Hide();
        }
    }
}
