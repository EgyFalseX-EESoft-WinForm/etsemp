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
    public partial class tblmortabatEditFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsData.tblmortabatRow _row;
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.AppOptionsTableAdapter adpOption = new Datasource.dsDataTableAdapters.AppOptionsTableAdapter();
        Datasource.dsLinq.vtblmortabat _vrow = null;
        public tblmortabatEditFrm(Datasource.dsLinq.vtblmortabat row)
        {
            InitializeComponent();
            _vrow = row;
            tblmortabatTableAdapter.FillByID(dsData.tblmortabat, _vrow.AsaseSalaryId, _vrow.month_code, _vrow.EmpID);
            _row = dsData.tblmortabat[0];
            
        }
        void FillControls()
        {
            lueAsaseSalaryId.EditValue = _vrow.AsaseSalaryId;
            luemonth_code.EditValue = _vrow.month_code;
            lueEmpID.EditValue = _vrow.EmpID;

            tbasasy.EditValue = _vrow.asasy;
            tbtamin26.EditValue = _vrow.tamin26;
            tbtamin24.EditValue = _vrow.tamin24;
            tbelawa1.EditValue = _vrow.elawa1;
            tbelawa2.EditValue = _vrow.elawa2;
            tbelawa3.EditValue = _vrow.elawa3;
            tbelawa4.EditValue = _vrow.elawa4;
            tbelawa5.EditValue = _vrow.elawa5;
            tbegtmaia.EditValue = _vrow.egtmaia;
            tbedafia.EditValue = _vrow.edafia;
            tbmenha.EditValue = _vrow.menha;
            tbhadadna.EditValue = _vrow.menha;
            tbhafez.EditValue = _vrow.hafez;
            tbkhpra.EditValue = _vrow.khpra;
            tbsumesthkak.EditValue = _vrow.sumesthkak;
            tbestamin26.EditValue = _vrow.estamin26;
            tbestamin24.EditValue = _vrow.estamin14;
            tbestamin14.EditValue = _vrow.estamin14;
            tbestamin11.EditValue = _vrow.estamin11;
            tbsolaf.EditValue = _vrow.solaf;
            tbabsent.EditValue = _vrow.absent;
            tbgaza.EditValue = _vrow.gaza;
            tbsumesetktaa.EditValue = _vrow.sumesetktaa;
            tbsafy.EditValue = _vrow.safy;
        }
        void CreateUpdateRow()
        {
            _row.AsaseSalaryId = Convert.ToInt32(lueAsaseSalaryId.EditValue);
            _row.month_code = Convert.ToByte(luemonth_code.EditValue);
            _row.EmpID = Convert.ToInt32(lueEmpID.EditValue);

            _row.asasy = Convert.ToDouble(tbasasy.Value);
            _row.asasywithout = 0;

            _row.tamin26 = Convert.ToDouble(tbtamin26.Value);
            _row.tamin24 = Convert.ToDouble(tbtamin24.Value);
            _row.elawa1 = Convert.ToDouble(tbelawa1.Value);
            _row.elawa2 = Convert.ToDouble(tbelawa2.Value);
            _row.elawa3 = Convert.ToDouble(tbelawa3.Value);
            _row.elawa4 = Convert.ToDouble(tbelawa4.Value);
            _row.elawa5 = Convert.ToDouble(tbelawa5.Value);
            _row.egtmaia = Convert.ToDouble(tbegtmaia.Value);
            _row.edafia = Convert.ToDouble(tbedafia.Value);
            _row.egtmaia = Convert.ToDouble(tbegtmaia.Value);
            _row.menha = Convert.ToDouble(tbmenha.Value);
            _row.hadadna = Convert.ToDouble(tbhadadna.Value);
            _row.hafez = Convert.ToDouble(tbhafez.Value);
            _row.khpra = Convert.ToDouble(tbkhpra.Value);

            _row.sumesthkak = Convert.ToDouble(tbsumesthkak.Value);

            _row.estamin26 = Convert.ToDouble(tbestamin26.Value);
            _row.estamin24 = Convert.ToDouble(tbestamin24.Value);
            _row.estamin14 = Convert.ToDouble(tbestamin14.Value);
            _row.estamin11 = Convert.ToDouble(tbestamin11.Value);
            _row.solaf = Convert.ToDouble(tbsolaf.Value);
            _row.absent = Convert.ToDouble(tbabsent.Value);
            _row.gaza = Convert.ToDouble(tbgaza.Value);

            _row.sumesetktaa = Convert.ToDouble(tbsumesetktaa.Value);

            _row.safy = Convert.ToDouble(tbsafy.Value);

            _row.asasywithout = 0;
            _row.elawajan = 0; _row.elawajulay = 0;
            _row.est1 = 0; _row.est2 = 0; _row.est3 = 0; _row.est4 = 0; _row.est5 = 0;
            _row.esttkta1 = 0; _row.esttkta2 = 0; _row.esttkta3 = 0; _row.esttkta4 = 0;

        }
        void CalcForm()
        {
            Datasource.dsData.AppOptionsRow Options = dsData.AppOptions[0];

            //Est7kakat
            double asasy = Convert.ToDouble(tbasasy.EditValue);

            tbtamin26.EditValue = asasy * 0.26;

            //tbelawa1.EditValue = asasy * Options.alwa1;
            //tbelawa2.EditValue = asasy * Options.alwa2;
            //tbelawa3.EditValue = asasy * Options.alwa3;
            //tbelawa4.EditValue = asasy * Options.alwa4;
            //tbelawa5.EditValue = asasy * Options.alwa5;

            double Variable = Convert.ToDouble(tbelawa1.Value + tbelawa2.Value + tbelawa3.Value + tbelawa4.Value + tbelawa5.Value 
                + tbegtmaia.Value + tbedafia.Value + tbkhpra.Value);

            tbtamin24.EditValue = Variable * 0.24;

            tbsumesthkak.EditValue = tbasasy.Value + tbtamin26.Value + tbtamin24.Value
                + tbelawa1.Value + tbelawa2.Value + tbelawa3.Value + tbelawa4.Value + tbelawa5.Value
                + tbegtmaia.Value + tbedafia.Value + tbmenha.Value + tbhadadna.Value + tbhafez.Value + tbkhpra.Value;

            //Estkta3aat
            tbestamin26.EditValue = asasy * 0.26;
            tbestamin24.EditValue = Variable * 0.24;
            tbestamin14.EditValue = asasy * 0.14;
            tbestamin11.EditValue = Variable * 0.11;

            tbsumesetktaa.EditValue = tbestamin26.Value + tbestamin24.Value + tbestamin14.Value + tbestamin11.Value 
                + tbsolaf.Value + tbabsent.Value + tbgaza.Value;

            //Safi
            tbsafy.Value = tbsumesthkak.Value - tbsumesetktaa.Value;
        }
        private void tblmortabatAddFrm_Load(object sender, EventArgs e)
        {
            adpOption.Fill(dsData.AppOptions);
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
                tblmortabatTableAdapter.Update(dsData.tblmortabat);
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