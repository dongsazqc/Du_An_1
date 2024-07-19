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
            btn_DS_sanpham = new Button();
            data_SPBH = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            textBox4 = new TextBox();
            button5 = new Button();
            groupBox2 = new GroupBox();
            dtf_GioHang = new DataGridView();
            groupBox5 = new GroupBox();
            txt_tongtien = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_sđt = new TextBox();
            txt_tenkhachhang = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txt_khachdua = new TextBox();
            txt_Tienthua = new TextBox();
            label12 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            btn_LuuHoaDon = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)data_SPBH).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtf_GioHang).BeginInit();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_DS_sanpham
            // 
            btn_DS_sanpham.BackColor = SystemColors.ActiveBorder;
            btn_DS_sanpham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_DS_sanpham.ForeColor = Color.Blue;
            btn_DS_sanpham.Location = new Point(6, 194);
            btn_DS_sanpham.Name = "btn_DS_sanpham";
            btn_DS_sanpham.Size = new Size(437, 44);
            btn_DS_sanpham.TabIndex = 18;
            btn_DS_sanpham.Text = "Lấy danh sách sản phẩm";
            btn_DS_sanpham.UseVisualStyleBackColor = false;
            btn_DS_sanpham.Click += btn_DS_sanpham_Click;
            // 
            // data_SPBH
            // 
            data_SPBH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_SPBH.Location = new Point(6, 244);
            data_SPBH.Name = "data_SPBH";
            data_SPBH.RowHeadersWidth = 51;
            data_SPBH.Size = new Size(440, 533);
            data_SPBH.TabIndex = 0;
            data_SPBH.CellContentClick += data_SPBH_CellContentClick;
            data_SPBH.CellDoubleClick += data_SPBH_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(data_SPBH);
            groupBox1.Controls.Add(btn_DS_sanpham);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 849);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(6, 789);
            label9.Name = "label9";
            label9.Size = new Size(429, 84);
            label9.TabIndex = 21;
            label9.Text = "click đúp để thêm sản phẩm vào giỏ hàng !!\r\n\r\n\r\n";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 27);
            textBox4.TabIndex = 20;
            // 
            // button5
            // 
            button5.Font = new Font("SimSun-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(6, 159);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 19;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtf_GioHang);
            groupBox2.Location = new Point(493, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 470);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // dtf_GioHang
            // 
            dtf_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtf_GioHang.Location = new Point(6, 26);
            dtf_GioHang.Name = "dtf_GioHang";
            dtf_GioHang.RowHeadersWidth = 51;
            dtf_GioHang.Size = new Size(395, 430);
            dtf_GioHang.TabIndex = 0;
            dtf_GioHang.CellContentClick += dtf_GioHang_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_tongtien);
            groupBox5.Controls.Add(textBox2);
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(txt_sđt);
            groupBox5.Controls.Add(txt_tenkhachhang);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.ForeColor = Color.Blue;
            groupBox5.Location = new Point(933, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(661, 285);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin khách hàng chi tiết";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txt_tongtien.Location = new Point(192, 233);
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(221, 46);
            txt_tongtien.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 36;
            textBox2.TextChanged += txt_GiaGoc_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += txt_GiaGoc_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(43, 244);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 28;
            label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(769, 94);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(518, 135);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 183);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 23;
            label2.Text = "Gmail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 139);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 23;
            label1.Text = "Địa chỉ";
            // 
            // txt_sđt
            // 
            txt_sđt.Location = new Point(192, 87);
            txt_sđt.Name = "txt_sđt";
            txt_sđt.Size = new Size(221, 27);
            txt_sđt.TabIndex = 2;
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.Location = new Point(192, 46);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.Size = new Size(221, 27);
            txt_tenkhachhang.TabIndex = 1;
            txt_tenkhachhang.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(43, 94);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 0;
            label10.Text = "Số điện thoại";
            label10.Click += label3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(43, 53);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 0;
            label11.Text = "Tên khách hàng";
            label11.Click += label3_Click;
            // 
            // txt_khachdua
            // 
            txt_khachdua.Location = new Point(146, 49);
            txt_khachdua.Name = "txt_khachdua";
            txt_khachdua.Size = new Size(221, 27);
            txt_khachdua.TabIndex = 34;
            // 
            // txt_Tienthua
            // 
            txt_Tienthua.Location = new Point(146, 93);
            txt_Tienthua.Name = "txt_Tienthua";
            txt_Tienthua.Size = new Size(221, 27);
            txt_Tienthua.TabIndex = 33;
            txt_Tienthua.TextChanged += txt_TongTien_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(37, 100);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 29;
            label12.Text = "Tiền thừa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 56);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 26;
            label3.Text = "Khách đưa";
            label3.Click += label3_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(txt_khachdua);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(txt_Tienthua);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(933, 304);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(661, 179);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin chung";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(409, 86);
            button4.Name = "button4";
            button4.Size = new Size(213, 50);
            button4.TabIndex = 4;
            button4.Text = "Thanh toán";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(37, 145);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 29;
            label7.Text = "Voucher";
            // 
            // btn_LuuHoaDon
            // 
            btn_LuuHoaDon.Cursor = Cursors.Hand;
            btn_LuuHoaDon.Location = new Point(385, 309);
            btn_LuuHoaDon.Name = "btn_LuuHoaDon";
            btn_LuuHoaDon.Size = new Size(127, 35);
            btn_LuuHoaDon.TabIndex = 0;
            btn_LuuHoaDon.Text = "Lưu hóa đơn";
            btn_LuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(172, 309);
            button1.Name = "button1";
            button1.Size = new Size(127, 35);
            button1.TabIndex = 1;
            button1.Text = "Thêm hóa đơn";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(623, 309);
            button2.Name = "button2";
            button2.Size = new Size(127, 35);
            button2.TabIndex = 2;
            button2.Text = "In hóa đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(870, 309);
            button3.Name = "button3";
            button3.Size = new Size(127, 35);
            button3.TabIndex = 3;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(btn_LuuHoaDon);
            groupBox4.Location = new Point(493, 489);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1124, 374);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách hóa đơn chi tiết";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 875);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "FormBanHang";
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)data_SPBH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtf_GioHang).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_DS_sanpham;
        private DataGridView data_SPBH;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label label3;
        private Label label4;
        private TextBox txt_sđt;
        private TextBox txt_tenkhachhang;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label label5;
        private TextBox txt_khachdua;
        private TextBox txt_Tienthua;
        private Label label12;
        private GroupBox groupBox3;
        private Button button4;
        private Button btn_LuuHoaDon;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private DataGridView dtf_GioHang;
        private TextBox textBox4;
        private Button button5;
        private Label label9;
        private TextBox txt_tongtien;
    }
}