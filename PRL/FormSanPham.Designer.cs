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
            btn_timkiem = new Button();
            txt_search = new TextBox();
            dgv_sanpham = new DataGridView();
            label5 = new Label();
            grb_SanPham = new GroupBox();
            btn_Del = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grp_giamgia = new GroupBox();
            dtg_SPGG = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            btn_sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            grb_SanPham.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grp_giamgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_SPGG).BeginInit();
            SuspendLayout();
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.Gold;
            btn_sua.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_sua.Image = Properties.Resources.icons8_save_30;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(130, 93);
            btn_sua.Name = "btn_sua";
            btn_sua.RightToLeft = RightToLeft.No;
            btn_sua.Size = new Size(123, 54);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 93);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(403, 44);
            label3.Name = "label3";
            label3.Size = new Size(138, 22);
            label3.TabIndex = 0;
            label3.Text = "Tên thương hiệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(809, 117);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 1;
            label4.Text = "Mô tả";
            // 
            // txt_IDsanpham
            // 
            txt_IDsanpham.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_IDsanpham.Location = new Point(141, 39);
            txt_IDsanpham.Name = "txt_IDsanpham";
            txt_IDsanpham.Size = new Size(230, 27);
            txt_IDsanpham.TabIndex = 2;
            // 
            // txt_tensanpham
            // 
            txt_tensanpham.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tensanpham.Location = new Point(141, 88);
            txt_tensanpham.Name = "txt_tensanpham";
            txt_tensanpham.Size = new Size(230, 27);
            txt_tensanpham.TabIndex = 3;
            txt_tensanpham.TextChanged += txt_tensanpham_TextChanged;
            // 
            // txt_tenthuonghieu
            // 
            txt_tenthuonghieu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tenthuonghieu.Location = new Point(547, 39);
            txt_tenthuonghieu.Name = "txt_tenthuonghieu";
            txt_tenthuonghieu.Size = new Size(230, 27);
            txt_tenthuonghieu.TabIndex = 4;
            // 
            // rtb_mota
            // 
            rtb_mota.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_mota.Location = new Point(871, 15);
            rtb_mota.Name = "rtb_mota";
            rtb_mota.Size = new Size(212, 193);
            rtb_mota.TabIndex = 5;
            rtb_mota.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 143);
            label6.Name = "label6";
            label6.Size = new Size(142, 22);
            label6.TabIndex = 7;
            label6.Text = "Số lượng tồn kho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 142);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 8;
            label7.Text = "Kích thước";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 181);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 9;
            label8.Text = "Màu sắc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(403, 186);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái";
            // 
            // txt_soluong
            // 
            txt_soluong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soluong.Location = new Point(141, 142);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(230, 27);
            txt_soluong.TabIndex = 11;
            // 
            // txt_kichthuoc
            // 
            txt_kichthuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_kichthuoc.Location = new Point(542, 141);
            txt_kichthuoc.Name = "txt_kichthuoc";
            txt_kichthuoc.Size = new Size(230, 27);
            txt_kichthuoc.TabIndex = 12;
            // 
            // txt_mausac
            // 
            txt_mausac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_mausac.Location = new Point(141, 181);
            txt_mausac.Name = "txt_mausac";
            txt_mausac.Size = new Size(230, 27);
            txt_mausac.TabIndex = 13;
            // 
            // txt_trangthai
            // 
            txt_trangthai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_trangthai.Location = new Point(542, 185);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(230, 27);
            txt_trangthai.TabIndex = 14;
            // 
            // txt_gia
            // 
            txt_gia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_gia.Location = new Point(542, 93);
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
            btn_them.Location = new Point(130, 27);
            btn_them.Name = "btn_them";
            btn_them.RightToLeft = RightToLeft.No;
            btn_them.Size = new Size(123, 54);
            btn_them.TabIndex = 16;
            btn_them.Text = "Thêm";
            btn_them.UseMnemonic = false;
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_timkiem
            // 
            btn_timkiem.BackColor = Color.LightGray;
            btn_timkiem.Enabled = false;
            btn_timkiem.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_timkiem.ForeColor = Color.Chocolate;
            btn_timkiem.Image = Properties.Resources.icons8_search_30;
            btn_timkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timkiem.Location = new Point(931, 306);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(229, 29);
            btn_timkiem.TabIndex = 19;
            btn_timkiem.Text = "Tìm kiếm theo tên";
            btn_timkiem.UseVisualStyleBackColor = false;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(1166, 306);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(401, 27);
            txt_search.TabIndex = 20;
            txt_search.TextChanged += textBox9_TextChanged;
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(6, 55);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.RowHeadersWidth = 51;
            dgv_sanpham.Size = new Size(1161, 389);
            dgv_sanpham.TabIndex = 21;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(412, 93);
            label5.Name = "label5";
            label5.Size = new Size(35, 22);
            label5.TabIndex = 22;
            label5.Text = "Giá";
            // 
            // grb_SanPham
            // 
            grb_SanPham.CausesValidation = false;
            grb_SanPham.Controls.Add(dgv_sanpham);
            grb_SanPham.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grb_SanPham.Location = new Point(6, 359);
            grb_SanPham.Name = "grb_SanPham";
            grb_SanPham.Size = new Size(790, 504);
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
            btn_Del.Location = new Point(132, 169);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(121, 54);
            btn_Del.TabIndex = 24;
            btn_Del.Text = "Clear";
            btn_Del.UseVisualStyleBackColor = false;
            btn_Del.Click += btn_Del_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_tenthuonghieu);
            groupBox1.Controls.Add(txt_mausac);
            groupBox1.Controls.Add(txt_gia);
            groupBox1.Controls.Add(txt_soluong);
            groupBox1.Controls.Add(txt_kichthuoc);
            groupBox1.Controls.Add(txt_tensanpham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_IDsanpham);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_trangthai);
            groupBox1.Controls.Add(rtb_mota);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1108, 273);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Fuchsia;
            groupBox2.Controls.Add(btn_Del);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Font = new Font("Snap ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1166, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 273);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // grp_giamgia
            // 
            grp_giamgia.Controls.Add(dtg_SPGG);
            grp_giamgia.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grp_giamgia.Location = new Point(845, 359);
            grp_giamgia.Name = "grp_giamgia";
            grp_giamgia.Size = new Size(722, 504);
            grp_giamgia.TabIndex = 27;
            grp_giamgia.TabStop = false;
            grp_giamgia.Text = "Các sản phẩm giảm giá";
            grp_giamgia.Enter += grp_giamgia_Enter;
            // 
            // dtg_SPGG
            // 
            dtg_SPGG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SPGG.Location = new Point(6, 55);
            dtg_SPGG.Name = "dtg_SPGG";
            dtg_SPGG.RowHeadersWidth = 51;
            dtg_SPGG.Size = new Size(710, 389);
            dtg_SPGG.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(502, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(728, 325);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 29;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(291, 325);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(53, 323);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 31;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 875);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(grp_giamgia);
            Controls.Add(txt_search);
            Controls.Add(btn_timkiem);
            Controls.Add(grb_SanPham);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            grb_SanPham.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            grp_giamgia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_SPGG).EndInit();
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
        private Button btn_timkiem;
        private TextBox txt_search;
        private DataGridView dgv_sanpham;
        private Label label5;
        private GroupBox grb_SanPham;
        private Button btn_Del;
        public Button btn_them;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox grp_giamgia;
        private DataGridView dtg_SPGG;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}