using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Amg_OTO
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUsername.Text.Trim();
            string sifre = txtPassword.Text.Trim();

            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT COUNT(*) 
                           FROM adminler 
                           WHERE kullanici_adi = @kullanici 
                           AND sifre = @sifre";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    int sonuc = Convert.ToInt32(cmd.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        // GİRİŞ BAŞARILI
                        FrmDashboard frm = new FrmDashboard();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
        }
    }
}
