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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapMonHoc));
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoi_gian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_tin_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoc_phi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghi_chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrv
            // 
            this.dtgrv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mh,
            this.ma_gv,
            this.diem_id,
            this.ten_mh,
            this.thoi_gian,
            this.dia_diem,
            this.so_tin_chi,
            this.so_tiet,
            this.so_dk,
            this.hoc_phi,
            this.ghi_chu});
            this.dtgrv.Location = new System.Drawing.Point(-1, 301);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(1126, 406);
            this.dtgrv.TabIndex = 1;
            // 
            // ma_mh
            // 
            this.ma_mh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma_mh.DataPropertyName = "ma_mh";
            this.ma_mh.HeaderText = "Mã Môn Học";
            this.ma_mh.MinimumWidth = 6;
            this.ma_mh.Name = "ma_mh";
            // 
            // ma_gv
            // 
            this.ma_gv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma_gv.DataPropertyName = "ma_gv";
            this.ma_gv.HeaderText = "Mã Giáo Viên";
            this.ma_gv.MinimumWidth = 6;
            this.ma_gv.Name = "ma_gv";
            // 
            // diem_id
            // 
            this.diem_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_id.DataPropertyName = "diem_id";
            this.diem_id.HeaderText = "Điểm ID";
            this.diem_id.MinimumWidth = 10;
            this.diem_id.Name = "diem_id";
            // 
            // ten_mh
            // 
            this.ten_mh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_mh.DataPropertyName = "ten_mh";
            this.ten_mh.HeaderText = "Tên Môn Học";
            this.ten_mh.MinimumWidth = 6;
            this.ten_mh.Name = "ten_mh";
            // 
            // thoi_gian
            // 
            this.thoi_gian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thoi_gian.DataPropertyName = "thoi_gian";
            this.thoi_gian.HeaderText = "Thời Gian";
            this.thoi_gian.MinimumWidth = 6;
            this.thoi_gian.Name = "thoi_gian";
            // 
            // dia_diem
            // 
            this.dia_diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_diem.DataPropertyName = "dia_diem";
            this.dia_diem.HeaderText = "Địa Điểm";
            this.dia_diem.MinimumWidth = 6;
            this.dia_diem.Name = "dia_diem";
            // 
            // so_tin_chi
            // 
            this.so_tin_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.so_tin_chi.DataPropertyName = "so_tin_chi";
            this.so_tin_chi.FillWeight = 50F;
            this.so_tin_chi.HeaderText = "Số Tín Chỉ";
            this.so_tin_chi.MinimumWidth = 6;
            this.so_tin_chi.Name = "so_tin_chi";
            // 
            // so_tiet
            // 
            this.so_tiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.so_tiet.DataPropertyName = "so_tiet";
            this.so_tiet.FillWeight = 50F;
            this.so_tiet.HeaderText = "Số Tiết";
            this.so_tiet.MinimumWidth = 6;
            this.so_tiet.Name = "so_tiet";
            // 
            // so_dk
            // 
            this.so_dk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.so_dk.DataPropertyName = "so_dk";
            this.so_dk.FillWeight = 50F;
            this.so_dk.HeaderText = "Số Đăng Kí";
            this.so_dk.MinimumWidth = 6;
            this.so_dk.Name = "so_dk";
            // 
            // hoc_phi
            // 
            this.hoc_phi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoc_phi.DataPropertyName = "hoc_phi";
            this.hoc_phi.HeaderText = "Học Phí";
            this.hoc_phi.MinimumWidth = 6;
            this.hoc_phi.Name = "hoc_phi";
            // 
            // ghi_chu
            // 
            this.ghi_chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghi_chu.DataPropertyName = "ghi_chu";
            this.ghi_chu.HeaderText = "Ghi Chú";
            this.ghi_chu.MinimumWidth = 6;
            this.ghi_chu.Name = "ghi_chu";
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
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // FormNhapMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 719);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoi_gian;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_tin_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dk;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoc_phi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghi_chu;
    }
}