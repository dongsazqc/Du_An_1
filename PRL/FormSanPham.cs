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

        public FormSanPham()
        {
            InitializeComponent();

            loadsanpham();
            List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
            Loaddata(sanPhamGiamGia);
            loadsanpham();
            ConfigureDataGridView();

        }
        private void ConfigureDataGridView()
        {
            // Xóa các cột không mong muốn khi cấu hình DataGridView
            RemoveUnwantedColumns();
        } private void loadsanpham()
        {
            List<SanPham> sp = _sanPhamService.CNShow();
            showdata(sp);
            LoadComboBox(sp);
            dgv_sanpham.DataSource = sp;
            List<SanPham> sanPhams = _sanPhamService.CNShow();
            showdata(sanPhams);
            RemoveUnwantedColumns();

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
<<<<<<< HEAD
            decimal giadecimal = decimal.Parse(gia);
            txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
=======
            decimal giaInt = decimal.Parse(gia);
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
            int soluongInt = int.Parse(soluongtonkho);
            DialogResult result = MessageBox.Show("bạn có muốn thêm không?", "thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _sanPhamService.CNthem(idInt, ten, tenthuonghieu, mota, giadecimal, soluongInt, kichthuoc, mausac, trangthai);
                MessageBox.Show(kq);
                loadsanpham();

                return;
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
            // lấy dữ liệu ra từ dòng được chọn để fill lên form
            int row = e.RowIndex;
            var rowdata = dgv_sanpham.Rows[row];
            txt_IDsanpham.Text = rowdata.Cells["SanPhamId"].Value.ToString();
            txt_tensanpham.Text = rowdata.Cells["TenSanPham"].Value.ToString();
            txt_tenthuonghieu.Text = rowdata.Cells["TenThuongHieu"].Value.ToString();
            rtb_mota.Text = rowdata.Cells["MoTa"].Value.ToString();
            txt_gia.Text = rowdata.Cells["Gia"].Value.ToString();
            txt_soluong.Text = rowdata.Cells["SoLuongTonKho"].Value.ToString();
            txt_kichthuoc.Text = rowdata.Cells["KichThuoc"].Value.ToString();
            txt_mausac.Text = rowdata.Cells["MauSac"].Value.ToString();
            txt_trangthai.Text = rowdata.Cells["TrangThai"].Value.ToString();
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
<<<<<<< HEAD
            decimal giaInt = decimal.Parse(gia);
=======
            decimal giadecimal = decimal.Parse(gia);
            txt_gia.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
>>>>>>> 8ef5c852a648acb2b12a9e16a9ba7e9778647207
            int soluongInt = int.Parse(soluongtonkho);
            DialogResult result = MessageBox.Show("bạn có muốn sửa không?", "sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _sanPhamService.CNSua(idInt, ten, tenthuonghieu, mota, giadecimal, soluongInt, kichthuoc, mausac, trangthai);
                MessageBox.Show(kq);
                loadsanpham();

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

            txt_phantramgiam.Text = "";
            txt_giagiam.Text = "";
            dt_ngaybd.Text = "";
            dt_ngaykt.Text = "";



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
            if (cbb_IDsp.SelectedValue != null && int.TryParse(cbb_IDsp.SelectedValue.ToString(), out int sanphamID))
            {
                // Kiểm tra giá trị SelectedValue


                var sanphams = _sanPhamRep.GetAll();

                // Kiểm tra danh sách sản phẩm trả về từ repository
                if (sanphams == null || !sanphams.Any())
                {
                    dgv_sanpham.DataSource = null;
                    return;
                }

                var sanpham = sanphams.FirstOrDefault(k => k.SanPhamId == sanphamID);

                if (sanpham != null)
                {
                    dgv_sanpham.DataSource = new List<SanPham> { sanpham };

                    dgv_sanpham.Refresh();
                }
                else
                {

                    dgv_sanpham.DataSource = null;
                }
                RemoveUnwantedColumns();
            }
            else
            {

                dgv_sanpham.DataSource = null;
            }
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
            int row = e.RowIndex;
            var rowdata = dtg_SPGG.Rows[row];
            txt_IDsanpham.Text = rowdata.Cells[1].Value.ToString();
            txt_tensanpham.Text = rowdata.Cells[2].Value.ToString();
            txt_gia.Text = rowdata.Cells[3].Value.ToString();
            txt_giagiam.Text = rowdata.Cells[5].Value.ToString();
            rtb_mota.Text = rowdata.Cells[8].Value.ToString();

            txt_phantramgiam.Text = rowdata.Cells[4].Value.ToString();
            dt_ngaybd.Text = rowdata.Cells[6].Value.ToString();
            dt_ngaykt.Text = rowdata.Cells[7].Value.ToString();
            string today = DateTime.Now.ToString();

            // Gán giá trị ngày vào TextBox
            dt_ngaybd.Text = today;
            dt_ngaykt.Text = today;
        }

        private void btn_taoqr_Click(object sender, EventArgs e)
        {
            // tạo qr code
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(txt_tensanpham.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(qr1);
            pictureBox1.Image = code.GetGraphic(6, Color.Black, Color.White, true);

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
                string kq = _spgiamgia.CNthem(maInt, tenspgg, giadecimal, phantramgiamdcl, giagiamdcl, motaspgg);
                MessageBox.Show(kq);
                List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
                Loaddata(sanPhamGiamGia);
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
                string kq = _spgiamgia.CNSua(maInt, tenspgg, giadecimal, phantramgiamdcl, giagiamdcl, motaspgg);
                MessageBox.Show(kq);
                List<SanPhamGiamGium> sanPhamGiamGia = _spgiamgia.CNShow();
                Loaddata(sanPhamGiamGia);
                ; return;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

