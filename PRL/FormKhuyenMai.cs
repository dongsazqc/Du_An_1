using BUS.Service;
using DAL.Models;
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
    public partial class FormKhuyenMai : Form
    {
        KhuyenMaiServies _kmServices = new KhuyenMaiServies();
        public FormKhuyenMai()
        {
            InitializeComponent();
            List<KhuyenMai> khuyenMais = _kmServices.CNShow();
            LoadKm(khuyenMais);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadKm(List<KhuyenMai> khuyenMais)
        {
            dgv_khuyenmai.Rows.Clear();
            dgv_khuyenmai.ColumnCount = 7;
            int stt = 1;
            dgv_khuyenmai.Columns[0].HeaderText = "Số thứ tự";
            dgv_khuyenmai.Columns[1].HeaderText = "ID Khuyến Mãi";
            dgv_khuyenmai.Columns[2].HeaderText = "Tên Khuyến Mãi";
            dgv_khuyenmai.Columns[3].HeaderText = "Mô Tả";
            dgv_khuyenmai.Columns[4].HeaderText = "Giảm Giá";

            dgv_khuyenmai.Columns[5].HeaderText = "Ngày Bắt Đầu";
            dgv_khuyenmai.Columns[6].HeaderText = "Ngày Kết Thúc";

            foreach (var item in khuyenMais)
            {
                dgv_khuyenmai.Rows.Add(stt++, item.KhuyenMaiId, item.TenKhuyenMai, item.MoTa, item.GiamGia, item.NgayBatDau, item.NgayKetThuc);
            }
        }
        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {

        }

        private void dgv_khuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var rowdata = dgv_khuyenmai.Rows[row];
            txt_Idkm.Text = rowdata.Cells[1].Value.ToString();
            txt_tenKm.Text = rowdata.Cells[2].Value.ToString();
            txt_motakm.Text = rowdata.Cells[3].Value.ToString();
            txt_giamgiakm.Text = rowdata.Cells[4].Value.ToString();



            object cellValueNgayBD = dgv_khuyenmai.Rows[row].Cells[5].Value;
            if (cellValueNgayBD != null && DateTime.TryParse(cellValueNgayBD.ToString(), out DateTime ngayBD))
            {
                dt_ngaybdkm.Value = ngayBD;
            }
            else
            {
                dt_ngaybdkm.Value = DateTime.Now; // Giá trị mặc định
            }

            // Kiểm tra và xử lý giá trị ngày kết thúc
            object cellValueNgayKT = dgv_khuyenmai.Rows[row].Cells[6].Value;
            if (cellValueNgayKT != null && DateTime.TryParse(cellValueNgayKT.ToString(), out DateTime ngayKT))
            {
                dt_ngayktkm.Value = ngayKT;
            }
            else
            {
                dt_ngayktkm.Value = DateTime.Now; // Giá trị mặc định
            }
        }

        private void txt_timkiemkm_TextChanged(object sender, EventArgs e)
        {
            List<KhuyenMai> khuyenMais = _kmServices.CNtim(txt_timkiemkm.Text);
            LoadKm(khuyenMais);

        }

        private void btn_themkm_Click(object sender, EventArgs e)
        {
            string idkm = txt_Idkm.Text;
            string tenkm = txt_tenKm.Text;
            
            string mota = txt_motakm.Text;
            string giamgia = txt_giamgiakm.Text;
         
            int idInt = int.Parse(idkm);
            decimal giadecimal = decimal.Parse(giamgia);
            txt_giamgiakm.Text = giadecimal.ToString("F2"); // F2 để định dạng với 2 chữ số thập phân
            

            DialogResult result = MessageBox.Show("bạn có muốn thêm không?", "thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _kmServices.CNthem(idInt, tenkm,  mota, giadecimal);
                MessageBox.Show(kq);
                List<KhuyenMai> khuyenMais = _kmServices.CNShow();
                LoadKm(khuyenMais); 

                return;
            }
        }
    }
}
