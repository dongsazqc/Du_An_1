namespace PRL
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            pictureBox1 = new PictureBox();
            btn_Thoat = new Button();
            btn_DangNhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(684, 328);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 16;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(534, 328);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 29);
            btn_DangNhap.TabIndex = 15;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(549, 240);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(244, 27);
            txt_matkhau.TabIndex = 14;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(549, 196);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(244, 27);
            txt_taikhoan.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 243);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 199);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 11;
            label3.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-18, 86);
            label2.Name = "label2";
            label2.Size = new Size(837, 20);
            label2.TabIndex = 10;
            label2.Text = "-------------------------------------------------------------------------------Thông tin đăng nhập------------------------------------";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormDangNhap";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Thoat;
        private Button btn_DangNhap;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}