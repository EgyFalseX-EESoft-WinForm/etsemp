﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;

namespace ETSEmployee
{
    public partial class EMPinoutFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public EMPinoutFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDAgazainout:
                    repositoryItemGridLookUpEditAgazainoutId.DataSource = SqlDB.LoadDataTable(@"SELECT AgazainoutId, Agazainout FROM CDAgazainout");
                    repositoryItemGridLookUpEditAgazainoutId.DisplayMember = "Agazainout";
                    repositoryItemGridLookUpEditAgazainoutId.ValueMember = "AgazainoutId";
                    break;
                case CodeFrm.TableNames.All:
                    //CDAgazainout
                    repositoryItemGridLookUpEditAgazainoutId.DataSource = SqlDB.LoadDataTable(@"SELECT AgazainoutId, Agazainout FROM CDAgazainout");
                    repositoryItemGridLookUpEditAgazainoutId.DisplayMember = "Agazainout";
                    repositoryItemGridLookUpEditAgazainoutId.ValueMember = "AgazainoutId";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, EMPNAME FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "EMPNAME";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, agaza_st_date, agaza_end_date, AgazainoutId, agaza_MEMEO, datein, userin, 
            EmpID AS EmpID_SRC, agaza_st_date AS agaza_st_date_SRC FROM EMPinout");
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditagaza_type_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAgazainout);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDAgazainout);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            string EmpID;
            if (row["EmpID"].ToString() == string.Empty)
                EmpID = "NULL";
            else
                EmpID = row["EmpID"].ToString();

            string AgazainoutId;
            if (row["AgazainoutId"].ToString() == string.Empty)
                AgazainoutId = "NULL";
            else
                AgazainoutId = row["AgazainoutId"].ToString();

            string agaza_st_date;
            if (row["agaza_st_date"].ToString() == string.Empty)
                agaza_st_date = "NULL";
            else
                agaza_st_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["agaza_st_date"].ToString()));

            string agaza_end_date;
            if (row["agaza_end_date"].ToString() == string.Empty)
                agaza_end_date = "NULL";
            else
                agaza_end_date = string.Format("Convert(datetime, '{0}', 103)", SqlDB.ConvertToDateDMY(row["agaza_end_date"].ToString()));

            string agaza_MEMEO;
            if (row["agaza_MEMEO"].ToString() == string.Empty)
                agaza_MEMEO = "NULL";
            else
                agaza_MEMEO = String.Format("N'{0}'", row["agaza_MEMEO"]);

            try
            {
                if (row["EmpID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO EMPinout (EmpID, agaza_st_date, agaza_end_date, AgazainoutId, agaza_MEMEO, datein, userin)
                    VALUES ({0}, {1}, {2}, {3}, {4}, GETDATE(), {5})", EmpID, agaza_st_date, agaza_end_date, AgazainoutId, agaza_MEMEO, SqlDB.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE EMPinout SET EmpID = {0}, agaza_st_date = {1}, agaza_end_date = {2}, AgazainoutId = {3}, agaza_MEMEO = {4}, datein = GETDATE(), userin = {5}
                    WHERE (EmpID = {6}) AND (agaza_st_date = Convert(datetime, '{7}', 103))"
                        , EmpID, agaza_st_date, agaza_end_date, AgazainoutId, agaza_MEMEO, SqlDB.UserInfo.UserID, row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["agaza_st_date_SRC"].ToString()));
                }
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(string.Format(@"UPDATE TBL_Emp SET JOB_STATUS_ID = (SELECT JOB_STATUS FROM CDAgazainout WHERE AgazainoutId = {0}) WHERE EmpID = {1}", AgazainoutId, EmpID));
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحذير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["EmpID_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From EMPinout Where EmpID = {0} And agaza_st_date = Convert(datetime, '{1}', 103)",
                row["EmpID_SRC"], SqlDB.ConvertToDateDMY(row["agaza_st_date_SRC"].ToString()));
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion
        
    }
}