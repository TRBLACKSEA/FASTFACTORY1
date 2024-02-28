
namespace FastFactory
{
    partial class ParcaKartiUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picParcaResmi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParcaNumarasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picParcaResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // picParcaResmi
            // 
            this.picParcaResmi.Location = new System.Drawing.Point(4, 4);
            this.picParcaResmi.Name = "picParcaResmi";
            this.picParcaResmi.Size = new System.Drawing.Size(136, 142);
            this.picParcaResmi.TabIndex = 0;
            this.picParcaResmi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parça Numarası:";
            // 
            // lblParcaNumarasi
            // 
            this.lblParcaNumarasi.AutoSize = true;
            this.lblParcaNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParcaNumarasi.Location = new System.Drawing.Point(277, 4);
            this.lblParcaNumarasi.Name = "lblParcaNumarasi";
            this.lblParcaNumarasi.Size = new System.Drawing.Size(125, 20);
            this.lblParcaNumarasi.TabIndex = 1;
            this.lblParcaNumarasi.Text = "Parça Numarası:";
            // 
            // ParcaKartiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblParcaNumarasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picParcaResmi);
            this.Name = "ParcaKartiUserControl";
            this.Size = new System.Drawing.Size(488, 149);
            ((System.ComponentModel.ISupportInitialize)(this.picParcaResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picParcaResmi;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblParcaNumarasi;
    }
}
