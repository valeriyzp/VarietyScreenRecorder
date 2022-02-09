namespace VarietyScreenRecorder.Window_GE
{
    partial class WindowGE_GetText
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
            this.tlp_FullArea = new System.Windows.Forms.TableLayoutPanel();
            this.l_Text = new System.Windows.Forms.Label();
            this.tb_TextValue = new System.Windows.Forms.TextBox();
            this.b_Set = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.tlp_FullArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_FullArea
            // 
            this.tlp_FullArea.ColumnCount = 5;
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_FullArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_FullArea.Controls.Add(this.l_Text, 1, 1);
            this.tlp_FullArea.Controls.Add(this.tb_TextValue, 1, 3);
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
            this.tlp_FullArea.Size = new System.Drawing.Size(284, 131);
            this.tlp_FullArea.TabIndex = 0;
            // 
            // l_Text
            // 
            this.l_Text.AutoSize = true;
            this.tlp_FullArea.SetColumnSpan(this.l_Text, 3);
            this.l_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Text.Location = new System.Drawing.Point(13, 10);
            this.l_Text.Name = "l_Text";
            this.l_Text.Size = new System.Drawing.Size(258, 27);
            this.l_Text.TabIndex = 0;
            this.l_Text.Text = "label1";
            this.l_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_TextValue
            // 
            this.tlp_FullArea.SetColumnSpan(this.tb_TextValue, 3);
            this.tb_TextValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TextValue.Location = new System.Drawing.Point(13, 50);
            this.tb_TextValue.Name = "tb_TextValue";
            this.tb_TextValue.Size = new System.Drawing.Size(258, 20);
            this.tb_TextValue.TabIndex = 1;
            this.tb_TextValue.TextChanged += new System.EventHandler(this.tb_TextValue_TextChanged);
            // 
            // b_Set
            // 
            this.b_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Set.Location = new System.Drawing.Point(13, 87);
            this.b_Set.Name = "b_Set";
            this.b_Set.Size = new System.Drawing.Size(121, 30);
            this.b_Set.TabIndex = 2;
            this.b_Set.Text = "Set";
            this.b_Set.UseVisualStyleBackColor = true;
            this.b_Set.Click += new System.EventHandler(this.b_Set_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Cancel.Location = new System.Drawing.Point(150, 87);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(121, 30);
            this.b_Cancel.TabIndex = 3;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // WindowGE_GetText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.tlp_FullArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WindowGE_GetText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tlp_FullArea.ResumeLayout(false);
            this.tlp_FullArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_FullArea;
        private System.Windows.Forms.Label l_Text;
        private System.Windows.Forms.Button b_Set;
        private System.Windows.Forms.Button b_Cancel;
        public System.Windows.Forms.TextBox tb_TextValue;
    }
}