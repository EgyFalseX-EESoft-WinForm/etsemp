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
    public partial class tblbadalatEditFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsData.tblbadalatRow _row;
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.AppOptionsTableAdapter adpOption = new Datasource.dsDataTableAdapters.AppOptionsTableAdapter();
        Datasource.dsDataTableAdapters.tblbadalatTableAdapter adp = new Datasource.dsDataTableAdapters.tblbadalatTableAdapter();
        Datasource.dsLinq.vtblbadalat _vrow = null;
        public tblbadalatEditFrm(Datasource.dsLinq.vtblbadalat row)
        {
            InitializeComponent();
            _vrow = row;
            adp.FillByID(dsData.tblbadalat, _vrow.AsaseSalaryId, _vrow.month_code, _vrow.EmpID);
            _row = dsData.tblbadalat[0];
        }
        void FillControls()
        {
            lueAsaseSalaryId.EditValue = _vrow.AsaseSalaryId;
            luemonth_code.EditValue = _vrow.month_code;
            lueEmpID.EditValue = _vrow.EmpID;

            tbfatra1.EditValue = _vrow.fatra1;
            tbfatra2.EditValue = _vrow.fatra2;
            tbbadalgohood.EditValue = _vrow.badalgohood;
            tbfark.EditValue = _vrow.badalgohood;
            tbyears.EditValue = _vrow.years;
            tbhafez.EditValue = _vrow.hafez;
            tbsumesthkakbadal.EditValue = _vrow.sumesthkakbadal;
            tbdays.EditValue = _vrow.days;
            tbsoolaf.EditValue = _vrow.soolaf;
            tbabsent.EditValue = _vrow.absent;
            tbgazaa.EditValue = _vrow.gazaa;
            tbsumesetktaa.EditValue = _vrow.sumesetktaa;
            tbsafy.EditValue = _vrow.safy;
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
            FillControls();
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