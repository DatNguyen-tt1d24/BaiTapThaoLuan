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
    public partial class ThongKeMang : Form
    {
        private int[] arr;
        public ThongKeMang()
        {
            InitializeComponent();
        }
        private bool KiemTraVaTaoMang()
        {
            if (arr != null && arr.Length > 0) return true;

            if (int.TryParse(txtN.Text.Trim(), out int n) && n > 0)
            {
                arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(0, 101);
                }
                txtMang.Text = string.Join(", ", arr);
                return true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số phần tử N là số nguyên dương!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return false;
            }
        }

        private void ThongKeMang_Load(object sender, EventArgs e)
        {


        }

        private void btnDemChan_Click(object sender, EventArgs e)
        {
            if (!KiemTraVaTaoMang()) return;
            int countChan = arr.Count(x => x % 2 == 0);
            txtSoChan.Text = countChan.ToString();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            if (!KiemTraVaTaoMang()) return;
            int countLe = arr.Count(x => x % 2 != 0);
            txtSoLe.Text = countLe.ToString();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!KiemTraVaTaoMang()) return;
            long tong = arr.Sum(x => (long)x);
            txtTong.Text = tong.ToString("N0");
        }

        private void btnTimXuatHien_Click(object sender, EventArgs e)
        {
            if (!KiemTraVaTaoMang()) return;
            var group = arr.GroupBy(x => x)
                           .OrderByDescending(g => g.Count())
                           .First();

            txtXuatHien.Text = $"{group.Key} ({group.Count()} lần)";
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtMang.Clear();
            txtSoChan.Text = "0";
            txtSoLe.Text = "0";
            txtTong.Text = "0";
            txtXuatHien.Text = "(Chưa tính)";
            arr = null; 
            txtN.Focus();
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
