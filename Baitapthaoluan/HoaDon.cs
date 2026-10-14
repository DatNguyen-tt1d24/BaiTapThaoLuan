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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text.Trim(), out int sl) &&
                double.TryParse(txtDonGia.Text.Trim(), out double donGia))
            {
                if (sl <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Số lượng và đơn giá phải lớn hơn 0!", "Thống báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double thanhTien = sl * donGia;
                double giamGia = radThanhVien.Checked ? (thanhTien * 0.05) : 0;
                double vat = 0.08 * (thanhTien - giamGia);
                double tongCong = thanhTien - giamGia + vat;
                txtThanhTien.Text = thanhTien.ToString("N0");
                txtGiamGia.Text = giamGia.ToString("N0");
                txtVAT.Text = vat.ToString("N0");
                txtTongCong.Text = tongCong.ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng và đơn giá là số hợp lệ!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaHang.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtThanhTien.Text = "0";
            txtGiamGia.Text = "0";
            txtVAT.Text = "0";
            txtTongCong.Text = "0";

            radThanhVien.Checked = true;
            txtMaHang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng màn hình này không?", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
