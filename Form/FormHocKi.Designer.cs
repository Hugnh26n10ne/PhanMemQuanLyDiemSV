namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormHocKi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocKi));
            this.dtgrv_HocKi = new System.Windows.Forms.DataGridView();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_HọcKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.gbx_NhapChiTietDiem = new System.Windows.Forms.GroupBox();
            this.tbx_GhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_HK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_HocKi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.gbx_NhapChiTietDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrv_HocKi
            // 
            this.dtgrv_HocKi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_HocKi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_HocKi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_HocKi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_HọcKi,
            this.dtgrv_GhiChu});
            this.dtgrv_HocKi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrv_HocKi.Location = new System.Drawing.Point(12, 259);
            this.dtgrv_HocKi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrv_HocKi.Name = "dtgrv_HocKi";
            this.dtgrv_HocKi.RowHeadersWidth = 82;
            this.dtgrv_HocKi.RowTemplate.Height = 33;
            this.dtgrv_HocKi.Size = new System.Drawing.Size(865, 264);
            this.dtgrv_HocKi.TabIndex = 28;
            // 
            // dtgrv_Stt
            // 
            this.dtgrv_Stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_Stt.HeaderText = "STT";
            this.dtgrv_Stt.MinimumWidth = 10;
            this.dtgrv_Stt.Name = "dtgrv_Stt";
            // 
            // dtgrv_HọcKi
            // 
            this.dtgrv_HọcKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_HọcKi.HeaderText = "Học kì";
            this.dtgrv_HọcKi.MinimumWidth = 10;
            this.dtgrv_HọcKi.Name = "dtgrv_HọcKi";
            // 
            // dtgrv_GhiChu
            // 
            this.dtgrv_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_GhiChu.HeaderText = "Ghi Chú";
            this.dtgrv_GhiChu.MinimumWidth = 10;
            this.dtgrv_GhiChu.Name = "dtgrv_GhiChu";
            this.dtgrv_GhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.groupBox1.Controls.Add(this.tbx_TimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(865, 131);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(343, 76);
            this.pbx_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(26, 30);
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
            this.btn_NhapExcel.Location = new System.Drawing.Point(665, 21);
            this.btn_NhapExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(159, 34);
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
            this.btn_Xoa.Location = new System.Drawing.Point(489, 23);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 30);
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
            this.btn_CapNhat.Location = new System.Drawing.Point(333, 23);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(126, 30);
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
            this.btn_Luu.Location = new System.Drawing.Point(177, 23);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 30);
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
            this.btn_Thêm.Location = new System.Drawing.Point(20, 23);
            this.btn_Thêm.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(127, 30);
            this.btn_Thêm.TabIndex = 31;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = false;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.AutoSize = true;
            this.btn_XuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.Location = new System.Drawing.Point(665, 74);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(159, 34);
            this.btn_XuatExcel.TabIndex = 30;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(20, 76);
            this.tbx_TimKiem.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(304, 30);
            this.tbx_TimKiem.TabIndex = 26;
            this.tbx_TimKiem.Text = "(Tìm kiếm theo học kì)";
            // 
            // gbx_NhapChiTietDiem
            // 
            this.gbx_NhapChiTietDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_GhiChu);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label3);
            this.gbx_NhapChiTietDiem.Controls.Add(this.tbx_HK);
            this.gbx_NhapChiTietDiem.Controls.Add(this.label4);
            this.gbx_NhapChiTietDiem.Location = new System.Drawing.Point(12, 13);
            this.gbx_NhapChiTietDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_NhapChiTietDiem.Name = "gbx_NhapChiTietDiem";
            this.gbx_NhapChiTietDiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_NhapChiTietDiem.Size = new System.Drawing.Size(865, 109);
            this.gbx_NhapChiTietDiem.TabIndex = 26;
            this.gbx_NhapChiTietDiem.TabStop = false;
            this.gbx_NhapChiTietDiem.Text = "Chi Tiết Học Kì";
            // 
            // tbx_GhiChu
            // 
            this.tbx_GhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_GhiChu.Location = new System.Drawing.Point(341, 31);
            this.tbx_GhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_GhiChu.Multiline = true;
            this.tbx_GhiChu.Name = "tbx_GhiChu";
            this.tbx_GhiChu.Size = new System.Drawing.Size(503, 53);
            this.tbx_GhiChu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ghi chú";
            // 
            // tbx_HK
            // 
            this.tbx_HK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_HK.Location = new System.Drawing.Point(93, 33);
            this.tbx_HK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_HK.Name = "tbx_HK";
            this.tbx_HK.Size = new System.Drawing.Size(139, 30);
            this.tbx_HK.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Học kì";
            // 
            // FormHocKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 536);
            this.Controls.Add(this.dtgrv_HocKi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_NhapChiTietDiem);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHocKi";
            this.Text = "Phần mềm quản lý điểm sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_HocKi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.gbx_NhapChiTietDiem.ResumeLayout(false);
            this.gbx_NhapChiTietDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv_HocKi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbx_TimKiem;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.GroupBox gbx_NhapChiTietDiem;
        private System.Windows.Forms.TextBox tbx_GhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_HK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_HọcKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_GhiChu;
    }
}