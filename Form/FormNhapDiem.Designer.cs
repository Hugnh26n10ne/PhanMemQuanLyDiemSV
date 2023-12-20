namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormNhapDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtrgv = new System.Windows.Forms.DataGridView();
            this.tbx_Timkiem = new System.Windows.Forms.TextBox();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sotc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuyencan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemthuchanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthaoluan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kiemtragk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thicuoiki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtrgv
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtrgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dtrgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtrgv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtrgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtrgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Mahocphan,
            this.Tenhocphan,
            this.Sotc,
            this.Lanhoc,
            this.Lanthi,
            this.Danhgia,
            this.Masv,
            this.Chuyencan,
            this.Diemthuchanh,
            this.diemthaoluan,
            this.Kiemtragk,
            this.Thicuoiki,
            this.Tongket,
            this.Diemchu});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtrgv.DefaultCellStyle = dataGridViewCellStyle28;
            this.dtrgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtrgv.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dtrgv.Location = new System.Drawing.Point(12, 121);
            this.dtrgv.MinimumSize = new System.Drawing.Size(1284, 644);
            this.dtrgv.Name = "dtrgv";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtrgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dtrgv.RowHeadersWidth = 51;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtrgv.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dtrgv.RowTemplate.Height = 24;
            this.dtrgv.Size = new System.Drawing.Size(1284, 644);
            this.dtrgv.TabIndex = 1;
            // 
            // tbx_Timkiem
            // 
            this.tbx_Timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Timkiem.Location = new System.Drawing.Point(12, 82);
            this.tbx_Timkiem.Name = "tbx_Timkiem";
            this.tbx_Timkiem.Size = new System.Drawing.Size(308, 22);
            this.tbx_Timkiem.TabIndex = 2;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Timkiem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(336, 82);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(133, 22);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // Mahocphan
            // 
            this.Mahocphan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mahocphan.HeaderText = "Mã học phần";
            this.Mahocphan.MinimumWidth = 6;
            this.Mahocphan.Name = "Mahocphan";
            // 
            // Tenhocphan
            // 
            this.Tenhocphan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenhocphan.HeaderText = "Tên học phần";
            this.Tenhocphan.MinimumWidth = 6;
            this.Tenhocphan.Name = "Tenhocphan";
            // 
            // Sotc
            // 
            this.Sotc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sotc.HeaderText = "Số TC";
            this.Sotc.MinimumWidth = 6;
            this.Sotc.Name = "Sotc";
            // 
            // Lanhoc
            // 
            this.Lanhoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lanhoc.HeaderText = "Lần học";
            this.Lanhoc.MinimumWidth = 6;
            this.Lanhoc.Name = "Lanhoc";
            // 
            // Lanthi
            // 
            this.Lanthi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lanthi.HeaderText = "Lần thi";
            this.Lanthi.MinimumWidth = 6;
            this.Lanthi.Name = "Lanthi";
            // 
            // Danhgia
            // 
            this.Danhgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Danhgia.HeaderText = "Đánh giá";
            this.Danhgia.MinimumWidth = 6;
            this.Danhgia.Name = "Danhgia";
            // 
            // Masv
            // 
            this.Masv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Masv.HeaderText = "Mã SV";
            this.Masv.MinimumWidth = 6;
            this.Masv.Name = "Masv";
            // 
            // Chuyencan
            // 
            this.Chuyencan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chuyencan.HeaderText = "Chuyên cần";
            this.Chuyencan.MinimumWidth = 6;
            this.Chuyencan.Name = "Chuyencan";
            // 
            // Diemthuchanh
            // 
            this.Diemthuchanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diemthuchanh.HeaderText = "Điểm thực hành";
            this.Diemthuchanh.MinimumWidth = 6;
            this.Diemthuchanh.Name = "Diemthuchanh";
            // 
            // diemthaoluan
            // 
            this.diemthaoluan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diemthaoluan.HeaderText = "Điểm thảo luận";
            this.diemthaoluan.MinimumWidth = 6;
            this.diemthaoluan.Name = "diemthaoluan";
            // 
            // Kiemtragk
            // 
            this.Kiemtragk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kiemtragk.HeaderText = "Giữa kì";
            this.Kiemtragk.MinimumWidth = 6;
            this.Kiemtragk.Name = "Kiemtragk";
            // 
            // Thicuoiki
            // 
            this.Thicuoiki.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thicuoiki.HeaderText = "Cuối kì";
            this.Thicuoiki.MinimumWidth = 6;
            this.Thicuoiki.Name = "Thicuoiki";
            // 
            // Tongket
            // 
            this.Tongket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tongket.HeaderText = "Tổng kết";
            this.Tongket.MinimumWidth = 6;
            this.Tongket.Name = "Tongket";
            // 
            // Diemchu
            // 
            this.Diemchu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diemchu.HeaderText = "Điểm chữ";
            this.Diemchu.MinimumWidth = 6;
            this.Diemchu.Name = "Diemchu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1154, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xuất file excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1308, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.tbx_Timkiem);
            this.Controls.Add(this.dtrgv);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormNhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapDiem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtrgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtrgv;
        private System.Windows.Forms.TextBox tbx_Timkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sotc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danhgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuyencan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemthuchanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthaoluan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kiemtragk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thicuoiki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemchu;
        private System.Windows.Forms.Button button1;
    }
}