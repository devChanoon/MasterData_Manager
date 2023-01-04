namespace MasterData_Manager
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_DBName = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_DBAddress = new System.Windows.Forms.TextBox();
            this.cbe_ViewPassword = new DevExpress.XtraEditors.CheckButton();
            this.sb_Connect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tc_Step = new DevExpress.XtraTab.XtraTabControl();
            this.tp_Step1 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Step1 = new DevExpress.XtraGrid.GridControl();
            this.gv_Step1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_step1_SP_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_step1_SP_Content = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Step1_Top = new System.Windows.Forms.Panel();
            this.te_Step1_Prev_DB_Name = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sb_Step1_Search = new DevExpress.XtraEditors.SimpleButton();
            this.tp_Step2 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Step2 = new DevExpress.XtraGrid.GridControl();
            this.gv_Step2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_step2_Parameter_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_step2_Parameter_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_step2_Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Step2_Top = new System.Windows.Forms.Panel();
            this.sb_Step2_Search = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Step2_Save = new DevExpress.XtraEditors.SimpleButton();
            this.tp_Step3 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Step3 = new DevExpress.XtraGrid.GridControl();
            this.gv_Step3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_step3_Check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.r_ce_step3_Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gc_step3_Table_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_step3_Condition_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_step3_Condition_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Step3_Top = new System.Windows.Forms.Panel();
            this.sb_Step3_UncheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Step3_CheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.tlp_Step3_Checked_Count = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lc_Step3_Checked_Count = new DevExpress.XtraEditors.LabelControl();
            this.sb_Step3_Search = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Step3_Execute = new DevExpress.XtraEditors.SimpleButton();
            this.lc_Message = new DevExpress.XtraEditors.LabelControl();
            this.tlp_Step = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Step4 = new DevExpress.XtraEditors.CheckButton();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.cb_Step3 = new DevExpress.XtraEditors.CheckButton();
            this.cb_Step2 = new DevExpress.XtraEditors.CheckButton();
            this.cb_Step1 = new DevExpress.XtraEditors.CheckButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlp_Main.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Step)).BeginInit();
            this.tc_Step.SuspendLayout();
            this.tp_Step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step1)).BeginInit();
            this.pnl_Step1_Top.SuspendLayout();
            this.tp_Step2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step2)).BeginInit();
            this.pnl_Step2_Top.SuspendLayout();
            this.tp_Step3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_step3_Check)).BeginInit();
            this.pnl_Step3_Top.SuspendLayout();
            this.tlp_Step3_Checked_Count.SuspendLayout();
            this.tlp_Step.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.tlp_Main.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.tb_DBName);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.tb_DBAddress);
            this.groupBox1.Controls.Add(this.cbe_ViewPassword);
            this.groupBox1.Controls.Add(this.sb_Connect);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Information";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(538, 49);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(193, 23);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.Text = "!1Tascorp";
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DB_Information_KeyDown);
            // 
            // tb_DBName
            // 
            this.tb_DBName.Location = new System.Drawing.Point(538, 20);
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(220, 23);
            this.tb_DBName.TabIndex = 1;
            this.tb_DBName.Text = "RTEGMS_NATUREFARM";
            this.tb_DBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DBName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DB_Information_KeyDown);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(169, 49);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(238, 23);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.Text = "sa";
            this.tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DB_Information_KeyDown);
            // 
            // tb_DBAddress
            // 
            this.tb_DBAddress.Location = new System.Drawing.Point(169, 20);
            this.tb_DBAddress.Name = "tb_DBAddress";
            this.tb_DBAddress.Size = new System.Drawing.Size(238, 23);
            this.tb_DBAddress.TabIndex = 0;
            this.tb_DBAddress.Text = "sf.tascorp.co.kr";
            this.tb_DBAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_DBAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DB_Information_KeyDown);
            // 
            // cbe_ViewPassword
            // 
            this.cbe_ViewPassword.AllowFocus = false;
            this.cbe_ViewPassword.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbe_ViewPassword.AppearancePressed.Options.UseBackColor = true;
            this.cbe_ViewPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbe_ViewPassword.ImageOptions.Image")));
            this.cbe_ViewPassword.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cbe_ViewPassword.Location = new System.Drawing.Point(730, 49);
            this.cbe_ViewPassword.Name = "cbe_ViewPassword";
            this.cbe_ViewPassword.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cbe_ViewPassword.Size = new System.Drawing.Size(28, 23);
            this.cbe_ViewPassword.TabIndex = 9;
            this.cbe_ViewPassword.CheckedChanged += new System.EventHandler(this.cbe_ViewPassword_CheckedChanged);
            // 
            // sb_Connect
            // 
            this.sb_Connect.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Connect.Appearance.Options.UseFont = true;
            this.sb_Connect.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Connect.Location = new System.Drawing.Point(829, 20);
            this.sb_Connect.Name = "sb_Connect";
            this.sb_Connect.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Connect.Size = new System.Drawing.Size(124, 53);
            this.sb_Connect.TabIndex = 5;
            this.sb_Connect.Text = "CONNECT";
            this.sb_Connect.Click += new System.EventHandler(this.sb_Connect_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(90, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "ID";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(470, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(470, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "DB Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(90, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DB Address";
            // 
            // tb_log
            // 
            this.tb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_log.Location = new System.Drawing.Point(3, 19);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(298, 603);
            this.tb_log.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_log);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(697, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 625);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tlp_Main.Controls.Add(this.groupBox2, 1, 1);
            this.tlp_Main.Controls.Add(this.groupBox1, 0, 0);
            this.tlp_Main.Controls.Add(this.groupBox3, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(1004, 721);
            this.tlp_Main.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tc_Step);
            this.groupBox3.Controls.Add(this.lc_Message);
            this.groupBox3.Controls.Add(this.tlp_Step);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(3, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 625);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // tc_Step
            // 
            this.tc_Step.Appearance.BackColor = System.Drawing.Color.White;
            this.tc_Step.Appearance.BackColor2 = System.Drawing.Color.White;
            this.tc_Step.Appearance.BorderColor = System.Drawing.Color.White;
            this.tc_Step.Appearance.Options.UseBackColor = true;
            this.tc_Step.Appearance.Options.UseBorderColor = true;
            this.tc_Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Step.Location = new System.Drawing.Point(3, 99);
            this.tc_Step.Name = "tc_Step";
            this.tc_Step.SelectedTabPage = this.tp_Step1;
            this.tc_Step.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tc_Step.Size = new System.Drawing.Size(682, 523);
            this.tc_Step.TabIndex = 2;
            this.tc_Step.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_Step1,
            this.tp_Step2,
            this.tp_Step3});
            // 
            // tp_Step1
            // 
            this.tp_Step1.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.tp_Step1.Appearance.PageClient.BorderColor = System.Drawing.Color.White;
            this.tp_Step1.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Step1.Appearance.PageClient.Options.UseBorderColor = true;
            this.tp_Step1.Controls.Add(this.gc_Step1);
            this.tp_Step1.Controls.Add(this.pnl_Step1_Top);
            this.tp_Step1.Name = "tp_Step1";
            this.tp_Step1.Size = new System.Drawing.Size(680, 521);
            this.tp_Step1.Text = "Step1";
            // 
            // gc_Step1
            // 
            this.gc_Step1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Step1.Location = new System.Drawing.Point(0, 44);
            this.gc_Step1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Step1.MainView = this.gv_Step1;
            this.gc_Step1.Name = "gc_Step1";
            this.gc_Step1.Size = new System.Drawing.Size(680, 477);
            this.gc_Step1.TabIndex = 1;
            this.gc_Step1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Step1});
            // 
            // gv_Step1
            // 
            this.gv_Step1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Step1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Step1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Step1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Step1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Step1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Step1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Step1.Appearance.Row.Options.UseForeColor = true;
            this.gv_Step1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Step1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Step1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_step1_SP_Name,
            this.gc_step1_SP_Content});
            this.gv_Step1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Step1.GridControl = this.gc_Step1;
            this.gv_Step1.Name = "gv_Step1";
            this.gv_Step1.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Step1.OptionsView.ShowGroupPanel = false;
            this.gv_Step1.OptionsView.ShowIndicator = false;
            this.gv_Step1.RowHeight = 25;
            // 
            // gc_step1_SP_Name
            // 
            this.gc_step1_SP_Name.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step1_SP_Name.AppearanceCell.Options.UseFont = true;
            this.gc_step1_SP_Name.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step1_SP_Name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step1_SP_Name.AppearanceHeader.Options.UseFont = true;
            this.gc_step1_SP_Name.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step1_SP_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step1_SP_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step1_SP_Name.Caption = "프로시저 명";
            this.gc_step1_SP_Name.FieldName = "SP_Name";
            this.gc_step1_SP_Name.Name = "gc_step1_SP_Name";
            this.gc_step1_SP_Name.OptionsColumn.AllowEdit = false;
            this.gc_step1_SP_Name.OptionsColumn.AllowFocus = false;
            this.gc_step1_SP_Name.OptionsFilter.AllowAutoFilter = false;
            this.gc_step1_SP_Name.OptionsFilter.AllowFilter = false;
            this.gc_step1_SP_Name.Visible = true;
            this.gc_step1_SP_Name.VisibleIndex = 0;
            this.gc_step1_SP_Name.Width = 210;
            // 
            // gc_step1_SP_Content
            // 
            this.gc_step1_SP_Content.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step1_SP_Content.AppearanceCell.Options.UseFont = true;
            this.gc_step1_SP_Content.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step1_SP_Content.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step1_SP_Content.AppearanceHeader.Options.UseFont = true;
            this.gc_step1_SP_Content.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step1_SP_Content.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step1_SP_Content.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step1_SP_Content.Caption = "프로시저 내용";
            this.gc_step1_SP_Content.FieldName = "SP_Content";
            this.gc_step1_SP_Content.Name = "gc_step1_SP_Content";
            this.gc_step1_SP_Content.OptionsColumn.AllowEdit = false;
            this.gc_step1_SP_Content.OptionsColumn.AllowFocus = false;
            this.gc_step1_SP_Content.OptionsFilter.AllowAutoFilter = false;
            this.gc_step1_SP_Content.OptionsFilter.AllowFilter = false;
            this.gc_step1_SP_Content.Visible = true;
            this.gc_step1_SP_Content.VisibleIndex = 1;
            this.gc_step1_SP_Content.Width = 468;
            // 
            // pnl_Step1_Top
            // 
            this.pnl_Step1_Top.BackColor = System.Drawing.Color.White;
            this.pnl_Step1_Top.Controls.Add(this.te_Step1_Prev_DB_Name);
            this.pnl_Step1_Top.Controls.Add(this.labelControl5);
            this.pnl_Step1_Top.Controls.Add(this.sb_Step1_Search);
            this.pnl_Step1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Step1_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Step1_Top.Name = "pnl_Step1_Top";
            this.pnl_Step1_Top.Size = new System.Drawing.Size(680, 44);
            this.pnl_Step1_Top.TabIndex = 0;
            // 
            // te_Step1_Prev_DB_Name
            // 
            this.te_Step1_Prev_DB_Name.Location = new System.Drawing.Point(90, 12);
            this.te_Step1_Prev_DB_Name.Name = "te_Step1_Prev_DB_Name";
            this.te_Step1_Prev_DB_Name.Size = new System.Drawing.Size(238, 22);
            this.te_Step1_Prev_DB_Name.TabIndex = 7;
            this.te_Step1_Prev_DB_Name.Text = "RTEGMS_AOS";
            this.te_Step1_Prev_DB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(16, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 15);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "기존 DB명";
            // 
            // sb_Step1_Search
            // 
            this.sb_Step1_Search.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Step1_Search.Appearance.Options.UseFont = true;
            this.sb_Step1_Search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step1_Search.Location = new System.Drawing.Point(551, 5);
            this.sb_Step1_Search.Name = "sb_Step1_Search";
            this.sb_Step1_Search.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step1_Search.Size = new System.Drawing.Size(124, 34);
            this.sb_Step1_Search.TabIndex = 6;
            this.sb_Step1_Search.Text = "SEARCH";
            this.sb_Step1_Search.Click += new System.EventHandler(this.sb_Search_Click);
            // 
            // tp_Step2
            // 
            this.tp_Step2.Controls.Add(this.gc_Step2);
            this.tp_Step2.Controls.Add(this.pnl_Step2_Top);
            this.tp_Step2.Name = "tp_Step2";
            this.tp_Step2.Size = new System.Drawing.Size(680, 521);
            this.tp_Step2.Text = "tp_Step2";
            // 
            // gc_Step2
            // 
            this.gc_Step2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Step2.Location = new System.Drawing.Point(0, 44);
            this.gc_Step2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Step2.MainView = this.gv_Step2;
            this.gc_Step2.Name = "gc_Step2";
            this.gc_Step2.Size = new System.Drawing.Size(680, 477);
            this.gc_Step2.TabIndex = 3;
            this.gc_Step2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Step2});
            // 
            // gv_Step2
            // 
            this.gv_Step2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Step2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Step2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_Step2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Step2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_Step2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Step2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Step2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Step2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Step2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Step2.Appearance.Row.Options.UseForeColor = true;
            this.gv_Step2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Step2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Step2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_step2_Parameter_Code,
            this.gc_step2_Parameter_Value,
            this.gc_step2_Remark});
            this.gv_Step2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Step2.GridControl = this.gc_Step2;
            this.gv_Step2.Name = "gv_Step2";
            this.gv_Step2.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Step2.OptionsView.ShowGroupPanel = false;
            this.gv_Step2.OptionsView.ShowIndicator = false;
            this.gv_Step2.RowHeight = 25;
            // 
            // gc_step2_Parameter_Code
            // 
            this.gc_step2_Parameter_Code.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step2_Parameter_Code.AppearanceCell.Options.UseFont = true;
            this.gc_step2_Parameter_Code.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step2_Parameter_Code.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step2_Parameter_Code.AppearanceHeader.Options.UseFont = true;
            this.gc_step2_Parameter_Code.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step2_Parameter_Code.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step2_Parameter_Code.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step2_Parameter_Code.Caption = "파라미터 코드";
            this.gc_step2_Parameter_Code.FieldName = "parameter_code";
            this.gc_step2_Parameter_Code.Name = "gc_step2_Parameter_Code";
            this.gc_step2_Parameter_Code.OptionsColumn.AllowEdit = false;
            this.gc_step2_Parameter_Code.OptionsColumn.AllowFocus = false;
            this.gc_step2_Parameter_Code.OptionsFilter.AllowAutoFilter = false;
            this.gc_step2_Parameter_Code.OptionsFilter.AllowFilter = false;
            this.gc_step2_Parameter_Code.Visible = true;
            this.gc_step2_Parameter_Code.VisibleIndex = 0;
            this.gc_step2_Parameter_Code.Width = 189;
            // 
            // gc_step2_Parameter_Value
            // 
            this.gc_step2_Parameter_Value.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step2_Parameter_Value.AppearanceCell.Options.UseFont = true;
            this.gc_step2_Parameter_Value.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step2_Parameter_Value.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step2_Parameter_Value.AppearanceHeader.Options.UseFont = true;
            this.gc_step2_Parameter_Value.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step2_Parameter_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step2_Parameter_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step2_Parameter_Value.Caption = "파라미터 값";
            this.gc_step2_Parameter_Value.FieldName = "parameter_value";
            this.gc_step2_Parameter_Value.Name = "gc_step2_Parameter_Value";
            this.gc_step2_Parameter_Value.OptionsFilter.AllowAutoFilter = false;
            this.gc_step2_Parameter_Value.OptionsFilter.AllowFilter = false;
            this.gc_step2_Parameter_Value.Visible = true;
            this.gc_step2_Parameter_Value.VisibleIndex = 1;
            this.gc_step2_Parameter_Value.Width = 132;
            // 
            // gc_step2_Remark
            // 
            this.gc_step2_Remark.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_step2_Remark.AppearanceCell.Options.UseFont = true;
            this.gc_step2_Remark.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gc_step2_Remark.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step2_Remark.AppearanceHeader.Options.UseFont = true;
            this.gc_step2_Remark.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step2_Remark.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step2_Remark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step2_Remark.Caption = "설명";
            this.gc_step2_Remark.FieldName = "remark";
            this.gc_step2_Remark.Name = "gc_step2_Remark";
            this.gc_step2_Remark.OptionsColumn.AllowEdit = false;
            this.gc_step2_Remark.OptionsColumn.AllowFocus = false;
            this.gc_step2_Remark.OptionsFilter.AllowAutoFilter = false;
            this.gc_step2_Remark.OptionsFilter.AllowFilter = false;
            this.gc_step2_Remark.Visible = true;
            this.gc_step2_Remark.VisibleIndex = 2;
            this.gc_step2_Remark.Width = 357;
            // 
            // pnl_Step2_Top
            // 
            this.pnl_Step2_Top.BackColor = System.Drawing.Color.White;
            this.pnl_Step2_Top.Controls.Add(this.sb_Step2_Search);
            this.pnl_Step2_Top.Controls.Add(this.sb_Step2_Save);
            this.pnl_Step2_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Step2_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Step2_Top.Name = "pnl_Step2_Top";
            this.pnl_Step2_Top.Size = new System.Drawing.Size(680, 44);
            this.pnl_Step2_Top.TabIndex = 2;
            // 
            // sb_Step2_Search
            // 
            this.sb_Step2_Search.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Step2_Search.Appearance.Options.UseFont = true;
            this.sb_Step2_Search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step2_Search.Location = new System.Drawing.Point(551, 5);
            this.sb_Step2_Search.Name = "sb_Step2_Search";
            this.sb_Step2_Search.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step2_Search.Size = new System.Drawing.Size(124, 34);
            this.sb_Step2_Search.TabIndex = 7;
            this.sb_Step2_Search.Text = "SEARCH";
            this.sb_Step2_Search.Click += new System.EventHandler(this.sb_Search_Click);
            // 
            // sb_Step2_Save
            // 
            this.sb_Step2_Save.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Step2_Save.Appearance.Options.UseFont = true;
            this.sb_Step2_Save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step2_Save.Location = new System.Drawing.Point(423, 5);
            this.sb_Step2_Save.Name = "sb_Step2_Save";
            this.sb_Step2_Save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step2_Save.Size = new System.Drawing.Size(124, 34);
            this.sb_Step2_Save.TabIndex = 6;
            this.sb_Step2_Save.Text = "SAVE";
            this.sb_Step2_Save.Click += new System.EventHandler(this.sb_Execute_Click);
            // 
            // tp_Step3
            // 
            this.tp_Step3.Controls.Add(this.gc_Step3);
            this.tp_Step3.Controls.Add(this.pnl_Step3_Top);
            this.tp_Step3.Name = "tp_Step3";
            this.tp_Step3.Size = new System.Drawing.Size(680, 521);
            this.tp_Step3.Text = "tp_Step3";
            // 
            // gc_Step3
            // 
            this.gc_Step3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Step3.Location = new System.Drawing.Point(0, 44);
            this.gc_Step3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gc_Step3.MainView = this.gv_Step3;
            this.gc_Step3.Name = "gc_Step3";
            this.gc_Step3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.r_ce_step3_Check});
            this.gc_Step3.Size = new System.Drawing.Size(680, 477);
            this.gc_Step3.TabIndex = 5;
            this.gc_Step3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Step3});
            // 
            // gv_Step3
            // 
            this.gv_Step3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.gv_Step3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gv_Step3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gv_Step3.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gv_Step3.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gv_Step3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gv_Step3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gv_Step3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step3.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gv_Step3.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gv_Step3.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gv_Step3.Appearance.Row.Options.UseForeColor = true;
            this.gv_Step3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.gv_Step3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gv_Step3.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gv_Step3.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gv_Step3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_step3_Check,
            this.gc_step3_Table_Name,
            this.gc_step3_Condition_Name,
            this.gc_step3_Condition_Value});
            this.gv_Step3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_Step3.GridControl = this.gc_Step3;
            this.gv_Step3.Name = "gv_Step3";
            this.gv_Step3.OptionsView.EnableAppearanceEvenRow = true;
            this.gv_Step3.OptionsView.ShowGroupPanel = false;
            this.gv_Step3.OptionsView.ShowIndicator = false;
            this.gv_Step3.RowHeight = 25;
            // 
            // gc_step3_Check
            // 
            this.gc_step3_Check.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Check.AppearanceCell.Options.UseFont = true;
            this.gc_step3_Check.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Check.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step3_Check.AppearanceHeader.Options.UseFont = true;
            this.gc_step3_Check.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step3_Check.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step3_Check.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step3_Check.Caption = "선택";
            this.gc_step3_Check.ColumnEdit = this.r_ce_step3_Check;
            this.gc_step3_Check.FieldName = "check";
            this.gc_step3_Check.Name = "gc_step3_Check";
            this.gc_step3_Check.OptionsFilter.AllowAutoFilter = false;
            this.gc_step3_Check.OptionsFilter.AllowFilter = false;
            this.gc_step3_Check.Visible = true;
            this.gc_step3_Check.VisibleIndex = 0;
            this.gc_step3_Check.Width = 70;
            // 
            // r_ce_step3_Check
            // 
            this.r_ce_step3_Check.AutoHeight = false;
            this.r_ce_step3_Check.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.r_ce_step3_Check.Name = "r_ce_step3_Check";
            this.r_ce_step3_Check.ValueChecked = "Y";
            this.r_ce_step3_Check.ValueUnchecked = "N";
            this.r_ce_step3_Check.CheckedChanged += new System.EventHandler(this.r_ce_step3_Check_CheckedChanged);
            // 
            // gc_step3_Table_Name
            // 
            this.gc_step3_Table_Name.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Table_Name.AppearanceCell.Options.UseFont = true;
            this.gc_step3_Table_Name.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Table_Name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step3_Table_Name.AppearanceHeader.Options.UseFont = true;
            this.gc_step3_Table_Name.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step3_Table_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step3_Table_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step3_Table_Name.Caption = "테이블명";
            this.gc_step3_Table_Name.FieldName = "table_name";
            this.gc_step3_Table_Name.Name = "gc_step3_Table_Name";
            this.gc_step3_Table_Name.OptionsColumn.AllowEdit = false;
            this.gc_step3_Table_Name.OptionsColumn.AllowFocus = false;
            this.gc_step3_Table_Name.OptionsFilter.AllowAutoFilter = false;
            this.gc_step3_Table_Name.OptionsFilter.AllowFilter = false;
            this.gc_step3_Table_Name.Visible = true;
            this.gc_step3_Table_Name.VisibleIndex = 1;
            this.gc_step3_Table_Name.Width = 242;
            // 
            // gc_step3_Condition_Name
            // 
            this.gc_step3_Condition_Name.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Condition_Name.AppearanceCell.Options.UseFont = true;
            this.gc_step3_Condition_Name.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Condition_Name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step3_Condition_Name.AppearanceHeader.Options.UseFont = true;
            this.gc_step3_Condition_Name.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step3_Condition_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step3_Condition_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step3_Condition_Name.Caption = "예외 컬럼명";
            this.gc_step3_Condition_Name.FieldName = "condition_name";
            this.gc_step3_Condition_Name.Name = "gc_step3_Condition_Name";
            this.gc_step3_Condition_Name.OptionsColumn.AllowEdit = false;
            this.gc_step3_Condition_Name.OptionsColumn.AllowFocus = false;
            this.gc_step3_Condition_Name.OptionsFilter.AllowAutoFilter = false;
            this.gc_step3_Condition_Name.OptionsFilter.AllowFilter = false;
            this.gc_step3_Condition_Name.Visible = true;
            this.gc_step3_Condition_Name.VisibleIndex = 2;
            this.gc_step3_Condition_Name.Width = 140;
            // 
            // gc_step3_Condition_Value
            // 
            this.gc_step3_Condition_Value.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Condition_Value.AppearanceCell.Options.UseFont = true;
            this.gc_step3_Condition_Value.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_step3_Condition_Value.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gc_step3_Condition_Value.AppearanceHeader.Options.UseFont = true;
            this.gc_step3_Condition_Value.AppearanceHeader.Options.UseForeColor = true;
            this.gc_step3_Condition_Value.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_step3_Condition_Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_step3_Condition_Value.Caption = "예외 값";
            this.gc_step3_Condition_Value.FieldName = "condition_value";
            this.gc_step3_Condition_Value.Name = "gc_step3_Condition_Value";
            this.gc_step3_Condition_Value.OptionsColumn.AllowEdit = false;
            this.gc_step3_Condition_Value.OptionsColumn.AllowFocus = false;
            this.gc_step3_Condition_Value.OptionsFilter.AllowAutoFilter = false;
            this.gc_step3_Condition_Value.OptionsFilter.AllowFilter = false;
            this.gc_step3_Condition_Value.Visible = true;
            this.gc_step3_Condition_Value.VisibleIndex = 3;
            this.gc_step3_Condition_Value.Width = 226;
            // 
            // pnl_Step3_Top
            // 
            this.pnl_Step3_Top.BackColor = System.Drawing.Color.White;
            this.pnl_Step3_Top.Controls.Add(this.sb_Step3_UncheckAll);
            this.pnl_Step3_Top.Controls.Add(this.sb_Step3_CheckAll);
            this.pnl_Step3_Top.Controls.Add(this.tlp_Step3_Checked_Count);
            this.pnl_Step3_Top.Controls.Add(this.sb_Step3_Search);
            this.pnl_Step3_Top.Controls.Add(this.sb_Step3_Execute);
            this.pnl_Step3_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Step3_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Step3_Top.Name = "pnl_Step3_Top";
            this.pnl_Step3_Top.Size = new System.Drawing.Size(680, 44);
            this.pnl_Step3_Top.TabIndex = 4;
            // 
            // sb_Step3_UncheckAll
            // 
            this.sb_Step3_UncheckAll.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_Step3_UncheckAll.Appearance.Options.UseFont = true;
            this.sb_Step3_UncheckAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step3_UncheckAll.Location = new System.Drawing.Point(91, 5);
            this.sb_Step3_UncheckAll.Name = "sb_Step3_UncheckAll";
            this.sb_Step3_UncheckAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step3_UncheckAll.Size = new System.Drawing.Size(83, 34);
            this.sb_Step3_UncheckAll.TabIndex = 13;
            this.sb_Step3_UncheckAll.Text = "전체해제";
            this.sb_Step3_UncheckAll.Click += new System.EventHandler(this.sb_Step3_UncheckAll_Click);
            // 
            // sb_Step3_CheckAll
            // 
            this.sb_Step3_CheckAll.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sb_Step3_CheckAll.Appearance.Options.UseFont = true;
            this.sb_Step3_CheckAll.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step3_CheckAll.Location = new System.Drawing.Point(5, 5);
            this.sb_Step3_CheckAll.Name = "sb_Step3_CheckAll";
            this.sb_Step3_CheckAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step3_CheckAll.Size = new System.Drawing.Size(83, 34);
            this.sb_Step3_CheckAll.TabIndex = 12;
            this.sb_Step3_CheckAll.Text = "전체선택";
            this.sb_Step3_CheckAll.Click += new System.EventHandler(this.sb_Step3_CheckAll_Click);
            // 
            // tlp_Step3_Checked_Count
            // 
            this.tlp_Step3_Checked_Count.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Step3_Checked_Count.ColumnCount = 2;
            this.tlp_Step3_Checked_Count.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Step3_Checked_Count.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Step3_Checked_Count.Controls.Add(this.labelControl6, 0, 0);
            this.tlp_Step3_Checked_Count.Controls.Add(this.lc_Step3_Checked_Count, 1, 0);
            this.tlp_Step3_Checked_Count.Location = new System.Drawing.Point(190, 5);
            this.tlp_Step3_Checked_Count.Name = "tlp_Step3_Checked_Count";
            this.tlp_Step3_Checked_Count.RowCount = 1;
            this.tlp_Step3_Checked_Count.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Step3_Checked_Count.Size = new System.Drawing.Size(230, 34);
            this.tlp_Step3_Checked_Count.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(1, 1);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 32);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "선택 테이블 수";
            // 
            // lc_Step3_Checked_Count
            // 
            this.lc_Step3_Checked_Count.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_Step3_Checked_Count.Appearance.Options.UseFont = true;
            this.lc_Step3_Checked_Count.Appearance.Options.UseTextOptions = true;
            this.lc_Step3_Checked_Count.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_Step3_Checked_Count.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Step3_Checked_Count.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lc_Step3_Checked_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Step3_Checked_Count.IndentBetweenImageAndText = 7;
            this.lc_Step3_Checked_Count.Location = new System.Drawing.Point(118, 4);
            this.lc_Step3_Checked_Count.Name = "lc_Step3_Checked_Count";
            this.lc_Step3_Checked_Count.Size = new System.Drawing.Size(108, 26);
            this.lc_Step3_Checked_Count.TabIndex = 10;
            this.lc_Step3_Checked_Count.Text = "000 / 000";
            // 
            // sb_Step3_Search
            // 
            this.sb_Step3_Search.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Step3_Search.Appearance.Options.UseFont = true;
            this.sb_Step3_Search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step3_Search.Location = new System.Drawing.Point(551, 5);
            this.sb_Step3_Search.Name = "sb_Step3_Search";
            this.sb_Step3_Search.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step3_Search.Size = new System.Drawing.Size(124, 34);
            this.sb_Step3_Search.TabIndex = 8;
            this.sb_Step3_Search.Text = "SEARCH";
            this.sb_Step3_Search.Click += new System.EventHandler(this.sb_Search_Click);
            // 
            // sb_Step3_Execute
            // 
            this.sb_Step3_Execute.Appearance.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Step3_Execute.Appearance.Options.UseFont = true;
            this.sb_Step3_Execute.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sb_Step3_Execute.Location = new System.Drawing.Point(423, 5);
            this.sb_Step3_Execute.Name = "sb_Step3_Execute";
            this.sb_Step3_Execute.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sb_Step3_Execute.Size = new System.Drawing.Size(124, 34);
            this.sb_Step3_Execute.TabIndex = 7;
            this.sb_Step3_Execute.Text = "EXECUTE";
            this.sb_Step3_Execute.Click += new System.EventHandler(this.sb_Execute_Click);
            // 
            // lc_Message
            // 
            this.lc_Message.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc_Message.Appearance.Options.UseFont = true;
            this.lc_Message.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Message.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lc_Message.Dock = System.Windows.Forms.DockStyle.Top;
            this.lc_Message.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lc_Message.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lc_Message.ImageOptions.Image")));
            this.lc_Message.IndentBetweenImageAndText = 7;
            this.lc_Message.Location = new System.Drawing.Point(3, 71);
            this.lc_Message.Name = "lc_Message";
            this.lc_Message.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lc_Message.Size = new System.Drawing.Size(682, 28);
            this.lc_Message.TabIndex = 1;
            this.lc_Message.Text = "[SEARCH] 버튼을 눌러 조회해 주십시오.";
            // 
            // tlp_Step
            // 
            this.tlp_Step.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_Step.ColumnCount = 4;
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Step.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Step.Controls.Add(this.cb_Step4, 3, 0);
            this.tlp_Step.Controls.Add(this.cb_Step3, 2, 0);
            this.tlp_Step.Controls.Add(this.cb_Step2, 1, 0);
            this.tlp_Step.Controls.Add(this.cb_Step1, 0, 0);
            this.tlp_Step.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Step.Location = new System.Drawing.Point(3, 19);
            this.tlp_Step.Name = "tlp_Step";
            this.tlp_Step.RowCount = 1;
            this.tlp_Step.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Step.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Step.Size = new System.Drawing.Size(682, 52);
            this.tlp_Step.TabIndex = 0;
            // 
            // cb_Step4
            // 
            this.cb_Step4.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Step4.Appearance.Options.UseFont = true;
            this.cb_Step4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cb_Step4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Step4.Location = new System.Drawing.Point(516, 6);
            this.cb_Step4.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Step4.Name = "cb_Step4";
            this.cb_Step4.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cb_Step4.Size = new System.Drawing.Size(160, 40);
            this.cb_Step4.StyleController = this.styleController1;
            this.cb_Step4.TabIndex = 3;
            this.cb_Step4.Tag = "4";
            this.cb_Step4.Text = "4. 마스터 데이터 입력";
            this.cb_Step4.Click += new System.EventHandler(this.cb_Step_Click);
            // 
            // styleController1
            // 
            this.styleController1.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.styleController1.Appearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.styleController1.Appearance.Options.UseBackColor = true;
            this.styleController1.Appearance.Options.UseBorderColor = true;
            this.styleController1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // cb_Step3
            // 
            this.cb_Step3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Step3.Appearance.Options.UseFont = true;
            this.cb_Step3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cb_Step3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Step3.Location = new System.Drawing.Point(346, 6);
            this.cb_Step3.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Step3.Name = "cb_Step3";
            this.cb_Step3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cb_Step3.Size = new System.Drawing.Size(159, 40);
            this.cb_Step3.StyleController = this.styleController1;
            this.cb_Step3.TabIndex = 2;
            this.cb_Step3.Tag = "3";
            this.cb_Step3.Text = "3. 기존 데이터 삭제";
            this.cb_Step3.Click += new System.EventHandler(this.cb_Step_Click);
            // 
            // cb_Step2
            // 
            this.cb_Step2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Step2.Appearance.Options.UseFont = true;
            this.cb_Step2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cb_Step2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Step2.Location = new System.Drawing.Point(176, 6);
            this.cb_Step2.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Step2.Name = "cb_Step2";
            this.cb_Step2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cb_Step2.Size = new System.Drawing.Size(159, 40);
            this.cb_Step2.StyleController = this.styleController1;
            this.cb_Step2.TabIndex = 1;
            this.cb_Step2.Tag = "2";
            this.cb_Step2.Text = "2. 파라미터 설정";
            this.cb_Step2.Click += new System.EventHandler(this.cb_Step_Click);
            // 
            // cb_Step1
            // 
            this.cb_Step1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Step1.Appearance.Options.UseFont = true;
            this.cb_Step1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cb_Step1.Checked = true;
            this.cb_Step1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Step1.Location = new System.Drawing.Point(6, 6);
            this.cb_Step1.Margin = new System.Windows.Forms.Padding(5);
            this.cb_Step1.Name = "cb_Step1";
            this.cb_Step1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cb_Step1.Size = new System.Drawing.Size(159, 40);
            this.cb_Step1.StyleController = this.styleController1;
            this.cb_Step1.TabIndex = 0;
            this.cb_Step1.Tag = "1";
            this.cb_Step1.Text = "1. 기존 DB Name 조회";
            this.cb_Step1.Click += new System.EventHandler(this.cb_Step_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 721);
            this.Controls.Add(this.tlp_Main);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterData Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Step)).EndInit();
            this.tc_Step.ResumeLayout(false);
            this.tp_Step1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step1)).EndInit();
            this.pnl_Step1_Top.ResumeLayout(false);
            this.pnl_Step1_Top.PerformLayout();
            this.tp_Step2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step2)).EndInit();
            this.pnl_Step2_Top.ResumeLayout(false);
            this.tp_Step3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Step3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Step3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_ce_step3_Check)).EndInit();
            this.pnl_Step3_Top.ResumeLayout(false);
            this.tlp_Step3_Checked_Count.ResumeLayout(false);
            this.tlp_Step3_Checked_Count.PerformLayout();
            this.tlp_Step.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_DBName;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_DBAddress;
        private DevExpress.XtraEditors.CheckButton cbe_ViewPassword;
        private DevExpress.XtraEditors.SimpleButton sb_Connect;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraTab.XtraTabControl tc_Step;
        private DevExpress.XtraTab.XtraTabPage tp_Step1;
        private DevExpress.XtraGrid.GridControl gc_Step1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Step1;
        private System.Windows.Forms.Panel pnl_Step1_Top;
        private DevExpress.XtraEditors.SimpleButton sb_Step1_Search;
        private DevExpress.XtraTab.XtraTabPage tp_Step2;
        private DevExpress.XtraEditors.LabelControl lc_Message;
        private System.Windows.Forms.TableLayoutPanel tlp_Step;
        private DevExpress.XtraEditors.CheckButton cb_Step4;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.CheckButton cb_Step3;
        private DevExpress.XtraEditors.CheckButton cb_Step2;
        private DevExpress.XtraEditors.CheckButton cb_Step1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step1_SP_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step1_SP_Content;
        private System.Windows.Forms.TextBox te_Step1_Prev_DB_Name;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gc_Step2;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Step2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step2_Parameter_Code;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step2_Parameter_Value;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step2_Remark;
        private System.Windows.Forms.Panel pnl_Step2_Top;
        private DevExpress.XtraEditors.SimpleButton sb_Step2_Save;
        private DevExpress.XtraEditors.SimpleButton sb_Step2_Search;
        private DevExpress.XtraTab.XtraTabPage tp_Step3;
        private DevExpress.XtraGrid.GridControl gc_Step3;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Step3;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step3_Check;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step3_Table_Name;
        private System.Windows.Forms.Panel pnl_Step3_Top;
        private DevExpress.XtraEditors.SimpleButton sb_Step3_Execute;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit r_ce_step3_Check;
        private DevExpress.XtraEditors.SimpleButton sb_Step3_Search;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step3_Condition_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_step3_Condition_Value;
        private System.Windows.Forms.TableLayoutPanel tlp_Step3_Checked_Count;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lc_Step3_Checked_Count;
        private DevExpress.XtraEditors.SimpleButton sb_Step3_UncheckAll;
        private DevExpress.XtraEditors.SimpleButton sb_Step3_CheckAll;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}

