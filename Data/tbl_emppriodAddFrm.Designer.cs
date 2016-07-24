namespace ETSEmployee.Data
{
    partial class tbl_emppriodAddFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbl_emppriodAddFrm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dsData = new ETSEmployee.Datasource.dsData();
            this.luedayid = new DevExpress.XtraEditors.LookUpEdit();
            this.lueempid = new DevExpress.XtraEditors.LookUpEdit();
            this.tblmortabatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAsaseSalaryId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormonth_code = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tblmortabatTableAdapter = new ETSEmployee.Datasource.dsDataTableAdapters.tblmortabatTableAdapter();
            this.tbdayid = new DevExpress.XtraEditors.CalcEdit();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSdayid = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedayid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueempid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmortabatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAsaseSalaryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormonth_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdayid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSdayid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.luedayid);
            this.dataLayoutControl1.Controls.Add(this.lueempid);
            this.dataLayoutControl1.Controls.Add(this.tbdayid);
            this.dataLayoutControl1.DataSource = this.tblmortabatBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(691, 209, 250, 632);
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(431, 125);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::ETSEmployee.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(329, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 22);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "الغاء";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ETSEmployee.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(313, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luedayid
            // 
            this.luedayid.Location = new System.Drawing.Point(12, 36);
            this.luedayid.Name = "luedayid";
            this.luedayid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luedayid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("dayname", "اليوم", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luedayid.Properties.DataSource = this.LSMSdayid;
            this.luedayid.Properties.DisplayMember = "dayname";
            this.luedayid.Properties.NullText = "";
            this.luedayid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luedayid.Properties.ValueMember = "dayid";
            this.luedayid.Size = new System.Drawing.Size(350, 20);
            this.luedayid.StyleController = this.dataLayoutControl1;
            this.luedayid.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.luedayid, conditionValidationRule1);
            // 
            // lueempid
            // 
            this.lueempid.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lueempid.Location = new System.Drawing.Point(12, 12);
            this.lueempid.Name = "lueempid";
            this.lueempid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueempid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpID", "كود"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNAME", "اسم")});
            this.lueempid.Properties.DataSource = this.LSMSEmp;
            this.lueempid.Properties.DisplayMember = "EMPNAME";
            this.lueempid.Properties.NullText = "";
            this.lueempid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueempid.Properties.ValueMember = "EmpID";
            this.lueempid.Size = new System.Drawing.Size(350, 20);
            this.lueempid.StyleController = this.dataLayoutControl1;
            this.lueempid.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.lueempid, conditionValidationRule2);
            // 
            // tblmortabatBindingSource
            // 
            this.tblmortabatBindingSource.DataMember = "tblmortabat";
            this.tblmortabatBindingSource.DataSource = this.dsData;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemFormonth_code,
            this.ItemForAsaseSalaryId,
            this.ItemForEmpID});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(431, 125);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 33);
            this.layoutControlItem1.Text = "Save";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(317, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(94, 33);
            this.layoutControlItem2.Text = "Cancel";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForAsaseSalaryId
            // 
            this.ItemForAsaseSalaryId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAsaseSalaryId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAsaseSalaryId.Control = this.tbdayid;
            this.ItemForAsaseSalaryId.CustomizationFormText = "Asase Salary Id";
            this.ItemForAsaseSalaryId.Location = new System.Drawing.Point(0, 48);
            this.ItemForAsaseSalaryId.Name = "ItemForAsaseSalaryId";
            this.ItemForAsaseSalaryId.Size = new System.Drawing.Size(411, 24);
            this.ItemForAsaseSalaryId.Text = "عدد الفترات";
            this.ItemForAsaseSalaryId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAsaseSalaryId.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForEmpID
            // 
            this.ItemForEmpID.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmpID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForEmpID.Control = this.lueempid;
            this.ItemForEmpID.CustomizationFormText = "Emp ID";
            this.ItemForEmpID.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmpID.Name = "ItemForEmpID";
            this.ItemForEmpID.Size = new System.Drawing.Size(411, 24);
            this.ItemForEmpID.Text = "الاسم";
            this.ItemForEmpID.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForEmpID.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemFormonth_code
            // 
            this.ItemFormonth_code.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormonth_code.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormonth_code.Control = this.luedayid;
            this.ItemFormonth_code.CustomizationFormText = "month_code";
            this.ItemFormonth_code.Location = new System.Drawing.Point(0, 24);
            this.ItemFormonth_code.Name = "ItemFormonth_code";
            this.ItemFormonth_code.Size = new System.Drawing.Size(411, 24);
            this.ItemFormonth_code.Text = "اليوم";
            this.ItemFormonth_code.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormonth_code.TextSize = new System.Drawing.Size(54, 13);
            // 
            // tblmortabatTableAdapter
            // 
            this.tblmortabatTableAdapter.ClearBeforeFill = true;
            // 
            // tbdayid
            // 
            this.tbdayid.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbdayid.Location = new System.Drawing.Point(12, 60);
            this.tbdayid.Name = "tbdayid";
            this.tbdayid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbdayid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.tbdayid.Size = new System.Drawing.Size(350, 20);
            this.tbdayid.StyleController = this.dataLayoutControl1;
            this.tbdayid.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.tbdayid, conditionValidationRule3);
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(ETSEmployee.Datasource.dsLinq.TBL_Emp);
            this.LSMSEmp.KeyExpression = "[EmpID]";
            // 
            // LSMSdayid
            // 
            this.LSMSdayid.ElementType = typeof(ETSEmployee.Datasource.dsLinq.cd_day);
            this.LSMSdayid.KeyExpression = "[dayid]";
            // 
            // tbl_emppriodAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(431, 125);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tbl_emppriodAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            this.Load += new System.EventHandler(this.tblmortabatAddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedayid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueempid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmortabatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAsaseSalaryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormonth_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdayid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSdayid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Datasource.dsData dsData;
        private System.Windows.Forms.BindingSource tblmortabatBindingSource;
        private Datasource.dsDataTableAdapters.tblmortabatTableAdapter tblmortabatTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit luedayid;
        private DevExpress.XtraEditors.LookUpEdit lueempid;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAsaseSalaryId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpID;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormonth_code;
        private DevExpress.XtraEditors.CalcEdit tbdayid;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSdayid;
    }
}