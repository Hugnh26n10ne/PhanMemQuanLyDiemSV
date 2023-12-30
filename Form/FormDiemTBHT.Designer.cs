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
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_XuatFileExcel = new System.Windows.Forms.Button();
            this.cbx_ChonNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ChonHocKy = new System.Windows.Forms.ComboBox();
            this.ln_chonhocki = new System.Windows.Forms.Label();
            this.dtgrv_BangDiemTBHTSV = new System.Windows.Forms.DataGridView();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo10N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo10N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo4N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TBHeSo4N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTCN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTCN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.dtgrv_BangDiemTBHTSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_BangDiemTBHTSV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_BangDiemTBHTSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_BangDiemTBHTSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_NamHoc,
            this.dtgrv_HocKi,
            this.dtgrv_TBHeSo10N1,
            this.dtgrv_TBHeSo10N2,
            this.dtgrv_TBHeSo4N1,
            this.dtgrv_TBHeSo4N2,
            this.dtgrv_SoTCN1,
            this.dtgrv_SoTCN2});
            this.dtgrv_BangDiemTBHTSV.Location = new System.Drawing.Point(13, 174);
            this.dtgrv_BangDiemTBHTSV.Name = "dtgrv_BangDiemTBHTSV";
            this.dtgrv_BangDiemTBHTSV.RowHeadersWidth = 51;
            this.dtgrv_BangDiemTBHTSV.RowTemplate.Height = 24;
            this.dtgrv_BangDiemTBHTSV.Size = new System.Drawing.Size(1071, 388);
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "DANH SÁCH ĐIỂM TRUNG HỌC TẬP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDiemTBHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 574);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrv_BangDiemTBHTSV);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiemTBHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}