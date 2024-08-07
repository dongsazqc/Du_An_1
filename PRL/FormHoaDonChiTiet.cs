using BUS.Service;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PRL
{
    
    public partial class FormHoaDonChiTiet : Form
    {
        SanPhamMuaSer _sanPhamMuaSer = new SanPhamMuaSer();
        private string _hoaDonId;
        public FormHoaDonChiTiet( string hoaDonId)
        {
            InitializeComponent();
            _hoaDonId = hoaDonId;
            
        }


        private void FormHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadSanPham(_hoaDonId);
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên thương hiệu ";   
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Giá";
            dataGridView1.Columns[4].HeaderText = "Tổng giá";

        }
        public void LoadSanPham(string hoaDonId)
        {
            var sanPhamList = _sanPhamMuaSer.GetSanPhamByHoaDonId(hoaDonId);

            dataGridView1.Rows.Clear(); // Xóa dữ liệu hiện tại trên DataGridView

            foreach (var sanPham in sanPhamList)
            {
                dataGridView1.Rows.Add(
                    sanPham.TenSanPham,
                    sanPham.TenThuongHieu,
                    sanPham.SoLuong,
                    sanPham.Gia,
                    sanPham.TongGia
                );
            }
        }





    }
}
