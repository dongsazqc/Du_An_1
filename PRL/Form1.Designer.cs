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
            label1 = new Label();
            btn_BanHang = new Button();
            btn_KhachHang = new Button();
            Avatar = new PictureBox();
            btn_SanPham = new Button();
            panel2 = new Panel();
            lb_Menu = new Label();
            panel_Body = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            panel2.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(Avatar);
            panel1.Controls.Add(btn_SanPham);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 1032);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(59, 910);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 6;
            label1.Text = "Nhân Viên";
            // 
            // btn_BanHang
            // 
            btn_BanHang.BackColor = Color.FromArgb(255, 128, 255);
            btn_BanHang.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BanHang.Location = new Point(0, 586);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(249, 112);
            btn_BanHang.TabIndex = 5;
            btn_BanHang.Text = "Bán Hàng";
            btn_BanHang.UseVisualStyleBackColor = false;
            btn_BanHang.Click += btn_BanHang_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.BackColor = Color.Cyan;
            btn_KhachHang.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_KhachHang.Location = new Point(3, 481);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(249, 112);
            btn_KhachHang.TabIndex = 4;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = false;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.RosyBrown;
            Avatar.Image = (Image)resources.GetObject("Avatar.Image");
            Avatar.Location = new Point(0, 0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(249, 215);
            Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            Avatar.TabIndex = 3;
            Avatar.TabStop = false;
            // 
            // btn_SanPham
            // 
            btn_SanPham.BackColor = Color.PaleTurquoise;
            btn_SanPham.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SanPham.Location = new Point(3, 372);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Size = new Size(249, 112);
            btn_SanPham.TabIndex = 0;
            btn_SanPham.Text = "Sản phẩm";
            btn_SanPham.UseVisualStyleBackColor = false;
            btn_SanPham.Click += btn_SanPham_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(lb_Menu);
            panel2.Location = new Point(249, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1653, 111);
            panel2.TabIndex = 1;
            // 
            // lb_Menu
            // 
            lb_Menu.AutoSize = true;
            lb_Menu.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Menu.Location = new Point(822, 39);
            lb_Menu.Name = "lb_Menu";
            lb_Menu.Size = new Size(168, 35);
            lb_Menu.TabIndex = 0;
            lb_Menu.Text = "Trang Chủ";
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.FromArgb(0, 192, 0);
            panel_Body.Controls.Add(pictureBox1);
            panel_Body.Location = new Point(249, 112);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1653, 922);
            panel_Body.TabIndex = 2;
            panel_Body.Paint += panel_Body_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RosyBrown;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(707, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Phần mền bán quàn áo thời trang";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox Avatar;
        private Button btn_SanPham;
        private Panel panel_Body;
        private Button btn_BanHang;
        private Button btn_KhachHang;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lb_Menu;
    }
}
