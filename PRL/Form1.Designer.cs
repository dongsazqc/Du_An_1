namespace PRL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btn_TrangChu = new Button();
            label1 = new Label();
            btn_BanHang = new Button();
            btn_KhachHang = new Button();
            btn_SanPham = new Button();
            panel_Body = new Panel();
            TieuDe = new Label();
            panel2 = new Panel();
            icbtn_HienAn = new FontAwesome.Sharp.IconButton();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            btn_KM = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(iconPictureBox6);
            panel1.Controls.Add(btn_KM);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btn_TrangChu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(btn_SanPham);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 1032);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 172);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(0, 0, 192);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(23, 705);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 10;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(0, 0, 192);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PersonPregnant;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(23, 575);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 9;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 0, 192);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(23, 450);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(0, 0, 192);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HouseFlag;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(23, 321);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // btn_TrangChu
            // 
            btn_TrangChu.BackColor = Color.FromArgb(0, 0, 192);
            btn_TrangChu.FlatAppearance.BorderSize = 0;
            btn_TrangChu.FlatStyle = FlatStyle.Flat;
            btn_TrangChu.Font = new Font("Franklin Gothic Demi Cond", 13F, FontStyle.Bold);
            btn_TrangChu.ForeColor = Color.WhiteSmoke;
            btn_TrangChu.Location = new Point(3, 290);
            btn_TrangChu.Name = "btn_TrangChu";
            btn_TrangChu.Size = new Size(249, 112);
            btn_TrangChu.TabIndex = 6;
            btn_TrangChu.Text = "Trang chủ";
            btn_TrangChu.UseVisualStyleBackColor = false;
            btn_TrangChu.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 963);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 6;
            label1.Text = "Nhân Viên";
            // 
            // btn_BanHang
            // 
            btn_BanHang.BackColor = Color.FromArgb(0, 0, 192);
            btn_BanHang.FlatAppearance.BorderSize = 0;
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.Font = new Font("Franklin Gothic Demi Cond", 13F, FontStyle.Bold);
            btn_BanHang.ForeColor = Color.WhiteSmoke;
            btn_BanHang.Location = new Point(0, 667);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(249, 112);
            btn_BanHang.TabIndex = 5;
            btn_BanHang.Text = "Bán Hàng";
            btn_BanHang.UseVisualStyleBackColor = false;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.BackColor = Color.FromArgb(0, 0, 192);
            btn_KhachHang.FlatAppearance.BorderSize = 0;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.Font = new Font("Franklin Gothic Demi Cond", 13F, FontStyle.Bold);
            btn_KhachHang.ForeColor = Color.White;
            btn_KhachHang.Location = new Point(3, 536);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(249, 112);
            btn_KhachHang.TabIndex = 4;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = false;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_SanPham
            // 
            btn_SanPham.BackColor = Color.FromArgb(0, 0, 192);
            btn_SanPham.FlatAppearance.BorderSize = 0;
            btn_SanPham.FlatStyle = FlatStyle.Flat;
            btn_SanPham.Font = new Font("Franklin Gothic Demi Cond", 13F, FontStyle.Bold);
            btn_SanPham.ForeColor = Color.White;
            btn_SanPham.Location = new Point(3, 418);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Size = new Size(249, 112);
            btn_SanPham.TabIndex = 0;
            btn_SanPham.Text = "Sản phẩm";
            btn_SanPham.UseVisualStyleBackColor = false;
            btn_SanPham.Click += btn_SanPham_Click;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.FromArgb(255, 224, 192);
            panel_Body.Location = new Point(-1, 112);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1903, 922);
            panel_Body.TabIndex = 2;
            panel_Body.Paint += panel_Body_Paint;
            // 
            // TieuDe
            // 
            TieuDe.AutoSize = true;
            TieuDe.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            TieuDe.Location = new Point(803, 35);
            TieuDe.Name = "TieuDe";
            TieuDe.Size = new Size(502, 40);
            TieuDe.TabIndex = 0;
            TieuDe.Text = "Giải Pháp Bán Hàng Tối Ưu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(TieuDe);
            panel2.Controls.Add(icbtn_HienAn);
            panel2.Location = new Point(-1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1903, 111);
            panel2.TabIndex = 1;
            // 
            // icbtn_HienAn
            // 
            icbtn_HienAn.BackColor = Color.Silver;
            icbtn_HienAn.IconChar = FontAwesome.Sharp.IconChar.None;
            icbtn_HienAn.IconColor = Color.Black;
            icbtn_HienAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbtn_HienAn.Location = new Point(255, 48);
            icbtn_HienAn.Name = "icbtn_HienAn";
            icbtn_HienAn.Size = new Size(65, 63);
            icbtn_HienAn.TabIndex = 1;
            icbtn_HienAn.UseVisualStyleBackColor = false;
            icbtn_HienAn.Click += iconButton1_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(0, 0, 192);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            iconPictureBox6.IconColor = Color.White;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 40;
            iconPictureBox6.Location = new Point(23, 827);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 40);
            iconPictureBox6.TabIndex = 13;
            iconPictureBox6.TabStop = false;
            // 
            // btn_KM
            // 
            btn_KM.BackColor = Color.FromArgb(0, 0, 192);
            btn_KM.FlatAppearance.BorderSize = 0;
            btn_KM.FlatStyle = FlatStyle.Flat;
            btn_KM.Font = new Font("Franklin Gothic Demi Cond", 13F, FontStyle.Bold);
            btn_KM.ForeColor = Color.White;
            btn_KM.Location = new Point(3, 798);
            btn_KM.Name = "btn_KM";
            btn_KM.Size = new Size(249, 112);
            btn_KM.TabIndex = 6;
            btn_KM.Text = "Khuyễn mãi";
            btn_KM.UseVisualStyleBackColor = false;
            btn_KM.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Phần mền bán quàn áo thời trang";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_SanPham;
        private Panel panel_Body;
        private Button btn_KhachHang;
        private Label label1;
        private Button btn_BanHang;
        private Button btn_TrangChu;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label TieuDe;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Button btn_Voucher;
        private FontAwesome.Sharp.IconButton icbtn_HienAn;
        private Button btn_KM;
    }
}
