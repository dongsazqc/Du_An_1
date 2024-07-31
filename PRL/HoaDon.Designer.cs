namespace PRL
{
    partial class HoaDon
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
            dgv_HoaDonCT = new DataGridView();
            btnHoaDon = new Button();
            btnHoaDonCT = new Button();
            dgvHoaDon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dgv_HoaDonCT
            // 
            dgv_HoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonCT.Location = new Point(763, 220);
            dgv_HoaDonCT.Name = "dgv_HoaDonCT";
            dgv_HoaDonCT.RowHeadersWidth = 51;
            dgv_HoaDonCT.Size = new Size(748, 504);
            dgv_HoaDonCT.TabIndex = 1;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.Red;
            btnHoaDon.Font = new Font("Segoe UI", 10.2F);
            btnHoaDon.Location = new Point(236, 128);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(150, 59);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hiển thị hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnHoaDonCT
            // 
            btnHoaDonCT.BackColor = Color.Cyan;
            btnHoaDonCT.Font = new Font("Segoe UI", 10.2F);
            btnHoaDonCT.Location = new Point(950, 128);
            btnHoaDonCT.Name = "btnHoaDonCT";
            btnHoaDonCT.Size = new Size(217, 59);
            btnHoaDonCT.TabIndex = 3;
            btnHoaDonCT.Text = "Hiển thị hóa đơn chi tiết";
            btnHoaDonCT.UseVisualStyleBackColor = false;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(0, 220);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(742, 504);
            dgvHoaDon.TabIndex = 4;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 736);
            Controls.Add(dgvHoaDon);
            Controls.Add(btnHoaDonCT);
            Controls.Add(btnHoaDon);
            Controls.Add(dgv_HoaDonCT);
            Name = "HoaDon";
            Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgv_HoaDonCT;
        private Button btnHoaDon;
        private Button btnHoaDonCT;
        private DataGridView dgvHoaDon;
    }
}