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
using static PRL.FormBanHang;

namespace PRL
{
    public partial class FormHoaDon : Form
    {
        HoaDonService _service = new HoaDonService();
        public FormHoaDon()
        {
            InitializeComponent();
            List<HoaDon> hoaDons = _service.CNShowHoaDon();
            Loaddata(hoaDons);

        }

        private void Loaddata(List<HoaDon> hoaDons)
        {
            dtg_HoaDon.Rows.Clear();
            dtg_HoaDon.ColumnCount =7 ;
            int stt = 1;
            dtg_HoaDon.Columns[0].HeaderText = "Số thứ tự";
            dtg_HoaDon.Columns[1].HeaderText = "Mã hóa đơn";
            dtg_HoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dtg_HoaDon.Columns[3].HeaderText = "Địa chỉ";
            dtg_HoaDon.Columns[4].HeaderText = "Gmail";
            dtg_HoaDon.Columns[5].HeaderText = "Số điện thoại";
            dtg_HoaDon.Columns[6].HeaderText = "Tổng tiền";
            foreach(var item  in hoaDons) 
            {
                dtg_HoaDon.Rows.Add(stt++,item.HoaDonId,item.TenKhachHang,item.DiaChi,item.Gmail,item.SoDienThoai,item.TongTien);
            }


        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }


    }
}
