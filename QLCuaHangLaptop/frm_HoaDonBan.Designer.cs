﻿namespace QLCuaHangLaptop
{
    partial class frm_HoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.numSl = new System.Windows.Forms.NumericUpDown();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnXoaHD);
            this.panel1.Controls.Add(this.btnTaoHD);
            this.panel1.Controls.Add(this.btnLuuHD);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 62);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "  &Hủy sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Enabled = false;
            this.btnXoaHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(279, 10);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(124, 39);
            this.btnXoaHD.TabIndex = 10;
            this.btnXoaHD.Text = " &Xóa HD";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click_1);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHD.Location = new System.Drawing.Point(5, 10);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(124, 39);
            this.btnTaoHD.TabIndex = 8;
            this.btnTaoHD.Text = "  &Tạo HD";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click_1);
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Enabled = false;
            this.btnLuuHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(136, 10);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(124, 39);
            this.btnLuuHD.TabIndex = 9;
            this.btnLuuHD.Text = "   &Lưu HD";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvKho);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(636, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(537, 287);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kho";
            // 
            // dgvKho
            // 
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(12, 27);
            this.dgvKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 62;
            this.dgvKho.RowTemplate.Height = 28;
            this.dgvKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKho.Size = new System.Drawing.Size(500, 255);
            this.dgvKho.TabIndex = 0;
            this.dgvKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKho_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtMahd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(413, 22);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(156, 29);
            this.txtNgayLap.TabIndex = 5;
            // 
            // txtMahd
            // 
            this.txtMahd.Location = new System.Drawing.Point(131, 22);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.ReadOnly = true;
            this.txtMahd.Size = new System.Drawing.Size(127, 29);
            this.txtMahd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.numSl);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.txtTT);
            this.groupBox3.Controls.Add(this.txtKM);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.txtTen);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(648, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(525, 202);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laptop";
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(408, 155);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 32);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "  &Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Enabled = false;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(325, 154);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 32);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = " &Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // numSl
            // 
            this.numSl.Location = new System.Drawing.Point(121, 70);
            this.numSl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSl.Name = "numSl";
            this.numSl.Size = new System.Drawing.Size(60, 29);
            this.numSl.TabIndex = 12;
            this.numSl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSl.ValueChanged += new System.EventHandler(this.numSl_ValueChanged_2);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(20, 155);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(265, 29);
            this.txtTim.TabIndex = 11;
            this.txtTim.Text = "Mã / Tên sản phẩm";
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click_1);
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(325, 105);
            this.txtTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(168, 29);
            this.txtTT.TabIndex = 10;
            this.txtTT.Text = "0";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(121, 105);
            this.txtKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(61, 29);
            this.txtKM.TabIndex = 9;
            this.txtKM.Text = "0";
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged_2);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(325, 69);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(168, 29);
            this.txtGiaBan.TabIndex = 8;
            this.txtGiaBan.Text = "0";
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged_1);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(325, 26);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(168, 29);
            this.txtTen.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(61, 29);
            this.txtId.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "KM (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvCTHD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(588, 287);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(17, 27);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 62;
            this.dgvCTHD.RowTemplate.Height = 28;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(553, 255);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick_1);
            this.dgvCTHD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCTHD_CellFormatting_1);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(427, 116);
            this.cbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(156, 24);
            this.cbKhachHang.TabIndex = 18;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(145, 117);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(125, 22);
            this.txtNhanVien.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhân viên";
            // 
            // frm_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.HDwwal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 534);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_HoaDonBan";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.NumericUpDown numSl;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}