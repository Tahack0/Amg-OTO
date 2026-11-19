namespace Amg_OTO
{
    partial class FrmFaturalar
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
            this.dataGridFaturalar = new System.Windows.Forms.DataGridView();
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            this.lblFaturaListe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOdemeTur = new System.Windows.Forms.ComboBox();
            this.txtOdenenTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtFaturaId = new System.Windows.Forms.TextBox();
            this.txtServisId = new System.Windows.Forms.TextBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFaturalar
            // 
            this.dataGridFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFaturalar.Location = new System.Drawing.Point(12, 47);
            this.dataGridFaturalar.MultiSelect = false;
            this.dataGridFaturalar.Name = "dataGridFaturalar";
            this.dataGridFaturalar.ReadOnly = true;
            this.dataGridFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFaturalar.Size = new System.Drawing.Size(776, 150);
            this.dataGridFaturalar.TabIndex = 0;
            this.dataGridFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFaturalar_CellClick);
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Location = new System.Drawing.Point(587, 381);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOdemeEkle.TabIndex = 2;
            this.btnOdemeEkle.Text = "Ödeme Ekle";
            this.btnOdemeEkle.UseVisualStyleBackColor = true;
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // lblFaturaListe
            // 
            this.lblFaturaListe.AutoSize = true;
            this.lblFaturaListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaListe.Location = new System.Drawing.Point(305, 9);
            this.lblFaturaListe.Name = "lblFaturaListe";
            this.lblFaturaListe.Size = new System.Drawing.Size(123, 31);
            this.lblFaturaListe.TabIndex = 3;
            this.lblFaturaListe.Text = "Faturalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ödeme Türü :";
            // 
            // cmbOdemeTur
            // 
            this.cmbOdemeTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTur.FormattingEnabled = true;
            this.cmbOdemeTur.Location = new System.Drawing.Point(587, 245);
            this.cmbOdemeTur.Name = "cmbOdemeTur";
            this.cmbOdemeTur.Size = new System.Drawing.Size(121, 21);
            this.cmbOdemeTur.TabIndex = 5;
            // 
            // txtOdenenTutar
            // 
            this.txtOdenenTutar.Location = new System.Drawing.Point(587, 302);
            this.txtOdenenTutar.Name = "txtOdenenTutar";
            this.txtOdenenTutar.Size = new System.Drawing.Size(100, 20);
            this.txtOdenenTutar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " Tutar      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FATURA DETAYI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "||";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "||";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "||";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "||";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "||";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "||";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "||";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "||";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(376, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "||";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "||";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "||";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(376, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "||";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(376, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "||";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(376, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "||";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(376, 384);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "||";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(376, 397);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "||";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(376, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "||";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(376, 423);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "||";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(376, 436);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "||";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(546, 205);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "ÖDEME EKLE";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 253);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Fatura ID";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 296);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Servis ID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 336);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "Toplam";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 381);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "Tarih";
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(114, 250);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.ReadOnly = true;
            this.txtFaturaId.Size = new System.Drawing.Size(100, 20);
            this.txtFaturaId.TabIndex = 34;
            // 
            // txtServisId
            // 
            this.txtServisId.Location = new System.Drawing.Point(114, 293);
            this.txtServisId.Name = "txtServisId";
            this.txtServisId.ReadOnly = true;
            this.txtServisId.Size = new System.Drawing.Size(100, 20);
            this.txtServisId.TabIndex = 35;
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(114, 333);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(100, 20);
            this.txtToplam.TabIndex = 36;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(114, 374);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(100, 20);
            this.txtTarih.TabIndex = 37;
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtServisId);
            this.Controls.Add(this.txtFaturaId);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdenenTutar);
            this.Controls.Add(this.cmbOdemeTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFaturaListe);
            this.Controls.Add(this.btnOdemeEkle);
            this.Controls.Add(this.dataGridFaturalar);
            this.Name = "FrmFaturalar";
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaturalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFaturalar;
        private System.Windows.Forms.Button btnOdemeEkle;
        private System.Windows.Forms.Label lblFaturaListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOdemeTur;
        private System.Windows.Forms.TextBox txtOdenenTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.TextBox txtServisId;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtTarih;
    }
}