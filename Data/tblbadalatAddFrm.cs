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
    public partial class tblbadalatAddFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsData.tblbadalatRow _row;
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.AppOptionsTableAdapter adpOption = new Datasource.dsDataTableAdapters.AppOptionsTableAdapter();
        Datasource.dsDataTableAdapters.tblbadalatTableAdapter adp = new Datasource.dsDataTableAdapters.tblbadalatTableAdapter();
        public tblbadalatAddFrm()
        {
            InitializeComponent();
        }
        void ResetControls()
        {
            lueAsaseSalaryId.EditValue = FXFW.SqlDB.asase_code;
            luemonth_code.EditValue = null;
            lueEmpID.EditValue = null;

            tbfatra1.EditValue = 0;
            tbfatra2.EditValue = 0;
            tbbadalgohood.EditValue = 0;
            tbfark.EditValue = 0;
            tbyears.EditValue = 0;
            tbhafez.EditValue = 0;
            tbhafez.EditValue = 0;
            tbsumesthkakbadal.EditValue = 0;
            tbdays.EditValue = 0;
            tbsoolaf.EditValue = 0;
            tbabsent.EditValue = 0;
            tbgazaa.EditValue = 0;
            tbsumesetktaa.EditValue = 0;
            tbsafy.EditValue = 0;
        }
        void CreateUpdateRow()
        {
            _row.AsaseSalaryId = Convert.ToInt32(lueAsaseSalaryId.EditValue);
            _row.month_code = Convert.ToByte(luemonth_code.EditValue);
            _row.EmpID = Convert.ToInt32(lueEmpID.EditValue);

            _row.fatra1 = Convert.ToDouble(tbfatra1.Value);
            _row.fatra2 = Convert.ToDouble(tbfatra2.Value);
            _row.badalgohood = Convert.ToDouble(tbbadalgohood.Value);
            _row.fark = Convert.ToDouble(tbfark.Value);
            _row.years = Convert.ToDouble(tbyears.Value);
            _row.hafez = Convert.ToDouble(tbhafez.Value);
            _row.sumesthkakbadal = Convert.ToDouble(tbsumesthkakbadal.Value);

            _row.days = Convert.ToDouble(tbdays.Value);
            _row.absent = Convert.ToDouble(tbabsent.Value);
            _row.gazaa = Convert.ToDouble(tbgazaa.Value);
            _row.soolaf = Convert.ToDouble(tbsoolaf.Value);
            _row.sumesetktaa = Convert.ToDouble(tbsumesetktaa.Value);

            _row.est1 = 0; _row.est2 = 0;
            _row.esttkta1 = 0; _row.esttkta2 = 0;

            _row.safy = Convert.ToDouble(tbsafy.Value);
        }
        void CalcForm()
        {

            tbsumesthkakbadal.EditValue = Convert.ToDouble(tbfatra1.Value + tbfatra2.Value + tbbadalgohood.Value + tbfark.Value + tbyears.Value + tbhafez.Value);

            tbsumesetktaa.EditValue = Convert.ToDouble(tbdays.Value + tbabsent.Value + tbgazaa.Value + tbsoolaf.Value);

            //Safi
            tbsafy.Value = tbsumesthkakbadal.Value - tbsumesetktaa.Value;
        }
        private void tblmortabatAddFrm_Load(object sender, EventArgs e)
        {
            this.cDMonthTableAdapter.Fill(this.dsData.CDMonth);
            this.cD_AsaseSalaryTableAdapter.Fill(this.dsData.CD_AsaseSalary);
            LSMSEmp.QueryableSource = from q in dsLinq.TBL_Emps where q.JobTypeId == (int)Classes.Core.JobTypeId.Mo3yan_1 select q;
            dsData.tblbadalat.BeginLoadData();
            _row = dsData.tblbadalat.NewtblbadalatRow();
            dsData.tblbadalat.AddtblbadalatRow(_row);

            ResetControls();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                CreateUpdateRow();
                _row.userin = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID);
                _row.datein = (DateTime)AdpQry.GetServerDatetime();
                //dsData.tblmortabat.EndLoadData();
                _row.EndEdit();
                if (adp.Update(dsData.tblbadalat) > 0)
                    DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TXT_EditValueChanged(object sender, EventArgs e)
        {
            CalcForm();
        }
    }
}