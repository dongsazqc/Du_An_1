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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            groupBox4 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            txt_GiaGoc = new TextBox();
            txt_tienthua = new TextBox();
            txt_khachdua = new TextBox();
            txt_TongTien = new TextBox();
            txt_Thue = new TextBox();
            txt_Voucher = new TextBox();
            label12 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            txt_sđt = new TextBox();
            txt_tenkhachhang = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)data_SPBH).BeginInit();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btn_DS_sanpham
            // 
            btn_DS_sanpham.BackColor = SystemColors.ActiveBorder;
            btn_DS_sanpham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_DS_sanpham.Location = new Point(6, 179);
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
            data_SPBH.Size = new Size(440, 599);
            data_SPBH.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(data_SPBH);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_DS_sanpham);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 849);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách đơn hàng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 20;
            label1.Text = "Thời gian";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(493, 489);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1124, 374);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin hóa đơn chi tiết";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(493, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1124, 226);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ hàng";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_GiaGoc);
            groupBox5.Controls.Add(txt_tienthua);
            groupBox5.Controls.Add(txt_khachdua);
            groupBox5.Controls.Add(txt_TongTien);
            groupBox5.Controls.Add(txt_Thue);
            groupBox5.Controls.Add(txt_Voucher);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(dateTimePicker3);
            groupBox5.Controls.Add(txt_sđt);
            groupBox5.Controls.Add(txt_tenkhachhang);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox5.ForeColor = Color.Blue;
            groupBox5.Location = new Point(487, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1124, 223);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin hóa đơn";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // txt_GiaGoc
            // 
            txt_GiaGoc.Location = new Point(535, 42);
            txt_GiaGoc.Name = "txt_GiaGoc";
            txt_GiaGoc.Size = new Size(221, 27);
            txt_GiaGoc.TabIndex = 36;
            txt_GiaGoc.TextChanged += txt_GiaGoc_TextChanged;
            // 
            // txt_tienthua
            // 
            txt_tienthua.Location = new Point(876, 134);
            txt_tienthua.Name = "txt_tienthua";
            txt_tienthua.Size = new Size(221, 27);
            txt_tienthua.TabIndex = 35;
            // 
            // txt_khachdua
            // 
            txt_khachdua.Location = new Point(876, 94);
            txt_khachdua.Name = "txt_khachdua";
            txt_khachdua.Size = new Size(221, 27);
            txt_khachdua.TabIndex = 34;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(876, 46);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(221, 27);
            txt_TongTien.TabIndex = 33;
            // 
            // txt_Thue
            // 
            txt_Thue.Location = new Point(535, 130);
            txt_Thue.Name = "txt_Thue";
            txt_Thue.Size = new Size(221, 27);
            txt_Thue.TabIndex = 32;
            txt_Thue.TextChanged += txt_Thue_TextChanged;
            // 
            // txt_Voucher
            // 
            txt_Voucher.Location = new Point(535, 87);
            txt_Voucher.Name = "txt_Voucher";
            txt_Voucher.Size = new Size(221, 27);
            txt_Voucher.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(769, 137);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 29;
            label12.Text = "Tiền thừa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(769, 42);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(775, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 26;
            label3.Text = "Khách đưa";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(446, 137);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 25;
            label2.Text = "Thuế";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(446, 94);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 23;
            label7.Text = "Mã Voucher";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(446, 49);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 23;
            label8.Text = "Giá gốc";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(192, 130);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(221, 27);
            dateTimePicker3.TabIndex = 22;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(43, 137);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 0;
            label9.Text = "Thời gian";
            label9.Click += label3_Click;
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
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 875);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "FormBanHang";
            Text = "FormBanHang";
            ((System.ComponentModel.ISupportInitialize)data_SPBH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_DS_sanpham;
        private DataGridView data_SPBH;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private TextBox txt_sđt;
        private TextBox txt_tenkhachhang;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label label5;
        private TextBox txt_tienthua;
        private TextBox txt_khachdua;
        private TextBox txt_TongTien;
        private TextBox txt_Thue;
        private TextBox txt_Voucher;
        private Label label12;
        private TextBox txt_GiaGoc;
    }
}