using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using VarietyScreenRecorder.ExtraClass;

namespace VarietyScreenRecorder.Window_GE
{
    public partial class WindowGE_Main : Form
    {
        private static readonly Color ActiveElementColor = Color.FromArgb(64, 255, 64);
        private static readonly Color NotActiveElementColor = SystemColors.Control;

        private ShapeCursor CursorShape;
        private Color ActiveColor = Color.Black;
        private Color ActiveFillColor = Color.White;
        private int LineWidth = 10;
        private int TextSize = 14;
        private string ActiveText = "Default";

        private string RectangleType = "Rectangle";
        private string EllipseType = "Ellipse";
        private string LineType = "Line";

        private string ActiveTool = "None";
        private IShape ActiveElement = null;

        private Bitmap Translucent;
        private Bitmap NotTransparent;
        private Graphics TranslucentGraphics;
        private Graphics NotTransparentGraphics;

        private static readonly float OnePointLineHelper = 0.01f;

        private ShapesHistory Shapes;

        private string FilePath = "";
        private string FileName = "";
        private string FileExtension = "";
        private bool IsSave = false;

        public class ShapesHistory
        {
            public int VisibleShapesCount { get; set; }
            public List<IShape> History { get; set; }

            public ShapesHistory()
            {
                History = new List<IShape>();
                VisibleShapesCount = 0;
            }

            public void Add(IShape shape)
            {
                if (VisibleShapesCount != History.Count)
                {
                    History.RemoveRange(VisibleShapesCount, History.Count - VisibleShapesCount);
                }

                History.Add(shape);
                VisibleShapesCount++;
            }

            public void Undo()
            {
                VisibleShapesCount = VisibleShapesCount <= 0 ? 0 : VisibleShapesCount - 1;
            }

            public bool CanUndo()
            {
                return VisibleShapesCount > 0 ? true : false;
            }

            public void Redo()
            {
                VisibleShapesCount = VisibleShapesCount >= History.Count ? History.Count : VisibleShapesCount + 1;
            }

            public bool CanRedo()
            {
                return VisibleShapesCount == History.Count ? false : true;
            }

            public void Draw(Graphics Translucent, Graphics NotTransparent)
            {
                for (int i = 0; i < VisibleShapesCount; ++i)
                    History[i].Draw(Translucent, NotTransparent);
            }
        }

        public WindowGE_Main(Image image)
        {
            this.Icon = Properties.Resources.Logo;

            InitializeComponent();
            pb_Image.Image = image;
            this.Text = DateTime.Now.ToString("yyyyMMdd_HHmmssfff") + "*";

            Translucent = new Bitmap(image.Width, image.Height);
            NotTransparent = new Bitmap(image.Width, image.Height);

            TranslucentGraphics = Graphics.FromImage(Translucent);
            NotTransparentGraphics = Graphics.FromImage(NotTransparent);

            TranslucentGraphics.SmoothingMode = SmoothingMode.None;
            TranslucentGraphics.CompositingMode = CompositingMode.SourceCopy;

            NotTransparentGraphics.SmoothingMode = SmoothingMode.HighQuality;
            NotTransparentGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            CursorShape = new ShapeCursor(image.Width, image.Height);
            Shapes = new ShapesHistory();
        }

        private void SetButtonsNotActiveElementColor()
        {
            tsb_Pen.BackColor = NotActiveElementColor;
            tsb_Marker.BackColor = NotActiveElementColor;
            tsb_Text.BackColor = NotActiveElementColor;
            tsb_LineArrow.BackColor = NotActiveElementColor;
            tsb_Rectangle.BackColor = NotActiveElementColor;
            tsb_Ellipse.BackColor = NotActiveElementColor;
        }

        private void SetToolStripButtonStatus(ToolStripButton Button)
        {
            if (Button.BackColor == NotActiveElementColor)
                Button.BackColor = ActiveElementColor;
            else
                Button.BackColor = NotActiveElementColor;
        }

        private void SetToolStripSplitButtonStatus(ToolStripSplitButton Button)
        {
            if (Button.BackColor == NotActiveElementColor)
                Button.BackColor = ActiveElementColor;
            else
                Button.BackColor = NotActiveElementColor;
        }

        private void tsb_Cursor_Click(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripButtonStatus((ToolStripButton)sender);
            if (tsb_Cursor.BackColor == ActiveElementColor)
            {
                ActiveTool = "Cursor";
                CursorShape.IsActive = true;
            }
            else
            {
                ActiveTool = "None";
                CursorShape.IsActive = false;
            }

            if (IsSave)
            {
                IsSave = false;
                this.Text += "*";
            }

            pb_Image.Refresh();
        }

        private void tsb_Pen_Click(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripButtonStatus((ToolStripButton)sender);
            ActiveTool = "Pen";
        }

        private void tsb_Marker_Click(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripButtonStatus((ToolStripButton)sender);
            ActiveTool = "Marker";
        }

        private void tsb_Text_Click(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripButtonStatus((ToolStripButton)sender);
            ActiveTool = "Text";

            ActiveText = GetText("Write your text", ActiveText);
        }

        private void tsb_Line_Click(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripButtonStatus((ToolStripButton)sender);
            ActiveTool = "Line";
        }

        private void tsb_LineArrow_ButtonClick(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripSplitButtonStatus((ToolStripSplitButton)sender);
            ActiveTool = LineType;
        }

        private void tsmi_Line_Click(object sender, EventArgs e)
        {
            tsb_LineArrow.Image = Properties.Resources.GE_Line;
            LineType = "Line";
            tsb_LineArrow.PerformButtonClick();
        }

        private void tsmi_Arrow_Click(object sender, EventArgs e)
        {
            tsb_LineArrow.Image = Properties.Resources.GE_Arrow;
            LineType = "Arrow";
            tsb_LineArrow.PerformButtonClick();
        }

        private void tsb_Rectangle_ButtonClick(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripSplitButtonStatus((ToolStripSplitButton)sender);
            ActiveTool = RectangleType;
        }

        private void tsmi_Rectangle_Click(object sender, EventArgs e)
        {
            tsb_Rectangle.Image = Properties.Resources.GE_Rectangle;
            RectangleType = "Rectangle";
            tsb_Rectangle.PerformButtonClick();
        }

        private void tsmi_FillRectangle_Click(object sender, EventArgs e)
        {
            tsb_Rectangle.Image = Properties.Resources.GE_FillRectangle;
            RectangleType = "FillRectangle";
            tsb_Rectangle.PerformButtonClick();
        }

        private void tsb_Ellipse_ButtonClick(object sender, EventArgs e)
        {
            SetButtonsNotActiveElementColor();
            SetToolStripSplitButtonStatus((ToolStripSplitButton)sender);
            ActiveTool = EllipseType;
        }

        private void tsmi_Ellipse_Click(object sender, EventArgs e)
        {
            tsb_Ellipse.Image = Properties.Resources.GE_Ellipse;
            EllipseType = "Ellipse";
            tsb_Ellipse.PerformButtonClick();
        }

        private void tsmi_FillEllipse_Click(object sender, EventArgs e)
        {
            tsb_Ellipse.Image = Properties.Resources.GE_FillEllipse;
            EllipseType = "FillEllipse";
            tsb_Ellipse.PerformButtonClick();
        }

        private void tsb_Color_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPicker = new ColorDialog();
            ColorPicker.Color = ActiveColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
                ActiveColor = ColorPicker.Color;
        }

        private void tsb_FillColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorPicker = new ColorDialog();
            ColorPicker.Color = ActiveFillColor;
            if (ColorPicker.ShowDialog() == DialogResult.OK)
                ActiveFillColor = ColorPicker.Color;
        }

        private int GetSize(string Text, int StartValue)
        {
            WindowGE_GetSize GetSizeWindow = new WindowGE_GetSize(Text, StartValue);
            GetSizeWindow.ShowDialog();

            if (GetSizeWindow.isSet)
                StartValue = (int)GetSizeWindow.nud_Size.Value;

            GetSizeWindow.Dispose();
            return StartValue;
        }

        private void tsb_LineWidth_Click(object sender, EventArgs e)
        {
            LineWidth = GetSize("Select line width", LineWidth);
        }

        private void tsb_TextSize_Click(object sender, EventArgs e)
        {
            TextSize = GetSize("Select text size", TextSize);
        }

        private string GetText(string Text, string ActiveText)
        {
            WindowGE_GetText GetTextWindow = new WindowGE_GetText(Text, ActiveText);
            GetTextWindow.ShowDialog();

            if (GetTextWindow.isSet)
                ActiveText = GetTextWindow.tb_TextValue.Text;

            GetTextWindow.Dispose();
            return ActiveText;
        }

        public interface IShape
        {
            void Draw(Graphics translucent, Graphics notTransparent);
            void Draw(Graphics graphics);
            void NewCursorPoint(Point currentCursorPosition);
            void UpdateModifierKey(bool shift);
        }

        public class ShapeCursor : IShape
        {
            public Point CursorPosition { get; set; }
            public Point MaxPosition { get; set; }
            public bool IsActive { get; set; } = false;

            public ShapeCursor(int imageWidth, int imageHeight)
            {
                CursorPosition = new Point(0, 0);
                MaxPosition = new Point(imageWidth - 1, imageHeight - 1);
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                if (IsActive)
                {
                    graphics.DrawImage(Properties.Resources.GE_CursorImage, new Rectangle(CursorPosition, Properties.Resources.GE_CursorImage.Size));
                }

            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                int X = currentCursorPosition.X, Y = currentCursorPosition.Y;

                if (X < 0) X = 0;
                else if (X > MaxPosition.X) X = MaxPosition.X;

                if (Y < 0) Y = 0;
                else if (Y > MaxPosition.Y) Y = MaxPosition.Y;

                CursorPosition = new Point(X, Y);
            }

            public void UpdateModifierKey(bool shift)
            {
                ;
            }
        }

        public class ShapeText : IShape
        {
            public string Text { get; set; }
            public Font TextFont { get; set; }
            public SolidBrush TextSolidBrush { get; set; }
            public Point TextPosition { get; set; }

            public ShapeText(string text, int textSize, Point position, Color color)
            {
                Text = text;
                TextFont = new Font("Microsoft Sans Serif", textSize, FontStyle.Regular);
                TextPosition = position;
                TextSolidBrush = new SolidBrush(color);
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                graphics.DrawString(Text, TextFont, TextSolidBrush, TextPosition);
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                TextPosition = currentCursorPosition;
            }

            public void UpdateModifierKey(bool shift)
            {
                ;
            }
        }

        public static void SetUpPen(Pen pen)
        {
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.LineJoin = LineJoin.Round;
            pen.MiterLimit = 0;
        }

        public static void SetUpPenForArrow(Pen pen)
        {
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;
            pen.LineJoin = LineJoin.Round;
            pen.MiterLimit = 0;
        }

        public class ShapeMarker : IShape
        {
            public Pen MarkerPen { get; set; }
            public List<Point> MarkerPoints { get; set; }

            public ShapeMarker(int lineWidth, Point position)
            {
                MarkerPoints = new List<Point>();
                MarkerPoints.Add(position);
                MarkerPen = new Pen(Color.FromArgb(127, 64, 255, 64), lineWidth);
                SetUpPen(MarkerPen);
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(translucent);
            }

            public void Draw(Graphics graphics)
            {
                if (MarkerPoints.Count == 1)
                    graphics.DrawLine(MarkerPen, MarkerPoints[0].X - OnePointLineHelper, MarkerPoints[0].Y - OnePointLineHelper, MarkerPoints[0].X, MarkerPoints[0].Y);
                else
                    graphics.DrawLines(MarkerPen, MarkerPoints.ToArray());
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                MarkerPoints.Add(currentCursorPosition);
            }
            public void UpdateModifierKey(bool shift)
            {
                ;
            }
        }

        public class ShapePen : IShape
        {
            public Pen PenPen { get; set; }
            public List<Point> PenPoints { get; set; }

            public ShapePen(int lineWidth, Color color, Point position)
            {
                PenPoints = new List<Point>();
                PenPoints.Add(position);
                PenPen = new Pen(color, lineWidth);
                SetUpPen(PenPen);
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                if (PenPoints.Count == 1)
                    graphics.DrawLine(PenPen, PenPoints[0].X - OnePointLineHelper, PenPoints[0].Y - OnePointLineHelper, PenPoints[0].X, PenPoints[0].Y);
                else
                    graphics.DrawLines(PenPen, PenPoints.ToArray());
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                PenPoints.Add(currentCursorPosition);
            }

            public void UpdateModifierKey(bool shift)
            {
                ;
            }
        }

        public class ShapeLine : IShape
        {
            public Pen PenLine { get; set; }
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            public Point SaveLineEndPoint { get; set; }
            private bool IsValidEndPoint = false;
            private bool IsShift = false;

            public ShapeLine(int lineWidth, Color color, Point position, bool isArrow)
            {
                StartPoint = position;

                PenLine = new Pen(color, lineWidth);

                if (isArrow)
                    SetUpPenForArrow(PenLine);
                else
                    SetUpPen(PenLine);
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                if (IsValidEndPoint)
                    graphics.DrawLine(PenLine, StartPoint, EndPoint);
                else
                    graphics.DrawLine(PenLine, StartPoint.X - OnePointLineHelper, StartPoint.Y - OnePointLineHelper, StartPoint.X, StartPoint.Y);
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                if (currentCursorPosition.X == StartPoint.X && currentCursorPosition.Y == StartPoint.Y)
                    IsValidEndPoint = false;
                else
                    IsValidEndPoint = true;

                EndPoint = currentCursorPosition;
                if (IsShift)
                    MakeCorrectLine();
            }

            public void UpdateModifierKey(bool shift)
            {
                if (IsShift != shift)
                {
                    IsShift = shift;

                    if (IsShift)
                        MakeCorrectLine();
                    else
                        UnMakeCorrectLine();
                }
            }

            private void MakeCorrectLine()
            {
                int X1 = StartPoint.X;
                int Y1 = StartPoint.Y;
                int X2 = EndPoint.X;
                int Y2 = EndPoint.Y;

                int SizeX = Math.Abs(X1 - EndPoint.X);
                int SizeY = Math.Abs(Y1 - EndPoint.Y);

                if (SizeX > SizeY)
                    Y2 = Y1;
                else
                    X2 = X1;

                SaveLineEndPoint = EndPoint;
                EndPoint = new Point(X2, Y2);
            }

            private void UnMakeCorrectLine()
            {
                EndPoint = SaveLineEndPoint;
            }
        }

        public class ShapeRectangle : IShape
        {
            public Pen PenRectangle { get; set; }
            public SolidBrush BrushFillRectangle { get; set; }
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            public Point SaveRectangleEndPoint { get; set; }
            private bool IsValidEndPoint = false;
            private bool IsShift = false;

            public ShapeRectangle(int lineWidth, Color activeColor, Point position)
            {
                StartPoint = position;

                PenRectangle = new Pen(activeColor, lineWidth);
                SetUpPen(PenRectangle);

                BrushFillRectangle = new SolidBrush(Color.Transparent);

                StartPoint = position;
            }

            public ShapeRectangle(int lineWidth, Color activeColor, Color fillColor, Point position)
            {
                StartPoint = position;

                PenRectangle = new Pen(activeColor, lineWidth);
                SetUpPen(PenRectangle);

                BrushFillRectangle = new SolidBrush(fillColor);

                StartPoint = position;
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                if (IsValidEndPoint)
                {
                    if(StartPoint.X == EndPoint.X || StartPoint.Y == EndPoint.Y)
                    {
                        graphics.DrawLine(PenRectangle, StartPoint, EndPoint);
                    }
                    else
                    {
                        int X1 = Math.Min(StartPoint.X, EndPoint.X);
                        int Y1 = Math.Min(StartPoint.Y, EndPoint.Y);
                        int X2 = Math.Max(StartPoint.X, EndPoint.X);
                        int Y2 = Math.Max(StartPoint.Y, EndPoint.Y);

                        int width = X2 - X1;
                        int height = Y2 - Y1;

                        if (width < PenRectangle.Width && height < PenRectangle.Width)
                        {
                            graphics.DrawLine(PenRectangle, X1, Y1, X2, Y1);
                            graphics.DrawLine(PenRectangle, X2, Y1, X2, Y2);
                            graphics.DrawLine(PenRectangle, X2, Y2, X1, Y2);
                            graphics.DrawLine(PenRectangle, X1, Y2, X1, Y1);
                        }
                        else
                        {
                            graphics.FillRectangle(BrushFillRectangle, X1, Y1, X2 - X1, Y2 - Y1);
                            graphics.DrawRectangle(PenRectangle, X1, Y1, X2 - X1, Y2 - Y1);
                        }
                    }
                }
                else
                {
                    graphics.DrawLine(PenRectangle, StartPoint.X - OnePointLineHelper, StartPoint.Y - OnePointLineHelper, StartPoint.X, StartPoint.Y);
                }
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                if (currentCursorPosition.X == StartPoint.X && currentCursorPosition.Y == StartPoint.Y)
                    IsValidEndPoint = false;
                else
                    IsValidEndPoint = true;

                EndPoint = currentCursorPosition;
                if (IsShift)
                    MakeSquare();
            }

            public void UpdateModifierKey(bool shift)
            {
                if (IsShift != shift)
                {
                    IsShift = shift;

                    if (IsShift)
                        MakeSquare();
                    else
                        UnMakeSquare();
                }
            }

            private void MakeSquare()
            {
                int X1 = StartPoint.X;
                int Y1 = StartPoint.Y;
                int X2 = 0;
                int Y2 = 0;

                int SizeX = Math.Abs(X1 - EndPoint.X);
                int SizeY = Math.Abs(Y1 - EndPoint.Y);
                int EqualSize = Math.Min(SizeX, SizeY);

                if (StartPoint.X > EndPoint.X)
                    X2 = X1 - EqualSize;
                else
                    X2 = X1 + EqualSize;

                if (StartPoint.Y > EndPoint.Y)
                    Y2 = Y1 - EqualSize;
                else
                    Y2 = Y1 + EqualSize;

                SaveRectangleEndPoint = EndPoint;
                EndPoint = new Point(X2, Y2);
            }

            private void UnMakeSquare()
            {
                EndPoint = SaveRectangleEndPoint;
            }
        }

        public class ShapeEllipse : IShape
        {
            public Pen PenEllipse { get; set; }
            public SolidBrush BrushFillEllipse { get; set; }
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            private Point SaveEllipseEndPoint { get; set; }
            private bool IsValidEndPoint = false;
            private bool IsShift = false;

            public ShapeEllipse(int lineWidth, Color activeColor, Point position)
            {
                StartPoint = position;

                PenEllipse = new Pen(activeColor, lineWidth);
                SetUpPen(PenEllipse);

                BrushFillEllipse = new SolidBrush(Color.Transparent);

                StartPoint = position;
            }

            public ShapeEllipse(int lineWidth, Color activeColor, Color fillColor, Point position)
            {
                StartPoint = position;

                PenEllipse = new Pen(activeColor, lineWidth);
                SetUpPen(PenEllipse);

                BrushFillEllipse = new SolidBrush(fillColor);

                StartPoint = position;
            }

            public void Draw(Graphics translucent, Graphics notTransparent)
            {
                Draw(notTransparent);
            }

            public void Draw(Graphics graphics)
            {
                if (IsValidEndPoint)
                {
                    if (StartPoint.X == EndPoint.X || StartPoint.Y == EndPoint.Y)
                    {
                        graphics.DrawLine(PenEllipse, StartPoint, EndPoint);
                    }
                    else
                    {
                        int X1 = Math.Min(StartPoint.X, EndPoint.X);
                        int Y1 = Math.Min(StartPoint.Y, EndPoint.Y);
                        int X2 = Math.Max(StartPoint.X, EndPoint.X);
                        int Y2 = Math.Max(StartPoint.Y, EndPoint.Y);

                        int width = X2 - X1;
                        int height = Y2 - Y1;

                        if (width < PenEllipse.Width && height < PenEllipse.Width)
                        {
                            graphics.FillEllipse(PenEllipse.Brush, X1 - PenEllipse.Width / 2, Y1 - PenEllipse.Width / 2, X2 - X1 + PenEllipse.Width, Y2 - Y1 + PenEllipse.Width);
                        }
                        else
                        {
                            graphics.FillEllipse(BrushFillEllipse, X1, Y1, X2 - X1, Y2 - Y1);
                            graphics.DrawEllipse(PenEllipse, X1, Y1, X2 - X1, Y2 - Y1);
                        }
                    }
                }
                else
                {
                    graphics.DrawLine(PenEllipse, StartPoint.X - OnePointLineHelper, StartPoint.Y - OnePointLineHelper, StartPoint.X, StartPoint.Y);
                }
            }

            public void NewCursorPoint(Point currentCursorPosition)
            {
                if (currentCursorPosition.X == StartPoint.X && currentCursorPosition.Y == StartPoint.Y)
                    IsValidEndPoint = false;
                else
                    IsValidEndPoint = true;

                EndPoint = currentCursorPosition;
                if (IsShift)
                    MakeCircle();
            }

            public void UpdateModifierKey(bool shift)
            {
                if (IsShift != shift)
                {
                    IsShift = shift;

                    if (IsShift)
                        MakeCircle();
                    else
                        UnMakeCircle();
                }
            }

            private void MakeCircle()
            {
                int X1 = StartPoint.X;
                int Y1 = StartPoint.Y;
                int X2 = 0;
                int Y2 = 0;

                int SizeX = Math.Abs(X1 - EndPoint.X);
                int SizeY = Math.Abs(Y1 - EndPoint.Y);
                int EqualSize = Math.Min(SizeX, SizeY);

                if (StartPoint.X > EndPoint.X)
                    X2 = X1 - EqualSize;
                else
                    X2 = X1 + EqualSize;

                if (StartPoint.Y > EndPoint.Y)
                    Y2 = Y1 - EqualSize;
                else
                    Y2 = Y1 + EqualSize;

                SaveEllipseEndPoint = EndPoint;
                EndPoint = new Point(X2, Y2);
            }

            private void UnMakeCircle()
            {
                EndPoint = SaveEllipseEndPoint;
            }
        }

        private void pb_Image_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ActiveTool == "Cursor")
                {
                    ActiveElement = CursorShape;
                    CursorShape.NewCursorPoint(e.Location);
                }
                if (ActiveTool == "Text")
                {
                    ActiveElement = new ShapeText(ActiveText, TextSize, e.Location, ActiveColor);
                }
                else if (ActiveTool == "Pen")
                {
                    ActiveElement = new ShapePen(LineWidth, ActiveColor, e.Location);
                }
                else if (ActiveTool == "Marker")
                {
                    ActiveElement = new ShapeMarker(LineWidth, e.Location);
                }
                else if (ActiveTool == "Line")
                {
                    ActiveElement = new ShapeLine(LineWidth, ActiveColor, e.Location, false);
                }
                else if (ActiveTool == "Arrow")
                {
                    ActiveElement = new ShapeLine(LineWidth, ActiveColor, e.Location, true);
                }
                else if (ActiveTool == "Rectangle")
                {
                    ActiveElement = new ShapeRectangle(LineWidth, ActiveColor, e.Location);
                }
                else if (ActiveTool == "FillRectangle")
                {
                    ActiveElement = new ShapeRectangle(LineWidth, ActiveColor, ActiveFillColor, e.Location);
                }
                else if (ActiveTool == "Ellipse")
                {
                    ActiveElement = new ShapeEllipse(LineWidth, ActiveColor, e.Location);
                }
                else if (ActiveTool == "FillEllipse")
                {
                    ActiveElement = new ShapeEllipse(LineWidth, ActiveColor, ActiveFillColor, e.Location);
                }

                if (ActiveTool != "None" && IsSave)
                {
                    IsSave = false;
                    this.Text += "*";
                }

                pb_Image.Refresh();
            }
        }

        private void pb_Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ActiveElement != null)
                {
                    ActiveElement.NewCursorPoint(e.Location);
                    pb_Image.Refresh();
                }
            }
        }

        private void pb_Image_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ActiveElement != null)
                {
                    if (ActiveTool != "Cursor")
                    {
                        ActiveElement.Draw(TranslucentGraphics, NotTransparentGraphics);
                        Shapes.Add(ActiveElement);
                    }

                    ActiveElement = null;
                    UpdateUndoRedoButtons();

                    pb_Image.Refresh();
                }
            }
        }

        private void pb_Image_Paint(object sender, PaintEventArgs e)
        {
            if (ActiveElement != null && ActiveTool != "Cursor")
            {
                Image CopyTranslucent = (Image)Translucent.Clone();
                Image CopyNotTransparent = (Image)NotTransparent.Clone();

                Graphics CopyTranslucentGraphics = Graphics.FromImage(CopyTranslucent);
                Graphics CopyNotTransparentGraphics = Graphics.FromImage(CopyNotTransparent);

                CopyTranslucentGraphics.SmoothingMode = SmoothingMode.None;
                CopyTranslucentGraphics.CompositingMode = CompositingMode.SourceCopy;
                CopyNotTransparentGraphics.SmoothingMode = SmoothingMode.HighQuality;
                CopyNotTransparentGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                ActiveElement.Draw(CopyTranslucentGraphics, CopyNotTransparentGraphics);

                CursorShape.Draw(e.Graphics);
                e.Graphics.DrawImage(CopyTranslucent, new Point(0, 0));
                e.Graphics.DrawImage(CopyNotTransparent, new Point(0, 0));

                CopyTranslucent.Dispose();
                CopyNotTransparent.Dispose();
                CopyTranslucentGraphics.Dispose();
                CopyNotTransparentGraphics.Dispose();
            }
            else
            {
                CursorShape.Draw(e.Graphics);
                e.Graphics.DrawImage(Translucent, new Point(0, 0));
                e.Graphics.DrawImage(NotTransparent, new Point(0, 0));
            }
        }

        private void ReDrawImages()
        {
            TranslucentGraphics.Clear(Color.Transparent);
            NotTransparentGraphics.Clear(Color.Transparent);

            Shapes.Draw(TranslucentGraphics, NotTransparentGraphics);
        }

        private void UpdateUndoRedoButtons()
        {
            if (Shapes.CanUndo())
                tsmi_Undo.Enabled = true;
            else
                tsmi_Undo.Enabled = false;
            if (Shapes.CanRedo())
                tsmi_Redo.Enabled = true;
            else
                tsmi_Redo.Enabled = false;
        }

        private void tsmi_Undo_Click(object sender, EventArgs e)
        {
            if (IsSave)
            {
                IsSave = false;
                this.Text += "*";
            }

            if (ActiveElement != null)
            {
                ActiveElement = null;
            }
            else
            {
                Shapes.Undo();

                ReDrawImages();
            }

            UpdateUndoRedoButtons();
            pb_Image.Refresh();
        }

        private void tsmi_Redo_Click(object sender, EventArgs e)
        {
            if (IsSave)
            {
                IsSave = false;
                this.Text += "*";
            }

            if (ActiveElement != null)
            {
                if (ActiveTool != "Cursor")
                {
                    ActiveElement.Draw(TranslucentGraphics, NotTransparentGraphics);
                    Shapes.Add(ActiveElement);
                }

                ActiveElement = null;
            }
            else
            {
                Shapes.Redo();

                ReDrawImages();
            }

            UpdateUndoRedoButtons();
            pb_Image.Refresh();
        }

        private void SaveImage()
        {
            if (ActiveElement != null)
            {
                if (ActiveTool != "Cursor")
                {
                    ActiveElement.Draw(TranslucentGraphics, NotTransparentGraphics);
                    Shapes.Add(ActiveElement);

                    UpdateUndoRedoButtons();

                    pb_Image.Refresh();
                }
            }

            Image Result = (Image)pb_Image.Image.Clone();
            Graphics ResultGraphics = Graphics.FromImage(Result);
            CursorShape.Draw(ResultGraphics);
            ResultGraphics.DrawImage(Translucent, new Point(0, 0));
            ResultGraphics.DrawImage(NotTransparent, new Point(0, 0));

            Clipboard.SetImage(Result);
            ScreenshotManager.SaveScreenshot(Result, FilePath, FileName, FileExtension);
            this.Text = FilePath + "\\" + FileName + "." + FileExtension;
            IsSave = true;

            Result.Dispose();
            ResultGraphics.Dispose();
        }

        private bool GetFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save screenshot as...";
            saveFileDialog.Filter = "Image files(*.png)|*.png|Image files(*.jpeg)|*.jpeg|Image files(*.bmp)|*.bmp|Image files(*.gif)|*.gif";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.CheckPathExists = true;
            if (FilePath != "")
            {
                saveFileDialog.FileName = FilePath + "\\" + FileName + "." + FileExtension;
                saveFileDialog.FileName = FileName;
            }
                

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileExtension = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf('.') + 1);
                FileName = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf('\\') + 1, saveFileDialog.FileName.LastIndexOf('.') - saveFileDialog.FileName.LastIndexOf('\\') - 1);
                FilePath = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf('\\'));

                return true;
            }
            else
                return false;
        }

        private void tsmi_Save_Click(object sender, EventArgs e)
        {
            if (FilePath != "")
                SaveImage();
            else
                tsmi_SaveAs.PerformClick();
        }

        private void tsmi_SaveAs_Click(object sender, EventArgs e)
        {
            if (GetFilePath())
                SaveImage();
        }

        private void WindowGE_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Shift)
                if (ActiveElement != null)
                    ActiveElement.UpdateModifierKey(true);

            pb_Image.Refresh();
        }

        private void WindowGE_Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Shift)
                if (ActiveElement != null)
                    ActiveElement.UpdateModifierKey(false);

            pb_Image.Refresh();
        }

        private void WindowGE_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsSave)
            {
                DialogResult dialogResult = MessageBox.Show("Want to save a screenshot before closing?", "Closing...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tsmi_Save.PerformClick();
                }
            }
        }
    }
}
