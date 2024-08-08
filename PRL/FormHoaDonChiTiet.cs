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
            LoadSanPhamDetails(_hoaDonId);
            
            

        }
        private void LoadSanPhamDetails(string hoaDonId)
        {
            try
            {
                // Lấy dữ liệu sản phẩm từ cơ sở dữ liệu bằng mã hóa đơn
                var sanPhamList = _sanPhamMuaSer.GetSanPhamByHoaDonId(hoaDonId);

                // Hiển thị dữ liệu vào DataGridView
                dataGridView1.DataSource = sanPhamList;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
