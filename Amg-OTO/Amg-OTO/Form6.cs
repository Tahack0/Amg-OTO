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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            ParcalariGetir();
        }
        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");
        int secilenParcaId = -1;

        void ParcalariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"SELECT 
                                id, 
                                parca_adi, 
                                parca_kodu, 
                                kategori_id, 
                                alis_fiyati, 
                                satis_fiyati,
                                stok_adedi
                               FROM parcalar";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridParcalar.DataSource = dt;
            }
        }



        private void dataGridParcalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridParcalar.Rows[e.RowIndex];

            secilenParcaId = Convert.ToInt32(row.Cells["id"].Value);
            txtParcaAdi.Text = row.Cells["parca_adi"].Value.ToString();
            txtParcaKodu.Text = row.Cells["parca_kodu"].Value.ToString();
            txtKategori.Text = row.Cells["kategori_id"].Value.ToString();
            txtAlisFiyat.Text = row.Cells["alis_fiyati"].Value.ToString();
            txtSatisFiyat.Text = row.Cells["satis_fiyati"].Value.ToString();
            nudStok.Value = Convert.ToDecimal(row.Cells["stok_adedi"].Value);
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO parcalar
        (parca_adi, parca_kodu, kategori_id, alis_fiyati, satis_fiyati, stok_adedi, )
        VALUES (@adi, @kodu, @kategori, @alis, @satis, @stok_adedi)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", txtParcaAdi.Text);
                cmd.Parameters.AddWithValue("@kodu", txtParcaKodu.Text);
                cmd.Parameters.AddWithValue("@kategori_id", txtKategori.Text);
                cmd.Parameters.AddWithValue("@alis", txtAlisFiyat.Text);
                cmd.Parameters.AddWithValue("@satis", txtSatisFiyat.Text);
                
                cmd.Parameters.AddWithValue("@stok_adedi", nudStok.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Parça eklendi.");
            ParcalariGetir();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenParcaId == -1)
            {
                MessageBox.Show("Lütfen bir parça seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"UPDATE parcalar SET
        parca_adi=@adi,
        parca_kodu=@kodu,
        kategori_id=@kategori_id,
        alis_fiyati=@alis,
        satis_fiyati=@satis,
        stok_adedi=@stok_adedi
        
        WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", txtParcaAdi.Text);
                cmd.Parameters.AddWithValue("@kodu", txtParcaKodu.Text);
                cmd.Parameters.AddWithValue("@kategori_id", txtKategori.Text);
                cmd.Parameters.AddWithValue("@alis", txtAlisFiyat.Text);
                cmd.Parameters.AddWithValue("@satis", txtSatisFiyat.Text);
                cmd.Parameters.AddWithValue("@stok_adedi", nudStok.Value);
                
                cmd.Parameters.AddWithValue("@id", secilenParcaId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Parça güncellendi.");
            ParcalariGetir();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenParcaId == -1)
            {
                MessageBox.Show("Lütfen bir parça seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "DELETE FROM parcalar WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", secilenParcaId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Parça silindi.");
            ParcalariGetir();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            txtParcaAdi.Clear();
            txtParcaKodu.Clear();
            txtKategori.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
            nudStok.Value = 0;
            secilenParcaId = -1;
        }
    }
}
