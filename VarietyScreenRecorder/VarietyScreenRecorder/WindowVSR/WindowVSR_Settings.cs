using System;
using System.Windows.Forms;
using VarietyScreenRecorder.ExtraClass;

namespace VarietyScreenRecorder.WindowVSR
{
    public partial class WindowVSR_Settings : Form
    {
        public WindowVSR_Settings()
        {
            this.Icon = Properties.Resources.Logo;

            InitializeComponent();

            GetMainSettings();
            GetHotKeys();
        }

        private void SetDefaultMainSettings()
        {
            Properties.Settings.Default.FullSizeScreenshot_Path = "";
            Properties.Settings.Default.FullSizeScreenshot_Extension = "png";

            Properties.Settings.Default.SizedScreenshot_Path = "";
            Properties.Settings.Default.SizedScreenshot_Extension = "png";
            Properties.Settings.Default.SizedScreenshot_IsEdit = true;

            Properties.Settings.Default.TimeLapseScreenshot_Path = "";
            Properties.Settings.Default.TimeLapseScreenshot_Extension = "png";
            Properties.Settings.Default.TimeLapseScreenshot_Interval = 5;

            Properties.Settings.Default.VideoRecord_Path = "";

            Properties.Settings.Default.Save();
        }

        private void SetDefaultHotKeys()
        {
            Properties.Settings.Default.VSRHotKey_PhotoCam = "Ctrl+P";
            Properties.Settings.Default.VSRHotKey_PhotoCamSized = "Ctrl+C";
            Properties.Settings.Default.VSRHotKey_TimeLapse = "Ctrl+T";
            Properties.Settings.Default.VSRHotKey_VideoCam = "Ctrl+V";
            Properties.Settings.Default.VSRHotKey_Setting = "Ctrl+S";
            Properties.Settings.Default.VSRHotKey_Info = "Ctrl+I";

            Properties.Settings.Default.Save();
        }

        private void GetMainSettings()
        {
            tb_FullSizeScreenshot_Path.Text = Properties.Settings.Default.FullSizeScreenshot_Path == "" ? Environment.CurrentDirectory + "\\Screenshots" : Properties.Settings.Default.FullSizeScreenshot_Path;
            cb_FullSizeScreenshot_Extension.SelectedItem =  Properties.Settings.Default.FullSizeScreenshot_Extension;

            tb_SizedScreenshot_Path.Text = Properties.Settings.Default.SizedScreenshot_Path == "" ? Environment.CurrentDirectory + "\\SizedScreenshots" : Properties.Settings.Default.SizedScreenshot_Path;
            cb_SizedScreenshot_Extension.SelectedItem = Properties.Settings.Default.SizedScreenshot_Extension;
            cb_SizedScreenshot_IsEdit.Checked = Properties.Settings.Default.SizedScreenshot_IsEdit;

            tb_TimeLapseScreenshot_Path.Text = Properties.Settings.Default.TimeLapseScreenshot_Path == "" ? Environment.CurrentDirectory + "\\TimeLapses" : Properties.Settings.Default.TimeLapseScreenshot_Path;
            cb_TimeLapseScreenshot_Extension.SelectedItem = Properties.Settings.Default.TimeLapseScreenshot_Extension;
            tb_TimeLapseScreenshot_Interval.Value = Properties.Settings.Default.TimeLapseScreenshot_Interval;
            nud_TimeLapseScreenshot_Interval.Value = Properties.Settings.Default.TimeLapseScreenshot_Interval;

            tb_VideoRecord_Path.Text = Properties.Settings.Default.VideoRecord_Path == "" ? Environment.CurrentDirectory + "\\VideoRecords" : Properties.Settings.Default.VideoRecord_Path;
        }

        private void GetHotKeys()
        {
            tb_VSRHotKey_PhotoCam.Text = Properties.Settings.Default.VSRHotKey_PhotoCam;
            tb_VSRHotKey_PhotoCamSized.Text = Properties.Settings.Default.VSRHotKey_PhotoCamSized;
            tb_VSRHotKey_TimeLapse.Text = Properties.Settings.Default.VSRHotKey_TimeLapse;
            tb_VSRHotKey_VideoCam.Text = Properties.Settings.Default.VSRHotKey_VideoCam;
            tb_VSRHotKey_Setting.Text = Properties.Settings.Default.VSRHotKey_Setting;
            tb_VSRHotKey_Info.Text = Properties.Settings.Default.VSRHotKey_Info;
        }

        private void SaveMainSettings()
        {
            Properties.Settings.Default.FullSizeScreenshot_Path = tb_FullSizeScreenshot_Path.Text == Environment.CurrentDirectory + "\\Screenshots" ? "" : tb_FullSizeScreenshot_Path.Text;
            Properties.Settings.Default.FullSizeScreenshot_Extension = (string)cb_FullSizeScreenshot_Extension.SelectedItem;

            Properties.Settings.Default.SizedScreenshot_Path = tb_SizedScreenshot_Path.Text == Environment.CurrentDirectory + "\\SizedScreenshots" ? "" : tb_SizedScreenshot_Path.Text;
            Properties.Settings.Default.SizedScreenshot_Extension = (string)cb_SizedScreenshot_Extension.SelectedItem;
            Properties.Settings.Default.SizedScreenshot_IsEdit = cb_SizedScreenshot_IsEdit.Checked;

            Properties.Settings.Default.TimeLapseScreenshot_Path = tb_TimeLapseScreenshot_Path.Text == Environment.CurrentDirectory + "\\TimeLapses" ? "" : tb_TimeLapseScreenshot_Path.Text;
            Properties.Settings.Default.TimeLapseScreenshot_Extension = (string)cb_TimeLapseScreenshot_Extension.SelectedItem;
            Properties.Settings.Default.TimeLapseScreenshot_Interval = tb_TimeLapseScreenshot_Interval.Value;

            Properties.Settings.Default.VideoRecord_Path = tb_VideoRecord_Path.Text == Environment.CurrentDirectory + "\\VideoRecords" ? "" : tb_VideoRecord_Path.Text;

            Properties.Settings.Default.Save();
        }

        private void SaveHotKeys()
        {
            Properties.Settings.Default.VSRHotKey_PhotoCam = tb_VSRHotKey_PhotoCam.Text;
            Properties.Settings.Default.VSRHotKey_PhotoCamSized = tb_VSRHotKey_PhotoCamSized.Text;
            Properties.Settings.Default.VSRHotKey_TimeLapse = tb_VSRHotKey_TimeLapse.Text;
            Properties.Settings.Default.VSRHotKey_VideoCam = tb_VSRHotKey_VideoCam.Text;
            Properties.Settings.Default.VSRHotKey_Setting = tb_VSRHotKey_Setting.Text;
            Properties.Settings.Default.VSRHotKey_Info = tb_VSRHotKey_Info.Text;

            Properties.Settings.Default.Save();
        }

        private string GetNewPath(string CurrentPath)
        {
            string NewPath = "";

            FolderBrowserDialog NewFolderWindow = new FolderBrowserDialog();
            NewFolderWindow.SelectedPath = CurrentPath;
            NewFolderWindow.Description = "Choose folder...";

            if (NewFolderWindow.ShowDialog() == DialogResult.OK)
                NewPath = NewFolderWindow.SelectedPath;
            else
                NewPath = CurrentPath;

            return NewPath;
        }

        private void b_FullSizeScreenshot_Path_Click(object sender, EventArgs e)
        {
            tb_FullSizeScreenshot_Path.Text = GetNewPath(tb_FullSizeScreenshot_Path.Text);
        }

        private void b_SizedScreenshot_Path_Click(object sender, EventArgs e)
        {
            tb_SizedScreenshot_Path.Text = GetNewPath(tb_SizedScreenshot_Path.Text);
        }

        private void b_TimeLapseScreenshot_Path_Click(object sender, EventArgs e)
        {
            tb_TimeLapseScreenshot_Path.Text = GetNewPath(tb_TimeLapseScreenshot_Path.Text);
        }

        private void b_VideoRecord_Path_Click(object sender, EventArgs e)
        {
            tb_VideoRecord_Path.Text = GetNewPath(tb_VideoRecord_Path.Text);
        }

        private void tb_TimeLapseScreenshot_Interval_Scroll(object sender, EventArgs e)
        {
            nud_TimeLapseScreenshot_Interval.Value = tb_TimeLapseScreenshot_Interval.Value;
        }

        private void nud_TimeLapseScreenshot_Interval_ValueChanged(object sender, EventArgs e)
        {
            tb_TimeLapseScreenshot_Interval.Value = (int)nud_TimeLapseScreenshot_Interval.Value;
        }

        private void b_DefaultMainSetting_Click(object sender, EventArgs e)
        {
            SetDefaultMainSettings();

            GetMainSettings();
        }

        private void b_CancelMainSetting_Click(object sender, EventArgs e)
        {
            GetMainSettings();
        }

        private void b_SaveMainSettings_Click(object sender, EventArgs e)
        {
            SaveMainSettings();

            GetMainSettings();
        }


        private void DiscardHotKey(string HotKey)
        {
            if (tb_VSRHotKey_PhotoCam.Text == HotKey) tb_VSRHotKey_PhotoCam.Text = "";
            if (tb_VSRHotKey_PhotoCamSized.Text == HotKey) tb_VSRHotKey_PhotoCamSized.Text = "";
            if (tb_VSRHotKey_TimeLapse.Text == HotKey) tb_VSRHotKey_TimeLapse.Text = "";
            if (tb_VSRHotKey_VideoCam.Text == HotKey) tb_VSRHotKey_VideoCam.Text = "";
            if (tb_VSRHotKey_Setting.Text == HotKey) tb_VSRHotKey_Setting.Text = "";
            if (tb_VSRHotKey_Info.Text == HotKey) tb_VSRHotKey_Info.Text = "";
        }


        private string GetNewHotKey(KeyEventArgs e)
        {
            string NewHotKey = "";

            if (HotKeyManager.isHotKey(e))
            {
                NewHotKey = HotKeyManager.GetHotKey(e);
                DiscardHotKey(NewHotKey);
            }

            return NewHotKey;
        }

        private void tb_VSRHotKey_PhotoCam_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_PhotoCam.Text = GetNewHotKey(e);
        }

        private void tb_VSRHotKey_PhotoCamSized_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_PhotoCamSized.Text = GetNewHotKey(e);
        }

        private void tb_VSRHotKey_TimeLapse_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_TimeLapse.Text = GetNewHotKey(e);
        }

        private void tb_VSRHotKey_VideoCam_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_VideoCam.Text = GetNewHotKey(e);
        }

        private void tb_VSRHotKey_Setting_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_Setting.Text = GetNewHotKey(e);
        }

        private void tb_VSRHotKey_Info_KeyDown(object sender, KeyEventArgs e)
        {
            tb_VSRHotKey_Info.Text = GetNewHotKey(e);
        }

        private void b_DefaultHotKeys_Click(object sender, EventArgs e)
        {
            SetDefaultHotKeys();

            GetHotKeys();
        }

        private void b_CancelHotKeys_Click(object sender, EventArgs e)
        {
            GetHotKeys();
        }

        private void b_SaveHotKeys_Click(object sender, EventArgs e)
        {
            SaveHotKeys();

            GetHotKeys();
        }
    }
}
