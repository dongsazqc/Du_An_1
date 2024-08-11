using BUS.Service;
using DAL.Models;
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

namespace PRL
{

    public partial class Voucher : Form
    {
        BUS.Service.KhuyenMaiServies _voucherServices = new BUS.Service.KhuyenMaiServies();

        KhuyenMaiRep _repo = new KhuyenMaiRep();
        public Voucher() 
        {

            InitializeComponent();
           
        }
        private void load()
        {
        }
        

        private void Voucher_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_voucher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void txt_tenthuonghieuvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phantramvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_themvoucher_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_suavoucher_Click(object sender, EventArgs e)
        {
          
        }


        private void cbb_mavoucher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
       
        private void dt_ngaybd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}