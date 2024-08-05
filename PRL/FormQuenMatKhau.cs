using BUS.Service;
using DAL.Repsitory;
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
    public partial class FormQuenMatKhau : Form
    {
        DangNhapServices services = new DangNhapServices();
        public FormQuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email đăng kí");
            }
            else
            {
                var nguoiDungs = services.GetNguoiDungByEmail(email);
                if (nguoiDungs.Count > 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + nguoiDungs[0].MatKhauMaHoa;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }
            }
        }
    }
}
