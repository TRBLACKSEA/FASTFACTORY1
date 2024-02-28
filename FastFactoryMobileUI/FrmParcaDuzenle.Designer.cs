
namespace FastFactoryMobileUI
{
    partial class FrmParcaDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblParcaKodu = new System.Windows.Forms.Label();
            this.gridLookUpEditOperasyonlar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblUretilen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.numericUpDownUretilen = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtParcaAdi = new System.Windows.Forms.TextBox();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditOperasyonlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUretilen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parça Kodu:";
            // 
            // lblParcaKodu
            // 
            this.lblParcaKodu.AutoSize = true;
            this.lblParcaKodu.Location = new System.Drawing.Point(221, 12);
            this.lblParcaKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcaKodu.Name = "lblParcaKodu";
            this.lblParcaKodu.Size = new System.Drawing.Size(23, 31);
            this.lblParcaKodu.TabIndex = 1;
            this.lblParcaKodu.Text = "-";
            // 
            // gridLookUpEditOperasyonlar
            // 
            this.gridLookUpEditOperasyonlar.Location = new System.Drawing.Point(236, 443);
            this.gridLookUpEditOperasyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.gridLookUpEditOperasyonlar.Name = "gridLookUpEditOperasyonlar";
            this.gridLookUpEditOperasyonlar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridLookUpEditOperasyonlar.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditOperasyonlar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditOperasyonlar.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditOperasyonlar.Size = new System.Drawing.Size(321, 40);
            this.gridLookUpEditOperasyonlar.TabIndex = 2;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridLookUpEdit1View.DetailHeight = 453;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parça Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Malzeme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adet:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(231, 358);
            this.lblAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(23, 31);
            this.lblAdet.TabIndex = 1;
            this.lblAdet.Text = "-";
            // 
            // lblUretilen
            // 
            this.lblUretilen.AutoSize = true;
            this.lblUretilen.Location = new System.Drawing.Point(30, 400);
            this.lblUretilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUretilen.Name = "lblUretilen";
            this.lblUretilen.Size = new System.Drawing.Size(197, 31);
            this.lblUretilen.TabIndex = 0;
            this.lblUretilen.Text = "Üretilen Miktar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 447);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Durum:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(236, 493);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(320, 73);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // numericUpDownUretilen
            // 
            this.numericUpDownUretilen.Location = new System.Drawing.Point(237, 398);
            this.numericUpDownUretilen.Name = "numericUpDownUretilen";
            this.numericUpDownUretilen.Size = new System.Drawing.Size(120, 38);
            this.numericUpDownUretilen.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marka :";
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Enabled = false;
            this.txtMalzeme.Location = new System.Drawing.Point(227, 159);
            this.txtMalzeme.Multiline = true;
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(329, 95);
            this.txtMalzeme.TabIndex = 5;
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Location = new System.Drawing.Point(227, 260);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(329, 95);
            this.txtMarka.TabIndex = 5;
            // 
            // txtParcaAdi
            // 
            this.txtParcaAdi.Enabled = false;
            this.txtParcaAdi.Location = new System.Drawing.Point(227, 58);
            this.txtParcaAdi.Multiline = true;
            this.txtParcaAdi.Name = "txtParcaAdi";
            this.txtParcaAdi.Size = new System.Drawing.Size(329, 95);
            this.txtParcaAdi.TabIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Operasyon Adı";
            this.gridColumn2.FieldName = "OperasyonAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Operasyon Tanım ID";
            this.gridColumn3.FieldName = "OperasyonTanimID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // FrmParcaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 569);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtParcaAdi);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.numericUpDownUretilen);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gridLookUpEditOperasyonlar);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUretilen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblParcaKodu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmParcaDuzenle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje : -";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmParcaDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.FrmParcaDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditOperasyonlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUretilen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParcaKodu;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditOperasyonlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUretilen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown numericUpDownUretilen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtParcaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}