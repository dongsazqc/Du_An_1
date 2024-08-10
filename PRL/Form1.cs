using BUS.Service;
using DAL.Models;
using DAL.Repsitory;

namespace PRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Load_data(List<SanPham> sanPhams)
        {
        }

        private void btn_Load_sanpham_Click_1(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham());
            TieuDe.Text = btn_SanPham.Text;
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            TieuDe.Text = btn_KhachHang.Text;

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
            TieuDe.Text = btn_BanHang.Text;

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            TieuDe.Text = btn_TrangChu.Text;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            icbtn_HienAn.IconChar = FontAwesome.Sharp.IconChar.List;
        }

        private void btn_hoAdon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Voucher());
            TieuDe.Text = btn_Voucher.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                // Nếu panel đang hiển thị, ẩn nó
                panel1.Visible = false;
               icbtn_HienAn.Text = "Hiện Panel";
            }
            else
            {
                panel1.Visible = true;
                icbtn_HienAn.Text = "Ẩn Panel"; 
            }
        }

    }
}
