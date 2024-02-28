
namespace FastFactory.Modüller._1_Uretim
{
    partial class FrmIsEmriParametreleri
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
            this.ısEmriParametresiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParametreNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParcaResmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParcaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParcaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalzeme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ısEmriParametresiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.ısEmriParametresiBindingSource;
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
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(238, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
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
            // ısEmriParametresiBindingSource
            // 
            this.ısEmriParametresiBindingSource.DataSource = typeof(Cores.Entities.Uretim.IsEmriParametresi);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colParametreNumarasi,
            this.colParcaResmi,
            this.colParcaKodu,
            this.colParcaAdi,
            this.colMalzeme,
            this.colMarka});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colParametreNumarasi
            // 
            this.colParametreNumarasi.Caption = "Parametre Tanımı";
            this.colParametreNumarasi.FieldName = "ParametreTanimi";
            this.colParametreNumarasi.Name = "colParametreNumarasi";
            this.colParametreNumarasi.OptionsColumn.AllowEdit = false;
            this.colParametreNumarasi.Visible = true;
            this.colParametreNumarasi.VisibleIndex = 0;
            // 
            // colParcaResmi
            // 
            this.colParcaResmi.FieldName = "ParcaResmi";
            this.colParcaResmi.Name = "colParcaResmi";
            this.colParcaResmi.OptionsColumn.AllowEdit = false;
            this.colParcaResmi.Visible = true;
            this.colParcaResmi.VisibleIndex = 1;
            // 
            // colParcaKodu
            // 
            this.colParcaKodu.FieldName = "ParcaKodu";
            this.colParcaKodu.Name = "colParcaKodu";
            this.colParcaKodu.OptionsColumn.AllowEdit = false;
            this.colParcaKodu.Visible = true;
            this.colParcaKodu.VisibleIndex = 2;
            // 
            // colParcaAdi
            // 
            this.colParcaAdi.FieldName = "ParcaAdi";
            this.colParcaAdi.Name = "colParcaAdi";
            this.colParcaAdi.OptionsColumn.AllowEdit = false;
            this.colParcaAdi.Visible = true;
            this.colParcaAdi.VisibleIndex = 3;
            // 
            // colMalzeme
            // 
            this.colMalzeme.FieldName = "Malzeme";
            this.colMalzeme.Name = "colMalzeme";
            this.colMalzeme.OptionsColumn.AllowEdit = false;
            this.colMalzeme.Visible = true;
            this.colMalzeme.VisibleIndex = 4;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 5;
            // 
            // varsayılanİşEmriOlarakAyarlaToolStripMenuItem
            // 
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem.Name = "varsayılanİşEmriOlarakAyarlaToolStripMenuItem";
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem.Text = "Varsayılan İş Emri Olarak Ayarla";
            this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem.Click += new System.EventHandler(this.varsayılanİşEmriOlarakAyarlaToolStripMenuItem_Click);
            // 
            // FrmIsEmriParametreleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmIsEmriParametreleri";
            this.ShowIcon = false;
            this.Text = "İş Emri Parametreleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIsEmriParametreleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ısEmriParametresiBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colParametreNumarasi;
        private DevExpress.XtraGrid.Columns.GridColumn colParcaResmi;
        private DevExpress.XtraGrid.Columns.GridColumn colParcaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colParcaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMalzeme;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private System.Windows.Forms.BindingSource ısEmriParametresiBindingSource;
        private System.Windows.Forms.ToolStripMenuItem varsayılanİşEmriOlarakAyarlaToolStripMenuItem;
    }
}