namespace PRL
{
    partial class FormBanHang
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
            groupBox5 = new GroupBox();
            cbx_HoaDonId = new ComboBox();
            btn_ThanhToan = new Button();
            txt_Gmail = new TextBox();
            txt_DiaChi = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_sđt = new TextBox();
            txt_tenkhachhang = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txt_tongtien = new TextBox();
            lb_TongTien = new Label();
            txt_khachdua = new TextBox();
            txt_Tienthua = new TextBox();
            label12 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txt_voucher = new TextBox();
            label7 = new Label();
            icbtn_TaoHoaDon = new FontAwesome.Sharp.IconButton();
            groupBox4 = new GroupBox();
            icbtn_LamMOI = new FontAwesome.Sharp.IconButton();
            groupBox6 = new GroupBox();
            textBox1 = new TextBox();
            label8 = new Label();
            dtg_HoaDon = new DataGridView();
            pn_ChiTiet = new Panel();
            label9 = new Label();
            btn_Close = new Button();
            dtg_ChiTiet = new DataGridView();
            data_SPBH = new DataGridView();
            txt_timkiemsanpham = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            dtf_GioHang = new DataGridView();
            btn_xoaALLL = new Button();
            btn_XoaSp = new Button();
            groupBox2 = new GroupBox();
            label14 = new Label();
            txt_TimKiemGioHang = new TextBox();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).BeginInit();
            pn_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_SPBH).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtf_GioHang).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbx_HoaDonId);
            groupBox5.Controls.Add(btn_ThanhToan);
            groupBox5.Controls.Add(txt_Gmail);
            groupBox5.Controls.Add(txt_DiaChi);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(txt_sđt);
            groupBox5.Controls.Add(txt_tenkhachhang);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.ForeColor = Color.Red;
            groupBox5.Location = new Point(1452, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(443, 285);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin khách hàng chi tiết";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // cbx_HoaDonId
            // 
            cbx_HoaDonId.ForeColor = Color.Black;
            cbx_HoaDonId.FormattingEnabled = true;
            cbx_HoaDonId.Location = new Point(43, 52);
            cbx_HoaDonId.Name = "cbx_HoaDonId";
            cbx_HoaDonId.Size = new Size(212, 31);
            cbx_HoaDonId.TabIndex = 37;
            cbx_HoaDonId.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 192, 128);
            btn_ThanhToan.Cursor = Cursors.Hand;
            btn_ThanhToan.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ThanhToan.Location = new Point(261, 39);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(152, 47);
            btn_ThanhToan.TabIndex = 35;
            btn_ThanhToan.Text = "Thanh toán hóa đơn";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // txt_Gmail
            // 
            txt_Gmail.ForeColor = Color.Black;
            txt_Gmail.Location = new Point(192, 244);
            txt_Gmail.Name = "txt_Gmail";
            txt_Gmail.Size = new Size(221, 30);
            txt_Gmail.TabIndex = 36;
            txt_Gmail.TextChanged += txt_GiaGoc_TextChanged;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.ForeColor = Color.Black;
            txt_DiaChi.Location = new Point(192, 196);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(221, 30);
            txt_DiaChi.TabIndex = 36;
            txt_DiaChi.TextChanged += txt_GiaGoc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(769, 94);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(518, 135);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 244);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 23;
            label2.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 203);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 23;
            label1.Text = "Địa chỉ";
            // 
            // txt_sđt
            // 
            txt_sđt.ForeColor = Color.Black;
            txt_sđt.Location = new Point(192, 152);
            txt_sđt.Name = "txt_sđt";
            txt_sđt.Size = new Size(221, 30);
            txt_sđt.TabIndex = 2;
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.ForeColor = Color.Black;
            txt_tenkhachhang.Location = new Point(192, 105);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.Size = new Size(221, 30);
            txt_tenkhachhang.TabIndex = 1;
            txt_tenkhachhang.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(43, 159);
            label10.Name = "label10";
            label10.Size = new Size(116, 23);
            label10.TabIndex = 0;
            label10.Text = "Số điện thoại";
            label10.Click += label3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(43, 112);
            label11.Name = "label11";
            label11.Size = new Size(134, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên khách hàng";
            label11.Click += label3_Click;
            // 
            // txt_tongtien
            // 
            txt_tongtien.BorderStyle = BorderStyle.None;
            txt_tongtien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txt_tongtien.ForeColor = Color.Black;
            txt_tongtien.Location = new Point(215, 186);
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(186, 46);
            txt_tongtien.TabIndex = 37;
            txt_tongtien.TextChanged += txt_tongtien_TextChanged_1;
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.BackColor = Color.FromArgb(0, 0, 192);
            lb_TongTien.FlatStyle = FlatStyle.Flat;
            lb_TongTien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_TongTien.ForeColor = Color.Red;
            lb_TongTien.Location = new Point(6, 191);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(215, 41);
            lb_TongTien.TabIndex = 28;
            lb_TongTien.Text = "Tổng hóa đơn";
            lb_TongTien.Click += label6_Click;
            // 
            // txt_khachdua
            // 
            txt_khachdua.ForeColor = Color.Black;
            txt_khachdua.Location = new Point(192, 26);
            txt_khachdua.Name = "txt_khachdua";
            txt_khachdua.Size = new Size(221, 30);
            txt_khachdua.TabIndex = 34;
            // 
            // txt_Tienthua
            // 
            txt_Tienthua.ForeColor = Color.Black;
            txt_Tienthua.Location = new Point(192, 78);
            txt_Tienthua.Name = "txt_Tienthua";
            txt_Tienthua.Size = new Size(221, 30);
            txt_Tienthua.TabIndex = 33;
            txt_Tienthua.TextChanged += txt_TongTien_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(43, 85);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 29;
            label12.Text = "Tiền thừa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 33);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 26;
            label3.Text = "Khách đưa";
            label3.Click += label3_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_tongtien);
            groupBox3.Controls.Add(txt_khachdua);
            groupBox3.Controls.Add(txt_voucher);
            groupBox3.Controls.Add(lb_TongTien);
            groupBox3.Controls.Add(txt_Tienthua);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(1452, 304);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(443, 307);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin thanh toán";
            // 
            // txt_voucher
            // 
            txt_voucher.ForeColor = Color.Black;
            txt_voucher.Location = new Point(192, 127);
            txt_voucher.Name = "txt_voucher";
            txt_voucher.Size = new Size(221, 30);
            txt_voucher.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 134);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 29;
            label7.Text = "Voucher";
            // 
            // icbtn_TaoHoaDon
            // 
            icbtn_TaoHoaDon.BackColor = Color.Lime;
            icbtn_TaoHoaDon.FlatStyle = FlatStyle.Flat;
            icbtn_TaoHoaDon.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            icbtn_TaoHoaDon.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icbtn_TaoHoaDon.ForeColor = SystemColors.ControlText;
            icbtn_TaoHoaDon.IconChar = FontAwesome.Sharp.IconChar.Plus;
            icbtn_TaoHoaDon.IconColor = Color.Black;
            icbtn_TaoHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtn_TaoHoaDon.IconSize = 30;
            icbtn_TaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            icbtn_TaoHoaDon.Location = new Point(35, 93);
            icbtn_TaoHoaDon.Name = "icbtn_TaoHoaDon";
            icbtn_TaoHoaDon.Size = new Size(170, 56);
            icbtn_TaoHoaDon.TabIndex = 37;
            icbtn_TaoHoaDon.Text = "Tạo hóa đơn";
            icbtn_TaoHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbtn_TaoHoaDon.UseVisualStyleBackColor = false;
            icbtn_TaoHoaDon.Click += btn_TaoHoaDon_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(icbtn_LamMOI);
            groupBox4.Controls.Add(icbtn_TaoHoaDon);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.ForeColor = Color.Red;
            groupBox4.Location = new Point(1452, 651);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(443, 212);
            groupBox4.TabIndex = 38;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năg";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // icbtn_LamMOI
            // 
            icbtn_LamMOI.BackColor = Color.Lime;
            icbtn_LamMOI.FlatStyle = FlatStyle.Flat;
            icbtn_LamMOI.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            icbtn_LamMOI.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icbtn_LamMOI.ForeColor = SystemColors.ControlText;
            icbtn_LamMOI.IconChar = FontAwesome.Sharp.IconChar.Plus;
            icbtn_LamMOI.IconColor = Color.Black;
            icbtn_LamMOI.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtn_LamMOI.IconSize = 30;
            icbtn_LamMOI.ImageAlign = ContentAlignment.MiddleLeft;
            icbtn_LamMOI.Location = new Point(261, 93);
            icbtn_LamMOI.Name = "icbtn_LamMOI";
            icbtn_LamMOI.Size = new Size(170, 56);
            icbtn_LamMOI.TabIndex = 39;
            icbtn_LamMOI.Text = "Làm mới";
            icbtn_LamMOI.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbtn_LamMOI.UseVisualStyleBackColor = false;
            icbtn_LamMOI.Click += icbtn_LamMOI_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(dtg_HoaDon);
            groupBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox6.ForeColor = Color.Red;
            groupBox6.Location = new Point(29, 617);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1266, 246);
            groupBox6.TabIndex = 40;
            groupBox6.TabStop = false;
            groupBox6.Text = "DS hóa đơn đã thanh toán";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 27);
            textBox1.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(77, 212);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(276, 20);
            label8.TabIndex = 40;
            label8.Text = "CICK ĐÚP ĐỂ XEM CHI TIẾT HÓA ĐƠN";
            // 
            // dtg_HoaDon
            // 
            dtg_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDon.Location = new Point(77, 67);
            dtg_HoaDon.Name = "dtg_HoaDon";
            dtg_HoaDon.RowHeadersWidth = 51;
            dtg_HoaDon.Size = new Size(1145, 142);
            dtg_HoaDon.TabIndex = 39;
            dtg_HoaDon.CellContentClick += dtg_HoaDon_CellContentClick;
            dtg_HoaDon.CellContentDoubleClick += dtg_HoaDon_CellContentDoubleClick;
            // 
            // pn_ChiTiet
            // 
            pn_ChiTiet.BackColor = Color.FromArgb(255, 192, 128);
            pn_ChiTiet.Controls.Add(label9);
            pn_ChiTiet.Controls.Add(btn_Close);
            pn_ChiTiet.Controls.Add(dtg_ChiTiet);
            pn_ChiTiet.Location = new Point(612, 438);
            pn_ChiTiet.Name = "pn_ChiTiet";
            pn_ChiTiet.Size = new Size(701, 325);
            pn_ChiTiet.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(32, 29);
            label9.Name = "label9";
            label9.Size = new Size(435, 46);
            label9.TabIndex = 2;
            label9.Text = "Thông tin hóa đơn chi tiết";
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.Red;
            btn_Close.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Close.Location = new Point(645, 7);
            btn_Close.Name = "btn_Close";
            btn_Close.RightToLeft = RightToLeft.No;
            btn_Close.Size = new Size(38, 29);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // dtg_ChiTiet
            // 
            dtg_ChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ChiTiet.Location = new Point(32, 94);
            dtg_ChiTiet.Name = "dtg_ChiTiet";
            dtg_ChiTiet.RowHeadersWidth = 51;
            dtg_ChiTiet.Size = new Size(638, 188);
            dtg_ChiTiet.TabIndex = 0;
            // 
            // data_SPBH
            // 
            data_SPBH.BackgroundColor = Color.FromArgb(255, 224, 192);
            data_SPBH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_SPBH.GridColor = Color.FromArgb(192, 192, 0);
            data_SPBH.Location = new Point(6, 81);
            data_SPBH.Name = "data_SPBH";
            data_SPBH.RightToLeft = RightToLeft.No;
            data_SPBH.RowHeadersWidth = 51;
            data_SPBH.Size = new Size(840, 454);
            data_SPBH.TabIndex = 0;
            data_SPBH.CellContentClick += data_SPBH_CellContentClick;
            data_SPBH.CellDoubleClick += data_SPBH_CellDoubleClick;
            // 
            // txt_timkiemsanpham
            // 
            txt_timkiemsanpham.Location = new Point(169, 52);
            txt_timkiemsanpham.Name = "txt_timkiemsanpham";
            txt_timkiemsanpham.Size = new Size(433, 27);
            txt_timkiemsanpham.TabIndex = 20;
            txt_timkiemsanpham.TextChanged += txt_timkiemsanpham_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(6, 538);
            label6.Name = "label6";
            label6.Size = new Size(353, 20);
            label6.TabIndex = 21;
            label6.Text = "CLICK ĐÚP ĐỂ THÊM SẢN PHẨM VÀO GIỎ HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_timkiemsanpham);
            groupBox1.Controls.Add(data_SPBH);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(29, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(852, 598);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.ForeColor = Color.White;
            label13.Location = new Point(64, 55);
            label13.Name = "label13";
            label13.Size = new Size(0, 23);
            label13.TabIndex = 22;
            // 
            // dtf_GioHang
            // 
            dtf_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtf_GioHang.Location = new Point(17, 94);
            dtf_GioHang.Name = "dtf_GioHang";
            dtf_GioHang.RowHeadersWidth = 51;
            dtf_GioHang.Size = new Size(524, 429);
            dtf_GioHang.TabIndex = 0;
            dtf_GioHang.CellContentClick += dtf_GioHang_CellContentClick;
            // 
            // btn_xoaALLL
            // 
            btn_xoaALLL.Location = new Point(349, 541);
            btn_xoaALLL.Name = "btn_xoaALLL";
            btn_xoaALLL.Size = new Size(94, 41);
            btn_xoaALLL.TabIndex = 3;
            btn_xoaALLL.Text = "Xóa ALL";
            btn_xoaALLL.UseVisualStyleBackColor = true;
            btn_xoaALLL.Click += btn_xoaALLL_Click;
            // 
            // btn_XoaSp
            // 
            btn_XoaSp.Location = new Point(86, 541);
            btn_XoaSp.Name = "btn_XoaSp";
            btn_XoaSp.Size = new Size(124, 41);
            btn_XoaSp.TabIndex = 5;
            btn_XoaSp.Text = "Xóa Sản phẩm";
            btn_XoaSp.UseVisualStyleBackColor = true;
            btn_XoaSp.Click += btn_XoaSp_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(btn_XoaSp);
            groupBox2.Controls.Add(btn_xoaALLL);
            groupBox2.Controls.Add(txt_TimKiemGioHang);
            groupBox2.Controls.Add(dtf_GioHang);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(888, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(558, 598);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(86, 50);
            label14.Name = "label14";
            label14.Size = new Size(0, 23);
            label14.TabIndex = 23;
            // 
            // txt_TimKiemGioHang
            // 
            txt_TimKiemGioHang.Location = new Point(157, 61);
            txt_TimKiemGioHang.Name = "txt_TimKiemGioHang";
            txt_TimKiemGioHang.Size = new Size(384, 30);
            txt_TimKiemGioHang.TabIndex = 2;
            txt_TimKiemGioHang.TextChanged += txt_TimKiemGioHang_TextChanged;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1907, 875);
            Controls.Add(pn_ChiTiet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            ForeColor = Color.Brown;
            Name = "FormBanHang";
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).EndInit();
            pn_ChiTiet.ResumeLayout(false);
            pn_ChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_SPBH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtf_GioHang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox5;
        private Label label3;
        private Label label4;
        private TextBox txt_sđt;
        private TextBox txt_tenkhachhang;
        private Label label10;
        private Label label11;
        private Label lb_TongTien;
        private Label label5;
        private TextBox txt_khachdua;
        private TextBox txt_Tienthua;
        private Label label12;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txt_DiaChi;
        private Label label2;
        private TextBox txt_Gmail;
        private TextBox txt_voucher;
        private Label label7;
        private TextBox txt_tongtien;
        private FontAwesome.Sharp.IconButton icbtn_TaoHoaDon;
        private GroupBox groupBox4;
        private Button btn_ThanhToan;
        private ComboBox cbx_HoaDonId;
        private FontAwesome.Sharp.IconButton icbtn_LamMOI;
        private GroupBox groupBox6;
        private Label label8;
        private Panel pn_ChiTiet;
        private DataGridView dtg_ChiTiet;
        private Button btn_Close;
        private DataGridView dtg_HoaDon;
        private Label label9;
        private DataGridView data_SPBH;
        private TextBox txt_timkiemsanpham;
        private Label label6;
        private GroupBox groupBox1;
        private Label label13;
        private DataGridView dtf_GioHang;
        private Button btn_xoaALLL;
        private Button btn_XoaSp;
        private GroupBox groupBox2;
        private Label label14;
        private TextBox txt_TimKiemGioHang;
        private TextBox textBox1;
    }
}