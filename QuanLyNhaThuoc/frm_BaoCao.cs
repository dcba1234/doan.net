using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frm_BaoCao : Form
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = Quan ly nha thuoc c#; Integrated Security = True");
        public frm_BaoCao()
        {

            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 hd = new DataSet1();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_report", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@thang", dateTimePicker1.Value.Month);
            cmd.Parameters.AddWithValue("@nam", dateTimePicker1.Value.Year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(hd, hd.Tables[0].TableName);
            // da.Fill(hd);
            //ReportDataSource rds = new ReportDataSource("khachHang", hd.Tables[0]);
            reportBindingSource.DataSource = hd;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("date", " tháng " + dateTimePicker1.Value.Month.ToString() + " - " + dateTimePicker1.Value.Year.ToString()));
            //reportParameters.Add(new ReportParameter("tenkh", f.txt_tenkh.Text));
            //reportParameters.Add(new ReportParameter("makh", f.txt_makhachhang.Text));
            //reportParameters.Add(new ReportParameter("sdt", f.sdt));
            //reportParameters.Add(new ReportParameter("diachi", f.diachi));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            con.Close();
            this.reportViewer1.RefreshReport();
        }

        private void frm_BaoCao_Load(object sender, EventArgs e)
        {
            DataSet1 hd = new DataSet1();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_report", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@thang", dateTimePicker1.Value.Month);
            cmd.Parameters.AddWithValue("@nam", dateTimePicker1.Value.Year);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(hd, hd.Tables[0].TableName);
            // da.Fill(hd);
            //ReportDataSource rds = new ReportDataSource("khachHang", hd.Tables[0]);
            reportBindingSource.DataSource = hd;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("date", " tháng " + dateTimePicker1.Value.Month.ToString() + " - " + dateTimePicker1.Value.Year.ToString()));
            //reportParameters.Add(new ReportParameter("tenkh", f.txt_tenkh.Text));
            //reportParameters.Add(new ReportParameter("makh", f.txt_makhachhang.Text));
            //reportParameters.Add(new ReportParameter("sdt", f.sdt));
            //reportParameters.Add(new ReportParameter("diachi", f.diachi));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            con.Close();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
