namespace QLCuaHangLaptop
{
    partial class frm_DoiTac
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
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.KH;
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhachHang.Location = new System.Drawing.Point(132, 33);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(239, 391);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.NCC;
            this.btnNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNCC.Location = new System.Drawing.Point(430, 33);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(239, 391);
            this.btnNCC.TabIndex = 2;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // frm_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.bluewalf1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNCC);
            this.Controls.Add(this.btnKhachHang);
            this.DoubleBuffered = true;
            this.Name = "frm_DoiTac";
            this.Load += new System.EventHandler(this.frm_DoiTac_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNCC;
    }
}