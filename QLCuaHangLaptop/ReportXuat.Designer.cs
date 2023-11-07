namespace QLCuaHangLaptop
{
    partial class ReportXuat
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyCuaHangLaptopDataSet = new QLCuaHangLaptop.QuanLyCuaHangLaptopDataSet();
            this.ChiTietHDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHDBTableAdapter = new QLCuaHangLaptop.QuanLyCuaHangLaptopDataSetTableAdapters.ChiTietHDBTableAdapter();
            this.HoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonBanTableAdapter = new QLCuaHangLaptop.QuanLyCuaHangLaptopDataSetTableAdapters.HoaDonBanTableAdapter();
            this.LaptopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaptopTableAdapter = new QLCuaHangLaptop.QuanLyCuaHangLaptopDataSetTableAdapters.LaptopTableAdapter();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new QLCuaHangLaptop.QuanLyCuaHangLaptopDataSetTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangLaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHDBBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.HoaDonBanBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.LaptopBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCuaHangLaptop.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyCuaHangLaptopDataSet
            // 
            this.QuanLyCuaHangLaptopDataSet.DataSetName = "QuanLyCuaHangLaptopDataSet";
            this.QuanLyCuaHangLaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHDBBindingSource
            // 
            this.ChiTietHDBBindingSource.DataMember = "ChiTietHDB";
            this.ChiTietHDBBindingSource.DataSource = this.QuanLyCuaHangLaptopDataSet;
            // 
            // ChiTietHDBTableAdapter
            // 
            this.ChiTietHDBTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonBanBindingSource
            // 
            this.HoaDonBanBindingSource.DataMember = "HoaDonBan";
            this.HoaDonBanBindingSource.DataSource = this.QuanLyCuaHangLaptopDataSet;
            // 
            // HoaDonBanTableAdapter
            // 
            this.HoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // LaptopBindingSource
            // 
            this.LaptopBindingSource.DataMember = "Laptop";
            this.LaptopBindingSource.DataSource = this.QuanLyCuaHangLaptopDataSet;
            // 
            // LaptopTableAdapter
            // 
            this.LaptopTableAdapter.ClearBeforeFill = true;
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.QuanLyCuaHangLaptopDataSet;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // ReportXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportXuat";
            this.Text = "ReportXuat";
            this.Load += new System.EventHandler(this.ReportXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCuaHangLaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHDBBindingSource;
        private QuanLyCuaHangLaptopDataSet QuanLyCuaHangLaptopDataSet;
        private System.Windows.Forms.BindingSource HoaDonBanBindingSource;
        private System.Windows.Forms.BindingSource LaptopBindingSource;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private QuanLyCuaHangLaptopDataSetTableAdapters.ChiTietHDBTableAdapter ChiTietHDBTableAdapter;
        private QuanLyCuaHangLaptopDataSetTableAdapters.HoaDonBanTableAdapter HoaDonBanTableAdapter;
        private QuanLyCuaHangLaptopDataSetTableAdapters.LaptopTableAdapter LaptopTableAdapter;
        private QuanLyCuaHangLaptopDataSetTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}