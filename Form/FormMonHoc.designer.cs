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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giangvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diemchu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_NamHoc = new System.Windows.Forms.ComboBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrv
            // 
            this.dtgrv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Mamon,
            this.Tenmon,
            this.Tc,
            this.Tiet,
            this.Giangvien,
            this.Tongket,
            this.Diemchu});
            this.dtgrv.Location = new System.Drawing.Point(12, 180);
            this.dtgrv.Name = "dtgrv";
            this.dtgrv.ReadOnly = true;
            this.dtgrv.RowHeadersWidth = 51;
            this.dtgrv.RowTemplate.Height = 24;
            this.dtgrv.Size = new System.Drawing.Size(1151, 499);
            this.dtgrv.TabIndex = 0;
            this.dtgrv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgrv_CellBeginEdit);
            this.dtgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgrv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgrv_DataBindingComplete);
            // 
            // STT
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // Mamon
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mamon.DefaultCellStyle = dataGridViewCellStyle3;
            this.Mamon.HeaderText = "Mã môn";
            this.Mamon.MinimumWidth = 6;
            this.Mamon.Name = "Mamon";
            this.Mamon.ReadOnly = true;
            this.Mamon.Width = 250;
            // 
            // Tenmon
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmon.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tenmon.HeaderText = "Tên môn";
            this.Tenmon.MinimumWidth = 6;
            this.Tenmon.Name = "Tenmon";
            this.Tenmon.ReadOnly = true;
            this.Tenmon.Width = 250;
            // 
            // Tc
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tc.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tc.HeaderText = "Số TC";
            this.Tc.MinimumWidth = 6;
            this.Tc.Name = "Tc";
            this.Tc.ReadOnly = true;
            this.Tc.Width = 50;
            // 
            // Tiet
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiet.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tiet.HeaderText = "Số tiết";
            this.Tiet.MinimumWidth = 6;
            this.Tiet.Name = "Tiet";
            this.Tiet.ReadOnly = true;
            this.Tiet.Width = 50;
            // 
            // Giangvien
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giangvien.DefaultCellStyle = dataGridViewCellStyle7;
            this.Giangvien.HeaderText = "Tên GV";
            this.Giangvien.MinimumWidth = 6;
            this.Giangvien.Name = "Giangvien";
            this.Giangvien.ReadOnly = true;
            this.Giangvien.Width = 200;
            // 
            // Tongket
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tongket.DefaultCellStyle = dataGridViewCellStyle8;
            this.Tongket.HeaderText = "Tổng kết HP";
            this.Tongket.MinimumWidth = 6;
            this.Tongket.Name = "Tongket";
            this.Tongket.ReadOnly = true;
            this.Tongket.Width = 125;
            // 
            // Diemchu
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diemchu.DefaultCellStyle = dataGridViewCellStyle9;
            this.Diemchu.HeaderText = "Điểm chữ";
            this.Diemchu.MinimumWidth = 6;
            this.Diemchu.Name = "Diemchu";
            this.Diemchu.ReadOnly = true;
            this.Diemchu.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢNG MÔN HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_NamHoc
            // 
            this.cbx_NamHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_NamHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_NamHoc.FormattingEnabled = true;
            this.cbx_NamHoc.Items.AddRange(new object[] {
            "Năm 1_Học kì 1",
            "Năm 1_Học kì 2",
            "Năm 2_Học kì 1",
            "Năm 2_Học kì 2",
            "Năm 3_Học kì 1",
            "Năm 3_Học kì 2",
            "Năm 4_Học kì 1",
            "Năm 4_Học kì 2"});
            this.cbx_NamHoc.Location = new System.Drawing.Point(12, 137);
            this.cbx_NamHoc.Name = "cbx_NamHoc";
            this.cbx_NamHoc.Size = new System.Drawing.Size(347, 28);
            this.cbx_NamHoc.TabIndex = 2;
            this.cbx_NamHoc.Text = "-__-Năm học_ Học kì-__-";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_TimKiem.Location = new System.Drawing.Point(753, 137);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(296, 27);
            this.tbx_TimKiem.TabIndex = 3;
            this.tbx_TimKiem.Text = "(Tìm môn học, mã môn học)";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(1064, 136);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(88, 27);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Xuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xuat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.Location = new System.Drawing.Point(509, 132);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(123, 33);
            this.btn_Xuat.TabIndex = 5;
            this.btn_Xuat.Text = "Xuất file excel";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1169, 691);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.cbx_NamHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrv);
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Điểm Sinh VIên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_NamHoc;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giangvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diemchu;
        private System.Windows.Forms.Button btn_Xuat;
    }
}

