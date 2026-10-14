using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitapthaoluan
{
    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoKM.Text.Trim(), out double km) && km > 0)
            {
                double tongTien = 0;

                if (km <= 1)
                {
                    tongTien = km * 15000;
                }else if (km <= 30)
                {
                    tongTien = 15000 + (km - 1) * 10000;
                }
                else
                {
                    tongTien = 15000 + (29 * 10000) + (km - 30) * 8000;
                }
                txtTien.Text = tongTien.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số km là số dương hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoKM.Focus();
                txtSoKM.SelectAll();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtSoKM.Clear();
            txtTien.Clear();
            txtSoKM.Focus();
        }
    }
}
