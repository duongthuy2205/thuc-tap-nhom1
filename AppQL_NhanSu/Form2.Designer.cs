namespace AppQL_NhanSu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChucVu = new System.Windows.Forms.Button();
            this.lb_userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Luong = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_PhongBan = new System.Windows.Forms.Button();
            this.uC_PhongBan1 = new AppQL_NhanSu.UC_PhongBan();
            this.uC_Luong1 = new AppQL_NhanSu.UC_Luong();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_ChucVu1 = new AppQL_NhanSu.UC_ChucVu();
            this.SilePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.SilePanel);
            this.panel1.Controls.Add(this.btn_ChucVu);
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Luong);
            this.panel1.Controls.Add(this.log_out);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_PhongBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 523);
            this.panel1.TabIndex = 10;
            // 
            // btn_ChucVu
            // 
            this.btn_ChucVu.FlatAppearance.BorderSize = 0;
            this.btn_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChucVu.Location = new System.Drawing.Point(0, 259);
            this.btn_ChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChucVu.Name = "btn_ChucVu";
            this.btn_ChucVu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_ChucVu.Size = new System.Drawing.Size(175, 38);
            this.btn_ChucVu.TabIndex = 13;
            this.btn_ChucVu.Text = "Chức Vụ";
            this.btn_ChucVu.UseVisualStyleBackColor = true;
            this.btn_ChucVu.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(29, 89);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(27, 17);
            this.lb_userName.TabIndex = 12;
            this.lb_userName.Text = "lad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Luong
            // 
            this.btn_Luong.FlatAppearance.BorderSize = 0;
            this.btn_Luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luong.Location = new System.Drawing.Point(0, 217);
            this.btn_Luong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luong.Name = "btn_Luong";
            this.btn_Luong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Luong.Size = new System.Drawing.Size(175, 38);
            this.btn_Luong.TabIndex = 7;
            this.btn_Luong.Text = "Lương";
            this.btn_Luong.UseVisualStyleBackColor = true;
            this.btn_Luong.Click += new System.EventHandler(this.btn_Luong_Click);
            // 
            // log_out
            // 
            this.log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_out.Location = new System.Drawing.Point(3, 487);
            this.log_out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(139, 32);
            this.log_out.TabIndex = 9;
            this.log_out.Text = "Đăng Xuất";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 143);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(175, 38);
            this.btn_NhanVien.TabIndex = 5;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_PhongBan
            // 
            this.btn_PhongBan.FlatAppearance.BorderSize = 0;
            this.btn_PhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhongBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_PhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhongBan.Location = new System.Drawing.Point(0, 180);
            this.btn_PhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PhongBan.Name = "btn_PhongBan";
            this.btn_PhongBan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_PhongBan.Size = new System.Drawing.Size(175, 38);
            this.btn_PhongBan.TabIndex = 6;
            this.btn_PhongBan.Text = "Phòng Ban";
            this.btn_PhongBan.UseVisualStyleBackColor = true;
            this.btn_PhongBan.Click += new System.EventHandler(this.btn_PhongBan_Click);
            // 
            // uC_PhongBan1
            // 
            this.uC_PhongBan1.Location = new System.Drawing.Point(0, 0);
            this.uC_PhongBan1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_PhongBan1.Name = "uC_PhongBan1";
            this.uC_PhongBan1.Size = new System.Drawing.Size(656, 425);
            this.uC_PhongBan1.TabIndex = 0;
            // 
            // uC_Luong1
            // 
            this.uC_Luong1.Location = new System.Drawing.Point(0, 0);
            this.uC_Luong1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Luong1.Name = "uC_Luong1";
            this.uC_Luong1.Size = new System.Drawing.Size(656, 425);
            this.uC_Luong1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_ChucVu1);
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 523);
            this.panel2.TabIndex = 11;
            // 
            // uC_ChucVu1
            // 
            this.uC_ChucVu1.Location = new System.Drawing.Point(-3, 0);
            this.uC_ChucVu1.Name = "uC_ChucVu1";
            this.uC_ChucVu1.Size = new System.Drawing.Size(875, 523);
            this.uC_ChucVu1.TabIndex = 0;
            // 
            // SilePanel
            // 
            this.SilePanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SilePanel.Location = new System.Drawing.Point(0, 143);
            this.SilePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SilePanel.Name = "SilePanel";
            this.SilePanel.Size = new System.Drawing.Size(11, 38);
            this.SilePanel.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Luong;
        private System.Windows.Forms.Button btn_PhongBan;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private UC_PhongBan uC_PhongBan1;
        private UC_Luong uC_Luong1;
        private UC_NhanVien1 uC_NhanVien1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ChucVu;
        private UC_ChucVu uC_ChucVu1;
        private System.Windows.Forms.Panel SilePanel;
    }
}