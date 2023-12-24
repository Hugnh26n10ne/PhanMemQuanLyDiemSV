namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormNhapMonHoc
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
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dtgrv_MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_MaMonHoc = new System.Windows.Forms.TextBox();
            this.tbx_MaGiaoVien = new System.Windows.Forms.TextBox();
            this.tbx_DiemID = new System.Windows.Forms.TextBox();
            this.tbx_TenMonHoc = new System.Windows.Forms.TextBox();
            this.tbx_ThoiGian = new System.Windows.Forms.TextBox();
            this.tbx_DiaDiem = new System.Windows.Forms.TextBox();
            this.tbx_HocPhi = new System.Windows.Forms.TextBox();
            this.tbx_GhiChu = new System.Windows.Forms.TextBox();
            this.tbx_SoTinChi = new System.Windows.Forms.TextBox();
            this.tbx_SoTiet = new System.Windows.Forms.TextBox();
            this.tbx_SoDangKi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrv
            // 
            this.dtgrv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_MaMonHoc,
            this.dtgrv_MaGiaoVien,
            this.dtgrv_DiemID,
            this.dtgrv_TenMonHoc,
            this.dtgrv_ThoiGian,
            this.dtgrv_DiaDiem,
            this.dtgrv_SoTinChi,
            this.dtgrv_SoTiet,
            this.dtgrv_SoDK,
            this.dtgrv_HocPhi,
            this.dtgrv_GhiChu});
            this.dtgrv.Location = new System.Drawing.Point(-1, 549);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(1126, 158);
            this.dtgrv.TabIndex = 1;
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.Location = new System.Drawing.Point(43, 109);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(103, 35);
            this.btn_Luu.TabIndex = 17;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Location = new System.Drawing.Point(188, 109);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 35);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Location = new System.Drawing.Point(333, 109);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 35);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XuatFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_XuatFile.Location = new System.Drawing.Point(478, 109);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(103, 35);
            this.btn_XuatFile.TabIndex = 20;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(623, 109);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(103, 35);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(492, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 50);
            this.label8.TabIndex = 22;
            this.label8.Text = "MÔN HỌC";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_TimKiem.Location = new System.Drawing.Point(132, 24);
            this.tbx_TimKiem.MaximumSize = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.MinimumSize = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.Multiline = true;
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.MaximumSize = new System.Drawing.Size(88, 25);
            this.label1.MinimumSize = new System.Drawing.Size(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.tbx_TimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_XuatFile);
            this.panel1.Location = new System.Drawing.Point(198, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 161);
            this.panel1.TabIndex = 26;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(645, 24);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(45, 42);
            this.btn_TimKiem.TabIndex = 25;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgrv_MaMonHoc
            // 
            this.dtgrv_MaMonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_MaMonHoc.FillWeight = 70F;
            this.dtgrv_MaMonHoc.HeaderText = "Mã Môn Học";
            this.dtgrv_MaMonHoc.MinimumWidth = 6;
            this.dtgrv_MaMonHoc.Name = "dtgrv_MaMonHoc";
            // 
            // dtgrv_MaGiaoVien
            // 
            this.dtgrv_MaGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_MaGiaoVien.FillWeight = 70F;
            this.dtgrv_MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.dtgrv_MaGiaoVien.MinimumWidth = 6;
            this.dtgrv_MaGiaoVien.Name = "dtgrv_MaGiaoVien";
            // 
            // dtgrv_DiemID
            // 
            this.dtgrv_DiemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_DiemID.FillWeight = 30F;
            this.dtgrv_DiemID.HeaderText = "Điểm ID";
            this.dtgrv_DiemID.MinimumWidth = 6;
            this.dtgrv_DiemID.Name = "dtgrv_DiemID";
            // 
            // dtgrv_TenMonHoc
            // 
            this.dtgrv_TenMonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TenMonHoc.HeaderText = "Tên Môn Học";
            this.dtgrv_TenMonHoc.MinimumWidth = 6;
            this.dtgrv_TenMonHoc.Name = "dtgrv_TenMonHoc";
            // 
            // dtgrv_ThoiGian
            // 
            this.dtgrv_ThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_ThoiGian.FillWeight = 80F;
            this.dtgrv_ThoiGian.HeaderText = "Thời Gian";
            this.dtgrv_ThoiGian.MinimumWidth = 6;
            this.dtgrv_ThoiGian.Name = "dtgrv_ThoiGian";
            // 
            // dtgrv_DiaDiem
            // 
            this.dtgrv_DiaDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_DiaDiem.FillWeight = 80F;
            this.dtgrv_DiaDiem.HeaderText = "Địa Điểm";
            this.dtgrv_DiaDiem.MinimumWidth = 6;
            this.dtgrv_DiaDiem.Name = "dtgrv_DiaDiem";
            // 
            // dtgrv_SoTinChi
            // 
            this.dtgrv_SoTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTinChi.FillWeight = 30F;
            this.dtgrv_SoTinChi.HeaderText = "Số Tín Chỉ";
            this.dtgrv_SoTinChi.MinimumWidth = 6;
            this.dtgrv_SoTinChi.Name = "dtgrv_SoTinChi";
            // 
            // dtgrv_SoTiet
            // 
            this.dtgrv_SoTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTiet.FillWeight = 30F;
            this.dtgrv_SoTiet.HeaderText = "Số Tiết";
            this.dtgrv_SoTiet.MinimumWidth = 6;
            this.dtgrv_SoTiet.Name = "dtgrv_SoTiet";
            // 
            // dtgrv_SoDK
            // 
            this.dtgrv_SoDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoDK.FillWeight = 30F;
            this.dtgrv_SoDK.HeaderText = "Số Đăng Kí";
            this.dtgrv_SoDK.MinimumWidth = 6;
            this.dtgrv_SoDK.Name = "dtgrv_SoDK";
            // 
            // dtgrv_HocPhi
            // 
            this.dtgrv_HocPhi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_HocPhi.FillWeight = 80F;
            this.dtgrv_HocPhi.HeaderText = "Học Phí";
            this.dtgrv_HocPhi.MinimumWidth = 6;
            this.dtgrv_HocPhi.Name = "dtgrv_HocPhi";
            // 
            // dtgrv_GhiChu
            // 
            this.dtgrv_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_GhiChu.HeaderText = "Ghi Chú";
            this.dtgrv_GhiChu.MinimumWidth = 6;
            this.dtgrv_GhiChu.Name = "dtgrv_GhiChu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(165, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Môn Học";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(165, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã Giáo Viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(165, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Điểm ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(165, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên Môn Học";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(584, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Thời Gian";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(584, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Địa Điểm";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(314, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Số Tín Chỉ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(528, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Số Tiết";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(723, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Số Đăng Kí";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(584, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Học Phí";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(584, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Ghi Chú";
            // 
            // tbx_MaMonHoc
            // 
            this.tbx_MaMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_MaMonHoc.Location = new System.Drawing.Point(268, 262);
            this.tbx_MaMonHoc.Name = "tbx_MaMonHoc";
            this.tbx_MaMonHoc.Size = new System.Drawing.Size(281, 22);
            this.tbx_MaMonHoc.TabIndex = 39;
            // 
            // tbx_MaGiaoVien
            // 
            this.tbx_MaGiaoVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_MaGiaoVien.Location = new System.Drawing.Point(268, 316);
            this.tbx_MaGiaoVien.Name = "tbx_MaGiaoVien";
            this.tbx_MaGiaoVien.Size = new System.Drawing.Size(281, 22);
            this.tbx_MaGiaoVien.TabIndex = 40;
            // 
            // tbx_DiemID
            // 
            this.tbx_DiemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_DiemID.Location = new System.Drawing.Point(268, 370);
            this.tbx_DiemID.Name = "tbx_DiemID";
            this.tbx_DiemID.Size = new System.Drawing.Size(281, 22);
            this.tbx_DiemID.TabIndex = 41;
            // 
            // tbx_TenMonHoc
            // 
            this.tbx_TenMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_TenMonHoc.Location = new System.Drawing.Point(268, 424);
            this.tbx_TenMonHoc.Name = "tbx_TenMonHoc";
            this.tbx_TenMonHoc.Size = new System.Drawing.Size(281, 22);
            this.tbx_TenMonHoc.TabIndex = 42;
            // 
            // tbx_ThoiGian
            // 
            this.tbx_ThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_ThoiGian.Location = new System.Drawing.Point(679, 262);
            this.tbx_ThoiGian.Name = "tbx_ThoiGian";
            this.tbx_ThoiGian.Size = new System.Drawing.Size(263, 22);
            this.tbx_ThoiGian.TabIndex = 43;
            // 
            // tbx_DiaDiem
            // 
            this.tbx_DiaDiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_DiaDiem.Location = new System.Drawing.Point(679, 316);
            this.tbx_DiaDiem.Name = "tbx_DiaDiem";
            this.tbx_DiaDiem.Size = new System.Drawing.Size(263, 22);
            this.tbx_DiaDiem.TabIndex = 44;
            // 
            // tbx_HocPhi
            // 
            this.tbx_HocPhi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_HocPhi.Location = new System.Drawing.Point(679, 370);
            this.tbx_HocPhi.Name = "tbx_HocPhi";
            this.tbx_HocPhi.Size = new System.Drawing.Size(263, 22);
            this.tbx_HocPhi.TabIndex = 45;
            // 
            // tbx_GhiChu
            // 
            this.tbx_GhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_GhiChu.Location = new System.Drawing.Point(679, 424);
            this.tbx_GhiChu.Name = "tbx_GhiChu";
            this.tbx_GhiChu.Size = new System.Drawing.Size(263, 22);
            this.tbx_GhiChu.TabIndex = 46;
            // 
            // tbx_SoTinChi
            // 
            this.tbx_SoTinChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_SoTinChi.Location = new System.Drawing.Point(405, 493);
            this.tbx_SoTinChi.Name = "tbx_SoTinChi";
            this.tbx_SoTinChi.Size = new System.Drawing.Size(100, 22);
            this.tbx_SoTinChi.TabIndex = 47;
            // 
            // tbx_SoTiet
            // 
            this.tbx_SoTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_SoTiet.Location = new System.Drawing.Point(600, 493);
            this.tbx_SoTiet.Name = "tbx_SoTiet";
            this.tbx_SoTiet.Size = new System.Drawing.Size(100, 22);
            this.tbx_SoTiet.TabIndex = 48;
            this.tbx_SoTiet.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // tbx_SoDangKi
            // 
            this.tbx_SoDangKi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_SoDangKi.Location = new System.Drawing.Point(820, 493);
            this.tbx_SoDangKi.Name = "tbx_SoDangKi";
            this.tbx_SoDangKi.Size = new System.Drawing.Size(100, 22);
            this.tbx_SoDangKi.TabIndex = 49;
            // 
            // FormNhapMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 719);
            this.Controls.Add(this.tbx_SoDangKi);
            this.Controls.Add(this.tbx_SoTiet);
            this.Controls.Add(this.tbx_SoTinChi);
            this.Controls.Add(this.tbx_GhiChu);
            this.Controls.Add(this.tbx_HocPhi);
            this.Controls.Add(this.tbx_DiaDiem);
            this.Controls.Add(this.tbx_ThoiGian);
            this.Controls.Add(this.tbx_TenMonHoc);
            this.Controls.Add(this.tbx_DiemID);
            this.Controls.Add(this.tbx_MaGiaoVien);
            this.Controls.Add(this.tbx_MaMonHoc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapMonHoc";
            this.Text = "FormNhapMonHoc";
            this.Load += new System.EventHandler(this.FormNhapMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_HocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_GhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbx_MaMonHoc;
        private System.Windows.Forms.TextBox tbx_MaGiaoVien;
        private System.Windows.Forms.TextBox tbx_DiemID;
        private System.Windows.Forms.TextBox tbx_TenMonHoc;
        private System.Windows.Forms.TextBox tbx_ThoiGian;
        private System.Windows.Forms.TextBox tbx_DiaDiem;
        private System.Windows.Forms.TextBox tbx_HocPhi;
        private System.Windows.Forms.TextBox tbx_GhiChu;
        private System.Windows.Forms.TextBox tbx_SoTinChi;
        private System.Windows.Forms.TextBox tbx_SoTiet;
        private System.Windows.Forms.TextBox tbx_SoDangKi;
    }
}