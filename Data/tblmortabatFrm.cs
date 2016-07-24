using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace ETSEmployee.Data
{
    public partial class tblmortabatFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext() { ObjectTrackingEnabled = false };
        Datasource.dsDataTableAdapters.tblmortabatTableAdapter adp = new Datasource.dsDataTableAdapters.tblmortabatTableAdapter();
        #region -   Functions   -
        public tblmortabatFrm()
        {
            InitializeComponent();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            return;
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDelete, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            //SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDelete.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            LSMSData.QueryableSource = from q in dsLinq.vtblmortabats select q;
            //ActivePriv();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("autoID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["autoID"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtblmortabat row = (Datasource.dsLinq.vtblmortabat)GV.GetRow(GV.FocusedRowHandle);
            tblmortabatEditFrm frm = new tblmortabatEditFrm(row);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LSMSData.Reload();
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtblmortabat row = (Datasource.dsLinq.vtblmortabat)GV.GetRow(GV.FocusedRowHandle);
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                adp.Delete(row.AsaseSalaryId, row.month_code, row.EmpID);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                LSMSData.Reload();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tblmortabatAddFrm frm = new tblmortabatAddFrm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LSMSData.Reload();
                btnNew_Click(btnNew, EventArgs.Empty);
            }
        }
        private void repositoryItemButtonEditBadalat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtblmortabat row = (Datasource.dsLinq.vtblmortabat)GV.GetRow(GV.FocusedRowHandle);
            List<Datasource.dsLinq.vtblbadalat> lst = (from q in dsLinq.vtblbadalats where q.AsaseSalaryId == row.AsaseSalaryId && q.EmpID == row.EmpID && q.month_code == row.month_code select q).ToList<Datasource.dsLinq.vtblbadalat>();
            if (lst.Count == 0)
            {
                MessageBox.Show("لا يوجد بدلات", "الملف غير متاح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tblbadalatEditFrm frm = new tblbadalatEditFrm(lst[0]);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LSMSData.Reload();
            }
        }
        #endregion

        

    }
}