namespace buoi03
{
    partial class QLKhoaHoc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaKH = new TextBox();
            txtTenKH = new TextBox();
            nudSoTinChi = new NumericUpDown();
            btnThem = new Button();
            lstKhoaHoc = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã khóa học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 51);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên khóa học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 85);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Số tín chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 127);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 3;
            label4.Text = "Danh Sách Khoá Học:";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(151, 19);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(169, 23);
            txtMaKH.TabIndex = 4;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(151, 51);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(322, 23);
            txtTenKH.TabIndex = 5;
            // 
            // nudSoTinChi
            // 
            nudSoTinChi.Location = new Point(151, 85);
            nudSoTinChi.Name = "nudSoTinChi";
            nudSoTinChi.Size = new Size(120, 23);
            nudSoTinChi.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Chartreuse;
            btnThem.Location = new Point(326, 85);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lstKhoaHoc
            // 
            lstKhoaHoc.FormattingEnabled = true;
            lstKhoaHoc.ItemHeight = 15;
            lstKhoaHoc.Location = new Point(12, 145);
            lstKhoaHoc.Name = "lstKhoaHoc";
            lstKhoaHoc.Size = new Size(556, 289);
            lstKhoaHoc.TabIndex = 9;
            // 
            // QLKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 446);
            Controls.Add(lstKhoaHoc);
            Controls.Add(btnThem);
            Controls.Add(nudSoTinChi);
            Controls.Add(txtTenKH);
            Controls.Add(txtMaKH);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLKhoaHoc";
            Text = "Quản lý khóa học";
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaKH;
        private TextBox txtTenKH;
        private NumericUpDown nudSoTinChi;
        private Button btnThem;
        private ListBox lstKhoaHoc;
    }
}