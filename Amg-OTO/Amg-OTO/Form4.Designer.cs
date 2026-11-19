namespace Amg_OTO
{
    partial class FrmAraclar
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
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.dataGridAraclar = new System.Windows.Forms.DataGridView();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSase = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtSase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(22, 25);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(95, 25);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri :";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(123, 31);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteriler.TabIndex = 1;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
            // 
            // dataGridAraclar
            // 
            this.dataGridAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAraclar.Location = new System.Drawing.Point(12, 84);
            this.dataGridAraclar.MultiSelect = false;
            this.dataGridAraclar.Name = "dataGridAraclar";
            this.dataGridAraclar.ReadOnly = true;
            this.dataGridAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAraclar.Size = new System.Drawing.Size(409, 150);
            this.dataGridAraclar.TabIndex = 2;
            this.dataGridAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAraclar_CellClick);
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(123, 273);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 4;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(22, 267);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(78, 25);
            this.lblMarka.TabIndex = 3;
            this.lblMarka.Text = "Marka:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(123, 311);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(22, 305);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model:";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(22, 344);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(43, 25);
            this.lblYil.TabIndex = 7;
            this.lblYil.Text = "Yıl:";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(21, 382);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(72, 25);
            this.lblPlaka.TabIndex = 9;
            this.lblPlaka.Text = "Plaka:";
            // 
            // lblSase
            // 
            this.lblSase.AutoSize = true;
            this.lblSase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSase.Location = new System.Drawing.Point(22, 417);
            this.lblSase.Name = "lblSase";
            this.lblSase.Size = new System.Drawing.Size(100, 25);
            this.lblSase.TabIndex = 11;
            this.lblSase.Text = "Şase No:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkle.Location = new System.Drawing.Point(321, 273);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Araç Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(321, 348);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.Location = new System.Drawing.Point(321, 311);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(321, 387);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(123, 348);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 17;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(123, 387);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 18;
            // 
            // txtSase
            // 
            this.txtSase.Location = new System.Drawing.Point(123, 422);
            this.txtSase.Name = "txtSase";
            this.txtSase.Size = new System.Drawing.Size(100, 20);
            this.txtSase.TabIndex = 19;
            // 
            // FrmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 470);
            this.Controls.Add(this.txtSase);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSase);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.dataGridAraclar);
            this.Controls.Add(this.cmbMusteriler);
            this.Controls.Add(this.lblMusteri);
            this.Name = "FrmAraclar";
            this.Text = "FrmAraclar";
            this.Load += new System.EventHandler(this.FrmAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.DataGridView dataGridAraclar;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblSase;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtSase;
    }
}