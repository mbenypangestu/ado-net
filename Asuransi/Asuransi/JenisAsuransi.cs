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
    public partial class JenisAsuransi : Form
    {
        public JenisAsuransi()
        {
            InitializeComponent();
        }

        private void jenis_asuransiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jenis_asuransiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asuransiDataSet);

        }

        private void JenisAsuransi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_asuransiDataSet.Jenis_asuransi' table. You can move, or remove it, as needed.
            this.jenis_asuransiTableAdapter.Fill(this.db_asuransiDataSet.Jenis_asuransi);

        }
    }
}
