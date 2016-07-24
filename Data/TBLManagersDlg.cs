using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ETSEmployee.Data
{
    public partial class TBLManagersDlg : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsData.TBLManagersRow _row;
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        public TBLManagersDlg(Datasource.dsData.TBLManagersRow row)
        {
            InitializeComponent();
            LSMSEmp.QueryableSource = from q in dsLinq.TBL_Emps select q;
            LSMSGeha.QueryableSource = from q in dsLinq.TBLGehaworks select q;
            _row = row;

            lueEmpID.DataBindings.Add("EditValue", _row, "EmpID");
            lueGehaworkId.DataBindings.Add("EditValue", _row, "GehaworkId");
            dedatefrom.DataBindings.Add("EditValue", _row, "datefrom");
            dedateto.DataBindings.Add("EditValue", _row, "dateto");
            tbmobile1.DataBindings.Add("EditValue", _row, "mobile1");
            tbmobile12.DataBindings.Add("EditValue", _row, "mobile12");
            tbtelwork.DataBindings.Add("EditValue", _row, "telwork");
            tbtelhome.DataBindings.Add("EditValue", _row, "telhome");
            tbemail.DataBindings.Add("EditValue", _row, "email");
            tbaddress.DataBindings.Add("EditValue", _row, "address");
            tbremarks.DataBindings.Add("EditValue", _row, "remarks");

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _row.AcceptChanges();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _row.RejectChanges();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}