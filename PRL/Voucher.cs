using BUS.Service;
using DAL.Models;
using DAL.Repsitory;
using PRL.Models;
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

namespace PRL
{

    public partial class Voucher : Form
    {
        VoucherService _voucherServices = new VoucherService();

        VoucherRep _repo = new VoucherRep();
        public Voucher() 
        {

            InitializeComponent();
            List<DAL.Models.Voucher> vouchers = _voucherServices.CNShow();
            LoadVoucher(vouchers);
           
        }
        private void load()
        {
             List<DAL.Models.Voucher> vouchers = _voucherServices.CNShow();
        }
        private void LoadVoucher(List<DAL.Models.Voucher> voucherList)
        {
            dgv_voucher.Rows.Clear();
            dgv_voucher.ColumnCount = 9;
            int stt = 1;
            dgv_voucher.Columns[0].HeaderText = "Số thứ tự";
            dgv_voucher.Columns[1].HeaderText = "ID Voucher";
            dgv_voucher.Columns[2].HeaderText = "Tên Voucher";
            dgv_voucher.Columns[3].HeaderText = "Tên Thương Hiệu";
            dgv_voucher.Columns[4].HeaderText = "Phần Trăm Giảm";
            dgv_voucher.Columns[5].HeaderText = "Giá Trị";
            dgv_voucher.Columns[6].HeaderText = "Ngày Bắt Đầu";
            dgv_voucher.Columns[7].HeaderText = "Ngày Kết Thúc";
            dgv_voucher.Columns[8].HeaderText = "Điều Kiện Sử Dụng";
            foreach (var item in voucherList)
            {
                dgv_voucher.Rows.Add(stt++, item.MaVoucher, item.TenVoucher, item.TenThuongHieu, item.PhanTramGiam, item.GiaTri, item.NgayBatDau, item.NgayKetThuc, item.DieuKienSuDung);
            }
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_voucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var rowdata = dgv_voucher.Rows[row];
            txt_mavoucher.Text = rowdata.Cells[1].Value.ToString();
            txt_tenvoucher.Text = rowdata.Cells[2].Value.ToString();
            txt_tenthuonghieuvc.Text = rowdata.Cells[3].Value.ToString();
            txt_phantramvc.Text = rowdata.Cells[4].Value.ToString();
            txt_giatrivc.Text = rowdata.Cells[5].Value.ToString();

            dt_ngaybd.Text = rowdata.Cells[6].Value.ToString();
            dt_ngaykt.Text = rowdata.Cells[7].Value.ToString();
            txt_dieukiensd.Text = rowdata.Cells[8].Value.ToString();
            string today = DateTime.Now.ToString();

            // Gán giá trị ngày vào TextBox
            dt_ngaybd.Text = today;
            dt_ngaykt.Text = today;

        }

        private void txt_tenthuonghieuvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phantramvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txt_mavoucher.Text = "";
                txt_tenvoucher.Text = "";
                txt_tenthuonghieuvc.Text = "";
                txt_phantramvc.Text = "";
                txt_giatrivc.Text = "";
                dt_ngaybd.Text = "";
                dt_ngaykt.Text = "";
                txt_dieukiensd.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_themvoucher_Click(object sender, EventArgs e)
        {
            string idma = txt_mavoucher.Text;
            string ten = txt_tenvoucher.Text;
            string tenthuonghieu = txt_tenthuonghieuvc.Text;
            string phantram = txt_phantramvc.Text;
            string gia = txt_giatrivc.Text;
           
            string dieukien = txt_dieukiensd.Text;


            int idInt = int.Parse(idma);
            // Chuyển đổi các giá trị khác
            decimal giaDcm = decimal.Parse(gia);
            decimal phantramdcm = decimal.Parse(phantram);
            txt_phantramvc.Text = phantramdcm.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            txt_giatrivc.Text = giaDcm.ToString("F2");

            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _voucherServices.CNthem(idInt, ten, tenthuonghieu, giaDcm, phantramdcm,  dieukien);
                MessageBox.Show(kq);
                List<DAL.Models.Voucher> vouchers = _voucherServices.CNShow();
                LoadVoucher(vouchers);
                return;
                

            }
            else
            {
                // Thông báo lỗi nếu dữ liệu không hợp lệ
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường nhập.");
            }
        }

        private void btn_suavoucher_Click(object sender, EventArgs e)
        {
            string idma = txt_mavoucher.Text;
            string ten = txt_tenvoucher.Text;
            string tenthuonghieu = txt_tenthuonghieuvc.Text;
            string phantram = txt_phantramvc.Text;
            string gia = txt_giatrivc.Text;
            string ngaybd = dt_ngaybd.Text;
            string ngaykt = dt_ngaykt.Text;
            string dieukien = txt_dieukiensd.Text;
            int idInt = int.Parse(idma);

            // Chuyển đổi các giá trị khác
            decimal giaDcm = decimal.Parse(gia);
            decimal phantramdcm = decimal.Parse(phantram);
            txt_phantramvc.Text = phantramdcm.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            txt_giatrivc.Text = giaDcm.ToString("F2");
            DialogResult result = MessageBox.Show("Bạn có muốn sửa ?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _voucherServices.CNsua(idInt, ten, tenthuonghieu, giaDcm, phantramdcm, dieukien);
                MessageBox.Show(kq);
                List<DAL.Models.Voucher> vouchers = _voucherServices.CNShow();
                LoadVoucher(vouchers);
                return;
            }
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            // tạo qr code
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(txt_tenvoucher.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(qr1);
            pictureBox1.Image = code.GetGraphic(6, Color.Black, Color.White, true);
        }

        private void cbb_mavoucher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
       
        private void dt_ngaybd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}