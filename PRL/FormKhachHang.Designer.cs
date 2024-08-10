
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            groupBox1 = new GroupBox();
            dgv_data = new DataGridView();
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
            btnClear = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            dgv_KhachHang = new DataGridView();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            khachHangBindingSource = new BindingSource(components);
            label6 = new Label();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_data);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(692, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 243);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(6, 29);
            dgv_data.Name = "dgv_data";
            dgv_data.RowHeadersWidth = 51;
            dgv_data.Size = new Size(790, 208);
            dgv_data.TabIndex = 0;
            dgv_data.CellClick += dgv_data_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(28, 23);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 89);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(52, 188);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(52, 248);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(254, 31);
            txtMa.Name = "txtMa";
            txtMa.ReadOnly = true;
            txtMa.Size = new Size(311, 30);
            txtMa.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(254, 82);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(311, 30);
            txtTenKhachHang.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(254, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 30);
            txtEmail.TabIndex = 9;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(254, 188);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(311, 30);
            txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(254, 241);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(311, 30);
            txtDiaChi.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnThem.ForeColor = Color.Black;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(52, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 58);
            btnThem.TabIndex = 12;
            btnThem.Text = "New";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSua.ForeColor = Color.Black;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(231, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 58);
            btnSua.TabIndex = 13;
            btnSua.Text = "Edit";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(399, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 58);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(692, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(530, 101);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMa);
            groupBox3.Controls.Add(txtTenKhachHang);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.IndianRed;
            groupBox3.Location = new Point(48, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 312);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgv_KhachHang);
            groupBox5.Location = new Point(48, 493);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1060, 240);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Khách hàng mua nhiều nhất";
            // 
            // dgv_KhachHang
            // 
            dgv_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KhachHang.Location = new Point(6, 22);
            dgv_KhachHang.Name = "dgv_KhachHang";
            dgv_KhachHang.RowHeadersWidth = 51;
            dgv_KhachHang.Size = new Size(1047, 212);
            dgv_KhachHang.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            linkLabel1.Location = new Point(1314, 655);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 38);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Góp ý";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            linkLabel2.Location = new Point(1314, 704);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(174, 29);
            linkLabel2.TabIndex = 24;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Hỗ trợ khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(698, 156);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 27;
            label6.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(795, 155);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(427, 27);
            txtTimKiem.TabIndex = 28;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1500, 745);
            Controls.Add(txtTimKiem);
            Controls.Add(label6);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormKhachHang";
            RightToLeft = RightToLeft.No;
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_KhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnClear;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private DataGridView dgv_KhachHang;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private BindingSource khachHangBindingSource;
        private DataGridView dgv_data;
        private Label label6;
        private TextBox txtTimKiem;
    }
}