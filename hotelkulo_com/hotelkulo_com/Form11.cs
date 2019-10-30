using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelkulo_com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_hotelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hotelDataSet.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.db_hotelDataSet.hotel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            search();
        }

        private void search()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = hotelDataGridView.DataSource;
            bs.Filter = "name like '%" + txtSearch.Text + "%'";
            hotelDataGridView.DataSource = bs;
        }
    }
}
