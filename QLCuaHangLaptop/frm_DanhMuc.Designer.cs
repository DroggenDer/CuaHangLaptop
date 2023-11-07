namespace QLCuaHangLaptop
{
    partial class frm_DanhMuc
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
            this.btnTinhTrang = new System.Windows.Forms.Button();
            this.btnThuongHieu = new System.Windows.Forms.Button();
            this.btnBaoHanh = new System.Windows.Forms.Button();
            this.btnKichThuoc = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhTrang
            // 
            this.btnTinhTrang.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.TinhTrang;
            this.btnTinhTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTinhTrang.Location = new System.Drawing.Point(18, 121);
            this.btnTinhTrang.Name = "btnTinhTrang";
            this.btnTinhTrang.Size = new System.Drawing.Size(146, 227);
            this.btnTinhTrang.TabIndex = 0;
            this.btnTinhTrang.UseVisualStyleBackColor = true;
            this.btnTinhTrang.Click += new System.EventHandler(this.btnTinhTrang_Click);
            // 
            // btnThuongHieu
            // 
            this.btnThuongHieu.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.ThuongHieu;
            this.btnThuongHieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThuongHieu.Location = new System.Drawing.Point(170, 121);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(146, 227);
            this.btnThuongHieu.TabIndex = 1;
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.BaoHanh;
            this.btnBaoHanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaoHanh.Location = new System.Drawing.Point(322, 121);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Size = new System.Drawing.Size(146, 227);
            this.btnBaoHanh.TabIndex = 2;
            this.btnBaoHanh.UseVisualStyleBackColor = true;
            this.btnBaoHanh.Click += new System.EventHandler(this.btnBaoHanh_Click);
            // 
            // btnKichThuoc
            // 
            this.btnKichThuoc.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.KichThuoc;
            this.btnKichThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKichThuoc.Location = new System.Drawing.Point(474, 121);
            this.btnKichThuoc.Name = "btnKichThuoc";
            this.btnKichThuoc.Size = new System.Drawing.Size(146, 227);
            this.btnKichThuoc.TabIndex = 3;
            this.btnKichThuoc.UseVisualStyleBackColor = true;
            this.btnKichThuoc.Click += new System.EventHandler(this.btnKichThuoc_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.Laptop;
            this.btnLaptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaptop.Location = new System.Drawing.Point(629, 121);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(159, 227);
            this.btnLaptop.TabIndex = 4;
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.bluewalf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnKichThuoc);
            this.Controls.Add(this.btnBaoHanh);
            this.Controls.Add(this.btnThuongHieu);
            this.Controls.Add(this.btnTinhTrang);
            this.DoubleBuffered = true;
            this.Name = "frm_DanhMuc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTrang;
        private System.Windows.Forms.Button btnThuongHieu;
        private System.Windows.Forms.Button btnBaoHanh;
        private System.Windows.Forms.Button btnKichThuoc;
        private System.Windows.Forms.Button btnLaptop;
    }
}