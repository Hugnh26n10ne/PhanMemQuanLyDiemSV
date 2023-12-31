namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemTaiKhoan));
            this.dtgrv_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.cbx_ChonMonHoc = new System.Windows.Forms.ComboBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ChonChucVu = new System.Windows.Forms.ComboBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.gbx_NhapChiTietDiem = new System.Windows.Forms.GroupBox();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_TrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_ChucVu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrv_TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_TaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.gbx_NhapChiTietDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrv_TaiKhoan
            // 
            this.dtgrv_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_TK,
            this.dtgrv_MatKhau,
            this.dtgrv_ChucVu,
            this.dtgrv_TrangThai});
            this.dtgrv_TaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrv_TaiKhoan.Location = new System.Drawing.Point(1, 228);
            this.dtgrv_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrv_TaiKhoan.Name = "dtgrv_TaiKhoan";
            this.dtgrv_TaiKhoan.RowHeadersWidth = 82;
            this.dtgrv_TaiKhoan.RowTemplate.Height = 33;
            this.dtgrv_TaiKhoan.Size = new System.Drawing.Size(1132, 381);
            this.dtgrv_TaiKhoan.TabIndex = 2;
            this.dtgrv_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_TaiKhoan_CellClick);
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
            this.groupBox1.Controls.Add(this.cbx_ChonMonHoc);
            this.groupBox1.Controls.Add(this.tbx_TimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_ChonChucVu);
            this.groupBox1.Controls.Add(this.ln_chonhocki);
            this.groupBox1.Location = new System.Drawing.Point(3, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1130, 113);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(343, 65);
            this.pbx_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(26, 30);
            this.pbx_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_TimKiem.TabIndex = 36;
            this.pbx_TimKiem.TabStop = false;
            this.pbx_TimKiem.Click += new System.EventHandler(this.pbx_TimKiem_Click);
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.AutoSize = true;
            this.btn_NhapExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NhapExcel.FlatAppearance.BorderSize = 0;
            this.btn_NhapExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapExcel.ForeColor = System.Drawing.Color.White;
            this.btn_NhapExcel.Location = new System.Drawing.Point(649, 21);
            this.btn_NhapExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(164, 48);
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
            this.btn_Xoa.Location = new System.Drawing.Point(492, 21);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 32);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Orange;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btn_CapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(335, 21);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(126, 32);
            this.btn_CapNhat.TabIndex = 33;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(178, 21);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 32);
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
            this.btn_Thêm.Location = new System.Drawing.Point(20, 21);
            this.btn_Thêm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(127, 32);
            this.btn_Thêm.TabIndex = 31;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = false;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.AutoSize = true;
            this.btn_XuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.Location = new System.Drawing.Point(649, 62);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(159, 48);
            this.btn_XuatExcel.TabIndex = 30;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // cbx_ChonMonHoc
            // 
            this.cbx_ChonMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_ChonMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_ChonMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_ChonMonHoc.FormattingEnabled = true;
            this.cbx_ChonMonHoc.Location = new System.Drawing.Point(945, 65);
            this.cbx_ChonMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_ChonMonHoc.Name = "cbx_ChonMonHoc";
            this.cbx_ChonMonHoc.Size = new System.Drawing.Size(176, 45);
            this.cbx_ChonMonHoc.TabIndex = 28;
            this.cbx_ChonMonHoc.Text = "-Chọn trạng thái-";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(20, 65);
            this.tbx_TimKiem.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(304, 44);
            this.tbx_TimKiem.TabIndex = 26;
            this.tbx_TimKiem.Text = "(Tìm kiếm tài khoản)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(841, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Trạng thái";
            // 
            // cbx_ChonChucVu
            // 
            this.cbx_ChonChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_ChonChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_ChonChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_ChonChucVu.FormattingEnabled = true;
            this.cbx_ChonChucVu.Location = new System.Drawing.Point(942, 27);
            this.cbx_ChonChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_ChonChucVu.Name = "cbx_ChonChucVu";
            this.cbx_ChonChucVu.Size = new System.Drawing.Size(176, 45);
            this.cbx_ChonChucVu.TabIndex = 24;
            this.cbx_ChonChucVu.Text = "-Chọn chức vụ-";
            // 
            // ln_chonhocki
            // 
            this.ln_chonhocki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_chonhocki.AutoSize = true;
            this.ln_chonhocki.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_chonhocki.Location = new System.Drawing.Point(841, 30);
            this.ln_chonhocki.Name = "ln_chonhocki";
            this.ln_chonhocki.Size = new System.Drawing.Size(116, 38);
            this.ln_chonhocki.TabIndex = 25;
            this.ln_chonhocki.Text = "Chức vụ";
            // 
            // gbx_NhapChiTietDiem
            // 
            this.gbx_NhapChiTietDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_MatKhau);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label5);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_TaiKhoan);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label4);
            this.gbx_NhapChiTietDiem.Controls.Add(this.cbx_TrangThai);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label3);
            this.gbx_NhapChiTietDiem.Controls.Add(this.cbx_ChucVu);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label2);
            this.gbx_NhapChiTietDiem.Location = new System.Drawing.Point(3, 3);
            this.gbx_NhapChiTietDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_NhapChiTietDiem.Name = "gbx_NhapChiTietDiem";
            this.gbx_NhapChiTietDiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_NhapChiTietDiem.Size = new System.Drawing.Size(1130, 96);
            this.gbx_NhapChiTietDiem.TabIndex = 21;
            this.gbx_NhapChiTietDiem.TabStop = false;
            this.gbx_NhapChiTietDiem.Text = "Chi Tiết Tài Khoản";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_MatKhau.Location = new System.Drawing.Point(354, 33);
            this.tbx_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(108, 44);
            this.tbx_MatKhau.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mật khẩu";
            // 
            // tbx_TaiKhoan
            // 
            this.tbx_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_TaiKhoan.Location = new System.Drawing.Point(120, 33);
            this.tbx_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_TaiKhoan.Name = "tbx_TaiKhoan";
            this.tbx_TaiKhoan.Size = new System.Drawing.Size(108, 44);
            this.tbx_TaiKhoan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tài khoản";
            // 
            // cbx_TrangThai
            // 
            this.cbx_TrangThai.FormattingEnabled = true;
            this.cbx_TrangThai.Location = new System.Drawing.Point(901, 33);
            this.cbx_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_TrangThai.Name = "cbx_TrangThai";
            this.cbx_TrangThai.Size = new System.Drawing.Size(222, 45);
            this.cbx_TrangThai.TabIndex = 3;
            this.cbx_TrangThai.Text = "-Chọn trạng thái -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // cbx_ChucVu
            // 
            this.cbx_ChucVu.FormattingEnabled = true;
            this.cbx_ChucVu.Location = new System.Drawing.Point(578, 33);
            this.cbx_ChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            this.cbx_ChucVu.Size = new System.Drawing.Size(208, 45);
            this.cbx_ChucVu.TabIndex = 1;
            this.cbx_ChucVu.Text = "-Chọn chức vụ -";
            this.cbx_ChucVu.SelectedIndexChanged += new System.EventHandler(this.cbx_ChucVu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ";
            // 
            // dtgrv_TK
            // 
            this.dtgrv_TK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TK.DataPropertyName = "tai_khoan";
            this.dtgrv_TK.HeaderText = "Tài Khoản ";
            this.dtgrv_TK.MinimumWidth = 10;
            this.dtgrv_TK.Name = "dtgrv_TK";
            // 
            // dtgrv_MatKhau
            // 
            this.dtgrv_MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_MatKhau.DataPropertyName = "mat_khau";
            this.dtgrv_MatKhau.HeaderText = "Mật Khẩu";
            this.dtgrv_MatKhau.MinimumWidth = 10;
            this.dtgrv_MatKhau.Name = "dtgrv_MatKhau";
            // 
            // dtgrv_ChucVu
            // 
            this.dtgrv_ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_ChucVu.DataPropertyName = "idPer";
            this.dtgrv_ChucVu.HeaderText = "Chức Vụ";
            this.dtgrv_ChucVu.MinimumWidth = 10;
            this.dtgrv_ChucVu.Name = "dtgrv_ChucVu";
            this.dtgrv_ChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtgrv_TrangThai
            // 
            this.dtgrv_TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TrangThai.DataPropertyName = "status";
            this.dtgrv_TrangThai.HeaderText = "Trạng Thái";
            this.dtgrv_TrangThai.MinimumWidth = 10;
            this.dtgrv_TrangThai.Name = "dtgrv_TrangThai";
            this.dtgrv_TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_NhapChiTietDiem);
            this.Controls.Add(this.dtgrv_TaiKhoan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemTaiKhoan";
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.Load += new System.EventHandler(this.FormThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_TaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.gbx_NhapChiTietDiem.ResumeLayout(false);
            this.gbx_NhapChiTietDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv_TaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbx_TimKiem;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.ComboBox cbx_ChonMonHoc;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_ChonChucVu;
        private System.Windows.Forms.Label ln_chonhocki;
        private System.Windows.Forms.GroupBox gbx_NhapChiTietDiem;
        private System.Windows.Forms.TextBox tbx_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_TaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_TrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_ChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TrangThai;
    }
}