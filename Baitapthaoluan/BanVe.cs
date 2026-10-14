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
    public partial class BanVe : Form
    {
        public BanVe()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }
            if (int.TryParse(txtSoLuong.Text.Trim(), out int sl) && sl > 0)
            {
                double donGia = radThuong.Checked ? 70000 : 120000;
                double thanhTien = sl * donGia;
                double giamGia = (sl >= 5) ? (thanhTien * 0.10) : 0;
                double tongTien = thanhTien - giamGia;
                txtThanhTien.Text = thanhTien.ToString("N0");
                txtGiamGia.Text = giamGia.ToString("N0");
                txtTongTien.Text = tongTien.ToString("N0");
            }
            else
            {
                MessageBox.Show("Số lượng vé phải là số nguyên lớn hơn 0!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                txtSoLuong.SelectAll();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtSoLuong.Clear();

            txtThanhTien.Text = "0";
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";

            radThuong.Checked = true;
            txtTenKhach.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát màn hình này không?", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
