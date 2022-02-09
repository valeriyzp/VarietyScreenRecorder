using System;
using System.Drawing;
using System.Windows.Forms;

namespace VarietyScreenRecorder.WindowVSR
{
    public partial class WindowVSR_ScreenshotCrop : Form
    {
        private static readonly Size MIN_SIZE = new Size(50, 50);

        public Image ResultImage;

        bool isMousePressed = false;

        Rectangle ScreenshotSelectedRectangle;
        Point MousePressedPoint;

        public WindowVSR_ScreenshotCrop(Image image)
        {
            this.Icon = Properties.Resources.Logo;
            this.BackgroundImage = image;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawSelection(e);
        }

        private void WindowVSR_ScreenshotCrop_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMousePressed = true;

                MousePressedPoint = e.Location;
                ScreenshotSelectedRectangle = new Rectangle(MousePressedPoint, new Size(0, 0));
            }
        }

        private void WindowVSR_ScreenshotCrop_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMousePressed)
            {
                int X1 = Math.Min(MousePressedPoint.X, e.X);
                int Y1 = Math.Min(MousePressedPoint.Y, e.Y);
                int X2 = Math.Max(MousePressedPoint.X, e.X);
                int Y2 = Math.Max(MousePressedPoint.Y, e.Y);

                ScreenshotSelectedRectangle = new Rectangle(X1, Y1, X2 - X1 + 1, Y2 - Y1 + 1);
                Invalidate();
            }
        }

        private void WindowVSR_ScreenshotCrop_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isMousePressed = false;
                Invalidate();

                if(IsLegalSize(ScreenshotSelectedRectangle.Size))
                {
                    ResultImage = new Bitmap(ScreenshotSelectedRectangle.Width, ScreenshotSelectedRectangle.Height);
                    Graphics.FromImage(ResultImage).DrawImage(BackgroundImage, 0, 0, ScreenshotSelectedRectangle, GraphicsUnit.Pixel);

                    this.Close();
                }
            }
        }

        private void DrawSelection(PaintEventArgs e)
        {
            Region ScreenshotArea = new Region(new Rectangle(0, 0, this.Width, this.Height));
            if(isMousePressed)
                ScreenshotArea.Exclude(ScreenshotSelectedRectangle);

            Brush RegionBrush = new SolidBrush(Color.FromArgb(191, Color.Black));
            Pen BorderPen = new Pen(new SolidBrush(Color.FromArgb(255, 64, 255, 64)));

            e.Graphics.FillRegion(RegionBrush, ScreenshotArea);
            if(isMousePressed)
                e.Graphics.DrawRectangle(BorderPen, ScreenshotSelectedRectangle.X, ScreenshotSelectedRectangle.Y,
                                                    ScreenshotSelectedRectangle.Width - 1, ScreenshotSelectedRectangle.Height - 1);
        }

        private bool IsLegalSize(Size Nominal)
        {
            if (MIN_SIZE.Width > Nominal.Width || MIN_SIZE.Height > Nominal.Height)
                return false;
            else
                return true;
        }
    }
}
