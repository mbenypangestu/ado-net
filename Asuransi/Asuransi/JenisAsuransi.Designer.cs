namespace Asuransi
{
    partial class JenisAsuransi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenisAsuransi));
            this.db_asuransiDataSet = new Asuransi.db_asuransiDataSet();
            this.jenis_asuransiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jenis_asuransiTableAdapter = new Asuransi.db_asuransiDataSetTableAdapters.Jenis_asuransiTableAdapter();
            this.tableAdapterManager = new Asuransi.db_asuransiDataSetTableAdapters.TableAdapterManager();
            this.jenis_asuransiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.jenis_asuransiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jenis_asuransiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_asuransiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiBindingNavigator)).BeginInit();
            this.jenis_asuransiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // db_asuransiDataSet
            // 
            this.db_asuransiDataSet.DataSetName = "db_asuransiDataSet";
            this.db_asuransiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenis_asuransiBindingSource
            // 
            this.jenis_asuransiBindingSource.DataMember = "Jenis_asuransi";
            this.jenis_asuransiBindingSource.DataSource = this.db_asuransiDataSet;
            // 
            // jenis_asuransiTableAdapter
            // 
            this.jenis_asuransiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.Asuransi_nasabahTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Jenis_asuransiTableAdapter = this.jenis_asuransiTableAdapter;
            this.tableAdapterManager.NasabahTableAdapter = null;
            this.tableAdapterManager.Pembayaran_klaimTableAdapter = null;
            this.tableAdapterManager.SetoranTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Asuransi.db_asuransiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jenis_asuransiBindingNavigator
            // 
            this.jenis_asuransiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jenis_asuransiBindingNavigator.BindingSource = this.jenis_asuransiBindingSource;
            this.jenis_asuransiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jenis_asuransiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jenis_asuransiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jenis_asuransiBindingNavigatorSaveItem});
            this.jenis_asuransiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jenis_asuransiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jenis_asuransiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jenis_asuransiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jenis_asuransiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jenis_asuransiBindingNavigator.Name = "jenis_asuransiBindingNavigator";
            this.jenis_asuransiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jenis_asuransiBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.jenis_asuransiBindingNavigator.TabIndex = 0;
            this.jenis_asuransiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // jenis_asuransiBindingNavigatorSaveItem
            // 
            this.jenis_asuransiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jenis_asuransiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jenis_asuransiBindingNavigatorSaveItem.Image")));
            this.jenis_asuransiBindingNavigatorSaveItem.Name = "jenis_asuransiBindingNavigatorSaveItem";
            this.jenis_asuransiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.jenis_asuransiBindingNavigatorSaveItem.Text = "Save Data";
            this.jenis_asuransiBindingNavigatorSaveItem.Click += new System.EventHandler(this.jenis_asuransiBindingNavigatorSaveItem_Click);
            // 
            // jenis_asuransiDataGridView
            // 
            this.jenis_asuransiDataGridView.AutoGenerateColumns = false;
            this.jenis_asuransiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jenis_asuransiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.jenis_asuransiDataGridView.DataSource = this.jenis_asuransiBindingSource;
            this.jenis_asuransiDataGridView.Location = new System.Drawing.Point(40, 22);
            this.jenis_asuransiDataGridView.Name = "jenis_asuransiDataGridView";
            this.jenis_asuransiDataGridView.Size = new System.Drawing.Size(348, 193);
            this.jenis_asuransiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kode_asuransi";
            this.dataGridViewTextBoxColumn1.HeaderText = "kode_asuransi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jenis_asuransi";
            this.dataGridViewTextBoxColumn2.HeaderText = "jenis_asuransi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nilai_asuransi";
            this.dataGridViewTextBoxColumn3.HeaderText = "nilai_asuransi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // JenisAsuransi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 386);
            this.Controls.Add(this.jenis_asuransiDataGridView);
            this.Controls.Add(this.jenis_asuransiBindingNavigator);
            this.Name = "JenisAsuransi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JenisAsuransi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_asuransiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiBindingNavigator)).EndInit();
            this.jenis_asuransiBindingNavigator.ResumeLayout(false);
            this.jenis_asuransiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jenis_asuransiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_asuransiDataSet db_asuransiDataSet;
        private System.Windows.Forms.BindingSource jenis_asuransiBindingSource;
        private db_asuransiDataSetTableAdapters.Jenis_asuransiTableAdapter jenis_asuransiTableAdapter;
        private db_asuransiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jenis_asuransiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jenis_asuransiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jenis_asuransiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}