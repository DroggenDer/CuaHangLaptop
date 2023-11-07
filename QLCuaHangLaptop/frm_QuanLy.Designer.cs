namespace QLCuaHangLaptop
{
    partial class frm_QuanLy
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
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.l3ChucVu;
            this.btnChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChucVu.Location = new System.Drawing.Point(59, 66);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(212, 341);
            this.btnChucVu.TabIndex = 2;
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.l4NhanVien;
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNhanVien.Location = new System.Drawing.Point(293, 66);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(212, 341);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.l1ThongKe;
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.Location = new System.Drawing.Point(522, 66);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(212, 341);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.bluewalf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnChucVu);
            this.DoubleBuffered = true;
            this.Name = "frm_QuanLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThongKe;
    }
}