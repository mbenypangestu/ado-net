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
    public partial class FormSetoran : Form
    {
        public FormSetoran()
        {
            InitializeComponent();
        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asuransiDataSet);

        }

        private void FormSetoran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_asuransiDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.db_asuransiDataSet.Admin);

        }
    }
}
