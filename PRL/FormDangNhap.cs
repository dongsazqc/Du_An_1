using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
