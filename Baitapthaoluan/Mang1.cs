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
    public partial class Mang1 : Form
    {
        private int[] arr;
        public Mang1()
        {
            InitializeComponent();
        }
        private void TaoMangNgauNhien()
        {
            if (int.TryParse(txtN.Text.Trim(), out int n) && n > 0)
            {
                arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rnd.Next(-50, 51);
                }
                txtMangGoc.Text = string.Join("  ", arr);
                txtKetQua.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập N là số nguyên dương!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                txtN.SelectAll();
            }
        }

        private void Mang1_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            TaoMangNgauNhien();
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Vui lòng nhấn 'Tạo mảng' trước khi thực hiện!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radMax.Checked)
            {
                int max = arr.Max();
                txtKetQua.Text = $"Giá trị LỚN NHẤT (Max) = {max}";
            }
            else if (radMin.Checked)
            {
                int min = arr.Min();
                txtKetQua.Text = $"Giá trị NHỎ NHẤT (Min) = {min}";
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                MessageBox.Show("Vui lòng nhấn 'Tạo mảng' trước khi thực hiện!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int[] temp = (int[])arr.Clone();

            if (radTang.Checked)
            {
                Array.Sort(temp);
                txtKetQua.Text = "Mảng sau khi sắp xếp TĂNG DẦN:\r\n" + string.Join("  ", temp);
            }
            else if (radGiam.Checked)
            {
                Array.Sort(temp);
                Array.Reverse(temp);
                txtKetQua.Text = "Mảng sau khi sắp xếp GIẢM DẦN:\r\n" + string.Join("  ", temp);
            }
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
