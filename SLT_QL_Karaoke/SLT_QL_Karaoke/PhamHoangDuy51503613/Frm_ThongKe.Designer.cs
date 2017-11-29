

namespace PhamHoangDuy51503613
{
    partial class Frm_ThongKe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.dpk_NgayThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rpv_BaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem Thống Kê";
            // 
            // dpk_NgayThang
            // 
            this.dpk_NgayThang.CustomFormat = "dd/MM/yyyy";
            this.dpk_NgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_NgayThang.Location = new System.Drawing.Point(131, 35);
            this.dpk_NgayThang.Name = "dpk_NgayThang";
            this.dpk_NgayThang.Size = new System.Drawing.Size(111, 23);
            this.dpk_NgayThang.TabIndex = 2;
            this.dpk_NgayThang.ValueChanged += new System.EventHandler(this.dpk_NgayThang_ValueChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(814, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Báo Cáo Doanh Thu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpv_BaoCao
            // 
            this.rpv_BaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.rpv_BaoCao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_BaoCao.LocalReport.ReportEmbeddedResource = "";
            this.rpv_BaoCao.LocalReport.ReportPath = "Rpt_BaoCao.rdlc";
            this.rpv_BaoCao.Location = new System.Drawing.Point(0, 64);
            this.rpv_BaoCao.Name = "rpv_BaoCao";
            this.rpv_BaoCao.Size = new System.Drawing.Size(814, 363);
            this.rpv_BaoCao.TabIndex = 4;
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 427);
            this.Controls.Add(this.rpv_BaoCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpk_NgayThang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpk_NgayThang;
        private System.Windows.Forms.Label label2;

        private Microsoft.Reporting.WinForms.ReportViewer rpv_BaoCao;
    }
}