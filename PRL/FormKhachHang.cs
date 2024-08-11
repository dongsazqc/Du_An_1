﻿using BUS.Service;
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
using DAL.Models;
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
            SetupDataGridView();
            LoadData();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
        }
        private void SetupDataGridView()
        {
            // Cấu hình cột trong dgv_data
            dgv_data.ColumnCount = 6;
            dgv_data.Columns[0].HeaderText = "STT";
            dgv_data.Columns[1].HeaderText = "ID khách hàng";
            dgv_data.Columns[2].HeaderText = "Tên khách hàng";
            dgv_data.Columns[3].HeaderText = "Email";
            dgv_data.Columns[4].HeaderText = "SDT";
            dgv_data.Columns[5].HeaderText = "Địa chỉ";

            // Thêm cột giới tính
          
        }
        private void LoadData()
        {
            dgv_data.Rows.Clear(); // Xóa dữ liệu cũ
            List<KhachHang> khachhangs = _services.CNShow();
            showdata(khachhangs);
            KhachHangMuaNhieuNhat();
        }
        private void showdata(List<KhachHang> kh)
        {
            dgv_data.Rows.Clear();
            int stt = 1;
            foreach (var item in kh)
            {
                dgv_data.Rows.Add(stt++, item.KhachHangId, item.TenKhachHang, item.Email, item.SoDienThoai, item.DiaChi);

            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTenKhachHang.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            bool gioitinh = rdoNam.Checked; 

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
                List<KhachHang> khachhangs = _services.CNShow();
                showdata(khachhangs);
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
                List<KhachHang> khachhangs = _services.CNShow();
                showdata(khachhangs);
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
               
            }
        }
        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rowdata = dgv_data.Rows[e.RowIndex];
                txtMa.Text = rowdata.Cells[1].Value.ToString();
                txtTenKhachHang.Text = rowdata.Cells[2].Value.ToString();
                txtEmail.Text = rowdata.Cells[3].Value.ToString();
                txtSDT.Text = rowdata.Cells[4].Value.ToString();
                txtDiaChi.Text = rowdata.Cells[5].Value.ToString();
                
               
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang> kh = _services.CNTim(txtTimKiem.Text);
            showdata(kh);
        }
    }
}
