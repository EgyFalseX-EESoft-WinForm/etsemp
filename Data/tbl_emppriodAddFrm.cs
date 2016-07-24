using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ETSEmployee.Data
{
    public partial class tbl_emppriodAddFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsDataTableAdapters.tbl_emppriodTableAdapter adp = new Datasource.dsDataTableAdapters.tbl_emppriodTableAdapter();
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.AppOptionsTableAdapter adpOption = new Datasource.dsDataTableAdapters.AppOptionsTableAdapter();
        public tbl_emppriodAddFrm()
        {
            InitializeComponent();
        }
        void ResetControls()
        {
            lueempid.EditValue = null;
            luedayid.EditValue = null;
            tbdayid.EditValue = 1;
        }
        private void tblmortabatAddFrm_Load(object sender, EventArgs e)
        {
            adpOption.Fill(dsData.AppOptions);
            LSMSEmp.QueryableSource = from q in dsLinq.TBL_Emps select q;// where q.JobTypeId == (int)Classes.Core.JobTypeId.Mo3yan_1
            LSMSdayid.QueryableSource = from q in dsLinq.cd_days select q;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            
            try
            {
                for (byte i = 1; i <= tbdayid.Value; i++)
                    adp.Insert(Convert.ToInt32(lueempid.EditValue), i, Convert.ToByte(luedayid.EditValue));
                ResetControls();
                //DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}