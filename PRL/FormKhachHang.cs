using BUS.Service;
using DAL.Models;
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
    public partial class FormKhachHang : Form
    {
        KhachHangServices _services = new KhachHangServices();

        public FormKhachHang()
        {
            _services = new KhachHangServices();
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {


        }
        private void LoadDuLieuFromToDataTable()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtID.Text;
            string mota = txtTenKhachHang.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;

            int maInt = int.Parse(ma);

            DialogResult resul = MessageBox.Show("Ban co muon them khong?", "Them moi", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                string kq = _services.CNThem(maInt, mota, email, sdt, diachi);
                List<KhachHang> khachhangs = _services.CNShow();
                ShowData(khachhangs);
                MessageBox.Show(kq);
            }

        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<KhachHang> cuaHangs = _services.CNShow();
            ShowData(cuaHangs);
        }

        public void ShowData(List<KhachHang> kh)
        {
            dgv_KhachHang.Rows.Clear();
            dgv_KhachHang.ColumnCount = 6;
            int stt = 1;
            dgv_KhachHang.Columns[0].HeaderText = "STT";
            dgv_KhachHang.Columns[1].HeaderText = "ID";
            dgv_KhachHang.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv_KhachHang.Columns[3].HeaderText = "Email";
            dgv_KhachHang.Columns[4].HeaderText = "Số Điện Thoại";
            dgv_KhachHang.Columns[5].HeaderText = "Địa chỉ";
            foreach (var item in kh)
            {
                dgv_KhachHang.Rows.Add(stt++, item.KhachHangId, item.TenKhachHang, item.Email, item.SoDienThoai, item.DiaChi);
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var rowData = dgv_KhachHang.Rows[row];
            txtID.Text = rowData.Cells[1].Value.ToString();
            txtTenKhachHang.Text = rowData.Cells[2].Value.ToString();
            txtEmail.Text = rowData.Cells[3].Value.ToString();
            txtSDT.Text = rowData.Cells[4].Value.ToString();
            txtDiaChi.Text = rowData.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtID.Text;
            string tenkhachhang = txtTenKhachHang.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;

            int maInt = int.Parse(ma);

            DialogResult resul = MessageBox.Show("Ban co muon sua khong?", "Them moi", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                string kq = _services.CNSua(maInt, tenkhachhang, email, sdt, diachi);
                List<KhachHang> khachhangs = _services.CNShow();
                ShowData(khachhangs);
                MessageBox.Show(kq);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Ban co muon xoa khong", "Xoa", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes && txtID.Text.Trim() != "")
            {
                MessageBox.Show(_services.CNXoa(txtID.Text));
                List<KhachHang> khachHangs = _services.CNShow();
                ShowData(khachHangs);
                return;
            }
        }
    }
}
