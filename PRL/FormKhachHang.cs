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

namespace PRL
{
    public partial class FormKhachHang : Form
    {
        KhachHangServices _services = new KhachHangServices();
        KhachHangRep _context = new KhachHangRep();
        public FormKhachHang()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadKhachHangData();
            dgv_data.CellClick += dgv_data_CellClick;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            RemoveUnwantedColumns();
        }
        private void ConfigureDataGridView()
        {
            // Xóa các cột không mong muốn khi cấu hình DataGridView
            RemoveUnwantedColumns();
        }
        private void LoadKhachHangData()
        {
            List<KhachHang> khachHangList = _services.CNShow();
            showdata(khachHangList);
            dgv_data.DataSource = khachHangList;
            KhachHangMuaNhieuNhat();
            RemoveUnwantedColumns();
        }
        private void showdata(List<KhachHang> khachHangList)
        {
            cbTenKhachHang.DataSource = khachHangList;
            cbTenKhachHang.DisplayMember = "TenKhachHang";
            cbTenKhachHang.ValueMember = "KhachHangId";

            cbSoDienThoai.DataSource = khachHangList;
            cbSoDienThoai.DisplayMember = "SoDienThoai";
            cbSoDienThoai.ValueMember = "KhachHangId";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTenKhachHang.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;

            int maInt = int.Parse(ma);
            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ"); return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn chắc chắn thêm không", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNThem(maInt, ten, email, sdt, diachi);
                MessageBox.Show(kq);
                LoadKhachHangData();
                return;
            }
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KhachHangMuaNhieuNhat()
        {
            dgv_KhachHang.Rows.Clear();
            dgv_KhachHang.ColumnCount = 8;
            dgv_KhachHang.Columns[0].HeaderText = "STT";
            dgv_KhachHang.Columns[1].HeaderText = "ID Khách hàng";
            dgv_KhachHang.Columns[2].HeaderText = "Tên khách hàng";
            dgv_KhachHang.Columns[3].HeaderText = "SDT";
            dgv_KhachHang.Columns[4].HeaderText = "Địa chỉ";
            dgv_KhachHang.Columns[5].HeaderText = "Gmail";
            dgv_KhachHang.Columns[6].HeaderText = "Sản phẩm";
            dgv_KhachHang.Columns[7].HeaderText = "Tổng tiền";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTenKhachHang.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;

            int maInt = int.Parse(ma);
            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ"); return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không", "Đã sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNSua(maInt, ten, email, sdt, diachi);
                MessageBox.Show(kq);
                LoadKhachHangData();
                return;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtMa.Text = "";
                txtTenKhachHang.Text = "";
                txtEmail.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                LoadKhachHangData();
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void cboTenKhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void RemoveUnwantedColumns()
        {
            if (dgv_data.Columns["DanhGia"] != null) dgv_data.Columns.Remove("DanhGia");
            if (dgv_data.Columns["DonHangs"] != null) dgv_data.Columns.Remove("DonHangs");
            if (dgv_data.Columns["HoaDons"] != null) dgv_data.Columns.Remove("HoaDons");
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                    DataGridViewRow row = dgv_data.Rows[e.RowIndex];
                    txtMa.Text = row.Cells["KhachHangId"].Value.ToString();
                    txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
        }
    }
}
