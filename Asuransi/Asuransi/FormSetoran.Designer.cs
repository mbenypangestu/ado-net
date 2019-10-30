namespace Asuransi
{
    partial class FormSetoran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.db_asuransiDataSet = new Asuransi.db_asuransiDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Asuransi.db_asuransiDataSetTableAdapters.AdminTableAdapter();
            this.tableAdapterManager = new Asuransi.db_asuransiDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.db_asuransiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db_asuransiDataSet
            // 
            this.db_asuransiDataSet.DataSetName = "db_asuransiDataSet";
            this.db_asuransiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.db_asuransiDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.Asuransi_nasabahTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Jenis_asuransiTableAdapter = null;
            this.tableAdapterManager.NasabahTableAdapter = null;
            this.tableAdapterManager.Pembayaran_klaimTableAdapter = null;
            this.tableAdapterManager.SetoranTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Asuransi.db_asuransiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormSetoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 272);
            this.Name = "FormSetoran";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormSetoran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_asuransiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private db_asuransiDataSet db_asuransiDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private db_asuransiDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private db_asuransiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}