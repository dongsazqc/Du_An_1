namespace PRL
{
    partial class Voucher
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
            dt_ngaykt = new DateTimePicker();
            dt_ngaybd = new DateTimePicker();
            txt_dieukiensd = new TextBox();
            txt_giatrivc = new TextBox();
            txt_phantramvc = new TextBox();
            txt_tenthuonghieuvc = new TextBox();
            txt_tenvoucher = new TextBox();
            txt_mavoucher = new TextBox();
            lbl_tenvoucher = new Label();
            lbl_dksd = new Label();
            lbl_ngaykt = new Label();
            lbl_ngaybd = new Label();
            lbl_phantram = new Label();
            lbl_tenthuonghieu = new Label();
            lbl_gia = new Label();
            lbl_mavoucher = new Label();
            groupBox2 = new GroupBox();
            btn_qr = new Button();
            btn_suavoucher = new Button();
            btn_Clear = new Button();
            btn_themvoucher = new Button();
            groupBox3 = new GroupBox();
            dgv_voucher = new DataGridView();
            cbb_mavoucher = new ComboBox();
            cbb_tenvoucher = new ComboBox();
            cbb_tenthuonghieuvc = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_voucher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(dt_ngaykt);
            groupBox1.Controls.Add(dt_ngaybd);
            groupBox1.Controls.Add(txt_dieukiensd);
            groupBox1.Controls.Add(txt_giatrivc);
            groupBox1.Controls.Add(txt_phantramvc);
            groupBox1.Controls.Add(txt_tenthuonghieuvc);
            groupBox1.Controls.Add(txt_tenvoucher);
            groupBox1.Controls.Add(txt_mavoucher);
            groupBox1.Controls.Add(lbl_tenvoucher);
            groupBox1.Controls.Add(lbl_dksd);
            groupBox1.Controls.Add(lbl_ngaykt);
            groupBox1.Controls.Add(lbl_ngaybd);
            groupBox1.Controls.Add(lbl_phantram);
            groupBox1.Controls.Add(lbl_tenthuonghieu);
            groupBox1.Controls.Add(lbl_gia);
            groupBox1.Controls.Add(lbl_mavoucher);
            groupBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Voucher";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dt_ngaykt
            // 
            dt_ngaykt.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dt_ngaykt.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngaykt.Location = new Point(631, 204);
            dt_ngaykt.Name = "dt_ngaykt";
            dt_ngaykt.Size = new Size(290, 26);
            dt_ngaykt.TabIndex = 17;
            // 
            // dt_ngaybd
            // 
            dt_ngaybd.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dt_ngaybd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_ngaybd.Location = new Point(631, 139);
            dt_ngaybd.Name = "dt_ngaybd";
            dt_ngaybd.Size = new Size(290, 26);
            dt_ngaybd.TabIndex = 16;
            dt_ngaybd.ValueChanged += dt_ngaybd_ValueChanged;
            // 
            // txt_dieukiensd
            // 
            txt_dieukiensd.Font = new Font("Tahoma", 12F);
            txt_dieukiensd.Location = new Point(631, 263);
            txt_dieukiensd.Name = "txt_dieukiensd";
            txt_dieukiensd.Size = new Size(286, 32);
            txt_dieukiensd.TabIndex = 15;
            // 
            // txt_giatrivc
            // 
            txt_giatrivc.Font = new Font("Tahoma", 12F);
            txt_giatrivc.Location = new Point(631, 68);
            txt_giatrivc.Name = "txt_giatrivc";
            txt_giatrivc.Size = new Size(290, 32);
            txt_giatrivc.TabIndex = 12;
            // 
            // txt_phantramvc
            // 
            txt_phantramvc.Font = new Font("Tahoma", 12F);
            txt_phantramvc.Location = new Point(160, 263);
            txt_phantramvc.Name = "txt_phantramvc";
            txt_phantramvc.Size = new Size(232, 32);
            txt_phantramvc.TabIndex = 11;
            txt_phantramvc.TextChanged += txt_phantramvc_TextChanged;
            // 
            // txt_tenthuonghieuvc
            // 
            txt_tenthuonghieuvc.Font = new Font("Tahoma", 12F);
            txt_tenthuonghieuvc.Location = new Point(160, 197);
            txt_tenthuonghieuvc.Name = "txt_tenthuonghieuvc";
            txt_tenthuonghieuvc.Size = new Size(232, 32);
            txt_tenthuonghieuvc.TabIndex = 10;
            txt_tenthuonghieuvc.TextChanged += txt_tenthuonghieuvc_TextChanged;
            // 
            // txt_tenvoucher
            // 
            txt_tenvoucher.Font = new Font("Tahoma", 12F);
            txt_tenvoucher.Location = new Point(160, 140);
            txt_tenvoucher.Name = "txt_tenvoucher";
            txt_tenvoucher.Size = new Size(232, 32);
            txt_tenvoucher.TabIndex = 9;
            // 
            // txt_mavoucher
            // 
            txt_mavoucher.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_mavoucher.Location = new Point(160, 74);
            txt_mavoucher.Name = "txt_mavoucher";
            txt_mavoucher.Size = new Size(232, 32);
            txt_mavoucher.TabIndex = 8;
            // 
            // lbl_tenvoucher
            // 
            lbl_tenvoucher.AutoSize = true;
            lbl_tenvoucher.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_tenvoucher.Location = new Point(17, 147);
            lbl_tenvoucher.Name = "lbl_tenvoucher";
            lbl_tenvoucher.Size = new Size(116, 22);
            lbl_tenvoucher.TabIndex = 7;
            lbl_tenvoucher.Text = "Tên Voucher:";
            // 
            // lbl_dksd
            // 
            lbl_dksd.AutoSize = true;
            lbl_dksd.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_dksd.Location = new Point(458, 270);
            lbl_dksd.Name = "lbl_dksd";
            lbl_dksd.Size = new Size(167, 22);
            lbl_dksd.TabIndex = 6;
            lbl_dksd.Text = "Điều Kiện Sử Dụng:";
            // 
            // lbl_ngaykt
            // 
            lbl_ngaykt.AutoSize = true;
            lbl_ngaykt.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_ngaykt.Location = new Point(471, 207);
            lbl_ngaykt.Name = "lbl_ngaykt";
            lbl_ngaykt.Size = new Size(133, 22);
            lbl_ngaykt.TabIndex = 5;
            lbl_ngaykt.Text = "Ngày Kết Thúc:";
            // 
            // lbl_ngaybd
            // 
            lbl_ngaybd.AutoSize = true;
            lbl_ngaybd.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_ngaybd.Location = new Point(471, 142);
            lbl_ngaybd.Name = "lbl_ngaybd";
            lbl_ngaybd.Size = new Size(126, 22);
            lbl_ngaybd.TabIndex = 4;
            lbl_ngaybd.Text = "Ngày Bắt Đầu:";
            // 
            // lbl_phantram
            // 
            lbl_phantram.AutoSize = true;
            lbl_phantram.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_phantram.Location = new Point(6, 270);
            lbl_phantram.Name = "lbl_phantram";
            lbl_phantram.Size = new Size(148, 22);
            lbl_phantram.TabIndex = 3;
            lbl_phantram.Text = "Phần Trăm Giảm:";
            // 
            // lbl_tenthuonghieu
            // 
            lbl_tenthuonghieu.AutoSize = true;
            lbl_tenthuonghieu.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_tenthuonghieu.Location = new Point(6, 204);
            lbl_tenthuonghieu.Name = "lbl_tenthuonghieu";
            lbl_tenthuonghieu.Size = new Size(155, 22);
            lbl_tenthuonghieu.TabIndex = 2;
            lbl_tenthuonghieu.Text = "Tên Thương Hiệu:";
            // 
            // lbl_gia
            // 
            lbl_gia.AutoSize = true;
            lbl_gia.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_gia.Location = new Point(471, 79);
            lbl_gia.Name = "lbl_gia";
            lbl_gia.Size = new Size(68, 22);
            lbl_gia.TabIndex = 1;
            lbl_gia.Text = "Giá Trị:";
            // 
            // lbl_mavoucher
            // 
            lbl_mavoucher.AutoSize = true;
            lbl_mavoucher.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbl_mavoucher.Location = new Point(24, 81);
            lbl_mavoucher.Name = "lbl_mavoucher";
            lbl_mavoucher.Size = new Size(109, 22);
            lbl_mavoucher.TabIndex = 0;
            lbl_mavoucher.Text = "Mã Voucher:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(btn_qr);
            groupBox2.Controls.Add(btn_suavoucher);
            groupBox2.Controls.Add(btn_Clear);
            groupBox2.Controls.Add(btn_themvoucher);
            groupBox2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(981, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng Voucher";
            // 
            // btn_qr
            // 
            btn_qr.BackColor = SystemColors.ButtonHighlight;
            btn_qr.Font = new Font("Tahoma", 10.8F);
            btn_qr.Image = Properties.Resources.icons8_new_page_24;
            btn_qr.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qr.Location = new Point(452, 63);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(103, 53);
            btn_qr.TabIndex = 3;
            btn_qr.Text = "Tạo Qr";
            btn_qr.UseVisualStyleBackColor = false;
            btn_qr.Click += btn_qr_Click;
            // 
            // btn_suavoucher
            // 
            btn_suavoucher.BackColor = Color.Snow;
            btn_suavoucher.Font = new Font("Tahoma", 10.8F);
            btn_suavoucher.Image = Properties.Resources.icons8_save_30;
            btn_suavoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btn_suavoucher.Location = new Point(144, 62);
            btn_suavoucher.Name = "btn_suavoucher";
            btn_suavoucher.Size = new Size(97, 54);
            btn_suavoucher.TabIndex = 2;
            btn_suavoucher.Text = "Sửa";
            btn_suavoucher.UseVisualStyleBackColor = false;
            btn_suavoucher.Click += btn_suavoucher_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Ivory;
            btn_Clear.Font = new Font("Tahoma", 10.8F);
            btn_Clear.Image = Properties.Resources.icons8_clear_50;
            btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clear.Location = new Point(291, 63);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(108, 52);
            btn_Clear.TabIndex = 1;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_themvoucher
            // 
            btn_themvoucher.BackColor = SystemColors.ButtonHighlight;
            btn_themvoucher.Font = new Font("Tahoma", 10.8F);
            btn_themvoucher.Image = Properties.Resources.icons8_new_page_24;
            btn_themvoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themvoucher.Location = new Point(6, 62);
            btn_themvoucher.Name = "btn_themvoucher";
            btn_themvoucher.Size = new Size(103, 53);
            btn_themvoucher.TabIndex = 0;
            btn_themvoucher.Text = "  Thêm ";
            btn_themvoucher.UseVisualStyleBackColor = false;
            btn_themvoucher.Click += btn_themvoucher_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_voucher);
            groupBox3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(953, 365);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Voucher";
            // 
            // dgv_voucher
            // 
            dgv_voucher.BackgroundColor = Color.Silver;
            dgv_voucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_voucher.Location = new Point(9, 28);
            dgv_voucher.Name = "dgv_voucher";
            dgv_voucher.RowHeadersWidth = 51;
            dgv_voucher.Size = new Size(938, 331);
            dgv_voucher.TabIndex = 0;
            dgv_voucher.CellContentClick += dgv_voucher_CellContentClick;
            // 
            // cbb_mavoucher
            // 
            cbb_mavoucher.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbb_mavoucher.FormattingEnabled = true;
            cbb_mavoucher.Location = new Point(128, 394);
            cbb_mavoucher.Name = "cbb_mavoucher";
            cbb_mavoucher.Size = new Size(156, 31);
            cbb_mavoucher.TabIndex = 3;
            cbb_mavoucher.Text = "Mã Voucher";
            cbb_mavoucher.SelectedIndexChanged += cbb_mavoucher_SelectedIndexChanged;
            // 
            // cbb_tenvoucher
            // 
            cbb_tenvoucher.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbb_tenvoucher.FormattingEnabled = true;
            cbb_tenvoucher.Location = new Point(403, 394);
            cbb_tenvoucher.Name = "cbb_tenvoucher";
            cbb_tenvoucher.Size = new Size(151, 31);
            cbb_tenvoucher.TabIndex = 4;
            cbb_tenvoucher.Text = "Tên Voucher";
            // 
            // cbb_tenthuonghieuvc
            // 
            cbb_tenthuonghieuvc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbb_tenthuonghieuvc.FormattingEnabled = true;
            cbb_tenthuonghieuvc.Location = new Point(681, 394);
            cbb_tenthuonghieuvc.Name = "cbb_tenthuonghieuvc";
            cbb_tenthuonghieuvc.Size = new Size(161, 31);
            cbb_tenthuonghieuvc.TabIndex = 5;
            cbb_tenthuonghieuvc.Text = "Tên Thương Hiệu";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(981, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 199);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Voucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1629, 808);
            Controls.Add(pictureBox1);
            Controls.Add(cbb_tenthuonghieuvc);
            Controls.Add(cbb_tenvoucher);
            Controls.Add(cbb_mavoucher);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Voucher";
            Text = "Voucher";
            Load += Voucher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_voucher).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_tenvoucher;
        private Label lbl_dksd;
        private Label lbl_ngaykt;
        private Label lbl_ngaybd;
        private Label lbl_phantram;
        private Label lbl_tenthuonghieu;
        private Label lbl_gia;
        private Label lbl_mavoucher;
        private TextBox txt_giatrivc;
        private TextBox txt_phantramvc;
        private TextBox txt_tenthuonghieuvc;
        private TextBox txt_tenvoucher;
        private TextBox txt_mavoucher;
        private TextBox txt_dieukiensd;
        private GroupBox groupBox2;
        private Button btn_suavoucher;
        private Button btn_Clear;
        private Button btn_themvoucher;
        private GroupBox groupBox3;
        private ComboBox cbb_mavoucher;
        private ComboBox cbb_tenvoucher;
        private ComboBox cbb_tenthuonghieuvc;
        private DataGridView dgv_voucher;
        private DateTimePicker dt_ngaykt;
        private DateTimePicker dt_ngaybd;
        private Button btn_qr;
        private PictureBox pictureBox1;
    }
}