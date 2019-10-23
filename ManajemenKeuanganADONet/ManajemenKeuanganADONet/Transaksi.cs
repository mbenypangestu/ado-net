using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManajemenKeuanganADONet
{
    public partial class Transaksi : Form
    {
        public DataTable detail_trans;
        public int selected;
        public Transaksi(DataTable dt)
        {
            InitializeComponent();
            loadTernak();
            displayDataDetailTrans(dt);
            this.detail_trans = dt;
        }

        public void loadTernak()
        {
            Database db = new Database();

            SqlConnection conn = db.connect();
            conn.Open();

            String query = "SELECT * FROM t_ternak";
            SqlCommand cmd = db.runQuery(query);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "nama_ternak";

            conn.Close();
        }

        public void displayDataDetailTrans(DataTable trans)
        {
            Database db = new Database();

            SqlConnection conn = db.connect();
            conn.Open();

            String query = "SELECT * FROM t_detail WHERE id_trans = " + trans.Rows[0]["id"];
            SqlCommand cmd = db.runQuery(query);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public void displayAfterDataDetailTrans(DataTable trans)
        {
            Database db = new Database();

            SqlConnection conn = db.connect();
            conn.Open();

            String query = "SELECT * FROM t_detail WHERE id_trans = " + this.detail_trans.Rows[0]["id"];
            SqlCommand cmd = db.runQuery(query);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt16(textBox1.Text);
            decimal sub_price = Convert.ToDecimal(textBox1.Text);

            Database db = new Database();
            SqlConnection conn = db.connect();
            conn.Open();

            MessageBox.Show(comboBox1.SelectedValue.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO t_detail (id_trans, id_ternak, qty, sub_price) VALUES("+ this.detail_trans.Rows[0]["id"] + ", "+ Convert.ToInt16(comboBox1.SelectedValue.ToString()) + " ,"+ qty + ", 2000)";
            cmd.ExecuteNonQuery();

            String query1 = "SELECT * FROM t_detail_penjualan WHERE id_transaksi = " + this.detail_trans.Rows[0]["id"];
            SqlCommand cmd1 = db.runQuery(query1);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            displayAfterDataDetailTrans(dt);
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
