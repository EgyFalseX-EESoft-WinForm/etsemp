namespace ETSEmployee
{
    partial class Qry01Frm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.vQry01BindingSource = new System.Windows.Forms.BindingSource();
            this.dsQry = new ETSEmployee.Datasource.dsQry();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTH_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpNationalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOBILE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldyana_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpStateName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnationaltyname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQualifiedPlaceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqualName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecializationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltameen_date1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltameen_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoaahel_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWork_Start_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehawork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemPictureEditImg = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintExport = new DevExpress.XtraEditors.SimpleButton();
            this.vQry01TableAdapter = new ETSEmployee.Datasource.dsQryTableAdapters.vQry01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlData.DataSource = this.vQry01BindingSource;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.EmbeddedNavigator.TextStringFormat = "صف {0} من {1}";
            this.gridControlData.Location = new System.Drawing.Point(0, 53);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemPictureEditImg,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEditDMY});
            this.gridControlData.Size = new System.Drawing.Size(734, 404);
            this.gridControlData.TabIndex = 1;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // vQry01BindingSource
            // 
            this.vQry01BindingSource.DataMember = "vQry01";
            this.vQry01BindingSource.DataSource = this.dsQry;
            // 
            // dsQry
            // 
            this.dsQry.DataSetName = "dsQry";
            this.dsQry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewData.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewData.Appearance.Empty.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewData.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewData.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gridViewData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewData.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewData.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Gray;
            this.gridViewData.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewData.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSlateGray;
            this.gridViewData.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewData.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewData.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewData.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewData.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewData.Appearance.Row.Options.UseBackColor = true;
            this.gridViewData.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewData.Appearance.SelectedRow.BackColor = System.Drawing.Color.DimGray;
            this.gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewData.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridViewData.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpID,
            this.colEMPNAME,
            this.colBIRTH_DATE,
            this.colEmpNationalID,
            this.colDepartment,
            this.colMOBILE_NO,
            this.colEmpJobName,
            this.colEmp_Address,
            this.coldyana_name,
            this.colEmpStateName,
            this.colJobType,
            this.colnationaltyname,
            this.colQualifiedPlaceName,
            this.colqualName,
            this.colSpecializationName,
            this.coltameen_date1,
            this.coltameen_no,
            this.colMoaahel_Date,
            this.colWork_Start_Date,
            this.colGehawork,
            this.colAge});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsCustomization.AllowRowSizing = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowFooter = true;
            // 
            // colEmpID
            // 
            this.colEmpID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpID.Caption = "كود";
            this.colEmpID.FieldName = "EmpID";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.Visible = true;
            this.colEmpID.VisibleIndex = 0;
            // 
            // colEMPNAME
            // 
            this.colEMPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.Caption = "الاسم";
            this.colEMPNAME.FieldName = "EMPNAME";
            this.colEMPNAME.Name = "colEMPNAME";
            this.colEMPNAME.Visible = true;
            this.colEMPNAME.VisibleIndex = 1;
            // 
            // colBIRTH_DATE
            // 
            this.colBIRTH_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.Caption = "تاريخ الميلاد";
            this.colBIRTH_DATE.FieldName = "BIRTH_DATE";
            this.colBIRTH_DATE.Name = "colBIRTH_DATE";
            this.colBIRTH_DATE.Visible = true;
            this.colBIRTH_DATE.VisibleIndex = 2;
            // 
            // colEmpNationalID
            // 
            this.colEmpNationalID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpNationalID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNationalID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpNationalID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpNationalID.Caption = "الرقم القومي";
            this.colEmpNationalID.FieldName = "EmpNationalID";
            this.colEmpNationalID.Name = "colEmpNationalID";
            this.colEmpNationalID.Visible = true;
            this.colEmpNationalID.VisibleIndex = 3;
            // 
            // colDepartment
            // 
            this.colDepartment.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartment.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartment.Caption = "القسم";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 4;
            // 
            // colMOBILE_NO
            // 
            this.colMOBILE_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colMOBILE_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOBILE_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOBILE_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOBILE_NO.Caption = "موبيل";
            this.colMOBILE_NO.FieldName = "MOBILE_NO";
            this.colMOBILE_NO.Name = "colMOBILE_NO";
            this.colMOBILE_NO.Visible = true;
            this.colMOBILE_NO.VisibleIndex = 5;
            // 
            // colEmpJobName
            // 
            this.colEmpJobName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.Caption = "وظيفة";
            this.colEmpJobName.FieldName = "EmpJobName";
            this.colEmpJobName.Name = "colEmpJobName";
            this.colEmpJobName.Visible = true;
            this.colEmpJobName.VisibleIndex = 6;
            // 
            // colEmp_Address
            // 
            this.colEmp_Address.AppearanceCell.Options.UseTextOptions = true;
            this.colEmp_Address.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Address.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmp_Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmp_Address.Caption = "العنوان";
            this.colEmp_Address.FieldName = "Emp_Address";
            this.colEmp_Address.Name = "colEmp_Address";
            this.colEmp_Address.Visible = true;
            this.colEmp_Address.VisibleIndex = 7;
            // 
            // coldyana_name
            // 
            this.coldyana_name.AppearanceCell.Options.UseTextOptions = true;
            this.coldyana_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldyana_name.AppearanceHeader.Options.UseTextOptions = true;
            this.coldyana_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldyana_name.Caption = "الديانة";
            this.coldyana_name.FieldName = "dyana_name";
            this.coldyana_name.Name = "coldyana_name";
            this.coldyana_name.Visible = true;
            this.coldyana_name.VisibleIndex = 8;
            // 
            // colEmpStateName
            // 
            this.colEmpStateName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpStateName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpStateName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpStateName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpStateName.Caption = "الحالة الوظيفية";
            this.colEmpStateName.FieldName = "EmpStateName";
            this.colEmpStateName.Name = "colEmpStateName";
            this.colEmpStateName.Visible = true;
            this.colEmpStateName.VisibleIndex = 9;
            // 
            // colJobType
            // 
            this.colJobType.AppearanceCell.Options.UseTextOptions = true;
            this.colJobType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobType.AppearanceHeader.Options.UseTextOptions = true;
            this.colJobType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobType.Caption = "نوع الوظيفة";
            this.colJobType.FieldName = "JobType";
            this.colJobType.Name = "colJobType";
            this.colJobType.Visible = true;
            this.colJobType.VisibleIndex = 10;
            // 
            // colnationaltyname
            // 
            this.colnationaltyname.AppearanceCell.Options.UseTextOptions = true;
            this.colnationaltyname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnationaltyname.AppearanceHeader.Options.UseTextOptions = true;
            this.colnationaltyname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnationaltyname.Caption = "الجنسية";
            this.colnationaltyname.FieldName = "nationaltyname";
            this.colnationaltyname.Name = "colnationaltyname";
            this.colnationaltyname.Visible = true;
            this.colnationaltyname.VisibleIndex = 12;
            // 
            // colQualifiedPlaceName
            // 
            this.colQualifiedPlaceName.AppearanceCell.Options.UseTextOptions = true;
            this.colQualifiedPlaceName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQualifiedPlaceName.AppearanceHeader.Options.UseTextOptions = true;
            this.colQualifiedPlaceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQualifiedPlaceName.Caption = "جهة الحصول";
            this.colQualifiedPlaceName.FieldName = "QualifiedPlaceName";
            this.colQualifiedPlaceName.Name = "colQualifiedPlaceName";
            this.colQualifiedPlaceName.Visible = true;
            this.colQualifiedPlaceName.VisibleIndex = 13;
            // 
            // colqualName
            // 
            this.colqualName.AppearanceCell.Options.UseTextOptions = true;
            this.colqualName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.AppearanceHeader.Options.UseTextOptions = true;
            this.colqualName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.Caption = "المؤهل";
            this.colqualName.FieldName = "qualName";
            this.colqualName.Name = "colqualName";
            this.colqualName.Visible = true;
            this.colqualName.VisibleIndex = 14;
            // 
            // colSpecializationName
            // 
            this.colSpecializationName.AppearanceCell.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.Caption = "التخصص";
            this.colSpecializationName.FieldName = "SpecializationName";
            this.colSpecializationName.Name = "colSpecializationName";
            this.colSpecializationName.Visible = true;
            this.colSpecializationName.VisibleIndex = 15;
            // 
            // coltameen_date1
            // 
            this.coltameen_date1.AppearanceCell.Options.UseTextOptions = true;
            this.coltameen_date1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_date1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltameen_date1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_date1.Caption = "تاريخ التأمين";
            this.coltameen_date1.FieldName = "tameen_date1";
            this.coltameen_date1.Name = "coltameen_date1";
            this.coltameen_date1.Visible = true;
            this.coltameen_date1.VisibleIndex = 16;
            // 
            // coltameen_no
            // 
            this.coltameen_no.AppearanceCell.Options.UseTextOptions = true;
            this.coltameen_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_no.AppearanceHeader.Options.UseTextOptions = true;
            this.coltameen_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltameen_no.Caption = "رقم التأمين";
            this.coltameen_no.FieldName = "tameen_no";
            this.coltameen_no.Name = "coltameen_no";
            this.coltameen_no.Visible = true;
            this.coltameen_no.VisibleIndex = 17;
            // 
            // colMoaahel_Date
            // 
            this.colMoaahel_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colMoaahel_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMoaahel_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colMoaahel_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMoaahel_Date.Caption = "سنة التخرج";
            this.colMoaahel_Date.FieldName = "Moaahel_Date";
            this.colMoaahel_Date.Name = "colMoaahel_Date";
            this.colMoaahel_Date.Visible = true;
            this.colMoaahel_Date.VisibleIndex = 18;
            // 
            // colWork_Start_Date
            // 
            this.colWork_Start_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colWork_Start_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWork_Start_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colWork_Start_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWork_Start_Date.Caption = "تاريخ بداية العمل";
            this.colWork_Start_Date.FieldName = "Work_Start_Date";
            this.colWork_Start_Date.Name = "colWork_Start_Date";
            this.colWork_Start_Date.Visible = true;
            this.colWork_Start_Date.VisibleIndex = 19;
            // 
            // colGehawork
            // 
            this.colGehawork.AppearanceCell.Options.UseTextOptions = true;
            this.colGehawork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehawork.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehawork.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehawork.Caption = "جهة العمل";
            this.colGehawork.FieldName = "Gehawork";
            this.colGehawork.Name = "colGehawork";
            this.colGehawork.Visible = true;
            this.colGehawork.VisibleIndex = 11;
            // 
            // colAge
            // 
            this.colAge.AppearanceCell.Options.UseTextOptions = true;
            this.colAge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAge.AppearanceHeader.Options.UseTextOptions = true;
            this.colAge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAge.Caption = "العمر";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 20;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "u";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Mask.EditMask = "u";
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemPictureEditImg
            // 
            this.repositoryItemPictureEditImg.Name = "repositoryItemPictureEditImg";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            this.repositoryItemDateEditDMY.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPrintExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(734, 47);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPrintExport
            // 
            this.btnPrintExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExport.Location = new System.Drawing.Point(588, 12);
            this.btnPrintExport.Name = "btnPrintExport";
            this.btnPrintExport.Size = new System.Drawing.Size(134, 23);
            this.btnPrintExport.TabIndex = 0;
            this.btnPrintExport.Text = "طباعه و تصدير";
            this.btnPrintExport.Click += new System.EventHandler(this.btnPrintExport_Click);
            // 
            // vQry01TableAdapter
            // 
            this.vQry01TableAdapter.ClearBeforeFill = true;
            // 
            // Qry01Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControlData);
            this.Name = "Qry01Frm";
            this.Text = "بيانات اساسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Qry06Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vQry01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEditImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditImg;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrintExport;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private Datasource.dsQry dsQry;
        private System.Windows.Forms.BindingSource vQry01BindingSource;
        private Datasource.dsQryTableAdapters.vQry01TableAdapter vQry01TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTH_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpNationalID;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colMOBILE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Address;
        private DevExpress.XtraGrid.Columns.GridColumn coldyana_name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpStateName;
        private DevExpress.XtraGrid.Columns.GridColumn colJobType;
        private DevExpress.XtraGrid.Columns.GridColumn colnationaltyname;
        private DevExpress.XtraGrid.Columns.GridColumn colQualifiedPlaceName;
        private DevExpress.XtraGrid.Columns.GridColumn colqualName;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecializationName;
        private DevExpress.XtraGrid.Columns.GridColumn coltameen_date1;
        private DevExpress.XtraGrid.Columns.GridColumn coltameen_no;
        private DevExpress.XtraGrid.Columns.GridColumn colMoaahel_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colWork_Start_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colGehawork;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;

    }
}