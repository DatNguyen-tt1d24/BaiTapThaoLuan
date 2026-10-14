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
    public partial class XepLoai : Form
    {
        public XepLoai()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHK1.Text.Trim(), out double hk1) &&
                double.TryParse(txtHK2.Text.Trim(), out double hk2))
            {
                if (hk1 < 0 || hk1 > 10 || hk2 < 0 || hk2 > 10)
                {
                    MessageBox.Show("Điểm các học kỳ phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double dtb = (hk1 + hk2 * 2.0) / 3.0;
                txtDTB.Text = dtb.ToString("0.00");
                if (dtb >= 5)
                {
                    txtXepLoai.Text = "Giỏi";
                }else if (dtb >= 7.0)
                {
                    txtXepLoai.Text = "Khá";
                }else if (dtb >= 5.0) 
                {
                    txtXepLoai.Text = "Trung bình";
                }else
                {
                    txtXepLoai.Text = "Yếu";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm học kỳ 1 và học kỳ 2 hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHK1.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHK1.Clear();
            txtHK2.Clear();
            txtDTB.Text = "0.00";
            txtXepLoai.Text = "—";
            txtHK1.Focus();
        }
    }
}
