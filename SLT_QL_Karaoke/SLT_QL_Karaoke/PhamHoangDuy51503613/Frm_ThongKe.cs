using System;
using System.Data;
using System.Windows.Forms;
using PresentationLayer;
using DataAccessLayer;
using Microsoft.Reporting.WebForms;
using PhamHoangDuy51503613.DataSet1TableAdapters;

namespace PhamHoangDuy51503613
{
    public partial class Frm_ThongKe : Form
    {
        Cls_HoaDon_DTA HDon_DATA = new Cls_HoaDon_DTA();
        Cls_HoaDon_PTA HDon_PTA = new Cls_HoaDon_PTA();

        string sDk = "";
        DataTable TblHoaDon;

        DataView dv;
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
 
            //1 reset report
            this.rpv_BaoCao.Reset();
            //2 format report
            rpv_BaoCao.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            rpv_BaoCao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpv_BaoCao.ZoomPercent = 100;

            //config

            DataSet1 dataset = new DataSet1();
            dataset.BeginInit();
            this.rpv_BaoCao.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataset.Tables["DtHoaDon"]));
            this.rpv_BaoCao.LocalReport.ReportPath = "../../rptReportHoaDon.rdlc";
            this.rpv_BaoCao.Location = new System.Drawing.Point(0, 0);
            dataset.EndInit();

            DataSet1TableAdapters.DtHoaDonTableAdapter DTHoaDon = new DataSet1TableAdapters.DtHoaDonTableAdapter();
            DTHoaDon.Connection.ConnectionString = HDon_PTA.sChuoiKetNoi();
            DTHoaDon.ClearBeforeFill = true;

            if (sDk != "")
                DTHoaDon.FillBy(dataset.DtHoaDon, sDk);
            else
                DTHoaDon.Fill(dataset.DtHoaDon);


                     

            this.rpv_BaoCao.RefreshReport();
        }

        

        private void dpk_NgayThang_ValueChanged(object sender, EventArgs e)
        {

            sDk = dpk_NgayThang.Value.Day.ToString();
            Frm_ThongKe_Load(sender, e);
        }

       
        
    }
}
