namespace PRL
{
    partial class FormKhachHang
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
            dgv_data = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMa = new TextBox();
            txtTenKhachHang = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            txtSeach = new TextBox();
            btnShow = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(0, 31);
            dgv_data.Name = "dgv_data";
            dgv_data.RowHeadersWidth = 51;
            dgv_data.Size = new Size(1599, 218);
            dgv_data.TabIndex = 0;
            dgv_data.CellClick += dgv_KhachHang_CellClick;
            dgv_data.CellContentClick += dgv_KhachHang_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_data);
            groupBox1.Location = new Point(12, 488);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1611, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 72);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 109);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 157);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 221);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(213, 25);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(224, 27);
            txtMa.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(213, 69);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(224, 27);
            txtTenKhachHang.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(213, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(213, 157);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(224, 27);
            txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(213, 214);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(224, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(781, 52);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(781, 109);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(781, 178);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(49, 339);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtSeach
            // 
            txtSeach.Location = new Point(213, 341);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(427, 27);
            txtSeach.TabIndex = 16;
            txtSeach.TextChanged += txtSeach_TextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(781, 262);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 17;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(781, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 745);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(txtSeach);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_data;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMa;
        private TextBox txtTenKhachHang;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private TextBox txtSeach;
        private Button btnShow;
        private Button btnClear;
    }
}