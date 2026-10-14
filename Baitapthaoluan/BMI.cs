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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtChieuCao.Text.Trim(), out double cm) &&
                double.TryParse(txtCanNang.Text.Trim(), out double kg))
            {
                if (cm <= 0 || kg <= 0)
                {
                    MessageBox.Show("Chiều cao và cân nặng phải lớn hơn 0!", "Lỗi nhập liệu",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double m = cm / 100.0;
                double bmi = kg / (m * m);
                txtBMI.Text = bmi.ToString("0.00");
                if (bmi < 18.5)
                {
                    txtPhanLoai.Text = "Gầy";
                }else if(bmi <= 24.9)
                {
                    txtPhanLoai.Text = "Bình thường";
                }
                else if (bmi <= 29.9)
                {
                    txtPhanLoai.Text = "Thừa cân";
                }
                else
                {
                    txtPhanLoai.Text = "Béo phì";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chiều cao (cm) và cân nặng (kg) hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChieuCao.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChieuCao.Clear();
            txtCanNang.Clear();
            txtBMI.Text = "0.00";
            txtPhanLoai.Text = "—";
            txtChieuCao.Focus();
        }
    }
}
