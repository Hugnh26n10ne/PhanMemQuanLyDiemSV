namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormNhapThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapThongTin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XuatFileExcel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_va_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dan_toc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_dien_thoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vai_tro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.tbx_TimKiem);
            this.groupBox1.Controls.Add(this.labe);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_XuatFileExcel);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Location = new System.Drawing.Point(760, 75);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(54, 32);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(286, 75);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(468, 34);
            this.tbx_TimKiem.TabIndex = 7;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labe.Location = new System.Drawing.Point(181, 78);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(99, 28);
            this.labe.TabIndex = 6;
            this.labe.Text = "TÌm Kiếm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.SlateGray;
            this.btn_Thoat.Location = new System.Drawing.Point(880, 136);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(105, 35);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_XuatFileExcel
            // 
            this.btn_XuatFileExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XuatFileExcel.Location = new System.Drawing.Point(671, 136);
            this.btn_XuatFileExcel.Name = "btn_XuatFileExcel";
            this.btn_XuatFileExcel.Size = new System.Drawing.Size(143, 35);
            this.btn_XuatFileExcel.TabIndex = 4;
            this.btn_XuatFileExcel.Text = "Xuất file Excel";
            this.btn_XuatFileExcel.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.ForeColor = System.Drawing.Color.Olive;
            this.btn_Update.Location = new System.Drawing.Point(280, 136);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(105, 35);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Xoa.Location = new System.Drawing.Point(480, 136);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(105, 35);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Luu.Location = new System.Drawing.Point(80, 136);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(105, 35);
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật thông tin : Thêm, Sửa, Xóa,...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgrv
            // 
            this.dtgrv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tai_khoan,
            this.ho_va_ten,
            this.gioi_tinh,
            this.dia_chi,
            this.ngay_sinh,
            this.dan_toc,
            this.so_dien_thoai,
            this.email,
            this.nganh,
            this.vai_tro,
            this.trang_thai});
            this.dtgrv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrv.Location = new System.Drawing.Point(25, 207);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(1163, 151);
            this.dtgrv.TabIndex = 6;
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // tai_khoan
            // 
            this.tai_khoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tai_khoan.HeaderText = "Tài Khoản";
            this.tai_khoan.MinimumWidth = 6;
            this.tai_khoan.Name = "tai_khoan";
            // 
            // ho_va_ten
            // 
            this.ho_va_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ho_va_ten.HeaderText = "Họ và Tên";
            this.ho_va_ten.MinimumWidth = 6;
            this.ho_va_ten.Name = "ho_va_ten";
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioi_tinh.FillWeight = 50F;
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.MinimumWidth = 6;
            this.gioi_tinh.Name = "gioi_tinh";
            // 
            // dia_chi
            // 
            this.dia_chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.MinimumWidth = 6;
            this.dia_chi.Name = "dia_chi";
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngay_sinh.FillWeight = 70F;
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.MinimumWidth = 6;
            this.ngay_sinh.Name = "ngay_sinh";
            // 
            // dan_toc
            // 
            this.dan_toc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dan_toc.FillWeight = 50F;
            this.dan_toc.HeaderText = "Dân tộc";
            this.dan_toc.MinimumWidth = 6;
            this.dan_toc.Name = "dan_toc";
            // 
            // so_dien_thoai
            // 
            this.so_dien_thoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.so_dien_thoai.FillWeight = 60F;
            this.so_dien_thoai.HeaderText = "SĐT";
            this.so_dien_thoai.MinimumWidth = 6;
            this.so_dien_thoai.Name = "so_dien_thoai";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.FillWeight = 70F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // nganh
            // 
            this.nganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nganh.FillWeight = 70F;
            this.nganh.HeaderText = "Ngành";
            this.nganh.MinimumWidth = 6;
            this.nganh.Name = "nganh";
            // 
            // vai_tro
            // 
            this.vai_tro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vai_tro.FillWeight = 70F;
            this.vai_tro.HeaderText = "Vai trò";
            this.vai_tro.MinimumWidth = 6;
            this.vai_tro.Name = "vai_tro";
            // 
            // trang_thai
            // 
            this.trang_thai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trang_thai.FillWeight = 70F;
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.MinimumWidth = 6;
            this.trang_thai.Name = "trang_thai";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 156);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormNhapThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgrv);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhapThongTin";
            this.Text = "FormNhapThongTin";
            this.Load += new System.EventHandler(this.FormNhapThongTin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XuatFileExcel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_va_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dan_toc;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_dien_thoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn vai_tro;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}