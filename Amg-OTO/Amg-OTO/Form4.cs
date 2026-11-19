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
    public partial class FrmAraclar : Form
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            MusterileriGetir();
            MarkalariGetir();
        }
        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");
        int secilenAracId = -1;

        void MusterileriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, CONCAT(ad,' ',soyad) AS adsoyad FROM musteriler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMusteriler.DataSource = dt;
                cmbMusteriler.DisplayMember = "adsoyad";
                cmbMusteriler.ValueMember = "id";
            }
        }

        void MarkalariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, marka_adi FROM arac_markalari";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMarka.DataSource = dt;
                cmbMarka.DisplayMember = "marka_adi";
                cmbMarka.ValueMember = "id";
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedValue == null) return;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = "SELECT id, model_adi FROM arac_modelleri WHERE marka_id=@mid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mid", cmbMarka.SelectedValue);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbModel.DataSource = dt;
                cmbModel.DisplayMember = "model_adi";
                cmbModel.ValueMember = "id";
            }
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedValue == null) return;
            AraclariGetir();
        }

        void AraclariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"SELECT a.id, am.model_adi, a.yil, a.plaka, a.sase_no
                       FROM araclar a
                       JOIN arac_modelleri am ON a.model_id = am.id
                       WHERE a.musteri_id = @mid";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mid", cmbMusteriler.SelectedValue);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridAraclar.DataSource = dt;
            }
        }

        private void dataGridAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridAraclar.Rows[e.RowIndex];
                secilenAracId = Convert.ToInt32(row.Cells["id"].Value);

                txtYil.Text = row.Cells["yil"].Value.ToString();
                txtPlaka.Text = row.Cells["plaka"].Value.ToString();
                txtSase.Text = row.Cells["sase_no"].Value.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO araclar
        (musteri_id, model_id, yil, plaka, sase_no)
        VALUES (@musteri, @model, @yil, @plaka, @sase)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@musteri", cmbMusteriler.SelectedValue);
                cmd.Parameters.AddWithValue("@model", cmbModel.SelectedValue);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@sase", txtSase.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Araç eklendi.");
            AraclariGetir();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenAracId == -1)
            {
                MessageBox.Show("Araç seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"UPDATE araclar SET
        model_id=@model, yil=@yil, plaka=@plaka, sase_no=@sase
        WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@model", cmbModel.SelectedValue);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@sase", txtSase.Text);
                cmd.Parameters.AddWithValue("@id", secilenAracId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Araç güncellendi.");
            AraclariGetir();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenAracId == -1)
            {
                MessageBox.Show("Araç seçin.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"UPDATE araclar SET
        model_id=@model, yil=@yil, plaka=@plaka, sase_no=@sase
        WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@model", cmbModel.SelectedValue);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@sase", txtSase.Text);
                cmd.Parameters.AddWithValue("@id", secilenAracId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Araç güncellendi.");
            AraclariGetir();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            txtYil.Clear();
            txtPlaka.Clear();
            txtSase.Clear();
            secilenAracId = -1;
        }
    }
}
