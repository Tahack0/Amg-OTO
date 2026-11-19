namespace Amg_OTO
{
    partial class FrmStok
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
            this.lblParcaListe = new System.Windows.Forms.Label();
            this.dataGridParcalar = new System.Windows.Forms.DataGridView();
            this.txtParcaKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParcaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParcaListe
            // 
            this.lblParcaListe.AutoSize = true;
            this.lblParcaListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParcaListe.Location = new System.Drawing.Point(242, 9);
            this.lblParcaListe.Name = "lblParcaListe";
            this.lblParcaListe.Size = new System.Drawing.Size(239, 31);
            this.lblParcaListe.TabIndex = 0;
            this.lblParcaListe.Text = "Parça & Stok Listesi";
            // 
            // dataGridParcalar
            // 
            this.dataGridParcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParcalar.Location = new System.Drawing.Point(12, 43);
            this.dataGridParcalar.MultiSelect = false;
            this.dataGridParcalar.Name = "dataGridParcalar";
            this.dataGridParcalar.ReadOnly = true;
            this.dataGridParcalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParcalar.Size = new System.Drawing.Size(654, 150);
            this.dataGridParcalar.TabIndex = 1;
            this.dataGridParcalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridParcalar_CellClick);
            // 
            // txtParcaKodu
            // 
            this.txtParcaKodu.Location = new System.Drawing.Point(200, 265);
            this.txtParcaKodu.Name = "txtParcaKodu";
            this.txtParcaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtParcaKodu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parça Adı";
            // 
            // txtParcaAdi
            // 
            this.txtParcaAdi.Location = new System.Drawing.Point(200, 216);
            this.txtParcaAdi.Name = "txtParcaAdi";
            this.txtParcaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtParcaAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parça Kodu";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(200, 307);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 20);
            this.txtKategori.TabIndex = 6;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(200, 352);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyat.TabIndex = 7;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(200, 395);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtSatisFiyat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(336, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stok Adedi";
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(342, 253);
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(120, 20);
            this.nudStok.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(591, 224);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(591, 265);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(591, 307);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(591, 350);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParcaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParcaKodu);
            this.Controls.Add(this.dataGridParcalar);
            this.Controls.Add(this.lblParcaListe);
            this.Name = "FrmStok";
            this.Text = "FrmStok";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcaListe;
        private System.Windows.Forms.DataGridView dataGridParcalar;
        private System.Windows.Forms.TextBox txtParcaKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParcaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
    }
}