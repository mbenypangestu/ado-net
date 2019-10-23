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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            Database db = new Database();
            
            SqlConnection conn = db.connect();
            conn.Open();

            String query = "SELECT * FROM t_penjualan";
            SqlCommand cmd = db.runQuery(query);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            SqlConnection conn = db.connect();
            conn.Open();

            DateTime now = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";

            String query = "INSERT INTO t_penjualan (tgl_transaksi, total) VALUES('" + now.ToString(format) + "', 0)";
            SqlCommand cmd = db.runQuery(query);


            String query2 = "SELECT * FROM t_penjualan ORDER BY id DESC OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY";
            SqlCommand cmd2 = db.runQuery(query2);

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt1);

            displayData();

            Transaksi trans = new Transaksi(dt1);
            trans.Show();

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ternak ternak = new Ternak();
            ternak.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
