namespace ETSEmployee.Data
{
    partial class TBLManagersFrm
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
            this.barManagerMin = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehawork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatefrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobile1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmobile12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelwork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelhome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dsData = new ETSEmployee.Datasource.dsData();
            this.tBLManagersTableAdapter = new ETSEmployee.Datasource.dsDataTableAdapters.TBLManagersTableAdapter();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerMin
            // 
            this.barManagerMin.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManagerMin.Controller = this.barAndDockingController1;
            this.barManagerMin.DockControls.Add(this.barDockControlTop);
            this.barManagerMin.DockControls.Add(this.barDockControlBottom);
            this.barManagerMin.DockControls.Add(this.barDockControlLeft);
            this.barManagerMin.DockControls.Add(this.barDockControlRight);
            this.barManagerMin.Form = this;
            this.barManagerMin.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd});
            this.barManagerMin.MainMenu = this.bar2;
            this.barManagerMin.MaxItemId = 1;
            this.barManagerMin.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            // 
            // bar2
            // 
            this.bar2.BarName = "Sub menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "اضافة";
            this.bbiAdd.Glyph = global::ETSEmployee.Properties.Resources.add_16x16;
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 362);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 338);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 338);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.LSMSData;
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 24);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMin;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDelete});
            this.gridControlMain.Size = new System.Drawing.Size(884, 338);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(ETSEmployee.Datasource.dsLinq.TBLManager);
            this.LSMSData.KeyExpression = "[EmpID], [GehaworkId]";
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMPNAME,
            this.colGehawork,
            this.coldatefrom,
            this.coldateto,
            this.colmobile1,
            this.colmobile12,
            this.coltelwork,
            this.coltelhome,
            this.colemail,
            this.coladdress,
            this.colremarks,
            this.colEdit,
            this.colDelete});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // colEMPNAME
            // 
            this.colEMPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.Caption = "الاسم";
            this.colEMPNAME.FieldName = "TBL_Emp.EMPNAME";
            this.colEMPNAME.Name = "colEMPNAME";
            this.colEMPNAME.Visible = true;
            this.colEMPNAME.VisibleIndex = 0;
            // 
            // colGehawork
            // 
            this.colGehawork.AppearanceCell.Options.UseTextOptions = true;
            this.colGehawork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehawork.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehawork.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehawork.Caption = "جهة العميل";
            this.colGehawork.FieldName = "TBL_Emp.TBLGehawork.Gehawork";
            this.colGehawork.Name = "colGehawork";
            this.colGehawork.Visible = true;
            this.colGehawork.VisibleIndex = 1;
            // 
            // coldatefrom
            // 
            this.coldatefrom.AppearanceCell.Options.UseTextOptions = true;
            this.coldatefrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatefrom.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatefrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatefrom.Caption = "من تاريخ";
            this.coldatefrom.FieldName = "datefrom";
            this.coldatefrom.Name = "coldatefrom";
            this.coldatefrom.Visible = true;
            this.coldatefrom.VisibleIndex = 2;
            // 
            // coldateto
            // 
            this.coldateto.AppearanceCell.Options.UseTextOptions = true;
            this.coldateto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateto.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateto.Caption = "الي تاريخ";
            this.coldateto.FieldName = "dateto";
            this.coldateto.Name = "coldateto";
            this.coldateto.Visible = true;
            this.coldateto.VisibleIndex = 3;
            // 
            // colmobile1
            // 
            this.colmobile1.AppearanceCell.Options.UseTextOptions = true;
            this.colmobile1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmobile1.AppearanceHeader.Options.UseTextOptions = true;
            this.colmobile1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmobile1.Caption = "موبيل 1";
            this.colmobile1.FieldName = "mobile1";
            this.colmobile1.Name = "colmobile1";
            this.colmobile1.Visible = true;
            this.colmobile1.VisibleIndex = 4;
            // 
            // colmobile12
            // 
            this.colmobile12.AppearanceCell.Options.UseTextOptions = true;
            this.colmobile12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmobile12.AppearanceHeader.Options.UseTextOptions = true;
            this.colmobile12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmobile12.Caption = "موبيل 2";
            this.colmobile12.FieldName = "mobile12";
            this.colmobile12.Name = "colmobile12";
            this.colmobile12.Visible = true;
            this.colmobile12.VisibleIndex = 5;
            // 
            // coltelwork
            // 
            this.coltelwork.AppearanceCell.Options.UseTextOptions = true;
            this.coltelwork.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltelwork.AppearanceHeader.Options.UseTextOptions = true;
            this.coltelwork.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltelwork.Caption = "تليفون العمل";
            this.coltelwork.FieldName = "telwork";
            this.coltelwork.Name = "coltelwork";
            this.coltelwork.Visible = true;
            this.coltelwork.VisibleIndex = 6;
            // 
            // coltelhome
            // 
            this.coltelhome.AppearanceCell.Options.UseTextOptions = true;
            this.coltelhome.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltelhome.AppearanceHeader.Options.UseTextOptions = true;
            this.coltelhome.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltelhome.Caption = "تليفون المنزل";
            this.coltelhome.FieldName = "telhome";
            this.coltelhome.Name = "coltelhome";
            this.coltelhome.Visible = true;
            this.coltelhome.VisibleIndex = 7;
            // 
            // colemail
            // 
            this.colemail.AppearanceCell.Options.UseTextOptions = true;
            this.colemail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colemail.AppearanceHeader.Options.UseTextOptions = true;
            this.colemail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colemail.Caption = "البريد";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 8;
            // 
            // coladdress
            // 
            this.coladdress.AppearanceCell.Options.UseTextOptions = true;
            this.coladdress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coladdress.AppearanceHeader.Options.UseTextOptions = true;
            this.coladdress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coladdress.Caption = "العنوان";
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 9;
            // 
            // colremarks
            // 
            this.colremarks.AppearanceCell.Options.UseTextOptions = true;
            this.colremarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colremarks.AppearanceHeader.Options.UseTextOptions = true;
            this.colremarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colremarks.Caption = "ملاحظات";
            this.colremarks.FieldName = "remarks";
            this.colremarks.Name = "colremarks";
            this.colremarks.Visible = true;
            this.colremarks.VisibleIndex = 10;
            // 
            // colEdit
            // 
            this.colEdit.AppearanceCell.Options.UseTextOptions = true;
            this.colEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdit.Caption = "تعديل";
            this.colEdit.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 11;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // colDelete
            // 
            this.colDelete.AppearanceCell.Options.UseTextOptions = true;
            this.colDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDelete.Caption = "حذف";
            this.colDelete.ColumnEdit = this.repositoryItemButtonEditDelete;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 12;
            // 
            // repositoryItemButtonEditDelete
            // 
            this.repositoryItemButtonEditDelete.AutoHeight = false;
            this.repositoryItemButtonEditDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDelete.Name = "repositoryItemButtonEditDelete";
            this.repositoryItemButtonEditDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDelete_ButtonClick);
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLManagersTableAdapter
            // 
            this.tBLManagersTableAdapter.ClearBeforeFill = true;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PaintStyleName = "Skin";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // TBLManagersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 362);
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TBLManagersFrm";
            this.Text = "بيانات المديرين";
            this.Load += new System.EventHandler(this.TBLManagersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMin;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private Datasource.dsData dsData;
        private Datasource.dsDataTableAdapters.TBLManagersTableAdapter tBLManagersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coldatefrom;
        private DevExpress.XtraGrid.Columns.GridColumn coldateto;
        private DevExpress.XtraGrid.Columns.GridColumn colmobile1;
        private DevExpress.XtraGrid.Columns.GridColumn colmobile12;
        private DevExpress.XtraGrid.Columns.GridColumn coltelwork;
        private DevExpress.XtraGrid.Columns.GridColumn coltelhome;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colremarks;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGehawork;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDelete;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    }
}