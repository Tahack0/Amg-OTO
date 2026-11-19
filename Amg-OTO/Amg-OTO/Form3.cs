using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Amg_OTO
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");
        int secilenMusteriId = -1;

        void MusterileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, ad, soyad, telefon, eposta FROM musteriler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridMusteriler.DataSource = dt;
            }
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            secilenMusteriId = -1;
        }


        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void dataGridMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridMusteriler.Rows[e.RowIndex];

                secilenMusteriId = Convert.ToInt32(row.Cells["id"].Value);
                txtAd.Text = row.Cells["ad"].Value.ToString();
                txtSoyad.Text = row.Cells["soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["telefon"].Value.ToString();
                txtEposta.Text = row.Cells["eposta"].Value.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO musteriler (ad, soyad, telefon, eposta)
                       VALUES (@ad, @soyad, @telefon, @eposta)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri eklendi.");
            MusterileriGetir();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bu müşteriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo
            );

            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string sql = "DELETE FROM musteriler WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", secilenMusteriId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri silindi.");
                MusterileriGetir();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"UPDATE musteriler 
                       SET ad=@ad, soyad=@soyad, telefon=@telefon, eposta=@eposta
                       WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@eposta", txtEposta.Text);
                cmd.Parameters.AddWithValue("@id", secilenMusteriId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri güncellendi.");
            MusterileriGetir();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
