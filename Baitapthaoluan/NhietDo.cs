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
    public partial class NhietDo : Form
    {
        public NhietDo()
        {
            InitializeComponent();
        }

        private void btnChuyendoi_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNhietdo.Text.Trim(), out double nhap))
            {
                if (radCtoF.Checked)
                {        
                    double f = (nhap * 1.8) + 32;
                    txtKetqua.Text = $"{f:0.##} °F";
                }
                else
                {                
                    double c = (nhap - 32) * 0.555;
                    txtKetqua.Text = $"{c:0.##} °C";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nhiệt độ hợp lệ!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhietdo.Focus();
                txtNhietdo.SelectAll();
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhietdo.Clear();
            txtKetqua.Text = "(Chưa có kết quả)";
            radCtoF.Checked = true;
            txtNhietdo.Focus();
        }
    }
    }

