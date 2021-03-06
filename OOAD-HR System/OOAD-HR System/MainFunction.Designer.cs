﻿namespace OOAD_HR_System
{
    partial class _mainFunction
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
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionDataSet = new OOAD_HR_System.positionDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptDataSet = new OOAD_HR_System.deptDataSet();
            this.bonusdefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusDefDataSet = new OOAD_HR_System.bonusDefDataSet();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusDataSet = new OOAD_HR_System.bonusDataSet();
            this.authorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authoDataSet = new OOAD_HR_System.authoDataSet();
            this._logoutButton = new System.Windows.Forms.Button();
            this.departmentTableAdapter = new OOAD_HR_System.deptDataSetTableAdapters.departmentTableAdapter();
            this.positionTableAdapter = new OOAD_HR_System.positionDataSetTableAdapters.positionTableAdapter();
            this.authorizationTableAdapter = new OOAD_HR_System.authoDataSetTableAdapters.authorizationTableAdapter();
            this.bonusdefTableAdapter = new OOAD_HR_System.bonusDefDataSetTableAdapters.bonusdefTableAdapter();
            this.bonusTableAdapter = new OOAD_HR_System.bonusDataSetTableAdapters.bonusTableAdapter();
            this._department = new System.Windows.Forms.TabPage();
            this._departmentPage = new System.Windows.Forms.TabControl();
            this._newDepartment = new System.Windows.Forms.TabPage();
            this._insertDeptButton = new System.Windows.Forms.Button();
            this._newDeptTimeDP = new System.Windows.Forms.DateTimePicker();
            this._newDeptManTB = new System.Windows.Forms.TextBox();
            this._newDeptNameTB = new System.Windows.Forms.TextBox();
            this._newDeptIDTB = new System.Windows.Forms.TextBox();
            this._newDeptManLB = new System.Windows.Forms.Label();
            this._newDeptStartTimeLB = new System.Windows.Forms.Label();
            this._newDeptNameLB = new System.Windows.Forms.Label();
            this._newDeptIDLB = new System.Windows.Forms.Label();
            this._editDepartment = new System.Windows.Forms.TabPage();
            this._editDeptEndTimeDefDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptButton = new System.Windows.Forms.Button();
            this._searchDeptButton = new System.Windows.Forms.Button();
            this._editDeptCheckCB = new System.Windows.Forms.ComboBox();
            this._editDeptEndTimeDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptStartTimeDP = new System.Windows.Forms.DateTimePicker();
            this._editDeptManTB = new System.Windows.Forms.TextBox();
            this._editDeptNameTB = new System.Windows.Forms.TextBox();
            this._editDeptIDTB = new System.Windows.Forms.TextBox();
            this._editDeptManLB = new System.Windows.Forms.Label();
            this._editDeptEndTimeLB = new System.Windows.Forms.Label();
            this._editDeptCheckLB = new System.Windows.Forms.Label();
            this._editDeptStartTimeLB = new System.Windows.Forms.Label();
            this._editDeptNameLB = new System.Windows.Forms.Label();
            this._editDeptIDLB = new System.Windows.Forms.Label();
            this._position = new System.Windows.Forms.TabPage();
            this._positionPage = new System.Windows.Forms.TabControl();
            this._addPosition = new System.Windows.Forms.TabPage();
            this._addPositionButton = new System.Windows.Forms.Button();
            this._addPositionIDTB = new System.Windows.Forms.TextBox();
            this._addPositionNameTB = new System.Windows.Forms.TextBox();
            this._addPositionBSTB = new System.Windows.Forms.TextBox();
            this._addPositionAuthoCB = new System.Windows.Forms.ComboBox();
            this._addPositionAuthoLB = new System.Windows.Forms.Label();
            this._addPositionBSLB = new System.Windows.Forms.Label();
            this._addPositionNameLB = new System.Windows.Forms.Label();
            this._addPositionIDLB = new System.Windows.Forms.Label();
            this._editPosition = new System.Windows.Forms.TabPage();
            this._editPositionButton = new System.Windows.Forms.Button();
            this._searchPositionButton = new System.Windows.Forms.Button();
            this._editPositionIDTB = new System.Windows.Forms.TextBox();
            this._editPositionNameTB = new System.Windows.Forms.TextBox();
            this._editPositionBSTB = new System.Windows.Forms.TextBox();
            this._editPositionAuthoCB = new System.Windows.Forms.ComboBox();
            this._editPositionAuthoLB = new System.Windows.Forms.Label();
            this._editPositionBSLB = new System.Windows.Forms.Label();
            this._editPositionNameLB = new System.Windows.Forms.Label();
            this._editPositionIDLB = new System.Windows.Forms.Label();
            this._authorization = new System.Windows.Forms.TabPage();
            this._authorizationPage = new System.Windows.Forms.TabControl();
            this._newAuthorization = new System.Windows.Forms.TabPage();
            this._insertAuthoButton = new System.Windows.Forms.Button();
            this._newAuthoLevelCB = new System.Windows.Forms.ComboBox();
            this._newAuthoNameTB = new System.Windows.Forms.TextBox();
            this._newAuthoIDTB = new System.Windows.Forms.TextBox();
            this._newAuthoLevelLB = new System.Windows.Forms.Label();
            this._newAuthoNameLB = new System.Windows.Forms.Label();
            this._newAuthoIDLB = new System.Windows.Forms.Label();
            this._editAuthorization = new System.Windows.Forms.TabPage();
            this._editAuthoButton = new System.Windows.Forms.Button();
            this._searchAuthoButton = new System.Windows.Forms.Button();
            this._editAuthoLevelCB = new System.Windows.Forms.ComboBox();
            this._editAuthoNameTB = new System.Windows.Forms.TextBox();
            this._editAuthoIDTB = new System.Windows.Forms.TextBox();
            this._editAuthoLevelLB = new System.Windows.Forms.Label();
            this._editAuthoNameLB = new System.Windows.Forms.Label();
            this._editAuthoIDLB = new System.Windows.Forms.Label();
            this._salary = new System.Windows.Forms.TabPage();
            this._salaryPage = new System.Windows.Forms.TabControl();
            this._addpayMethod = new System.Windows.Forms.TabPage();
            this._addPaywayButton = new System.Windows.Forms.Button();
            this._addPaywayMethodCB = new System.Windows.Forms.ComboBox();
            this._addPaywayAccountTB = new System.Windows.Forms.TextBox();
            this._addPaywayEmplIDTB = new System.Windows.Forms.TextBox();
            this._addpaywayAccountLB = new System.Windows.Forms.Label();
            this._addPaywayMethodLB = new System.Windows.Forms.Label();
            this._addPaywayEmplIDLB = new System.Windows.Forms.Label();
            this._editPayMethod = new System.Windows.Forms.TabPage();
            this._paywayEditButton = new System.Windows.Forms.Button();
            this._paywaySearchButton = new System.Windows.Forms.Button();
            this._editPaywayMethodCB = new System.Windows.Forms.ComboBox();
            this._editPaywayAccountTB = new System.Windows.Forms.TextBox();
            this._editPaywayEmplIDTB = new System.Windows.Forms.TextBox();
            this._editPaywayAccountLB = new System.Windows.Forms.Label();
            this._editPaywayMethodLB = new System.Windows.Forms.Label();
            this._editPaywayEmplIDLB = new System.Windows.Forms.Label();
            this._bonus = new System.Windows.Forms.TabPage();
            this._bonusPage = new System.Windows.Forms.TabControl();
            this._addBonusDef = new System.Windows.Forms.TabPage();
            this._addBonusDefButton = new System.Windows.Forms.Button();
            this._addBonusDefAmountTB = new System.Windows.Forms.TextBox();
            this._addBonusDefAmountLB = new System.Windows.Forms.Label();
            this._addBonusDefEffiDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDefEffiDateLB = new System.Windows.Forms.Label();
            this._addBonusDefCreateDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDefCreateDateLB = new System.Windows.Forms.Label();
            this._addBonusDefDescTB = new System.Windows.Forms.TextBox();
            this._addBonusDefDescLB = new System.Windows.Forms.Label();
            this._addBonusNameTB = new System.Windows.Forms.TextBox();
            this._addBonusDefNameLB = new System.Windows.Forms.Label();
            this._addBonusDefIDTB = new System.Windows.Forms.TextBox();
            this._addBonusDefIDLB = new System.Windows.Forms.Label();
            this._editBonusDef = new System.Windows.Forms.TabPage();
            this._editBonusDefButton = new System.Windows.Forms.Button();
            this._searchBonusDefButton = new System.Windows.Forms.Button();
            this._editBonusDefAmountTB = new System.Windows.Forms.TextBox();
            this._editBonusDefAmountLB = new System.Windows.Forms.Label();
            this._editBonusDefEffiDateDTP = new System.Windows.Forms.DateTimePicker();
            this._editBonusDefEffiDateLB = new System.Windows.Forms.Label();
            this._editBonusDefCreateDateDTP = new System.Windows.Forms.DateTimePicker();
            this._editBonusDefCreateDateLB = new System.Windows.Forms.Label();
            this._editBonusDefDescTB = new System.Windows.Forms.TextBox();
            this._editBonusDefDescLB = new System.Windows.Forms.Label();
            this._editBonusDefNameTB = new System.Windows.Forms.TextBox();
            this._editBonusDefNameLB = new System.Windows.Forms.Label();
            this._editBonusDefIDTB = new System.Windows.Forms.TextBox();
            this._editBonusDefIDLB = new System.Windows.Forms.Label();
            this._addBonusTLB = new System.Windows.Forms.TabPage();
            this._addbonusPeriodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._addBonusButton = new System.Windows.Forms.Button();
            this._addBonusDateDTP = new System.Windows.Forms.DateTimePicker();
            this._addBonusDateLB = new System.Windows.Forms.Label();
            this._addBonusEmplIDTB = new System.Windows.Forms.TextBox();
            this._addBonusEmplID = new System.Windows.Forms.Label();
            this._addBonusCB = new System.Windows.Forms.ComboBox();
            this._addBonusNameLB = new System.Windows.Forms.Label();
            this._emplBonusSearch = new System.Windows.Forms.TabPage();
            this._bonusEmplIDSearchToolStrip = new System.Windows.Forms.ToolStrip();
            this._emplIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emplIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this._fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._bonusDataGridView = new System.Windows.Forms.DataGridView();
            this.bonusDefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._workAttendance = new System.Windows.Forms.TabPage();
            this._workAttendancePage = new System.Windows.Forms.TabControl();
            this._addWorkAttendance = new System.Windows.Forms.TabPage();
            this._addWAButton = new System.Windows.Forms.Button();
            this._addWAEndOTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAEndOverTimeLB = new System.Windows.Forms.Label();
            this._addWAStartOTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAStartOverTimeLB = new System.Windows.Forms.Label();
            this._addWAIsOvertimeCB = new System.Windows.Forms.ComboBox();
            this._addWAIsOvertime = new System.Windows.Forms.Label();
            this._addWAEndWTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAEndWTLB = new System.Windows.Forms.Label();
            this._addWAStartWTDTP = new System.Windows.Forms.DateTimePicker();
            this._addWAStartWTLB = new System.Windows.Forms.Label();
            this._addWAWorkStatusCB = new System.Windows.Forms.ComboBox();
            this._addWAStatusLB = new System.Windows.Forms.Label();
            this._addWADateDTP = new System.Windows.Forms.DateTimePicker();
            this._addWADate = new System.Windows.Forms.Label();
            this._addWAEmplIDTB = new System.Windows.Forms.TextBox();
            this._addWAEmplIDLB = new System.Windows.Forms.Label();
            this._editWorkAttendance = new System.Windows.Forms.TabPage();
            this._editWAButton = new System.Windows.Forms.Button();
            this._searchWAButton = new System.Windows.Forms.Button();
            this._editWAEndOTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAEndOTLB = new System.Windows.Forms.Label();
            this._editWAStartOTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAStartOTLB = new System.Windows.Forms.Label();
            this._editWAIsOvertimeCB = new System.Windows.Forms.ComboBox();
            this._editWAIsOvertimeLB = new System.Windows.Forms.Label();
            this._editWAEndWTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAEndWTLB = new System.Windows.Forms.Label();
            this._editWAStartWTDTP = new System.Windows.Forms.DateTimePicker();
            this._editWAStartWTLB = new System.Windows.Forms.Label();
            this._editWAStatusCB = new System.Windows.Forms.ComboBox();
            this._editWAWorkStatusLB = new System.Windows.Forms.Label();
            this._editWADateDTP = new System.Windows.Forms.DateTimePicker();
            this._editWADateLB = new System.Windows.Forms.Label();
            this._editWAEmplIDTB = new System.Windows.Forms.TextBox();
            this._editWAEmplIDLB = new System.Windows.Forms.Label();
            this._employee = new System.Windows.Forms.TabPage();
            this._employeePage = new System.Windows.Forms.TabControl();
            this._newEmployee = new System.Windows.Forms.TabPage();
            this._addEmplLoginPWTB = new System.Windows.Forms.TextBox();
            this._addEmplLoginPWLB = new System.Windows.Forms.Label();
            this._newEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._newEmplSexCB = new System.Windows.Forms.ComboBox();
            this._insertEmplButton = new System.Windows.Forms.Button();
            this._newEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._newEmplBloodLB = new System.Windows.Forms.Label();
            this._newEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._newEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._newEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._newEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._newEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._newEmplAddrTB = new System.Windows.Forms.TextBox();
            this._newEmplPhoneTB = new System.Windows.Forms.TextBox();
            this._newEmpllSsnTB = new System.Windows.Forms.TextBox();
            this._newEmplBirthDP = new System.Windows.Forms.DateTimePicker();
            this._newEmplNameTB = new System.Windows.Forms.TextBox();
            this._newEmplIDTB = new System.Windows.Forms.TextBox();
            this._newEmplPositionIDLB = new System.Windows.Forms.Label();
            this._newEmplDeptIDLB = new System.Windows.Forms.Label();
            this._newEmplBasicSalaryLB = new System.Windows.Forms.Label();
            this._newEmplBirthLB = new System.Windows.Forms.Label();
            this._newEmplSpouseLB = new System.Windows.Forms.Label();
            this._newEmplMarriedStatLB = new System.Windows.Forms.Label();
            this._newEmplJobStatLB = new System.Windows.Forms.Label();
            this._newEmplMilitaryLB = new System.Windows.Forms.Label();
            this._newEmplEmerPhoneLB = new System.Windows.Forms.Label();
            this._newEmplEmerPersonLB = new System.Windows.Forms.Label();
            this._newEmplAddrLB = new System.Windows.Forms.Label();
            this._newEmplPhoneLB = new System.Windows.Forms.Label();
            this._newEmplSexLB = new System.Windows.Forms.Label();
            this._newEmplSsnLB = new System.Windows.Forms.Label();
            this._newEmplNameLB = new System.Windows.Forms.Label();
            this._newEmplIDLB = new System.Windows.Forms.Label();
            this._editEmployee = new System.Windows.Forms.TabPage();
            this._searchEmplButtom = new System.Windows.Forms.Button();
            this._editEmplPositionCB = new System.Windows.Forms.ComboBox();
            this._editEmplSexCB = new System.Windows.Forms.ComboBox();
            this._editEmplButton = new System.Windows.Forms.Button();
            this._editEmplBloodCB = new System.Windows.Forms.ComboBox();
            this._editEmplBloodLB = new System.Windows.Forms.Label();
            this._editEmplDeptCB = new System.Windows.Forms.ComboBox();
            this._editEmplBasicSalaryTB = new System.Windows.Forms.TextBox();
            this._editEmplJobStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplSpouseTB = new System.Windows.Forms.TextBox();
            this._editEmplMarriedStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplMilitaryStatCB = new System.Windows.Forms.ComboBox();
            this._editEmplEmerPhoneTB = new System.Windows.Forms.TextBox();
            this._editEmplEmerPersonTB = new System.Windows.Forms.TextBox();
            this._editEmplAddrTB = new System.Windows.Forms.TextBox();
            this._editEmplPhoneTB = new System.Windows.Forms.TextBox();
            this._editEmplSsnTB = new System.Windows.Forms.TextBox();
            this._editEmplBirthDTP = new System.Windows.Forms.DateTimePicker();
            this._editEmplNameTB = new System.Windows.Forms.TextBox();
            this._editEmplIDTB = new System.Windows.Forms.TextBox();
            this._editEmplPositionLB = new System.Windows.Forms.Label();
            this._editEmplDeptLB = new System.Windows.Forms.Label();
            this._editEmplBasicSalaryLB = new System.Windows.Forms.Label();
            this._editEmplBirthLB = new System.Windows.Forms.Label();
            this._editEmplSpouseLB = new System.Windows.Forms.Label();
            this._editMarriedStatLB = new System.Windows.Forms.Label();
            this._editEmplJobStatLB = new System.Windows.Forms.Label();
            this._editEmplMilitaryStatLB = new System.Windows.Forms.Label();
            this._editEmplEmerPhone = new System.Windows.Forms.Label();
            this._editEmplEmerPersonLB = new System.Windows.Forms.Label();
            this._editEmplAddrLB = new System.Windows.Forms.Label();
            this._editEmplPhoneLB = new System.Windows.Forms.Label();
            this._editEmplSexLB = new System.Windows.Forms.Label();
            this._editEmplSsnLB = new System.Windows.Forms.Label();
            this._editEmplNameLB = new System.Windows.Forms.Label();
            this.editEmplIDLB = new System.Windows.Forms.Label();
            this._mainFunctionPage = new System.Windows.Forms.TabControl();
            this._produceSalary = new System.Windows.Forms.TabPage();
            this._prodeceSalaryStartDateLB = new System.Windows.Forms.Label();
            this._produceSalaryStartDateDTP = new System.Windows.Forms.DateTimePicker();
            this._produceSalaryEndDateLB = new System.Windows.Forms.Label();
            this._produceSalaryEndDateDTP = new System.Windows.Forms.DateTimePicker();
            this._produceSalaryPeriod = new System.Windows.Forms.Label();
            this._produceSalaryPeriodTB = new System.Windows.Forms.TextBox();
            this._produceSalaryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusdefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDefDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoDataSet)).BeginInit();
            this._department.SuspendLayout();
            this._departmentPage.SuspendLayout();
            this._newDepartment.SuspendLayout();
            this._editDepartment.SuspendLayout();
            this._position.SuspendLayout();
            this._positionPage.SuspendLayout();
            this._addPosition.SuspendLayout();
            this._editPosition.SuspendLayout();
            this._authorization.SuspendLayout();
            this._authorizationPage.SuspendLayout();
            this._newAuthorization.SuspendLayout();
            this._editAuthorization.SuspendLayout();
            this._salary.SuspendLayout();
            this._salaryPage.SuspendLayout();
            this._addpayMethod.SuspendLayout();
            this._editPayMethod.SuspendLayout();
            this._bonus.SuspendLayout();
            this._bonusPage.SuspendLayout();
            this._addBonusDef.SuspendLayout();
            this._editBonusDef.SuspendLayout();
            this._addBonusTLB.SuspendLayout();
            this._emplBonusSearch.SuspendLayout();
            this._bonusEmplIDSearchToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bonusDataGridView)).BeginInit();
            this._workAttendance.SuspendLayout();
            this._workAttendancePage.SuspendLayout();
            this._addWorkAttendance.SuspendLayout();
            this._editWorkAttendance.SuspendLayout();
            this._employee.SuspendLayout();
            this._employeePage.SuspendLayout();
            this._newEmployee.SuspendLayout();
            this._editEmployee.SuspendLayout();
            this._mainFunctionPage.SuspendLayout();
            this._produceSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.positionDataSet;
            // 
            // positionDataSet
            // 
            this.positionDataSet.DataSetName = "positionDataSet";
            this.positionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.deptDataSet;
            // 
            // deptDataSet
            // 
            this.deptDataSet.DataSetName = "deptDataSet";
            this.deptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bonusdefBindingSource
            // 
            this.bonusdefBindingSource.DataMember = "bonusdef";
            this.bonusdefBindingSource.DataSource = this.bonusDefDataSet;
            // 
            // bonusDefDataSet
            // 
            this.bonusDefDataSet.DataSetName = "bonusDefDataSet";
            this.bonusDefDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataMember = "bonus";
            this.bonusBindingSource.DataSource = this.bonusDataSet;
            // 
            // bonusDataSet
            // 
            this.bonusDataSet.DataSetName = "bonusDataSet";
            this.bonusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorizationBindingSource
            // 
            this.authorizationBindingSource.DataMember = "authorization";
            this.authorizationBindingSource.DataSource = this.authoDataSet;
            // 
            // authoDataSet
            // 
            this.authoDataSet.DataSetName = "authoDataSet";
            this.authoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _logoutButton
            // 
            this._logoutButton.Location = new System.Drawing.Point(1318, 14);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(75, 28);
            this._logoutButton.TabIndex = 1;
            this._logoutButton.Text = "Logout";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Click += new System.EventHandler(this.ClickLogoutButton);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // authorizationTableAdapter
            // 
            this.authorizationTableAdapter.ClearBeforeFill = true;
            // 
            // bonusdefTableAdapter
            // 
            this.bonusdefTableAdapter.ClearBeforeFill = true;
            // 
            // bonusTableAdapter
            // 
            this.bonusTableAdapter.ClearBeforeFill = true;
            // 
            // _department
            // 
            this._department.Controls.Add(this._departmentPage);
            this._department.Location = new System.Drawing.Point(4, 34);
            this._department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._department.Name = "_department";
            this._department.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._department.Size = new System.Drawing.Size(1584, 872);
            this._department.TabIndex = 10;
            this._department.Text = "Department";
            this._department.UseVisualStyleBackColor = true;
            // 
            // _departmentPage
            // 
            this._departmentPage.Controls.Add(this._newDepartment);
            this._departmentPage.Controls.Add(this._editDepartment);
            this._departmentPage.Location = new System.Drawing.Point(6, 10);
            this._departmentPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._departmentPage.Name = "_departmentPage";
            this._departmentPage.SelectedIndex = 0;
            this._departmentPage.Size = new System.Drawing.Size(1342, 684);
            this._departmentPage.TabIndex = 0;
            // 
            // _newDepartment
            // 
            this._newDepartment.Controls.Add(this._insertDeptButton);
            this._newDepartment.Controls.Add(this._newDeptTimeDP);
            this._newDepartment.Controls.Add(this._newDeptManTB);
            this._newDepartment.Controls.Add(this._newDeptNameTB);
            this._newDepartment.Controls.Add(this._newDeptIDTB);
            this._newDepartment.Controls.Add(this._newDeptManLB);
            this._newDepartment.Controls.Add(this._newDeptStartTimeLB);
            this._newDepartment.Controls.Add(this._newDeptNameLB);
            this._newDepartment.Controls.Add(this._newDeptIDLB);
            this._newDepartment.Location = new System.Drawing.Point(4, 34);
            this._newDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDepartment.Name = "_newDepartment";
            this._newDepartment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDepartment.Size = new System.Drawing.Size(1334, 646);
            this._newDepartment.TabIndex = 0;
            this._newDepartment.Text = "Add";
            this._newDepartment.UseVisualStyleBackColor = true;
            // 
            // _insertDeptButton
            // 
            this._insertDeptButton.Location = new System.Drawing.Point(708, 483);
            this._insertDeptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._insertDeptButton.Name = "_insertDeptButton";
            this._insertDeptButton.Size = new System.Drawing.Size(118, 46);
            this._insertDeptButton.TabIndex = 8;
            this._insertDeptButton.Text = "Add";
            this._insertDeptButton.UseVisualStyleBackColor = true;
            this._insertDeptButton.Click += new System.EventHandler(this.ClickAddDeptButton);
            // 
            // _newDeptTimeDP
            // 
            this._newDeptTimeDP.Location = new System.Drawing.Point(284, 296);
            this._newDeptTimeDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDeptTimeDP.Name = "_newDeptTimeDP";
            this._newDeptTimeDP.Size = new System.Drawing.Size(298, 36);
            this._newDeptTimeDP.TabIndex = 7;
            // 
            // _newDeptManTB
            // 
            this._newDeptManTB.Location = new System.Drawing.Point(285, 399);
            this._newDeptManTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDeptManTB.Name = "_newDeptManTB";
            this._newDeptManTB.Size = new System.Drawing.Size(296, 36);
            this._newDeptManTB.TabIndex = 6;
            // 
            // _newDeptNameTB
            // 
            this._newDeptNameTB.Location = new System.Drawing.Point(256, 159);
            this._newDeptNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDeptNameTB.Name = "_newDeptNameTB";
            this._newDeptNameTB.Size = new System.Drawing.Size(328, 36);
            this._newDeptNameTB.TabIndex = 5;
            // 
            // _newDeptIDTB
            // 
            this._newDeptIDTB.Location = new System.Drawing.Point(226, 74);
            this._newDeptIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._newDeptIDTB.Name = "_newDeptIDTB";
            this._newDeptIDTB.Size = new System.Drawing.Size(358, 36);
            this._newDeptIDTB.TabIndex = 4;
            // 
            // _newDeptManLB
            // 
            this._newDeptManLB.AutoSize = true;
            this._newDeptManLB.Location = new System.Drawing.Point(60, 404);
            this._newDeptManLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newDeptManLB.Name = "_newDeptManLB";
            this._newDeptManLB.Size = new System.Drawing.Size(208, 24);
            this._newDeptManLB.TabIndex = 3;
            this._newDeptManLB.Text = "Department Manager:";
            // 
            // _newDeptStartTimeLB
            // 
            this._newDeptStartTimeLB.AutoSize = true;
            this._newDeptStartTimeLB.Location = new System.Drawing.Point(60, 254);
            this._newDeptStartTimeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newDeptStartTimeLB.Name = "_newDeptStartTimeLB";
            this._newDeptStartTimeLB.Size = new System.Drawing.Size(277, 24);
            this._newDeptStartTimeLB.TabIndex = 2;
            this._newDeptStartTimeLB.Text = "Start Date of the Department:";
            // 
            // _newDeptNameLB
            // 
            this._newDeptNameLB.AutoSize = true;
            this._newDeptNameLB.Location = new System.Drawing.Point(60, 164);
            this._newDeptNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newDeptNameLB.Name = "_newDeptNameLB";
            this._newDeptNameLB.Size = new System.Drawing.Size(182, 24);
            this._newDeptNameLB.TabIndex = 1;
            this._newDeptNameLB.Text = "Department Name:";
            // 
            // _newDeptIDLB
            // 
            this._newDeptIDLB.AutoSize = true;
            this._newDeptIDLB.Location = new System.Drawing.Point(60, 78);
            this._newDeptIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._newDeptIDLB.Name = "_newDeptIDLB";
            this._newDeptIDLB.Size = new System.Drawing.Size(152, 24);
            this._newDeptIDLB.TabIndex = 0;
            this._newDeptIDLB.Text = "Department ID:";
            // 
            // _editDepartment
            // 
            this._editDepartment.Controls.Add(this._editDeptEndTimeDefDP);
            this._editDepartment.Controls.Add(this._editDeptButton);
            this._editDepartment.Controls.Add(this._searchDeptButton);
            this._editDepartment.Controls.Add(this._editDeptCheckCB);
            this._editDepartment.Controls.Add(this._editDeptEndTimeDP);
            this._editDepartment.Controls.Add(this._editDeptStartTimeDP);
            this._editDepartment.Controls.Add(this._editDeptManTB);
            this._editDepartment.Controls.Add(this._editDeptNameTB);
            this._editDepartment.Controls.Add(this._editDeptIDTB);
            this._editDepartment.Controls.Add(this._editDeptManLB);
            this._editDepartment.Controls.Add(this._editDeptEndTimeLB);
            this._editDepartment.Controls.Add(this._editDeptCheckLB);
            this._editDepartment.Controls.Add(this._editDeptStartTimeLB);
            this._editDepartment.Controls.Add(this._editDeptNameLB);
            this._editDepartment.Controls.Add(this._editDeptIDLB);
            this._editDepartment.Location = new System.Drawing.Point(4, 34);
            this._editDepartment.Name = "_editDepartment";
            this._editDepartment.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._editDepartment.Size = new System.Drawing.Size(1334, 646);
            this._editDepartment.TabIndex = 1;
            this._editDepartment.Text = "Edit";
            this._editDepartment.UseVisualStyleBackColor = true;
            // 
            // _editDeptEndTimeDefDP
            // 
            this._editDeptEndTimeDefDP.Enabled = false;
            this._editDeptEndTimeDefDP.Location = new System.Drawing.Point(560, 426);
            this._editDeptEndTimeDefDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editDeptEndTimeDefDP.Name = "_editDeptEndTimeDefDP";
            this._editDeptEndTimeDefDP.Size = new System.Drawing.Size(298, 36);
            this._editDeptEndTimeDefDP.TabIndex = 14;
            this._editDeptEndTimeDefDP.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this._editDeptEndTimeDefDP.Visible = false;
            // 
            // _editDeptButton
            // 
            this._editDeptButton.Location = new System.Drawing.Point(850, 544);
            this._editDeptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editDeptButton.Name = "_editDeptButton";
            this._editDeptButton.Size = new System.Drawing.Size(123, 48);
            this._editDeptButton.TabIndex = 12;
            this._editDeptButton.Text = "Edit";
            this._editDeptButton.UseVisualStyleBackColor = true;
            this._editDeptButton.Click += new System.EventHandler(this.ClickEditDeptButton);
            // 
            // _searchDeptButton
            // 
            this._searchDeptButton.Location = new System.Drawing.Point(694, 546);
            this._searchDeptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchDeptButton.Name = "_searchDeptButton";
            this._searchDeptButton.Size = new System.Drawing.Size(123, 46);
            this._searchDeptButton.TabIndex = 1;
            this._searchDeptButton.Text = "Search";
            this._searchDeptButton.UseVisualStyleBackColor = true;
            this._searchDeptButton.Click += new System.EventHandler(this.ClickSearchDeptButton);
            // 
            // _editDeptCheckCB
            // 
            this._editDeptCheckCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editDeptCheckCB.FormattingEnabled = true;
            this._editDeptCheckCB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this._editDeptCheckCB.Location = new System.Drawing.Point(266, 318);
            this._editDeptCheckCB.Name = "_editDeptCheckCB";
            this._editDeptCheckCB.Size = new System.Drawing.Size(121, 32);
            this._editDeptCheckCB.TabIndex = 11;
            this._editDeptCheckCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditDeptCheckCBSelectedIndex);
            // 
            // _editDeptEndTimeDP
            // 
            this._editDeptEndTimeDP.Enabled = false;
            this._editDeptEndTimeDP.Location = new System.Drawing.Point(292, 426);
            this._editDeptEndTimeDP.Name = "_editDeptEndTimeDP";
            this._editDeptEndTimeDP.Size = new System.Drawing.Size(236, 36);
            this._editDeptEndTimeDP.TabIndex = 10;
            // 
            // _editDeptStartTimeDP
            // 
            this._editDeptStartTimeDP.Location = new System.Drawing.Point(292, 246);
            this._editDeptStartTimeDP.Name = "_editDeptStartTimeDP";
            this._editDeptStartTimeDP.Size = new System.Drawing.Size(236, 36);
            this._editDeptStartTimeDP.TabIndex = 9;
            // 
            // _editDeptManTB
            // 
            this._editDeptManTB.Location = new System.Drawing.Point(334, 500);
            this._editDeptManTB.Name = "_editDeptManTB";
            this._editDeptManTB.Size = new System.Drawing.Size(194, 36);
            this._editDeptManTB.TabIndex = 8;
            // 
            // _editDeptNameTB
            // 
            this._editDeptNameTB.Location = new System.Drawing.Point(308, 132);
            this._editDeptNameTB.Name = "_editDeptNameTB";
            this._editDeptNameTB.Size = new System.Drawing.Size(222, 36);
            this._editDeptNameTB.TabIndex = 7;
            // 
            // _editDeptIDTB
            // 
            this._editDeptIDTB.Location = new System.Drawing.Point(276, 51);
            this._editDeptIDTB.Name = "_editDeptIDTB";
            this._editDeptIDTB.Size = new System.Drawing.Size(253, 36);
            this._editDeptIDTB.TabIndex = 6;
            // 
            // _editDeptManLB
            // 
            this._editDeptManLB.AutoSize = true;
            this._editDeptManLB.Location = new System.Drawing.Point(112, 504);
            this._editDeptManLB.Name = "_editDeptManLB";
            this._editDeptManLB.Size = new System.Drawing.Size(208, 24);
            this._editDeptManLB.TabIndex = 5;
            this._editDeptManLB.Text = "Department Manager:";
            // 
            // _editDeptEndTimeLB
            // 
            this._editDeptEndTimeLB.AutoSize = true;
            this._editDeptEndTimeLB.Location = new System.Drawing.Point(112, 399);
            this._editDeptEndTimeLB.Name = "_editDeptEndTimeLB";
            this._editDeptEndTimeLB.Size = new System.Drawing.Size(317, 24);
            this._editDeptEndTimeLB.TabIndex = 4;
            this._editDeptEndTimeLB.Text = "Terminate date of the department:";
            // 
            // _editDeptCheckLB
            // 
            this._editDeptCheckLB.AutoSize = true;
            this._editDeptCheckLB.Location = new System.Drawing.Point(112, 322);
            this._editDeptCheckLB.Name = "_editDeptCheckLB";
            this._editDeptCheckLB.Size = new System.Drawing.Size(147, 24);
            this._editDeptCheckLB.TabIndex = 3;
            this._editDeptCheckLB.Text = "Still operating?";
            // 
            // _editDeptStartTimeLB
            // 
            this._editDeptStartTimeLB.AutoSize = true;
            this._editDeptStartTimeLB.Location = new System.Drawing.Point(112, 219);
            this._editDeptStartTimeLB.Name = "_editDeptStartTimeLB";
            this._editDeptStartTimeLB.Size = new System.Drawing.Size(267, 24);
            this._editDeptStartTimeLB.TabIndex = 2;
            this._editDeptStartTimeLB.Text = "Start date of the department:";
            // 
            // _editDeptNameLB
            // 
            this._editDeptNameLB.AutoSize = true;
            this._editDeptNameLB.Location = new System.Drawing.Point(112, 136);
            this._editDeptNameLB.Name = "_editDeptNameLB";
            this._editDeptNameLB.Size = new System.Drawing.Size(182, 24);
            this._editDeptNameLB.TabIndex = 1;
            this._editDeptNameLB.Text = "Department Name:";
            // 
            // _editDeptIDLB
            // 
            this._editDeptIDLB.AutoSize = true;
            this._editDeptIDLB.Location = new System.Drawing.Point(112, 68);
            this._editDeptIDLB.Name = "_editDeptIDLB";
            this._editDeptIDLB.Size = new System.Drawing.Size(152, 24);
            this._editDeptIDLB.TabIndex = 0;
            this._editDeptIDLB.Text = "Department ID:";
            // 
            // _position
            // 
            this._position.Controls.Add(this._positionPage);
            this._position.Location = new System.Drawing.Point(4, 34);
            this._position.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._position.Name = "_position";
            this._position.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._position.Size = new System.Drawing.Size(1584, 872);
            this._position.TabIndex = 9;
            this._position.Text = "Position";
            this._position.UseVisualStyleBackColor = true;
            // 
            // _positionPage
            // 
            this._positionPage.Controls.Add(this._addPosition);
            this._positionPage.Controls.Add(this._editPosition);
            this._positionPage.Location = new System.Drawing.Point(4, 9);
            this._positionPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._positionPage.Name = "_positionPage";
            this._positionPage.SelectedIndex = 0;
            this._positionPage.Size = new System.Drawing.Size(2328, 1290);
            this._positionPage.TabIndex = 0;
            // 
            // _addPosition
            // 
            this._addPosition.Controls.Add(this._addPositionButton);
            this._addPosition.Controls.Add(this._addPositionIDTB);
            this._addPosition.Controls.Add(this._addPositionNameTB);
            this._addPosition.Controls.Add(this._addPositionBSTB);
            this._addPosition.Controls.Add(this._addPositionAuthoCB);
            this._addPosition.Controls.Add(this._addPositionAuthoLB);
            this._addPosition.Controls.Add(this._addPositionBSLB);
            this._addPosition.Controls.Add(this._addPositionNameLB);
            this._addPosition.Controls.Add(this._addPositionIDLB);
            this._addPosition.Location = new System.Drawing.Point(4, 34);
            this._addPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPosition.Name = "_addPosition";
            this._addPosition.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPosition.Size = new System.Drawing.Size(2320, 1252);
            this._addPosition.TabIndex = 0;
            this._addPosition.Text = "Add";
            this._addPosition.UseVisualStyleBackColor = true;
            // 
            // _addPositionButton
            // 
            this._addPositionButton.Location = new System.Drawing.Point(753, 693);
            this._addPositionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPositionButton.Name = "_addPositionButton";
            this._addPositionButton.Size = new System.Drawing.Size(170, 68);
            this._addPositionButton.TabIndex = 8;
            this._addPositionButton.Text = "Add";
            this._addPositionButton.UseVisualStyleBackColor = true;
            this._addPositionButton.Click += new System.EventHandler(this.ClickAddPositionButton);
            // 
            // _addPositionIDTB
            // 
            this._addPositionIDTB.Location = new System.Drawing.Point(268, 66);
            this._addPositionIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPositionIDTB.Name = "_addPositionIDTB";
            this._addPositionIDTB.Size = new System.Drawing.Size(415, 36);
            this._addPositionIDTB.TabIndex = 7;
            // 
            // _addPositionNameTB
            // 
            this._addPositionNameTB.Location = new System.Drawing.Point(314, 198);
            this._addPositionNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPositionNameTB.Name = "_addPositionNameTB";
            this._addPositionNameTB.Size = new System.Drawing.Size(370, 36);
            this._addPositionNameTB.TabIndex = 6;
            // 
            // _addPositionBSTB
            // 
            this._addPositionBSTB.Location = new System.Drawing.Point(405, 348);
            this._addPositionBSTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPositionBSTB.Name = "_addPositionBSTB";
            this._addPositionBSTB.Size = new System.Drawing.Size(278, 36);
            this._addPositionBSTB.TabIndex = 5;
            this._addPositionBSTB.Text = "0";
            // 
            // _addPositionAuthoCB
            // 
            this._addPositionAuthoCB.DataSource = this.authorizationBindingSource;
            this._addPositionAuthoCB.DisplayMember = "authoName";
            this._addPositionAuthoCB.FormattingEnabled = true;
            this._addPositionAuthoCB.Location = new System.Drawing.Point(417, 477);
            this._addPositionAuthoCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPositionAuthoCB.Name = "_addPositionAuthoCB";
            this._addPositionAuthoCB.Size = new System.Drawing.Size(266, 32);
            this._addPositionAuthoCB.TabIndex = 4;
            this._addPositionAuthoCB.ValueMember = "authoID";
            // 
            // _addPositionAuthoLB
            // 
            this._addPositionAuthoLB.AutoSize = true;
            this._addPositionAuthoLB.Location = new System.Drawing.Point(81, 489);
            this._addPositionAuthoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPositionAuthoLB.Name = "_addPositionAuthoLB";
            this._addPositionAuthoLB.Size = new System.Drawing.Size(218, 24);
            this._addPositionAuthoLB.TabIndex = 3;
            this._addPositionAuthoLB.Text = "Position Authorization:";
            // 
            // _addPositionBSLB
            // 
            this._addPositionBSLB.AutoSize = true;
            this._addPositionBSLB.Location = new System.Drawing.Point(81, 357);
            this._addPositionBSLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPositionBSLB.Name = "_addPositionBSLB";
            this._addPositionBSLB.Size = new System.Drawing.Size(209, 24);
            this._addPositionBSLB.TabIndex = 2;
            this._addPositionBSLB.Text = "Position Basic Salary:";
            // 
            // _addPositionNameLB
            // 
            this._addPositionNameLB.AutoSize = true;
            this._addPositionNameLB.Location = new System.Drawing.Point(81, 216);
            this._addPositionNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPositionNameLB.Name = "_addPositionNameLB";
            this._addPositionNameLB.Size = new System.Drawing.Size(149, 24);
            this._addPositionNameLB.TabIndex = 1;
            this._addPositionNameLB.Text = "Position Name:";
            // 
            // _addPositionIDLB
            // 
            this._addPositionIDLB.AutoSize = true;
            this._addPositionIDLB.Location = new System.Drawing.Point(81, 84);
            this._addPositionIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPositionIDLB.Name = "_addPositionIDLB";
            this._addPositionIDLB.Size = new System.Drawing.Size(119, 24);
            this._addPositionIDLB.TabIndex = 0;
            this._addPositionIDLB.Text = "Position ID:";
            // 
            // _editPosition
            // 
            this._editPosition.Controls.Add(this._editPositionButton);
            this._editPosition.Controls.Add(this._searchPositionButton);
            this._editPosition.Controls.Add(this._editPositionIDTB);
            this._editPosition.Controls.Add(this._editPositionNameTB);
            this._editPosition.Controls.Add(this._editPositionBSTB);
            this._editPosition.Controls.Add(this._editPositionAuthoCB);
            this._editPosition.Controls.Add(this._editPositionAuthoLB);
            this._editPosition.Controls.Add(this._editPositionBSLB);
            this._editPosition.Controls.Add(this._editPositionNameLB);
            this._editPosition.Controls.Add(this._editPositionIDLB);
            this._editPosition.Location = new System.Drawing.Point(4, 34);
            this._editPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPosition.Name = "_editPosition";
            this._editPosition.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPosition.Size = new System.Drawing.Size(2320, 1252);
            this._editPosition.TabIndex = 1;
            this._editPosition.Text = "Edit";
            this._editPosition.UseVisualStyleBackColor = true;
            // 
            // _editPositionButton
            // 
            this._editPositionButton.Enabled = false;
            this._editPositionButton.Location = new System.Drawing.Point(1014, 714);
            this._editPositionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPositionButton.Name = "_editPositionButton";
            this._editPositionButton.Size = new System.Drawing.Size(170, 68);
            this._editPositionButton.TabIndex = 18;
            this._editPositionButton.Text = "Edit";
            this._editPositionButton.UseVisualStyleBackColor = true;
            this._editPositionButton.Click += new System.EventHandler(this.ClickEditPositionButton);
            // 
            // _searchPositionButton
            // 
            this._searchPositionButton.Location = new System.Drawing.Point(753, 714);
            this._searchPositionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchPositionButton.Name = "_searchPositionButton";
            this._searchPositionButton.Size = new System.Drawing.Size(170, 68);
            this._searchPositionButton.TabIndex = 17;
            this._searchPositionButton.Text = "Search";
            this._searchPositionButton.UseVisualStyleBackColor = true;
            this._searchPositionButton.Click += new System.EventHandler(this.ClickSearchPositionButtom);
            // 
            // _editPositionIDTB
            // 
            this._editPositionIDTB.Location = new System.Drawing.Point(268, 87);
            this._editPositionIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPositionIDTB.Name = "_editPositionIDTB";
            this._editPositionIDTB.Size = new System.Drawing.Size(415, 36);
            this._editPositionIDTB.TabIndex = 16;
            // 
            // _editPositionNameTB
            // 
            this._editPositionNameTB.Location = new System.Drawing.Point(314, 219);
            this._editPositionNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPositionNameTB.Name = "_editPositionNameTB";
            this._editPositionNameTB.ReadOnly = true;
            this._editPositionNameTB.Size = new System.Drawing.Size(370, 36);
            this._editPositionNameTB.TabIndex = 15;
            // 
            // _editPositionBSTB
            // 
            this._editPositionBSTB.Location = new System.Drawing.Point(405, 369);
            this._editPositionBSTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPositionBSTB.Name = "_editPositionBSTB";
            this._editPositionBSTB.ReadOnly = true;
            this._editPositionBSTB.Size = new System.Drawing.Size(278, 36);
            this._editPositionBSTB.TabIndex = 14;
            // 
            // _editPositionAuthoCB
            // 
            this._editPositionAuthoCB.DataSource = this.authorizationBindingSource;
            this._editPositionAuthoCB.DisplayMember = "authoName";
            this._editPositionAuthoCB.Enabled = false;
            this._editPositionAuthoCB.FormattingEnabled = true;
            this._editPositionAuthoCB.Location = new System.Drawing.Point(417, 498);
            this._editPositionAuthoCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPositionAuthoCB.Name = "_editPositionAuthoCB";
            this._editPositionAuthoCB.Size = new System.Drawing.Size(266, 32);
            this._editPositionAuthoCB.TabIndex = 13;
            this._editPositionAuthoCB.ValueMember = "authoID";
            // 
            // _editPositionAuthoLB
            // 
            this._editPositionAuthoLB.AutoSize = true;
            this._editPositionAuthoLB.Location = new System.Drawing.Point(81, 510);
            this._editPositionAuthoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPositionAuthoLB.Name = "_editPositionAuthoLB";
            this._editPositionAuthoLB.Size = new System.Drawing.Size(218, 24);
            this._editPositionAuthoLB.TabIndex = 12;
            this._editPositionAuthoLB.Text = "Position Authorization:";
            // 
            // _editPositionBSLB
            // 
            this._editPositionBSLB.AutoSize = true;
            this._editPositionBSLB.Location = new System.Drawing.Point(81, 378);
            this._editPositionBSLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPositionBSLB.Name = "_editPositionBSLB";
            this._editPositionBSLB.Size = new System.Drawing.Size(209, 24);
            this._editPositionBSLB.TabIndex = 11;
            this._editPositionBSLB.Text = "Position Basic Salary:";
            // 
            // _editPositionNameLB
            // 
            this._editPositionNameLB.AutoSize = true;
            this._editPositionNameLB.Location = new System.Drawing.Point(81, 237);
            this._editPositionNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPositionNameLB.Name = "_editPositionNameLB";
            this._editPositionNameLB.Size = new System.Drawing.Size(149, 24);
            this._editPositionNameLB.TabIndex = 10;
            this._editPositionNameLB.Text = "Position Name:";
            // 
            // _editPositionIDLB
            // 
            this._editPositionIDLB.AutoSize = true;
            this._editPositionIDLB.Location = new System.Drawing.Point(81, 105);
            this._editPositionIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPositionIDLB.Name = "_editPositionIDLB";
            this._editPositionIDLB.Size = new System.Drawing.Size(119, 24);
            this._editPositionIDLB.TabIndex = 9;
            this._editPositionIDLB.Text = "Position ID:";
            // 
            // _authorization
            // 
            this._authorization.Controls.Add(this._authorizationPage);
            this._authorization.Location = new System.Drawing.Point(4, 34);
            this._authorization.Name = "_authorization";
            this._authorization.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._authorization.Size = new System.Drawing.Size(1584, 872);
            this._authorization.TabIndex = 8;
            this._authorization.Text = "Authorization";
            this._authorization.UseVisualStyleBackColor = true;
            // 
            // _authorizationPage
            // 
            this._authorizationPage.Controls.Add(this._newAuthorization);
            this._authorizationPage.Controls.Add(this._editAuthorization);
            this._authorizationPage.Location = new System.Drawing.Point(6, 8);
            this._authorizationPage.Name = "_authorizationPage";
            this._authorizationPage.SelectedIndex = 0;
            this._authorizationPage.Size = new System.Drawing.Size(1546, 860);
            this._authorizationPage.TabIndex = 0;
            // 
            // _newAuthorization
            // 
            this._newAuthorization.Controls.Add(this._insertAuthoButton);
            this._newAuthorization.Controls.Add(this._newAuthoLevelCB);
            this._newAuthorization.Controls.Add(this._newAuthoNameTB);
            this._newAuthorization.Controls.Add(this._newAuthoIDTB);
            this._newAuthorization.Controls.Add(this._newAuthoLevelLB);
            this._newAuthorization.Controls.Add(this._newAuthoNameLB);
            this._newAuthorization.Controls.Add(this._newAuthoIDLB);
            this._newAuthorization.Location = new System.Drawing.Point(4, 34);
            this._newAuthorization.Name = "_newAuthorization";
            this._newAuthorization.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._newAuthorization.Size = new System.Drawing.Size(1538, 822);
            this._newAuthorization.TabIndex = 0;
            this._newAuthorization.Text = "Add";
            this._newAuthorization.UseVisualStyleBackColor = true;
            // 
            // _insertAuthoButton
            // 
            this._insertAuthoButton.Location = new System.Drawing.Point(548, 416);
            this._insertAuthoButton.Name = "_insertAuthoButton";
            this._insertAuthoButton.Size = new System.Drawing.Size(104, 45);
            this._insertAuthoButton.TabIndex = 6;
            this._insertAuthoButton.Text = "Add";
            this._insertAuthoButton.UseVisualStyleBackColor = true;
            this._insertAuthoButton.Click += new System.EventHandler(this.ClickAddAuthoButton);
            // 
            // _newAuthoLevelCB
            // 
            this._newAuthoLevelCB.FormattingEnabled = true;
            this._newAuthoLevelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this._newAuthoLevelCB.Location = new System.Drawing.Point(250, 243);
            this._newAuthoLevelCB.Name = "_newAuthoLevelCB";
            this._newAuthoLevelCB.Size = new System.Drawing.Size(134, 32);
            this._newAuthoLevelCB.TabIndex = 5;
            // 
            // _newAuthoNameTB
            // 
            this._newAuthoNameTB.Location = new System.Drawing.Point(255, 130);
            this._newAuthoNameTB.Name = "_newAuthoNameTB";
            this._newAuthoNameTB.Size = new System.Drawing.Size(270, 36);
            this._newAuthoNameTB.TabIndex = 4;
            // 
            // _newAuthoIDTB
            // 
            this._newAuthoIDTB.Location = new System.Drawing.Point(225, 28);
            this._newAuthoIDTB.Name = "_newAuthoIDTB";
            this._newAuthoIDTB.Size = new System.Drawing.Size(300, 36);
            this._newAuthoIDTB.TabIndex = 3;
            // 
            // _newAuthoLevelLB
            // 
            this._newAuthoLevelLB.AutoSize = true;
            this._newAuthoLevelLB.Location = new System.Drawing.Point(50, 250);
            this._newAuthoLevelLB.Name = "_newAuthoLevelLB";
            this._newAuthoLevelLB.Size = new System.Drawing.Size(196, 24);
            this._newAuthoLevelLB.TabIndex = 2;
            this._newAuthoLevelLB.Text = "Authorization Level:";
            // 
            // _newAuthoNameLB
            // 
            this._newAuthoNameLB.AutoSize = true;
            this._newAuthoNameLB.Location = new System.Drawing.Point(50, 142);
            this._newAuthoNameLB.Name = "_newAuthoNameLB";
            this._newAuthoNameLB.Size = new System.Drawing.Size(199, 24);
            this._newAuthoNameLB.TabIndex = 1;
            this._newAuthoNameLB.Text = "Authorization Name:";
            // 
            // _newAuthoIDLB
            // 
            this._newAuthoIDLB.AutoSize = true;
            this._newAuthoIDLB.Location = new System.Drawing.Point(50, 40);
            this._newAuthoIDLB.Name = "_newAuthoIDLB";
            this._newAuthoIDLB.Size = new System.Drawing.Size(169, 24);
            this._newAuthoIDLB.TabIndex = 0;
            this._newAuthoIDLB.Text = "Authorization ID:";
            // 
            // _editAuthorization
            // 
            this._editAuthorization.Controls.Add(this._editAuthoButton);
            this._editAuthorization.Controls.Add(this._searchAuthoButton);
            this._editAuthorization.Controls.Add(this._editAuthoLevelCB);
            this._editAuthorization.Controls.Add(this._editAuthoNameTB);
            this._editAuthorization.Controls.Add(this._editAuthoIDTB);
            this._editAuthorization.Controls.Add(this._editAuthoLevelLB);
            this._editAuthorization.Controls.Add(this._editAuthoNameLB);
            this._editAuthorization.Controls.Add(this._editAuthoIDLB);
            this._editAuthorization.Location = new System.Drawing.Point(4, 34);
            this._editAuthorization.Name = "_editAuthorization";
            this._editAuthorization.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._editAuthorization.Size = new System.Drawing.Size(1538, 822);
            this._editAuthorization.TabIndex = 1;
            this._editAuthorization.Text = "Edit";
            this._editAuthorization.UseVisualStyleBackColor = true;
            // 
            // _editAuthoButton
            // 
            this._editAuthoButton.Location = new System.Drawing.Point(742, 454);
            this._editAuthoButton.Name = "_editAuthoButton";
            this._editAuthoButton.Size = new System.Drawing.Size(118, 56);
            this._editAuthoButton.TabIndex = 13;
            this._editAuthoButton.Text = "Edit";
            this._editAuthoButton.UseVisualStyleBackColor = true;
            this._editAuthoButton.Click += new System.EventHandler(this.ClickEditAuthoButtom);
            // 
            // _searchAuthoButton
            // 
            this._searchAuthoButton.Location = new System.Drawing.Point(566, 454);
            this._searchAuthoButton.Name = "_searchAuthoButton";
            this._searchAuthoButton.Size = new System.Drawing.Size(111, 56);
            this._searchAuthoButton.TabIndex = 12;
            this._searchAuthoButton.Text = "Search";
            this._searchAuthoButton.UseVisualStyleBackColor = true;
            this._searchAuthoButton.Click += new System.EventHandler(this.ClickSearchAuthoButtom);
            // 
            // _editAuthoLevelCB
            // 
            this._editAuthoLevelCB.FormattingEnabled = true;
            this._editAuthoLevelCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this._editAuthoLevelCB.Location = new System.Drawing.Point(262, 261);
            this._editAuthoLevelCB.Name = "_editAuthoLevelCB";
            this._editAuthoLevelCB.Size = new System.Drawing.Size(134, 32);
            this._editAuthoLevelCB.TabIndex = 11;
            // 
            // _editAuthoNameTB
            // 
            this._editAuthoNameTB.Location = new System.Drawing.Point(267, 148);
            this._editAuthoNameTB.Name = "_editAuthoNameTB";
            this._editAuthoNameTB.Size = new System.Drawing.Size(270, 36);
            this._editAuthoNameTB.TabIndex = 10;
            // 
            // _editAuthoIDTB
            // 
            this._editAuthoIDTB.Location = new System.Drawing.Point(237, 46);
            this._editAuthoIDTB.Name = "_editAuthoIDTB";
            this._editAuthoIDTB.Size = new System.Drawing.Size(300, 36);
            this._editAuthoIDTB.TabIndex = 9;
            // 
            // _editAuthoLevelLB
            // 
            this._editAuthoLevelLB.AutoSize = true;
            this._editAuthoLevelLB.Location = new System.Drawing.Point(62, 268);
            this._editAuthoLevelLB.Name = "_editAuthoLevelLB";
            this._editAuthoLevelLB.Size = new System.Drawing.Size(196, 24);
            this._editAuthoLevelLB.TabIndex = 8;
            this._editAuthoLevelLB.Text = "Authorization Level:";
            // 
            // _editAuthoNameLB
            // 
            this._editAuthoNameLB.AutoSize = true;
            this._editAuthoNameLB.Location = new System.Drawing.Point(62, 160);
            this._editAuthoNameLB.Name = "_editAuthoNameLB";
            this._editAuthoNameLB.Size = new System.Drawing.Size(199, 24);
            this._editAuthoNameLB.TabIndex = 7;
            this._editAuthoNameLB.Text = "Authorization Name:";
            // 
            // _editAuthoIDLB
            // 
            this._editAuthoIDLB.AutoSize = true;
            this._editAuthoIDLB.Location = new System.Drawing.Point(62, 58);
            this._editAuthoIDLB.Name = "_editAuthoIDLB";
            this._editAuthoIDLB.Size = new System.Drawing.Size(169, 24);
            this._editAuthoIDLB.TabIndex = 6;
            this._editAuthoIDLB.Text = "Authorization ID:";
            // 
            // _salary
            // 
            this._salary.Controls.Add(this._salaryPage);
            this._salary.Location = new System.Drawing.Point(4, 34);
            this._salary.Name = "_salary";
            this._salary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._salary.Size = new System.Drawing.Size(1584, 872);
            this._salary.TabIndex = 4;
            this._salary.Text = "Salary";
            this._salary.UseVisualStyleBackColor = true;
            // 
            // _salaryPage
            // 
            this._salaryPage.Controls.Add(this._addpayMethod);
            this._salaryPage.Controls.Add(this._editPayMethod);
            this._salaryPage.Controls.Add(this._produceSalary);
            this._salaryPage.Location = new System.Drawing.Point(8, 4);
            this._salaryPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._salaryPage.Name = "_salaryPage";
            this._salaryPage.SelectedIndex = 0;
            this._salaryPage.Size = new System.Drawing.Size(1572, 867);
            this._salaryPage.TabIndex = 0;
            // 
            // _addpayMethod
            // 
            this._addpayMethod.Controls.Add(this._addPaywayButton);
            this._addpayMethod.Controls.Add(this._addPaywayMethodCB);
            this._addpayMethod.Controls.Add(this._addPaywayAccountTB);
            this._addpayMethod.Controls.Add(this._addPaywayEmplIDTB);
            this._addpayMethod.Controls.Add(this._addpaywayAccountLB);
            this._addpayMethod.Controls.Add(this._addPaywayMethodLB);
            this._addpayMethod.Controls.Add(this._addPaywayEmplIDLB);
            this._addpayMethod.Location = new System.Drawing.Point(4, 34);
            this._addpayMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addpayMethod.Name = "_addpayMethod";
            this._addpayMethod.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addpayMethod.Size = new System.Drawing.Size(1564, 829);
            this._addpayMethod.TabIndex = 1;
            this._addpayMethod.Text = "Add Payment Method";
            this._addpayMethod.UseVisualStyleBackColor = true;
            // 
            // _addPaywayButton
            // 
            this._addPaywayButton.Location = new System.Drawing.Point(597, 441);
            this._addPaywayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPaywayButton.Name = "_addPaywayButton";
            this._addPaywayButton.Size = new System.Drawing.Size(162, 56);
            this._addPaywayButton.TabIndex = 6;
            this._addPaywayButton.Text = "Add";
            this._addPaywayButton.UseVisualStyleBackColor = true;
            this._addPaywayButton.Click += new System.EventHandler(this.ClickAddPaywayButton);
            // 
            // _addPaywayMethodCB
            // 
            this._addPaywayMethodCB.FormattingEnabled = true;
            this._addPaywayMethodCB.Items.AddRange(new object[] {
            "In Person",
            "Transfer"});
            this._addPaywayMethodCB.Location = new System.Drawing.Point(270, 165);
            this._addPaywayMethodCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPaywayMethodCB.Name = "_addPaywayMethodCB";
            this._addPaywayMethodCB.Size = new System.Drawing.Size(253, 32);
            this._addPaywayMethodCB.TabIndex = 5;
            this._addPaywayMethodCB.SelectedIndexChanged += new System.EventHandler(this.ChangedAddPaywayMethodCBSelectedIndex);
            // 
            // _addPaywayAccountTB
            // 
            this._addPaywayAccountTB.Location = new System.Drawing.Point(160, 309);
            this._addPaywayAccountTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPaywayAccountTB.Name = "_addPaywayAccountTB";
            this._addPaywayAccountTB.Size = new System.Drawing.Size(362, 36);
            this._addPaywayAccountTB.TabIndex = 4;
            // 
            // _addPaywayEmplIDTB
            // 
            this._addPaywayEmplIDTB.Location = new System.Drawing.Point(236, 75);
            this._addPaywayEmplIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._addPaywayEmplIDTB.Name = "_addPaywayEmplIDTB";
            this._addPaywayEmplIDTB.Size = new System.Drawing.Size(288, 36);
            this._addPaywayEmplIDTB.TabIndex = 3;
            // 
            // _addpaywayAccountLB
            // 
            this._addpaywayAccountLB.AutoSize = true;
            this._addpaywayAccountLB.Location = new System.Drawing.Point(88, 272);
            this._addpaywayAccountLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addpaywayAccountLB.Name = "_addpaywayAccountLB";
            this._addpaywayAccountLB.Size = new System.Drawing.Size(176, 24);
            this._addpaywayAccountLB.TabIndex = 2;
            this._addpaywayAccountLB.Text = "Payment Account:";
            // 
            // _addPaywayMethodLB
            // 
            this._addPaywayMethodLB.AutoSize = true;
            this._addPaywayMethodLB.Location = new System.Drawing.Point(88, 174);
            this._addPaywayMethodLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPaywayMethodLB.Name = "_addPaywayMethodLB";
            this._addPaywayMethodLB.Size = new System.Drawing.Size(170, 24);
            this._addPaywayMethodLB.TabIndex = 1;
            this._addPaywayMethodLB.Text = "Payment Method:";
            // 
            // _addPaywayEmplIDLB
            // 
            this._addPaywayEmplIDLB.AutoSize = true;
            this._addPaywayEmplIDLB.Location = new System.Drawing.Point(88, 84);
            this._addPaywayEmplIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._addPaywayEmplIDLB.Name = "_addPaywayEmplIDLB";
            this._addPaywayEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._addPaywayEmplIDLB.TabIndex = 0;
            this._addPaywayEmplIDLB.Text = "Employee ID:";
            // 
            // _editPayMethod
            // 
            this._editPayMethod.Controls.Add(this._paywayEditButton);
            this._editPayMethod.Controls.Add(this._paywaySearchButton);
            this._editPayMethod.Controls.Add(this._editPaywayMethodCB);
            this._editPayMethod.Controls.Add(this._editPaywayAccountTB);
            this._editPayMethod.Controls.Add(this._editPaywayEmplIDTB);
            this._editPayMethod.Controls.Add(this._editPaywayAccountLB);
            this._editPayMethod.Controls.Add(this._editPaywayMethodLB);
            this._editPayMethod.Controls.Add(this._editPaywayEmplIDLB);
            this._editPayMethod.Location = new System.Drawing.Point(4, 34);
            this._editPayMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPayMethod.Name = "_editPayMethod";
            this._editPayMethod.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPayMethod.Size = new System.Drawing.Size(1564, 829);
            this._editPayMethod.TabIndex = 2;
            this._editPayMethod.Text = "Edit Payment Method";
            this._editPayMethod.UseVisualStyleBackColor = true;
            // 
            // _paywayEditButton
            // 
            this._paywayEditButton.Location = new System.Drawing.Point(771, 471);
            this._paywayEditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._paywayEditButton.Name = "_paywayEditButton";
            this._paywayEditButton.Size = new System.Drawing.Size(156, 48);
            this._paywayEditButton.TabIndex = 31;
            this._paywayEditButton.Text = "Edit";
            this._paywayEditButton.UseVisualStyleBackColor = true;
            this._paywayEditButton.Click += new System.EventHandler(this.ClickPaywayEditButton);
            // 
            // _paywaySearchButton
            // 
            this._paywaySearchButton.Location = new System.Drawing.Point(570, 471);
            this._paywaySearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._paywaySearchButton.Name = "_paywaySearchButton";
            this._paywaySearchButton.Size = new System.Drawing.Size(156, 48);
            this._paywaySearchButton.TabIndex = 30;
            this._paywaySearchButton.Text = "Search";
            this._paywaySearchButton.UseVisualStyleBackColor = true;
            this._paywaySearchButton.Click += new System.EventHandler(this.ClickPaywaySearchButton);
            // 
            // _editPaywayMethodCB
            // 
            this._editPaywayMethodCB.FormattingEnabled = true;
            this._editPaywayMethodCB.Items.AddRange(new object[] {
            "In Person",
            "Transfer"});
            this._editPaywayMethodCB.Location = new System.Drawing.Point(273, 189);
            this._editPaywayMethodCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPaywayMethodCB.Name = "_editPaywayMethodCB";
            this._editPaywayMethodCB.Size = new System.Drawing.Size(247, 32);
            this._editPaywayMethodCB.TabIndex = 29;
            this._editPaywayMethodCB.SelectedIndexChanged += new System.EventHandler(this.ChangededitPaywayMethodCBSelectedIndex);
            // 
            // _editPaywayAccountTB
            // 
            this._editPaywayAccountTB.Location = new System.Drawing.Point(150, 351);
            this._editPaywayAccountTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPaywayAccountTB.Name = "_editPaywayAccountTB";
            this._editPaywayAccountTB.Size = new System.Drawing.Size(370, 36);
            this._editPaywayAccountTB.TabIndex = 28;
            // 
            // _editPaywayEmplIDTB
            // 
            this._editPaywayEmplIDTB.Location = new System.Drawing.Point(238, 72);
            this._editPaywayEmplIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editPaywayEmplIDTB.Name = "_editPaywayEmplIDTB";
            this._editPaywayEmplIDTB.Size = new System.Drawing.Size(282, 36);
            this._editPaywayEmplIDTB.TabIndex = 27;
            // 
            // _editPaywayAccountLB
            // 
            this._editPaywayAccountLB.AutoSize = true;
            this._editPaywayAccountLB.Location = new System.Drawing.Point(92, 306);
            this._editPaywayAccountLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPaywayAccountLB.Name = "_editPaywayAccountLB";
            this._editPaywayAccountLB.Size = new System.Drawing.Size(176, 24);
            this._editPaywayAccountLB.TabIndex = 26;
            this._editPaywayAccountLB.Text = "Payment Account:";
            // 
            // _editPaywayMethodLB
            // 
            this._editPaywayMethodLB.AutoSize = true;
            this._editPaywayMethodLB.Location = new System.Drawing.Point(92, 198);
            this._editPaywayMethodLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPaywayMethodLB.Name = "_editPaywayMethodLB";
            this._editPaywayMethodLB.Size = new System.Drawing.Size(170, 24);
            this._editPaywayMethodLB.TabIndex = 25;
            this._editPaywayMethodLB.Text = "Payment Method:";
            // 
            // _editPaywayEmplIDLB
            // 
            this._editPaywayEmplIDLB.AutoSize = true;
            this._editPaywayEmplIDLB.Location = new System.Drawing.Point(92, 81);
            this._editPaywayEmplIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editPaywayEmplIDLB.Name = "_editPaywayEmplIDLB";
            this._editPaywayEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._editPaywayEmplIDLB.TabIndex = 24;
            this._editPaywayEmplIDLB.Text = "Employee ID:";
            // 
            // _bonus
            // 
            this._bonus.Controls.Add(this._bonusPage);
            this._bonus.Location = new System.Drawing.Point(4, 34);
            this._bonus.Name = "_bonus";
            this._bonus.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._bonus.Size = new System.Drawing.Size(1584, 872);
            this._bonus.TabIndex = 3;
            this._bonus.Text = "Bonus";
            this._bonus.UseVisualStyleBackColor = true;
            // 
            // _bonusPage
            // 
            this._bonusPage.Controls.Add(this._addBonusDef);
            this._bonusPage.Controls.Add(this._editBonusDef);
            this._bonusPage.Controls.Add(this._addBonusTLB);
            this._bonusPage.Controls.Add(this._emplBonusSearch);
            this._bonusPage.Location = new System.Drawing.Point(4, 8);
            this._bonusPage.Name = "_bonusPage";
            this._bonusPage.SelectedIndex = 0;
            this._bonusPage.Size = new System.Drawing.Size(1550, 860);
            this._bonusPage.TabIndex = 0;
            // 
            // _addBonusDef
            // 
            this._addBonusDef.Controls.Add(this._addBonusDefButton);
            this._addBonusDef.Controls.Add(this._addBonusDefAmountTB);
            this._addBonusDef.Controls.Add(this._addBonusDefAmountLB);
            this._addBonusDef.Controls.Add(this._addBonusDefEffiDateDTP);
            this._addBonusDef.Controls.Add(this._addBonusDefEffiDateLB);
            this._addBonusDef.Controls.Add(this._addBonusDefCreateDateDTP);
            this._addBonusDef.Controls.Add(this._addBonusDefCreateDateLB);
            this._addBonusDef.Controls.Add(this._addBonusDefDescTB);
            this._addBonusDef.Controls.Add(this._addBonusDefDescLB);
            this._addBonusDef.Controls.Add(this._addBonusNameTB);
            this._addBonusDef.Controls.Add(this._addBonusDefNameLB);
            this._addBonusDef.Controls.Add(this._addBonusDefIDTB);
            this._addBonusDef.Controls.Add(this._addBonusDefIDLB);
            this._addBonusDef.Location = new System.Drawing.Point(4, 34);
            this._addBonusDef.Name = "_addBonusDef";
            this._addBonusDef.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._addBonusDef.Size = new System.Drawing.Size(1542, 822);
            this._addBonusDef.TabIndex = 0;
            this._addBonusDef.Text = "Add Definition";
            this._addBonusDef.UseVisualStyleBackColor = true;
            // 
            // _addBonusDefButton
            // 
            this._addBonusDefButton.Location = new System.Drawing.Point(876, 566);
            this._addBonusDefButton.Name = "_addBonusDefButton";
            this._addBonusDefButton.Size = new System.Drawing.Size(111, 36);
            this._addBonusDefButton.TabIndex = 12;
            this._addBonusDefButton.Text = "Add";
            this._addBonusDefButton.UseVisualStyleBackColor = true;
            this._addBonusDefButton.Click += new System.EventHandler(this.ClickAddBonusDefButton);
            // 
            // _addBonusDefAmountTB
            // 
            this._addBonusDefAmountTB.Location = new System.Drawing.Point(777, 228);
            this._addBonusDefAmountTB.Name = "_addBonusDefAmountTB";
            this._addBonusDefAmountTB.Size = new System.Drawing.Size(210, 36);
            this._addBonusDefAmountTB.TabIndex = 11;
            this._addBonusDefAmountTB.Text = "0";
            // 
            // _addBonusDefAmountLB
            // 
            this._addBonusDefAmountLB.AutoSize = true;
            this._addBonusDefAmountLB.Location = new System.Drawing.Point(618, 234);
            this._addBonusDefAmountLB.Name = "_addBonusDefAmountLB";
            this._addBonusDefAmountLB.Size = new System.Drawing.Size(152, 24);
            this._addBonusDefAmountLB.TabIndex = 10;
            this._addBonusDefAmountLB.Text = "Bonus Amount:";
            // 
            // _addBonusDefEffiDateDTP
            // 
            this._addBonusDefEffiDateDTP.Location = new System.Drawing.Point(788, 118);
            this._addBonusDefEffiDateDTP.Name = "_addBonusDefEffiDateDTP";
            this._addBonusDefEffiDateDTP.Size = new System.Drawing.Size(200, 36);
            this._addBonusDefEffiDateDTP.TabIndex = 9;
            // 
            // _addBonusDefEffiDateLB
            // 
            this._addBonusDefEffiDateLB.AutoSize = true;
            this._addBonusDefEffiDateLB.Location = new System.Drawing.Point(614, 130);
            this._addBonusDefEffiDateLB.Name = "_addBonusDefEffiDateLB";
            this._addBonusDefEffiDateLB.Size = new System.Drawing.Size(167, 24);
            this._addBonusDefEffiDateLB.TabIndex = 8;
            this._addBonusDefEffiDateLB.Text = "Efficacious Date:";
            // 
            // _addBonusDefCreateDateDTP
            // 
            this._addBonusDefCreateDateDTP.Location = new System.Drawing.Point(742, 26);
            this._addBonusDefCreateDateDTP.Name = "_addBonusDefCreateDateDTP";
            this._addBonusDefCreateDateDTP.Size = new System.Drawing.Size(200, 36);
            this._addBonusDefCreateDateDTP.TabIndex = 7;
            // 
            // _addBonusDefCreateDateLB
            // 
            this._addBonusDefCreateDateLB.AutoSize = true;
            this._addBonusDefCreateDateLB.Location = new System.Drawing.Point(614, 38);
            this._addBonusDefCreateDateLB.Name = "_addBonusDefCreateDateLB";
            this._addBonusDefCreateDateLB.Size = new System.Drawing.Size(123, 24);
            this._addBonusDefCreateDateLB.TabIndex = 6;
            this._addBonusDefCreateDateLB.Text = "Create Date:";
            // 
            // _addBonusDefDescTB
            // 
            this._addBonusDefDescTB.Location = new System.Drawing.Point(232, 226);
            this._addBonusDefDescTB.Multiline = true;
            this._addBonusDefDescTB.Name = "_addBonusDefDescTB";
            this._addBonusDefDescTB.Size = new System.Drawing.Size(282, 374);
            this._addBonusDefDescTB.TabIndex = 5;
            // 
            // _addBonusDefDescLB
            // 
            this._addBonusDefDescLB.AutoSize = true;
            this._addBonusDefDescLB.Location = new System.Drawing.Point(44, 230);
            this._addBonusDefDescLB.Name = "_addBonusDefDescLB";
            this._addBonusDefDescLB.Size = new System.Drawing.Size(183, 24);
            this._addBonusDefDescLB.TabIndex = 4;
            this._addBonusDefDescLB.Text = "Bonus Description:";
            // 
            // _addBonusNameTB
            // 
            this._addBonusNameTB.Location = new System.Drawing.Point(180, 124);
            this._addBonusNameTB.Name = "_addBonusNameTB";
            this._addBonusNameTB.Size = new System.Drawing.Size(334, 36);
            this._addBonusNameTB.TabIndex = 3;
            // 
            // _addBonusDefNameLB
            // 
            this._addBonusDefNameLB.AutoSize = true;
            this._addBonusDefNameLB.Location = new System.Drawing.Point(40, 130);
            this._addBonusDefNameLB.Name = "_addBonusDefNameLB";
            this._addBonusDefNameLB.Size = new System.Drawing.Size(133, 24);
            this._addBonusDefNameLB.TabIndex = 2;
            this._addBonusDefNameLB.Text = "Bonus Name:";
            // 
            // _addBonusDefIDTB
            // 
            this._addBonusDefIDTB.Location = new System.Drawing.Point(246, 26);
            this._addBonusDefIDTB.Name = "_addBonusDefIDTB";
            this._addBonusDefIDTB.Size = new System.Drawing.Size(268, 36);
            this._addBonusDefIDTB.TabIndex = 1;
            // 
            // _addBonusDefIDLB
            // 
            this._addBonusDefIDLB.AutoSize = true;
            this._addBonusDefIDLB.Location = new System.Drawing.Point(40, 38);
            this._addBonusDefIDLB.Name = "_addBonusDefIDLB";
            this._addBonusDefIDLB.Size = new System.Drawing.Size(200, 24);
            this._addBonusDefIDLB.TabIndex = 0;
            this._addBonusDefIDLB.Text = "Bonus Definition ID:";
            // 
            // _editBonusDef
            // 
            this._editBonusDef.Controls.Add(this._editBonusDefButton);
            this._editBonusDef.Controls.Add(this._searchBonusDefButton);
            this._editBonusDef.Controls.Add(this._editBonusDefAmountTB);
            this._editBonusDef.Controls.Add(this._editBonusDefAmountLB);
            this._editBonusDef.Controls.Add(this._editBonusDefEffiDateDTP);
            this._editBonusDef.Controls.Add(this._editBonusDefEffiDateLB);
            this._editBonusDef.Controls.Add(this._editBonusDefCreateDateDTP);
            this._editBonusDef.Controls.Add(this._editBonusDefCreateDateLB);
            this._editBonusDef.Controls.Add(this._editBonusDefDescTB);
            this._editBonusDef.Controls.Add(this._editBonusDefDescLB);
            this._editBonusDef.Controls.Add(this._editBonusDefNameTB);
            this._editBonusDef.Controls.Add(this._editBonusDefNameLB);
            this._editBonusDef.Controls.Add(this._editBonusDefIDTB);
            this._editBonusDef.Controls.Add(this._editBonusDefIDLB);
            this._editBonusDef.Location = new System.Drawing.Point(4, 34);
            this._editBonusDef.Name = "_editBonusDef";
            this._editBonusDef.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._editBonusDef.Size = new System.Drawing.Size(1542, 822);
            this._editBonusDef.TabIndex = 1;
            this._editBonusDef.Text = "Edit Definition";
            this._editBonusDef.UseVisualStyleBackColor = true;
            // 
            // _editBonusDefButton
            // 
            this._editBonusDefButton.Enabled = false;
            this._editBonusDefButton.Location = new System.Drawing.Point(1030, 588);
            this._editBonusDefButton.Name = "_editBonusDefButton";
            this._editBonusDefButton.Size = new System.Drawing.Size(111, 36);
            this._editBonusDefButton.TabIndex = 26;
            this._editBonusDefButton.Text = "Edit";
            this._editBonusDefButton.UseVisualStyleBackColor = true;
            this._editBonusDefButton.Click += new System.EventHandler(this.ClickEditBonusDefButton);
            // 
            // _searchBonusDefButton
            // 
            this._searchBonusDefButton.Location = new System.Drawing.Point(884, 588);
            this._searchBonusDefButton.Name = "_searchBonusDefButton";
            this._searchBonusDefButton.Size = new System.Drawing.Size(111, 36);
            this._searchBonusDefButton.TabIndex = 25;
            this._searchBonusDefButton.Text = "Search";
            this._searchBonusDefButton.UseVisualStyleBackColor = true;
            this._searchBonusDefButton.Click += new System.EventHandler(this.ClickSearchBonusDefButton);
            // 
            // _editBonusDefAmountTB
            // 
            this._editBonusDefAmountTB.Enabled = false;
            this._editBonusDefAmountTB.Location = new System.Drawing.Point(784, 250);
            this._editBonusDefAmountTB.Name = "_editBonusDefAmountTB";
            this._editBonusDefAmountTB.Size = new System.Drawing.Size(210, 36);
            this._editBonusDefAmountTB.TabIndex = 24;
            this._editBonusDefAmountTB.Text = "0";
            // 
            // _editBonusDefAmountLB
            // 
            this._editBonusDefAmountLB.AutoSize = true;
            this._editBonusDefAmountLB.Location = new System.Drawing.Point(626, 256);
            this._editBonusDefAmountLB.Name = "_editBonusDefAmountLB";
            this._editBonusDefAmountLB.Size = new System.Drawing.Size(152, 24);
            this._editBonusDefAmountLB.TabIndex = 23;
            this._editBonusDefAmountLB.Text = "Bonus Amount:";
            // 
            // _editBonusDefEffiDateDTP
            // 
            this._editBonusDefEffiDateDTP.Enabled = false;
            this._editBonusDefEffiDateDTP.Location = new System.Drawing.Point(795, 142);
            this._editBonusDefEffiDateDTP.Name = "_editBonusDefEffiDateDTP";
            this._editBonusDefEffiDateDTP.Size = new System.Drawing.Size(200, 36);
            this._editBonusDefEffiDateDTP.TabIndex = 22;
            // 
            // _editBonusDefEffiDateLB
            // 
            this._editBonusDefEffiDateLB.AutoSize = true;
            this._editBonusDefEffiDateLB.Location = new System.Drawing.Point(622, 154);
            this._editBonusDefEffiDateLB.Name = "_editBonusDefEffiDateLB";
            this._editBonusDefEffiDateLB.Size = new System.Drawing.Size(167, 24);
            this._editBonusDefEffiDateLB.TabIndex = 21;
            this._editBonusDefEffiDateLB.Text = "Efficacious Date:";
            // 
            // _editBonusDefCreateDateDTP
            // 
            this._editBonusDefCreateDateDTP.Enabled = false;
            this._editBonusDefCreateDateDTP.Location = new System.Drawing.Point(752, 48);
            this._editBonusDefCreateDateDTP.Name = "_editBonusDefCreateDateDTP";
            this._editBonusDefCreateDateDTP.Size = new System.Drawing.Size(200, 36);
            this._editBonusDefCreateDateDTP.TabIndex = 20;
            // 
            // _editBonusDefCreateDateLB
            // 
            this._editBonusDefCreateDateLB.AutoSize = true;
            this._editBonusDefCreateDateLB.Location = new System.Drawing.Point(622, 60);
            this._editBonusDefCreateDateLB.Name = "_editBonusDefCreateDateLB";
            this._editBonusDefCreateDateLB.Size = new System.Drawing.Size(123, 24);
            this._editBonusDefCreateDateLB.TabIndex = 19;
            this._editBonusDefCreateDateLB.Text = "Create Date:";
            // 
            // _editBonusDefDescTB
            // 
            this._editBonusDefDescTB.Enabled = false;
            this._editBonusDefDescTB.Location = new System.Drawing.Point(242, 249);
            this._editBonusDefDescTB.Multiline = true;
            this._editBonusDefDescTB.Name = "_editBonusDefDescTB";
            this._editBonusDefDescTB.Size = new System.Drawing.Size(282, 374);
            this._editBonusDefDescTB.TabIndex = 18;
            // 
            // _editBonusDefDescLB
            // 
            this._editBonusDefDescLB.AutoSize = true;
            this._editBonusDefDescLB.Location = new System.Drawing.Point(52, 252);
            this._editBonusDefDescLB.Name = "_editBonusDefDescLB";
            this._editBonusDefDescLB.Size = new System.Drawing.Size(183, 24);
            this._editBonusDefDescLB.TabIndex = 17;
            this._editBonusDefDescLB.Text = "Bonus Description:";
            // 
            // _editBonusDefNameTB
            // 
            this._editBonusDefNameTB.Enabled = false;
            this._editBonusDefNameTB.Location = new System.Drawing.Point(188, 148);
            this._editBonusDefNameTB.Name = "_editBonusDefNameTB";
            this._editBonusDefNameTB.Size = new System.Drawing.Size(334, 36);
            this._editBonusDefNameTB.TabIndex = 16;
            // 
            // _editBonusDefNameLB
            // 
            this._editBonusDefNameLB.AutoSize = true;
            this._editBonusDefNameLB.Location = new System.Drawing.Point(48, 154);
            this._editBonusDefNameLB.Name = "_editBonusDefNameLB";
            this._editBonusDefNameLB.Size = new System.Drawing.Size(133, 24);
            this._editBonusDefNameLB.TabIndex = 15;
            this._editBonusDefNameLB.Text = "Bonus Name:";
            // 
            // _editBonusDefIDTB
            // 
            this._editBonusDefIDTB.Location = new System.Drawing.Point(254, 48);
            this._editBonusDefIDTB.Name = "_editBonusDefIDTB";
            this._editBonusDefIDTB.Size = new System.Drawing.Size(268, 36);
            this._editBonusDefIDTB.TabIndex = 14;
            // 
            // _editBonusDefIDLB
            // 
            this._editBonusDefIDLB.AutoSize = true;
            this._editBonusDefIDLB.Location = new System.Drawing.Point(48, 60);
            this._editBonusDefIDLB.Name = "_editBonusDefIDLB";
            this._editBonusDefIDLB.Size = new System.Drawing.Size(200, 24);
            this._editBonusDefIDLB.TabIndex = 13;
            this._editBonusDefIDLB.Text = "Bonus Definition ID:";
            // 
            // _addBonusTLB
            // 
            this._addBonusTLB.Controls.Add(this._addbonusPeriodTB);
            this._addBonusTLB.Controls.Add(this.label1);
            this._addBonusTLB.Controls.Add(this._addBonusButton);
            this._addBonusTLB.Controls.Add(this._addBonusDateDTP);
            this._addBonusTLB.Controls.Add(this._addBonusDateLB);
            this._addBonusTLB.Controls.Add(this._addBonusEmplIDTB);
            this._addBonusTLB.Controls.Add(this._addBonusEmplID);
            this._addBonusTLB.Controls.Add(this._addBonusCB);
            this._addBonusTLB.Controls.Add(this._addBonusNameLB);
            this._addBonusTLB.Location = new System.Drawing.Point(4, 34);
            this._addBonusTLB.Name = "_addBonusTLB";
            this._addBonusTLB.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._addBonusTLB.Size = new System.Drawing.Size(1542, 822);
            this._addBonusTLB.TabIndex = 2;
            this._addBonusTLB.Text = "Add";
            this._addBonusTLB.UseVisualStyleBackColor = true;
            // 
            // _addbonusPeriodTB
            // 
            this._addbonusPeriodTB.AcceptsReturn = true;
            this._addbonusPeriodTB.Location = new System.Drawing.Point(154, 398);
            this._addbonusPeriodTB.Name = "_addbonusPeriodTB";
            this._addbonusPeriodTB.Size = new System.Drawing.Size(298, 36);
            this._addbonusPeriodTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Period:";
            // 
            // _addBonusButton
            // 
            this._addBonusButton.Location = new System.Drawing.Point(478, 519);
            this._addBonusButton.Name = "_addBonusButton";
            this._addBonusButton.Size = new System.Drawing.Size(94, 38);
            this._addBonusButton.TabIndex = 6;
            this._addBonusButton.Text = "Add";
            this._addBonusButton.UseVisualStyleBackColor = true;
            this._addBonusButton.Click += new System.EventHandler(this.ClickAddBonusbutton);
            // 
            // _addBonusDateDTP
            // 
            this._addBonusDateDTP.Location = new System.Drawing.Point(178, 273);
            this._addBonusDateDTP.Name = "_addBonusDateDTP";
            this._addBonusDateDTP.Size = new System.Drawing.Size(276, 36);
            this._addBonusDateDTP.TabIndex = 5;
            // 
            // _addBonusDateLB
            // 
            this._addBonusDateLB.AutoSize = true;
            this._addBonusDateLB.Location = new System.Drawing.Point(70, 285);
            this._addBonusDateLB.Name = "_addBonusDateLB";
            this._addBonusDateLB.Size = new System.Drawing.Size(102, 24);
            this._addBonusDateLB.TabIndex = 4;
            this._addBonusDateLB.Text = "Add Date:";
            // 
            // _addBonusEmplIDTB
            // 
            this._addBonusEmplIDTB.Location = new System.Drawing.Point(218, 154);
            this._addBonusEmplIDTB.Name = "_addBonusEmplIDTB";
            this._addBonusEmplIDTB.Size = new System.Drawing.Size(236, 36);
            this._addBonusEmplIDTB.TabIndex = 3;
            // 
            // _addBonusEmplID
            // 
            this._addBonusEmplID.AutoSize = true;
            this._addBonusEmplID.Location = new System.Drawing.Point(70, 166);
            this._addBonusEmplID.Name = "_addBonusEmplID";
            this._addBonusEmplID.Size = new System.Drawing.Size(137, 24);
            this._addBonusEmplID.TabIndex = 2;
            this._addBonusEmplID.Text = "Employee ID:";
            // 
            // _addBonusCB
            // 
            this._addBonusCB.DataSource = this.bonusdefBindingSource;
            this._addBonusCB.DisplayMember = "bonusName";
            this._addBonusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addBonusCB.FormattingEnabled = true;
            this._addBonusCB.Location = new System.Drawing.Point(210, 39);
            this._addBonusCB.Name = "_addBonusCB";
            this._addBonusCB.Size = new System.Drawing.Size(242, 32);
            this._addBonusCB.TabIndex = 1;
            this._addBonusCB.ValueMember = "bonusDefID";
            // 
            // _addBonusNameLB
            // 
            this._addBonusNameLB.AutoSize = true;
            this._addBonusNameLB.Location = new System.Drawing.Point(70, 50);
            this._addBonusNameLB.Name = "_addBonusNameLB";
            this._addBonusNameLB.Size = new System.Drawing.Size(133, 24);
            this._addBonusNameLB.TabIndex = 0;
            this._addBonusNameLB.Text = "Bonus Name:";
            // 
            // _emplBonusSearch
            // 
            this._emplBonusSearch.Controls.Add(this._bonusEmplIDSearchToolStrip);
            this._emplBonusSearch.Controls.Add(this._bonusDataGridView);
            this._emplBonusSearch.Location = new System.Drawing.Point(4, 34);
            this._emplBonusSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._emplBonusSearch.Name = "_emplBonusSearch";
            this._emplBonusSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._emplBonusSearch.Size = new System.Drawing.Size(1542, 822);
            this._emplBonusSearch.TabIndex = 3;
            this._emplBonusSearch.Text = "Show Employee Bonus";
            this._emplBonusSearch.UseVisualStyleBackColor = true;
            // 
            // _bonusEmplIDSearchToolStrip
            // 
            this._bonusEmplIDSearchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._bonusEmplIDSearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._emplIDToolStripLabel,
            this.emplIDToolStripTextBox,
            this._fillToolStripButton});
            this._bonusEmplIDSearchToolStrip.Location = new System.Drawing.Point(28, 38);
            this._bonusEmplIDSearchToolStrip.Name = "_bonusEmplIDSearchToolStrip";
            this._bonusEmplIDSearchToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this._bonusEmplIDSearchToolStrip.Size = new System.Drawing.Size(355, 31);
            this._bonusEmplIDSearchToolStrip.TabIndex = 2;
            // 
            // _emplIDToolStripLabel
            // 
            this._emplIDToolStripLabel.Name = "_emplIDToolStripLabel";
            this._emplIDToolStripLabel.Size = new System.Drawing.Size(121, 28);
            this._emplIDToolStripLabel.Text = "Employee ID:";
            // 
            // emplIDToolStripTextBox
            // 
            this.emplIDToolStripTextBox.Name = "emplIDToolStripTextBox";
            this.emplIDToolStripTextBox.Size = new System.Drawing.Size(148, 31);
            // 
            // _fillToolStripButton
            // 
            this._fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fillToolStripButton.Name = "_fillToolStripButton";
            this._fillToolStripButton.Size = new System.Drawing.Size(71, 28);
            this._fillToolStripButton.Text = "Search";
            this._fillToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // _bonusDataGridView
            // 
            this._bonusDataGridView.AllowUserToAddRows = false;
            this._bonusDataGridView.AllowUserToDeleteRows = false;
            this._bonusDataGridView.AutoGenerateColumns = false;
            this._bonusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._bonusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonusDefIDDataGridViewTextBoxColumn,
            this.emplIDDataGridViewTextBoxColumn,
            this.bonusDateDataGridViewTextBoxColumn,
            this.bonusTDataGridViewTextBoxColumn});
            this._bonusDataGridView.DataSource = this.bonusBindingSource;
            this._bonusDataGridView.Location = new System.Drawing.Point(28, 114);
            this._bonusDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._bonusDataGridView.Name = "_bonusDataGridView";
            this._bonusDataGridView.ReadOnly = true;
            this._bonusDataGridView.RowTemplate.Height = 24;
            this._bonusDataGridView.Size = new System.Drawing.Size(964, 656);
            this._bonusDataGridView.TabIndex = 0;
            // 
            // bonusDefIDDataGridViewTextBoxColumn
            // 
            this.bonusDefIDDataGridViewTextBoxColumn.DataPropertyName = "bonusDefID";
            this.bonusDefIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusDefIDDataGridViewTextBoxColumn.HeaderText = "獎金定義ID";
            this.bonusDefIDDataGridViewTextBoxColumn.Name = "bonusDefIDDataGridViewTextBoxColumn";
            this.bonusDefIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDefIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // emplIDDataGridViewTextBoxColumn
            // 
            this.emplIDDataGridViewTextBoxColumn.DataPropertyName = "emplID";
            this.emplIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.emplIDDataGridViewTextBoxColumn.HeaderText = "員工ID";
            this.emplIDDataGridViewTextBoxColumn.Name = "emplIDDataGridViewTextBoxColumn";
            this.emplIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.emplIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bonusDateDataGridViewTextBoxColumn
            // 
            this.bonusDateDataGridViewTextBoxColumn.DataPropertyName = "bonusDate";
            this.bonusDateDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusDateDataGridViewTextBoxColumn.HeaderText = "獎金登錄日期";
            this.bonusDateDataGridViewTextBoxColumn.Name = "bonusDateDataGridViewTextBoxColumn";
            this.bonusDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bonusTDataGridViewTextBoxColumn
            // 
            this.bonusTDataGridViewTextBoxColumn.DataPropertyName = "bonusT";
            this.bonusTDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bonusTDataGridViewTextBoxColumn.HeaderText = "獎金登錄期別";
            this.bonusTDataGridViewTextBoxColumn.Name = "bonusTDataGridViewTextBoxColumn";
            this.bonusTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusTDataGridViewTextBoxColumn.Width = 150;
            // 
            // _workAttendance
            // 
            this._workAttendance.Controls.Add(this._workAttendancePage);
            this._workAttendance.Location = new System.Drawing.Point(4, 34);
            this._workAttendance.Name = "_workAttendance";
            this._workAttendance.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._workAttendance.Size = new System.Drawing.Size(1584, 872);
            this._workAttendance.TabIndex = 1;
            this._workAttendance.Text = "Work Attendance";
            this._workAttendance.UseVisualStyleBackColor = true;
            // 
            // _workAttendancePage
            // 
            this._workAttendancePage.Controls.Add(this._addWorkAttendance);
            this._workAttendancePage.Controls.Add(this._editWorkAttendance);
            this._workAttendancePage.Location = new System.Drawing.Point(8, 8);
            this._workAttendancePage.Name = "_workAttendancePage";
            this._workAttendancePage.SelectedIndex = 0;
            this._workAttendancePage.Size = new System.Drawing.Size(1548, 862);
            this._workAttendancePage.TabIndex = 0;
            // 
            // _addWorkAttendance
            // 
            this._addWorkAttendance.Controls.Add(this._addWAButton);
            this._addWorkAttendance.Controls.Add(this._addWAEndOTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAEndOverTimeLB);
            this._addWorkAttendance.Controls.Add(this._addWAStartOTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAStartOverTimeLB);
            this._addWorkAttendance.Controls.Add(this._addWAIsOvertimeCB);
            this._addWorkAttendance.Controls.Add(this._addWAIsOvertime);
            this._addWorkAttendance.Controls.Add(this._addWAEndWTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAEndWTLB);
            this._addWorkAttendance.Controls.Add(this._addWAStartWTDTP);
            this._addWorkAttendance.Controls.Add(this._addWAStartWTLB);
            this._addWorkAttendance.Controls.Add(this._addWAWorkStatusCB);
            this._addWorkAttendance.Controls.Add(this._addWAStatusLB);
            this._addWorkAttendance.Controls.Add(this._addWADateDTP);
            this._addWorkAttendance.Controls.Add(this._addWADate);
            this._addWorkAttendance.Controls.Add(this._addWAEmplIDTB);
            this._addWorkAttendance.Controls.Add(this._addWAEmplIDLB);
            this._addWorkAttendance.Location = new System.Drawing.Point(4, 34);
            this._addWorkAttendance.Name = "_addWorkAttendance";
            this._addWorkAttendance.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._addWorkAttendance.Size = new System.Drawing.Size(1540, 824);
            this._addWorkAttendance.TabIndex = 0;
            this._addWorkAttendance.Text = "Add";
            this._addWorkAttendance.UseVisualStyleBackColor = true;
            // 
            // _addWAButton
            // 
            this._addWAButton.Location = new System.Drawing.Point(968, 598);
            this._addWAButton.Name = "_addWAButton";
            this._addWAButton.Size = new System.Drawing.Size(98, 40);
            this._addWAButton.TabIndex = 16;
            this._addWAButton.Text = "Add";
            this._addWAButton.UseVisualStyleBackColor = true;
            this._addWAButton.Click += new System.EventHandler(this.ClickAddWAButton);
            // 
            // _addWAEndOTDTP
            // 
            this._addWAEndOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAEndOTDTP.Location = new System.Drawing.Point(820, 238);
            this._addWAEndOTDTP.Name = "_addWAEndOTDTP";
            this._addWAEndOTDTP.Size = new System.Drawing.Size(246, 36);
            this._addWAEndOTDTP.TabIndex = 15;
            // 
            // _addWAEndOverTimeLB
            // 
            this._addWAEndOverTimeLB.AutoSize = true;
            this._addWAEndOverTimeLB.Location = new System.Drawing.Point(651, 250);
            this._addWAEndOverTimeLB.Name = "_addWAEndOverTimeLB";
            this._addWAEndOverTimeLB.Size = new System.Drawing.Size(143, 24);
            this._addWAEndOverTimeLB.TabIndex = 14;
            this._addWAEndOverTimeLB.Text = "End Overtime:";
            // 
            // _addWAStartOTDTP
            // 
            this._addWAStartOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAStartOTDTP.Location = new System.Drawing.Point(826, 142);
            this._addWAStartOTDTP.Name = "_addWAStartOTDTP";
            this._addWAStartOTDTP.Size = new System.Drawing.Size(238, 36);
            this._addWAStartOTDTP.TabIndex = 13;
            // 
            // _addWAStartOverTimeLB
            // 
            this._addWAStartOverTimeLB.AutoSize = true;
            this._addWAStartOverTimeLB.Location = new System.Drawing.Point(651, 154);
            this._addWAStartOverTimeLB.Name = "_addWAStartOverTimeLB";
            this._addWAStartOverTimeLB.Size = new System.Drawing.Size(150, 24);
            this._addWAStartOverTimeLB.TabIndex = 12;
            this._addWAStartOverTimeLB.Text = "Start Overtime:";
            // 
            // _addWAIsOvertimeCB
            // 
            this._addWAIsOvertimeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addWAIsOvertimeCB.FormattingEnabled = true;
            this._addWAIsOvertimeCB.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this._addWAIsOvertimeCB.Location = new System.Drawing.Point(782, 48);
            this._addWAIsOvertimeCB.Name = "_addWAIsOvertimeCB";
            this._addWAIsOvertimeCB.Size = new System.Drawing.Size(157, 32);
            this._addWAIsOvertimeCB.TabIndex = 11;
            this._addWAIsOvertimeCB.SelectedIndexChanged += new System.EventHandler(this.ChangeWAIsOvertimeSelectedIndex);
            // 
            // _addWAIsOvertime
            // 
            this._addWAIsOvertime.AutoSize = true;
            this._addWAIsOvertime.Location = new System.Drawing.Point(652, 52);
            this._addWAIsOvertime.Name = "_addWAIsOvertime";
            this._addWAIsOvertime.Size = new System.Drawing.Size(124, 24);
            this._addWAIsOvertime.TabIndex = 10;
            this._addWAIsOvertime.Text = "Is Overtime:";
            // 
            // _addWAEndWTDTP
            // 
            this._addWAEndWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAEndWTDTP.Location = new System.Drawing.Point(220, 434);
            this._addWAEndWTDTP.Name = "_addWAEndWTDTP";
            this._addWAEndWTDTP.Size = new System.Drawing.Size(246, 36);
            this._addWAEndWTDTP.TabIndex = 9;
            // 
            // _addWAEndWTLB
            // 
            this._addWAEndWTLB.AutoSize = true;
            this._addWAEndWTLB.Location = new System.Drawing.Point(52, 446);
            this._addWAEndWTLB.Name = "_addWAEndWTLB";
            this._addWAEndWTLB.Size = new System.Drawing.Size(163, 24);
            this._addWAEndWTLB.TabIndex = 8;
            this._addWAEndWTLB.Text = "End Work Time:";
            // 
            // _addWAStartWTDTP
            // 
            this._addWAStartWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._addWAStartWTDTP.Location = new System.Drawing.Point(228, 338);
            this._addWAStartWTDTP.Name = "_addWAStartWTDTP";
            this._addWAStartWTDTP.Size = new System.Drawing.Size(238, 36);
            this._addWAStartWTDTP.TabIndex = 7;
            // 
            // _addWAStartWTLB
            // 
            this._addWAStartWTLB.AutoSize = true;
            this._addWAStartWTLB.Location = new System.Drawing.Point(52, 350);
            this._addWAStartWTLB.Name = "_addWAStartWTLB";
            this._addWAStartWTLB.Size = new System.Drawing.Size(170, 24);
            this._addWAStartWTLB.TabIndex = 6;
            this._addWAStartWTLB.Text = "Start Work Time:";
            // 
            // _addWAWorkStatusCB
            // 
            this._addWAWorkStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._addWAWorkStatusCB.FormattingEnabled = true;
            this._addWAWorkStatusCB.Items.AddRange(new object[] {
            "正常上下班",
            "遲到",
            "早退",
            "無故未到",
            "病假",
            "婚假",
            "產假",
            "休假"});
            this._addWAWorkStatusCB.Location = new System.Drawing.Point(188, 244);
            this._addWAWorkStatusCB.Name = "_addWAWorkStatusCB";
            this._addWAWorkStatusCB.Size = new System.Drawing.Size(278, 32);
            this._addWAWorkStatusCB.TabIndex = 5;
            this._addWAWorkStatusCB.SelectedIndexChanged += new System.EventHandler(this.ChangeWAStatusSelectedIndex);
            // 
            // _addWAStatusLB
            // 
            this._addWAStatusLB.AutoSize = true;
            this._addWAStatusLB.Location = new System.Drawing.Point(52, 252);
            this._addWAStatusLB.Name = "_addWAStatusLB";
            this._addWAStatusLB.Size = new System.Drawing.Size(128, 24);
            this._addWAStatusLB.TabIndex = 4;
            this._addWAStatusLB.Text = "Work Status:";
            // 
            // _addWADateDTP
            // 
            this._addWADateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._addWADateDTP.Location = new System.Drawing.Point(120, 146);
            this._addWADateDTP.Name = "_addWADateDTP";
            this._addWADateDTP.Size = new System.Drawing.Size(346, 36);
            this._addWADateDTP.TabIndex = 3;
            this._addWADateDTP.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            // 
            // _addWADate
            // 
            this._addWADate.AutoSize = true;
            this._addWADate.Location = new System.Drawing.Point(52, 154);
            this._addWADate.Name = "_addWADate";
            this._addWADate.Size = new System.Drawing.Size(58, 24);
            this._addWADate.TabIndex = 2;
            this._addWADate.Text = "Date:";
            // 
            // _addWAEmplIDTB
            // 
            this._addWAEmplIDTB.Location = new System.Drawing.Point(196, 50);
            this._addWAEmplIDTB.Name = "_addWAEmplIDTB";
            this._addWAEmplIDTB.Size = new System.Drawing.Size(270, 36);
            this._addWAEmplIDTB.TabIndex = 1;
            // 
            // _addWAEmplIDLB
            // 
            this._addWAEmplIDLB.AutoSize = true;
            this._addWAEmplIDLB.Location = new System.Drawing.Point(52, 56);
            this._addWAEmplIDLB.Name = "_addWAEmplIDLB";
            this._addWAEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._addWAEmplIDLB.TabIndex = 0;
            this._addWAEmplIDLB.Text = "Employee ID:";
            // 
            // _editWorkAttendance
            // 
            this._editWorkAttendance.Controls.Add(this._editWAButton);
            this._editWorkAttendance.Controls.Add(this._searchWAButton);
            this._editWorkAttendance.Controls.Add(this._editWAEndOTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAEndOTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStartOTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAStartOTLB);
            this._editWorkAttendance.Controls.Add(this._editWAIsOvertimeCB);
            this._editWorkAttendance.Controls.Add(this._editWAIsOvertimeLB);
            this._editWorkAttendance.Controls.Add(this._editWAEndWTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAEndWTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStartWTDTP);
            this._editWorkAttendance.Controls.Add(this._editWAStartWTLB);
            this._editWorkAttendance.Controls.Add(this._editWAStatusCB);
            this._editWorkAttendance.Controls.Add(this._editWAWorkStatusLB);
            this._editWorkAttendance.Controls.Add(this._editWADateDTP);
            this._editWorkAttendance.Controls.Add(this._editWADateLB);
            this._editWorkAttendance.Controls.Add(this._editWAEmplIDTB);
            this._editWorkAttendance.Controls.Add(this._editWAEmplIDLB);
            this._editWorkAttendance.Location = new System.Drawing.Point(4, 34);
            this._editWorkAttendance.Name = "_editWorkAttendance";
            this._editWorkAttendance.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._editWorkAttendance.Size = new System.Drawing.Size(1540, 824);
            this._editWorkAttendance.TabIndex = 1;
            this._editWorkAttendance.Text = "Edit";
            this._editWorkAttendance.UseVisualStyleBackColor = true;
            // 
            // _editWAButton
            // 
            this._editWAButton.Enabled = false;
            this._editWAButton.Location = new System.Drawing.Point(1048, 590);
            this._editWAButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAButton.Name = "_editWAButton";
            this._editWAButton.Size = new System.Drawing.Size(146, 62);
            this._editWAButton.TabIndex = 34;
            this._editWAButton.Text = "Edit";
            this._editWAButton.UseVisualStyleBackColor = true;
            this._editWAButton.Click += new System.EventHandler(this.ClickEditWAButton);
            // 
            // _searchWAButton
            // 
            this._searchWAButton.Location = new System.Drawing.Point(850, 590);
            this._searchWAButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._searchWAButton.Name = "_searchWAButton";
            this._searchWAButton.Size = new System.Drawing.Size(146, 62);
            this._searchWAButton.TabIndex = 33;
            this._searchWAButton.Text = "Search";
            this._searchWAButton.UseVisualStyleBackColor = true;
            this._searchWAButton.Click += new System.EventHandler(this.ClickSearchWAButton);
            // 
            // _editWAEndOTDTP
            // 
            this._editWAEndOTDTP.Enabled = false;
            this._editWAEndOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAEndOTDTP.Location = new System.Drawing.Point(828, 202);
            this._editWAEndOTDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAEndOTDTP.Name = "_editWAEndOTDTP";
            this._editWAEndOTDTP.Size = new System.Drawing.Size(366, 36);
            this._editWAEndOTDTP.TabIndex = 32;
            // 
            // _editWAEndOTLB
            // 
            this._editWAEndOTLB.AutoSize = true;
            this._editWAEndOTLB.Location = new System.Drawing.Point(681, 214);
            this._editWAEndOTLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAEndOTLB.Name = "_editWAEndOTLB";
            this._editWAEndOTLB.Size = new System.Drawing.Size(143, 24);
            this._editWAEndOTLB.TabIndex = 31;
            this._editWAEndOTLB.Text = "End Overtime:";
            // 
            // _editWAStartOTDTP
            // 
            this._editWAStartOTDTP.Enabled = false;
            this._editWAStartOTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAStartOTDTP.Location = new System.Drawing.Point(838, 116);
            this._editWAStartOTDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAStartOTDTP.Name = "_editWAStartOTDTP";
            this._editWAStartOTDTP.Size = new System.Drawing.Size(355, 36);
            this._editWAStartOTDTP.TabIndex = 30;
            // 
            // _editWAStartOTLB
            // 
            this._editWAStartOTLB.AutoSize = true;
            this._editWAStartOTLB.Location = new System.Drawing.Point(681, 128);
            this._editWAStartOTLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAStartOTLB.Name = "_editWAStartOTLB";
            this._editWAStartOTLB.Size = new System.Drawing.Size(150, 24);
            this._editWAStartOTLB.TabIndex = 29;
            this._editWAStartOTLB.Text = "Start Overtime:";
            // 
            // _editWAIsOvertimeCB
            // 
            this._editWAIsOvertimeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editWAIsOvertimeCB.Enabled = false;
            this._editWAIsOvertimeCB.FormattingEnabled = true;
            this._editWAIsOvertimeCB.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this._editWAIsOvertimeCB.Location = new System.Drawing.Point(813, 38);
            this._editWAIsOvertimeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAIsOvertimeCB.Name = "_editWAIsOvertimeCB";
            this._editWAIsOvertimeCB.Size = new System.Drawing.Size(234, 32);
            this._editWAIsOvertimeCB.TabIndex = 28;
            this._editWAIsOvertimeCB.SelectedIndexChanged += new System.EventHandler(this.ChangeEditWAIsOvertimeSelectedIndex);
            // 
            // _editWAIsOvertimeLB
            // 
            this._editWAIsOvertimeLB.AutoSize = true;
            this._editWAIsOvertimeLB.Location = new System.Drawing.Point(681, 45);
            this._editWAIsOvertimeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAIsOvertimeLB.Name = "_editWAIsOvertimeLB";
            this._editWAIsOvertimeLB.Size = new System.Drawing.Size(124, 24);
            this._editWAIsOvertimeLB.TabIndex = 27;
            this._editWAIsOvertimeLB.Text = "Is Overtime:";
            // 
            // _editWAEndWTDTP
            // 
            this._editWAEndWTDTP.Enabled = false;
            this._editWAEndWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAEndWTDTP.Location = new System.Drawing.Point(216, 390);
            this._editWAEndWTDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAEndWTDTP.Name = "_editWAEndWTDTP";
            this._editWAEndWTDTP.Size = new System.Drawing.Size(366, 36);
            this._editWAEndWTDTP.TabIndex = 26;
            // 
            // _editWAEndWTLB
            // 
            this._editWAEndWTLB.AutoSize = true;
            this._editWAEndWTLB.Location = new System.Drawing.Point(50, 402);
            this._editWAEndWTLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAEndWTLB.Name = "_editWAEndWTLB";
            this._editWAEndWTLB.Size = new System.Drawing.Size(163, 24);
            this._editWAEndWTLB.TabIndex = 25;
            this._editWAEndWTLB.Text = "End Work Time:";
            // 
            // _editWAStartWTDTP
            // 
            this._editWAStartWTDTP.Enabled = false;
            this._editWAStartWTDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._editWAStartWTDTP.Location = new System.Drawing.Point(226, 296);
            this._editWAStartWTDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAStartWTDTP.Name = "_editWAStartWTDTP";
            this._editWAStartWTDTP.Size = new System.Drawing.Size(355, 36);
            this._editWAStartWTDTP.TabIndex = 24;
            // 
            // _editWAStartWTLB
            // 
            this._editWAStartWTLB.AutoSize = true;
            this._editWAStartWTLB.Location = new System.Drawing.Point(50, 308);
            this._editWAStartWTLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAStartWTLB.Name = "_editWAStartWTLB";
            this._editWAStartWTLB.Size = new System.Drawing.Size(170, 24);
            this._editWAStartWTLB.TabIndex = 23;
            this._editWAStartWTLB.Text = "Start Work Time:";
            // 
            // _editWAStatusCB
            // 
            this._editWAStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editWAStatusCB.Enabled = false;
            this._editWAStatusCB.FormattingEnabled = true;
            this._editWAStatusCB.Items.AddRange(new object[] {
            "正常上下班",
            "遲到",
            "早退",
            "無故未到",
            "病假",
            "婚假",
            "產假",
            "休假"});
            this._editWAStatusCB.Location = new System.Drawing.Point(184, 219);
            this._editWAStatusCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAStatusCB.Name = "_editWAStatusCB";
            this._editWAStatusCB.Size = new System.Drawing.Size(326, 32);
            this._editWAStatusCB.TabIndex = 22;
            this._editWAStatusCB.SelectedIndexChanged += new System.EventHandler(this.ChangeEditWAStatusSelectedIndex);
            // 
            // _editWAWorkStatusLB
            // 
            this._editWAWorkStatusLB.AutoSize = true;
            this._editWAWorkStatusLB.Location = new System.Drawing.Point(50, 222);
            this._editWAWorkStatusLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAWorkStatusLB.Name = "_editWAWorkStatusLB";
            this._editWAWorkStatusLB.Size = new System.Drawing.Size(128, 24);
            this._editWAWorkStatusLB.TabIndex = 21;
            this._editWAWorkStatusLB.Text = "Work Status:";
            // 
            // _editWADateDTP
            // 
            this._editWADateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._editWADateDTP.Location = new System.Drawing.Point(116, 128);
            this._editWADateDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWADateDTP.Name = "_editWADateDTP";
            this._editWADateDTP.Size = new System.Drawing.Size(397, 36);
            this._editWADateDTP.TabIndex = 20;
            this._editWADateDTP.Value = new System.DateTime(2016, 6, 10, 0, 0, 0, 0);
            // 
            // _editWADateLB
            // 
            this._editWADateLB.AutoSize = true;
            this._editWADateLB.Location = new System.Drawing.Point(50, 136);
            this._editWADateLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWADateLB.Name = "_editWADateLB";
            this._editWADateLB.Size = new System.Drawing.Size(58, 24);
            this._editWADateLB.TabIndex = 19;
            this._editWADateLB.Text = "Date:";
            // 
            // _editWAEmplIDTB
            // 
            this._editWAEmplIDTB.Location = new System.Drawing.Point(194, 42);
            this._editWAEmplIDTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._editWAEmplIDTB.Name = "_editWAEmplIDTB";
            this._editWAEmplIDTB.Size = new System.Drawing.Size(318, 36);
            this._editWAEmplIDTB.TabIndex = 18;
            // 
            // _editWAEmplIDLB
            // 
            this._editWAEmplIDLB.AutoSize = true;
            this._editWAEmplIDLB.Location = new System.Drawing.Point(50, 54);
            this._editWAEmplIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._editWAEmplIDLB.Name = "_editWAEmplIDLB";
            this._editWAEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._editWAEmplIDLB.TabIndex = 17;
            this._editWAEmplIDLB.Text = "Employee ID:";
            // 
            // _employee
            // 
            this._employee.Controls.Add(this._employeePage);
            this._employee.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employee.Location = new System.Drawing.Point(4, 34);
            this._employee.Name = "_employee";
            this._employee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._employee.Size = new System.Drawing.Size(1584, 872);
            this._employee.TabIndex = 0;
            this._employee.Text = "Employee";
            this._employee.UseVisualStyleBackColor = true;
            // 
            // _employeePage
            // 
            this._employeePage.Controls.Add(this._newEmployee);
            this._employeePage.Controls.Add(this._editEmployee);
            this._employeePage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._employeePage.Location = new System.Drawing.Point(8, 8);
            this._employeePage.Name = "_employeePage";
            this._employeePage.SelectedIndex = 0;
            this._employeePage.Size = new System.Drawing.Size(1545, 860);
            this._employeePage.TabIndex = 0;
            // 
            // _newEmployee
            // 
            this._newEmployee.Controls.Add(this._addEmplLoginPWTB);
            this._newEmployee.Controls.Add(this._addEmplLoginPWLB);
            this._newEmployee.Controls.Add(this._newEmplPositionCB);
            this._newEmployee.Controls.Add(this._newEmplSexCB);
            this._newEmployee.Controls.Add(this._insertEmplButton);
            this._newEmployee.Controls.Add(this._newEmplBloodCB);
            this._newEmployee.Controls.Add(this._newEmplBloodLB);
            this._newEmployee.Controls.Add(this._newEmplDeptCB);
            this._newEmployee.Controls.Add(this._newEmplBasicSalaryTB);
            this._newEmployee.Controls.Add(this._newEmplJobStatCB);
            this._newEmployee.Controls.Add(this._newEmplSpouseTB);
            this._newEmployee.Controls.Add(this._newEmplMarriedStatCB);
            this._newEmployee.Controls.Add(this._newEmplMilitaryStatCB);
            this._newEmployee.Controls.Add(this._newEmplEmerPhoneTB);
            this._newEmployee.Controls.Add(this._newEmplEmerPersonTB);
            this._newEmployee.Controls.Add(this._newEmplAddrTB);
            this._newEmployee.Controls.Add(this._newEmplPhoneTB);
            this._newEmployee.Controls.Add(this._newEmpllSsnTB);
            this._newEmployee.Controls.Add(this._newEmplBirthDP);
            this._newEmployee.Controls.Add(this._newEmplNameTB);
            this._newEmployee.Controls.Add(this._newEmplIDTB);
            this._newEmployee.Controls.Add(this._newEmplPositionIDLB);
            this._newEmployee.Controls.Add(this._newEmplDeptIDLB);
            this._newEmployee.Controls.Add(this._newEmplBasicSalaryLB);
            this._newEmployee.Controls.Add(this._newEmplBirthLB);
            this._newEmployee.Controls.Add(this._newEmplSpouseLB);
            this._newEmployee.Controls.Add(this._newEmplMarriedStatLB);
            this._newEmployee.Controls.Add(this._newEmplJobStatLB);
            this._newEmployee.Controls.Add(this._newEmplMilitaryLB);
            this._newEmployee.Controls.Add(this._newEmplEmerPhoneLB);
            this._newEmployee.Controls.Add(this._newEmplEmerPersonLB);
            this._newEmployee.Controls.Add(this._newEmplAddrLB);
            this._newEmployee.Controls.Add(this._newEmplPhoneLB);
            this._newEmployee.Controls.Add(this._newEmplSexLB);
            this._newEmployee.Controls.Add(this._newEmplSsnLB);
            this._newEmployee.Controls.Add(this._newEmplNameLB);
            this._newEmployee.Controls.Add(this._newEmplIDLB);
            this._newEmployee.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._newEmployee.Location = new System.Drawing.Point(4, 34);
            this._newEmployee.Name = "_newEmployee";
            this._newEmployee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._newEmployee.Size = new System.Drawing.Size(1537, 822);
            this._newEmployee.TabIndex = 0;
            this._newEmployee.Text = "Add";
            this._newEmployee.UseVisualStyleBackColor = true;
            // 
            // _addEmplLoginPWTB
            // 
            this._addEmplLoginPWTB.Location = new System.Drawing.Point(843, 578);
            this._addEmplLoginPWTB.Name = "_addEmplLoginPWTB";
            this._addEmplLoginPWTB.Size = new System.Drawing.Size(320, 36);
            this._addEmplLoginPWTB.TabIndex = 41;
            // 
            // _addEmplLoginPWLB
            // 
            this._addEmplLoginPWLB.AutoSize = true;
            this._addEmplLoginPWLB.Location = new System.Drawing.Point(674, 584);
            this._addEmplLoginPWLB.Name = "_addEmplLoginPWLB";
            this._addEmplLoginPWLB.Size = new System.Drawing.Size(162, 24);
            this._addEmplLoginPWLB.TabIndex = 40;
            this._addEmplLoginPWLB.Text = "Login Password:";
            // 
            // _newEmplPositionCB
            // 
            this._newEmplPositionCB.DataSource = this.positionBindingSource;
            this._newEmplPositionCB.DisplayMember = "positionName";
            this._newEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplPositionCB.FormattingEnabled = true;
            this._newEmplPositionCB.Location = new System.Drawing.Point(146, 624);
            this._newEmplPositionCB.Name = "_newEmplPositionCB";
            this._newEmplPositionCB.Size = new System.Drawing.Size(308, 32);
            this._newEmplPositionCB.TabIndex = 39;
            this._newEmplPositionCB.ValueMember = "positionID";
            this._newEmplPositionCB.SelectedIndexChanged += new System.EventHandler(this.ChangedNewEmplPositionCBSelectedIndex);
            // 
            // _newEmplSexCB
            // 
            this._newEmplSexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplSexCB.FormattingEnabled = true;
            this._newEmplSexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._newEmplSexCB.Location = new System.Drawing.Point(726, 100);
            this._newEmplSexCB.Name = "_newEmplSexCB";
            this._newEmplSexCB.Size = new System.Drawing.Size(121, 32);
            this._newEmplSexCB.TabIndex = 38;
            // 
            // _insertEmplButton
            // 
            this._insertEmplButton.Location = new System.Drawing.Point(1220, 718);
            this._insertEmplButton.Name = "_insertEmplButton";
            this._insertEmplButton.Size = new System.Drawing.Size(112, 52);
            this._insertEmplButton.TabIndex = 37;
            this._insertEmplButton.Text = "Add";
            this._insertEmplButton.UseVisualStyleBackColor = true;
            this._insertEmplButton.Click += new System.EventHandler(this.ClickAddEmplButton);
            // 
            // _newEmplBloodCB
            // 
            this._newEmplBloodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplBloodCB.FormattingEnabled = true;
            this._newEmplBloodCB.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this._newEmplBloodCB.Location = new System.Drawing.Point(951, 100);
            this._newEmplBloodCB.Name = "_newEmplBloodCB";
            this._newEmplBloodCB.Size = new System.Drawing.Size(114, 32);
            this._newEmplBloodCB.TabIndex = 36;
            // 
            // _newEmplBloodLB
            // 
            this._newEmplBloodLB.AutoSize = true;
            this._newEmplBloodLB.Location = new System.Drawing.Point(874, 108);
            this._newEmplBloodLB.Name = "_newEmplBloodLB";
            this._newEmplBloodLB.Size = new System.Drawing.Size(70, 24);
            this._newEmplBloodLB.TabIndex = 35;
            this._newEmplBloodLB.Text = "Blood:";
            // 
            // _newEmplDeptCB
            // 
            this._newEmplDeptCB.DataSource = this.departmentBindingSource;
            this._newEmplDeptCB.DisplayMember = "departmentName";
            this._newEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplDeptCB.FormattingEnabled = true;
            this._newEmplDeptCB.Location = new System.Drawing.Point(182, 558);
            this._newEmplDeptCB.Name = "_newEmplDeptCB";
            this._newEmplDeptCB.Size = new System.Drawing.Size(308, 32);
            this._newEmplDeptCB.TabIndex = 33;
            this._newEmplDeptCB.ValueMember = "departmentID";
            // 
            // _newEmplBasicSalaryTB
            // 
            this._newEmplBasicSalaryTB.Location = new System.Drawing.Point(184, 694);
            this._newEmplBasicSalaryTB.Name = "_newEmplBasicSalaryTB";
            this._newEmplBasicSalaryTB.Size = new System.Drawing.Size(300, 36);
            this._newEmplBasicSalaryTB.TabIndex = 32;
            this._newEmplBasicSalaryTB.Text = "0";
            // 
            // _newEmplJobStatCB
            // 
            this._newEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplJobStatCB.FormattingEnabled = true;
            this._newEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._newEmplJobStatCB.Location = new System.Drawing.Point(164, 486);
            this._newEmplJobStatCB.Name = "_newEmplJobStatCB";
            this._newEmplJobStatCB.Size = new System.Drawing.Size(320, 32);
            this._newEmplJobStatCB.TabIndex = 31;
            // 
            // _newEmplSpouseTB
            // 
            this._newEmplSpouseTB.Location = new System.Drawing.Point(758, 477);
            this._newEmplSpouseTB.Name = "_newEmplSpouseTB";
            this._newEmplSpouseTB.ReadOnly = true;
            this._newEmplSpouseTB.Size = new System.Drawing.Size(223, 36);
            this._newEmplSpouseTB.TabIndex = 30;
            // 
            // _newEmplMarriedStatCB
            // 
            this._newEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMarriedStatCB.FormattingEnabled = true;
            this._newEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._newEmplMarriedStatCB.Location = new System.Drawing.Point(828, 410);
            this._newEmplMarriedStatCB.Name = "_newEmplMarriedStatCB";
            this._newEmplMarriedStatCB.Size = new System.Drawing.Size(152, 32);
            this._newEmplMarriedStatCB.TabIndex = 29;
            this._newEmplMarriedStatCB.SelectedIndexChanged += new System.EventHandler(this.ChangedNewEmplMarriedStatCBSelectedIndex);
            // 
            // _newEmplMilitaryStatCB
            // 
            this._newEmplMilitaryStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._newEmplMilitaryStatCB.FormattingEnabled = true;
            this._newEmplMilitaryStatCB.Items.AddRange(new object[] {
            "役畢",
            "屆退",
            "待役",
            "未役",
            "免役"});
            this._newEmplMilitaryStatCB.Location = new System.Drawing.Point(828, 320);
            this._newEmplMilitaryStatCB.Name = "_newEmplMilitaryStatCB";
            this._newEmplMilitaryStatCB.Size = new System.Drawing.Size(152, 32);
            this._newEmplMilitaryStatCB.TabIndex = 28;
            // 
            // _newEmplEmerPhoneTB
            // 
            this._newEmplEmerPhoneTB.Location = new System.Drawing.Point(236, 405);
            this._newEmplEmerPhoneTB.Name = "_newEmplEmerPhoneTB";
            this._newEmplEmerPhoneTB.Size = new System.Drawing.Size(248, 36);
            this._newEmplEmerPhoneTB.TabIndex = 27;
            // 
            // _newEmplEmerPersonTB
            // 
            this._newEmplEmerPersonTB.Location = new System.Drawing.Point(240, 326);
            this._newEmplEmerPersonTB.Name = "_newEmplEmerPersonTB";
            this._newEmplEmerPersonTB.Size = new System.Drawing.Size(244, 36);
            this._newEmplEmerPersonTB.TabIndex = 26;
            // 
            // _newEmplAddrTB
            // 
            this._newEmplAddrTB.Location = new System.Drawing.Point(146, 250);
            this._newEmplAddrTB.Name = "_newEmplAddrTB";
            this._newEmplAddrTB.Size = new System.Drawing.Size(1018, 36);
            this._newEmplAddrTB.TabIndex = 25;
            // 
            // _newEmplPhoneTB
            // 
            this._newEmplPhoneTB.Location = new System.Drawing.Point(828, 182);
            this._newEmplPhoneTB.Name = "_newEmplPhoneTB";
            this._newEmplPhoneTB.Size = new System.Drawing.Size(336, 36);
            this._newEmplPhoneTB.TabIndex = 24;
            // 
            // _newEmpllSsnTB
            // 
            this._newEmpllSsnTB.Location = new System.Drawing.Point(104, 177);
            this._newEmpllSsnTB.Name = "_newEmpllSsnTB";
            this._newEmpllSsnTB.Size = new System.Drawing.Size(382, 36);
            this._newEmpllSsnTB.TabIndex = 20;
            // 
            // _newEmplBirthDP
            // 
            this._newEmplBirthDP.Location = new System.Drawing.Point(782, 28);
            this._newEmplBirthDP.Name = "_newEmplBirthDP";
            this._newEmplBirthDP.Size = new System.Drawing.Size(200, 36);
            this._newEmplBirthDP.TabIndex = 19;
            // 
            // _newEmplNameTB
            // 
            this._newEmplNameTB.Location = new System.Drawing.Point(124, 105);
            this._newEmplNameTB.Name = "_newEmplNameTB";
            this._newEmplNameTB.Size = new System.Drawing.Size(360, 36);
            this._newEmplNameTB.TabIndex = 17;
            // 
            // _newEmplIDTB
            // 
            this._newEmplIDTB.Location = new System.Drawing.Point(190, 28);
            this._newEmplIDTB.Name = "_newEmplIDTB";
            this._newEmplIDTB.Size = new System.Drawing.Size(294, 36);
            this._newEmplIDTB.TabIndex = 16;
            // 
            // _newEmplPositionIDLB
            // 
            this._newEmplPositionIDLB.AutoSize = true;
            this._newEmplPositionIDLB.Location = new System.Drawing.Point(48, 628);
            this._newEmplPositionIDLB.Name = "_newEmplPositionIDLB";
            this._newEmplPositionIDLB.Size = new System.Drawing.Size(89, 24);
            this._newEmplPositionIDLB.TabIndex = 15;
            this._newEmplPositionIDLB.Text = "Position:";
            // 
            // _newEmplDeptIDLB
            // 
            this._newEmplDeptIDLB.AutoSize = true;
            this._newEmplDeptIDLB.Location = new System.Drawing.Point(48, 562);
            this._newEmplDeptIDLB.Name = "_newEmplDeptIDLB";
            this._newEmplDeptIDLB.Size = new System.Drawing.Size(122, 24);
            this._newEmplDeptIDLB.TabIndex = 14;
            this._newEmplDeptIDLB.Text = "Department:";
            // 
            // _newEmplBasicSalaryLB
            // 
            this._newEmplBasicSalaryLB.AutoSize = true;
            this._newEmplBasicSalaryLB.Location = new System.Drawing.Point(48, 700);
            this._newEmplBasicSalaryLB.Name = "_newEmplBasicSalaryLB";
            this._newEmplBasicSalaryLB.Size = new System.Drawing.Size(130, 24);
            this._newEmplBasicSalaryLB.TabIndex = 13;
            this._newEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _newEmplBirthLB
            // 
            this._newEmplBirthLB.AutoSize = true;
            this._newEmplBirthLB.Location = new System.Drawing.Point(670, 40);
            this._newEmplBirthLB.Name = "_newEmplBirthLB";
            this._newEmplBirthLB.Size = new System.Drawing.Size(105, 24);
            this._newEmplBirthLB.TabIndex = 12;
            this._newEmplBirthLB.Text = "Birth Day:";
            // 
            // _newEmplSpouseLB
            // 
            this._newEmplSpouseLB.AutoSize = true;
            this._newEmplSpouseLB.Location = new System.Drawing.Point(670, 489);
            this._newEmplSpouseLB.Name = "_newEmplSpouseLB";
            this._newEmplSpouseLB.Size = new System.Drawing.Size(81, 24);
            this._newEmplSpouseLB.TabIndex = 11;
            this._newEmplSpouseLB.Text = "Spouse:";
            // 
            // _newEmplMarriedStatLB
            // 
            this._newEmplMarriedStatLB.AutoSize = true;
            this._newEmplMarriedStatLB.Location = new System.Drawing.Point(670, 417);
            this._newEmplMarriedStatLB.Name = "_newEmplMarriedStatLB";
            this._newEmplMarriedStatLB.Size = new System.Drawing.Size(150, 24);
            this._newEmplMarriedStatLB.TabIndex = 10;
            this._newEmplMarriedStatLB.Text = "Married Status:";
            // 
            // _newEmplJobStatLB
            // 
            this._newEmplJobStatLB.AutoSize = true;
            this._newEmplJobStatLB.Location = new System.Drawing.Point(48, 489);
            this._newEmplJobStatLB.Name = "_newEmplJobStatLB";
            this._newEmplJobStatLB.Size = new System.Drawing.Size(108, 24);
            this._newEmplJobStatLB.TabIndex = 9;
            this._newEmplJobStatLB.Text = "Job Status:";
            // 
            // _newEmplMilitaryLB
            // 
            this._newEmplMilitaryLB.AutoSize = true;
            this._newEmplMilitaryLB.Location = new System.Drawing.Point(670, 328);
            this._newEmplMilitaryLB.Name = "_newEmplMilitaryLB";
            this._newEmplMilitaryLB.Size = new System.Drawing.Size(150, 24);
            this._newEmplMilitaryLB.TabIndex = 8;
            this._newEmplMilitaryLB.Text = "Military Status:";
            // 
            // _newEmplEmerPhoneLB
            // 
            this._newEmplEmerPhoneLB.AutoSize = true;
            this._newEmplEmerPhoneLB.Location = new System.Drawing.Point(48, 417);
            this._newEmplEmerPhoneLB.Name = "_newEmplEmerPhoneLB";
            this._newEmplEmerPhoneLB.Size = new System.Drawing.Size(181, 24);
            this._newEmplEmerPhoneLB.TabIndex = 7;
            this._newEmplEmerPhoneLB.Text = "Emergency Phone:";
            // 
            // _newEmplEmerPersonLB
            // 
            this._newEmplEmerPersonLB.AutoSize = true;
            this._newEmplEmerPersonLB.Location = new System.Drawing.Point(48, 338);
            this._newEmplEmerPersonLB.Name = "_newEmplEmerPersonLB";
            this._newEmplEmerPersonLB.Size = new System.Drawing.Size(187, 24);
            this._newEmplEmerPersonLB.TabIndex = 6;
            this._newEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _newEmplAddrLB
            // 
            this._newEmplAddrLB.AutoSize = true;
            this._newEmplAddrLB.Location = new System.Drawing.Point(48, 262);
            this._newEmplAddrLB.Name = "_newEmplAddrLB";
            this._newEmplAddrLB.Size = new System.Drawing.Size(90, 24);
            this._newEmplAddrLB.TabIndex = 5;
            this._newEmplAddrLB.Text = "Address:";
            // 
            // _newEmplPhoneLB
            // 
            this._newEmplPhoneLB.AutoSize = true;
            this._newEmplPhoneLB.Location = new System.Drawing.Point(670, 189);
            this._newEmplPhoneLB.Name = "_newEmplPhoneLB";
            this._newEmplPhoneLB.Size = new System.Drawing.Size(152, 24);
            this._newEmplPhoneLB.TabIndex = 4;
            this._newEmplPhoneLB.Text = "Phone Number:";
            // 
            // _newEmplSexLB
            // 
            this._newEmplSexLB.AutoSize = true;
            this._newEmplSexLB.Location = new System.Drawing.Point(670, 108);
            this._newEmplSexLB.Name = "_newEmplSexLB";
            this._newEmplSexLB.Size = new System.Drawing.Size(50, 24);
            this._newEmplSexLB.TabIndex = 3;
            this._newEmplSexLB.Text = "Sex:";
            // 
            // _newEmplSsnLB
            // 
            this._newEmplSsnLB.AutoSize = true;
            this._newEmplSsnLB.Location = new System.Drawing.Point(48, 194);
            this._newEmplSsnLB.Name = "_newEmplSsnLB";
            this._newEmplSsnLB.Size = new System.Drawing.Size(49, 24);
            this._newEmplSsnLB.TabIndex = 2;
            this._newEmplSsnLB.Text = "Ssn:";
            // 
            // _newEmplNameLB
            // 
            this._newEmplNameLB.AutoSize = true;
            this._newEmplNameLB.Location = new System.Drawing.Point(48, 117);
            this._newEmplNameLB.Name = "_newEmplNameLB";
            this._newEmplNameLB.Size = new System.Drawing.Size(70, 24);
            this._newEmplNameLB.TabIndex = 1;
            this._newEmplNameLB.Text = "Name:";
            // 
            // _newEmplIDLB
            // 
            this._newEmplIDLB.AutoSize = true;
            this._newEmplIDLB.Location = new System.Drawing.Point(48, 40);
            this._newEmplIDLB.Name = "_newEmplIDLB";
            this._newEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this._newEmplIDLB.TabIndex = 0;
            this._newEmplIDLB.Text = "Employee ID:";
            // 
            // _editEmployee
            // 
            this._editEmployee.Controls.Add(this._searchEmplButtom);
            this._editEmployee.Controls.Add(this._editEmplPositionCB);
            this._editEmployee.Controls.Add(this._editEmplSexCB);
            this._editEmployee.Controls.Add(this._editEmplButton);
            this._editEmployee.Controls.Add(this._editEmplBloodCB);
            this._editEmployee.Controls.Add(this._editEmplBloodLB);
            this._editEmployee.Controls.Add(this._editEmplDeptCB);
            this._editEmployee.Controls.Add(this._editEmplBasicSalaryTB);
            this._editEmployee.Controls.Add(this._editEmplJobStatCB);
            this._editEmployee.Controls.Add(this._editEmplSpouseTB);
            this._editEmployee.Controls.Add(this._editEmplMarriedStatCB);
            this._editEmployee.Controls.Add(this._editEmplMilitaryStatCB);
            this._editEmployee.Controls.Add(this._editEmplEmerPhoneTB);
            this._editEmployee.Controls.Add(this._editEmplEmerPersonTB);
            this._editEmployee.Controls.Add(this._editEmplAddrTB);
            this._editEmployee.Controls.Add(this._editEmplPhoneTB);
            this._editEmployee.Controls.Add(this._editEmplSsnTB);
            this._editEmployee.Controls.Add(this._editEmplBirthDTP);
            this._editEmployee.Controls.Add(this._editEmplNameTB);
            this._editEmployee.Controls.Add(this._editEmplIDTB);
            this._editEmployee.Controls.Add(this._editEmplPositionLB);
            this._editEmployee.Controls.Add(this._editEmplDeptLB);
            this._editEmployee.Controls.Add(this._editEmplBasicSalaryLB);
            this._editEmployee.Controls.Add(this._editEmplBirthLB);
            this._editEmployee.Controls.Add(this._editEmplSpouseLB);
            this._editEmployee.Controls.Add(this._editMarriedStatLB);
            this._editEmployee.Controls.Add(this._editEmplJobStatLB);
            this._editEmployee.Controls.Add(this._editEmplMilitaryStatLB);
            this._editEmployee.Controls.Add(this._editEmplEmerPhone);
            this._editEmployee.Controls.Add(this._editEmplEmerPersonLB);
            this._editEmployee.Controls.Add(this._editEmplAddrLB);
            this._editEmployee.Controls.Add(this._editEmplPhoneLB);
            this._editEmployee.Controls.Add(this._editEmplSexLB);
            this._editEmployee.Controls.Add(this._editEmplSsnLB);
            this._editEmployee.Controls.Add(this._editEmplNameLB);
            this._editEmployee.Controls.Add(this.editEmplIDLB);
            this._editEmployee.Location = new System.Drawing.Point(4, 34);
            this._editEmployee.Name = "_editEmployee";
            this._editEmployee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this._editEmployee.Size = new System.Drawing.Size(1537, 822);
            this._editEmployee.TabIndex = 1;
            this._editEmployee.Text = "Edit";
            this._editEmployee.UseVisualStyleBackColor = true;
            // 
            // _searchEmplButtom
            // 
            this._searchEmplButtom.Location = new System.Drawing.Point(1078, 726);
            this._searchEmplButtom.Name = "_searchEmplButtom";
            this._searchEmplButtom.Size = new System.Drawing.Size(112, 52);
            this._searchEmplButtom.TabIndex = 75;
            this._searchEmplButtom.Text = "Search";
            this._searchEmplButtom.UseVisualStyleBackColor = true;
            this._searchEmplButtom.Click += new System.EventHandler(this.ClickSearchEmplButtom);
            // 
            // _editEmplPositionCB
            // 
            this._editEmplPositionCB.DataSource = this.positionBindingSource;
            this._editEmplPositionCB.DisplayMember = "positionName";
            this._editEmplPositionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplPositionCB.Enabled = false;
            this._editEmplPositionCB.FormattingEnabled = true;
            this._editEmplPositionCB.Location = new System.Drawing.Point(150, 632);
            this._editEmplPositionCB.Name = "_editEmplPositionCB";
            this._editEmplPositionCB.Size = new System.Drawing.Size(308, 32);
            this._editEmplPositionCB.TabIndex = 74;
            this._editEmplPositionCB.ValueMember = "positionID";
            this._editEmplPositionCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditEmplPositionCBSelectedIndex);
            // 
            // _editEmplSexCB
            // 
            this._editEmplSexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplSexCB.Enabled = false;
            this._editEmplSexCB.FormattingEnabled = true;
            this._editEmplSexCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._editEmplSexCB.Location = new System.Drawing.Point(730, 108);
            this._editEmplSexCB.Name = "_editEmplSexCB";
            this._editEmplSexCB.Size = new System.Drawing.Size(121, 32);
            this._editEmplSexCB.TabIndex = 73;
            // 
            // _editEmplButton
            // 
            this._editEmplButton.Enabled = false;
            this._editEmplButton.Location = new System.Drawing.Point(1224, 726);
            this._editEmplButton.Name = "_editEmplButton";
            this._editEmplButton.Size = new System.Drawing.Size(112, 52);
            this._editEmplButton.TabIndex = 72;
            this._editEmplButton.Text = "Edit";
            this._editEmplButton.UseVisualStyleBackColor = true;
            this._editEmplButton.Click += new System.EventHandler(this.ClickEditEmplButtom);
            // 
            // _editEmplBloodCB
            // 
            this._editEmplBloodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplBloodCB.Enabled = false;
            this._editEmplBloodCB.FormattingEnabled = true;
            this._editEmplBloodCB.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this._editEmplBloodCB.Location = new System.Drawing.Point(956, 108);
            this._editEmplBloodCB.Name = "_editEmplBloodCB";
            this._editEmplBloodCB.Size = new System.Drawing.Size(114, 32);
            this._editEmplBloodCB.TabIndex = 71;
            // 
            // _editEmplBloodLB
            // 
            this._editEmplBloodLB.AutoSize = true;
            this._editEmplBloodLB.Location = new System.Drawing.Point(878, 116);
            this._editEmplBloodLB.Name = "_editEmplBloodLB";
            this._editEmplBloodLB.Size = new System.Drawing.Size(70, 24);
            this._editEmplBloodLB.TabIndex = 70;
            this._editEmplBloodLB.Text = "Blood:";
            // 
            // _editEmplDeptCB
            // 
            this._editEmplDeptCB.DataSource = this.departmentBindingSource;
            this._editEmplDeptCB.DisplayMember = "departmentName";
            this._editEmplDeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplDeptCB.Enabled = false;
            this._editEmplDeptCB.FormattingEnabled = true;
            this._editEmplDeptCB.Location = new System.Drawing.Point(186, 566);
            this._editEmplDeptCB.Name = "_editEmplDeptCB";
            this._editEmplDeptCB.Size = new System.Drawing.Size(308, 32);
            this._editEmplDeptCB.TabIndex = 69;
            this._editEmplDeptCB.ValueMember = "departmentID";
            // 
            // _editEmplBasicSalaryTB
            // 
            this._editEmplBasicSalaryTB.Location = new System.Drawing.Point(188, 702);
            this._editEmplBasicSalaryTB.Name = "_editEmplBasicSalaryTB";
            this._editEmplBasicSalaryTB.ReadOnly = true;
            this._editEmplBasicSalaryTB.Size = new System.Drawing.Size(300, 36);
            this._editEmplBasicSalaryTB.TabIndex = 68;
            this._editEmplBasicSalaryTB.Text = "0";
            // 
            // _editEmplJobStatCB
            // 
            this._editEmplJobStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplJobStatCB.Enabled = false;
            this._editEmplJobStatCB.FormattingEnabled = true;
            this._editEmplJobStatCB.Items.AddRange(new object[] {
            "在職",
            "離職"});
            this._editEmplJobStatCB.Location = new System.Drawing.Point(168, 494);
            this._editEmplJobStatCB.Name = "_editEmplJobStatCB";
            this._editEmplJobStatCB.Size = new System.Drawing.Size(320, 32);
            this._editEmplJobStatCB.TabIndex = 67;
            // 
            // _editEmplSpouseTB
            // 
            this._editEmplSpouseTB.Location = new System.Drawing.Point(762, 484);
            this._editEmplSpouseTB.Name = "_editEmplSpouseTB";
            this._editEmplSpouseTB.ReadOnly = true;
            this._editEmplSpouseTB.Size = new System.Drawing.Size(223, 36);
            this._editEmplSpouseTB.TabIndex = 66;
            // 
            // _editEmplMarriedStatCB
            // 
            this._editEmplMarriedStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplMarriedStatCB.Enabled = false;
            this._editEmplMarriedStatCB.FormattingEnabled = true;
            this._editEmplMarriedStatCB.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this._editEmplMarriedStatCB.Location = new System.Drawing.Point(832, 418);
            this._editEmplMarriedStatCB.Name = "_editEmplMarriedStatCB";
            this._editEmplMarriedStatCB.Size = new System.Drawing.Size(152, 32);
            this._editEmplMarriedStatCB.TabIndex = 65;
            this._editEmplMarriedStatCB.SelectedIndexChanged += new System.EventHandler(this.ChangedEditEmplMarriedStatCBSelectedIndex);
            // 
            // _editEmplMilitaryStatCB
            // 
            this._editEmplMilitaryStatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._editEmplMilitaryStatCB.Enabled = false;
            this._editEmplMilitaryStatCB.FormattingEnabled = true;
            this._editEmplMilitaryStatCB.Items.AddRange(new object[] {
            "役畢",
            "屆退",
            "待役",
            "未役",
            "免役"});
            this._editEmplMilitaryStatCB.Location = new System.Drawing.Point(832, 328);
            this._editEmplMilitaryStatCB.Name = "_editEmplMilitaryStatCB";
            this._editEmplMilitaryStatCB.Size = new System.Drawing.Size(152, 32);
            this._editEmplMilitaryStatCB.TabIndex = 64;
            // 
            // _editEmplEmerPhoneTB
            // 
            this._editEmplEmerPhoneTB.Location = new System.Drawing.Point(240, 412);
            this._editEmplEmerPhoneTB.Name = "_editEmplEmerPhoneTB";
            this._editEmplEmerPhoneTB.ReadOnly = true;
            this._editEmplEmerPhoneTB.Size = new System.Drawing.Size(248, 36);
            this._editEmplEmerPhoneTB.TabIndex = 63;
            // 
            // _editEmplEmerPersonTB
            // 
            this._editEmplEmerPersonTB.Location = new System.Drawing.Point(244, 334);
            this._editEmplEmerPersonTB.Name = "_editEmplEmerPersonTB";
            this._editEmplEmerPersonTB.ReadOnly = true;
            this._editEmplEmerPersonTB.Size = new System.Drawing.Size(244, 36);
            this._editEmplEmerPersonTB.TabIndex = 62;
            // 
            // _editEmplAddrTB
            // 
            this._editEmplAddrTB.Location = new System.Drawing.Point(150, 258);
            this._editEmplAddrTB.Name = "_editEmplAddrTB";
            this._editEmplAddrTB.ReadOnly = true;
            this._editEmplAddrTB.Size = new System.Drawing.Size(1018, 36);
            this._editEmplAddrTB.TabIndex = 61;
            // 
            // _editEmplPhoneTB
            // 
            this._editEmplPhoneTB.Location = new System.Drawing.Point(832, 190);
            this._editEmplPhoneTB.Name = "_editEmplPhoneTB";
            this._editEmplPhoneTB.ReadOnly = true;
            this._editEmplPhoneTB.Size = new System.Drawing.Size(336, 36);
            this._editEmplPhoneTB.TabIndex = 60;
            // 
            // _editEmplSsnTB
            // 
            this._editEmplSsnTB.Location = new System.Drawing.Point(108, 184);
            this._editEmplSsnTB.Name = "_editEmplSsnTB";
            this._editEmplSsnTB.ReadOnly = true;
            this._editEmplSsnTB.Size = new System.Drawing.Size(382, 36);
            this._editEmplSsnTB.TabIndex = 59;
            // 
            // _editEmplBirthDTP
            // 
            this._editEmplBirthDTP.Enabled = false;
            this._editEmplBirthDTP.Location = new System.Drawing.Point(786, 36);
            this._editEmplBirthDTP.Name = "_editEmplBirthDTP";
            this._editEmplBirthDTP.Size = new System.Drawing.Size(200, 36);
            this._editEmplBirthDTP.TabIndex = 58;
            // 
            // _editEmplNameTB
            // 
            this._editEmplNameTB.Location = new System.Drawing.Point(128, 112);
            this._editEmplNameTB.Name = "_editEmplNameTB";
            this._editEmplNameTB.ReadOnly = true;
            this._editEmplNameTB.Size = new System.Drawing.Size(360, 36);
            this._editEmplNameTB.TabIndex = 57;
            // 
            // _editEmplIDTB
            // 
            this._editEmplIDTB.Location = new System.Drawing.Point(194, 36);
            this._editEmplIDTB.Name = "_editEmplIDTB";
            this._editEmplIDTB.Size = new System.Drawing.Size(294, 36);
            this._editEmplIDTB.TabIndex = 56;
            // 
            // _editEmplPositionLB
            // 
            this._editEmplPositionLB.AutoSize = true;
            this._editEmplPositionLB.Location = new System.Drawing.Point(52, 636);
            this._editEmplPositionLB.Name = "_editEmplPositionLB";
            this._editEmplPositionLB.Size = new System.Drawing.Size(89, 24);
            this._editEmplPositionLB.TabIndex = 55;
            this._editEmplPositionLB.Text = "Position:";
            // 
            // _editEmplDeptLB
            // 
            this._editEmplDeptLB.AutoSize = true;
            this._editEmplDeptLB.Location = new System.Drawing.Point(52, 570);
            this._editEmplDeptLB.Name = "_editEmplDeptLB";
            this._editEmplDeptLB.Size = new System.Drawing.Size(122, 24);
            this._editEmplDeptLB.TabIndex = 54;
            this._editEmplDeptLB.Text = "Department:";
            // 
            // _editEmplBasicSalaryLB
            // 
            this._editEmplBasicSalaryLB.AutoSize = true;
            this._editEmplBasicSalaryLB.Location = new System.Drawing.Point(52, 708);
            this._editEmplBasicSalaryLB.Name = "_editEmplBasicSalaryLB";
            this._editEmplBasicSalaryLB.Size = new System.Drawing.Size(130, 24);
            this._editEmplBasicSalaryLB.TabIndex = 53;
            this._editEmplBasicSalaryLB.Text = "Basic Salary:";
            // 
            // _editEmplBirthLB
            // 
            this._editEmplBirthLB.AutoSize = true;
            this._editEmplBirthLB.Location = new System.Drawing.Point(674, 48);
            this._editEmplBirthLB.Name = "_editEmplBirthLB";
            this._editEmplBirthLB.Size = new System.Drawing.Size(105, 24);
            this._editEmplBirthLB.TabIndex = 52;
            this._editEmplBirthLB.Text = "Birth Day:";
            // 
            // _editEmplSpouseLB
            // 
            this._editEmplSpouseLB.AutoSize = true;
            this._editEmplSpouseLB.Location = new System.Drawing.Point(674, 496);
            this._editEmplSpouseLB.Name = "_editEmplSpouseLB";
            this._editEmplSpouseLB.Size = new System.Drawing.Size(81, 24);
            this._editEmplSpouseLB.TabIndex = 51;
            this._editEmplSpouseLB.Text = "Spouse:";
            // 
            // _editMarriedStatLB
            // 
            this._editMarriedStatLB.AutoSize = true;
            this._editMarriedStatLB.Location = new System.Drawing.Point(674, 424);
            this._editMarriedStatLB.Name = "_editMarriedStatLB";
            this._editMarriedStatLB.Size = new System.Drawing.Size(150, 24);
            this._editMarriedStatLB.TabIndex = 50;
            this._editMarriedStatLB.Text = "Married Status:";
            // 
            // _editEmplJobStatLB
            // 
            this._editEmplJobStatLB.AutoSize = true;
            this._editEmplJobStatLB.Location = new System.Drawing.Point(52, 496);
            this._editEmplJobStatLB.Name = "_editEmplJobStatLB";
            this._editEmplJobStatLB.Size = new System.Drawing.Size(108, 24);
            this._editEmplJobStatLB.TabIndex = 49;
            this._editEmplJobStatLB.Text = "Job Status:";
            // 
            // _editEmplMilitaryStatLB
            // 
            this._editEmplMilitaryStatLB.AutoSize = true;
            this._editEmplMilitaryStatLB.Location = new System.Drawing.Point(674, 336);
            this._editEmplMilitaryStatLB.Name = "_editEmplMilitaryStatLB";
            this._editEmplMilitaryStatLB.Size = new System.Drawing.Size(150, 24);
            this._editEmplMilitaryStatLB.TabIndex = 48;
            this._editEmplMilitaryStatLB.Text = "Military Status:";
            // 
            // _editEmplEmerPhone
            // 
            this._editEmplEmerPhone.AutoSize = true;
            this._editEmplEmerPhone.Location = new System.Drawing.Point(52, 424);
            this._editEmplEmerPhone.Name = "_editEmplEmerPhone";
            this._editEmplEmerPhone.Size = new System.Drawing.Size(181, 24);
            this._editEmplEmerPhone.TabIndex = 47;
            this._editEmplEmerPhone.Text = "Emergency Phone:";
            // 
            // _editEmplEmerPersonLB
            // 
            this._editEmplEmerPersonLB.AutoSize = true;
            this._editEmplEmerPersonLB.Location = new System.Drawing.Point(52, 346);
            this._editEmplEmerPersonLB.Name = "_editEmplEmerPersonLB";
            this._editEmplEmerPersonLB.Size = new System.Drawing.Size(187, 24);
            this._editEmplEmerPersonLB.TabIndex = 46;
            this._editEmplEmerPersonLB.Text = "Emergency Person:";
            // 
            // _editEmplAddrLB
            // 
            this._editEmplAddrLB.AutoSize = true;
            this._editEmplAddrLB.Location = new System.Drawing.Point(52, 270);
            this._editEmplAddrLB.Name = "_editEmplAddrLB";
            this._editEmplAddrLB.Size = new System.Drawing.Size(90, 24);
            this._editEmplAddrLB.TabIndex = 45;
            this._editEmplAddrLB.Text = "Address:";
            // 
            // _editEmplPhoneLB
            // 
            this._editEmplPhoneLB.AutoSize = true;
            this._editEmplPhoneLB.Location = new System.Drawing.Point(674, 196);
            this._editEmplPhoneLB.Name = "_editEmplPhoneLB";
            this._editEmplPhoneLB.Size = new System.Drawing.Size(152, 24);
            this._editEmplPhoneLB.TabIndex = 44;
            this._editEmplPhoneLB.Text = "Phone Number:";
            // 
            // _editEmplSexLB
            // 
            this._editEmplSexLB.AutoSize = true;
            this._editEmplSexLB.Location = new System.Drawing.Point(674, 116);
            this._editEmplSexLB.Name = "_editEmplSexLB";
            this._editEmplSexLB.Size = new System.Drawing.Size(50, 24);
            this._editEmplSexLB.TabIndex = 43;
            this._editEmplSexLB.Text = "Sex:";
            // 
            // _editEmplSsnLB
            // 
            this._editEmplSsnLB.AutoSize = true;
            this._editEmplSsnLB.Location = new System.Drawing.Point(52, 202);
            this._editEmplSsnLB.Name = "_editEmplSsnLB";
            this._editEmplSsnLB.Size = new System.Drawing.Size(49, 24);
            this._editEmplSsnLB.TabIndex = 42;
            this._editEmplSsnLB.Text = "Ssn:";
            // 
            // _editEmplNameLB
            // 
            this._editEmplNameLB.AutoSize = true;
            this._editEmplNameLB.Location = new System.Drawing.Point(52, 124);
            this._editEmplNameLB.Name = "_editEmplNameLB";
            this._editEmplNameLB.Size = new System.Drawing.Size(70, 24);
            this._editEmplNameLB.TabIndex = 41;
            this._editEmplNameLB.Text = "Name:";
            // 
            // editEmplIDLB
            // 
            this.editEmplIDLB.AutoSize = true;
            this.editEmplIDLB.Location = new System.Drawing.Point(52, 48);
            this.editEmplIDLB.Name = "editEmplIDLB";
            this.editEmplIDLB.Size = new System.Drawing.Size(137, 24);
            this.editEmplIDLB.TabIndex = 40;
            this.editEmplIDLB.Text = "Employee ID:";
            // 
            // _mainFunctionPage
            // 
            this._mainFunctionPage.Controls.Add(this._employee);
            this._mainFunctionPage.Controls.Add(this._workAttendance);
            this._mainFunctionPage.Controls.Add(this._bonus);
            this._mainFunctionPage.Controls.Add(this._salary);
            this._mainFunctionPage.Controls.Add(this._authorization);
            this._mainFunctionPage.Controls.Add(this._position);
            this._mainFunctionPage.Controls.Add(this._department);
            this._mainFunctionPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mainFunctionPage.Location = new System.Drawing.Point(12, 12);
            this._mainFunctionPage.Name = "_mainFunctionPage";
            this._mainFunctionPage.SelectedIndex = 0;
            this._mainFunctionPage.Size = new System.Drawing.Size(1592, 910);
            this._mainFunctionPage.TabIndex = 0;
            // 
            // _produceSalary
            // 
            this._produceSalary.Controls.Add(this._produceSalaryButton);
            this._produceSalary.Controls.Add(this._produceSalaryPeriodTB);
            this._produceSalary.Controls.Add(this._produceSalaryPeriod);
            this._produceSalary.Controls.Add(this._produceSalaryEndDateDTP);
            this._produceSalary.Controls.Add(this._produceSalaryEndDateLB);
            this._produceSalary.Controls.Add(this._produceSalaryStartDateDTP);
            this._produceSalary.Controls.Add(this._prodeceSalaryStartDateLB);
            this._produceSalary.Location = new System.Drawing.Point(4, 34);
            this._produceSalary.Name = "_produceSalary";
            this._produceSalary.Padding = new System.Windows.Forms.Padding(3);
            this._produceSalary.Size = new System.Drawing.Size(1564, 829);
            this._produceSalary.TabIndex = 3;
            this._produceSalary.Text = "Produce Salary";
            this._produceSalary.UseVisualStyleBackColor = true;
            // 
            // _prodeceSalaryStartDateLB
            // 
            this._prodeceSalaryStartDateLB.AutoSize = true;
            this._prodeceSalaryStartDateLB.Location = new System.Drawing.Point(87, 62);
            this._prodeceSalaryStartDateLB.Name = "_prodeceSalaryStartDateLB";
            this._prodeceSalaryStartDateLB.Size = new System.Drawing.Size(107, 24);
            this._prodeceSalaryStartDateLB.TabIndex = 0;
            this._prodeceSalaryStartDateLB.Text = "Start Date:";
            // 
            // _produceSalaryStartDateDTP
            // 
            this._produceSalaryStartDateDTP.Location = new System.Drawing.Point(201, 56);
            this._produceSalaryStartDateDTP.Name = "_produceSalaryStartDateDTP";
            this._produceSalaryStartDateDTP.Size = new System.Drawing.Size(238, 36);
            this._produceSalaryStartDateDTP.TabIndex = 1;
            // 
            // _produceSalaryEndDateLB
            // 
            this._produceSalaryEndDateLB.AutoSize = true;
            this._produceSalaryEndDateLB.Location = new System.Drawing.Point(87, 182);
            this._produceSalaryEndDateLB.Name = "_produceSalaryEndDateLB";
            this._produceSalaryEndDateLB.Size = new System.Drawing.Size(100, 24);
            this._produceSalaryEndDateLB.TabIndex = 2;
            this._produceSalaryEndDateLB.Text = "End Date:";
            // 
            // _produceSalaryEndDateDTP
            // 
            this._produceSalaryEndDateDTP.Location = new System.Drawing.Point(201, 174);
            this._produceSalaryEndDateDTP.Name = "_produceSalaryEndDateDTP";
            this._produceSalaryEndDateDTP.Size = new System.Drawing.Size(238, 36);
            this._produceSalaryEndDateDTP.TabIndex = 3;
            // 
            // _produceSalaryPeriod
            // 
            this._produceSalaryPeriod.AutoSize = true;
            this._produceSalaryPeriod.Location = new System.Drawing.Point(87, 318);
            this._produceSalaryPeriod.Name = "_produceSalaryPeriod";
            this._produceSalaryPeriod.Size = new System.Drawing.Size(75, 24);
            this._produceSalaryPeriod.TabIndex = 4;
            this._produceSalaryPeriod.Text = "Period:";
            // 
            // _produceSalaryPeriodTB
            // 
            this._produceSalaryPeriodTB.Location = new System.Drawing.Point(168, 306);
            this._produceSalaryPeriodTB.Name = "_produceSalaryPeriodTB";
            this._produceSalaryPeriodTB.Size = new System.Drawing.Size(271, 36);
            this._produceSalaryPeriodTB.TabIndex = 5;
            // 
            // _produceSalaryButton
            // 
            this._produceSalaryButton.Location = new System.Drawing.Point(469, 536);
            this._produceSalaryButton.Name = "_produceSalaryButton";
            this._produceSalaryButton.Size = new System.Drawing.Size(109, 49);
            this._produceSalaryButton.TabIndex = 6;
            this._produceSalaryButton.Text = "Produce";
            this._produceSalaryButton.UseVisualStyleBackColor = true;
            this._produceSalaryButton.Click += new System.EventHandler(this.ClickProduceSalaryButton);
            // 
            // _mainFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 952);
            this.Controls.Add(this._logoutButton);
            this.Controls.Add(this._mainFunctionPage);
            this.Name = "_mainFunction";
            this.Text = "MainFunction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseMainFunction);
            this.Load += new System.EventHandler(this.LoadMainFunction);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusdefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDefDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authoDataSet)).EndInit();
            this._department.ResumeLayout(false);
            this._departmentPage.ResumeLayout(false);
            this._newDepartment.ResumeLayout(false);
            this._newDepartment.PerformLayout();
            this._editDepartment.ResumeLayout(false);
            this._editDepartment.PerformLayout();
            this._position.ResumeLayout(false);
            this._positionPage.ResumeLayout(false);
            this._addPosition.ResumeLayout(false);
            this._addPosition.PerformLayout();
            this._editPosition.ResumeLayout(false);
            this._editPosition.PerformLayout();
            this._authorization.ResumeLayout(false);
            this._authorizationPage.ResumeLayout(false);
            this._newAuthorization.ResumeLayout(false);
            this._newAuthorization.PerformLayout();
            this._editAuthorization.ResumeLayout(false);
            this._editAuthorization.PerformLayout();
            this._salary.ResumeLayout(false);
            this._salaryPage.ResumeLayout(false);
            this._addpayMethod.ResumeLayout(false);
            this._addpayMethod.PerformLayout();
            this._editPayMethod.ResumeLayout(false);
            this._editPayMethod.PerformLayout();
            this._bonus.ResumeLayout(false);
            this._bonusPage.ResumeLayout(false);
            this._addBonusDef.ResumeLayout(false);
            this._addBonusDef.PerformLayout();
            this._editBonusDef.ResumeLayout(false);
            this._editBonusDef.PerformLayout();
            this._addBonusTLB.ResumeLayout(false);
            this._addBonusTLB.PerformLayout();
            this._emplBonusSearch.ResumeLayout(false);
            this._emplBonusSearch.PerformLayout();
            this._bonusEmplIDSearchToolStrip.ResumeLayout(false);
            this._bonusEmplIDSearchToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bonusDataGridView)).EndInit();
            this._workAttendance.ResumeLayout(false);
            this._workAttendancePage.ResumeLayout(false);
            this._addWorkAttendance.ResumeLayout(false);
            this._addWorkAttendance.PerformLayout();
            this._editWorkAttendance.ResumeLayout(false);
            this._editWorkAttendance.PerformLayout();
            this._employee.ResumeLayout(false);
            this._employeePage.ResumeLayout(false);
            this._newEmployee.ResumeLayout(false);
            this._newEmployee.PerformLayout();
            this._editEmployee.ResumeLayout(false);
            this._editEmployee.PerformLayout();
            this._mainFunctionPage.ResumeLayout(false);
            this._produceSalary.ResumeLayout(false);
            this._produceSalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _logoutButton;
        private deptDataSet deptDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private deptDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private positionDataSet positionDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private positionDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private authoDataSet authoDataSet;
        private System.Windows.Forms.BindingSource authorizationBindingSource;
        private authoDataSetTableAdapters.authorizationTableAdapter authorizationTableAdapter;
        private bonusDefDataSet bonusDefDataSet;
        private System.Windows.Forms.BindingSource bonusdefBindingSource;
        private bonusDefDataSetTableAdapters.bonusdefTableAdapter bonusdefTableAdapter;
        private bonusDataSet bonusDataSet;
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private bonusDataSetTableAdapters.bonusTableAdapter bonusTableAdapter;
        private System.Windows.Forms.TabPage _department;
        private System.Windows.Forms.TabControl _departmentPage;
        private System.Windows.Forms.TabPage _newDepartment;
        private System.Windows.Forms.Button _insertDeptButton;
        private System.Windows.Forms.DateTimePicker _newDeptTimeDP;
        private System.Windows.Forms.TextBox _newDeptManTB;
        private System.Windows.Forms.TextBox _newDeptNameTB;
        private System.Windows.Forms.TextBox _newDeptIDTB;
        private System.Windows.Forms.Label _newDeptManLB;
        private System.Windows.Forms.Label _newDeptStartTimeLB;
        private System.Windows.Forms.Label _newDeptNameLB;
        private System.Windows.Forms.Label _newDeptIDLB;
        private System.Windows.Forms.TabPage _editDepartment;
        private System.Windows.Forms.DateTimePicker _editDeptEndTimeDefDP;
        private System.Windows.Forms.Button _editDeptButton;
        private System.Windows.Forms.Button _searchDeptButton;
        private System.Windows.Forms.ComboBox _editDeptCheckCB;
        private System.Windows.Forms.DateTimePicker _editDeptEndTimeDP;
        private System.Windows.Forms.DateTimePicker _editDeptStartTimeDP;
        private System.Windows.Forms.TextBox _editDeptManTB;
        private System.Windows.Forms.TextBox _editDeptNameTB;
        private System.Windows.Forms.TextBox _editDeptIDTB;
        private System.Windows.Forms.Label _editDeptManLB;
        private System.Windows.Forms.Label _editDeptEndTimeLB;
        private System.Windows.Forms.Label _editDeptCheckLB;
        private System.Windows.Forms.Label _editDeptStartTimeLB;
        private System.Windows.Forms.Label _editDeptNameLB;
        private System.Windows.Forms.Label _editDeptIDLB;
        private System.Windows.Forms.TabPage _position;
        private System.Windows.Forms.TabControl _positionPage;
        private System.Windows.Forms.TabPage _addPosition;
        private System.Windows.Forms.Button _addPositionButton;
        private System.Windows.Forms.TextBox _addPositionIDTB;
        private System.Windows.Forms.TextBox _addPositionNameTB;
        private System.Windows.Forms.TextBox _addPositionBSTB;
        private System.Windows.Forms.ComboBox _addPositionAuthoCB;
        private System.Windows.Forms.Label _addPositionAuthoLB;
        private System.Windows.Forms.Label _addPositionBSLB;
        private System.Windows.Forms.Label _addPositionNameLB;
        private System.Windows.Forms.Label _addPositionIDLB;
        private System.Windows.Forms.TabPage _editPosition;
        private System.Windows.Forms.Button _editPositionButton;
        private System.Windows.Forms.Button _searchPositionButton;
        private System.Windows.Forms.TextBox _editPositionIDTB;
        private System.Windows.Forms.TextBox _editPositionNameTB;
        private System.Windows.Forms.TextBox _editPositionBSTB;
        private System.Windows.Forms.ComboBox _editPositionAuthoCB;
        private System.Windows.Forms.Label _editPositionAuthoLB;
        private System.Windows.Forms.Label _editPositionBSLB;
        private System.Windows.Forms.Label _editPositionNameLB;
        private System.Windows.Forms.Label _editPositionIDLB;
        private System.Windows.Forms.TabPage _authorization;
        private System.Windows.Forms.TabControl _authorizationPage;
        private System.Windows.Forms.TabPage _newAuthorization;
        private System.Windows.Forms.Button _insertAuthoButton;
        private System.Windows.Forms.ComboBox _newAuthoLevelCB;
        private System.Windows.Forms.TextBox _newAuthoNameTB;
        private System.Windows.Forms.TextBox _newAuthoIDTB;
        private System.Windows.Forms.Label _newAuthoLevelLB;
        private System.Windows.Forms.Label _newAuthoNameLB;
        private System.Windows.Forms.Label _newAuthoIDLB;
        private System.Windows.Forms.TabPage _editAuthorization;
        private System.Windows.Forms.Button _editAuthoButton;
        private System.Windows.Forms.Button _searchAuthoButton;
        private System.Windows.Forms.ComboBox _editAuthoLevelCB;
        private System.Windows.Forms.TextBox _editAuthoNameTB;
        private System.Windows.Forms.TextBox _editAuthoIDTB;
        private System.Windows.Forms.Label _editAuthoLevelLB;
        private System.Windows.Forms.Label _editAuthoNameLB;
        private System.Windows.Forms.Label _editAuthoIDLB;
        private System.Windows.Forms.TabPage _salary;
        private System.Windows.Forms.TabPage _bonus;
        private System.Windows.Forms.TabControl _bonusPage;
        private System.Windows.Forms.TabPage _addBonusDef;
        private System.Windows.Forms.Button _addBonusDefButton;
        private System.Windows.Forms.TextBox _addBonusDefAmountTB;
        private System.Windows.Forms.Label _addBonusDefAmountLB;
        private System.Windows.Forms.DateTimePicker _addBonusDefEffiDateDTP;
        private System.Windows.Forms.Label _addBonusDefEffiDateLB;
        private System.Windows.Forms.DateTimePicker _addBonusDefCreateDateDTP;
        private System.Windows.Forms.Label _addBonusDefCreateDateLB;
        private System.Windows.Forms.TextBox _addBonusDefDescTB;
        private System.Windows.Forms.Label _addBonusDefDescLB;
        private System.Windows.Forms.TextBox _addBonusNameTB;
        private System.Windows.Forms.Label _addBonusDefNameLB;
        private System.Windows.Forms.TextBox _addBonusDefIDTB;
        private System.Windows.Forms.Label _addBonusDefIDLB;
        private System.Windows.Forms.TabPage _editBonusDef;
        private System.Windows.Forms.Button _editBonusDefButton;
        private System.Windows.Forms.Button _searchBonusDefButton;
        private System.Windows.Forms.TextBox _editBonusDefAmountTB;
        private System.Windows.Forms.Label _editBonusDefAmountLB;
        private System.Windows.Forms.DateTimePicker _editBonusDefEffiDateDTP;
        private System.Windows.Forms.Label _editBonusDefEffiDateLB;
        private System.Windows.Forms.DateTimePicker _editBonusDefCreateDateDTP;
        private System.Windows.Forms.Label _editBonusDefCreateDateLB;
        private System.Windows.Forms.TextBox _editBonusDefDescTB;
        private System.Windows.Forms.Label _editBonusDefDescLB;
        private System.Windows.Forms.TextBox _editBonusDefNameTB;
        private System.Windows.Forms.Label _editBonusDefNameLB;
        private System.Windows.Forms.TextBox _editBonusDefIDTB;
        private System.Windows.Forms.Label _editBonusDefIDLB;
        private System.Windows.Forms.TabPage _addBonusTLB;
        private System.Windows.Forms.TextBox _addbonusPeriodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _addBonusButton;
        private System.Windows.Forms.DateTimePicker _addBonusDateDTP;
        private System.Windows.Forms.Label _addBonusDateLB;
        private System.Windows.Forms.TextBox _addBonusEmplIDTB;
        private System.Windows.Forms.Label _addBonusEmplID;
        private System.Windows.Forms.ComboBox _addBonusCB;
        private System.Windows.Forms.Label _addBonusNameLB;
        private System.Windows.Forms.TabPage _emplBonusSearch;
        private System.Windows.Forms.ToolStrip _bonusEmplIDSearchToolStrip;
        private System.Windows.Forms.ToolStripLabel _emplIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emplIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton _fillToolStripButton;
        private System.Windows.Forms.DataGridView _bonusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusTDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage _workAttendance;
        private System.Windows.Forms.TabControl _workAttendancePage;
        private System.Windows.Forms.TabPage _addWorkAttendance;
        private System.Windows.Forms.Button _addWAButton;
        private System.Windows.Forms.DateTimePicker _addWAEndOTDTP;
        private System.Windows.Forms.Label _addWAEndOverTimeLB;
        private System.Windows.Forms.DateTimePicker _addWAStartOTDTP;
        private System.Windows.Forms.Label _addWAStartOverTimeLB;
        private System.Windows.Forms.ComboBox _addWAIsOvertimeCB;
        private System.Windows.Forms.Label _addWAIsOvertime;
        private System.Windows.Forms.DateTimePicker _addWAEndWTDTP;
        private System.Windows.Forms.Label _addWAEndWTLB;
        private System.Windows.Forms.DateTimePicker _addWAStartWTDTP;
        private System.Windows.Forms.Label _addWAStartWTLB;
        private System.Windows.Forms.ComboBox _addWAWorkStatusCB;
        private System.Windows.Forms.Label _addWAStatusLB;
        private System.Windows.Forms.DateTimePicker _addWADateDTP;
        private System.Windows.Forms.Label _addWADate;
        private System.Windows.Forms.TextBox _addWAEmplIDTB;
        private System.Windows.Forms.Label _addWAEmplIDLB;
        private System.Windows.Forms.TabPage _editWorkAttendance;
        private System.Windows.Forms.Button _editWAButton;
        private System.Windows.Forms.Button _searchWAButton;
        private System.Windows.Forms.DateTimePicker _editWAEndOTDTP;
        private System.Windows.Forms.Label _editWAEndOTLB;
        private System.Windows.Forms.DateTimePicker _editWAStartOTDTP;
        private System.Windows.Forms.Label _editWAStartOTLB;
        private System.Windows.Forms.ComboBox _editWAIsOvertimeCB;
        private System.Windows.Forms.Label _editWAIsOvertimeLB;
        private System.Windows.Forms.DateTimePicker _editWAEndWTDTP;
        private System.Windows.Forms.Label _editWAEndWTLB;
        private System.Windows.Forms.DateTimePicker _editWAStartWTDTP;
        private System.Windows.Forms.Label _editWAStartWTLB;
        private System.Windows.Forms.ComboBox _editWAStatusCB;
        private System.Windows.Forms.Label _editWAWorkStatusLB;
        private System.Windows.Forms.DateTimePicker _editWADateDTP;
        private System.Windows.Forms.Label _editWADateLB;
        private System.Windows.Forms.TextBox _editWAEmplIDTB;
        private System.Windows.Forms.Label _editWAEmplIDLB;
        private System.Windows.Forms.TabPage _employee;
        private System.Windows.Forms.TabControl _employeePage;
        private System.Windows.Forms.TabPage _newEmployee;
        private System.Windows.Forms.TextBox _addEmplLoginPWTB;
        private System.Windows.Forms.Label _addEmplLoginPWLB;
        private System.Windows.Forms.ComboBox _newEmplPositionCB;
        private System.Windows.Forms.ComboBox _newEmplSexCB;
        private System.Windows.Forms.Button _insertEmplButton;
        private System.Windows.Forms.ComboBox _newEmplBloodCB;
        private System.Windows.Forms.Label _newEmplBloodLB;
        private System.Windows.Forms.ComboBox _newEmplDeptCB;
        private System.Windows.Forms.TextBox _newEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _newEmplJobStatCB;
        private System.Windows.Forms.TextBox _newEmplSpouseTB;
        private System.Windows.Forms.ComboBox _newEmplMarriedStatCB;
        private System.Windows.Forms.ComboBox _newEmplMilitaryStatCB;
        private System.Windows.Forms.TextBox _newEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _newEmplEmerPersonTB;
        private System.Windows.Forms.TextBox _newEmplAddrTB;
        private System.Windows.Forms.TextBox _newEmplPhoneTB;
        private System.Windows.Forms.TextBox _newEmpllSsnTB;
        private System.Windows.Forms.DateTimePicker _newEmplBirthDP;
        private System.Windows.Forms.TextBox _newEmplNameTB;
        private System.Windows.Forms.TextBox _newEmplIDTB;
        private System.Windows.Forms.Label _newEmplPositionIDLB;
        private System.Windows.Forms.Label _newEmplDeptIDLB;
        private System.Windows.Forms.Label _newEmplBasicSalaryLB;
        private System.Windows.Forms.Label _newEmplBirthLB;
        private System.Windows.Forms.Label _newEmplSpouseLB;
        private System.Windows.Forms.Label _newEmplMarriedStatLB;
        private System.Windows.Forms.Label _newEmplJobStatLB;
        private System.Windows.Forms.Label _newEmplMilitaryLB;
        private System.Windows.Forms.Label _newEmplEmerPhoneLB;
        private System.Windows.Forms.Label _newEmplEmerPersonLB;
        private System.Windows.Forms.Label _newEmplAddrLB;
        private System.Windows.Forms.Label _newEmplPhoneLB;
        private System.Windows.Forms.Label _newEmplSexLB;
        private System.Windows.Forms.Label _newEmplSsnLB;
        private System.Windows.Forms.Label _newEmplNameLB;
        private System.Windows.Forms.Label _newEmplIDLB;
        private System.Windows.Forms.TabPage _editEmployee;
        private System.Windows.Forms.Button _searchEmplButtom;
        private System.Windows.Forms.ComboBox _editEmplPositionCB;
        private System.Windows.Forms.ComboBox _editEmplSexCB;
        private System.Windows.Forms.Button _editEmplButton;
        private System.Windows.Forms.ComboBox _editEmplBloodCB;
        private System.Windows.Forms.Label _editEmplBloodLB;
        private System.Windows.Forms.ComboBox _editEmplDeptCB;
        private System.Windows.Forms.TextBox _editEmplBasicSalaryTB;
        private System.Windows.Forms.ComboBox _editEmplJobStatCB;
        private System.Windows.Forms.TextBox _editEmplSpouseTB;
        private System.Windows.Forms.ComboBox _editEmplMarriedStatCB;
        private System.Windows.Forms.ComboBox _editEmplMilitaryStatCB;
        private System.Windows.Forms.TextBox _editEmplEmerPhoneTB;
        private System.Windows.Forms.TextBox _editEmplEmerPersonTB;
        private System.Windows.Forms.TextBox _editEmplAddrTB;
        private System.Windows.Forms.TextBox _editEmplPhoneTB;
        private System.Windows.Forms.TextBox _editEmplSsnTB;
        private System.Windows.Forms.DateTimePicker _editEmplBirthDTP;
        private System.Windows.Forms.TextBox _editEmplNameTB;
        private System.Windows.Forms.TextBox _editEmplIDTB;
        private System.Windows.Forms.Label _editEmplPositionLB;
        private System.Windows.Forms.Label _editEmplDeptLB;
        private System.Windows.Forms.Label _editEmplBasicSalaryLB;
        private System.Windows.Forms.Label _editEmplBirthLB;
        private System.Windows.Forms.Label _editEmplSpouseLB;
        private System.Windows.Forms.Label _editMarriedStatLB;
        private System.Windows.Forms.Label _editEmplJobStatLB;
        private System.Windows.Forms.Label _editEmplMilitaryStatLB;
        private System.Windows.Forms.Label _editEmplEmerPhone;
        private System.Windows.Forms.Label _editEmplEmerPersonLB;
        private System.Windows.Forms.Label _editEmplAddrLB;
        private System.Windows.Forms.Label _editEmplPhoneLB;
        private System.Windows.Forms.Label _editEmplSexLB;
        private System.Windows.Forms.Label _editEmplSsnLB;
        private System.Windows.Forms.Label _editEmplNameLB;
        private System.Windows.Forms.Label editEmplIDLB;
        private System.Windows.Forms.TabPage _addpayMethod;
        private System.Windows.Forms.TabPage _editPayMethod;
        private System.Windows.Forms.Button _addPaywayButton;
        private System.Windows.Forms.ComboBox _addPaywayMethodCB;
        private System.Windows.Forms.TextBox _addPaywayAccountTB;
        private System.Windows.Forms.TextBox _addPaywayEmplIDTB;
        private System.Windows.Forms.Label _addpaywayAccountLB;
        private System.Windows.Forms.Label _addPaywayMethodLB;
        private System.Windows.Forms.Label _addPaywayEmplIDLB;
        private System.Windows.Forms.Button _paywayEditButton;
        private System.Windows.Forms.Button _paywaySearchButton;
        private System.Windows.Forms.ComboBox _editPaywayMethodCB;
        private System.Windows.Forms.TextBox _editPaywayAccountTB;
        private System.Windows.Forms.TextBox _editPaywayEmplIDTB;
        private System.Windows.Forms.Label _editPaywayAccountLB;
        private System.Windows.Forms.Label _editPaywayMethodLB;
        private System.Windows.Forms.Label _editPaywayEmplIDLB;
        private System.Windows.Forms.TabControl _mainFunctionPage;
        private System.Windows.Forms.TabControl _salaryPage;
        private System.Windows.Forms.TabPage _produceSalary;
        private System.Windows.Forms.DateTimePicker _produceSalaryStartDateDTP;
        private System.Windows.Forms.Label _prodeceSalaryStartDateLB;
        private System.Windows.Forms.Label _produceSalaryEndDateLB;
        private System.Windows.Forms.DateTimePicker _produceSalaryEndDateDTP;
        private System.Windows.Forms.Label _produceSalaryPeriod;
        private System.Windows.Forms.TextBox _produceSalaryPeriodTB;
        private System.Windows.Forms.Button _produceSalaryButton;
    }
}