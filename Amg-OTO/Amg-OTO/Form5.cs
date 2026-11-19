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
    public partial class FrmServis : Form
    {
        public FrmServis()
        {
            InitializeComponent();
        }

        private void FrmServis_Load(object sender, EventArgs e)
        {
            AraclariGetir();
            ParcalariGetir();
            IscilikleriGetir();

            tabServis.Enabled = false;
            btnServisTamamla.Enabled = false;
        }
        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");
        int aktifServisId = -1;

        void AraclariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"
        SELECT a.id,
        CONCAT(m.ad,' ',m.soyad,' - ',am.model_adi,' - ',a.plaka) AS arac
        FROM araclar a
        JOIN musteriler m ON a.musteri_id = m.id
        JOIN arac_modelleri am ON a.model_id = am.id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAraclar.DataSource = dt;
                cmbAraclar.DisplayMember = "arac";
                cmbAraclar.ValueMember = "id";
            }
        }

        private void btnServisAc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "INSERT INTO servis_kayitlari (arac_id, durum) VALUES (@arac, 'acik')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@arac", cmbAraclar.SelectedValue);
                cmd.ExecuteNonQuery();

                aktifServisId = (int)cmd.LastInsertedId;
            }

            tabServis.Enabled = true;
            btnServisTamamla.Enabled = true;

            ServisParcalariniGetir();
            ServisIscilikleriniGetir();

            MessageBox.Show("Servis açıldı. Servis ID: " + aktifServisId);
        }

        void ParcalariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, parca_adi FROM parcalar";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbParca.DataSource = dt;
                cmbParca.DisplayMember = "parca_adi";
                cmbParca.ValueMember = "id";
            }
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            if (aktifServisId == -1)
            {
                MessageBox.Show("Önce servis aç.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string fiyatSql = "SELECT satis_fiyati FROM parcalar WHERE id=@id";
                MySqlCommand fiyatCmd = new MySqlCommand(fiyatSql, conn);
                fiyatCmd.Parameters.AddWithValue("@id", cmbParca.SelectedValue);
                decimal fiyat = Convert.ToDecimal(fiyatCmd.ExecuteScalar());

                string sql = @"
        INSERT INTO servis_parcalari (servis_id, parca_id, adet, birim_fiyat)
        VALUES (@servis, @parca, @adet, @fiyat)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@servis", aktifServisId);
                cmd.Parameters.AddWithValue("@parca", cmbParca.SelectedValue);
                cmd.Parameters.AddWithValue("@adet", nudAdet.Value);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Parça servise eklendi.");
            ServisParcalariniGetir();
        }

        void IscilikleriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, iscilik_adi FROM iscilikler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbIscilik.DataSource = dt;
                cmbIscilik.DisplayMember = "iscilik_adi";
                cmbIscilik.ValueMember = "id";
            }
        }

        private void btnIscilikEkle_Click(object sender, EventArgs e)
        {
            if (aktifServisId == -1)
            {
                MessageBox.Show("Önce servis aç.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string fiyatSql = "SELECT fiyat FROM iscilikler WHERE id=@id";
                MySqlCommand fiyatCmd = new MySqlCommand(fiyatSql, conn);
                fiyatCmd.Parameters.AddWithValue("@id", cmbIscilik.SelectedValue);
                decimal fiyat = Convert.ToDecimal(fiyatCmd.ExecuteScalar());

                string sql = @"
        INSERT INTO servis_iscilikleri (servis_id, iscilik_id, fiyat)
        VALUES (@servis, @iscilik, @fiyat)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@servis", aktifServisId);
                cmd.Parameters.AddWithValue("@iscilik", cmbIscilik.SelectedValue);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İşçilik servise eklendi.");
            ServisIscilikleriniGetir();
        }

        private void btnServisTamamla_Click(object sender, EventArgs e)
        {
            if (aktifServisId == -1)
            {
                MessageBox.Show("Aktif servis yok.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "UPDATE servis_kayitlari SET durum='tamamlandi' WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", aktifServisId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Servis tamamlandı. Fatura otomatik oluşturuldu.");

            aktifServisId = -1;
            tabServis.Enabled = false;
            btnServisTamamla.Enabled = false;
        }
    
    void ServisParcalariniGetir()
        {
            if (aktifServisId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"
        SELECT 
            sp.id,
            p.parca_adi,
            sp.adet,
            sp.birim_fiyat,
            (sp.adet * sp.birim_fiyat) AS toplam
        FROM servis_parcalari sp
        JOIN parcalar p ON sp.parca_id = p.id
        WHERE sp.servis_id = @sid";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sid", aktifServisId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridServisParcalar.DataSource = dt;
            }
        }

        void ServisIscilikleriniGetir()
        {
            if (aktifServisId == -1) return;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"
        SELECT 
            si.id,
            i.iscilik_adi,
            si.fiyat
        FROM servis_iscilikleri si
        JOIN iscilikler i ON si.iscilik_id = i.id
        WHERE si.servis_id = @sid";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sid", aktifServisId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridServisIscilikler.DataSource = dt;
            }
        }

    }
}