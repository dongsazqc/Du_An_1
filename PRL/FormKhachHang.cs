﻿using BUS.Service;
using DAL.Models;
using DAL.Repsitory;
using Microsoft.Data.SqlClient;
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
        KhachHangRep _khachHangRep = new KhachHangRep();

        public FormKhachHang()
        {
            InitializeComponent();
            List<KhachHang> khachHangs = _services.CNShow();
            showData(khachHangs);
            tiemnangkh();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

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
                List<KhachHang> khachHangs = _services.CNShow();
                showData(khachHangs);
                return;
            }
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        }
        private void tiemnangkh()
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
        public void showData(List<KhachHang> kh)
        {
            dgv_data.Rows.Clear();  //Xo?a hê?t d?? liê?u cu? trên gridview
            dgv_data.ColumnCount = 6;   //ga?n co? 5 cô?t
            int stt = 1;
            dgv_data.Columns[0].HeaderText = "STT";
            dgv_data.Columns[1].HeaderText = "Mã khách hàng";
            dgv_data.Columns[2].HeaderText = "Tên khách hàng";
            dgv_data.Columns[3].HeaderText = "Email";
            dgv_data.Columns[4].HeaderText = "SDT";
            dgv_data.Columns[5].HeaderText = "Địa chỉ";
            foreach (var item in kh)
            {
                dgv_data.Rows.Add(stt++, item.KhachHangId, item.TenKhachHang, item.Email, item.SoDienThoai, item.DiaChi);

            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lâ?y ra t?? do?ng d???c cho?n ?ê? fill lên forn
            int row = e.RowIndex;
            var rowData = dgv_data.Rows[row]; //lâ?y data t?? row ?o? ra
            txtMa.Text = rowData.Cells[1].Value.ToString();
            txtTenKhachHang.Text = rowData.Cells[2].Value.ToString();
            txtEmail.Text = rowData.Cells[3].Value.ToString();
            txtSDT.Text = rowData.Cells[4].Value.ToString();
            txtDiaChi.Text = rowData.Cells[5].Value.ToString();
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
                List<KhachHang> khachHangs = _services.CNShow();
                showData(khachHangs);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Da xoa", MessageBoxButtons.YesNo);
            string ma = txtMa.Text;
            int maInt = int.Parse(ma);
            if (result == DialogResult.Yes && ma.Trim() != "")
            {
                MessageBox.Show(_services.CNXoa(maInt));
                List<KhachHang> khachHangs = _services.CNShow();
                showData(khachHangs);
                return;
            }
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang> kh = _services.CNTim(txtSeach.Text);
            showData(kh);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
