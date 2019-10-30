namespace Asuransi
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nasabahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranKlaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.jenisAsuransiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nasabahToolStripMenuItem,
            this.setoranToolStripMenuItem,
            this.pembayaranKlaimToolStripMenuItem,
            this.jenisAsuransiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nasabahToolStripMenuItem
            // 
            this.nasabahToolStripMenuItem.Name = "nasabahToolStripMenuItem";
            this.nasabahToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.nasabahToolStripMenuItem.Text = "Nasabah";
            this.nasabahToolStripMenuItem.Click += new System.EventHandler(this.nasabahToolStripMenuItem_Click);
            // 
            // setoranToolStripMenuItem
            // 
            this.setoranToolStripMenuItem.Name = "setoranToolStripMenuItem";
            this.setoranToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.setoranToolStripMenuItem.Text = "Setoran";
            this.setoranToolStripMenuItem.Click += new System.EventHandler(this.setoranToolStripMenuItem_Click);
            // 
            // pembayaranKlaimToolStripMenuItem
            // 
            this.pembayaranKlaimToolStripMenuItem.Name = "pembayaranKlaimToolStripMenuItem";
            this.pembayaranKlaimToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.pembayaranKlaimToolStripMenuItem.Text = "Pembayaran Klaim";
            this.pembayaranKlaimToolStripMenuItem.Click += new System.EventHandler(this.pembayaranKlaimToolStripMenuItem_Click);
            // 
            // jenisAsuransiToolStripMenuItem
            // 
            this.jenisAsuransiToolStripMenuItem.Name = "jenisAsuransiToolStripMenuItem";
            this.jenisAsuransiToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.jenisAsuransiToolStripMenuItem.Text = "Jenis Asuransi";
            this.jenisAsuransiToolStripMenuItem.Click += new System.EventHandler(this.jenisAsuransiToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 538);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nasabahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setoranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembayaranKlaimToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem jenisAsuransiToolStripMenuItem;
    }
}

