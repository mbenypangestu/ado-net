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
    public partial class FormNasabah : Form
    {
        public FormNasabah()
        {
            InitializeComponent();
            comboBox1.Items.Add("Perempuan");
            comboBox1.Items.Add("Laki-laki");
            display_data();
        }

        private void nasabahBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nasabahBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asuransiDataSet);

        }

        private void FormNasabah_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_asuransiDataSet.Jenis_asuransi' table. You can move, or remove it, as needed.
            this.jenis_asuransiTableAdapter.Fill(this.db_asuransiDataSet.Jenis_asuransi);
            // TODO: This line of code loads data into the 'db_asuransiDataSet.Nasabah' table. You can move, or remove it, as needed.
            this.nasabahTableAdapter.Fill(this.db_asuransiDataSet.Nasabah);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var contex = new db_asuransiEntities();
            var nasabah = new Nasabah();
            var asuransi = new Asuransi_nasabah();
            nasabah.nama_nasabah = textBox1.Text;
            nasabah.no_identitas = Convert.ToInt32(textBox2.Text);
            nasabah.tempat_lahir = textBox3.Text;
            nasabah.tanggal_lahir = dateTimePicker1.Value.Date;
            nasabah.jenis_kelamin = comboBox1.Text;
            nasabah.status = textBox4.Text;
            nasabah.pekerjaan = textBox5.Text;
            nasabah.penghasilan = textBox6.Text;
            nasabah.no_telp = Convert.ToInt32(textBox7.Text);
            nasabah.alamat = textBox8.Text;
            contex.Nasabah.Add(nasabah);
            asuransi.id_nasabah = nasabah.id_nasabah;
            asuransi.Jenis_asuransi = comboBox2.Text;
            contex.SaveChanges();
            display_data();

        }
        public void display_data() { 
            var contex = new db_asuransiEntities();
            var data = (from d in contex.Nasabah select d);
            dataGridView1.DataSource = data.ToList();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
