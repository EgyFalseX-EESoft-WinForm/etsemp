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
    public partial class TBLManagersFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        public TBLManagersFrm()
        {
            InitializeComponent();
            LSMSData.QueryableSource = from q in dsLinq.TBLManagers select q;
        }
        private void RefreshGrid()
        {
            dsLinq.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues,dsLinq.TBLManagers);
            LSMSData.Reload();
        }
        private void TBLManagersFrm_Load(object sender, EventArgs e)
        {
        }
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsData.TBLManagers.Clear();
            Datasource.dsData.TBLManagersRow row = dsData.TBLManagers.NewTBLManagersRow();
            row.EmpID = -1; row.GehaworkId = -1; row.mobile1 = row.mobile12 = row.telwork = row.telhome = row.email = row.address = row.remarks = string.Empty;
            row.datefrom = row.dateto = DateTime.Now;
            row.userin = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID); row.datein = (DateTime)AdpQry.GetServerDatetime();
            Data.TBLManagersDlg dlg = new TBLManagersDlg(row);
            dsData.TBLManagers.AddTBLManagersRow(row);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            row.EndEdit();
            int effectedRows = tBLManagersTableAdapter.Insert(row.EmpID, row.GehaworkId, row.datefrom, row.dateto, row.mobile1, row.mobile12, row.telwork, row.telhome, row.email, row.address, row.remarks, row.userin, row.datein);
            Program.ShowMsg("تم الحفظ", false, this);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshGrid();
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            dsData.TBLManagers.Clear();
            Datasource.dsLinq.TBLManager row = (Datasource.dsLinq.TBLManager)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (row == null)
                return;
            tBLManagersTableAdapter.FillByID(dsData.TBLManagers, row.EmpID, row.GehaworkId);
            Data.TBLManagersDlg dlg = new TBLManagersDlg(dsData.TBLManagers[0]);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            dsData.TBLManagers[0].userin = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID); dsData.TBLManagers[0].datein = (DateTime)AdpQry.GetServerDatetime();
            tBLManagersTableAdapter.Update(dsData.TBLManagers);
            Program.ShowMsg("تم التعديل", false, this);
            Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshGrid();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;
            Datasource.dsLinq.TBLManager row = (Datasource.dsLinq.TBLManager)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (row == null)
                return;
            tBLManagersTableAdapter.Delete(row.EmpID, row.GehaworkId);
            Program.ShowMsg("تم الحذف", false, this);
            Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            RefreshGrid();
        }
        
    }
}