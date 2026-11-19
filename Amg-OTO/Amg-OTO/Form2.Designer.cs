namespace Amg_OTO
{
    partial class FrmDashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnServis = new System.Windows.Forms.Button();
            this.btnAraclar = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnFaturalar);
            this.panelMenu.Controls.Add(this.btnStok);
            this.panelMenu.Controls.Add(this.btnServis);
            this.panelMenu.Controls.Add(this.btnAraclar);
            this.panelMenu.Controls.Add(this.btnMusteriler);
            this.panelMenu.Controls.Add(this.lblHeader);
            this.panelMenu.Location = new System.Drawing.Point(3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(498, 602);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(319, 512);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(152, 79);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.Location = new System.Drawing.Point(25, 407);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(152, 79);
            this.btnFaturalar.TabIndex = 5;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.UseVisualStyleBackColor = true;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click_1);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.Location = new System.Drawing.Point(183, 324);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(152, 79);
            this.btnStok.TabIndex = 4;
            this.btnStok.Text = "Parça & Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click_1);
            // 
            // btnServis
            // 
            this.btnServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnServis.Location = new System.Drawing.Point(25, 239);
            this.btnServis.Name = "btnServis";
            this.btnServis.Size = new System.Drawing.Size(152, 79);
            this.btnServis.TabIndex = 3;
            this.btnServis.Text = "Servis İşlemleri";
            this.btnServis.UseVisualStyleBackColor = true;
            this.btnServis.Click += new System.EventHandler(this.btnServis_Click_1);
            // 
            // btnAraclar
            // 
            this.btnAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraclar.Location = new System.Drawing.Point(183, 158);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(152, 79);
            this.btnAraclar.TabIndex = 2;
            this.btnAraclar.Text = "Araçlar";
            this.btnAraclar.UseVisualStyleBackColor = true;
            this.btnAraclar.Click += new System.EventHandler(this.btnAraclar_Click_1);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.Location = new System.Drawing.Point(25, 79);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(152, 79);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click_1);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.Location = new System.Drawing.Point(92, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "BMW Servis Otomasyonu";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContent.Location = new System.Drawing.Point(500, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(535, 602);
            this.panelContent.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(500, 605);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnFaturalar;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnServis;
        private System.Windows.Forms.Button btnAraclar;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Panel panelContent;
    }
}