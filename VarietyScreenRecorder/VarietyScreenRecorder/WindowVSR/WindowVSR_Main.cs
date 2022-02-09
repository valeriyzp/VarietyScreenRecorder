using System;
using System.Drawing;
using System.Windows.Forms;
using VarietyScreenRecorder.WindowVSR;
using VarietyScreenRecorder.ExtraClass;
using VarietyScreenRecorder.Window_GE;

namespace VarietyScreenRecorder
{
    public partial class WindowVSR_Main : Form
    {
        private VideoManager VideoRecorder = new VideoManager();

        public WindowVSR_Main()
        {
            this.Icon = Properties.Resources.Logo;

            InitializeComponent();

            b_PhotoCam.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            b_PhotoCamSized.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            b_TimeLapse.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            b_VideoCam.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            b_Settings.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            b_Info.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private Image MakeScreenshot()
        {
            this.Opacity = 0;
            Image Screenshot = ScreenshotManager.MakeScreenshot();
            this.Opacity = 1;

            return Screenshot;
        }

        private void MakeFullSizeScreenshot()
        {
            Image Screenshot = MakeScreenshot();
            Clipboard.SetImage(Screenshot);

            string PathToFile = Properties.Settings.Default.FullSizeScreenshot_Path == "" ? Environment.CurrentDirectory + "\\Screenshots" : Properties.Settings.Default.FullSizeScreenshot_Path;
            string Filename = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

            ScreenshotManager.SaveScreenshot(Screenshot, PathToFile, Filename, Properties.Settings.Default.FullSizeScreenshot_Extension);

            Screenshot.Dispose();
        }

        private void MakeSizedScreenshot()
        {
            Image Screenshot = MakeScreenshot();

            WindowVSR_ScreenshotCrop CropWindow = new WindowVSR_ScreenshotCrop(Screenshot);
            CropWindow.ShowDialog();

            Screenshot.Dispose();
            Screenshot = CropWindow.ResultImage;

            if (Screenshot != null)
            {
                Clipboard.SetImage(Screenshot);

                string PathToFile = Properties.Settings.Default.SizedScreenshot_Path == "" ? Environment.CurrentDirectory + "\\SizedScreenshots" : Properties.Settings.Default.SizedScreenshot_Path;
                string Filename = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

                ScreenshotManager.SaveScreenshot(Screenshot, PathToFile, Filename, Properties.Settings.Default.SizedScreenshot_Extension);
                
                if(Properties.Settings.Default.SizedScreenshot_IsEdit)
                {
                    WindowGE_Main GraphicsEditor = new WindowGE_Main(Screenshot);
                    GraphicsEditor.Show();
                }
                else
                {
                    Screenshot.Dispose();
                }
            }

            CropWindow.Dispose();
        }

        private void MakeTimeLapseScreenshot()
        {
            Image Screenshot = MakeScreenshot();

            string PathToFile = Properties.Settings.Default.TimeLapseScreenshot_Path == "" ? Environment.CurrentDirectory + "\\TimeLapses" : Properties.Settings.Default.TimeLapseScreenshot_Path;
            string Filename = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

            ScreenshotManager.SaveScreenshot(Screenshot, PathToFile, Filename, Properties.Settings.Default.TimeLapseScreenshot_Extension);

            Screenshot.Dispose();
        }

        private void b_PhotoCam_Click(object sender, EventArgs e)
        {
            b_PhotoCam.BackgroundImage = Properties.Resources.ActiveButton_PhotoCam;
            b_PhotoCam.Refresh();

            MakeFullSizeScreenshot();

            b_PhotoCam.BackgroundImage = Properties.Resources.NotActiveButton_PhotoCam;
            b_PhotoCam.Refresh();
        }

        private void b_PhotoCamSized_Click(object sender, EventArgs e)
        {
            b_PhotoCamSized.BackgroundImage = Properties.Resources.ActiveButton_PhotoCamSized;
            b_PhotoCamSized.Refresh();

            MakeSizedScreenshot();

            b_PhotoCamSized.BackgroundImage = Properties.Resources.NotActiveButton_PhotoCamSized;
            b_PhotoCamSized.Refresh();
        }

        private void b_TimeLapse_Click(object sender, EventArgs e)
        {
            if(t_TimeLapseTimer.Enabled)
            {
                b_TimeLapse.BackgroundImage = Properties.Resources.NotActiveButton_TimeLapse;
                b_TimeLapse.Refresh();

                t_TimeLapseTimer.Stop();
            }
            else
            {
                b_TimeLapse.BackgroundImage = Properties.Resources.ActiveButton_TimeLapse;
                b_TimeLapse.Refresh();

                t_TimeLapseTimer.Interval = Properties.Settings.Default.TimeLapseScreenshot_Interval * 1000;
                t_TimeLapseTimer.Start();
            }
        }

        private void t_TimeLapseTimer_Tick(object sender, EventArgs e)
        {
            MakeTimeLapseScreenshot();
        }

        private void b_VideoCam_Click(object sender, EventArgs e)
        {
            if (t_VideoCamTimer.Enabled)
            {
                l_VideoCamTime.Text = "Saving..";
                l_VideoCamTime.Refresh();

                VideoRecorder.StopRecording();
                t_VideoCamTimer.Enabled = false;

                b_VideoCam.BackgroundImage = Properties.Resources.NotActiveButton_VideoCam;
                b_VideoCam.Refresh();

                l_VideoCamTime.Text = "--:--:--";
                l_VideoCamTime.Refresh();
            }
            else
            {
                b_VideoCam.BackgroundImage = Properties.Resources.ActiveButton_VideoCam;
                b_VideoCam.Refresh();

                l_VideoCamTime.Text = "00:00:00";
                l_VideoCamTime.Refresh();

                string PathToFile = Properties.Settings.Default.VideoRecord_Path == "" ? Environment.CurrentDirectory + "\\VideoRecords" : Properties.Settings.Default.VideoRecord_Path;
                string Filename = DateTime.Now.ToString("yyyyMMdd_HHmmssfff");

                VideoRecorder.StartRecording(PathToFile, Filename);
                t_VideoCamTimer.Enabled = true;
            }
        }

        private void t_VideoCamTimer_Tick(object sender, EventArgs e)
        {
            l_VideoCamTime.Text = VideoRecorder.GetRecordingTime();
            l_VideoCamTime.Refresh();
        }

        private void b_Info_Click(object sender, EventArgs e)
        {
            b_Info.BackgroundImage = Properties.Resources.ActiveButton_Info;
            b_Info.Refresh();

            WindowVSR_Information InformationWindow = new WindowVSR_Information();
            InformationWindow.ShowDialog();

            InformationWindow.Dispose();

            b_Info.BackgroundImage = Properties.Resources.NotActiveButton_Info;
            b_Info.Refresh();
        }

        private void WindowVSR_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(HotKeyManager.isHotKey(e))
            {
                string HotKey = HotKeyManager.GetHotKey(e);

                if(HotKey == Properties.Settings.Default.VSRHotKey_PhotoCam)
                {
                    b_PhotoCam.PerformClick();
                }
                else if(HotKey == Properties.Settings.Default.VSRHotKey_PhotoCamSized)
                {
                    b_PhotoCamSized.PerformClick();
                }
                else if (HotKey == Properties.Settings.Default.VSRHotKey_TimeLapse)
                {
                    b_TimeLapse.PerformClick();
                }
                else if (HotKey == Properties.Settings.Default.VSRHotKey_VideoCam)
                {
                    b_VideoCam.PerformClick();
                }
                else if (HotKey == Properties.Settings.Default.VSRHotKey_Setting)
                {
                    b_Settings.PerformClick();
                }
                else if (HotKey == Properties.Settings.Default.VSRHotKey_Info)
                {
                    b_Info.PerformClick();
                }
            }
        }

        private void b_Settings_Click(object sender, EventArgs e)
        {
            b_Settings.BackgroundImage = Properties.Resources.ActiveButton_Settings;
            b_Settings.Refresh();

            WindowVSR_Settings SettingsWindow = new WindowVSR_Settings();
            SettingsWindow.ShowDialog();

            SettingsWindow.Dispose();

            b_Settings.BackgroundImage = Properties.Resources.NotActiveButton_Settings;
            b_Settings.Refresh();
        }
    }
}
