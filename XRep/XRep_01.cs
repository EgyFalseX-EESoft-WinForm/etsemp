using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace ETSEmployee.XRep
{
    public partial class XRep_01 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.AppOptionsTableAdapter adpOptions = new Datasource.dsReportTableAdapters.AppOptionsTableAdapter();
        Datasource.dsReportTableAdapters.XRep_01ATableAdapter adp_A = new Datasource.dsReportTableAdapters.XRep_01ATableAdapter();
        Datasource.dsReportTableAdapters.XRep_01BTableAdapter adp_B = new Datasource.dsReportTableAdapters.XRep_01BTableAdapter();
        public XRep_01()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            adpOptions.Fill(dsReport.AppOptions);
            xrpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(dsReport.AppOptions[0].SchoolLogo));

            adp_A.Fill(dsReport.XRep_01A);
            adp_B.Fill(dsReport.XRep_01B);

        }
        private void XRep_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            int AsaseSalaryId = Convert.ToInt32(Parameters["paramAsaseSalaryId"].Value);
            byte month_code = Convert.ToByte(Parameters["parammonth_code"].Value);

            xRep_01TableAdapter.Fill(dsReport.XRep_01, month_code, AsaseSalaryId);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "paramAsaseSalaryId")
                {
                    xrlAsaseSalaryId.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }
                if (pram.Parameter.Name == "parammonth_code")
                {
                    xrlmonth_code.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }

            }
        }

    }
}
