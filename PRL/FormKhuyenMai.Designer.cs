namespace PRL
{
    partial class FormKhuyenMai
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            dt_ngayktkm = new DateTimePicker();
            dt_ngaybdkm = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_giamgiakm = new TextBox();
            txt_motakm = new TextBox();
            txt_tenKm = new TextBox();
            txt_Idkm = new TextBox();
            label1 = new Label();
            btn_tenkm = new ComboBox();
            cbb_IDkm = new ComboBox();
            groupBox2 = new GroupBox();
            dgv_khuyenmai = new DataGridView();
            groupBox3 = new GroupBox();
            btn_qr = new Button();
            btn_clearkm = new Button();
            btn_suakm = new Button();
            btn_themkm = new Button();
            label8 = new Label();
            txt_timkiemkm = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_khuyenmai).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dt_ngayktkm);
            groupBox1.Controls.Add(dt_ngaybdkm);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_giamgiakm);
            groupBox1.Controls.Add(txt_motakm);
            groupBox1.Controls.Add(txt_tenKm);
            groupBox1.Controls.Add(txt_Idkm);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(941, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khuyến Mãi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(456, 291);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 26;
            label7.Text = "Mã QR Khuyến Mãi";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(628, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 125);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dt_ngayktkm
            // 
            dt_ngayktkm.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngayktkm.Format = DateTimePickerFormat.Short;
            dt_ngayktkm.Location = new Point(527, 110);
            dt_ngayktkm.Name = "dt_ngayktkm";
            dt_ngayktkm.Size = new Size(165, 26);
            dt_ngayktkm.TabIndex = 24;
            // 
            // dt_ngaybdkm
            // 
            dt_ngaybdkm.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngaybdkm.Format = DateTimePickerFormat.Short;
            dt_ngaybdkm.Location = new Point(523, 55);
            dt_ngaybdkm.Name = "dt_ngaybdkm";
            dt_ngaybdkm.Size = new Size(169, 26);
            dt_ngaybdkm.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(405, 115);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 20;
            label6.Text = "Ngày Kết Thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(405, 55);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 19;
            label5.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 169);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 18;
            label4.Text = "Giảm Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 169);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 17;
            label3.Text = "Mô Tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 110);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 16;
            label2.Text = "Tên Khuyến Mãi";
            // 
            // txt_giamgiakm
            // 
            txt_giamgiakm.Font = new Font("Tahoma", 9F);
            txt_giamgiakm.Location = new Point(144, 165);
            txt_giamgiakm.Name = "txt_giamgiakm";
            txt_giamgiakm.Size = new Size(229, 26);
            txt_giamgiakm.TabIndex = 15;
            // 
            // txt_motakm
            // 
            txt_motakm.Font = new Font("Tahoma", 9F);
            txt_motakm.Location = new Point(527, 165);
            txt_motakm.Name = "txt_motakm";
            txt_motakm.Size = new Size(325, 26);
            txt_motakm.TabIndex = 14;
            // 
            // txt_tenKm
            // 
            txt_tenKm.Font = new Font("Tahoma", 9F);
            txt_tenKm.Location = new Point(144, 110);
            txt_tenKm.Name = "txt_tenKm";
            txt_tenKm.Size = new Size(229, 26);
            txt_tenKm.TabIndex = 13;
            // 
            // txt_Idkm
            // 
            txt_Idkm.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Idkm.Location = new Point(144, 42);
            txt_Idkm.Name = "txt_Idkm";
            txt_Idkm.Size = new Size(229, 26);
            txt_Idkm.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "ID Khuyến Mãi";
            // 
            // btn_tenkm
            // 
            btn_tenkm.BackColor = Color.White;
            btn_tenkm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tenkm.FormattingEnabled = true;
            btn_tenkm.Location = new Point(911, 437);
            btn_tenkm.Name = "btn_tenkm";
            btn_tenkm.Size = new Size(151, 31);
            btn_tenkm.TabIndex = 27;
            btn_tenkm.Text = "Tên Khuyến Mãi";
            // 
            // cbb_IDkm
            // 
            cbb_IDkm.BackColor = Color.White;
            cbb_IDkm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_IDkm.FormattingEnabled = true;
            cbb_IDkm.Location = new Point(713, 433);
            cbb_IDkm.Name = "cbb_IDkm";
            cbb_IDkm.Size = new Size(151, 31);
            cbb_IDkm.TabIndex = 3;
            cbb_IDkm.Text = "ID Khuyến Mãi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_khuyenmai);
            groupBox2.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 484);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(941, 296);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khuyến Mãi";
            // 
            // dgv_khuyenmai
            // 
            dgv_khuyenmai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_khuyenmai.Location = new Point(17, 26);
            dgv_khuyenmai.Name = "dgv_khuyenmai";
            dgv_khuyenmai.RowHeadersWidth = 51;
            dgv_khuyenmai.Size = new Size(902, 251);
            dgv_khuyenmai.TabIndex = 0;
            dgv_khuyenmai.CellContentClick += dgv_khuyenmai_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_qr);
            groupBox3.Controls.Add(btn_clearkm);
            groupBox3.Controls.Add(btn_suakm);
            groupBox3.Controls.Add(btn_themkm);
            groupBox3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(973, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 250);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức Năng";
            // 
            // btn_qr
            // 
            btn_qr.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_qr.Location = new Point(192, 150);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(91, 46);
            btn_qr.TabIndex = 3;
            btn_qr.Text = "Tạo QR";
            btn_qr.UseVisualStyleBackColor = true;
            // 
            // btn_clearkm
            // 
            btn_clearkm.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clearkm.Location = new Point(333, 56);
            btn_clearkm.Name = "btn_clearkm";
            btn_clearkm.Size = new Size(91, 46);
            btn_clearkm.TabIndex = 2;
            btn_clearkm.Text = "Clear";
            btn_clearkm.UseVisualStyleBackColor = true;
            // 
            // btn_suakm
            // 
            btn_suakm.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_suakm.Location = new Point(192, 56);
            btn_suakm.Name = "btn_suakm";
            btn_suakm.Size = new Size(91, 46);
            btn_suakm.TabIndex = 1;
            btn_suakm.Text = "Sửa";
            btn_suakm.UseVisualStyleBackColor = true;
            // 
            // btn_themkm
            // 
            btn_themkm.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_themkm.Location = new Point(35, 56);
            btn_themkm.Name = "btn_themkm";
            btn_themkm.Size = new Size(91, 46);
            btn_themkm.TabIndex = 0;
            btn_themkm.Text = "Thêm";
            btn_themkm.UseVisualStyleBackColor = true;
            btn_themkm.Click += btn_themkm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(91, 437);
            label8.Name = "label8";
            label8.Size = new Size(155, 21);
            label8.TabIndex = 27;
            label8.Text = "Tìm Kiếm Theo Tên";
            // 
            // txt_timkiemkm
            // 
            txt_timkiemkm.Location = new Point(264, 435);
            txt_timkiemkm.Name = "txt_timkiemkm";
            txt_timkiemkm.Size = new Size(399, 27);
            txt_timkiemkm.TabIndex = 28;
            txt_timkiemkm.TextChanged += txt_timkiemkm_TextChanged;
            // 
            // FormKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 792);
            Controls.Add(btn_tenkm);
            Controls.Add(txt_timkiemkm);
            Controls.Add(label8);
            Controls.Add(cbb_IDkm);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKhuyenMai";
            Text = "FormKhuyenMai";
            Load += FormKhuyenMai_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_khuyenmai).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Idkm;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_giamgiakm;
        private TextBox txt_motakm;
        private TextBox txt_tenKm;
        private Label label6;
        private DateTimePicker dt_ngayktkm;
        private DateTimePicker dt_ngaybdkm;
        private Button btn_clearkm;
        private Button btn_suakm;
        private Button btn_themkm;
        private PictureBox pictureBox1;
        private ComboBox btn_tenkm;
        private Label label7;
        private ComboBox cbb_IDkm;
        private DataGridView dgv_khuyenmai;
        private Button btn_qr;
        private Label label8;
        private TextBox txt_timkiemkm;
    }
}