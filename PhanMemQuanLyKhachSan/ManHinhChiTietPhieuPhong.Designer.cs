﻿namespace PhanMemQuanLyKhachSan
{
    partial class frmChiTietPhieuPhong
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
            this.lblChiTietPP = new System.Windows.Forms.Label();
            this.txtChiTietGiaPhong = new System.Windows.Forms.TextBox();
            this.txtChiTietSoKhach = new System.Windows.Forms.TextBox();
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.txtChiTietSoDem = new System.Windows.Forms.TextBox();
            this.txtChiTietQuocTich = new System.Windows.Forms.TextBox();
            this.txtChiTietTenKhach = new System.Windows.Forms.TextBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.lblChiTietThanhTien = new System.Windows.Forms.Label();
            this.lblChiTietSoDem = new System.Windows.Forms.Label();
            this.lblChiTietNgayDi = new System.Windows.Forms.Label();
            this.lblChiTietQuocTich = new System.Windows.Forms.Label();
            this.lblChiTietTenKhach = new System.Windows.Forms.Label();
            this.lblChiTietSoPhong = new System.Windows.Forms.Label();
            this.lblChiTietGiaPhong = new System.Windows.Forms.Label();
            this.lblChiTietNgayVao = new System.Windows.Forms.Label();
            this.lblChiTietSoKhach = new System.Windows.Forms.Label();
            this.lblChiTietTenBooking = new System.Windows.Forms.Label();
            this.lblChiTietLoaiPhong = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.btnInCuaCTPP = new System.Windows.Forms.Button();
            this.btnSuaCuaCTPP = new System.Windows.Forms.Button();
            this.btnLuuCuaCTPP = new System.Windows.Forms.Button();
            this.btnXoaCuaCTPP = new System.Windows.Forms.Button();
            this.btnThemCuaCTPP = new System.Windows.Forms.Button();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cmbTenBooking = new System.Windows.Forms.ComboBox();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.cmbSoPhong = new System.Windows.Forms.ComboBox();
            this.lblChiTietTongTien = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChiTietPP
            // 
            this.lblChiTietPP.AutoSize = true;
            this.lblChiTietPP.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPP.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPP.Location = new System.Drawing.Point(278, 14);
            this.lblChiTietPP.Name = "lblChiTietPP";
            this.lblChiTietPP.Size = new System.Drawing.Size(351, 37);
            this.lblChiTietPP.TabIndex = 1;
            this.lblChiTietPP.Text = "CHI TIẾT PHIẾU PHÒNG";
            this.lblChiTietPP.Click += new System.EventHandler(this.lblChiTietPP_Click);
            // 
            // txtChiTietGiaPhong
            // 
            this.txtChiTietGiaPhong.Location = new System.Drawing.Point(160, 254);
            this.txtChiTietGiaPhong.Name = "txtChiTietGiaPhong";
            this.txtChiTietGiaPhong.Size = new System.Drawing.Size(149, 25);
            this.txtChiTietGiaPhong.TabIndex = 84;
            this.txtChiTietGiaPhong.TextChanged += new System.EventHandler(this.txtChiTietGiaPhong_TextChanged);
            // 
            // txtChiTietSoKhach
            // 
            this.txtChiTietSoKhach.Location = new System.Drawing.Point(160, 164);
            this.txtChiTietSoKhach.Name = "txtChiTietSoKhach";
            this.txtChiTietSoKhach.Size = new System.Drawing.Size(149, 25);
            this.txtChiTietSoKhach.TabIndex = 82;
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.AllowDrop = true;
            this.dgvChiTietDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.Column3,
            this.Column5,
            this.Column6,
            this.id});
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(29, 378);
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.RowHeadersVisible = false;
            this.dgvChiTietDichVu.RowHeadersWidth = 51;
            this.dgvChiTietDichVu.RowTemplate.Height = 24;
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(707, 175);
            this.dgvChiTietDichVu.TabIndex = 77;
            this.dgvChiTietDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDichVu_CellContentClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "Tên dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gía";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(448, 342);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(56, 25);
            this.txtSoLuong.TabIndex = 73;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(164, 342);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(121, 26);
            this.cmbTenDichVu.TabIndex = 70;
            this.cmbTenDichVu.SelectedIndexChanged += new System.EventHandler(this.cmbTenDichVu_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(449, 320);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(69, 19);
            this.lblSoLuong.TabIndex = 69;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDichVu.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.Location = new System.Drawing.Point(185, 320);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(87, 19);
            this.lblTenDichVu.TabIndex = 66;
            this.lblTenDichVu.Text = "Tên dịch vụ";
            // 
            // txtChiTietSoDem
            // 
            this.txtChiTietSoDem.Location = new System.Drawing.Point(423, 254);
            this.txtChiTietSoDem.Name = "txtChiTietSoDem";
            this.txtChiTietSoDem.Size = new System.Drawing.Size(77, 25);
            this.txtChiTietSoDem.TabIndex = 64;
            this.txtChiTietSoDem.Click += new System.EventHandler(this.txtChiTietGiaPhong_TextChanged);
            this.txtChiTietSoDem.TextChanged += new System.EventHandler(this.txtChiTietGiaPhong_TextChanged);
            // 
            // txtChiTietQuocTich
            // 
            this.txtChiTietQuocTich.Location = new System.Drawing.Point(656, 152);
            this.txtChiTietQuocTich.Name = "txtChiTietQuocTich";
            this.txtChiTietQuocTich.Size = new System.Drawing.Size(168, 25);
            this.txtChiTietQuocTich.TabIndex = 62;
            this.txtChiTietQuocTich.TextChanged += new System.EventHandler(this.txtChiTietQuocTich_TextChanged);
            // 
            // txtChiTietTenKhach
            // 
            this.txtChiTietTenKhach.Location = new System.Drawing.Point(655, 104);
            this.txtChiTietTenKhach.Name = "txtChiTietTenKhach";
            this.txtChiTietTenKhach.Size = new System.Drawing.Size(168, 25);
            this.txtChiTietTenKhach.TabIndex = 61;
            this.txtChiTietTenKhach.TextChanged += new System.EventHandler(this.txtChiTietTenKhach_TextChanged);
            // 
            // lblDichVu
            // 
            this.lblDichVu.AutoSize = true;
            this.lblDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblDichVu.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDichVu.Location = new System.Drawing.Point(409, 295);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(119, 32);
            this.lblDichVu.TabIndex = 59;
            this.lblDichVu.Text = "DỊCH VỤ";
            // 
            // lblChiTietThanhTien
            // 
            this.lblChiTietThanhTien.AutoSize = true;
            this.lblChiTietThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietThanhTien.Location = new System.Drawing.Point(554, 257);
            this.lblChiTietThanhTien.Name = "lblChiTietThanhTien";
            this.lblChiTietThanhTien.Size = new System.Drawing.Size(82, 19);
            this.lblChiTietThanhTien.TabIndex = 58;
            this.lblChiTietThanhTien.Text = "Thành tiền";
            this.lblChiTietThanhTien.Click += new System.EventHandler(this.lblChiTietThanhTien_Click);
            // 
            // lblChiTietSoDem
            // 
            this.lblChiTietSoDem.AutoSize = true;
            this.lblChiTietSoDem.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoDem.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoDem.Location = new System.Drawing.Point(372, 260);
            this.lblChiTietSoDem.Name = "lblChiTietSoDem";
            this.lblChiTietSoDem.Size = new System.Drawing.Size(57, 19);
            this.lblChiTietSoDem.TabIndex = 57;
            this.lblChiTietSoDem.Text = "Số đêm";
            // 
            // lblChiTietNgayDi
            // 
            this.lblChiTietNgayDi.AutoSize = true;
            this.lblChiTietNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayDi.Location = new System.Drawing.Point(554, 210);
            this.lblChiTietNgayDi.Name = "lblChiTietNgayDi";
            this.lblChiTietNgayDi.Size = new System.Drawing.Size(62, 19);
            this.lblChiTietNgayDi.TabIndex = 56;
            this.lblChiTietNgayDi.Text = "Ngày đi";
            // 
            // lblChiTietQuocTich
            // 
            this.lblChiTietQuocTich.AutoSize = true;
            this.lblChiTietQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietQuocTich.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietQuocTich.Location = new System.Drawing.Point(554, 158);
            this.lblChiTietQuocTich.Name = "lblChiTietQuocTich";
            this.lblChiTietQuocTich.Size = new System.Drawing.Size(72, 19);
            this.lblChiTietQuocTich.TabIndex = 55;
            this.lblChiTietQuocTich.Text = "Quốc tịch";
            // 
            // lblChiTietTenKhach
            // 
            this.lblChiTietTenKhach.AutoSize = true;
            this.lblChiTietTenKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenKhach.Location = new System.Drawing.Point(554, 110);
            this.lblChiTietTenKhach.Name = "lblChiTietTenKhach";
            this.lblChiTietTenKhach.Size = new System.Drawing.Size(77, 19);
            this.lblChiTietTenKhach.TabIndex = 54;
            this.lblChiTietTenKhach.Text = "Tên khách";
            this.lblChiTietTenKhach.Click += new System.EventHandler(this.lblChiTietTenKhach_Click);
            // 
            // lblChiTietSoPhong
            // 
            this.lblChiTietSoPhong.AutoSize = true;
            this.lblChiTietSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoPhong.Location = new System.Drawing.Point(554, 59);
            this.lblChiTietSoPhong.Name = "lblChiTietSoPhong";
            this.lblChiTietSoPhong.Size = new System.Drawing.Size(70, 19);
            this.lblChiTietSoPhong.TabIndex = 53;
            this.lblChiTietSoPhong.Text = "Số phòng";
            // 
            // lblChiTietGiaPhong
            // 
            this.lblChiTietGiaPhong.AutoSize = true;
            this.lblChiTietGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietGiaPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietGiaPhong.Location = new System.Drawing.Point(45, 261);
            this.lblChiTietGiaPhong.Name = "lblChiTietGiaPhong";
            this.lblChiTietGiaPhong.Size = new System.Drawing.Size(78, 19);
            this.lblChiTietGiaPhong.TabIndex = 52;
            this.lblChiTietGiaPhong.Text = "Giá phòng";
            // 
            // lblChiTietNgayVao
            // 
            this.lblChiTietNgayVao.AutoSize = true;
            this.lblChiTietNgayVao.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayVao.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayVao.Location = new System.Drawing.Point(45, 210);
            this.lblChiTietNgayVao.Name = "lblChiTietNgayVao";
            this.lblChiTietNgayVao.Size = new System.Drawing.Size(72, 19);
            this.lblChiTietNgayVao.TabIndex = 51;
            this.lblChiTietNgayVao.Text = "Ngày vào";
            // 
            // lblChiTietSoKhach
            // 
            this.lblChiTietSoKhach.AutoSize = true;
            this.lblChiTietSoKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoKhach.Location = new System.Drawing.Point(45, 167);
            this.lblChiTietSoKhach.Name = "lblChiTietSoKhach";
            this.lblChiTietSoKhach.Size = new System.Drawing.Size(69, 19);
            this.lblChiTietSoKhach.TabIndex = 50;
            this.lblChiTietSoKhach.Text = "Số khách";
            // 
            // lblChiTietTenBooking
            // 
            this.lblChiTietTenBooking.AutoSize = true;
            this.lblChiTietTenBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenBooking.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenBooking.Location = new System.Drawing.Point(45, 113);
            this.lblChiTietTenBooking.Name = "lblChiTietTenBooking";
            this.lblChiTietTenBooking.Size = new System.Drawing.Size(90, 19);
            this.lblChiTietTenBooking.TabIndex = 49;
            this.lblChiTietTenBooking.Text = "Tên booking";
            // 
            // lblChiTietLoaiPhong
            // 
            this.lblChiTietLoaiPhong.AutoSize = true;
            this.lblChiTietLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietLoaiPhong.Location = new System.Drawing.Point(45, 65);
            this.lblChiTietLoaiPhong.Name = "lblChiTietLoaiPhong";
            this.lblChiTietLoaiPhong.Size = new System.Drawing.Size(81, 19);
            this.lblChiTietLoaiPhong.TabIndex = 48;
            this.lblChiTietLoaiPhong.Text = "Loại phòng";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lblKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(522, 583);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(88, 19);
            this.lblKhachHang.TabIndex = 90;
            this.lblKhachHang.Text = "Khách hàng";
            this.lblKhachHang.Click += new System.EventHandler(this.lblKhachHang_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(519, 608);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(76, 19);
            this.lblTongTien.TabIndex = 91;
            this.lblTongTien.Text = "Tổng tiền:";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(551, 659);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(80, 19);
            this.lblNhanVien.TabIndex = 92;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // btnInCuaCTPP
            // 
            this.btnInCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnInCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconIn;
            this.btnInCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInCuaCTPP.Location = new System.Drawing.Point(758, 406);
            this.btnInCuaCTPP.Name = "btnInCuaCTPP";
            this.btnInCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnInCuaCTPP.TabIndex = 88;
            this.btnInCuaCTPP.Text = "In";
            this.btnInCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInCuaCTPP.UseVisualStyleBackColor = false;
            this.btnInCuaCTPP.Click += new System.EventHandler(this.btnInCuaCTPP_Click);
            // 
            // btnSuaCuaCTPP
            // 
            this.btnSuaCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnSuaCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconTimKiem;
            this.btnSuaCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCuaCTPP.Location = new System.Drawing.Point(758, 556);
            this.btnSuaCuaCTPP.Name = "btnSuaCuaCTPP";
            this.btnSuaCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnSuaCuaCTPP.TabIndex = 87;
            this.btnSuaCuaCTPP.Text = "Xem Lại";
            this.btnSuaCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCuaCTPP.UseVisualStyleBackColor = false;
            this.btnSuaCuaCTPP.Click += new System.EventHandler(this.btnSuaCuaCTPP_Click);
            // 
            // btnLuuCuaCTPP
            // 
            this.btnLuuCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnLuuCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconLuu;
            this.btnLuuCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCuaCTPP.Location = new System.Drawing.Point(758, 484);
            this.btnLuuCuaCTPP.Name = "btnLuuCuaCTPP";
            this.btnLuuCuaCTPP.Size = new System.Drawing.Size(84, 39);
            this.btnLuuCuaCTPP.TabIndex = 86;
            this.btnLuuCuaCTPP.Text = "Lưu";
            this.btnLuuCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCuaCTPP.UseVisualStyleBackColor = false;
            this.btnLuuCuaCTPP.Click += new System.EventHandler(this.btnLuuCuaCTPP_Click);
            // 
            // btnXoaCuaCTPP
            // 
            this.btnXoaCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnXoaCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconDelete;
            this.btnXoaCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCuaCTPP.Location = new System.Drawing.Point(758, 336);
            this.btnXoaCuaCTPP.Name = "btnXoaCuaCTPP";
            this.btnXoaCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnXoaCuaCTPP.TabIndex = 85;
            this.btnXoaCuaCTPP.Text = "Xóa";
            this.btnXoaCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCuaCTPP.UseVisualStyleBackColor = false;
            this.btnXoaCuaCTPP.Click += new System.EventHandler(this.btnXoaCuaCTPP_Click);
            // 
            // btnThemCuaCTPP
            // 
            this.btnThemCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnThemCuaCTPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconThem;
            this.btnThemCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCuaCTPP.Location = new System.Drawing.Point(758, 261);
            this.btnThemCuaCTPP.Name = "btnThemCuaCTPP";
            this.btnThemCuaCTPP.Size = new System.Drawing.Size(84, 37);
            this.btnThemCuaCTPP.TabIndex = 74;
            this.btnThemCuaCTPP.Text = "Thêm";
            this.btnThemCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCuaCTPP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCuaCTPP.UseVisualStyleBackColor = false;
            this.btnThemCuaCTPP.Click += new System.EventHandler(this.btnThemCuaCTPP_Click);
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnTroVeCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCTPP.Image = global::PhanMemQuanLyKhachSan.Properties.Resources.iconBack;
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(30, 12);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(96, 36);
            this.btnTroVeCuaCTPP.TabIndex = 0;
            this.btnTroVeCuaCTPP.Text = "Trở về";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCTPP.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(160, 65);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(149, 26);
            this.cmbLoaiPhong.TabIndex = 94;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // cmbTenBooking
            // 
            this.cmbTenBooking.FormattingEnabled = true;
            this.cmbTenBooking.Items.AddRange(new object[] {
            "Booking.com",
            "Agoda",
            "Travel Loka",
            "AirBnB",
            "Đan Việt",
            "My Tour",
            "Expedia",
            "Khách Tự Đến",
            "Khách Đối Tác"});
            this.cmbTenBooking.Location = new System.Drawing.Point(160, 113);
            this.cmbTenBooking.Name = "cmbTenBooking";
            this.cmbTenBooking.Size = new System.Drawing.Size(149, 26);
            this.cmbTenBooking.TabIndex = 95;
            this.cmbTenBooking.SelectedIndexChanged += new System.EventHandler(this.cmbTenBooking_SelectedIndexChanged);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "";
            this.dtpNgayDen.Enabled = false;
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(160, 210);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(149, 25);
            this.dtpNgayDen.TabIndex = 96;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(655, 210);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(169, 25);
            this.dtpNgayDi.TabIndex = 97;
            // 
            // cmbSoPhong
            // 
            this.cmbSoPhong.FormattingEnabled = true;
            this.cmbSoPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSoPhong.Location = new System.Drawing.Point(655, 53);
            this.cmbSoPhong.Name = "cmbSoPhong";
            this.cmbSoPhong.Size = new System.Drawing.Size(168, 26);
            this.cmbSoPhong.TabIndex = 98;
            this.cmbSoPhong.SelectedIndexChanged += new System.EventHandler(this.cmbSoPhong_SelectedIndexChanged);
            // 
            // lblChiTietTongTien
            // 
            this.lblChiTietTongTien.AutoSize = true;
            this.lblChiTietTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTongTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTongTien.Location = new System.Drawing.Point(611, 608);
            this.lblChiTietTongTien.Name = "lblChiTietTongTien";
            this.lblChiTietTongTien.Size = new System.Drawing.Size(16, 19);
            this.lblChiTietTongTien.TabIndex = 100;
            this.lblChiTietTongTien.Text = "0";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(655, 254);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(16, 19);
            this.lblThanhTien.TabIndex = 101;
            this.lblThanhTien.Text = "0";
            this.lblThanhTien.Click += new System.EventHandler(this.lblThanhTien_Click);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Items.AddRange(new object[] {
            "Standard",
            "Superior",
            "Deluxe"});
            this.cmbNhanVien.Location = new System.Drawing.Point(609, 653);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(155, 26);
            this.cmbNhanVien.TabIndex = 102;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(27, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 53);
            this.label1.TabIndex = 103;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(144, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 55);
            this.label2.TabIndex = 103;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(266, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 55);
            this.label3.TabIndex = 103;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(385, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 55);
            this.label4.TabIndex = 103;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(26, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 56);
            this.label5.TabIndex = 103;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(144, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 56);
            this.label6.TabIndex = 103;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(266, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 56);
            this.label7.TabIndex = 103;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(385, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 56);
            this.label8.TabIndex = 103;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmChiTietPhieuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PhanMemQuanLyKhachSan.Properties.Resources.b17;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblChiTietTongTien);
            this.Controls.Add(this.cmbSoPhong);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.cmbTenBooking);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnInCuaCTPP);
            this.Controls.Add(this.btnSuaCuaCTPP);
            this.Controls.Add(this.btnLuuCuaCTPP);
            this.Controls.Add(this.btnXoaCuaCTPP);
            this.Controls.Add(this.txtChiTietGiaPhong);
            this.Controls.Add(this.txtChiTietSoKhach);
            this.Controls.Add(this.dgvChiTietDichVu);
            this.Controls.Add(this.btnThemCuaCTPP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbTenDichVu);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenDichVu);
            this.Controls.Add(this.txtChiTietSoDem);
            this.Controls.Add(this.txtChiTietQuocTich);
            this.Controls.Add(this.txtChiTietTenKhach);
            this.Controls.Add(this.lblDichVu);
            this.Controls.Add(this.lblChiTietThanhTien);
            this.Controls.Add(this.lblChiTietSoDem);
            this.Controls.Add(this.lblChiTietNgayDi);
            this.Controls.Add(this.lblChiTietQuocTich);
            this.Controls.Add(this.lblChiTietTenKhach);
            this.Controls.Add(this.lblChiTietSoPhong);
            this.Controls.Add(this.lblChiTietGiaPhong);
            this.Controls.Add(this.lblChiTietNgayVao);
            this.Controls.Add(this.lblChiTietSoKhach);
            this.Controls.Add(this.lblChiTietTenBooking);
            this.Controls.Add(this.lblChiTietLoaiPhong);
            this.Controls.Add(this.lblChiTietPP);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiTietPhieuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Chi Tiết Phiếu Phòng";
            this.Load += new System.EventHandler(this.frmChiTietPhieuPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVeCuaCTPP;
        private System.Windows.Forms.Label lblChiTietPP;
        private System.Windows.Forms.TextBox txtChiTietGiaPhong;
        private System.Windows.Forms.TextBox txtChiTietSoKhach;
        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
        private System.Windows.Forms.Button btnThemCuaCTPP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.TextBox txtChiTietSoDem;
        private System.Windows.Forms.TextBox txtChiTietQuocTich;
        private System.Windows.Forms.TextBox txtChiTietTenKhach;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.Label lblChiTietThanhTien;
        private System.Windows.Forms.Label lblChiTietSoDem;
        private System.Windows.Forms.Label lblChiTietNgayDi;
        private System.Windows.Forms.Label lblChiTietQuocTich;
        private System.Windows.Forms.Label lblChiTietTenKhach;
        private System.Windows.Forms.Label lblChiTietSoPhong;
        private System.Windows.Forms.Label lblChiTietGiaPhong;
        private System.Windows.Forms.Label lblChiTietNgayVao;
        private System.Windows.Forms.Label lblChiTietSoKhach;
        private System.Windows.Forms.Label lblChiTietTenBooking;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.Button btnXoaCuaCTPP;
        private System.Windows.Forms.Button btnLuuCuaCTPP;
        private System.Windows.Forms.Button btnSuaCuaCTPP;
        private System.Windows.Forms.Button btnInCuaCTPP;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.ComboBox cmbTenBooking;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.ComboBox cmbSoPhong;
        private System.Windows.Forms.Label lblChiTietTongTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}