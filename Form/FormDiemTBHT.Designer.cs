namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormDiemTBHT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiemTBHT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_NganhHoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_XuatFileExcel = new System.Windows.Forms.Button();
            this.cbx_ChonNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ChonHocKy = new System.Windows.Forms.ComboBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.gbx_NhapChiTietDiem = new System.Windows.Forms.GroupBox();
            this.tbx_ThiKT = new System.Windows.Forms.TextBox();
            this.tbx_KTGiuaKy = new System.Windows.Forms.TextBox();
            this.tbx_DiemTL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_DiemTH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_ChuyenCan = new System.Windows.Forms.TextBox();
            this.tbx_DanhGia = new System.Windows.Forms.TextBox();
            this.tbx_LanThi = new System.Windows.Forms.TextBox();
            this.tbx_LanHoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_SoTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_MaHP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_MaSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrv_BangDiemTBHTSV = new System.Windows.Forms.DataGridView();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_LanHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_ChuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_KTGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_ThiKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TongKetHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.gbx_NhapChiTietDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_BangDiemTBHTSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_NhapExcel);
            this.groupBox1.Controls.Add(this.btn_XuatFileExcel);
            this.groupBox1.Controls.Add(this.cbx_ChonNamHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_ChonHocKy);
            this.groupBox1.Controls.Add(this.ln_chonhocki);
            this.groupBox1.Location = new System.Drawing.Point(13, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 81);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // cbx_NganhHoc
            // 
            this.cbx_NganhHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_NganhHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_NganhHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_NganhHoc.FormattingEnabled = true;
            this.cbx_NganhHoc.Items.AddRange(new object[] {
            "Toán ",
            "Lý ",
            "Hóa ",
            "Lập trình C++"});
            this.cbx_NganhHoc.Location = new System.Drawing.Point(906, 92);
            this.cbx_NganhHoc.Name = "cbx_NganhHoc";
            this.cbx_NganhHoc.Size = new System.Drawing.Size(157, 31);
            this.cbx_NganhHoc.TabIndex = 38;
            this.cbx_NganhHoc.Text = "-Chọn ngành học-";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(814, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ngành";
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(305, 78);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(31, 26);
            this.pbx_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_TimKiem.TabIndex = 36;
            this.pbx_TimKiem.TabStop = false;
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.AutoSize = true;
            this.btn_NhapExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NhapExcel.FlatAppearance.BorderSize = 0;
            this.btn_NhapExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapExcel.ForeColor = System.Drawing.Color.White;
            this.btn_NhapExcel.Location = new System.Drawing.Point(908, 28);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(141, 33);
            this.btn_NhapExcel.TabIndex = 35;
            this.btn_NhapExcel.Text = "Nhập Excel";
            this.btn_NhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFileExcel
            // 
            this.btn_XuatFileExcel.AutoSize = true;
            this.btn_XuatFileExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatFileExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatFileExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatFileExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatFileExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatFileExcel.Location = new System.Drawing.Point(733, 28);
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
            this.cbx_ChonNamHoc.Location = new System.Drawing.Point(122, 29);
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
            this.label1.Location = new System.Drawing.Point(30, 33);
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
            this.cbx_ChonHocKy.Location = new System.Drawing.Point(448, 29);
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
            this.ln_chonhocki.Location = new System.Drawing.Point(356, 33);
            this.ln_chonhocki.Name = "ln_chonhocki";
            this.ln_chonhocki.Size = new System.Drawing.Size(67, 23);
            this.ln_chonhocki.TabIndex = 25;
            this.ln_chonhocki.Text = "Học Kỳ ";
            // 
            // dtgrv_BangDiemTBHTSV
            // 
            this.gbx_NhapChiTietDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_ThiKT);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_KTGiuaKy);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_DiemTL);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label10);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label11);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label12);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_DiemTH);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label13);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_ChuyenCan);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_DanhGia);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_LanThi);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_LanHoc);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label8);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label7);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label6);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label5);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_SoTC);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label4);
            this.gbx_NhapChiTietDiem.Controls.Add(this.cbx_MaHP);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label3);
            this.gbx_NhapChiTietDiem.Controls.Add(this.cbx_MaSV);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label2);
            this.gbx_NhapChiTietDiem.Location = new System.Drawing.Point(12, 12);
            this.gbx_NhapChiTietDiem.Name = "gbx_NhapChiTietDiem";
            this.gbx_NhapChiTietDiem.Size = new System.Drawing.Size(1072, 181);
            this.gbx_NhapChiTietDiem.TabIndex = 22;
            this.gbx_NhapChiTietDiem.TabStop = false;
            this.gbx_NhapChiTietDiem.Text = "Chi Tiết Điểm Trung Bình Học Tập";
            // 
            // tbx_ThiKT
            // 
            this.tbx_ThiKT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ThiKT.Location = new System.Drawing.Point(920, 137);
            this.tbx_ThiKT.Name = "tbx_ThiKT";
            this.tbx_ThiKT.Size = new System.Drawing.Size(96, 30);
            this.tbx_ThiKT.TabIndex = 25;
            // 
            // tbx_KTGiuaKy
            // 
            this.tbx_KTGiuaKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_KTGiuaKy.Location = new System.Drawing.Point(663, 133);
            this.tbx_KTGiuaKy.Name = "tbx_KTGiuaKy";
            this.tbx_KTGiuaKy.Size = new System.Drawing.Size(96, 30);
            this.tbx_KTGiuaKy.TabIndex = 24;
            // 
            // tbx_DiemTL
            // 
            this.tbx_DiemTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_DiemTL.Location = new System.Drawing.Point(420, 137);
            this.tbx_DiemTL.Name = "tbx_DiemTL";
            this.tbx_DiemTL.Size = new System.Drawing.Size(96, 30);
            this.tbx_DiemTL.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(795, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thi kết thúc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "KT Giữa Kỳ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Điểm thảo luận";
            // 
            // tbx_DiemTH
            // 
            this.tbx_DiemTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_DiemTH.Location = new System.Drawing.Point(153, 137);
            this.tbx_DiemTH.Name = "tbx_DiemTH";
            this.tbx_DiemTH.Size = new System.Drawing.Size(96, 30);
            this.tbx_DiemTH.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 23);
            this.label13.TabIndex = 17;
            this.label13.Text = "Điểm thực hành";
            // 
            // tbx_ChuyenCan
            // 
            this.tbx_ChuyenCan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ChuyenCan.Location = new System.Drawing.Point(921, 90);
            this.tbx_ChuyenCan.Name = "tbx_ChuyenCan";
            this.tbx_ChuyenCan.Size = new System.Drawing.Size(96, 30);
            this.tbx_ChuyenCan.TabIndex = 16;
            // 
            // tbx_DanhGia
            // 
            this.tbx_DanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_DanhGia.Location = new System.Drawing.Point(699, 90);
            this.tbx_DanhGia.Name = "tbx_DanhGia";
            this.tbx_DanhGia.Size = new System.Drawing.Size(96, 30);
            this.tbx_DanhGia.TabIndex = 15;
            // 
            // tbx_LanThi
            // 
            this.tbx_LanThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_LanThi.Location = new System.Drawing.Point(494, 90);
            this.tbx_LanThi.Name = "tbx_LanThi";
            this.tbx_LanThi.Size = new System.Drawing.Size(96, 30);
            this.tbx_LanThi.TabIndex = 14;
            // 
            // tbx_LanHoc
            // 
            this.tbx_LanHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_LanHoc.Location = new System.Drawing.Point(295, 90);
            this.tbx_LanHoc.Name = "tbx_LanHoc";
            this.tbx_LanHoc.Size = new System.Drawing.Size(96, 30);
            this.tbx_LanHoc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(815, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chuyên cần";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đánh giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lần thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lần học";
            // 
            // tbx_SoTC
            // 
            this.tbx_SoTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_SoTC.Location = new System.Drawing.Point(101, 90);
            this.tbx_SoTC.Name = "tbx_SoTC";
            this.tbx_SoTC.Size = new System.Drawing.Size(96, 30);
            this.tbx_SoTC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tín chỉ";
            // 
            // cbx_MaHP
            // 
            this.cbx_MaHP.FormattingEnabled = true;
            this.cbx_MaHP.Location = new System.Drawing.Point(388, 36);
            this.cbx_MaHP.Name = "cbx_MaHP";
            this.cbx_MaHP.Size = new System.Drawing.Size(198, 31);
            this.cbx_MaHP.TabIndex = 3;
            this.cbx_MaHP.Text = "-Học Phần -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học phần";
            // 
            // cbx_MaSV
            // 
            this.cbx_MaSV.FormattingEnabled = true;
            this.cbx_MaSV.Location = new System.Drawing.Point(101, 36);
            this.cbx_MaSV.Name = "cbx_MaSV";
            this.cbx_MaSV.Size = new System.Drawing.Size(185, 31);
            this.cbx_MaSV.TabIndex = 1;
            this.cbx_MaSV.Text = "-Sinh Viên -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sinh viên";
            // 
            // dtgrv_BangDiemTBHTSV
            // 
            this.dtgrv_BangDiemTBHTSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_BangDiemTBHTSV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_BangDiemTBHTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_BangDiemTBHTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_MaSV,
            this.dtgrv_MaHP,
            this.dtgrv_TenHP,
            this.dtgrv_SoTinChi,
            this.dtgrv_LanHoc,
            this.dtgrv_LanThi,
            this.dtgrv_DanhGia,
            this.dtgrv_ChuyenCan,
            this.dtgrv_DiemTH,
            this.dtgrv_DiemTL,
            this.dtgrv_KTGiuaKy,
            this.dtgrv_ThiKetThuc,
            this.dtgrv_TongKetHP,
            this.dtgrv_DiemChu});
            this.dtgrv_BangDiemTBHTSV.Location = new System.Drawing.Point(13, 347);
            this.dtgrv_BangDiemTBHTSV.Name = "dtgrv_BangDiemTBHTSV";
            this.dtgrv_BangDiemTBHTSV.RowHeadersWidth = 51;
            this.dtgrv_BangDiemTBHTSV.RowTemplate.Height = 24;
            this.dtgrv_BangDiemTBHTSV.Size = new System.Drawing.Size(1071, 495);
            this.dtgrv_BangDiemTBHTSV.TabIndex = 21;
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
            // FormDiemTBHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_NhapChiTietDiem);
            this.Controls.Add(this.dtgrv_BangDiemTBHTSV);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiemTBHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.gbx_NhapChiTietDiem.ResumeLayout(false);
            this.gbx_NhapChiTietDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_BangDiemTBHTSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_XuatFileExcel;
        private System.Windows.Forms.ComboBox cbx_ChonNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_ChonHocKy;
        private System.Windows.Forms.Label ln_chonhocki;
        private System.Windows.Forms.DataGridView dtgrv_BangDiemTBHTSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo10N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo10N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo4N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TBHeSo4N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTCN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTCN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrv_BangDiemTBHTSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_LanHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_ChuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_KTGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_ThiKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TongKetHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemChu;
    }
}