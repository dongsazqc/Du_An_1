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
        public List<DataGridViewRow> Rows { get; set; }
        public FormHoaDonChiTiet()
        {
            InitializeComponent();
                SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên thương hiệu ";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Giá";
            dataGridView1.Columns[4].HeaderText = "Tổng giá";

        }

        private void FormHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            if (Rows != null && Rows.Any())
            {
                foreach (var row in Rows)
                {
                    dataGridView1.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                }
            }

        }





    }
}
