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
        HoaDonService _hoadonServicr = new HoaDonService();
        HoaDonRep _HoaDonRep = new HoaDonRep();
        List<HoaDon> hoaDons = new List<HoaDon>();
        List<SanPham> sanPhams = new List<SanPham>();

        public FormBanHang()
        {
            InitializeComponent();
            List<HoaDon> hoaDon1s = _hoadonServicr.CNShowHoaDon();
            Loadata(hoaDon1s);
            List<SanPham> sanPhams1 = _SanPhamService.CNShow();
            Loadata(sanPhams1);
        }

        private void Loadata(List<HoaDon> hoaDon1s)
        {
            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.ColumnCount = 6;
            int stt = 1;
            dtg_HoaDon.Columns[0].HeaderText = "Số thứ tự";
            dtg_HoaDon.Columns[1].HeaderText = "Mã hóa đơn";
            dtg_HoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dtg_HoaDon.Columns[3].HeaderText = "Địa chỉ";
            dtg_HoaDon.Columns[4].HeaderText = "Gmail";
            dtg_HoaDon.Columns[5].HeaderText = "Số điện thoại";
            foreach (var item in hoaDons)
            {
                dtg_HoaDon.Rows.Add(stt++, item.HoaDonId, item.TenKhachHang, item.DiaChi, item.Gmail, item.SoDienThoai);
            }
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
            icbtn_LamMOI.IconChar = FontAwesome.Sharp.IconChar.Rotate - Left;
            lb_TongTien.BackColor = Color.Transparent;
            lb_TongTien.BorderStyle = BorderStyle.None;
            icbtn_XoaHoaDon.IconChar = FontAwesome.Sharp.IconChar.Trash;


            txt_tongtien.Enabled = false;
            txt_tongtien.Text = "0.00";


            dtf_GioHang.ColumnCount = 5;
            dtf_GioHang.Columns[0].HeaderText = "Tên sản phẩm";
            dtf_GioHang.Columns[1].HeaderText = "Tên thương hiệu ";
            dtf_GioHang.Columns[2].HeaderText = "Số lượng";
            dtf_GioHang.Columns[3].HeaderText = "Giá";
            dtf_GioHang.Columns[4].HeaderText = "Tổng giá";


        }


        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void data_SPBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_SPBH.Rows[e.RowIndex];
                int sanPhamId = (int)selectedRow.Cells[1].Value; // Giả sử ID sản phẩm nằm ở cột 1
                string tensanpham = selectedRow.Cells[2].Value.ToString();
                string tenthuonghieu = selectedRow.Cells[3].Value.ToString();
                decimal gia = (decimal)selectedRow.Cells[5].Value;
                int soLuongTonKho = (int)selectedRow.Cells[6].Value;  // Giả sử số lượng tồn kho nằm ở cột 6

                using (FormSoLuong formSoLuong = new FormSoLuong())
                {
                    if (formSoLuong.ShowDialog() == DialogResult.OK)
                    {
                        int soluong = formSoLuong.SOLUONG;

                        if (soluong > soLuongTonKho)
                        {
                            MessageBox.Show("Số lượng yêu cầu vượt quá số lượng tồn kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            decimal tongGia = gia * soluong;
                            dtf_GioHang.Rows.Add(tensanpham, tenthuonghieu, soluong, gia, tongGia);
                            TongTienGioHang();

                            int soLuongMoi = soLuongTonKho - soluong;
                            _SanPhamService.CapNhatSoLuong(sanPhamId, soLuongMoi);

                            List<SanPham> sanPhams1 = _SanPhamService.CNShow();
                            Loadata(sanPhams1);
                        }
                    }
                }
            }

        }

        private void dtf_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_SPBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void txt_tongtien_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void TongTienGioHang()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dtf_GioHang.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal tongGia;
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out tongGia))
                    {
                        tongTien += tongGia;
                    }
                }
            }
            txt_tongtien.Text = tongTien.ToString("0.00");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string CauLenh = $"Xác nhận thanh toán {txt_tongtien.Text} cho nhân viên";
            DialogResult result = MessageBox.Show(CauLenh, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Lấy các thông tin từ form
                string hoaDonId = cbx_HoaDonId.Text;
                string tenKH = txt_tenkhachhang.Text;
                string soDT = txt_sđt.Text;
                string DiaC = txt_DiaChi.Text;
                string Gmail = txt_Gmail.Text;


                // Gọi phương thức thêm hóa đơn
                string kqThemHoaDon = _hoadonServicr.CNThemHoaDon(hoaDonId, tenKH, soDT, DiaC, Gmail);

                // Thông báo kết quả
                if (kqThemHoaDon != null)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách hóa đơn
                    List<HoaDon> hoaDons = _hoadonServicr.CNShowHoaDon();
                    Loadata(hoaDons);

                    // Reset form
                    txt_tenkhachhang.Clear();
                    txt_sđt.Clear();
                    txt_Gmail.Clear();
                    txt_DiaChi.Clear();
                    txt_Tienthua.Clear();
                    txt_tongtien.Clear();
                    txt_TimKiemGioHang.Clear();
                    txt_khachdua.Clear();
                    dtf_GioHang.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult Thoadon = MessageBox.Show("Bạn có chắc muốn tạo 1 hóa đơn không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoadon == DialogResult.Yes)
            {
                HoaDon hoaDon = new HoaDon
                {
                    HoaDonId = "HD" + (hoaDons.Count + 1).ToString("D3"),
                    SoDienThoai = txt_sđt.Text,
                    TenKhachHang = txt_tenkhachhang.Text,
                    DiaChi = txt_DiaChi.Text,
                    Gmail = txt_Gmail.Text,
                    sanPhamMuas = new List<SanPhamMua>()
                };

                foreach (DataGridViewRow row in dtf_GioHang.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        hoaDon.sanPhamMuas.Add(new SanPhamMua
                        {
                            TenSanPham = row.Cells[0].Value.ToString(),
                            TenThuongHieu = row.Cells[1].Value.ToString(),
                            SoLuong = int.Parse(row.Cells[2].Value.ToString()),
                            Gia = decimal.Parse(row.Cells[3].Value.ToString()),
                            TongGia = decimal.Parse(row.Cells[4].Value.ToString())
                        });
                    }
                }

                string thongBao = $"{hoaDon.HoaDonId}";
                string thongBao2 = txt_tenkhachhang.Text;
                MessageBox.Show($"Tạo thành công hóa đơn {thongBao} cho khách hàng {thongBao2} ", "Thành công !!", MessageBoxButtons.OK);
                hoaDons.Add(hoaDon);
                LoadCombobox();
                txt_tenkhachhang.Clear();
                txt_sđt.Clear();
                txt_Gmail.Clear();
                txt_DiaChi.Clear();
                txt_Tienthua.Clear();
                txt_tongtien.Clear();
                txt_TimKiemGioHang.Clear();
                txt_khachdua.Clear();
                dtf_GioHang.Rows.Clear();


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có lựa chọn nào không
            if (cbx_HoaDonId.SelectedItem != null)
            {
                // Lấy mã hóa đơn được chọn
                string selectedMaHoaDon = cbx_HoaDonId.SelectedItem.ToString();

                // Tìm hóa đơn tương ứng trong danh sách hoaDonChos
                HoaDon selectedHoaDon = hoaDons.FirstOrDefault(hd => hd.HoaDonId == selectedMaHoaDon);

                if (selectedHoaDon != null)
                {
                    // Hiển thị thông tin hóa đơn trên giao diện
                    txt_sđt.Text = selectedHoaDon.SoDienThoai;
                    txt_tenkhachhang.Text = selectedHoaDon.TenKhachHang;
                    txt_DiaChi.Text = selectedHoaDon.DiaChi;
                    txt_Gmail.Text = selectedHoaDon.Gmail;

                    // Cập nhật bảng giỏ hàng với các sản phẩm trong hóa đơn
                    dtf_GioHang.Rows.Clear();
                    foreach (var sp in selectedHoaDon.sanPhamMuas)
                    {
                        dtf_GioHang.Rows.Add(sp.TenSanPham, sp.TenThuongHieu, sp.SoLuong, sp.Gia, sp.TongGia);
                    }

                    // Cập nhật tổng tiền
                    TongTienGioHang();
                }
            }
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void LoadCombobox()
        {
            cbx_HoaDonId.Items.Clear();
            foreach (var hoaDon in hoaDons)
            {
                cbx_HoaDonId.Items.Add(hoaDon.HoaDonId);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //// Hiển thị hộp thoại xác nhận
            //DialogResult result = MessageBox.Show("Bạn có chắc muốn tạo hóa đơn cho khách vãng lai không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    // Tạo hóa đơn cho khách vãng lai
            //    HoaDon hoaDon = new HoaDon
            //    {
            //        HoaDonId = "VL_HD" + (hoaDons.Count + 1).ToString("D3"), // Thêm tiền tố VL
            //        SoDienThoai = "Khách vãng lai",
            //        TenKhachHang = "Khách vãng lai",
            //        DiaChi = "Không có",
            //        Gmail = "Không có",
            //        sanPhamMuas = new List<SanPhamMua>()
            //    };

            //    foreach (DataGridViewRow row in dtf_GioHang.Rows)
            //    {
            //        if (row.Cells[0].Value != null)
            //        {
            //            hoaDon.sanPhamMuas.Add(new SanPhamMua
            //            {
            //                TenSanPham = row.Cells[0].Value.ToString(),
            //                TenThuongHieu = row.Cells[1].Value.ToString(),
            //                SoLuong = int.Parse(row.Cells[2].Value.ToString()),
            //                Gia = decimal.Parse(row.Cells[3].Value.ToString()),
            //                TongGia = decimal.Parse(row.Cells[4].Value.ToString())
            //            });
            //        }
            //    }

            //    // Thông báo thành công
            //    string thongBao = $"{hoaDon.HoaDonId}";
            //    MessageBox.Show($"Tạo thành công hóa đơn {thongBao} cho khách vãng lai", "Thành công !!", MessageBoxButtons.OK);

            //    hoaDons.Add(hoaDon);
            //    LoadCombobox();

            //    // Xóa thông tin trên form
            //    txt_tenkhachhang.Clear();
            //    txt_sđt.Clear();
            //    txt_Gmail.Clear();
            //    txt_DiaChi.Clear();
            //    txt_Tienthua.Clear();
            //    txt_tongtien.Clear();
            //    txt_TimKiemGioHang.Clear();
            //    txt_khachdua.Clear();
            //    dtf_GioHang.Rows.Clear();
            //}
        }

        private void icbtn_LamMOI_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu hiện tại trên DataGridView
            dtg_HoaDon.Rows.Clear();
            data_SPBH.Rows.Clear();
            dtf_GioHang.Rows.Clear();

            // Xóa các TextBox và ComboBox
            txt_tenkhachhang.Clear();
            txt_sđt.Clear();
            txt_Gmail.Clear();
            txt_DiaChi.Clear();
            txt_Tienthua.Clear();
            txt_tongtien.Clear();
            txt_TimKiemGioHang.Clear();
            txt_khachdua.Clear();
            cbx_HoaDonId.Items.Clear();

            // Nạp lại dữ liệu từ dịch vụ nếu cần
            List<HoaDon> hoaDons = _hoadonServicr.CNShowHoaDon();
            Loadata(hoaDons);

            List<SanPham> sanPhams = _SanPhamService.CNShow();
            Loadata(sanPhams);

            // Reset các thuộc tính khác nếu cần
            icbtn_LamMOI.IconChar = FontAwesome.Sharp.IconChar.Rotate-Left;
            lb_TongTien.BackColor = Color.Transparent;
            lb_TongTien.BorderStyle = BorderStyle.None;
        }
    }
}
