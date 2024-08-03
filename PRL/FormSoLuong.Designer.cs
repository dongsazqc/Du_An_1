namespace PRL
{
    partial class FormSoLuong
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
            label1 = new Label();
            txt_SoLuong = new TextBox();
            btn_Ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(410, 31);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng nhập số lượng muốn mua !!";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(30, 62);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(263, 27);
            txt_SoLuong.TabIndex = 1;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(312, 61);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(66, 29);
            btn_Ok.TabIndex = 2;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // FormSoLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(428, 129);
            Controls.Add(btn_Ok);
            Controls.Add(txt_SoLuong);
            Controls.Add(label1);
            Name = "FormSoLuong";
            Text = "FormSoLuong";
            Load += FormSoLuong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_SoLuong;
        private Button btn_Ok;
    }
}