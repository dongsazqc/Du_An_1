namespace PRL
{
    partial class FormHoaDon
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
            dtg_HoaDon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).BeginInit();
            SuspendLayout();
            // 
            // dtg_HoaDon
            // 
            dtg_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HoaDon.Location = new Point(53, 222);
            dtg_HoaDon.Name = "dtg_HoaDon";
            dtg_HoaDon.RowHeadersWidth = 51;
            dtg_HoaDon.Size = new Size(652, 188);
            dtg_HoaDon.TabIndex = 0;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtg_HoaDon);
            Name = "FormHoaDon";
            Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)dtg_HoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_HoaDon;
    }
}