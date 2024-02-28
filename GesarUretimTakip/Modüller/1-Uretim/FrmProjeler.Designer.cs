
namespace FastFactory.Modüller._1_Uretim
{
    partial class FrmProjeler
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamamlandıDurumunaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamamlandıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devamEdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalEdilenlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askıdaOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üretimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOMListesiAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parçaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askıyaAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumAciklamasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.projeBindingSource;
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
            this.detayToolStripMenuItem,
            this.görüntüleToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.üretimİşlemleriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 92);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümüToolStripMenuItem,
            this.tamamlandıDurumunaGöreToolStripMenuItem});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // tümüToolStripMenuItem
            // 
            this.tümüToolStripMenuItem.Name = "tümüToolStripMenuItem";
            this.tümüToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tümüToolStripMenuItem.Text = "Tümü";
            // 
            // tamamlandıDurumunaGöreToolStripMenuItem
            // 
            this.tamamlandıDurumunaGöreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamamlandıToolStripMenuItem,
            this.devamEdenToolStripMenuItem,
            this.iptalEdilenlToolStripMenuItem,
            this.askıdaOlanlarToolStripMenuItem});
            this.tamamlandıDurumunaGöreToolStripMenuItem.Name = "tamamlandıDurumunaGöreToolStripMenuItem";
            this.tamamlandıDurumunaGöreToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tamamlandıDurumunaGöreToolStripMenuItem.Text = "Tamamlandı Durumuna Göre";
            // 
            // tamamlandıToolStripMenuItem
            // 
            this.tamamlandıToolStripMenuItem.Name = "tamamlandıToolStripMenuItem";
            this.tamamlandıToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tamamlandıToolStripMenuItem.Text = "Tamamlanmışlar";
            this.tamamlandıToolStripMenuItem.Click += new System.EventHandler(this.tamamlandıToolStripMenuItem_Click);
            // 
            // devamEdenToolStripMenuItem
            // 
            this.devamEdenToolStripMenuItem.Name = "devamEdenToolStripMenuItem";
            this.devamEdenToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.devamEdenToolStripMenuItem.Text = "Devam Edenler";
            // 
            // iptalEdilenlToolStripMenuItem
            // 
            this.iptalEdilenlToolStripMenuItem.Name = "iptalEdilenlToolStripMenuItem";
            this.iptalEdilenlToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.iptalEdilenlToolStripMenuItem.Text = "İptal Edilenler";
            // 
            // askıdaOlanlarToolStripMenuItem
            // 
            this.askıdaOlanlarToolStripMenuItem.Name = "askıdaOlanlarToolStripMenuItem";
            this.askıdaOlanlarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.askıdaOlanlarToolStripMenuItem.Text = "Askıda Olanlar";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // üretimİşlemleriToolStripMenuItem
            // 
            this.üretimİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOMListesiAktarToolStripMenuItem,
            this.parçaEkleToolStripMenuItem,
            this.askıyaAlToolStripMenuItem,
            this.iptalEtToolStripMenuItem});
            this.üretimİşlemleriToolStripMenuItem.Name = "üretimİşlemleriToolStripMenuItem";
            this.üretimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.üretimİşlemleriToolStripMenuItem.Text = "Üretim İşlemleri";
            // 
            // bOMListesiAktarToolStripMenuItem
            // 
            this.bOMListesiAktarToolStripMenuItem.Name = "bOMListesiAktarToolStripMenuItem";
            this.bOMListesiAktarToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.bOMListesiAktarToolStripMenuItem.Text = "BOM Listesi Aktar";
            this.bOMListesiAktarToolStripMenuItem.Click += new System.EventHandler(this.bOMListesiAktarToolStripMenuItem_Click);
            // 
            // parçaEkleToolStripMenuItem
            // 
            this.parçaEkleToolStripMenuItem.Name = "parçaEkleToolStripMenuItem";
            this.parçaEkleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.parçaEkleToolStripMenuItem.Text = "Parça Ekle";
            this.parçaEkleToolStripMenuItem.Click += new System.EventHandler(this.parçaEkleToolStripMenuItem_Click);
            // 
            // askıyaAlToolStripMenuItem
            // 
            this.askıyaAlToolStripMenuItem.Name = "askıyaAlToolStripMenuItem";
            this.askıyaAlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.askıyaAlToolStripMenuItem.Text = "Askıya Al";
            // 
            // iptalEtToolStripMenuItem
            // 
            this.iptalEtToolStripMenuItem.Name = "iptalEtToolStripMenuItem";
            this.iptalEtToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.iptalEtToolStripMenuItem.Text = "İptal Et";
            // 
            // projeBindingSource
            // 
            this.projeBindingSource.DataSource = typeof(Cores.Entities.Uretim.Proje);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProjeKodu,
            this.colProjeAdi,
            this.colAciklama,
            this.colDurum,
            this.colDurumAciklamasi});
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
            // colProjeKodu
            // 
            this.colProjeKodu.FieldName = "ProjeKodu";
            this.colProjeKodu.Name = "colProjeKodu";
            this.colProjeKodu.Visible = true;
            this.colProjeKodu.VisibleIndex = 0;
            // 
            // colProjeAdi
            // 
            this.colProjeAdi.FieldName = "ProjeAdi";
            this.colProjeAdi.Name = "colProjeAdi";
            this.colProjeAdi.Visible = true;
            this.colProjeAdi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            // 
            // colDurumAciklamasi
            // 
            this.colDurumAciklamasi.FieldName = "DurumAciklamasi";
            this.colDurumAciklamasi.Name = "colDurumAciklamasi";
            this.colDurumAciklamasi.Visible = true;
            this.colDurumAciklamasi.VisibleIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmProjeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProjeler";
            this.ShowIcon = false;
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.FrmProjeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamamlandıDurumunaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamamlandıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devamEdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalEdilenlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askıdaOlanlarToolStripMenuItem;
        private System.Windows.Forms.BindingSource projeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumAciklamasi;
        private System.Windows.Forms.ToolStripMenuItem üretimİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOMListesiAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askıyaAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parçaEkleToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}