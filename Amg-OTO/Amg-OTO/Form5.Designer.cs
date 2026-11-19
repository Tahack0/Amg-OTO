namespace Amg_OTO
{
    partial class FrmServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServis));
            this.lblParca = new System.Windows.Forms.Label();
            this.cmbParca = new System.Windows.Forms.ComboBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnParcaEkle = new System.Windows.Forms.Button();
            this.dataGridServisParcalar = new System.Windows.Forms.DataGridView();
            this.lblArac = new System.Windows.Forms.Label();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.btnServisAc = new System.Windows.Forms.Button();
            this.tabServis = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblIscilik = new System.Windows.Forms.Label();
            this.cmbIscilik = new System.Windows.Forms.ComboBox();
            this.btnIscilikEkle = new System.Windows.Forms.Button();
            this.btnServisTamamla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridServisIscilikler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServisParcalar)).BeginInit();
            this.tabServis.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServisIscilikler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParca
            // 
            this.lblParca.AutoSize = true;
            this.lblParca.Location = new System.Drawing.Point(12, 20);
            this.lblParca.Name = "lblParca";
            this.lblParca.Size = new System.Drawing.Size(35, 13);
            this.lblParca.TabIndex = 0;
            this.lblParca.Text = "Parça";
            // 
            // cmbParca
            // 
            this.cmbParca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParca.FormattingEnabled = true;
            this.cmbParca.Location = new System.Drawing.Point(98, 20);
            this.cmbParca.Name = "cmbParca";
            this.cmbParca.Size = new System.Drawing.Size(121, 21);
            this.cmbParca.TabIndex = 1;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(12, 93);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(99, 86);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 20);
            this.nudAdet.TabIndex = 3;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnParcaEkle
            // 
            this.btnParcaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnParcaEkle.Location = new System.Drawing.Point(80, 144);
            this.btnParcaEkle.Name = "btnParcaEkle";
            this.btnParcaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnParcaEkle.TabIndex = 4;
            this.btnParcaEkle.Text = "Parça Ekle";
            this.btnParcaEkle.UseVisualStyleBackColor = false;
            this.btnParcaEkle.Click += new System.EventHandler(this.btnParcaEkle_Click);
            // 
            // dataGridServisParcalar
            // 
            this.dataGridServisParcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServisParcalar.Location = new System.Drawing.Point(280, 20);
            this.dataGridServisParcalar.MultiSelect = false;
            this.dataGridServisParcalar.Name = "dataGridServisParcalar";
            this.dataGridServisParcalar.ReadOnly = true;
            this.dataGridServisParcalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServisParcalar.Size = new System.Drawing.Size(341, 150);
            this.dataGridServisParcalar.TabIndex = 5;
            // 
            // lblArac
            // 
            this.lblArac.AutoSize = true;
            this.lblArac.Location = new System.Drawing.Point(22, 31);
            this.lblArac.Name = "lblArac";
            this.lblArac.Size = new System.Drawing.Size(51, 13);
            this.lblArac.TabIndex = 6;
            this.lblArac.Text = "Araç Seç";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(98, 28);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(430, 21);
            this.cmbAraclar.TabIndex = 7;
            // 
            // btnServisAc
            // 
            this.btnServisAc.Location = new System.Drawing.Point(544, 31);
            this.btnServisAc.Name = "btnServisAc";
            this.btnServisAc.Size = new System.Drawing.Size(75, 23);
            this.btnServisAc.TabIndex = 8;
            this.btnServisAc.Text = "Servis Aç";
            this.btnServisAc.UseVisualStyleBackColor = true;
            this.btnServisAc.Click += new System.EventHandler(this.btnServisAc_Click);
            // 
            // tabServis
            // 
            this.tabServis.Controls.Add(this.tabPage1);
            this.tabServis.Controls.Add(this.tabPage2);
            this.tabServis.Location = new System.Drawing.Point(25, 87);
            this.tabServis.Name = "tabServis";
            this.tabServis.SelectedIndex = 0;
            this.tabServis.Size = new System.Drawing.Size(646, 300);
            this.tabServis.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbParca);
            this.tabPage1.Controls.Add(this.lblParca);
            this.tabPage1.Controls.Add(this.lblAdet);
            this.tabPage1.Controls.Add(this.nudAdet);
            this.tabPage1.Controls.Add(this.dataGridServisParcalar);
            this.tabPage1.Controls.Add(this.btnParcaEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridServisIscilikler);
            this.tabPage2.Controls.Add(this.btnIscilikEkle);
            this.tabPage2.Controls.Add(this.cmbIscilik);
            this.tabPage2.Controls.Add(this.lblIscilik);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblIscilik
            // 
            this.lblIscilik.AutoSize = true;
            this.lblIscilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIscilik.Location = new System.Drawing.Point(46, 41);
            this.lblIscilik.Name = "lblIscilik";
            this.lblIscilik.Size = new System.Drawing.Size(106, 31);
            this.lblIscilik.TabIndex = 0;
            this.lblIscilik.Text = "İşçilik :";
            // 
            // cmbIscilik
            // 
            this.cmbIscilik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIscilik.FormattingEnabled = true;
            this.cmbIscilik.Location = new System.Drawing.Point(203, 43);
            this.cmbIscilik.Name = "cmbIscilik";
            this.cmbIscilik.Size = new System.Drawing.Size(163, 21);
            this.cmbIscilik.TabIndex = 1;
            // 
            // btnIscilikEkle
            // 
            this.btnIscilikEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIscilikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIscilikEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIscilikEkle.Location = new System.Drawing.Point(415, 26);
            this.btnIscilikEkle.Name = "btnIscilikEkle";
            this.btnIscilikEkle.Size = new System.Drawing.Size(127, 53);
            this.btnIscilikEkle.TabIndex = 2;
            this.btnIscilikEkle.Text = "İşçilik Ekle";
            this.btnIscilikEkle.UseVisualStyleBackColor = false;
            this.btnIscilikEkle.Click += new System.EventHandler(this.btnIscilikEkle_Click);
            // 
            // btnServisTamamla
            // 
            this.btnServisTamamla.Location = new System.Drawing.Point(259, 413);
            this.btnServisTamamla.Name = "btnServisTamamla";
            this.btnServisTamamla.Size = new System.Drawing.Size(154, 48);
            this.btnServisTamamla.TabIndex = 10;
            this.btnServisTamamla.Text = "SERVİSİ TAMAMLA";
            this.btnServisTamamla.UseVisualStyleBackColor = true;
            this.btnServisTamamla.Click += new System.EventHandler(this.btnServisTamamla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(658, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // dataGridServisIscilikler
            // 
            this.dataGridServisIscilikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServisIscilikler.Location = new System.Drawing.Point(40, 98);
            this.dataGridServisIscilikler.Name = "dataGridServisIscilikler";
            this.dataGridServisIscilikler.Size = new System.Drawing.Size(550, 150);
            this.dataGridServisIscilikler.TabIndex = 3;
            // 
            // FrmServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnServisTamamla);
            this.Controls.Add(this.tabServis);
            this.Controls.Add(this.btnServisAc);
            this.Controls.Add(this.cmbAraclar);
            this.Controls.Add(this.lblArac);
            this.Name = "FrmServis";
            this.Text = "FrmServis";
            this.Load += new System.EventHandler(this.FrmServis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServisParcalar)).EndInit();
            this.tabServis.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServisIscilikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParca;
        private System.Windows.Forms.ComboBox cmbParca;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.DataGridView dataGridServisParcalar;
        private System.Windows.Forms.Button btnParcaEkle;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.Button btnServisAc;
        private System.Windows.Forms.TabControl tabServis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnIscilikEkle;
        private System.Windows.Forms.ComboBox cmbIscilik;
        private System.Windows.Forms.Label lblIscilik;
        private System.Windows.Forms.Button btnServisTamamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridServisIscilikler;
    }
}