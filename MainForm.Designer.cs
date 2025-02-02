namespace XmlClassApplication
{
    partial class MainForm
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
            this.dgvKalibrasyonBilgileri = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCihazEkle = new System.Windows.Forms.Button();
            this.tbTestBaslangicZamani = new System.Windows.Forms.TextBox();
            this.tbTestBitisZamani = new System.Windows.Forms.TextBox();
            this.tbOperatorAdi = new System.Windows.Forms.TextBox();
            this.dgvEmpedansOlcumleriBeta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalibrasyonBilgileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpedansOlcumleriBeta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKalibrasyonBilgileri
            // 
            this.dgvKalibrasyonBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKalibrasyonBilgileri.Location = new System.Drawing.Point(12, 12);
            this.dgvKalibrasyonBilgileri.Name = "dgvKalibrasyonBilgileri";
            this.dgvKalibrasyonBilgileri.RowHeadersWidth = 51;
            this.dgvKalibrasyonBilgileri.RowTemplate.Height = 24;
            this.dgvKalibrasyonBilgileri.Size = new System.Drawing.Size(663, 194);
            this.dgvKalibrasyonBilgileri.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(347, 263);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCihazEkle
            // 
            this.btnCihazEkle.Location = new System.Drawing.Point(12, 263);
            this.btnCihazEkle.Name = "btnCihazEkle";
            this.btnCihazEkle.Size = new System.Drawing.Size(131, 23);
            this.btnCihazEkle.TabIndex = 2;
            this.btnCihazEkle.Text = "Cihaz Ekle";
            this.btnCihazEkle.UseVisualStyleBackColor = true;
            this.btnCihazEkle.Click += new System.EventHandler(this.btnCihazEkle_Click);
            // 
            // tbTestBaslangicZamani
            // 
            this.tbTestBaslangicZamani.Location = new System.Drawing.Point(575, 240);
            this.tbTestBaslangicZamani.Name = "tbTestBaslangicZamani";
            this.tbTestBaslangicZamani.Size = new System.Drawing.Size(100, 22);
            this.tbTestBaslangicZamani.TabIndex = 3;
            // 
            // tbTestBitisZamani
            // 
            this.tbTestBitisZamani.Location = new System.Drawing.Point(575, 212);
            this.tbTestBitisZamani.Name = "tbTestBitisZamani";
            this.tbTestBitisZamani.Size = new System.Drawing.Size(100, 22);
            this.tbTestBitisZamani.TabIndex = 3;
            // 
            // tbOperatorAdi
            // 
            this.tbOperatorAdi.Location = new System.Drawing.Point(12, 212);
            this.tbOperatorAdi.Name = "tbOperatorAdi";
            this.tbOperatorAdi.Size = new System.Drawing.Size(100, 22);
            this.tbOperatorAdi.TabIndex = 3;
            // 
            // dgvEmpedansOlcumleriBeta
            // 
            this.dgvEmpedansOlcumleriBeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpedansOlcumleriBeta.Location = new System.Drawing.Point(706, 12);
            this.dgvEmpedansOlcumleriBeta.Name = "dgvEmpedansOlcumleriBeta";
            this.dgvEmpedansOlcumleriBeta.RowHeadersWidth = 51;
            this.dgvEmpedansOlcumleriBeta.RowTemplate.Height = 24;
            this.dgvEmpedansOlcumleriBeta.Size = new System.Drawing.Size(783, 194);
            this.dgvEmpedansOlcumleriBeta.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 450);
            this.Controls.Add(this.tbOperatorAdi);
            this.Controls.Add(this.tbTestBitisZamani);
            this.Controls.Add(this.tbTestBaslangicZamani);
            this.Controls.Add(this.btnCihazEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvEmpedansOlcumleriBeta);
            this.Controls.Add(this.dgvKalibrasyonBilgileri);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalibrasyonBilgileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpedansOlcumleriBeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKalibrasyonBilgileri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCihazEkle;
        private System.Windows.Forms.TextBox tbTestBaslangicZamani;
        private System.Windows.Forms.TextBox tbTestBitisZamani;
        private System.Windows.Forms.TextBox tbOperatorAdi;
        private System.Windows.Forms.DataGridView dgvEmpedansOlcumleriBeta;
    }
}

