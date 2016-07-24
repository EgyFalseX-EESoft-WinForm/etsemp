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
    public partial class tblmortabatAddFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsData.tblmortabatRow _row;
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.AppOptionsTableAdapter adpOption = new Datasource.dsDataTableAdapters.AppOptionsTableAdapter();
        public tblmortabatAddFrm()
        {
            InitializeComponent();
        }
        void ResetControls()
        {
            lueAsaseSalaryId.EditValue = FXFW.SqlDB.asase_code;
            luemonth_code.EditValue = null;
            lueEmpID.EditValue = null;

            tbasasy.EditValue = 0;
            tbtamin26.EditValue = 0;
            tbtamin24.EditValue = 0;
            tbelawa1.EditValue = 0;
            tbelawa2.EditValue = 0;
            tbelawa3.EditValue = 0;
            tbelawa4.EditValue = 0;
            tbelawa5.EditValue = 0;
            tbegtmaia.EditValue = 0;
            tbedafia.EditValue = 0;
            tbmenha.EditValue = 0;
            tbhadadna.EditValue = 0;
            tbhafez.EditValue = 0;
            tbkhpra.EditValue = 0;
            tbsumesthkak.EditValue = 0;
            tbestamin26.EditValue = 0;
            tbestamin24.EditValue = 0;
            tbestamin14.EditValue = 0;
            tbestamin11.EditValue = 0;
            tbsolaf.EditValue = 0;
            tbabsent.EditValue = 0;
            tbgaza.EditValue = 0;
            tbsumesetktaa.EditValue = 0;
            tbsafy.EditValue = 0;
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
            dsData.tblmortabat.BeginLoadData();
            _row = dsData.tblmortabat.NewtblmortabatRow();
            dsData.tblmortabat.AddtblmortabatRow(_row);

            ResetControls();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;

            try
            {
                

                CreateUpdateRow();

                _row.asasywithout = 0;
                _row.elawajan = 0; _row.elawajulay = 0;
                _row.est1 = 0; _row.est2 = 0; _row.est3 = 0; _row.est4 = 0; _row.est5 = 0;
                _row.esttkta1 = 0; _row.esttkta2 = 0; _row.esttkta3 = 0; _row.esttkta4 = 0;

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