
namespace FastFactory.Modüller._4_Muhasebe
{
    partial class FrmIrsaliyeler
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.faturalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalanmışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türeGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalanmışlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalanmamışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.görüntüleToolStripMenuItem,
            this.faturalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "İşlemler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // faturalaToolStripMenuItem
            // 
            this.faturalaToolStripMenuItem.Name = "faturalaToolStripMenuItem";
            this.faturalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturalaToolStripMenuItem.Text = "Faturala";
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümüToolStripMenuItem,
            this.türeGöreToolStripMenuItem,
            this.faturalanmışlarToolStripMenuItem});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // faturalanmışlarToolStripMenuItem
            // 
            this.faturalanmışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturalanmışlarToolStripMenuItem1,
            this.faturalanmamışlarToolStripMenuItem});
            this.faturalanmışlarToolStripMenuItem.Name = "faturalanmışlarToolStripMenuItem";
            this.faturalanmışlarToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.faturalanmışlarToolStripMenuItem.Text = "Faturalanma Durumuna Göre";
            // 
            // tümüToolStripMenuItem
            // 
            this.tümüToolStripMenuItem.Name = "tümüToolStripMenuItem";
            this.tümüToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümüToolStripMenuItem.Text = "Tümü";
            // 
            // türeGöreToolStripMenuItem
            // 
            this.türeGöreToolStripMenuItem.Name = "türeGöreToolStripMenuItem";
            this.türeGöreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.türeGöreToolStripMenuItem.Text = "Türe Göre";
            // 
            // faturalanmışlarToolStripMenuItem1
            // 
            this.faturalanmışlarToolStripMenuItem1.Name = "faturalanmışlarToolStripMenuItem1";
            this.faturalanmışlarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.faturalanmışlarToolStripMenuItem1.Text = "Faturalanmışlar";
            // 
            // faturalanmamışlarToolStripMenuItem
            // 
            this.faturalanmamışlarToolStripMenuItem.Name = "faturalanmamışlarToolStripMenuItem";
            this.faturalanmamışlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faturalanmamışlarToolStripMenuItem.Text = "Faturalanmamışlar";
            // 
            // FrmIrsaliyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmIrsaliyeler";
            this.ShowIcon = false;
            this.Text = "İrsaliyeler";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türeGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalanmışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalanmışlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faturalanmamışlarToolStripMenuItem;
    }
}