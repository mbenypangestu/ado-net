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
    public partial class Ternak : Form
    {
        public Ternak()
        {
            InitializeComponent();
            loadTernak();
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

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void Ternak_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            SqlConnection conn = db.connect();
            conn.Open();

            String query = "INSERT INTO t_ternak (nama_ternak, stock, harga) VALUES('" + textBox1.Text + "', "+ Convert.ToInt16(textBox2.Text) +", " + Convert.ToInt16(textBox3.Text) + ")";
            SqlCommand cmd = db.runQuery(query);


            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);

            loadTernak();

            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
