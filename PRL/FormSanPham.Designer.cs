namespace PRL
{
    partial class FormSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btn_sua;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_IDsanpham = new TextBox();
            txt_tensanpham = new TextBox();
            txt_tenthuonghieu = new TextBox();
            rtb_mota = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_soluong = new TextBox();
            txt_kichthuoc = new TextBox();
            txt_mausac = new TextBox();
            txt_trangthai = new TextBox();
            txt_gia = new TextBox();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_timkiem = new Button();
            txt_search = new TextBox();
            dgv_sanpham = new DataGridView();
            label5 = new Label();
            grb_SanPham = new GroupBox();
            btn_Del = new Button();
            btn_sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            grb_SanPham.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.Gold;
            btn_sua.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_sua.Image = Properties.Resources.icons8_save_30;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(247, 291);
            btn_sua.Name = "btn_sua";
            btn_sua.RightToLeft = RightToLeft.No;
            btn_sua.Size = new Size(112, 54);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 101);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(572, 51);
            label3.Name = "label3";
            label3.Size = new Size(138, 22);
            label3.TabIndex = 0;
            label3.Text = "Tên thương hiệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(1000, 125);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 1;
            label4.Text = "Mô tả";
            // 
            // txt_IDsanpham
            // 
            txt_IDsanpham.Location = new Point(186, 44);
            txt_IDsanpham.Name = "txt_IDsanpham";
            txt_IDsanpham.Size = new Size(230, 27);
            txt_IDsanpham.TabIndex = 2;
            // 
            // txt_tensanpham
            // 
            txt_tensanpham.Location = new Point(186, 94);
            txt_tensanpham.Name = "txt_tensanpham";
            txt_tensanpham.Size = new Size(230, 27);
            txt_tensanpham.TabIndex = 3;
            txt_tensanpham.TextChanged += txt_tensanpham_TextChanged;
            // 
            // txt_tenthuonghieu
            // 
            txt_tenthuonghieu.Location = new Point(738, 44);
            txt_tenthuonghieu.Name = "txt_tenthuonghieu";
            txt_tenthuonghieu.Size = new Size(230, 27);
            txt_tenthuonghieu.TabIndex = 4;
            // 
            // rtb_mota
            // 
            rtb_mota.Location = new Point(1062, 51);
            rtb_mota.Name = "rtb_mota";
            rtb_mota.Size = new Size(354, 193);
            rtb_mota.TabIndex = 5;
            rtb_mota.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 158);
            label6.Name = "label6";
            label6.Size = new Size(142, 22);
            label6.TabIndex = 7;
            label6.Text = "Số lượng tồn kho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(572, 160);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 8;
            label7.Text = "Kích thước";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 213);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 9;
            label8.Text = "Màu sắc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(572, 217);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(186, 153);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(230, 27);
            txt_soluong.TabIndex = 11;
            // 
            // txt_kichthuoc
            // 
            txt_kichthuoc.Location = new Point(738, 153);
            txt_kichthuoc.Name = "txt_kichthuoc";
            txt_kichthuoc.Size = new Size(230, 27);
            txt_kichthuoc.TabIndex = 12;
            // 
            // txt_mausac
            // 
            txt_mausac.Location = new Point(186, 210);
            txt_mausac.Name = "txt_mausac";
            txt_mausac.Size = new Size(230, 27);
            txt_mausac.TabIndex = 13;
            // 
            // txt_trangthai
            // 
            txt_trangthai.Location = new Point(738, 210);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(230, 27);
            txt_trangthai.TabIndex = 14;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(738, 98);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(230, 27);
            txt_gia.TabIndex = 15;
            // 
            // btn_them
            // 
            btn_them.AutoEllipsis = true;
            btn_them.BackColor = Color.Blue;
            btn_them.BackgroundImageLayout = ImageLayout.None;
            btn_them.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_them.Image = Properties.Resources.icons8_new_page_24;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(12, 291);
            btn_them.Name = "btn_them";
            btn_them.RightToLeft = RightToLeft.No;
            btn_them.Size = new Size(123, 54);
            btn_them.TabIndex = 16;
            btn_them.Text = "Thêm";
            btn_them.UseMnemonic = false;
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.Red;
            btn_xoa.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_xoa.Image = Properties.Resources.icons8_trash_can_50;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(496, 291);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(111, 54);
            btn_xoa.TabIndex = 18;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_timkiem
            // 
            btn_timkiem.BackColor = Color.LightGray;
            btn_timkiem.Enabled = false;
            btn_timkiem.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_timkiem.ForeColor = Color.Chocolate;
            btn_timkiem.Image = Properties.Resources.icons8_search_30;
            btn_timkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timkiem.Location = new Point(507, 392);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(229, 29);
            btn_timkiem.TabIndex = 19;
            btn_timkiem.Text = "Tìm kiếm theo tên";
            btn_timkiem.UseVisualStyleBackColor = false;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(12, 394);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(472, 27);
            txt_search.TabIndex = 20;
            txt_search.TextChanged += textBox9_TextChanged;
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(6, 26);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.RowHeadersWidth = 51;
            dgv_sanpham.Size = new Size(1611, 384);
            dgv_sanpham.TabIndex = 21;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(572, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 22);
            label5.TabIndex = 22;
            label5.Text = "Giá";
            // 
            // grb_SanPham
            // 
            grb_SanPham.Controls.Add(dgv_sanpham);
            grb_SanPham.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grb_SanPham.Location = new Point(6, 447);
            grb_SanPham.Name = "grb_SanPham";
            grb_SanPham.Size = new Size(1617, 416);
            grb_SanPham.TabIndex = 23;
            grb_SanPham.TabStop = false;
            grb_SanPham.Text = "Danh sách sản phẩm";
            // 
            // btn_Del
            // 
            btn_Del.BackColor = Color.LawnGreen;
            btn_Del.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Del.Image = Properties.Resources.icons8_clear_50;
            btn_Del.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Del.Location = new Point(716, 291);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(121, 54);
            btn_Del.TabIndex = 24;
            btn_Del.Text = "Clear";
            btn_Del.UseVisualStyleBackColor = false;
            btn_Del.Click += btn_Del_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 875);
            Controls.Add(btn_Del);
            Controls.Add(label5);
            Controls.Add(txt_search);
            Controls.Add(btn_timkiem);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(txt_gia);
            Controls.Add(txt_trangthai);
            Controls.Add(txt_mausac);
            Controls.Add(txt_kichthuoc);
            Controls.Add(txt_soluong);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(rtb_mota);
            Controls.Add(txt_tenthuonghieu);
            Controls.Add(txt_tensanpham);
            Controls.Add(txt_IDsanpham);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grb_SanPham);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            grb_SanPham.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_IDsanpham;
        private TextBox txt_tensanpham;
        private TextBox txt_tenthuonghieu;
        private RichTextBox rtb_mota;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_soluong;
        private TextBox txt_kichthuoc;
        private TextBox txt_mausac;
        private TextBox txt_trangthai;
        private TextBox txt_gia;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_timkiem;
        private TextBox txt_search;
        private DataGridView dgv_sanpham;
        private Label label5;
        private GroupBox grb_SanPham;
        private Button btn_Del;
        public Button btn_them;
    }
}