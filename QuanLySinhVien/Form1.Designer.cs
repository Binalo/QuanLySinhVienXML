namespace QuanLySinhVien
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gridviewSinhvien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(237, 378);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(297, 22);
            this.txtmasv.TabIndex = 4;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(237, 416);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(297, 22);
            this.txtHoten.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(237, 454);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(297, 22);
            this.txtLop.TabIndex = 6;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(237, 492);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(297, 22);
            this.txtDiachi.TabIndex = 7;
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(580, 379);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(86, 46);
            this.btnDocFile.TabIndex = 8;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(580, 425);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 46);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 46);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 46);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(677, 426);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 46);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(677, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 44);
            this.button6.TabIndex = 13;
            this.button6.Text = "Đóng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gridviewSinhvien
            // 
            this.gridviewSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.lop,
            this.diachi});
            this.gridviewSinhvien.Location = new System.Drawing.Point(51, 58);
            this.gridviewSinhvien.Name = "gridviewSinhvien";
            this.gridviewSinhvien.RowHeadersWidth = 51;
            this.gridviewSinhvien.RowTemplate.Height = 24;
            this.gridviewSinhvien.Size = new System.Drawing.Size(782, 268);
            this.gridviewSinhvien.TabIndex = 14;
            // 
            // masv
            // 
            this.masv.HeaderText = "Mã Sinh Vien";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Và Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 175;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 90;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 597);
            this.Controls.Add(this.gridviewSinhvien);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView gridviewSinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}

