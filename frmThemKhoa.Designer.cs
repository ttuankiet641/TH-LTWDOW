namespace baitap01
{
    partial class frmThemKhoa
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
            bttnLuu = new Button();
            bttnHuy = new Button();
            txtThemKhoa = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Khoa:";
            // 
            // bttnLuu
            // 
            bttnLuu.BackColor = Color.Coral;
            bttnLuu.Location = new Point(70, 91);
            bttnLuu.Name = "bttnLuu";
            bttnLuu.Size = new Size(75, 23);
            bttnLuu.TabIndex = 1;
            bttnLuu.Text = "Lưu";
            bttnLuu.UseVisualStyleBackColor = false;
            bttnLuu.Click += bttnLuu_Click;
            // 
            // bttnHuy
            // 
            bttnHuy.BackColor = SystemColors.ButtonShadow;
            bttnHuy.Location = new Point(190, 91);
            bttnHuy.Name = "bttnHuy";
            bttnHuy.Size = new Size(75, 23);
            bttnHuy.TabIndex = 2;
            bttnHuy.Text = "Huỷ";
            bttnHuy.UseVisualStyleBackColor = false;
            bttnHuy.Click += bttnHuy_Click;
            // 
            // txtThemKhoa
            // 
            txtThemKhoa.Location = new Point(96, 33);
            txtThemKhoa.Name = "txtThemKhoa";
            txtThemKhoa.Size = new Size(200, 23);
            txtThemKhoa.TabIndex = 3;
            txtThemKhoa.TextChanged += txtThemKhoa_TextChanged;
            // 
            // frmThemKhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 138);
            Controls.Add(txtThemKhoa);
            Controls.Add(bttnHuy);
            Controls.Add(bttnLuu);
            Controls.Add(label1);
            Name = "frmThemKhoa";
            Text = "frmThemKhoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttnLuu;
        private Button bttnHuy;
        private TextBox txtThemKhoa;
    }
}