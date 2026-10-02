namespace Buoi02
{
    partial class BT02
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.lstLichSu = new System.Windows.Forms.ListBox();
            this.btnXoaLichSu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(75, 49);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(53, 15);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số thứ 1:";
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(75, 108);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(53, 15);
            this.lblSo2.TabIndex = 1;
            this.lblSo2.Text = "Số thứ 2:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetQua.Location = new System.Drawing.Point(90, 225);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(50, 15);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // lblLichSu
            // 
            this.lblLichSu.AutoSize = true;
            this.lblLichSu.Location = new System.Drawing.Point(79, 294);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(106, 15);
            this.lblLichSu.TabIndex = 3;
            this.lblLichSu.Text = "lịch Sử thanh toán:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(183, 41);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(178, 23);
            this.txtSo1.TabIndex = 4;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(183, 100);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(174, 23);
            this.txtSo2.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(79, 160);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(52, 23);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(163, 160);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(52, 23);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(245, 160);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(57, 23);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "X";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(329, 160);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(49, 23);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "÷";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnPhepTinh_Click);
            // 
            // lstLichSu
            // 
            this.lstLichSu.FormattingEnabled = true;
            this.lstLichSu.ItemHeight = 15;
            this.lstLichSu.Location = new System.Drawing.Point(79, 321);
            this.lstLichSu.Name = "lstLichSu";
            this.lstLichSu.Size = new System.Drawing.Size(309, 139);
            this.lstLichSu.TabIndex = 10;
            // 
            // btnXoaLichSu
            // 
            this.btnXoaLichSu.Location = new System.Drawing.Point(313, 218);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLichSu.TabIndex = 11;
            this.btnXoaLichSu.Text = "Xóa lịch sử";
            this.btnXoaLichSu.UseVisualStyleBackColor = true;
            this.btnXoaLichSu.Click += new System.EventHandler(this.btnXoaLichSu_Click);
            // 
            // BT02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 477);
            this.Controls.Add(this.btnXoaLichSu);
            this.Controls.Add(this.lstLichSu);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.lblSo1);
            this.Name = "BT02";
            this.Text = "Máy Tính 4 Phép Tính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSo1;
        private Label lblSo2;
        private Label lblKetQua;
        private Label lblLichSu;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private ListBox lstLichSu;
        private Button btnXoaLichSu;
    }
}