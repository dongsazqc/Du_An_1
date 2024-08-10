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
using Microsoft.Data.SqlClient;


namespace PRL
{
    public partial class FormBanHang : Form
    {
        SanPhamRep _sanphamRep = new SanPhamRep();
        SanPhamService _SanPhamService = new SanPhamService();
        HoaDonService _hoadonService = new HoaDonService();
        HoaDonRep _HoaDonRep = new HoaDonRep();
        List<HoaDon> hoaDons = new List<HoaDon>();
        List<HoaDonDaThanhToan> hoaDonDaThanhs = new List<HoaDonDaThanhToan>();
        List<SanPham> sanPhams = new List<SanPham>();
        SanPhamMuaSer _SpMuaSer = new SanPhamMuaSer();
        SanPhamMuaRep _spMuaRep = new SanPhamMuaRep();
        HDTTService _hdttService = new HDTTService();
        private readonly string connectionString = "Data Source=PHAM_VAN_DONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True";


        public FormBanHang()
        {
            InitializeComponent();
            LoadHoaDons();
            LoadSanPhams();
            List<HoaDonDaThanhToan> hoaDonDaThanhToans = _hdttService.CNShowHoaDonThanhToan();
            showdata(hoaDonDaThanhToans);
            pn_ChiTiet.Visible = false;

        }

        private void showdata(List<HoaDonDaThanhToan> hoaDonDaThanhToans)
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
            foreach (var i in hoaDonDaThanhToans)
            {
                dtg_HoaDon.Rows.Add(stt++, i.HoaDonId, i.TenKhachHang, i.DiaChi, i.Gmail, i.SoDienThoai);
            }
        }

        private void LoadataHDCC(List<HoaDon> hddtt)
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
            foreach (var i in hoaDonDaThanhs)
            {
                dtg_HoaDon.Rows.Add(stt++, i.HoaDonId, i.TenKhachHang, i.DiaChi, i.Gmail, i.SoDienThoai);
            }
        }

        private void LoadHoaDons()
        {
            hoaDons = _hoadonService.CNShowHoaDon(); // Cập nhật danh sách hoaDons
            Loadata(hoaDons);
            LoadCombobox(); // Cập nhật ComboBox sau khi tải hóa đơn
        }
        private void LoadSanPhams()
        {
            sanPhams = _SanPhamService.CNShow(); // Cập nhật danh sách sanPhams
            Loadata(sanPhams);
        }
        private void Loadata(List<HoaDon> hoaDons)
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
            foreach (var i in hoaDons)
            {
                dtg_HoaDon.Rows.Add(stt++, i.HoaDonId, i.TenKhachHang, i.DiaChi, i.Gmail, i.SoDienThoai);
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


        private void btn_DS_sanpham_Click(object sender, EventArgs e)
        {
            LoadSanPhams();

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            icbtn_LamMOI.IconChar = FontAwesome.Sharp.IconChar.Rotate - Left;
            lb_TongTien.BackColor = Color.Transparent;
            lb_TongTien.BorderStyle = BorderStyle.None;
            txt_timkiemsanpham.ForeColor = Color.Gray;
            txt_Tienthua.Enabled = false;
            txt_tongtien.Enabled = false;
            txt_tongtien.Text = "0";


            dtf_GioHang.ColumnCount = 5;
            dtf_GioHang.Columns[0].HeaderText = "Tên sản phẩm";
            dtf_GioHang.Columns[1].HeaderText = "Tên thương hiệu ";
            dtf_GioHang.Columns[2].HeaderText = "Số lượng";
            dtf_GioHang.Columns[3].HeaderText = "Giá";
            dtf_GioHang.Columns[4].HeaderText = "Tổng giá";

            dtg_ChiTiet.ColumnCount = 6;
            dtg_ChiTiet.Columns[0].HeaderText = "Mã hóa đơn";
            dtg_ChiTiet.Columns[1].HeaderText = "Tên sản phẩm ";
            dtg_ChiTiet.Columns[2].HeaderText = "Tên thương hiệu";
            dtg_ChiTiet.Columns[3].HeaderText = "Số lượng";
            dtg_ChiTiet.Columns[4].HeaderText = "Giá";
            dtg_ChiTiet.Columns[5].HeaderText = "Tổng giá";


        }



        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void data_SPBH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = data_SPBH.Rows[e.RowIndex];
                int sanPhamId = (int)selectedRow.Cells[1].Value;
                string tensanpham = selectedRow.Cells[2].Value.ToString();
                string tenthuonghieu = selectedRow.Cells[3].Value.ToString();
                decimal gia = (decimal)selectedRow.Cells[5].Value;
                int soLuongTonKho = (int)selectedRow.Cells[6].Value;
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
                            bool productExists = false;
                            foreach (DataGridViewRow row in dtf_GioHang.Rows)
                            {
                                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == tensanpham &&
                                    row.Cells[1].Value != null && row.Cells[1].Value.ToString() == tenthuonghieu)
                                {
                                    int existingQuantity = int.Parse(row.Cells[2].Value.ToString());
                                    decimal existingTotalPrice = decimal.Parse(row.Cells[4].Value.ToString());

                                    row.Cells[2].Value = existingQuantity + soluong;
                                    row.Cells[4].Value = (existingQuantity + soluong) * gia;

                                    productExists = true;
                                    break;
                                }
                            }

                            if (!productExists)
                            {
                                decimal tongGia = gia * soluong;
                                dtf_GioHang.Rows.Add(tensanpham, tenthuonghieu, soluong, gia, tongGia);
                            }

                            TongTienGioHang();

                            int soLuongMoi = soLuongTonKho - soluong;
                            _SanPhamService.CapNhatSoLuong(sanPhamId, soLuongMoi);

                            LoadSanPhams(); // Cập nhật danh sách sản phẩm
                        }
                    }
                }
            }
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
            txt_tongtien.Text = tongTien.ToString("0");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

            if (cbx_HoaDonId.SelectedItem != null)
            {
                string selectedHoaDonId = cbx_HoaDonId.SelectedItem.ToString();
                string CauLenh = $"Xác nhận thanh toán {txt_tongtien.Text} cho hóa đơn {selectedHoaDonId}";
                DialogResult result = MessageBox.Show(CauLenh, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {

                    // Đặt điểm dừng tại đây
                    string hoaDonId = selectedHoaDonId;
                    string tenKH = txt_tenkhachhang.Text;
                    string soDT = txt_sđt.Text;
                    string DiaC = txt_DiaChi.Text;
                    string Gmail = txt_Gmail.Text;

                    // Gọi phương thức thêm hóa đơn
                    string kqThemHoaDon = _hdttService.CNThemHoaDonThanhToan(hoaDonId, tenKH, soDT, DiaC, Gmail);
                    MessageBox.Show(kqThemHoaDon); // Hiển thị kết quả thêm

                    // Cập nhật danh sách hóa đơn từ cơ sở dữ liệu
                    List<HoaDonDaThanhToan> hoaDonDaThanhToan1s = _hdttService.CNShowHoaDonThanhToan();
                    showdata(hoaDonDaThanhToan1s);

                    // Cập nhật lại ComboBox
                    cbx_HoaDonId.Items.Remove(selectedHoaDonId);

                    // Lưu lại các sản phẩm trong hóa đơn đã thanh toán
                  

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbx_HoaDonId.Text = "";
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {

            // Kiểm tra thông tin đầu vào từ các TextBox
            if (string.IsNullOrEmpty(txt_sđt.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra các điều kiện khác
            if (txt_sđt.Text != "0")
            {
                if (string.IsNullOrEmpty(txt_tenkhachhang.Text) ||
                    string.IsNullOrEmpty(txt_Gmail.Text) ||
                    string.IsNullOrEmpty(txt_DiaChi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các trường bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Xác nhận tạo hóa đơn vãng lai
                DialogResult result = MessageBox.Show("Bạn có xác định tạo 1 hóa đơn cho khách vãng lai không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                txt_DiaChi.Text = "Không có";
                txt_Gmail.Text = "Không có";
                txt_tenkhachhang.Text = "Không có";
            }

            // Lấy danh sách mã hóa đơn hiện có từ ComboBox
            List<string> existingIds = cbx_HoaDonId.Items.Cast<string>().ToList();
            string hoaDonId;
            int maxId;

            if (txt_sđt.Text == "0")
            {
                // Mã hóa đơn cho khách vãng lai
                maxId = GetMaxHoaDonId("VL");
                hoaDonId = "VL" + (maxId + 1).ToString("D3");
                // Kiểm tra trùng lặp và sinh mã mới nếu cần
                while (existingIds.Contains(hoaDonId))
                {
                    maxId++;
                    hoaDonId = "VL" + (maxId + 1).ToString("D3");
                }
            }
            else
            {
                // Mã hóa đơn cho khách hàng thông thường
                maxId = GetMaxHoaDonId("HD");
                hoaDonId = "HD" + (maxId + 1).ToString("D3");
                // Kiểm tra trùng lặp và sinh mã mới nếu cần
                while (existingIds.Contains(hoaDonId))
                {
                    maxId++;
                    hoaDonId = "HD" + (maxId + 1).ToString("D3");
                }
            }

            // Tạo đối tượng HoaDon
            HoaDonDaThanhToan hoaDon = new HoaDonDaThanhToan
            {
                HoaDonId = hoaDonId,
                SoDienThoai = txt_sđt.Text,
                TenKhachHang = txt_sđt.Text == "0" ? string.Empty : txt_tenkhachhang.Text,
                DiaChi = txt_sđt.Text == "0" ? string.Empty : txt_DiaChi.Text,
                Gmail = txt_sđt.Text == "0" ? string.Empty : txt_Gmail.Text,
                sanPhamMuas = new List<SanPhamMua>()
            };

            // Thêm sản phẩm vào hóa đơn
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

            // Hiển thị thông báo thành công
            string thongBao = $"{hoaDon.HoaDonId}";
            string thongBao2 = txt_sđt.Text == "0" ? "Vãng Lai" : txt_tenkhachhang.Text;
            MessageBox.Show($"Tạo thành công hóa đơn {thongBao} cho khách hàng {thongBao2}", "Thành công !!", MessageBoxButtons.OK);

            // Thêm hóa đơn vào danh sách và làm sạch các trường
            hoaDonDaThanhs.Add(hoaDon);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có lựa chọn nào không
            if (cbx_HoaDonId.SelectedItem != null)
            {
                // Lấy mã hóa đơn được chọn
                string selectedMaHoaDon = cbx_HoaDonId.SelectedItem.ToString();

                // Tìm hóa đơn tương ứng trong danh sách hoaDonChos
                HoaDonDaThanhToan selectedHoaDon = hoaDonDaThanhs.FirstOrDefault(hd => hd.HoaDonId == selectedMaHoaDon);

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
        private int GetMaxHoaDonId(string prefix)
        {
            int maxId = 0;
            string query = $"SELECT MAX(CAST(SUBSTRING(HoaDonID, LEN('{prefix}') + 1, LEN(HoaDonID) - LEN('{prefix}')) AS INT)) FROM HoaDonDaThanhToan WHERE HoaDonID LIKE '{prefix}%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    maxId = Convert.ToInt32(result);
                }
            }
            return maxId;
        }

        private void LoadCombobox()
        {
            cbx_HoaDonId.Items.Clear();
            foreach (var hoaDon in hoaDonDaThanhs)
            {
                cbx_HoaDonId.Items.Add(hoaDon.HoaDonId);
            }
        }


        private void icbtn_LamMOI_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu hiện tại trên DataGridView

            dtg_HoaDon.Rows.Clear();
            data_SPBH.Rows.Clear();
            dtf_GioHang.Rows.Clear();

            // Xóa các TextBox và ComboBox
            cbx_HoaDonId.Text = "";
            txt_tenkhachhang.Clear();
            txt_sđt.Clear();
            txt_Gmail.Clear();
            txt_DiaChi.Clear();
            txt_Tienthua.Clear();
            txt_tongtien.Clear();
            txt_TimKiemGioHang.Clear();
            txt_khachdua.Clear();

            // Nạp lại dữ liệu từ dịch vụ nếu cần

            List<SanPham> sanPhams = _SanPhamService.CNShow();
            Loadata(sanPhams);
            List<HoaDonDaThanhToan> hoaDonDaThanhToans = _hdttService.CNShowHoaDonThanhToan();
            showdata(hoaDonDaThanhToans);


            // Reset các thuộc tính khác nếu cần
            icbtn_LamMOI.IconChar = FontAwesome.Sharp.IconChar.Rotate - Left;
            lb_TongTien.BackColor = Color.Transparent;
            lb_TongTien.BorderStyle = BorderStyle.None;
        }

        private void btn_XoaSp_Click(object sender, EventArgs e)
        {

            if (dtf_GioHang.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dtf_GioHang.SelectedRows[0];
                string tenSanPham = selectedRow.Cells[0].Value.ToString();
                string tenThuongHieu = selectedRow.Cells[1].Value.ToString();
                int soLuong = int.Parse(selectedRow.Cells[2].Value.ToString());
                decimal gia = decimal.Parse(selectedRow.Cells[3].Value.ToString());

                // Xóa hàng khỏi giỏ hàng
                dtf_GioHang.Rows.Remove(selectedRow);

                // Cập nhật lại số lượng sản phẩm
                List<SanPham> sanPhams = _SanPhamService.CNTimTenandThuongHIeu(tenSanPham, tenThuongHieu);
                if (sanPhams != null && sanPhams.Count > 0)
                {
                    foreach (var sanPham in sanPhams)
                    {
                        int soLuongMoi = sanPham.SoLuongTonKho + soLuong;
                        _SanPhamService.CapNhatSoLuong(sanPham.SanPhamId, soLuongMoi);
                    }
                    Loadata(_SanPhamService.CNShow()); // Cập nhật danh sách sản phẩm
                }

                // Cập nhật tổng tiền
                TongTienGioHang();
            }
        }





        private void btn_xoaALLL_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtf_GioHang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string tenSanPham = row.Cells[0].Value.ToString();
                    string tenThuongHieu = row.Cells[1].Value.ToString();
                    int soLuong = int.Parse(row.Cells[2].Value.ToString());

                    // Cập nhật lại số lượng sản phẩm
                    List<SanPham> sanPhams = _SanPhamService.CNTimTenandThuongHIeu(tenSanPham, tenThuongHieu);
                    if (sanPhams != null && sanPhams.Count > 0)
                    {
                        foreach (var sanPham in sanPhams)
                        {
                            int soLuongMoi = sanPham.SoLuongTonKho + soLuong;
                            _SanPhamService.CapNhatSoLuong(sanPham.SanPhamId, soLuongMoi);
                        }
                        Loadata(_SanPhamService.CNShow()); // Cập nhật danh sách sản phẩm
                    }
                }
            }

            // Xóa tất cả hàng trong giỏ hàng
            dtf_GioHang.Rows.Clear();
            TongTienGioHang();
        }

        private void dtg_HoaDon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedMaHoaDon = dtg_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Tìm hóa đơn tương ứng trong danh sách hoaDonDaThanhs
                HoaDonDaThanhToan selectedHoaDon = hoaDonDaThanhs.FirstOrDefault(hd => hd.HoaDonId == selectedMaHoaDon);

                if (selectedHoaDon != null)
                {
                    // Hiển thị chi tiết hóa đơn
                    pn_ChiTiet.Visible = true;
                    dtg_ChiTiet.Rows.Clear();

                    foreach (var sp in selectedHoaDon.sanPhamMuas)
                    {
                        dtg_ChiTiet.Rows.Add(selectedMaHoaDon, sp.TenSanPham, sp.TenThuongHieu, sp.SoLuong, sp.Gia, sp.TongGia);
                    }
                }
                else
                {
                    pn_ChiTiet.Visible = true;
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
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void dtg_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            pn_ChiTiet.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<SanPham> sp = _SanPhamService.CntimSPTheoTen(txt_timkiemsanpham.Text);
            Loadata(sp);

        }

        private void txt_timkiemsanpham_TextChanged(object sender, EventArgs e)
        {
            List<SanPham> sp = _SanPhamService.CntimSPTheoTen(txt_timkiemsanpham.Text);
            Loadata(sp);
        }

        private void txt_TimKiemGioHang_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<SanPham> sp = _SanPhamService.CntimSPTheoTen(txt_timkiemsanpham.Text);
            Loadata(sp);
        }
    }
}
