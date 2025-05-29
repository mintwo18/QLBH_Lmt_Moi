using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Bán_Hàng
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang khach = new frmKhachHang();
            khach.MdiParent = this;
            khach.Show();
        }

        private void thêmMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanvien = new frmNhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void thêmMớiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNhaCungCap NCC = new frmNhaCungCap();
            NCC.MdiParent = this;
            NCC.Show();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemNVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void CapNhatNVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
