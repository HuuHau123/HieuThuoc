using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hieu_Thuoc
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap pn = new PhieuNhap();
        private void frmTKnhapthuoc_Load(object sender, EventArgs e)
        {
            DataTable tb = pn.getPhieuNhap();
            gridViewHoaDonNhap.DataSource = tb;
        }
    }
}
