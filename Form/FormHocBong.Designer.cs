namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormHocBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocBong));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_XuatFileExcel = new System.Windows.Forms.Button();
            this.cbx_ChonNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ChonHocKy = new System.Windows.Forms.ComboBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.dtgrv_HocBong = new System.Windows.Forms.DataGridView();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_NganhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo10N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo10N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo4N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo4N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTCN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTCN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_LopHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Khoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_HocBong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "DANH SÁCH HỌC BỔNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbx_LopHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_Khoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbx_TimKiem);
            this.groupBox1.Controls.Add(this.btn_NhapExcel);
            this.groupBox1.Controls.Add(this.tbx_TimKiem);
            this.groupBox1.Controls.Add(this.btn_XuatFileExcel);
            this.groupBox1.Controls.Add(this.cbx_ChonNamHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_ChonHocKy);
            this.groupBox1.Controls.Add(this.ln_chonhocki);
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 133);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NhapExcel.AutoSize = true;
            this.btn_NhapExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NhapExcel.FlatAppearance.BorderSize = 0;
            this.btn_NhapExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapExcel.ForeColor = System.Drawing.Color.White;
            this.btn_NhapExcel.Location = new System.Drawing.Point(1142, 27);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(141, 33);
            this.btn_NhapExcel.TabIndex = 35;
            this.btn_NhapExcel.Text = "Nhập Excel";
            this.btn_NhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFileExcel
            // 
            this.btn_XuatFileExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XuatFileExcel.AutoSize = true;
            this.btn_XuatFileExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatFileExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatFileExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatFileExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatFileExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatFileExcel.Location = new System.Drawing.Point(967, 27);
            this.btn_XuatFileExcel.Name = "btn_XuatFileExcel";
            this.btn_XuatFileExcel.Size = new System.Drawing.Size(141, 33);
            this.btn_XuatFileExcel.TabIndex = 30;
            this.btn_XuatFileExcel.Text = "Xuất Excel";
            this.btn_XuatFileExcel.UseVisualStyleBackColor = false;
            // 
            // cbx_ChonNamHoc
            // 
            this.cbx_ChonNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_ChonNamHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_ChonNamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_ChonNamHoc.FormattingEnabled = true;
            this.cbx_ChonNamHoc.Items.AddRange(new object[] {
            "Toán ",
            "Lý ",
            "Hóa ",
            "Lập trình C++"});
            this.cbx_ChonNamHoc.Location = new System.Drawing.Point(488, 27);
            this.cbx_ChonNamHoc.Name = "cbx_ChonNamHoc";
            this.cbx_ChonNamHoc.Size = new System.Drawing.Size(157, 31);
            this.cbx_ChonNamHoc.TabIndex = 28;
            this.cbx_ChonNamHoc.Text = "-Chọn năm học-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Năm Học";
            // 
            // cbx_ChonHocKy
            // 
            this.cbx_ChonHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_ChonHocKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_ChonHocKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_ChonHocKy.FormattingEnabled = true;
            this.cbx_ChonHocKy.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2",
            "Học kì 3"});
            this.cbx_ChonHocKy.Location = new System.Drawing.Point(789, 29);
            this.cbx_ChonHocKy.Name = "cbx_ChonHocKy";
            this.cbx_ChonHocKy.Size = new System.Drawing.Size(157, 31);
            this.cbx_ChonHocKy.TabIndex = 24;
            this.cbx_ChonHocKy.Text = "-Chọn học kỳ-";
            // 
            // ln_chonhocki
            // 
            this.ln_chonhocki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_chonhocki.AutoSize = true;
            this.ln_chonhocki.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_chonhocki.Location = new System.Drawing.Point(697, 33);
            this.ln_chonhocki.Name = "ln_chonhocki";
            this.ln_chonhocki.Size = new System.Drawing.Size(67, 23);
            this.ln_chonhocki.TabIndex = 25;
            this.ln_chonhocki.Text = "Học Kỳ ";
            // 
            // dtgrv_HocBong
            // 
            this.dtgrv_HocBong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_HocBong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_HocBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_HocBong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_NamHoc,
            this.dtgrv_HocKi,
            this.dtgrv_MaSV,
            this.dtgrv_HoVaTen,
            this.dtgrv_LopHoc,
            this.dtgrv_NganhHoc,
            this.dtgrv_Khoa,
            this.dtgrv_SoDienThoai,
            this.dtgrv_TBHeSo10N1,
            this.dtgrv_TBHeSo10N2,
            this.dtgrv_TBHeSo4N1,
            this.dtgrv_TBHeSo4N2,
            this.dtgrv_SoTCN1,
            this.dtgrv_SoTCN2});
            this.dtgrv_HocBong.Location = new System.Drawing.Point(21, 243);
            this.dtgrv_HocBong.Name = "dtgrv_HocBong";
            this.dtgrv_HocBong.RowHeadersWidth = 51;
            this.dtgrv_HocBong.RowTemplate.Height = 24;
            this.dtgrv_HocBong.Size = new System.Drawing.Size(1294, 431);
            this.dtgrv_HocBong.TabIndex = 40;
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(338, 29);
            this.pbx_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(26, 30);
            this.pbx_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_TimKiem.TabIndex = 44;
            this.pbx_TimKiem.TabStop = false;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(15, 29);
            this.tbx_TimKiem.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(304, 30);
            this.tbx_TimKiem.TabIndex = 43;
            this.tbx_TimKiem.Text = "(Tìm kiếm mã sinh viên, họ và tên)";
            // 
            // dtgrv_Stt
            // 
            this.dtgrv_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_Stt.HeaderText = "STT";
            this.dtgrv_Stt.MinimumWidth = 6;
            this.dtgrv_Stt.Name = "dtgrv_Stt";
            // 
            // dtgrv_NamHoc
            // 
            this.dtgrv_NamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_NamHoc.DataPropertyName = "ma_sv";
            this.dtgrv_NamHoc.HeaderText = "Năm học";
            this.dtgrv_NamHoc.MinimumWidth = 6;
            this.dtgrv_NamHoc.Name = "dtgrv_NamHoc";
            // 
            // dtgrv_HocKi
            // 
            this.dtgrv_HocKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_HocKi.HeaderText = "Học kì";
            this.dtgrv_HocKi.MinimumWidth = 6;
            this.dtgrv_HocKi.Name = "dtgrv_HocKi";
            // 
            // dtgrv_MaSV
            // 
            this.dtgrv_MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_MaSV.HeaderText = "Mã sinh viên";
            this.dtgrv_MaSV.MinimumWidth = 6;
            this.dtgrv_MaSV.Name = "dtgrv_MaSV";
            // 
            // dtgrv_HoVaTen
            // 
            this.dtgrv_HoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_HoVaTen.HeaderText = "Họ và tên";
            this.dtgrv_HoVaTen.MinimumWidth = 6;
            this.dtgrv_HoVaTen.Name = "dtgrv_HoVaTen";
            // 
            // dtgrv_LopHoc
            // 
            this.dtgrv_LopHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_LopHoc.HeaderText = "Lớp học";
            this.dtgrv_LopHoc.MinimumWidth = 6;
            this.dtgrv_LopHoc.Name = "dtgrv_LopHoc";
            // 
            // dtgrv_NganhHoc
            // 
            this.dtgrv_NganhHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_NganhHoc.HeaderText = "Ngành học";
            this.dtgrv_NganhHoc.MinimumWidth = 6;
            this.dtgrv_NganhHoc.Name = "dtgrv_NganhHoc";
            // 
            // dtgrv_Khoa
            // 
            this.dtgrv_Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_Khoa.HeaderText = "Khoa";
            this.dtgrv_Khoa.MinimumWidth = 6;
            this.dtgrv_Khoa.Name = "dtgrv_Khoa";
            // 
            // dtgrv_SoDienThoai
            // 
            this.dtgrv_SoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoDienThoai.HeaderText = "Số Điện Thoại";
            this.dtgrv_SoDienThoai.MinimumWidth = 6;
            this.dtgrv_SoDienThoai.Name = "dtgrv_SoDienThoai";
            // 
            // dtgrv_TBHeSo10N1
            // 
            this.dtgrv_TBHeSo10N1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TBHeSo10N1.DataPropertyName = "ten_mh";
            this.dtgrv_TBHeSo10N1.HeaderText = "TB Hệ 10 N1";
            this.dtgrv_TBHeSo10N1.MinimumWidth = 6;
            this.dtgrv_TBHeSo10N1.Name = "dtgrv_TBHeSo10N1";
            // 
            // dtgrv_TBHeSo10N2
            // 
            this.dtgrv_TBHeSo10N2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TBHeSo10N2.HeaderText = "TB Hệ 10 N2";
            this.dtgrv_TBHeSo10N2.MinimumWidth = 6;
            this.dtgrv_TBHeSo10N2.Name = "dtgrv_TBHeSo10N2";
            // 
            // dtgrv_TBHeSo4N1
            // 
            this.dtgrv_TBHeSo4N1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TBHeSo4N1.HeaderText = "TB Hệ 4 N1";
            this.dtgrv_TBHeSo4N1.MinimumWidth = 6;
            this.dtgrv_TBHeSo4N1.Name = "dtgrv_TBHeSo4N1";
            // 
            // dtgrv_TBHeSo4N2
            // 
            this.dtgrv_TBHeSo4N2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TBHeSo4N2.HeaderText = "TB Hệ 4 N2";
            this.dtgrv_TBHeSo4N2.MinimumWidth = 6;
            this.dtgrv_TBHeSo4N2.Name = "dtgrv_TBHeSo4N2";
            // 
            // dtgrv_SoTCN1
            // 
            this.dtgrv_SoTCN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTCN1.HeaderText = "Số TC N1";
            this.dtgrv_SoTCN1.MinimumWidth = 6;
            this.dtgrv_SoTCN1.Name = "dtgrv_SoTCN1";
            // 
            // dtgrv_SoTCN2
            // 
            this.dtgrv_SoTCN2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTCN2.HeaderText = "Số TC N2";
            this.dtgrv_SoTCN2.MinimumWidth = 6;
            this.dtgrv_SoTCN2.Name = "dtgrv_SoTCN2";
            // 
            // cbx_LopHoc
            // 
            this.cbx_LopHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_LopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_LopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_LopHoc.FormattingEnabled = true;
            this.cbx_LopHoc.Items.AddRange(new object[] {
            "Toán ",
            "Lý ",
            "Hóa ",
            "Lập trình C++"});
            this.cbx_LopHoc.Location = new System.Drawing.Point(488, 79);
            this.cbx_LopHoc.Name = "cbx_LopHoc";
            this.cbx_LopHoc.Size = new System.Drawing.Size(157, 31);
            this.cbx_LopHoc.TabIndex = 48;
            this.cbx_LopHoc.Text = "-Chọn lớp học-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Lớp Học";
            // 
            // cbx_Khoa
            // 
            this.cbx_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Khoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_Khoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_Khoa.FormattingEnabled = true;
            this.cbx_Khoa.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2",
            "Học kì 3"});
            this.cbx_Khoa.Location = new System.Drawing.Point(789, 81);
            this.cbx_Khoa.Name = "cbx_Khoa";
            this.cbx_Khoa.Size = new System.Drawing.Size(157, 31);
            this.cbx_Khoa.TabIndex = 45;
            this.cbx_Khoa.Text = "-Chọn khoa-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Khoa";
            // 
            // FormHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrv_HocBong);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHocBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_HocBong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_XuatFileExcel;
        private System.Windows.Forms.ComboBox cbx_ChonNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_ChonHocKy;
        private System.Windows.Forms.Label ln_chonhocki;
        private System.Windows.Forms.DataGridView dtgrv_HocBong;
        private System.Windows.Forms.ComboBox cbx_LopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Khoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbx_TimKiem;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_NganhHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo10N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo10N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo4N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo4N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTCN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTCN2;
    }
}