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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            FaturalariGetir();
            OdemeTurleriniDoldur();
        }

        string connStr = Environment.GetEnvironmentVariable("AMG_OTO_CONNECTION_STRING");
        int secilenFaturaId = -1;
    

    void FaturalariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string sql = @"
                        SELECT 
                            id AS fatura_id,
                            servis_id,
                            toplam_tutar AS genel_toplam,
                            tarih
                        FROM faturalar
                        ORDER BY tarih DESC";


                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridFaturalar.DataSource = dt;
            }
        }

        private void dataGridFaturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridFaturalar.Rows[e.RowIndex];

                secilenFaturaId = Convert.ToInt32(row.Cells["fatura_id"].Value);

                txtFaturaId.Text = row.Cells["fatura_id"].Value.ToString();
                txtServisId.Text = row.Cells["servis_id"].Value.ToString();
                txtToplam.Text = row.Cells["genel_toplam"].Value.ToString();
                txtTarih.Text = Convert.ToDateTime(row.Cells["tarih"].Value)
                                    .ToString("dd.MM.yyyy HH:mm");
            }
        }
        void OdemeTurleriniDoldur()
        {
            cmbOdemeTur.Items.Clear();
            cmbOdemeTur.Items.Add("Nakit");
            cmbOdemeTur.Items.Add("Kart");
            cmbOdemeTur.Items.Add("Havale");
            cmbOdemeTur.Items.Add("Veresiye");
            cmbOdemeTur.SelectedIndex = 0;
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (secilenFaturaId == -1)
            {
                MessageBox.Show("Lütfen bir fatura seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOdenenTutar.Text))
            {
                MessageBox.Show("Ödeme tutarı giriniz.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO odemeler
                       (fatura_id, odeme_turu, tutar, tarih)
                       VALUES (@fatura, @tur, @tutar, NOW())";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fatura", secilenFaturaId);
                cmd.Parameters.AddWithValue("@tur", cmbOdemeTur.Text);
                cmd.Parameters.AddWithValue("@tutar", txtOdenenTutar.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Ödeme kaydedildi.");
            txtOdenenTutar.Clear();
        }
    }
}
