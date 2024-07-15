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

namespace PRL
{
    public partial class FormSanPham : Form
    {
        SanPhamService  _sanPhamService = new SanPhamService();
        SanPhamRep _sanPhamRep = new SanPhamRep();

        public FormSanPham()
        {
            InitializeComponent();
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
