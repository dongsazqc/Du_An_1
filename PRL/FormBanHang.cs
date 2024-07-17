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
using DAL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PRL
{
    public partial class FormBanHang : Form
    {
        SanPhamRep _sanphamRep = new SanPhamRep();
        SanPhamService _SanPhamService = new SanPhamService();
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void Loadata(List<SanPham> sanphams)
        {
            data_SPBH.Rows.Clear();
            data_SPBH.ColumnCount = 10;
            int stt = 1;
            data_SPBH.Columns[0].HeaderText = "Số thứ tự";
            data_SPBH.Columns[1].HeaderText = "ID sản phẩm";
            data_SPBH.Columns[2].HeaderText = "Tên sản phẩm";
            data_SPBH.Columns[3].HeaderText = "Tên thương hiệu";
            data_SPBH.Columns[4].HeaderText = "Mô tả";
            data_SPBH.Columns[5].HeaderText = "Giá";
            data_SPBH.Columns[6].HeaderText = "Số lượng tồn kho";
            data_SPBH.Columns[7].HeaderText = "Kích thước";
            data_SPBH.Columns[8].HeaderText = "Màu sắc";
            data_SPBH.Columns[9].HeaderText = "Trạng thái";
            foreach (var item in sanphams)
            {
                data_SPBH.Rows.Add(stt++, item.SanPhamId, item.TenSanPham, item.TenThuongHieu, item.MoTa, item.Gia, item.SoLuongTonKho, item.KichThuoc, item.MauSac, item.TrangThai);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_DS_sanpham_Click(object sender, EventArgs e)
        {
            List<SanPham> sanphams = _SanPhamService.CNShow();
            Loadata(sanphams);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }



        private void txt_GiaGoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
             // Khởi tạo dtf_GioHang
            dtf_GioHang.ColumnCount = 4;
            dtf_GioHang.Columns[0].HeaderText = "ID sản phẩm";
            dtf_GioHang.Columns[1].HeaderText = "Tên sản phẩm";
            dtf_GioHang.Columns[2].HeaderText = "Giá";
            dtf_GioHang.Columns[3].HeaderText = "Số lượng tồn kho";
        }

        private void txt_tienthua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void data_SPBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_SPBH.Rows[e.RowIndex];
                int sanPhamId = (int)selectedRow.Cells[1].Value; // Sử dụng chỉ số cột
                string tenSanPham = selectedRow.Cells[2].Value.ToString(); // Sử dụng chỉ số cột
                decimal gia = (decimal)selectedRow.Cells[5].Value; // Sử dụng chỉ số cột
                int soLuongTonKho = (int)selectedRow.Cells[6].Value; // Sử dụng chỉ số cột

                dtf_GioHang.Rows.Add(sanPhamId, tenSanPham, gia, soLuongTonKho);
            }
        }

        private void dtf_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_SPBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
