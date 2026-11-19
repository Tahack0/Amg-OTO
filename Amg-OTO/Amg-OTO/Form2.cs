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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }


        private void btnMusteriler_Click_1(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
        }

        private void btnAraclar_Click_1(object sender, EventArgs e)
        {
            FrmAraclar frm = new FrmAraclar();
            frm.Show();
        }

        private void btnServis_Click_1(object sender, EventArgs e)
        {
            FrmServis frm = new FrmServis();
            frm.Show();
        }

        private void btnStok_Click_1(object sender, EventArgs e)
        {

            FrmStok frm = new FrmStok();
            frm.Show();
        }

        private void btnFaturalar_Click_1(object sender, EventArgs e)
        {
            FrmFaturalar frm = new FrmFaturalar();
            frm.Show();
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               "Çıkmak istediğinize emin misiniz?",
               "Çıkış",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
