namespace QLCuaHangLaptop
{
    partial class frm_QuanLy_ThongKe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvXuat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhap = new System.Windows.Forms.DataGridView();
            this.btnTK = new System.Windows.Forms.Button();
            this.dp2 = new System.Windows.Forms.DateTimePicker();
            this.dp1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvXuat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(649, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(611, 321);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HD Xuất";
            // 
            // dgvXuat
            // 
            this.dgvXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuat.Location = new System.Drawing.Point(16, 27);
            this.dgvXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXuat.Name = "dgvXuat";
            this.dgvXuat.RowHeadersWidth = 62;
            this.dgvXuat.RowTemplate.Height = 28;
            this.dgvXuat.Size = new System.Drawing.Size(576, 284);
            this.dgvXuat.TabIndex = 3;
            this.dgvXuat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvXuat_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvNhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(612, 321);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HD nhập";
            // 
            // dgvNhap
            // 
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhap.Location = new System.Drawing.Point(19, 27);
            this.dgvNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.RowHeadersWidth = 62;
            this.dgvNhap.RowTemplate.Height = 28;
            this.dgvNhap.Size = new System.Drawing.Size(576, 284);
            this.dgvNhap.TabIndex = 3;
            this.dgvNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhap_CellFormatting);
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(945, 13);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(196, 34);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Xem thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dp2
            // 
            this.dp2.Location = new System.Drawing.Point(589, 23);
            this.dp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp2.Name = "dp2";
            this.dp2.Size = new System.Drawing.Size(237, 22);
            this.dp2.TabIndex = 7;
            // 
            // dp1
            // 
            this.dp1.Location = new System.Drawing.Point(177, 23);
            this.dp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp1.Name = "dp1";
            this.dp1.Size = new System.Drawing.Size(237, 22);
            this.dp1.TabIndex = 6;
            // 
            // frm_QuanLy_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCuaHangLaptop.Properties.Resources.blueww;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dp2);
            this.Controls.Add(this.dp1);
            this.Name = "frm_QuanLy_ThongKe";
            this.Load += new System.EventHandler(this.frm_QuanLy_ThongKe_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhap;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DateTimePicker dp2;
        private System.Windows.Forms.DateTimePicker dp1;
    }
}