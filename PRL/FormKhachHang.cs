using BUS.Service;
using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace PRL
{
    public partial class FormKhachHang : Form
    {
        KhachHangServices _services = new KhachHangServices();
        KhachHangRep _context = new KhachHangRep();
        public FormKhachHang()
        {
            InitializeComponent();
            InitializeDataGridViews();
            LoadKhachHangData();
            List<KhachHang> khachHangCapdo = _services.CNShow();
            LOADKHCP(khachHangCapdo);




        }

        private void LOADKHCP(List<KhachHang> khachHangCapdo)
        {

            dgv_KhachHang.Rows.Clear();
            int stt = 1;
            foreach (var item in khachHangCapdo)
            {
                dgv_KhachHang.Rows.Add(stt++,item.KhachHangId, item.TenKhachHang, item.Email, item.SoDienThoai, item.DiaChi, item.DiemTichLuy, item.CapDoThanhVien);
            }
        }

        private void LoadKhachHangData()
        {
            List<KhachHang> khachhangs = _services.CNShow();
            LoadKhachHangToDataGridView(khachhangs);
        }

        private void LoadKhachHangToDataGridView(List<KhachHang> kh)
        {
            dgv_data.Rows.Clear();
            int stt = 1;
            foreach (KhachHang k in kh)
            {
                dgv_data.Rows.Add(stt++, k.KhachHangId, k.TenKhachHang, k.SoDienThoai, k.Email, k.DiaChi);
            }
        }
        private void LoadCapBac()
        {
            dgv_KhachHang.Rows.Clear();
            List<KhachHang> khachhangs = _services.CNShow();
        }


        private void InitializeDataGridViews()
        {
            // Initialize dgv_data
            dgv_data.ColumnCount = 6;
            dgv_data.Columns[0].HeaderText = "STT";
            dgv_data.Columns[1].HeaderText = "ID khách hàng";
            dgv_data.Columns[2].HeaderText = "Tên khách hàng";
            dgv_data.Columns[3].HeaderText = "SDT";
            dgv_data.Columns[4].HeaderText = "Email";
            dgv_data.Columns[5].HeaderText = "Địa chỉ";

            // Initialize dgv_KhachHang
            dgv_KhachHang.ColumnCount = 8;
            dgv_KhachHang.Columns[0].HeaderText = "STT";
            dgv_KhachHang.Columns[1].HeaderText = "ID Khách hàng";
            dgv_KhachHang.Columns[2].HeaderText = "Tên khách hàng";
            dgv_KhachHang.Columns[3].HeaderText = "";
            dgv_KhachHang.Columns[4].HeaderText = "SDT";
            dgv_KhachHang.Columns[5].HeaderText = "Địa chỉ";
            dgv_KhachHang.Columns[6].HeaderText = "Điểm tích lũy";
            dgv_KhachHang.Columns[7].HeaderText = "Cấp bậc";
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTenKhachHang.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNThemOrUpdateKhachHang(ten, email, sdt, diachi, 0, "Đồng");
                MessageBox.Show(kq);
                LoadKhachHangData();
            }
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CapBacKhachHang()
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();
            string ten = txtTenKhachHang.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diachi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            if (!int.TryParse(ma, out int maInt))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa không?", "Sửa thông tin", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNSua(maInt, ten, sdt, email, diachi);
                MessageBox.Show(kq);
                LoadKhachHangData();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả thông tin không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtMa.Clear();
                txtTenKhachHang.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
            }
        }
        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowdata = dgv_data.Rows[e.RowIndex];
                txtMa.Text = rowdata.Cells[1].Value?.ToString();
                txtTenKhachHang.Text = rowdata.Cells[2].Value?.ToString();
                txtSDT.Text = rowdata.Cells[3].Value?.ToString();
                txtEmail.Text = rowdata.Cells[4].Value?.ToString();
                txtDiaChi.Text = rowdata.Cells[5].Value?.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang> kh = _services.CNTim(txtTimKiem.Text.Trim());
            LoadKhachHangToDataGridView(kh);
        }
    }
}
