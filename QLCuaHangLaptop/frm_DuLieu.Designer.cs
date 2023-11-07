namespace QLCuaHangLaptop
{
    partial class frm_DuLieu
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
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.p1saoluu;
            this.btnSaoLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaoLuu.Location = new System.Drawing.Point(123, 43);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(248, 364);
            this.btnSaoLuu.TabIndex = 4;
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.p1phuchoi;
            this.btnPhucHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhucHoi.Location = new System.Drawing.Point(430, 43);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(248, 364);
            this.btnPhucHoi.TabIndex = 3;
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            // 
            // frm_DuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.bluewalf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoLuu);
            this.Controls.Add(this.btnPhucHoi);
            this.DoubleBuffered = true;
            this.Name = "frm_DuLieu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Button btnPhucHoi;
    }
}