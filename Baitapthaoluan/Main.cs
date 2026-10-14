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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void phầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bài1NhiệtĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhietDo());
        }

        private void bài2XếpLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XepLoai());
        }

        private void bài3BMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BMI());
        }

        private void bài4TamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TamGiac());
        }

        private void bài5TaxiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Taxi());
        }

        private void bài1HóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon());
        }

        private void bài2BánVéXemPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanVe());
        }

        private void bài1MảngMộtChiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Mang1());
        }

        private void bài2ThốngKêMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeMang());
        }
    }
}
