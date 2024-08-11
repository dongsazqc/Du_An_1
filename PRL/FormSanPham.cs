using BUS.Service;
using DAL.Models;
using DAL.Repsitory;
using Microsoft.EntityFrameworkCore;
using QRCoder;
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
        SPgiamgiaRep _spggrep = new SPgiamgiaRep();
        public FormSanPham()
        {
            InitializeComponent();

            loadsanpham();
            List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
            Loaddata(sanPhamGiamGia);
            loadsanpham();
            ConfigureDataGridView();
            loadsanphamgiamgia();


        }
        private void ConfigureDataGridView()
        {
            // Xóa các cột không mong muốn khi cấu hình DataGridView
            RemoveUnwantedColumns();
        }
        private void loadsanpham()
        {
            List<SanPham> sp = _sanPhamService.CNShow();
            showdata(sp);
            LoadComboBox(sp);
            dgv_sanpham.DataSource = sp;
            List<SanPham> sanPhams = _sanPhamService.CNShow();
            showdata(sanPhams);
            RemoveUnwantedColumns();

        }
        private void loadgg()
        {
            List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
            dtg_SPGG.DataSource = sanPhamGiamGia;
            Loaddata(sanPhamGiamGia);
        }

        private void Loaddata(List<SanPhamGiamGium> sanPhamGiamGia)
        {
            //dtg_SPGG.Rows.Clear();
            //dtg_SPGG.ColumnCount = 9;
            //int stt = 1;
            //dtg_SPGG.Columns[0].HeaderText = "Số thứ tự";
            //dtg_SPGG.Columns[1].HeaderText = "ID Sản Phẩm";
            //dtg_SPGG.Columns[2].HeaderText = "Tên Sản Phẩm";
            //dtg_SPGG.Columns[3].HeaderText = "Giá Bán";
            //dtg_SPGG.Columns[4].HeaderText = "Phần Trăm Giảm";
            //dtg_SPGG.Columns[5].HeaderText = "Giá Giảm";
            //dtg_SPGG.Columns[6].HeaderText = "Ngày Bắt Đầu";
            //dtg_SPGG.Columns[7].HeaderText = "Ngày Kết Thúc";
            //dtg_SPGG.Columns[8].HeaderText = "Mô Tả";
            //foreach (var item in sanPhamGiamGia)
            //{
            //    dtg_SPGG.Rows.Add(stt++, item.MaSanPham, item.TenSanPham, item.GiaBan, item.PhanTramGiam, item.GiaGiam, item.NgayBatDauGiamGia, item.NgayKetThucGiamGia, item.MoTa);
            //}
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {

            RemoveUnwantedColumns();

        }



        private void btn_laysanpham_Click(object sender, EventArgs e)
        {
        }
        public void showdata(List<SanPham> sp)
        {
            // dgv_sanpham.rows.clear();
            // dgv_sanpham.columncount = 10;
            //int stt = 1;
            //// dgv_sanpham.columns[0].headertext = "số thứ tự";
            // dgv_sanpham.columns[1].headertext = "id sản phẩm";
            // dgv_sanpham.columns[2].headertext = "tên sản phẩm";
            // dgv_sanpham.columns[3].headertext = "tên thương hiệu";
            //dgv_sanpham.columns[4].headertext = "mô tả";
            //  dgv_sanpham.columns[5].headertext = "giá";
            //  dgv_sanpham.columns[6].headertext = "số lượng tồn kho";
            // dgv_sanpham.columns[7].headertext = "kích thước";
            // dgv_sanpham.columns[8].headertext = "màu sắc";
            /// dgv_sanpham.columns[9].headertext = "trạng thái";
            //// foreach (var item in sp)
            // {
            //    dgv_sanpham.rows.add(stt++, item.sanphamid, item.tensanpham, item.tenthuonghieu, item.mota, item.gia, item.soluongtonkho, item.kichthuoc, item.mausac, item.trangthai);

            //}
        }

        private void btn_them_Click(object sender, EventArgs e)
        {


            SanPham sanPhamMoi = new SanPham
            {
                TenSanPham = txt_tensanpham.Text,          // Lấy tên sản phẩm từ TextBox
                TenThuongHieu = txt_tenthuonghieu.Text,  // Lấy tên thương hiệu từ TextBox

                // Thiết lập các thuộc tính khác nếu cần
            };

            // Gọi phương thức ThemSanPham để thêm sản phẩm
            var isAdded = _sanPhamService.ThemSanPham(sanPhamMoi);

            // Kiểm tra kết quả và hiển thị thông báo
            if (isAdded)
            {
                string id = txt_IDsanpham.Text;
                string ten = txt_tensanpham.Text;
                string tenthuonghieu = txt_tenthuonghieu.Text;
                string mota = rtb_mota.Text;
                string gia = txt_gia.Text;
                string soluongtonkho = txt_soluong.Text;
                string kichthuoc = txt_kichthuoc.Text;
                string mausac = txt_mausac.Text;
                bool trangthai = rdo_conhang.Checked;



                DateOnly ngaysx = DateOnly.FromDateTime(dt_ngaysx.Value);
                int idInt = int.Parse(id);
                decimal giadecimal = decimal.Parse(gia);
                txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
                decimal giaInt = decimal.Parse(gia);
                int soluongInt = int.Parse(soluongtonkho);
                string kq = _sanPhamService.CNthem(idInt, ten, tenthuonghieu, mota, giadecimal, soluongInt, kichthuoc, mausac, trangthai, ngaysx);
                MessageBox.Show(kq);
                loadsanpham();

                return;
            }
            else if(!isAdded)
            {
                MessageBox.Show("Sản phẩm đã tồn tại, không thể thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        //private void btn_xoa_Click(object sender, EventArgs e)
        //{
        //    string id = txt_IDsanpham.Text;
        //    int idInt = int.Parse(id);
        //    DialogResult result = MessageBox.Show("bạn có muốn xóa không?", "xóa", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes && txt_IDsanpham.Text.Trim() != "")
        //    {
        //        List<SanPham> sanPhams = _sanPhamService.CNShow();
        //        MessageBox.Show(_sanPhamService.CNxoa(idInt));
        //        dgv_sanpham.DataSource = sanPhams;
        //        showdata
        //        showdata(sanPhams);
        //        return;
        //    }
        //}

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                if (dgv_sanpham.CurrentCell.ColumnIndex > 0)
                {
                    int row = dgv_sanpham.CurrentRow.Index;

                    txt_IDsanpham.Text = dgv_sanpham.Rows[row].Cells[0].Value.ToString();
                    txt_tensanpham.Text = dgv_sanpham.Rows[row].Cells[1].Value.ToString();
                    txt_tenthuonghieu.Text = dgv_sanpham.Rows[row].Cells[2].Value.ToString();
                    rtb_mota.Text = dgv_sanpham.Rows[row].Cells[3].Value.ToString();
                    txt_gia.Text = dgv_sanpham.Rows[row].Cells[4].Value.ToString();

                    txt_soluong.Text = dgv_sanpham.Rows[row].Cells[5].Value.ToString();
                    txt_kichthuoc.Text = dgv_sanpham.Rows[row].Cells[6].Value.ToString();
                    txt_mausac.Text = dgv_sanpham.Rows[row].Cells[7].Value.ToString();
                    string s = dgv_sanpham.Rows[row].Cells[8].Value.ToString();
                    if (s == "False")
                    {
                        rdo_hethang.Checked = true;

                    }

                    else
                    {
                        rdo_conhang.Checked = false;
                    }
                    if (s == "True")
                    {
                        rdo_conhang.Checked = true;
                    }
                    else
                    {
                        rdo_conhang.Checked = false;
                    }
                    object cellValue = dgv_sanpham.Rows[row].Cells[9].Value;

                    if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        DateTime dtNgaySX;
                        bool isParsed = DateTime.TryParse(cellValue.ToString(), out dtNgaySX);

                        if (isParsed)
                        {
                            dt_ngaysx.Value = dtNgaySX;
                        }
                        else
                        {
                            MessageBox.Show("Giá trị của ô ngày sản xuất không hợp lệ. Không thể chuyển đổi sang DateTime.");
                            // Đặt giá trị mặc định cho dt_ngaysx nếu cần
                            dt_ngaysx.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        // Đặt giá trị mặc định cho dt_ngaysx khi giá trị null hoặc rỗng
                        dt_ngaysx.Value = DateTime.Now;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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
            bool trangthai = rdo_conhang.Checked;
            DateOnly ngaysx = DateOnly.FromDateTime(dt_ngaysx.Value);
            int idInt = int.Parse(id);
            decimal giaInt = decimal.Parse(gia);
            decimal giadecimal = decimal.Parse(gia);
            txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            int soluongInt = int.Parse(soluongtonkho);
            DialogResult result = MessageBox.Show("bạn có muốn sửa không?", "sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _sanPhamService.CNSua(idInt, ten, tenthuonghieu, mota, giadecimal, soluongInt, kichthuoc, mausac, trangthai, ngaysx);
                MessageBox.Show(kq);
                loadsanpham();

                return;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txt_IDsanpham.Text = "";
                txt_tensanpham.Text = "";
                txt_tenthuonghieu.Text = "";
                txt_soluong.Text = "";
                txt_mausac.Text = "";
                txt_gia.Text = "";
                txt_kichthuoc.Text = "";
                rdo_conhang.Checked = false;
                rtb_mota.Text = "";

                txt_phantramgiam.Text = "";
                txt_giagiam.Text = "";
                dt_ngaybd.Text = "";
                dt_ngaykt.Text = "";
            }



        }

        private void txt_tensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }
        private void RemoveExpiredProducts()
        {
            _spggrep.RemoveExpiredProducts();
        }
        private void loadsanphamgiamgia()
        {
            // Cập nhật DataGridView với danh sách sản phẩm còn hạn
            List<SanPhamGiamGium> sanPhamGiamGia = _spggrep.GetAll();
            dtg_SPGG.DataSource = sanPhamGiamGia;
        }
        private void grp_giamgia_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_giamgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }



        private void grb_SanPham_Enter(object sender, EventArgs e)
        {

        }


        private void cbb_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataGridView()
        {

        }
        private void RemoveUnwantedColumns()
        {
            if (dgv_sanpham.Columns["DanhGia"] != null) dgv_sanpham.Columns.Remove("DanhGia");
            if (dgv_sanpham.Columns["ChiTietDonHangs"] != null) dgv_sanpham.Columns.Remove("ChiTietDonHangs");
            if (dgv_sanpham.Columns["HoaDonChiTiets"] != null) dgv_sanpham.Columns.Remove("HoaDonChiTiets");
            if (dgv_sanpham.Columns["KhoHangs"] != null) dgv_sanpham.Columns.Remove("KhoHangs");
        }

        private void LoadComboBox(List<SanPham> sanPhams)
        {


            cbb_IDsp.DataSource = sanPhams;
            cbb_IDsp.DisplayMember = "SanPhamId"; // Tên cột hiển thị
            cbb_IDsp.ValueMember = "SanPhamId"; // Tên cột giá trị

            cbb_TenSP.DataSource = sanPhams;
            cbb_TenSP.DisplayMember = "TenSanPham"; // Tên cột hiển thị
            cbb_TenSP.ValueMember = "SanPhamId"; // Tên cột giá trị

            cbb_Tenthuonghieu.DataSource = sanPhams;
            cbb_Tenthuonghieu.DisplayMember = "TenThuongHieu"; // Tên cột hiển thị
            cbb_Tenthuonghieu.ValueMember = "SanPhamId"; // Tên cột giá trị
        }

        private void cbb_Tenthuonghieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtg_SPGG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtg_SPGG.CurrentCell.ColumnIndex > 0)
                {
                    int row = dtg_SPGG.CurrentRow.Index;

                    txt_IDsanpham.Text = dtg_SPGG.Rows[row].Cells[0].Value.ToString();
                    txt_tensanpham.Text = dtg_SPGG.Rows[row].Cells[1].Value.ToString();
                    txt_gia.Text = dtg_SPGG.Rows[row].Cells[2].Value.ToString();
                    txt_phantramgiam.Text = dtg_SPGG.Rows[row].Cells[3].Value.ToString();
                    txt_giagiam.Text = dtg_SPGG.Rows[row].Cells[4].Value.ToString();

                    object cellValue = dtg_SPGG.Rows[row].Cells[5].Value;

                    if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        DateTime dtNgayBD;
                        bool isParsed = DateTime.TryParse(cellValue.ToString(), out dtNgayBD);

                        if (isParsed)
                        {
                            dt_ngaybd.Value = dtNgayBD;
                        }
                        else
                        {
                            MessageBox.Show("Giá trị của ô ngày sản xuất không hợp lệ. Không thể chuyển đổi sang DateTime.");
                            // Đặt giá trị mặc định cho dt_ngaysx nếu cần
                            dt_ngaybd.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        // Đặt giá trị mặc định cho dt_ngaysx khi giá trị null hoặc rỗng
                        dt_ngaybd.Value = DateTime.Now;
                    }
                    object cellValue2 = dtg_SPGG.Rows[row].Cells[6].Value;

                    if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue2.ToString()))
                    {
                        DateTime dtNgayKT;
                        bool isParsed = DateTime.TryParse(cellValue.ToString(), out dtNgayKT);

                        if (isParsed)
                        {
                            dt_ngaykt.Value = dtNgayKT;
                        }
                        else
                        {
                            MessageBox.Show("Giá trị của ô ngày sản xuất không hợp lệ. Không thể chuyển đổi sang DateTime.");
                            // Đặt giá trị mặc định cho dt_ngaysx nếu cần
                            dt_ngaykt.Value = DateTime.Now;
                        }
                    }
                    else
                    {
                        // Đặt giá trị mặc định cho dt_ngaysx khi giá trị null hoặc rỗng
                        dt_ngaykt.Value = DateTime.Now;
                    }


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_taoqr_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(txt_IDsanpham.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(qr1);
            pictureBox1.Image = code.GetGraphic(7);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maspgg = txt_IDsanpham.Text;
            string tenspgg = txt_tensanpham.Text;
            string phantramgiam = txt_phantramgiam.Text;
            string gia = txt_gia.Text;
            string giagiam = txt_giagiam.Text;
            string motaspgg = rtb_mota.Text;
            DateOnly ngaybd = DateOnly.FromDateTime(dt_ngaybd.Value);
            DateOnly ngaykt = DateOnly.FromDateTime(dt_ngaykt.Value);
            DateTime startDate = dt_ngaybd.Value;
            DateTime endDate = dt_ngaykt.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Bạn có thể thêm các hành động khác nếu muốn, ví dụ như reset ngày bắt đầu về ngày kết thúc
                dt_ngaybd.Value = endDate;
            }
            else
            {
                MessageBox.Show("Ngày hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thực hiện các hành động khác nếu cần
            }
            int maInt = int.Parse(maspgg);
            decimal giadecimal = decimal.Parse(gia);
            decimal phantramgiamdcl = decimal.Parse(phantramgiam);
            decimal giagiamdcl = decimal.Parse(giagiam);
            txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            txt_phantramgiam.Text = phantramgiamdcl.ToString("F2");
            txt_giagiam.Text = giagiamdcl.ToString("F2");
            DialogResult result = MessageBox.Show("bạn có muốn thêm không?", "thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _spgiamgia.CNthem(maInt, tenspgg, giadecimal, phantramgiamdcl, giagiamdcl, ngaybd, ngaykt, motaspgg);
                MessageBox.Show(kq);
                loadgg();
                ; return;
            }
        }

        private void btn_suaspgg_Click(object sender, EventArgs e)
        {
            string maspgg = txt_IDsanpham.Text;
            string tenspgg = txt_tensanpham.Text;
            string phantramgiam = txt_phantramgiam.Text;
            string gia = txt_gia.Text;
            string giagiam = txt_giagiam.Text;
            string motaspgg = rtb_mota.Text;
            DateOnly ngaybd = DateOnly.FromDateTime(dt_ngaybd.Value);
            DateOnly ngaykt = DateOnly.FromDateTime(dt_ngaykt.Value);
            int maInt = int.Parse(maspgg);
            decimal giadecimal = decimal.Parse(gia);
            decimal phantramgiamdcl = decimal.Parse(phantramgiam);
            decimal giagiamdcl = decimal.Parse(giagiam);
            txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            txt_phantramgiam.Text = phantramgiamdcl.ToString("F2");
            txt_giagiam.Text = giagiamdcl.ToString("F2");
            DialogResult result = MessageBox.Show("bạn có muốn Sửa không?", "thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _spgiamgia.CNSua(maInt, tenspgg, giadecimal, phantramgiamdcl, giagiamdcl, ngaybd, ngaykt, motaspgg);
                MessageBox.Show(kq);
                loadgg();
                ; return;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            RemoveExpiredProducts();
            // Tải lại dữ liệu
            loadsanphamgiamgia();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            List<SanPham> sanPhams = _sanPhamService.CNtim(txt_timkiem.Text);

            dgv_sanpham.DataSource = sanPhams;
        }

        private void rdo_hethang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_conhang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

