using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wikihotel
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
    }
}
