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
    public partial class FormSoLuong : Form
    {
        public int SOLUONG { get; private set; }
        public FormSoLuong()
        {
            InitializeComponent();
            this.AcceptButton = btn_Ok;
        }

        public void btn_Ok_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_SoLuong.Text, out int soLuong) && soLuong > 0)
            {
                SOLUONG = soLuong;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormSoLuong_Load(object sender, EventArgs e)
        {

        }
    }
}
