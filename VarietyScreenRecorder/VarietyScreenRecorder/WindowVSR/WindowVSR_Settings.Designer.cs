namespace VarietyScreenRecorder.WindowVSR
{
    partial class WindowVSR_Settings
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
            this.tlp_AllContentAlignment = new System.Windows.Forms.TableLayoutPanel();
            this.tc_SettingsMenu = new System.Windows.Forms.TabControl();
            this.tp_MainSetting = new System.Windows.Forms.TabPage();
            this.tlp_MainSettings = new System.Windows.Forms.TableLayoutPanel();
            this.b_FullSizeScreenshot_Path = new System.Windows.Forms.Button();
            this.tb_FullSizeScreenshot_Path = new System.Windows.Forms.TextBox();
            this.cb_FullSizeScreenshot_Extension = new System.Windows.Forms.ComboBox();
            this.tb_SizedScreenshot_Path = new System.Windows.Forms.TextBox();
            this.cb_SizedScreenshot_Extension = new System.Windows.Forms.ComboBox();
            this.cb_SizedScreenshot_IsEdit = new System.Windows.Forms.CheckBox();
            this.tb_TimeLapseScreenshot_Path = new System.Windows.Forms.TextBox();
            this.cb_TimeLapseScreenshot_Extension = new System.Windows.Forms.ComboBox();
            this.tb_TimeLapseScreenshot_Interval = new System.Windows.Forms.TrackBar();
            this.nud_TimeLapseScreenshot_Interval = new System.Windows.Forms.NumericUpDown();
            this.tb_VideoRecord_Path = new System.Windows.Forms.TextBox();
            this.b_SizedScreenshot_Path = new System.Windows.Forms.Button();
            this.b_TimeLapseScreenshot_Path = new System.Windows.Forms.Button();
            this.b_VideoRecord_Path = new System.Windows.Forms.Button();
            this.b_CancelMainSetting = new System.Windows.Forms.Button();
            this.b_SaveMainSettings = new System.Windows.Forms.Button();
            this.b_DefaultMainSetting = new System.Windows.Forms.Button();
            this.l_FullSizeScreenshot_Path = new System.Windows.Forms.Label();
            this.l_FullSizeScreenshot_Extension = new System.Windows.Forms.Label();
            this.l_SizedScreenshot_Path = new System.Windows.Forms.Label();
            this.l_SizedScreenshot_Extension = new System.Windows.Forms.Label();
            this.l_SizedScreenshot_IsEdit = new System.Windows.Forms.Label();
            this.l_TimeLapseScreenshot_Path = new System.Windows.Forms.Label();
            this.l_TimeLapseScreenshot_Extension = new System.Windows.Forms.Label();
            this.l_TimeLapseScreenshot_Interval = new System.Windows.Forms.Label();
            this.l_VideoRecord_Path = new System.Windows.Forms.Label();
            this.tp_HotKeys = new System.Windows.Forms.TabPage();
            this.tlp_HotKeys = new System.Windows.Forms.TableLayoutPanel();
            this.l_VSRHotKey_PhotoCam = new System.Windows.Forms.Label();
            this.l_VSRHotKey_PhotoCamSized = new System.Windows.Forms.Label();
            this.l_VSRHotKey_TimeLapse = new System.Windows.Forms.Label();
            this.l_VSRHotKey_VideoCam = new System.Windows.Forms.Label();
            this.l_VSRHotKey_Setting = new System.Windows.Forms.Label();
            this.l_VSRHotKey_Info = new System.Windows.Forms.Label();
            this.tb_VSRHotKey_PhotoCam = new System.Windows.Forms.TextBox();
            this.tb_VSRHotKey_PhotoCamSized = new System.Windows.Forms.TextBox();
            this.tb_VSRHotKey_TimeLapse = new System.Windows.Forms.TextBox();
            this.tb_VSRHotKey_VideoCam = new System.Windows.Forms.TextBox();
            this.tb_VSRHotKey_Setting = new System.Windows.Forms.TextBox();
            this.tb_VSRHotKey_Info = new System.Windows.Forms.TextBox();
            this.b_SaveHotKeys = new System.Windows.Forms.Button();
            this.b_CancelHotKeys = new System.Windows.Forms.Button();
            this.b_DefaultHotKeys = new System.Windows.Forms.Button();
            this.tlp_AllContentAlignment.SuspendLayout();
            this.tc_SettingsMenu.SuspendLayout();
            this.tp_MainSetting.SuspendLayout();
            this.tlp_MainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TimeLapseScreenshot_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeLapseScreenshot_Interval)).BeginInit();
            this.tp_HotKeys.SuspendLayout();
            this.tlp_HotKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_AllContentAlignment
            // 
            this.tlp_AllContentAlignment.ColumnCount = 3;
            this.tlp_AllContentAlignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_AllContentAlignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AllContentAlignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_AllContentAlignment.Controls.Add(this.tc_SettingsMenu, 1, 1);
            this.tlp_AllContentAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_AllContentAlignment.Location = new System.Drawing.Point(0, 0);
            this.tlp_AllContentAlignment.Name = "tlp_AllContentAlignment";
            this.tlp_AllContentAlignment.RowCount = 3;
            this.tlp_AllContentAlignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_AllContentAlignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_AllContentAlignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_AllContentAlignment.Size = new System.Drawing.Size(734, 461);
            this.tlp_AllContentAlignment.TabIndex = 0;
            // 
            // tc_SettingsMenu
            // 
            this.tc_SettingsMenu.Controls.Add(this.tp_MainSetting);
            this.tc_SettingsMenu.Controls.Add(this.tp_HotKeys);
            this.tc_SettingsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_SettingsMenu.Location = new System.Drawing.Point(13, 13);
            this.tc_SettingsMenu.Name = "tc_SettingsMenu";
            this.tc_SettingsMenu.SelectedIndex = 0;
            this.tc_SettingsMenu.Size = new System.Drawing.Size(708, 435);
            this.tc_SettingsMenu.TabIndex = 0;
            // 
            // tp_MainSetting
            // 
            this.tp_MainSetting.Controls.Add(this.tlp_MainSettings);
            this.tp_MainSetting.Location = new System.Drawing.Point(4, 22);
            this.tp_MainSetting.Name = "tp_MainSetting";
            this.tp_MainSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MainSetting.Size = new System.Drawing.Size(700, 409);
            this.tp_MainSetting.TabIndex = 0;
            this.tp_MainSetting.Text = "Main settings";
            this.tp_MainSetting.UseVisualStyleBackColor = true;
            // 
            // tlp_MainSettings
            // 
            this.tlp_MainSettings.AutoScroll = true;
            this.tlp_MainSettings.ColumnCount = 9;
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_MainSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tlp_MainSettings.Controls.Add(this.b_FullSizeScreenshot_Path, 7, 1);
            this.tlp_MainSettings.Controls.Add(this.tb_FullSizeScreenshot_Path, 3, 1);
            this.tlp_MainSettings.Controls.Add(this.cb_FullSizeScreenshot_Extension, 3, 3);
            this.tlp_MainSettings.Controls.Add(this.tb_SizedScreenshot_Path, 3, 5);
            this.tlp_MainSettings.Controls.Add(this.cb_SizedScreenshot_Extension, 3, 7);
            this.tlp_MainSettings.Controls.Add(this.cb_SizedScreenshot_IsEdit, 3, 9);
            this.tlp_MainSettings.Controls.Add(this.tb_TimeLapseScreenshot_Path, 3, 11);
            this.tlp_MainSettings.Controls.Add(this.cb_TimeLapseScreenshot_Extension, 3, 13);
            this.tlp_MainSettings.Controls.Add(this.tb_TimeLapseScreenshot_Interval, 3, 15);
            this.tlp_MainSettings.Controls.Add(this.nud_TimeLapseScreenshot_Interval, 7, 15);
            this.tlp_MainSettings.Controls.Add(this.tb_VideoRecord_Path, 3, 17);
            this.tlp_MainSettings.Controls.Add(this.b_SizedScreenshot_Path, 7, 5);
            this.tlp_MainSettings.Controls.Add(this.b_TimeLapseScreenshot_Path, 7, 11);
            this.tlp_MainSettings.Controls.Add(this.b_VideoRecord_Path, 7, 17);
            this.tlp_MainSettings.Controls.Add(this.b_CancelMainSetting, 5, 19);
            this.tlp_MainSettings.Controls.Add(this.b_SaveMainSettings, 3, 19);
            this.tlp_MainSettings.Controls.Add(this.b_DefaultMainSetting, 7, 19);
            this.tlp_MainSettings.Controls.Add(this.l_FullSizeScreenshot_Path, 1, 1);
            this.tlp_MainSettings.Controls.Add(this.l_FullSizeScreenshot_Extension, 1, 3);
            this.tlp_MainSettings.Controls.Add(this.l_SizedScreenshot_Path, 1, 5);
            this.tlp_MainSettings.Controls.Add(this.l_SizedScreenshot_Extension, 1, 7);
            this.tlp_MainSettings.Controls.Add(this.l_SizedScreenshot_IsEdit, 1, 9);
            this.tlp_MainSettings.Controls.Add(this.l_TimeLapseScreenshot_Path, 1, 11);
            this.tlp_MainSettings.Controls.Add(this.l_TimeLapseScreenshot_Extension, 1, 13);
            this.tlp_MainSettings.Controls.Add(this.l_TimeLapseScreenshot_Interval, 1, 15);
            this.tlp_MainSettings.Controls.Add(this.l_VideoRecord_Path, 1, 17);
            this.tlp_MainSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MainSettings.Location = new System.Drawing.Point(3, 3);
            this.tlp_MainSettings.Name = "tlp_MainSettings";
            this.tlp_MainSettings.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tlp_MainSettings.RowCount = 21;
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_MainSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainSettings.Size = new System.Drawing.Size(694, 403);
            this.tlp_MainSettings.TabIndex = 0;
            // 
            // b_FullSizeScreenshot_Path
            // 
            this.b_FullSizeScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_FullSizeScreenshot_Path.Location = new System.Drawing.Point(539, 13);
            this.b_FullSizeScreenshot_Path.Name = "b_FullSizeScreenshot_Path";
            this.b_FullSizeScreenshot_Path.Size = new System.Drawing.Size(118, 20);
            this.b_FullSizeScreenshot_Path.TabIndex = 0;
            this.b_FullSizeScreenshot_Path.Text = "Browse";
            this.b_FullSizeScreenshot_Path.UseVisualStyleBackColor = true;
            this.b_FullSizeScreenshot_Path.Click += new System.EventHandler(this.b_FullSizeScreenshot_Path_Click);
            // 
            // tb_FullSizeScreenshot_Path
            // 
            this.tlp_MainSettings.SetColumnSpan(this.tb_FullSizeScreenshot_Path, 3);
            this.tb_FullSizeScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_FullSizeScreenshot_Path.Location = new System.Drawing.Point(271, 13);
            this.tb_FullSizeScreenshot_Path.Name = "tb_FullSizeScreenshot_Path";
            this.tb_FullSizeScreenshot_Path.ReadOnly = true;
            this.tb_FullSizeScreenshot_Path.Size = new System.Drawing.Size(252, 20);
            this.tb_FullSizeScreenshot_Path.TabIndex = 1;
            // 
            // cb_FullSizeScreenshot_Extension
            // 
            this.cb_FullSizeScreenshot_Extension.BackColor = System.Drawing.Color.White;
            this.cb_FullSizeScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_FullSizeScreenshot_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FullSizeScreenshot_Extension.FormattingEnabled = true;
            this.cb_FullSizeScreenshot_Extension.Items.AddRange(new object[] {
            "png",
            "jpeg",
            "bmp",
            "gif"});
            this.cb_FullSizeScreenshot_Extension.Location = new System.Drawing.Point(271, 49);
            this.cb_FullSizeScreenshot_Extension.Name = "cb_FullSizeScreenshot_Extension";
            this.cb_FullSizeScreenshot_Extension.Size = new System.Drawing.Size(118, 21);
            this.cb_FullSizeScreenshot_Extension.TabIndex = 2;
            // 
            // tb_SizedScreenshot_Path
            // 
            this.tlp_MainSettings.SetColumnSpan(this.tb_SizedScreenshot_Path, 3);
            this.tb_SizedScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SizedScreenshot_Path.Location = new System.Drawing.Point(271, 85);
            this.tb_SizedScreenshot_Path.Name = "tb_SizedScreenshot_Path";
            this.tb_SizedScreenshot_Path.ReadOnly = true;
            this.tb_SizedScreenshot_Path.Size = new System.Drawing.Size(252, 20);
            this.tb_SizedScreenshot_Path.TabIndex = 3;
            // 
            // cb_SizedScreenshot_Extension
            // 
            this.cb_SizedScreenshot_Extension.BackColor = System.Drawing.Color.White;
            this.cb_SizedScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SizedScreenshot_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SizedScreenshot_Extension.FormattingEnabled = true;
            this.cb_SizedScreenshot_Extension.Items.AddRange(new object[] {
            "png",
            "jpeg",
            "bmp",
            "gif"});
            this.cb_SizedScreenshot_Extension.Location = new System.Drawing.Point(271, 121);
            this.cb_SizedScreenshot_Extension.Name = "cb_SizedScreenshot_Extension";
            this.cb_SizedScreenshot_Extension.Size = new System.Drawing.Size(118, 21);
            this.cb_SizedScreenshot_Extension.TabIndex = 4;
            // 
            // cb_SizedScreenshot_IsEdit
            // 
            this.cb_SizedScreenshot_IsEdit.AutoSize = true;
            this.cb_SizedScreenshot_IsEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_SizedScreenshot_IsEdit.Location = new System.Drawing.Point(271, 157);
            this.cb_SizedScreenshot_IsEdit.Name = "cb_SizedScreenshot_IsEdit";
            this.cb_SizedScreenshot_IsEdit.Size = new System.Drawing.Size(118, 20);
            this.cb_SizedScreenshot_IsEdit.TabIndex = 5;
            this.cb_SizedScreenshot_IsEdit.UseVisualStyleBackColor = true;
            // 
            // tb_TimeLapseScreenshot_Path
            // 
            this.tlp_MainSettings.SetColumnSpan(this.tb_TimeLapseScreenshot_Path, 3);
            this.tb_TimeLapseScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TimeLapseScreenshot_Path.Location = new System.Drawing.Point(271, 193);
            this.tb_TimeLapseScreenshot_Path.Name = "tb_TimeLapseScreenshot_Path";
            this.tb_TimeLapseScreenshot_Path.ReadOnly = true;
            this.tb_TimeLapseScreenshot_Path.Size = new System.Drawing.Size(252, 20);
            this.tb_TimeLapseScreenshot_Path.TabIndex = 6;
            // 
            // cb_TimeLapseScreenshot_Extension
            // 
            this.cb_TimeLapseScreenshot_Extension.BackColor = System.Drawing.Color.White;
            this.cb_TimeLapseScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_TimeLapseScreenshot_Extension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TimeLapseScreenshot_Extension.FormattingEnabled = true;
            this.cb_TimeLapseScreenshot_Extension.Items.AddRange(new object[] {
            "png",
            "jpeg",
            "bmp",
            "gif"});
            this.cb_TimeLapseScreenshot_Extension.Location = new System.Drawing.Point(271, 229);
            this.cb_TimeLapseScreenshot_Extension.Name = "cb_TimeLapseScreenshot_Extension";
            this.cb_TimeLapseScreenshot_Extension.Size = new System.Drawing.Size(118, 21);
            this.cb_TimeLapseScreenshot_Extension.TabIndex = 7;
            // 
            // tb_TimeLapseScreenshot_Interval
            // 
            this.tlp_MainSettings.SetColumnSpan(this.tb_TimeLapseScreenshot_Interval, 3);
            this.tb_TimeLapseScreenshot_Interval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TimeLapseScreenshot_Interval.LargeChange = 10;
            this.tb_TimeLapseScreenshot_Interval.Location = new System.Drawing.Point(271, 265);
            this.tb_TimeLapseScreenshot_Interval.Maximum = 3600;
            this.tb_TimeLapseScreenshot_Interval.Minimum = 1;
            this.tb_TimeLapseScreenshot_Interval.Name = "tb_TimeLapseScreenshot_Interval";
            this.tb_TimeLapseScreenshot_Interval.Size = new System.Drawing.Size(252, 20);
            this.tb_TimeLapseScreenshot_Interval.TabIndex = 8;
            this.tb_TimeLapseScreenshot_Interval.Value = 1;
            this.tb_TimeLapseScreenshot_Interval.Scroll += new System.EventHandler(this.tb_TimeLapseScreenshot_Interval_Scroll);
            // 
            // nud_TimeLapseScreenshot_Interval
            // 
            this.nud_TimeLapseScreenshot_Interval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_TimeLapseScreenshot_Interval.Location = new System.Drawing.Point(539, 265);
            this.nud_TimeLapseScreenshot_Interval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nud_TimeLapseScreenshot_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TimeLapseScreenshot_Interval.Name = "nud_TimeLapseScreenshot_Interval";
            this.nud_TimeLapseScreenshot_Interval.Size = new System.Drawing.Size(118, 20);
            this.nud_TimeLapseScreenshot_Interval.TabIndex = 9;
            this.nud_TimeLapseScreenshot_Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TimeLapseScreenshot_Interval.ValueChanged += new System.EventHandler(this.nud_TimeLapseScreenshot_Interval_ValueChanged);
            // 
            // tb_VideoRecord_Path
            // 
            this.tlp_MainSettings.SetColumnSpan(this.tb_VideoRecord_Path, 3);
            this.tb_VideoRecord_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VideoRecord_Path.Location = new System.Drawing.Point(271, 301);
            this.tb_VideoRecord_Path.Name = "tb_VideoRecord_Path";
            this.tb_VideoRecord_Path.ReadOnly = true;
            this.tb_VideoRecord_Path.Size = new System.Drawing.Size(252, 20);
            this.tb_VideoRecord_Path.TabIndex = 10;
            // 
            // b_SizedScreenshot_Path
            // 
            this.b_SizedScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_SizedScreenshot_Path.Location = new System.Drawing.Point(539, 85);
            this.b_SizedScreenshot_Path.Name = "b_SizedScreenshot_Path";
            this.b_SizedScreenshot_Path.Size = new System.Drawing.Size(118, 20);
            this.b_SizedScreenshot_Path.TabIndex = 11;
            this.b_SizedScreenshot_Path.Text = "Browse";
            this.b_SizedScreenshot_Path.UseVisualStyleBackColor = true;
            this.b_SizedScreenshot_Path.Click += new System.EventHandler(this.b_SizedScreenshot_Path_Click);
            // 
            // b_TimeLapseScreenshot_Path
            // 
            this.b_TimeLapseScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_TimeLapseScreenshot_Path.Location = new System.Drawing.Point(539, 193);
            this.b_TimeLapseScreenshot_Path.Name = "b_TimeLapseScreenshot_Path";
            this.b_TimeLapseScreenshot_Path.Size = new System.Drawing.Size(118, 20);
            this.b_TimeLapseScreenshot_Path.TabIndex = 12;
            this.b_TimeLapseScreenshot_Path.Text = "Browse";
            this.b_TimeLapseScreenshot_Path.UseVisualStyleBackColor = true;
            this.b_TimeLapseScreenshot_Path.Click += new System.EventHandler(this.b_TimeLapseScreenshot_Path_Click);
            // 
            // b_VideoRecord_Path
            // 
            this.b_VideoRecord_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_VideoRecord_Path.Location = new System.Drawing.Point(539, 301);
            this.b_VideoRecord_Path.Name = "b_VideoRecord_Path";
            this.b_VideoRecord_Path.Size = new System.Drawing.Size(118, 20);
            this.b_VideoRecord_Path.TabIndex = 13;
            this.b_VideoRecord_Path.Text = "Browse";
            this.b_VideoRecord_Path.UseVisualStyleBackColor = true;
            this.b_VideoRecord_Path.Click += new System.EventHandler(this.b_VideoRecord_Path_Click);
            // 
            // b_CancelMainSetting
            // 
            this.b_CancelMainSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_CancelMainSetting.Location = new System.Drawing.Point(405, 353);
            this.b_CancelMainSetting.Name = "b_CancelMainSetting";
            this.b_CancelMainSetting.Size = new System.Drawing.Size(118, 30);
            this.b_CancelMainSetting.TabIndex = 15;
            this.b_CancelMainSetting.Text = "Cancel";
            this.b_CancelMainSetting.UseVisualStyleBackColor = true;
            this.b_CancelMainSetting.Click += new System.EventHandler(this.b_CancelMainSetting_Click);
            // 
            // b_SaveMainSettings
            // 
            this.b_SaveMainSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_SaveMainSettings.Location = new System.Drawing.Point(271, 353);
            this.b_SaveMainSettings.Name = "b_SaveMainSettings";
            this.b_SaveMainSettings.Size = new System.Drawing.Size(118, 30);
            this.b_SaveMainSettings.TabIndex = 14;
            this.b_SaveMainSettings.Text = "Save";
            this.b_SaveMainSettings.UseVisualStyleBackColor = true;
            this.b_SaveMainSettings.Click += new System.EventHandler(this.b_SaveMainSettings_Click);
            // 
            // b_DefaultMainSetting
            // 
            this.b_DefaultMainSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_DefaultMainSetting.Location = new System.Drawing.Point(539, 353);
            this.b_DefaultMainSetting.Name = "b_DefaultMainSetting";
            this.b_DefaultMainSetting.Size = new System.Drawing.Size(118, 30);
            this.b_DefaultMainSetting.TabIndex = 16;
            this.b_DefaultMainSetting.Text = "Default";
            this.b_DefaultMainSetting.UseVisualStyleBackColor = true;
            this.b_DefaultMainSetting.Click += new System.EventHandler(this.b_DefaultMainSetting_Click);
            // 
            // l_FullSizeScreenshot_Path
            // 
            this.l_FullSizeScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_FullSizeScreenshot_Path.Location = new System.Drawing.Point(13, 10);
            this.l_FullSizeScreenshot_Path.Name = "l_FullSizeScreenshot_Path";
            this.l_FullSizeScreenshot_Path.Size = new System.Drawing.Size(242, 26);
            this.l_FullSizeScreenshot_Path.TabIndex = 0;
            this.l_FullSizeScreenshot_Path.Text = "Folder path for saving quick screenshots";
            this.l_FullSizeScreenshot_Path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_FullSizeScreenshot_Extension
            // 
            this.l_FullSizeScreenshot_Extension.AutoSize = true;
            this.l_FullSizeScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_FullSizeScreenshot_Extension.Location = new System.Drawing.Point(13, 46);
            this.l_FullSizeScreenshot_Extension.Name = "l_FullSizeScreenshot_Extension";
            this.l_FullSizeScreenshot_Extension.Size = new System.Drawing.Size(242, 26);
            this.l_FullSizeScreenshot_Extension.TabIndex = 17;
            this.l_FullSizeScreenshot_Extension.Text = "Quick screenshots extension";
            this.l_FullSizeScreenshot_Extension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_SizedScreenshot_Path
            // 
            this.l_SizedScreenshot_Path.AutoSize = true;
            this.l_SizedScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SizedScreenshot_Path.Location = new System.Drawing.Point(13, 82);
            this.l_SizedScreenshot_Path.Name = "l_SizedScreenshot_Path";
            this.l_SizedScreenshot_Path.Size = new System.Drawing.Size(242, 26);
            this.l_SizedScreenshot_Path.TabIndex = 18;
            this.l_SizedScreenshot_Path.Text = "Folder path for custom screenshots";
            this.l_SizedScreenshot_Path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_SizedScreenshot_Extension
            // 
            this.l_SizedScreenshot_Extension.AutoSize = true;
            this.l_SizedScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SizedScreenshot_Extension.Location = new System.Drawing.Point(13, 118);
            this.l_SizedScreenshot_Extension.Name = "l_SizedScreenshot_Extension";
            this.l_SizedScreenshot_Extension.Size = new System.Drawing.Size(242, 26);
            this.l_SizedScreenshot_Extension.TabIndex = 19;
            this.l_SizedScreenshot_Extension.Text = "Custom screenshots extension";
            this.l_SizedScreenshot_Extension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_SizedScreenshot_IsEdit
            // 
            this.l_SizedScreenshot_IsEdit.AutoSize = true;
            this.l_SizedScreenshot_IsEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_SizedScreenshot_IsEdit.Location = new System.Drawing.Point(13, 154);
            this.l_SizedScreenshot_IsEdit.Name = "l_SizedScreenshot_IsEdit";
            this.l_SizedScreenshot_IsEdit.Size = new System.Drawing.Size(242, 26);
            this.l_SizedScreenshot_IsEdit.TabIndex = 20;
            this.l_SizedScreenshot_IsEdit.Text = "Run the editing tool for custom screenshots";
            this.l_SizedScreenshot_IsEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_TimeLapseScreenshot_Path
            // 
            this.l_TimeLapseScreenshot_Path.AutoSize = true;
            this.l_TimeLapseScreenshot_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_TimeLapseScreenshot_Path.Location = new System.Drawing.Point(13, 190);
            this.l_TimeLapseScreenshot_Path.Name = "l_TimeLapseScreenshot_Path";
            this.l_TimeLapseScreenshot_Path.Size = new System.Drawing.Size(242, 26);
            this.l_TimeLapseScreenshot_Path.TabIndex = 21;
            this.l_TimeLapseScreenshot_Path.Text = "Folder path for time lapse screenshots";
            this.l_TimeLapseScreenshot_Path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_TimeLapseScreenshot_Extension
            // 
            this.l_TimeLapseScreenshot_Extension.AutoSize = true;
            this.l_TimeLapseScreenshot_Extension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_TimeLapseScreenshot_Extension.Location = new System.Drawing.Point(13, 226);
            this.l_TimeLapseScreenshot_Extension.Name = "l_TimeLapseScreenshot_Extension";
            this.l_TimeLapseScreenshot_Extension.Size = new System.Drawing.Size(242, 26);
            this.l_TimeLapseScreenshot_Extension.TabIndex = 22;
            this.l_TimeLapseScreenshot_Extension.Text = "Time lapse screenshots extension";
            this.l_TimeLapseScreenshot_Extension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_TimeLapseScreenshot_Interval
            // 
            this.l_TimeLapseScreenshot_Interval.AutoSize = true;
            this.l_TimeLapseScreenshot_Interval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_TimeLapseScreenshot_Interval.Location = new System.Drawing.Point(13, 262);
            this.l_TimeLapseScreenshot_Interval.Name = "l_TimeLapseScreenshot_Interval";
            this.l_TimeLapseScreenshot_Interval.Size = new System.Drawing.Size(242, 26);
            this.l_TimeLapseScreenshot_Interval.TabIndex = 23;
            this.l_TimeLapseScreenshot_Interval.Text = "Save interval for time lapse screenshots (sec)";
            this.l_TimeLapseScreenshot_Interval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VideoRecord_Path
            // 
            this.l_VideoRecord_Path.AutoSize = true;
            this.l_VideoRecord_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VideoRecord_Path.Location = new System.Drawing.Point(13, 298);
            this.l_VideoRecord_Path.Name = "l_VideoRecord_Path";
            this.l_VideoRecord_Path.Size = new System.Drawing.Size(242, 26);
            this.l_VideoRecord_Path.TabIndex = 24;
            this.l_VideoRecord_Path.Text = "Folder path for screen records";
            this.l_VideoRecord_Path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tp_HotKeys
            // 
            this.tp_HotKeys.Controls.Add(this.tlp_HotKeys);
            this.tp_HotKeys.Location = new System.Drawing.Point(4, 22);
            this.tp_HotKeys.Name = "tp_HotKeys";
            this.tp_HotKeys.Padding = new System.Windows.Forms.Padding(3);
            this.tp_HotKeys.Size = new System.Drawing.Size(700, 409);
            this.tp_HotKeys.TabIndex = 1;
            this.tp_HotKeys.Text = "Hotkeys";
            this.tp_HotKeys.UseVisualStyleBackColor = true;
            // 
            // tlp_HotKeys
            // 
            this.tlp_HotKeys.AutoScroll = true;
            this.tlp_HotKeys.ColumnCount = 9;
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_HotKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_PhotoCam, 1, 1);
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_PhotoCamSized, 1, 3);
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_TimeLapse, 1, 5);
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_VideoCam, 1, 7);
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_Setting, 1, 9);
            this.tlp_HotKeys.Controls.Add(this.l_VSRHotKey_Info, 1, 11);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_PhotoCam, 5, 1);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_PhotoCamSized, 5, 3);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_TimeLapse, 5, 5);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_VideoCam, 5, 7);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_Setting, 5, 9);
            this.tlp_HotKeys.Controls.Add(this.tb_VSRHotKey_Info, 5, 11);
            this.tlp_HotKeys.Controls.Add(this.b_SaveHotKeys, 3, 13);
            this.tlp_HotKeys.Controls.Add(this.b_CancelHotKeys, 5, 13);
            this.tlp_HotKeys.Controls.Add(this.b_DefaultHotKeys, 7, 13);
            this.tlp_HotKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_HotKeys.Location = new System.Drawing.Point(3, 3);
            this.tlp_HotKeys.Name = "tlp_HotKeys";
            this.tlp_HotKeys.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tlp_HotKeys.RowCount = 15;
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_HotKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_HotKeys.Size = new System.Drawing.Size(694, 403);
            this.tlp_HotKeys.TabIndex = 0;
            // 
            // l_VSRHotKey_PhotoCam
            // 
            this.l_VSRHotKey_PhotoCam.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_PhotoCam, 3);
            this.l_VSRHotKey_PhotoCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_PhotoCam.Location = new System.Drawing.Point(13, 10);
            this.l_VSRHotKey_PhotoCam.Name = "l_VSRHotKey_PhotoCam";
            this.l_VSRHotKey_PhotoCam.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_PhotoCam.TabIndex = 0;
            this.l_VSRHotKey_PhotoCam.Text = "Keyboard shortcuts for quick screenshot";
            this.l_VSRHotKey_PhotoCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VSRHotKey_PhotoCamSized
            // 
            this.l_VSRHotKey_PhotoCamSized.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_PhotoCamSized, 3);
            this.l_VSRHotKey_PhotoCamSized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_PhotoCamSized.Location = new System.Drawing.Point(13, 46);
            this.l_VSRHotKey_PhotoCamSized.Name = "l_VSRHotKey_PhotoCamSized";
            this.l_VSRHotKey_PhotoCamSized.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_PhotoCamSized.TabIndex = 1;
            this.l_VSRHotKey_PhotoCamSized.Text = "Keyboard shortcuts for custom screenshot";
            this.l_VSRHotKey_PhotoCamSized.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VSRHotKey_TimeLapse
            // 
            this.l_VSRHotKey_TimeLapse.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_TimeLapse, 3);
            this.l_VSRHotKey_TimeLapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_TimeLapse.Location = new System.Drawing.Point(13, 82);
            this.l_VSRHotKey_TimeLapse.Name = "l_VSRHotKey_TimeLapse";
            this.l_VSRHotKey_TimeLapse.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_TimeLapse.TabIndex = 2;
            this.l_VSRHotKey_TimeLapse.Text = "Keyboard shortcuts for time lapse screenshot";
            this.l_VSRHotKey_TimeLapse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VSRHotKey_VideoCam
            // 
            this.l_VSRHotKey_VideoCam.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_VideoCam, 3);
            this.l_VSRHotKey_VideoCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_VideoCam.Location = new System.Drawing.Point(13, 118);
            this.l_VSRHotKey_VideoCam.Name = "l_VSRHotKey_VideoCam";
            this.l_VSRHotKey_VideoCam.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_VideoCam.TabIndex = 3;
            this.l_VSRHotKey_VideoCam.Text = "Keyboard shortcuts for start screen record";
            this.l_VSRHotKey_VideoCam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VSRHotKey_Setting
            // 
            this.l_VSRHotKey_Setting.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_Setting, 3);
            this.l_VSRHotKey_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_Setting.Location = new System.Drawing.Point(13, 154);
            this.l_VSRHotKey_Setting.Name = "l_VSRHotKey_Setting";
            this.l_VSRHotKey_Setting.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_Setting.TabIndex = 4;
            this.l_VSRHotKey_Setting.Text = "Keyboard shortcuts for settings";
            this.l_VSRHotKey_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_VSRHotKey_Info
            // 
            this.l_VSRHotKey_Info.AutoSize = true;
            this.tlp_HotKeys.SetColumnSpan(this.l_VSRHotKey_Info, 3);
            this.l_VSRHotKey_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_VSRHotKey_Info.Location = new System.Drawing.Point(13, 190);
            this.l_VSRHotKey_Info.Name = "l_VSRHotKey_Info";
            this.l_VSRHotKey_Info.Size = new System.Drawing.Size(316, 26);
            this.l_VSRHotKey_Info.TabIndex = 5;
            this.l_VSRHotKey_Info.Text = "Keyboard shortcuts for information";
            this.l_VSRHotKey_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_VSRHotKey_PhotoCam
            // 
            this.tb_VSRHotKey_PhotoCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_PhotoCam.Location = new System.Drawing.Point(345, 13);
            this.tb_VSRHotKey_PhotoCam.Name = "tb_VSRHotKey_PhotoCam";
            this.tb_VSRHotKey_PhotoCam.ReadOnly = true;
            this.tb_VSRHotKey_PhotoCam.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_PhotoCam.TabIndex = 6;
            this.tb_VSRHotKey_PhotoCam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_PhotoCam_KeyDown);
            // 
            // tb_VSRHotKey_PhotoCamSized
            // 
            this.tb_VSRHotKey_PhotoCamSized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_PhotoCamSized.Location = new System.Drawing.Point(345, 49);
            this.tb_VSRHotKey_PhotoCamSized.Name = "tb_VSRHotKey_PhotoCamSized";
            this.tb_VSRHotKey_PhotoCamSized.ReadOnly = true;
            this.tb_VSRHotKey_PhotoCamSized.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_PhotoCamSized.TabIndex = 7;
            this.tb_VSRHotKey_PhotoCamSized.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_PhotoCamSized_KeyDown);
            // 
            // tb_VSRHotKey_TimeLapse
            // 
            this.tb_VSRHotKey_TimeLapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_TimeLapse.Location = new System.Drawing.Point(345, 85);
            this.tb_VSRHotKey_TimeLapse.Name = "tb_VSRHotKey_TimeLapse";
            this.tb_VSRHotKey_TimeLapse.ReadOnly = true;
            this.tb_VSRHotKey_TimeLapse.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_TimeLapse.TabIndex = 8;
            this.tb_VSRHotKey_TimeLapse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_TimeLapse_KeyDown);
            // 
            // tb_VSRHotKey_VideoCam
            // 
            this.tb_VSRHotKey_VideoCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_VideoCam.Location = new System.Drawing.Point(345, 121);
            this.tb_VSRHotKey_VideoCam.Name = "tb_VSRHotKey_VideoCam";
            this.tb_VSRHotKey_VideoCam.ReadOnly = true;
            this.tb_VSRHotKey_VideoCam.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_VideoCam.TabIndex = 9;
            this.tb_VSRHotKey_VideoCam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_VideoCam_KeyDown);
            // 
            // tb_VSRHotKey_Setting
            // 
            this.tb_VSRHotKey_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_Setting.Location = new System.Drawing.Point(345, 157);
            this.tb_VSRHotKey_Setting.Name = "tb_VSRHotKey_Setting";
            this.tb_VSRHotKey_Setting.ReadOnly = true;
            this.tb_VSRHotKey_Setting.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_Setting.TabIndex = 10;
            this.tb_VSRHotKey_Setting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_Setting_KeyDown);
            // 
            // tb_VSRHotKey_Info
            // 
            this.tb_VSRHotKey_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_VSRHotKey_Info.Location = new System.Drawing.Point(345, 193);
            this.tb_VSRHotKey_Info.Name = "tb_VSRHotKey_Info";
            this.tb_VSRHotKey_Info.ReadOnly = true;
            this.tb_VSRHotKey_Info.Size = new System.Drawing.Size(150, 20);
            this.tb_VSRHotKey_Info.TabIndex = 11;
            this.tb_VSRHotKey_Info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_VSRHotKey_Info_KeyDown);
            // 
            // b_SaveHotKeys
            // 
            this.b_SaveHotKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_SaveHotKeys.Location = new System.Drawing.Point(179, 245);
            this.b_SaveHotKeys.Name = "b_SaveHotKeys";
            this.b_SaveHotKeys.Size = new System.Drawing.Size(150, 30);
            this.b_SaveHotKeys.TabIndex = 12;
            this.b_SaveHotKeys.Text = "Save";
            this.b_SaveHotKeys.UseVisualStyleBackColor = true;
            this.b_SaveHotKeys.Click += new System.EventHandler(this.b_SaveHotKeys_Click);
            // 
            // b_CancelHotKeys
            // 
            this.b_CancelHotKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_CancelHotKeys.Location = new System.Drawing.Point(345, 245);
            this.b_CancelHotKeys.Name = "b_CancelHotKeys";
            this.b_CancelHotKeys.Size = new System.Drawing.Size(150, 30);
            this.b_CancelHotKeys.TabIndex = 13;
            this.b_CancelHotKeys.Text = "Cancel";
            this.b_CancelHotKeys.UseVisualStyleBackColor = true;
            this.b_CancelHotKeys.Click += new System.EventHandler(this.b_CancelHotKeys_Click);
            // 
            // b_DefaultHotKeys
            // 
            this.b_DefaultHotKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_DefaultHotKeys.Location = new System.Drawing.Point(511, 245);
            this.b_DefaultHotKeys.Name = "b_DefaultHotKeys";
            this.b_DefaultHotKeys.Size = new System.Drawing.Size(150, 30);
            this.b_DefaultHotKeys.TabIndex = 14;
            this.b_DefaultHotKeys.Text = "Default";
            this.b_DefaultHotKeys.UseVisualStyleBackColor = true;
            this.b_DefaultHotKeys.Click += new System.EventHandler(this.b_DefaultHotKeys_Click);
            // 
            // WindowVSR_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tlp_AllContentAlignment);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "WindowVSR_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variety Screen Recorder";
            this.tlp_AllContentAlignment.ResumeLayout(false);
            this.tc_SettingsMenu.ResumeLayout(false);
            this.tp_MainSetting.ResumeLayout(false);
            this.tlp_MainSettings.ResumeLayout(false);
            this.tlp_MainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TimeLapseScreenshot_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeLapseScreenshot_Interval)).EndInit();
            this.tp_HotKeys.ResumeLayout(false);
            this.tlp_HotKeys.ResumeLayout(false);
            this.tlp_HotKeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_AllContentAlignment;
        private System.Windows.Forms.TabControl tc_SettingsMenu;
        private System.Windows.Forms.TabPage tp_MainSetting;
        private System.Windows.Forms.TabPage tp_HotKeys;
        private System.Windows.Forms.TableLayoutPanel tlp_MainSettings;
        private System.Windows.Forms.Button b_FullSizeScreenshot_Path;
        private System.Windows.Forms.TextBox tb_FullSizeScreenshot_Path;
        private System.Windows.Forms.ComboBox cb_FullSizeScreenshot_Extension;
        private System.Windows.Forms.TextBox tb_SizedScreenshot_Path;
        private System.Windows.Forms.ComboBox cb_SizedScreenshot_Extension;
        private System.Windows.Forms.CheckBox cb_SizedScreenshot_IsEdit;
        private System.Windows.Forms.TextBox tb_TimeLapseScreenshot_Path;
        private System.Windows.Forms.ComboBox cb_TimeLapseScreenshot_Extension;
        private System.Windows.Forms.TrackBar tb_TimeLapseScreenshot_Interval;
        private System.Windows.Forms.NumericUpDown nud_TimeLapseScreenshot_Interval;
        private System.Windows.Forms.TextBox tb_VideoRecord_Path;
        private System.Windows.Forms.Button b_SizedScreenshot_Path;
        private System.Windows.Forms.Button b_TimeLapseScreenshot_Path;
        private System.Windows.Forms.Button b_VideoRecord_Path;
        private System.Windows.Forms.TableLayoutPanel tlp_HotKeys;
        private System.Windows.Forms.Button b_CancelMainSetting;
        private System.Windows.Forms.Button b_SaveMainSettings;
        private System.Windows.Forms.Button b_DefaultMainSetting;
        private System.Windows.Forms.Label l_FullSizeScreenshot_Path;
        private System.Windows.Forms.Label l_FullSizeScreenshot_Extension;
        private System.Windows.Forms.Label l_SizedScreenshot_Path;
        private System.Windows.Forms.Label l_SizedScreenshot_Extension;
        private System.Windows.Forms.Label l_SizedScreenshot_IsEdit;
        private System.Windows.Forms.Label l_TimeLapseScreenshot_Path;
        private System.Windows.Forms.Label l_TimeLapseScreenshot_Extension;
        private System.Windows.Forms.Label l_TimeLapseScreenshot_Interval;
        private System.Windows.Forms.Label l_VideoRecord_Path;
        private System.Windows.Forms.Label l_VSRHotKey_PhotoCam;
        private System.Windows.Forms.Label l_VSRHotKey_PhotoCamSized;
        private System.Windows.Forms.Label l_VSRHotKey_TimeLapse;
        private System.Windows.Forms.Label l_VSRHotKey_VideoCam;
        private System.Windows.Forms.Label l_VSRHotKey_Setting;
        private System.Windows.Forms.Label l_VSRHotKey_Info;
        private System.Windows.Forms.TextBox tb_VSRHotKey_PhotoCam;
        private System.Windows.Forms.TextBox tb_VSRHotKey_PhotoCamSized;
        private System.Windows.Forms.TextBox tb_VSRHotKey_TimeLapse;
        private System.Windows.Forms.TextBox tb_VSRHotKey_VideoCam;
        private System.Windows.Forms.TextBox tb_VSRHotKey_Setting;
        private System.Windows.Forms.TextBox tb_VSRHotKey_Info;
        private System.Windows.Forms.Button b_SaveHotKeys;
        private System.Windows.Forms.Button b_CancelHotKeys;
        private System.Windows.Forms.Button b_DefaultHotKeys;
    }
}