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
    public partial class TamGiac : Form
    {
        public TamGiac()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text.Trim(), out double a) &&
                double.TryParse(txtB.Text.Trim(), out double b) &&
                double.TryParse(txtC.Text.Trim(), out double c))
            {
                if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
                {
                    double chuVi = a + b + c;
                    double p = chuVi / 2.0;
                    double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    txtChuVi.Text = chuVi.ToString("0.##");
                    txtDienTich.Text = dienTich.ToString("0.##");
                }
                else
                {
                    MessageBox.Show("Độ dài 3 cạnh phải lớn hơn 0 và thỏa mãn bất đẳng thức tam giác (tổng 2 cạnh lớn hơn cạnh còn lại)!",
                                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập độ dài 3 cạnh a, b, c là số hợp lệ!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtA.Focus();
        }
    }
}
