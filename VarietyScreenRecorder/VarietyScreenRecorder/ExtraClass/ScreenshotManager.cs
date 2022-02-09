using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VarietyScreenRecorder.ExtraClass
{
    class ScreenshotManager
    {
        public static Image MakeScreenshot()
        {
            Image Screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics ScreenshotGraphics = Graphics.FromImage(Screenshot);

            ScreenshotGraphics.CopyFromScreen(0, 0, 0, 0, Screenshot.Size);

            return Screenshot;
        }

        public static void SaveScreenshot(Image Screenshot, string Path, string Filename, string Extension = "png")
        {
            if (Extension == "")
                Extension = "png";

            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            switch (Extension)
            {
                case "png":
                    {
                        Screenshot.Save(Path + "\\" + Filename + "." + Extension, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    }
                case "jpeg":
                    {
                        Screenshot.Save(Path + "\\" + Filename + "." + Extension, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    }
                case "bmp":
                    {
                        Screenshot.Save(Path + "\\" + Filename + "." + Extension, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    }
                case "gif":
                    {
                        Screenshot.Save(Path + "\\" + Filename + "." + Extension, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    }
            }
        }
    }
}
