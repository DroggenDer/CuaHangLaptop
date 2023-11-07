namespace QLCuaHangLaptop
{
    partial class frm_HoaDon
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
            this.btnHDB = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHDB
            // 
            this.btnHDB.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.l5HDB;
            this.btnHDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHDB.Location = new System.Drawing.Point(431, 56);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.Size = new System.Drawing.Size(248, 364);
            this.btnHDB.TabIndex = 1;
            this.btnHDB.UseVisualStyleBackColor = true;
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.l6HDN;
            this.btnHDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHDN.Location = new System.Drawing.Point(124, 56);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(248, 364);
            this.btnHDN.TabIndex = 2;
            this.btnHDN.UseVisualStyleBackColor = true;
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.bluewalf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHDN);
            this.Controls.Add(this.btnHDB);
            this.DoubleBuffered = true;
            this.Name = "frm_HoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHDB;
        private System.Windows.Forms.Button btnHDN;
    }
}