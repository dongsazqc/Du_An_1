﻿using BUS.Service;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRL
{
    public partial class FormSanPham : Form
    {
        SPgiamgiaService _spgiamgia = new SPgiamgiaService(); 
        SanPhamService _sanPhamService = new SanPhamService();
        SanPhamRep _sanPhamRep = new SanPhamRep();

        public FormSanPham()
        {
            InitializeComponent();
            List<SanPham> sp = _sanPhamService.CNShow();
            showdata(sp);

            List<SanPham> sanPhams = _sanPhamService.CNShow();
            showdata(sanPhams);
            List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
            Loaddata(sanPhamGiamGia);
          
        }

        private void Loaddata(List<SanPhamGiamGium> sanPhamGiamGia)
        {
            dtg_SPGG.Rows.Clear();
            dtg_SPGG.ColumnCount = 9;
            int stt = 1;
            dtg_SPGG.Columns[0].HeaderText = "Số thứ tự";
            dtg_SPGG.Columns[1].HeaderText = "ID Sản Phẩm";
            dtg_SPGG.Columns[2].HeaderText = "Tên Sản Phẩm";
            dtg_SPGG.Columns[3].HeaderText = "Giá Bán";
            dtg_SPGG.Columns[4].HeaderText = "Phần Trăm Giảm";
            dtg_SPGG.Columns[5].HeaderText = "Giá Giảm";
            dtg_SPGG.Columns[6].HeaderText = "Ngày Bắt Đầu";
            dtg_SPGG.Columns[7].HeaderText = "Ngày Kết Thúc";
            dtg_SPGG.Columns[8].HeaderText = "Mô Tả";
            foreach (var item in sanPhamGiamGia)
            {
                dtg_SPGG.Rows.Add(stt++, item.MaSanPham, item.TenSanPham, item.GiaBan, item.PhanTramGiam, item.GiaGiam, item.NgayBatDauGiamGia, item.NgayKetThucGiamGia, item.MoTa);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            List<SanPham> sp = _sanPhamService.CNtim(txt_search.Text);
            showdata(sp);
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
        }

        private void btn_laysanpham_Click(object sender, EventArgs e)
        {
        }
        public void showdata(List<SanPham> sp)
        {
            dgv_sanpham.Rows.Clear();
            dgv_sanpham.ColumnCount = 10;
            int stt = 1;
            dgv_sanpham.Columns[0].HeaderText = "số thứ tự";
            dgv_sanpham.Columns[1].HeaderText = "ID sản phẩm";
            dgv_sanpham.Columns[2].HeaderText = "Tên sản phẩm";
            dgv_sanpham.Columns[3].HeaderText = "Tên thương hiệu";
            dgv_sanpham.Columns[4].HeaderText = "mô tả";
            dgv_sanpham.Columns[5].HeaderText = "giá";
            dgv_sanpham.Columns[6].HeaderText = "số lượng tồn kho";
            dgv_sanpham.Columns[7].HeaderText = "kích thước";
            dgv_sanpham.Columns[8].HeaderText = "màu sắc";
            dgv_sanpham.Columns[9].HeaderText = "trạng thái";
            foreach (var item in sp)
            {
                dgv_sanpham.Rows.Add(stt++, item.SanPhamId, item.TenSanPham, item.TenThuongHieu, item.MoTa, item.Gia, item.SoLuongTonKho, item.KichThuoc, item.MauSac, item.TrangThai);

            }
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
            string id = txt_IDsanpham.Text;
            string ten = txt_tensanpham.Text;
            string tenthuonghieu = txt_tenthuonghieu.Text;
            string mota = rtb_mota.Text;
            string gia = txt_gia.Text;
            string soluongtonkho = txt_soluong.Text;
            string kichthuoc = txt_kichthuoc.Text;
            string mausac = txt_mausac.Text;
            string trangthai = txt_trangthai.Text;
            int idInt = int.Parse(id);
            int giaInt = int.Parse(gia);
            int soluongInt = int.Parse(soluongtonkho);
            DialogResult result = MessageBox.Show("bạn có muốn thêm không?", "thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _sanPhamService.CNthem(idInt, ten, tenthuonghieu, mota, giaInt, soluongInt, kichthuoc, mausac, trangthai);
                MessageBox.Show(kq);
                List<SanPham> sanPhams = _sanPhamService.CNShow();
                //showdata
                showdata(sanPhams);
                return;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string id = txt_IDsanpham.Text;
            int idInt = int.Parse(id);
            DialogResult result = MessageBox.Show("bạn có muốn xóa không?", "xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && txt_IDsanpham.Text.Trim() != "")
            {
                List<SanPham> sanPhams = _sanPhamService.CNShow();
                MessageBox.Show(_sanPhamService.CNxoa(idInt));
                //showdata
                showdata(sanPhams);
                return;
            }
        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dữ liệu ra từ dòng được chọn để fill lên form
            int row = e.RowIndex;
            var rowdata = dgv_sanpham.Rows[row];
            txt_IDsanpham.Text = rowdata.Cells[1].Value.ToString();
            txt_tensanpham.Text = rowdata.Cells[2].Value.ToString();
            txt_tenthuonghieu.Text = rowdata.Cells[3].Value.ToString();
            rtb_mota.Text = rowdata.Cells[4].Value.ToString();
            txt_gia.Text = rowdata.Cells[5].Value.ToString();
            txt_soluong.Text = rowdata.Cells[6].Value.ToString();
            txt_kichthuoc.Text = rowdata.Cells[7].Value.ToString();
            txt_mausac.Text = rowdata.Cells[8].Value.ToString();
            txt_trangthai.Text = rowdata.Cells[9].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string id = txt_IDsanpham.Text;
            string ten = txt_tensanpham.Text;
            string tenthuonghieu = txt_tenthuonghieu.Text;
            string mota = rtb_mota.Text;
            string gia = txt_gia.Text;
            string soluongtonkho = txt_soluong.Text;
            string kichthuoc = txt_kichthuoc.Text;
            string mausac = txt_mausac.Text;
            string trangthai = txt_trangthai.Text;
            int idInt = int.Parse(id);
            int giaInt = int.Parse(gia);
            int soluongInt = int.Parse(soluongtonkho);
            DialogResult result = MessageBox.Show("bạn có muốn sửa không?", "sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _sanPhamService.CNSua(idInt, ten, tenthuonghieu, mota, giaInt, soluongInt, kichthuoc, mausac, trangthai);
                MessageBox.Show(kq);
                List<SanPham> sanPhams = _sanPhamService.CNShow();
                //showdata
                showdata(sanPhams);
                return;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            txt_IDsanpham.Text = "";
            txt_tensanpham.Text = "";
            txt_tenthuonghieu.Text = "";
            txt_soluong.Text = "";
            txt_mausac.Text = "";
            txt_gia.Text = "";
            txt_kichthuoc.Text = "";
            txt_trangthai.Text = "";
            rtb_mota.Text = "";



            ;
        }

        private void txt_tensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void grp_giamgia_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_giamgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
