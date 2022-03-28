using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int baris = 0;
            dgvPakaian.Rows.Add();
            baris = dgvPakaian.Rows.Count - 2;

            String jk;
            if (rdbS.Checked == true)
            {
                jk = "S";
            }
            else
            {
                jk = "M";
            }
            if (rdbL.Checked == true)
            {
                jk = "L";
            }
            else
            {
                jk = "XL";
            }

            dgvPakaian[0, baris].Value = dgvPakaian.Rows.Count - 1;
            dgvPakaian[1, baris].Value = cmbJenis.SelectedItem.ToString();
            dgvPakaian[2, baris].Value = txtMerek.Text;
            dgvPakaian[3, baris].Value = jk;
            dgvPakaian[4, baris].Value = dtpBarang.Text;
            dgvPakaian[5, baris].Value = txtStok.Text;
            
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(this.dgvPakaian.SelectedRows.Count > 0)
            {
                dgvPakaian.Rows.RemoveAt(this.dgvPakaian.SelectedRows[0].Index);
            };
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
