namespace VarietyScreenRecorder.Window_GE
{
    partial class WindowGE_GetSize
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
            this.l_Text = new System.Windows.Forms.Label();
            this.nud_Size = new System.Windows.Forms.NumericUpDown();
            this.tlp_FullArea = new System.Windows.Forms.TableLayoutPanel();
            this.b_Set = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Size)).BeginInit();
            this.tlp_FullArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Text
            // 
            this.l_Text.AutoSize = true;
            this.tlp_FullArea.SetColumnSpan(this.l_Text, 3);
            this.l_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Text.Location = new System.Drawing.Point(13, 10);
            this.l_Text.Name = "l_Text";
            this.l_Text.Size = new System.Drawing.Size(158, 27);
            this.l_Text.TabIndex = 0;
            this.l_Text.Text = "Your text";
            this.l_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_Size
            // 
            this.tlp_FullArea.SetColumnSpan(this.nud_Size, 3);
            this.nud_Size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nud_Size.Location = new System.Drawing.Point(13, 50);
            this.nud_Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Size.Name = "nud_Size";
            this.nud_Size.Size = new System.Drawing.Size(158, 20);
            this.nud_Size.TabIndex = 1;
            this.nud_Size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tlp_FullArea
            // 
            this.tlp_FullArea.ColumnCount = 5;
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.Controls.Add(this.nud_Size, 1, 3);
            this.tlp_FullArea.Controls.Add(this.l_Text, 1, 1);
            this.tlp_FullArea.Controls.Add(this.b_Set, 1, 5);
            this.tlp_FullArea.Controls.Add(this.b_Cancel, 3, 5);
            this.tlp_FullArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FullArea.Location = new System.Drawing.Point(0, 0);
            this.tlp_FullArea.Name = "tlp_FullArea";
            this.tlp_FullArea.RowCount = 7;
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_FullArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.Size = new System.Drawing.Size(184, 131);
            this.tlp_FullArea.TabIndex = 2;
            // 
            // b_Set
            // 
            this.b_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Set.Location = new System.Drawing.Point(13, 87);
            this.b_Set.Name = "b_Set";
            this.b_Set.Size = new System.Drawing.Size(71, 30);
            this.b_Set.TabIndex = 2;
            this.b_Set.Text = "Set";
            this.b_Set.UseVisualStyleBackColor = true;
            this.b_Set.Click += new System.EventHandler(this.b_Set_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Cancel.Location = new System.Drawing.Point(100, 87);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(71, 30);
            this.b_Cancel.TabIndex = 3;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // WindowGE_GetSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 131);
            this.Controls.Add(this.tlp_FullArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WindowGE_GetSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.nud_Size)).EndInit();
            this.tlp_FullArea.ResumeLayout(false);
            this.tlp_FullArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_FullArea;
        private System.Windows.Forms.Button b_Set;
        private System.Windows.Forms.Button b_Cancel;
        public System.Windows.Forms.NumericUpDown nud_Size;
    }
}