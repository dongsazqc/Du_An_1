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
            dgv_sanpham = new DataGridView();
            label5 = new Label();
            grb_SanPham = new GroupBox();
            btn_Del = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            dt_ngaykt = new DateTimePicker();
            dt_ngaybd = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            txt_giagiam = new TextBox();
            txt_phantramgiam = new TextBox();
            label11 = new Label();
            label10 = new Label();
            grp_giamgia = new GroupBox();
            dtg_SPGG = new DataGridView();
            cbb_Tenthuonghieu = new ComboBox();
            cbb_TenSP = new ComboBox();
            cbb_IDsp = new ComboBox();
            btn_taoqr = new Button();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            btn_suaspgg = new Button();
            button1 = new Button();
            btn_sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            grb_SanPham.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grp_giamgia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_SPGG).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sua
            // 
            btn_sua.BackColor = SystemColors.ButtonHighlight;
            btn_sua.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btn_sua.Image = Properties.Resources.icons8_save_30;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(239, 31);
            btn_sua.Name = "btn_sua";
            btn_sua.RightToLeft = RightToLeft.No;
            btn_sua.Size = new Size(112, 63);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 63);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 0;
            label1.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 136);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 63);
            label3.Name = "label3";
            label3.Size = new Size(138, 22);
            label3.TabIndex = 0;
            label3.Text = "Tên thương hiệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(827, 114);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 1;
            label4.Text = "Mô tả";
            // 
            // txt_IDsanpham
            // 
            txt_IDsanpham.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_IDsanpham.Location = new Point(154, 58);
            txt_IDsanpham.Name = "txt_IDsanpham";
            txt_IDsanpham.Size = new Size(230, 27);
            txt_IDsanpham.TabIndex = 2;
            // 
            // txt_tensanpham
            // 
            txt_tensanpham.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tensanpham.Location = new Point(153, 136);
            txt_tensanpham.Name = "txt_tensanpham";
            txt_tensanpham.Size = new Size(230, 27);
            txt_tensanpham.TabIndex = 3;
            txt_tensanpham.TextChanged += txt_tensanpham_TextChanged;
            // 
            // txt_tenthuonghieu
            // 
            txt_tenthuonghieu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tenthuonghieu.Location = new Point(562, 58);
            txt_tenthuonghieu.Name = "txt_tenthuonghieu";
            txt_tenthuonghieu.Size = new Size(249, 27);
            txt_tenthuonghieu.TabIndex = 4;
            // 
            // rtb_mota
            // 
            rtb_mota.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_mota.Location = new Point(889, 19);
            rtb_mota.Name = "rtb_mota";
            rtb_mota.Size = new Size(197, 213);
            rtb_mota.TabIndex = 5;
            rtb_mota.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 206);
            label6.Name = "label6";
            label6.Size = new Size(142, 22);
            label6.TabIndex = 7;
            label6.Text = "Số lượng tồn kho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(431, 205);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 8;
            label7.Text = "Kích thước";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 277);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 9;
            label8.Text = "Màu sắc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(433, 277);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 10;
            label9.Text = "Trạng thái";
            // 
            // txt_soluong
            // 
            txt_soluong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_soluong.Location = new Point(154, 205);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(230, 27);
            txt_soluong.TabIndex = 11;
            // 
            // txt_kichthuoc
            // 
            txt_kichthuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_kichthuoc.Location = new Point(564, 200);
            txt_kichthuoc.Name = "txt_kichthuoc";
            txt_kichthuoc.Size = new Size(247, 27);
            txt_kichthuoc.TabIndex = 12;
            // 
            // txt_mausac
            // 
            txt_mausac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_mausac.Location = new Point(153, 272);
            txt_mausac.Name = "txt_mausac";
            txt_mausac.Size = new Size(230, 27);
            txt_mausac.TabIndex = 13;
            // 
            // txt_trangthai
            // 
            txt_trangthai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_trangthai.Location = new Point(562, 272);
            txt_trangthai.Name = "txt_trangthai";
            txt_trangthai.Size = new Size(247, 27);
            txt_trangthai.TabIndex = 14;
            // 
            // txt_gia
            // 
            txt_gia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_gia.Location = new Point(562, 136);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(247, 27);
            txt_gia.TabIndex = 15;
            // 
            // btn_them
            // 
            btn_them.AutoEllipsis = true;
            btn_them.BackColor = Color.White;
            btn_them.BackgroundImageLayout = ImageLayout.None;
            btn_them.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_them.Image = Properties.Resources.icons8_new_page_24;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(54, 29);
            btn_them.Name = "btn_them";
            btn_them.RightToLeft = RightToLeft.No;
            btn_them.Size = new Size(110, 65);
            btn_them.TabIndex = 16;
            btn_them.Text = "Thêm";
            btn_them.UseMnemonic = false;
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(15, 28);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.RowHeadersWidth = 51;
            dgv_sanpham.Size = new Size(1203, 231);
            dgv_sanpham.TabIndex = 21;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            dgv_sanpham.CellContentClick += dgv_sanpham_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(468, 141);
            label5.Name = "label5";
            label5.Size = new Size(35, 22);
            label5.TabIndex = 22;
            label5.Text = "Giá";
            label5.Click += label5_Click;
            // 
            // grb_SanPham
            // 
            grb_SanPham.CausesValidation = false;
            grb_SanPham.Controls.Add(dgv_sanpham);
            grb_SanPham.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grb_SanPham.Location = new Point(12, 624);
            grb_SanPham.Name = "grb_SanPham";
            grb_SanPham.Size = new Size(1286, 272);
            grb_SanPham.TabIndex = 23;
            grb_SanPham.TabStop = false;
            grb_SanPham.Text = "Danh sách sản phẩm";
            grb_SanPham.Enter += grb_SanPham_Enter;
            // 
            // btn_Del
            // 
            btn_Del.BackColor = Color.White;
            btn_Del.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            btn_Del.Image = Properties.Resources.icons8_clear_50;
            btn_Del.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Del.Location = new Point(420, 32);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(109, 62);
            btn_Del.TabIndex = 24;
            btn_Del.Text = "Clear";
            btn_Del.UseVisualStyleBackColor = false;
            btn_Del.Click += btn_Del_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dt_ngaykt);
            groupBox1.Controls.Add(dt_ngaybd);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_giagiam);
            groupBox1.Controls.Add(txt_phantramgiam);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1119, 493);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(880, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 217);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // dt_ngaykt
            // 
            dt_ngaykt.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngaykt.Location = new Point(562, 403);
            dt_ngaykt.Name = "dt_ngaykt";
            dt_ngaykt.Size = new Size(247, 26);
            dt_ngaykt.TabIndex = 33;
            // 
            // dt_ngaybd
            // 
            dt_ngaybd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngaybd.Location = new Point(153, 407);
            dt_ngaybd.Name = "dt_ngaybd";
            dt_ngaybd.Size = new Size(249, 26);
            dt_ngaybd.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(433, 407);
            label13.Name = "label13";
            label13.Size = new Size(123, 22);
            label13.TabIndex = 28;
            label13.Text = "Ngày Kết Thúc";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 407);
            label12.Name = "label12";
            label12.Size = new Size(119, 22);
            label12.TabIndex = 27;
            label12.Text = "Ngày Bắt Đầu";
            // 
            // txt_giagiam
            // 
            txt_giagiam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_giagiam.Location = new Point(562, 340);
            txt_giagiam.Name = "txt_giagiam";
            txt_giagiam.Size = new Size(247, 27);
            txt_giagiam.TabIndex = 26;
            // 
            // txt_phantramgiam
            // 
            txt_phantramgiam.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_phantramgiam.Location = new Point(153, 345);
            txt_phantramgiam.Name = "txt_phantramgiam";
            txt_phantramgiam.Size = new Size(249, 27);
            txt_phantramgiam.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(445, 345);
            label11.Name = "label11";
            label11.Size = new Size(81, 22);
            label11.TabIndex = 24;
            label11.Text = "Giá Giảm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 350);
            label10.Name = "label10";
            label10.Size = new Size(141, 22);
            label10.TabIndex = 23;
            label10.Text = "Phần Trăm Giảm";
            // 
            // grp_giamgia
            // 
            grp_giamgia.Controls.Add(dtg_SPGG);
            grp_giamgia.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grp_giamgia.Location = new Point(1137, 12);
            grp_giamgia.Name = "grp_giamgia";
            grp_giamgia.Size = new Size(573, 323);
            grp_giamgia.TabIndex = 27;
            grp_giamgia.TabStop = false;
            grp_giamgia.Text = "Các sản phẩm giảm giá";
            grp_giamgia.Enter += grp_giamgia_Enter;
            // 
            // dtg_SPGG
            // 
            dtg_SPGG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SPGG.Location = new Point(13, 28);
            dtg_SPGG.Name = "dtg_SPGG";
            dtg_SPGG.RowHeadersWidth = 51;
            dtg_SPGG.Size = new Size(547, 251);
            dtg_SPGG.TabIndex = 0;
            dtg_SPGG.CellContentClick += dtg_SPGG_CellContentClick;
            // 
            // cbb_Tenthuonghieu
            // 
            cbb_Tenthuonghieu.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            cbb_Tenthuonghieu.ForeColor = Color.Black;
            cbb_Tenthuonghieu.FormattingEnabled = true;
            cbb_Tenthuonghieu.Location = new Point(573, 43);
            cbb_Tenthuonghieu.Name = "cbb_Tenthuonghieu";
            cbb_Tenthuonghieu.Size = new Size(184, 29);
            cbb_Tenthuonghieu.TabIndex = 28;
            cbb_Tenthuonghieu.Text = "Tên Thương Hiệu";
            cbb_Tenthuonghieu.SelectedIndexChanged += cbb_Tenthuonghieu_SelectedIndexChanged;
            // 
            // cbb_TenSP
            // 
            cbb_TenSP.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            cbb_TenSP.ForeColor = Color.Black;
            cbb_TenSP.FormattingEnabled = true;
            cbb_TenSP.Location = new Point(328, 43);
            cbb_TenSP.Name = "cbb_TenSP";
            cbb_TenSP.Size = new Size(151, 29);
            cbb_TenSP.TabIndex = 30;
            cbb_TenSP.Text = "Tên Sản Phẩm";
            cbb_TenSP.SelectedIndexChanged += cbb_TenSP_SelectedIndexChanged;
            // 
            // cbb_IDsp
            // 
            cbb_IDsp.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            cbb_IDsp.ForeColor = Color.Black;
            cbb_IDsp.FormattingEnabled = true;
            cbb_IDsp.Location = new Point(80, 43);
            cbb_IDsp.Name = "cbb_IDsp";
            cbb_IDsp.Size = new Size(151, 29);
            cbb_IDsp.TabIndex = 31;
            cbb_IDsp.Text = "ID sản phẩm";
            cbb_IDsp.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // btn_taoqr
            // 
            btn_taoqr.AutoEllipsis = true;
            btn_taoqr.BackColor = Color.White;
            btn_taoqr.BackgroundImageLayout = ImageLayout.None;
            btn_taoqr.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_taoqr.ImageAlign = ContentAlignment.MiddleLeft;
            btn_taoqr.Location = new Point(591, 29);
            btn_taoqr.Name = "btn_taoqr";
            btn_taoqr.RightToLeft = RightToLeft.No;
            btn_taoqr.Size = new Size(107, 60);
            btn_taoqr.TabIndex = 25;
            btn_taoqr.Text = "Tạo Qrcode";
            btn_taoqr.UseMnemonic = false;
            btn_taoqr.UseVisualStyleBackColor = false;
            btn_taoqr.Click += btn_taoqr_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.CausesValidation = false;
            groupBox3.Controls.Add(cbb_IDsp);
            groupBox3.Controls.Add(cbb_Tenthuonghieu);
            groupBox3.Controls.Add(cbb_TenSP);
            groupBox3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.Location = new Point(12, 511);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(805, 107);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm Kiếm ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(btn_taoqr);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_Del);
            groupBox2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            groupBox2.Location = new Point(867, 511);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(788, 107);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng sản phẩm";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(btn_suaspgg);
            groupBox4.Controls.Add(button1);
            groupBox4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            groupBox4.Location = new Point(1137, 341);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(547, 140);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thêm Sản Phẩm Giảm giá";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // btn_suaspgg
            // 
            btn_suaspgg.AutoEllipsis = true;
            btn_suaspgg.BackColor = Color.White;
            btn_suaspgg.BackgroundImageLayout = ImageLayout.None;
            btn_suaspgg.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_suaspgg.ImageAlign = ContentAlignment.MiddleLeft;
            btn_suaspgg.Location = new Point(231, 50);
            btn_suaspgg.Name = "btn_suaspgg";
            btn_suaspgg.RightToLeft = RightToLeft.No;
            btn_suaspgg.Size = new Size(110, 65);
            btn_suaspgg.TabIndex = 27;
            btn_suaspgg.Text = "Sửa";
            btn_suaspgg.UseMnemonic = false;
            btn_suaspgg.UseVisualStyleBackColor = false;
            btn_suaspgg.Click += btn_suaspgg_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(27, 50);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(110, 65);
            button1.TabIndex = 26;
            button1.Text = "Thêm ";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 895);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(grp_giamgia);
            Controls.Add(grb_SanPham);
            Controls.Add(groupBox1);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            grb_SanPham.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grp_giamgia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_SPGG).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
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
        private DataGridView dgv_sanpham;
        private Label label5;
        private GroupBox grb_SanPham;
        private Button btn_Del;
        public Button btn_them;
        private GroupBox groupBox1;
        private GroupBox grp_giamgia;
        private DataGridView dtg_SPGG;
        private ComboBox cbb_Tenthuonghieu;
        private ComboBox cbb_TenSP;
        private ComboBox cbb_IDsp;
        private TextBox txt_phantramgiam;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label12;
        public Button btn_taoqr;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private DateTimePicker dt_ngaybd;
        private TextBox txt_giagiam;
        private DateTimePicker dt_ngaykt;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        public Button btn_suaspgg;
        public Button button1;
    }
}