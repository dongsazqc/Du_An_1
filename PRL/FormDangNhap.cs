using BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.Repsitory.DangNhapRep;

namespace PRL
{
    public partial class FormDangNhap : Form
    {
        DangNhapServices services = new DangNhapServices();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Đăng nhập thành công", " Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //;Form1 form1 = new Form1();
            //form1.ShowDialog()
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;

            if (services.ValidateUser(username, password))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
        }

        
    }
}
