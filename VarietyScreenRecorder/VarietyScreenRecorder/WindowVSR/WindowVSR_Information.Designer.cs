namespace VarietyScreenRecorder.WindowVSR
{
    partial class WindowVSR_Information
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
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.l_ProgramName = new System.Windows.Forms.Label();
            this.l_AboutProgram = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::VarietyScreenRecorder.Properties.Resources.LogoPNG;
            this.pb_Logo.Location = new System.Drawing.Point(94, 30);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(127, 127);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // l_ProgramName
            // 
            this.l_ProgramName.AutoSize = true;
            this.l_ProgramName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ProgramName.Location = new System.Drawing.Point(18, 160);
            this.l_ProgramName.Name = "l_ProgramName";
            this.l_ProgramName.Size = new System.Drawing.Size(286, 24);
            this.l_ProgramName.TabIndex = 1;
            this.l_ProgramName.Text = "Variety Screen Recorder";
            // 
            // l_AboutProgram
            // 
            this.l_AboutProgram.AutoSize = true;
            this.l_AboutProgram.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_AboutProgram.Location = new System.Drawing.Point(31, 214);
            this.l_AboutProgram.Name = "l_AboutProgram";
            this.l_AboutProgram.Size = new System.Drawing.Size(260, 176);
            this.l_AboutProgram.TabIndex = 2;
            this.l_AboutProgram.Text = "Made by\r\nValeriy Kozlov\r\n\r\nSpecially for \r\nSerhiy Mykytovych Serdyuk\r\n\r\nZaporizhz" +
    "hia\r\n2020";
            this.l_AboutProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowVSR_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 423);
            this.Controls.Add(this.l_AboutProgram);
            this.Controls.Add(this.l_ProgramName);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowVSR_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variety Screen Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label l_ProgramName;
        private System.Windows.Forms.Label l_AboutProgram;
    }
}