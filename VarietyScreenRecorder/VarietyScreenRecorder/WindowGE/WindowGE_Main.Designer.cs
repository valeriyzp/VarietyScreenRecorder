namespace VarietyScreenRecorder.Window_GE
{
    partial class WindowGE_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowGE_Main));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ToolsButtons = new System.Windows.Forms.ToolStrip();
            this.tsb_Cursor = new System.Windows.Forms.ToolStripButton();
            this.tsb_Pen = new System.Windows.Forms.ToolStripButton();
            this.tsb_Marker = new System.Windows.Forms.ToolStripButton();
            this.tsb_Text = new System.Windows.Forms.ToolStripButton();
            this.tsb_LineArrow = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmi_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Arrow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_Rectangle = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmi_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FillRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_Ellipse = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmi_Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_FillEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Color = new System.Windows.Forms.ToolStripButton();
            this.tsb_FillColor = new System.Windows.Forms.ToolStripButton();
            this.tsb_LineWidth = new System.Windows.Forms.ToolStripButton();
            this.tsb_TextSize = new System.Windows.Forms.ToolStripButton();
            this.tlp_MainArea = new System.Windows.Forms.TableLayoutPanel();
            this.p_PictureArea = new System.Windows.Forms.Panel();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.ms_Menu.SuspendLayout();
            this.ts_ToolsButtons.SuspendLayout();
            this.tlp_MainArea.SuspendLayout();
            this.p_PictureArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_Edit});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ms_Menu.Size = new System.Drawing.Size(734, 24);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Save,
            this.tsmi_SaveAs});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(37, 20);
            this.tsmi_File.Text = "File";
            // 
            // tsmi_Save
            // 
            this.tsmi_Save.Name = "tsmi_Save";
            this.tsmi_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_Save.Size = new System.Drawing.Size(193, 22);
            this.tsmi_Save.Text = "Save";
            this.tsmi_Save.Click += new System.EventHandler(this.tsmi_Save_Click);
            // 
            // tsmi_SaveAs
            // 
            this.tsmi_SaveAs.Name = "tsmi_SaveAs";
            this.tsmi_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmi_SaveAs.Size = new System.Drawing.Size(193, 22);
            this.tsmi_SaveAs.Text = "Save as...";
            this.tsmi_SaveAs.Click += new System.EventHandler(this.tsmi_SaveAs_Click);
            // 
            // tsmi_Edit
            // 
            this.tsmi_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Undo,
            this.tsmi_Redo});
            this.tsmi_Edit.Name = "tsmi_Edit";
            this.tsmi_Edit.Size = new System.Drawing.Size(39, 20);
            this.tsmi_Edit.Text = "Edit";
            // 
            // tsmi_Undo
            // 
            this.tsmi_Undo.Enabled = false;
            this.tsmi_Undo.Name = "tsmi_Undo";
            this.tsmi_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_Undo.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Undo.Text = "Undo";
            this.tsmi_Undo.Click += new System.EventHandler(this.tsmi_Undo_Click);
            // 
            // tsmi_Redo
            // 
            this.tsmi_Redo.Enabled = false;
            this.tsmi_Redo.Name = "tsmi_Redo";
            this.tsmi_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmi_Redo.Size = new System.Drawing.Size(144, 22);
            this.tsmi_Redo.Text = "Redo";
            this.tsmi_Redo.Click += new System.EventHandler(this.tsmi_Redo_Click);
            // 
            // ts_ToolsButtons
            // 
            this.ts_ToolsButtons.BackColor = System.Drawing.SystemColors.Control;
            this.ts_ToolsButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_ToolsButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_ToolsButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Cursor,
            this.tsb_Pen,
            this.tsb_Marker,
            this.tsb_Text,
            this.tsb_LineArrow,
            this.tsb_Rectangle,
            this.tsb_Ellipse,
            this.toolStripSeparator1,
            this.tsb_Color,
            this.tsb_FillColor,
            this.tsb_LineWidth,
            this.tsb_TextSize});
            this.ts_ToolsButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ts_ToolsButtons.Location = new System.Drawing.Point(0, 24);
            this.ts_ToolsButtons.Name = "ts_ToolsButtons";
            this.ts_ToolsButtons.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_ToolsButtons.Size = new System.Drawing.Size(44, 387);
            this.ts_ToolsButtons.TabIndex = 1;
            this.ts_ToolsButtons.Text = "toolStrip1";
            // 
            // tsb_Cursor
            // 
            this.tsb_Cursor.AutoSize = false;
            this.tsb_Cursor.BackColor = System.Drawing.SystemColors.Control;
            this.tsb_Cursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Cursor.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Cursor;
            this.tsb_Cursor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Cursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Cursor.Name = "tsb_Cursor";
            this.tsb_Cursor.Size = new System.Drawing.Size(28, 28);
            this.tsb_Cursor.Text = "Cursor";
            this.tsb_Cursor.Click += new System.EventHandler(this.tsb_Cursor_Click);
            // 
            // tsb_Pen
            // 
            this.tsb_Pen.AutoSize = false;
            this.tsb_Pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Pen.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Pen;
            this.tsb_Pen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Pen.Name = "tsb_Pen";
            this.tsb_Pen.Size = new System.Drawing.Size(28, 28);
            this.tsb_Pen.Text = "Pen";
            this.tsb_Pen.Click += new System.EventHandler(this.tsb_Pen_Click);
            // 
            // tsb_Marker
            // 
            this.tsb_Marker.AutoSize = false;
            this.tsb_Marker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Marker.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Marker;
            this.tsb_Marker.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Marker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Marker.Name = "tsb_Marker";
            this.tsb_Marker.Size = new System.Drawing.Size(28, 28);
            this.tsb_Marker.Text = "Marker";
            this.tsb_Marker.Click += new System.EventHandler(this.tsb_Marker_Click);
            // 
            // tsb_Text
            // 
            this.tsb_Text.AutoSize = false;
            this.tsb_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Text.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Text;
            this.tsb_Text.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Text.Name = "tsb_Text";
            this.tsb_Text.Size = new System.Drawing.Size(28, 28);
            this.tsb_Text.Text = "Text";
            this.tsb_Text.Click += new System.EventHandler(this.tsb_Text_Click);
            // 
            // tsb_LineArrow
            // 
            this.tsb_LineArrow.AutoSize = false;
            this.tsb_LineArrow.BackColor = System.Drawing.SystemColors.Control;
            this.tsb_LineArrow.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.EmptyImage;
            this.tsb_LineArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsb_LineArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_LineArrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Line,
            this.tsmi_Arrow});
            this.tsb_LineArrow.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Line;
            this.tsb_LineArrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_LineArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_LineArrow.Name = "tsb_LineArrow";
            this.tsb_LineArrow.Size = new System.Drawing.Size(43, 28);
            this.tsb_LineArrow.Text = "Lines";
            this.tsb_LineArrow.ButtonClick += new System.EventHandler(this.tsb_LineArrow_ButtonClick);
            // 
            // tsmi_Line
            // 
            this.tsmi_Line.BackColor = System.Drawing.SystemColors.Control;
            this.tsmi_Line.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Line;
            this.tsmi_Line.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_Line.Name = "tsmi_Line";
            this.tsmi_Line.Size = new System.Drawing.Size(114, 30);
            this.tsmi_Line.Text = "Line";
            this.tsmi_Line.Click += new System.EventHandler(this.tsmi_Line_Click);
            // 
            // tsmi_Arrow
            // 
            this.tsmi_Arrow.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Arrow;
            this.tsmi_Arrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_Arrow.Name = "tsmi_Arrow";
            this.tsmi_Arrow.Size = new System.Drawing.Size(114, 30);
            this.tsmi_Arrow.Text = "Arrow";
            this.tsmi_Arrow.Click += new System.EventHandler(this.tsmi_Arrow_Click);
            // 
            // tsb_Rectangle
            // 
            this.tsb_Rectangle.AutoSize = false;
            this.tsb_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.tsb_Rectangle.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.EmptyImage;
            this.tsb_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsb_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Rectangle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Rectangle,
            this.tsmi_FillRectangle});
            this.tsb_Rectangle.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Rectangle;
            this.tsb_Rectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Rectangle.Name = "tsb_Rectangle";
            this.tsb_Rectangle.Size = new System.Drawing.Size(43, 28);
            this.tsb_Rectangle.Text = "Rectangle";
            this.tsb_Rectangle.ButtonClick += new System.EventHandler(this.tsb_Rectangle_ButtonClick);
            // 
            // tsmi_Rectangle
            // 
            this.tsmi_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.tsmi_Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Rectangle.Image")));
            this.tsmi_Rectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_Rectangle.Name = "tsmi_Rectangle";
            this.tsmi_Rectangle.Size = new System.Drawing.Size(149, 30);
            this.tsmi_Rectangle.Text = "Rectangle";
            this.tsmi_Rectangle.Click += new System.EventHandler(this.tsmi_Rectangle_Click);
            // 
            // tsmi_FillRectangle
            // 
            this.tsmi_FillRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_FillRectangle.Image")));
            this.tsmi_FillRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_FillRectangle.Name = "tsmi_FillRectangle";
            this.tsmi_FillRectangle.Size = new System.Drawing.Size(149, 30);
            this.tsmi_FillRectangle.Text = "Fill rectangle";
            this.tsmi_FillRectangle.Click += new System.EventHandler(this.tsmi_FillRectangle_Click);
            // 
            // tsb_Ellipse
            // 
            this.tsb_Ellipse.AutoSize = false;
            this.tsb_Ellipse.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.EmptyImage;
            this.tsb_Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsb_Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Ellipse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Ellipse,
            this.tsmi_FillEllipse});
            this.tsb_Ellipse.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Ellipse;
            this.tsb_Ellipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Ellipse.Name = "tsb_Ellipse";
            this.tsb_Ellipse.Size = new System.Drawing.Size(43, 28);
            this.tsb_Ellipse.Text = "Ellipse";
            this.tsb_Ellipse.ButtonClick += new System.EventHandler(this.tsb_Ellipse_ButtonClick);
            // 
            // tsmi_Ellipse
            // 
            this.tsmi_Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Ellipse.Image")));
            this.tsmi_Ellipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_Ellipse.Name = "tsmi_Ellipse";
            this.tsmi_Ellipse.Size = new System.Drawing.Size(133, 30);
            this.tsmi_Ellipse.Text = "Ellipse";
            this.tsmi_Ellipse.Click += new System.EventHandler(this.tsmi_Ellipse_Click);
            // 
            // tsmi_FillEllipse
            // 
            this.tsmi_FillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_FillEllipse.Image")));
            this.tsmi_FillEllipse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmi_FillEllipse.Name = "tsmi_FillEllipse";
            this.tsmi_FillEllipse.Size = new System.Drawing.Size(133, 30);
            this.tsmi_FillEllipse.Text = "Fill ellipse";
            this.tsmi_FillEllipse.Click += new System.EventHandler(this.tsmi_FillEllipse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(41, 6);
            // 
            // tsb_Color
            // 
            this.tsb_Color.AutoSize = false;
            this.tsb_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Color.Image = global::VarietyScreenRecorder.Properties.Resources.GE_Color;
            this.tsb_Color.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Color.Name = "tsb_Color";
            this.tsb_Color.Size = new System.Drawing.Size(28, 28);
            this.tsb_Color.Text = "Color";
            this.tsb_Color.Click += new System.EventHandler(this.tsb_Color_Click);
            // 
            // tsb_FillColor
            // 
            this.tsb_FillColor.AutoSize = false;
            this.tsb_FillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_FillColor.Image = global::VarietyScreenRecorder.Properties.Resources.GE_FillColor;
            this.tsb_FillColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_FillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_FillColor.Name = "tsb_FillColor";
            this.tsb_FillColor.Size = new System.Drawing.Size(28, 28);
            this.tsb_FillColor.Text = "Fill color";
            this.tsb_FillColor.Click += new System.EventHandler(this.tsb_FillColor_Click);
            // 
            // tsb_LineWidth
            // 
            this.tsb_LineWidth.AutoSize = false;
            this.tsb_LineWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_LineWidth.Image = global::VarietyScreenRecorder.Properties.Resources.GE_LineWidth;
            this.tsb_LineWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_LineWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_LineWidth.Name = "tsb_LineWidth";
            this.tsb_LineWidth.Size = new System.Drawing.Size(28, 28);
            this.tsb_LineWidth.Text = "Line width";
            this.tsb_LineWidth.Click += new System.EventHandler(this.tsb_LineWidth_Click);
            // 
            // tsb_TextSize
            // 
            this.tsb_TextSize.AutoSize = false;
            this.tsb_TextSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_TextSize.Image = global::VarietyScreenRecorder.Properties.Resources.GE_TextSize;
            this.tsb_TextSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_TextSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_TextSize.Name = "tsb_TextSize";
            this.tsb_TextSize.Size = new System.Drawing.Size(28, 28);
            this.tsb_TextSize.Text = "Text size";
            this.tsb_TextSize.Click += new System.EventHandler(this.tsb_TextSize_Click);
            // 
            // tlp_MainArea
            // 
            this.tlp_MainArea.BackColor = System.Drawing.Color.White;
            this.tlp_MainArea.ColumnCount = 3;
            this.tlp_MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_MainArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainArea.Controls.Add(this.p_PictureArea, 1, 1);
            this.tlp_MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_MainArea.Location = new System.Drawing.Point(44, 24);
            this.tlp_MainArea.Name = "tlp_MainArea";
            this.tlp_MainArea.RowCount = 3;
            this.tlp_MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_MainArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_MainArea.Size = new System.Drawing.Size(690, 387);
            this.tlp_MainArea.TabIndex = 2;
            // 
            // p_PictureArea
            // 
            this.p_PictureArea.AutoScroll = true;
            this.p_PictureArea.BackColor = System.Drawing.Color.White;
            this.p_PictureArea.Controls.Add(this.pb_Image);
            this.p_PictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_PictureArea.Location = new System.Drawing.Point(13, 13);
            this.p_PictureArea.Name = "p_PictureArea";
            this.p_PictureArea.Size = new System.Drawing.Size(664, 361);
            this.p_PictureArea.TabIndex = 0;
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.Location = new System.Drawing.Point(0, 0);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(50, 50);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            this.pb_Image.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Image_Paint);
            this.pb_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_Image_MouseDown);
            this.pb_Image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Image_MouseMove);
            this.pb_Image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_Image_MouseUp);
            // 
            // WindowGE_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tlp_MainArea);
            this.Controls.Add(this.ts_ToolsButtons);
            this.Controls.Add(this.ms_Menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "WindowGE_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics Editor | Variety Screen Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowGE_Main_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowGE_Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WindowGE_Main_KeyUp);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ts_ToolsButtons.ResumeLayout(false);
            this.ts_ToolsButtons.PerformLayout();
            this.tlp_MainArea.ResumeLayout(false);
            this.p_PictureArea.ResumeLayout(false);
            this.p_PictureArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStrip ts_ToolsButtons;
        private System.Windows.Forms.ToolStripButton tsb_Cursor;
        private System.Windows.Forms.ToolStripButton tsb_Marker;
        private System.Windows.Forms.ToolStripButton tsb_Pen;
        private System.Windows.Forms.ToolStripButton tsb_Color;
        private System.Windows.Forms.TableLayoutPanel tlp_MainArea;
        private System.Windows.Forms.Panel p_PictureArea;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.ToolStripButton tsb_Text;
        private System.Windows.Forms.ToolStripSplitButton tsb_Rectangle;
        private System.Windows.Forms.ToolStripSplitButton tsb_Ellipse;
        private System.Windows.Forms.ToolStripButton tsb_FillColor;
        private System.Windows.Forms.ToolStripButton tsb_LineWidth;
        private System.Windows.Forms.ToolStripButton tsb_TextSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FillRectangle;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ellipse;
        private System.Windows.Forms.ToolStripMenuItem tsmi_FillEllipse;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Redo;
        private System.Windows.Forms.ToolStripSplitButton tsb_LineArrow;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Line;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Arrow;
    }
}