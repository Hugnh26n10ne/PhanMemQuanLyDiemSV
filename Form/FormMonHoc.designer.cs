namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormMonHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
            this.dtgrv_MonHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.cbx_TKChucVu = new System.Windows.Forms.ComboBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.gbx_NhapChiTietDiem = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.cbx_TKMonHoc = new System.Windows.Forms.ComboBox();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TongKetHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_MonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbx_NhapChiTietDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrv_MonHoc
            // 
            this.dtgrv_MonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_MonHoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_MaMon,
            this.dtgrv_TenMon,
            this.dtgrv_SoTinChi,
            this.dtgrv_SoTiet,
            this.dtgrv_TenGV,
            this.dtgrv_TongKetHP,
            this.dtgrv_DiemChu});
            this.dtgrv_MonHoc.Location = new System.Drawing.Point(14, 331);
            this.dtgrv_MonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrv_MonHoc.Name = "dtgrv_MonHoc";
            this.dtgrv_MonHoc.ReadOnly = true;
            this.dtgrv_MonHoc.RowHeadersWidth = 51;
            this.dtgrv_MonHoc.RowTemplate.Height = 24;
            this.dtgrv_MonHoc.Size = new System.Drawing.Size(1184, 645);
            this.dtgrv_MonHoc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbx_TimKiem);
            this.groupBox1.Controls.Add(this.btn_NhapExcel);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_CapNhat);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Thêm);
            this.groupBox1.Controls.Add(this.btn_XuatExcel);
            this.groupBox1.Controls.Add(this.cbx_TKMonHoc);
            this.groupBox1.Controls.Add(this.tbx_TimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_TKChucVu);
            this.groupBox1.Controls.Add(this.ln_chonhocki);
            this.groupBox1.Location = new System.Drawing.Point(14, 200);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1184, 123);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.AutoSize = true;
            this.btn_NhapExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NhapExcel.FlatAppearance.BorderSize = 0;
            this.btn_NhapExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapExcel.ForeColor = System.Drawing.Color.White;
            this.btn_NhapExcel.Location = new System.Drawing.Point(663, 21);
            this.btn_NhapExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(159, 37);
            this.btn_NhapExcel.TabIndex = 35;
            this.btn_NhapExcel.Text = "Nhập Excel";
            this.btn_NhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(487, 23);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 33);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Orange;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btn_CapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(331, 23);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(126, 33);
            this.btn_CapNhat.TabIndex = 33;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(175, 23);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 33);
            this.btn_Luu.TabIndex = 32;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Thêm.FlatAppearance.BorderSize = 0;
            this.btn_Thêm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Thêm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thêm.ForeColor = System.Drawing.Color.White;
            this.btn_Thêm.Location = new System.Drawing.Point(18, 23);
            this.btn_Thêm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(127, 33);
            this.btn_Thêm.TabIndex = 31;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = false;
            // 
            // cbx_TKChucVu
            // 
            this.cbx_TKChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_TKChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_TKChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_TKChucVu.FormattingEnabled = true;
            this.cbx_TKChucVu.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2",
            "Học kì 3"});
            this.cbx_TKChucVu.Location = new System.Drawing.Point(997, 29);
            this.cbx_TKChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_TKChucVu.Name = "cbx_TKChucVu";
            this.cbx_TKChucVu.Size = new System.Drawing.Size(176, 31);
            this.cbx_TKChucVu.TabIndex = 24;
            this.cbx_TKChucVu.Text = "-Chọn tên giảng viên-";
            // 
            // ln_chonhocki
            // 
            this.ln_chonhocki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_chonhocki.AutoSize = true;
            this.ln_chonhocki.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_chonhocki.Location = new System.Drawing.Point(873, 33);
            this.ln_chonhocki.Name = "ln_chonhocki";
            this.ln_chonhocki.Size = new System.Drawing.Size(91, 23);
            this.ln_chonhocki.TabIndex = 25;
            this.ln_chonhocki.Text = "Giảng viên";
            // 
            // gbx_NhapChiTietDiem
            // 
            this.gbx_NhapChiTietDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_NhapChiTietDiem.Controls.Add(this.textBox6);
            this.gbx_NhapChiTietDiem.Controls.Add(this.textBox7);
            this.gbx_NhapChiTietDiem.Controls.Add(this.textBox8);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label10);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label11);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label12);
            this.gbx_NhapChiTietDiem.Controls.Add(this.textBox9);
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
            this.gbx_NhapChiTietDiem.Location = new System.Drawing.Point(14, 12);
            this.gbx_NhapChiTietDiem.Name = "gbx_NhapChiTietDiem";
            this.gbx_NhapChiTietDiem.Size = new System.Drawing.Size(1184, 181);
            this.gbx_NhapChiTietDiem.TabIndex = 24;
            this.gbx_NhapChiTietDiem.TabStop = false;
            this.gbx_NhapChiTietDiem.Text = "Chi Tiết Môn Học";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(920, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 30);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(663, 133);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(96, 30);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(420, 137);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(96, 30);
            this.textBox8.TabIndex = 23;
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
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(153, 137);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(96, 30);
            this.textBox9.TabIndex = 18;
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
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảng viên";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(873, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên môn";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(18, 72);
            this.tbx_TimKiem.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(304, 30);
            this.tbx_TimKiem.TabIndex = 26;
            this.tbx_TimKiem.Text = "(Nhập mã môn)";
            // 
            // cbx_TKMonHoc
            // 
            this.cbx_TKMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_TKMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_TKMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_TKMonHoc.FormattingEnabled = true;
            this.cbx_TKMonHoc.Items.AddRange(new object[] {
            "Toán ",
            "Lý ",
            "Hóa ",
            "Lập trình C++"});
            this.cbx_TKMonHoc.Location = new System.Drawing.Point(997, 72);
            this.cbx_TKMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_TKMonHoc.Name = "cbx_TKMonHoc";
            this.cbx_TKMonHoc.Size = new System.Drawing.Size(176, 31);
            this.cbx_TKMonHoc.TabIndex = 28;
            this.cbx_TKMonHoc.Text = "-Chọn tên môn-";
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.AutoSize = true;
            this.btn_XuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.Location = new System.Drawing.Point(663, 69);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(159, 37);
            this.btn_XuatExcel.TabIndex = 30;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(341, 72);
            this.pbx_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(26, 30);
            this.pbx_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_TimKiem.TabIndex = 36;
            this.pbx_TimKiem.TabStop = false;
            // 
            // dtgrv_Stt
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_Stt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv_Stt.HeaderText = "STT";
            this.dtgrv_Stt.MinimumWidth = 6;
            this.dtgrv_Stt.Name = "dtgrv_Stt";
            this.dtgrv_Stt.ReadOnly = true;
            this.dtgrv_Stt.Width = 50;
            // 
            // dtgrv_MaMon
            // 
            this.dtgrv_MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_MaMon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv_MaMon.HeaderText = "Mã môn";
            this.dtgrv_MaMon.MinimumWidth = 6;
            this.dtgrv_MaMon.Name = "dtgrv_MaMon";
            this.dtgrv_MaMon.ReadOnly = true;
            // 
            // dtgrv_TenMon
            // 
            this.dtgrv_TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_TenMon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrv_TenMon.HeaderText = "Tên môn";
            this.dtgrv_TenMon.MinimumWidth = 6;
            this.dtgrv_TenMon.Name = "dtgrv_TenMon";
            this.dtgrv_TenMon.ReadOnly = true;
            // 
            // dtgrv_SoTinChi
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_SoTinChi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrv_SoTinChi.HeaderText = "Số TC";
            this.dtgrv_SoTinChi.MinimumWidth = 6;
            this.dtgrv_SoTinChi.Name = "dtgrv_SoTinChi";
            this.dtgrv_SoTinChi.ReadOnly = true;
            this.dtgrv_SoTinChi.Width = 50;
            // 
            // dtgrv_SoTiet
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_SoTiet.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrv_SoTiet.HeaderText = "Số tiết";
            this.dtgrv_SoTiet.MinimumWidth = 6;
            this.dtgrv_SoTiet.Name = "dtgrv_SoTiet";
            this.dtgrv_SoTiet.ReadOnly = true;
            this.dtgrv_SoTiet.Width = 50;
            // 
            // dtgrv_TenGV
            // 
            this.dtgrv_TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_TenGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrv_TenGV.HeaderText = "Tên GV";
            this.dtgrv_TenGV.MinimumWidth = 6;
            this.dtgrv_TenGV.Name = "dtgrv_TenGV";
            this.dtgrv_TenGV.ReadOnly = true;
            // 
            // dtgrv_TongKetHP
            // 
            this.dtgrv_TongKetHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_TongKetHP.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgrv_TongKetHP.HeaderText = "Tổng kết HP";
            this.dtgrv_TongKetHP.MinimumWidth = 6;
            this.dtgrv_TongKetHP.Name = "dtgrv_TongKetHP";
            this.dtgrv_TongKetHP.ReadOnly = true;
            // 
            // dtgrv_DiemChu
            // 
            this.dtgrv_DiemChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_DiemChu.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgrv_DiemChu.HeaderText = "Điểm chữ";
            this.dtgrv_DiemChu.MinimumWidth = 6;
            this.dtgrv_DiemChu.Name = "dtgrv_DiemChu";
            this.dtgrv_DiemChu.ReadOnly = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1204, 993);
            this.Controls.Add(this.gbx_NhapChiTietDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrv_MonHoc);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_MonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbx_NhapChiTietDiem.ResumeLayout(false);
            this.gbx_NhapChiTietDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv_MonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.ComboBox cbx_TKChucVu;
        private System.Windows.Forms.Label ln_chonhocki;
        private System.Windows.Forms.GroupBox gbx_NhapChiTietDiem;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_ChuyenCan;
        private System.Windows.Forms.TextBox tbx_DanhGia;
        private System.Windows.Forms.TextBox tbx_LanThi;
        private System.Windows.Forms.TextBox tbx_LanHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_SoTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_MaHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_MaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_TimKiem;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.ComboBox cbx_TKMonHoc;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TongKetHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemChu;
    }
}

