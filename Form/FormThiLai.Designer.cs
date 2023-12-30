namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormThiLai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThiLai));
            this.dtgrv_ThiLai = new System.Windows.Forms.DataGridView();
            this.dtgrv_Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_ChonTenMon = new System.Windows.Forms.ComboBox();
            this.cbx_ChonGiangVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.pbx_TimKiem = new System.Windows.Forms.PictureBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.tbx_LanThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_ThiLai)).BeginInit();
            this.Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrv_ThiLai
            // 
            this.dtgrv_ThiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv_ThiLai.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgrv_ThiLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_ThiLai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_Stt,
            this.dtgrv_TenSV,
            this.dtgrv_TenMon,
            this.dtgrv_TenGV,
            this.dtgrv_LanThi,
            this.dtgrv_DTT});
            this.dtgrv_ThiLai.Location = new System.Drawing.Point(1, 190);
            this.dtgrv_ThiLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrv_ThiLai.Name = "dtgrv_ThiLai";
            this.dtgrv_ThiLai.ReadOnly = true;
            this.dtgrv_ThiLai.RowHeadersWidth = 51;
            this.dtgrv_ThiLai.RowTemplate.Height = 24;
            this.dtgrv_ThiLai.Size = new System.Drawing.Size(1077, 387);
            this.dtgrv_ThiLai.TabIndex = 1;
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
            // dtgrv_TenSV
            // 
            this.dtgrv_TenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_TenSV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv_TenSV.HeaderText = "Tên sinh viên";
            this.dtgrv_TenSV.MinimumWidth = 6;
            this.dtgrv_TenSV.Name = "dtgrv_TenSV";
            this.dtgrv_TenSV.ReadOnly = true;
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
            // dtgrv_TenGV
            // 
            this.dtgrv_TenGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_TenGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrv_TenGV.HeaderText = "Tên GV";
            this.dtgrv_TenGV.MinimumWidth = 6;
            this.dtgrv_TenGV.Name = "dtgrv_TenGV";
            this.dtgrv_TenGV.ReadOnly = true;
            // 
            // dtgrv_LanThi
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_LanThi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrv_LanThi.HeaderText = "Lần thi";
            this.dtgrv_LanThi.MinimumWidth = 6;
            this.dtgrv_LanThi.Name = "dtgrv_LanThi";
            this.dtgrv_LanThi.ReadOnly = true;
            this.dtgrv_LanThi.Width = 125;
            // 
            // dtgrv_DTT
            // 
            this.dtgrv_DTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_DTT.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrv_DTT.HeaderText = "Điểm Thi Trước";
            this.dtgrv_DTT.MinimumWidth = 6;
            this.dtgrv_DTT.Name = "dtgrv_DTT";
            this.dtgrv_DTT.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH THI LẠI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên môn";
            // 
            // cbx_ChonTenMon
            // 
            this.cbx_ChonTenMon.FormattingEnabled = true;
            this.cbx_ChonTenMon.Location = new System.Drawing.Point(917, 57);
            this.cbx_ChonTenMon.Name = "cbx_ChonTenMon";
            this.cbx_ChonTenMon.Size = new System.Drawing.Size(148, 31);
            this.cbx_ChonTenMon.TabIndex = 4;
            this.cbx_ChonTenMon.Text = "- Chọn Tên Môn -";
            // 
            // cbx_ChonGiangVien
            // 
            this.cbx_ChonGiangVien.FormattingEnabled = true;
            this.cbx_ChonGiangVien.Location = new System.Drawing.Point(917, 25);
            this.cbx_ChonGiangVien.Name = "cbx_ChonGiangVien";
            this.cbx_ChonGiangVien.Size = new System.Drawing.Size(148, 31);
            this.cbx_ChonGiangVien.TabIndex = 6;
            this.cbx_ChonGiangVien.Text = "- Chọn Tên Giảng Viên -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên giảng viên";
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.btn_NhapExcel);
            this.Filter.Controls.Add(this.btn_XuatExcel);
            this.Filter.Controls.Add(this.pbx_TimKiem);
            this.Filter.Controls.Add(this.tbx_TimKiem);
            this.Filter.Controls.Add(this.tbx_LanThi);
            this.Filter.Controls.Add(this.label4);
            this.Filter.Controls.Add(this.cbx_ChonGiangVien);
            this.Filter.Controls.Add(this.label3);
            this.Filter.Controls.Add(this.label2);
            this.Filter.Controls.Add(this.cbx_ChonTenMon);
            this.Filter.Location = new System.Drawing.Point(1, 56);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(1077, 115);
            this.Filter.TabIndex = 7;
            this.Filter.TabStop = false;
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.AutoSize = true;
            this.btn_NhapExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_NhapExcel.FlatAppearance.BorderSize = 0;
            this.btn_NhapExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapExcel.ForeColor = System.Drawing.Color.White;
            this.btn_NhapExcel.Location = new System.Drawing.Point(393, 23);
            this.btn_NhapExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(159, 37);
            this.btn_NhapExcel.TabIndex = 40;
            this.btn_NhapExcel.Text = "Nhập Excel";
            this.btn_NhapExcel.UseVisualStyleBackColor = false;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.AutoSize = true;
            this.btn_XuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.Location = new System.Drawing.Point(393, 71);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(159, 37);
            this.btn_XuatExcel.TabIndex = 39;
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // pbx_TimKiem
            // 
            this.pbx_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_TimKiem.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pbx_TimKiem.Location = new System.Drawing.Point(338, 47);
            this.pbx_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbx_TimKiem.Name = "pbx_TimKiem";
            this.pbx_TimKiem.Size = new System.Drawing.Size(26, 30);
            this.pbx_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_TimKiem.TabIndex = 38;
            this.pbx_TimKiem.TabStop = false;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(15, 47);
            this.tbx_TimKiem.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(304, 30);
            this.tbx_TimKiem.TabIndex = 37;
            this.tbx_TimKiem.Text = "(Tìm kiếm theo tên sinh viên)";
            // 
            // tbx_LanThi
            // 
            this.tbx_LanThi.Location = new System.Drawing.Point(662, 29);
            this.tbx_LanThi.Name = "tbx_LanThi";
            this.tbx_LanThi.Size = new System.Drawing.Size(100, 30);
            this.tbx_LanThi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lần thi";
            // 
            // FormThiLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrv_ThiLai);
            this.Controls.Add(this.Filter);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThiLai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_ThiLai)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_TimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv_ThiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_ChonTenMon;
        private System.Windows.Forms.ComboBox cbx_ChonGiangVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.TextBox tbx_LanThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbx_TimKiem;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Button btn_NhapExcel;
        private System.Windows.Forms.Button btn_XuatExcel;
    }
}