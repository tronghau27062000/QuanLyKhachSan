﻿namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatThongTinNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panThongTinNhanVien = new System.Windows.Forms.Panel();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemTTNV = new System.Windows.Forms.TextBox();
            this.btnXoaTTNV = new System.Windows.Forms.Button();
            this.btnThemTTNV = new System.Windows.Forms.Button();
            this.btnBackTTNV = new System.Windows.Forms.Button();
            this.btnLuuTTNV = new System.Windows.Forms.Button();
            this.picThongTinNhanVien = new System.Windows.Forms.PictureBox();
            this.btnTimKiemTTNV = new System.Windows.Forms.Button();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panThongTinNhanVien
            // 
            this.panThongTinNhanVien.BackColor = System.Drawing.Color.Turquoise;
            this.panThongTinNhanVien.Controls.Add(this.dgvThongTinNhanVien);
            this.panThongTinNhanVien.Location = new System.Drawing.Point(85, 244);
            this.panThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.panThongTinNhanVien.Name = "panThongTinNhanVien";
            this.panThongTinNhanVien.Size = new System.Drawing.Size(1464, 638);
            this.panThongTinNhanVien.TabIndex = 18;
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongTinNhanVien.ColumnHeadersHeight = 40;
            this.dgvThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.TenVV});
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(31, 21);
            this.dgvThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.ReadOnly = true;
            this.dgvThongTinNhanVien.RowHeadersVisible = false;
            this.dgvThongTinNhanVien.RowHeadersWidth = 51;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(1411, 598);
            this.dgvThongTinNhanVien.TabIndex = 0;
            this.dgvThongTinNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenVV
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.TenVV.DefaultCellStyle = dataGridViewCellStyle6;
            this.TenVV.FillWeight = 120F;
            this.TenVV.HeaderText = "Tên Nhân Viên";
            this.TenVV.MinimumWidth = 6;
            this.TenVV.Name = "TenVV";
            this.TenVV.ReadOnly = true;
            // 
            // txtTimKiemTTNV
            // 
            this.txtTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTTNV.Location = new System.Drawing.Point(504, 27);
            this.txtTimKiemTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemTTNV.Multiline = true;
            this.txtTimKiemTTNV.Name = "txtTimKiemTTNV";
            this.txtTimKiemTTNV.Size = new System.Drawing.Size(560, 45);
            this.txtTimKiemTTNV.TabIndex = 11;
            // 
            // btnXoaTTNV
            // 
            this.btnXoaTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnXoaTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTTNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTTNV.Location = new System.Drawing.Point(716, 143);
            this.btnXoaTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTTNV.Name = "btnXoaTTNV";
            this.btnXoaTTNV.Size = new System.Drawing.Size(121, 48);
            this.btnXoaTTNV.TabIndex = 17;
            this.btnXoaTTNV.Text = "Xóa";
            this.btnXoaTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTTNV.UseVisualStyleBackColor = false;
            this.btnXoaTTNV.Click += new System.EventHandler(this.btnXoaTTNV_Click);
            // 
            // btnThemTTNV
            // 
            this.btnThemTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnThemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTTNV.Location = new System.Drawing.Point(504, 143);
            this.btnThemTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTTNV.Name = "btnThemTTNV";
            this.btnThemTTNV.Size = new System.Drawing.Size(116, 48);
            this.btnThemTTNV.TabIndex = 16;
            this.btnThemTTNV.Text = "Thêm";
            this.btnThemTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTTNV.UseVisualStyleBackColor = false;
            this.btnThemTTNV.Click += new System.EventHandler(this.btnThemTTNV_Click);
            // 
            // btnBackTTNV
            // 
            this.btnBackTTNV.BackColor = System.Drawing.Color.Turquoise;
            this.btnBackTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTTNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnBackTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTTNV.Location = new System.Drawing.Point(22, 24);
            this.btnBackTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackTTNV.Name = "btnBackTTNV";
            this.btnBackTTNV.Size = new System.Drawing.Size(112, 48);
            this.btnBackTTNV.TabIndex = 15;
            this.btnBackTTNV.Text = "Back";
            this.btnBackTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackTTNV.UseVisualStyleBackColor = false;
            this.btnBackTTNV.Click += new System.EventHandler(this.BtnBackTTNV_Click);
            // 
            // btnLuuTTNV
            // 
            this.btnLuuTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnLuuTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuTTNV.Location = new System.Drawing.Point(921, 143);
            this.btnLuuTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuTTNV.Name = "btnLuuTTNV";
            this.btnLuuTTNV.Size = new System.Drawing.Size(120, 48);
            this.btnLuuTTNV.TabIndex = 13;
            this.btnLuuTTNV.Text = "Lưu";
            this.btnLuuTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuTTNV.UseVisualStyleBackColor = false;
            this.btnLuuTTNV.Click += new System.EventHandler(this.btnLuuTTNV_Click);
            // 
            // picThongTinNhanVien
            // 
            this.picThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.picThongTinNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picThongTinNhanVien.Location = new System.Drawing.Point(1308, 15);
            this.picThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.picThongTinNhanVien.Name = "picThongTinNhanVien";
            this.picThongTinNhanVien.Size = new System.Drawing.Size(241, 185);
            this.picThongTinNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThongTinNhanVien.TabIndex = 12;
            this.picThongTinNhanVien.TabStop = false;
            this.picThongTinNhanVien.Click += new System.EventHandler(this.picThongTinNhanVien_Click);
            // 
            // btnTimKiemTTNV
            // 
            this.btnTimKiemTTNV.BackColor = System.Drawing.Color.Pink;
            this.btnTimKiemTTNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTTNV.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconTimKiem;
            this.btnTimKiemTTNV.Location = new System.Drawing.Point(1073, 27);
            this.btnTimKiemTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemTTNV.Name = "btnTimKiemTTNV";
            this.btnTimKiemTTNV.Size = new System.Drawing.Size(169, 46);
            this.btnTimKiemTTNV.TabIndex = 10;
            this.btnTimKiemTTNV.Text = "Tìm Kiếm";
            this.btnTimKiemTTNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemTTNV.UseVisualStyleBackColor = false;
            this.btnTimKiemTTNV.Click += new System.EventHandler(this.btnTimKiemTTNV_Click);
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.Pink;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatLoaiPhong.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconHuy;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(1115, 142);
            this.btnHuyCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(113, 49);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 19;
            this.btnHuyCapNhatLoaiPhong.Text = "Hủy";
            this.btnHuyCapNhatLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnHuyCapNhatLoaiPhong.Click += new System.EventHandler(this.btnHuyCapNhatLoaiPhong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(232, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 188);
            this.panel1.TabIndex = 20;
            // 
            // frmCapNhatThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1643, 913);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.panThongTinNhanVien);
            this.Controls.Add(this.btnXoaTTNV);
            this.Controls.Add(this.btnThemTTNV);
            this.Controls.Add(this.btnBackTTNV);
            this.Controls.Add(this.btnLuuTTNV);
            this.Controls.Add(this.picThongTinNhanVien);
            this.Controls.Add(this.txtTimKiemTTNV);
            this.Controls.Add(this.btnTimKiemTTNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCapNhatThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmCapNhatThongTinNhanVien_Load);
            this.panThongTinNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panThongTinNhanVien;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.Button btnXoaTTNV;
        private System.Windows.Forms.Button btnThemTTNV;
        private System.Windows.Forms.Button btnBackTTNV;
        private System.Windows.Forms.Button btnLuuTTNV;
        private System.Windows.Forms.PictureBox picThongTinNhanVien;
        private System.Windows.Forms.TextBox txtTimKiemTTNV;
        private System.Windows.Forms.Button btnTimKiemTTNV;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVV;
        private System.Windows.Forms.Panel panel1;
    }
}