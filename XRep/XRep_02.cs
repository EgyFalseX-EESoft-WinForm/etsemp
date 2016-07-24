using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace ETSEmployee.XRep
{
    public partial class XRep_02 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsReportTableAdapters.AppOptionsTableAdapter adpOptions = new Datasource.dsReportTableAdapters.AppOptionsTableAdapter();
        Datasource.dsReportTableAdapters.XRep_02ATableAdapter adp_A = new Datasource.dsReportTableAdapters.XRep_02ATableAdapter();
        Datasource.dsReportTableAdapters.XRep_02BTableAdapter adp_B = new Datasource.dsReportTableAdapters.XRep_02BTableAdapter();
        Datasource.dsReportTableAdapters.XRep_02CTableAdapter adp_C = new Datasource.dsReportTableAdapters.XRep_02CTableAdapter();
        public XRep_02()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            //adpOptions.Fill(dsReport.AppOptions);
            //xrpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(dsReport.AppOptions[0].SchoolLogo));

            adp_A.Fill(dsReport.XRep_02A);
            adp_B.Fill(dsReport.XRep_02B);
            adp_C.Fill(dsReport.XRep_02C);

        }
        private void XRep_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            int AsaseSalaryId = Convert.ToInt32(Parameters["paramAsaseSalaryId"].Value);
            byte month_code = Convert.ToByte(Parameters["parammonth_code"].Value);
            Int64 GehaworkId = Convert.ToInt64(Parameters["paramGehaworkId"].Value);

            xRep_02TableAdapter.Fill(dsReport.XRep_02, AsaseSalaryId, month_code, GehaworkId);

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
                if (pram.Parameter.Name == "paramGehaworkId")
                {
                    xrlGehaworkId.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }

            }
        }

    }
}
