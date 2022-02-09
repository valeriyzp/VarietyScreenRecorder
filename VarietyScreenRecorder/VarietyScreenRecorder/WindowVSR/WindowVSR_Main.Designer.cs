namespace VarietyScreenRecorder
{
    partial class WindowVSR_Main
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
            this.components = new System.ComponentModel.Container();
            this.b_PhotoCam = new System.Windows.Forms.Button();
            this.b_PhotoCamSized = new System.Windows.Forms.Button();
            this.b_TimeLapse = new System.Windows.Forms.Button();
            this.b_VideoCam = new System.Windows.Forms.Button();
            this.b_Settings = new System.Windows.Forms.Button();
            this.b_Info = new System.Windows.Forms.Button();
            this.l_VideoCamTime = new System.Windows.Forms.Label();
            this.t_TimeLapseTimer = new System.Windows.Forms.Timer(this.components);
            this.t_VideoCamTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b_PhotoCam
            // 
            this.b_PhotoCam.BackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCam.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_PhotoCam;
            this.b_PhotoCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_PhotoCam.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_PhotoCam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_PhotoCam.FlatAppearance.BorderSize = 0;
            this.b_PhotoCam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_PhotoCam.ForeColor = System.Drawing.Color.Transparent;
            this.b_PhotoCam.Location = new System.Drawing.Point(10, 10);
            this.b_PhotoCam.Margin = new System.Windows.Forms.Padding(0);
            this.b_PhotoCam.Name = "b_PhotoCam";
            this.b_PhotoCam.Size = new System.Drawing.Size(64, 64);
            this.b_PhotoCam.TabIndex = 0;
            this.b_PhotoCam.UseVisualStyleBackColor = false;
            this.b_PhotoCam.Click += new System.EventHandler(this.b_PhotoCam_Click);
            // 
            // b_PhotoCamSized
            // 
            this.b_PhotoCamSized.BackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCamSized.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_PhotoCamSized;
            this.b_PhotoCamSized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_PhotoCamSized.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_PhotoCamSized.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_PhotoCamSized.FlatAppearance.BorderSize = 0;
            this.b_PhotoCamSized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCamSized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_PhotoCamSized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_PhotoCamSized.ForeColor = System.Drawing.Color.Transparent;
            this.b_PhotoCamSized.Location = new System.Drawing.Point(84, 10);
            this.b_PhotoCamSized.Margin = new System.Windows.Forms.Padding(0);
            this.b_PhotoCamSized.Name = "b_PhotoCamSized";
            this.b_PhotoCamSized.Size = new System.Drawing.Size(64, 64);
            this.b_PhotoCamSized.TabIndex = 1;
            this.b_PhotoCamSized.UseVisualStyleBackColor = false;
            this.b_PhotoCamSized.Click += new System.EventHandler(this.b_PhotoCamSized_Click);
            // 
            // b_TimeLapse
            // 
            this.b_TimeLapse.BackColor = System.Drawing.Color.Transparent;
            this.b_TimeLapse.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_TimeLapse;
            this.b_TimeLapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_TimeLapse.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_TimeLapse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_TimeLapse.FlatAppearance.BorderSize = 0;
            this.b_TimeLapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_TimeLapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_TimeLapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_TimeLapse.ForeColor = System.Drawing.Color.Transparent;
            this.b_TimeLapse.Location = new System.Drawing.Point(158, 10);
            this.b_TimeLapse.Margin = new System.Windows.Forms.Padding(0);
            this.b_TimeLapse.Name = "b_TimeLapse";
            this.b_TimeLapse.Size = new System.Drawing.Size(64, 64);
            this.b_TimeLapse.TabIndex = 2;
            this.b_TimeLapse.UseVisualStyleBackColor = false;
            this.b_TimeLapse.Click += new System.EventHandler(this.b_TimeLapse_Click);
            // 
            // b_VideoCam
            // 
            this.b_VideoCam.BackColor = System.Drawing.Color.Transparent;
            this.b_VideoCam.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_VideoCam;
            this.b_VideoCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_VideoCam.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_VideoCam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_VideoCam.FlatAppearance.BorderSize = 0;
            this.b_VideoCam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_VideoCam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_VideoCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_VideoCam.ForeColor = System.Drawing.Color.Transparent;
            this.b_VideoCam.Location = new System.Drawing.Point(232, 10);
            this.b_VideoCam.Margin = new System.Windows.Forms.Padding(0);
            this.b_VideoCam.Name = "b_VideoCam";
            this.b_VideoCam.Size = new System.Drawing.Size(64, 64);
            this.b_VideoCam.TabIndex = 3;
            this.b_VideoCam.UseVisualStyleBackColor = false;
            this.b_VideoCam.Click += new System.EventHandler(this.b_VideoCam_Click);
            // 
            // b_Settings
            // 
            this.b_Settings.BackColor = System.Drawing.Color.Transparent;
            this.b_Settings.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_Settings;
            this.b_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_Settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_Settings.FlatAppearance.BorderSize = 0;
            this.b_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Settings.ForeColor = System.Drawing.Color.Transparent;
            this.b_Settings.Location = new System.Drawing.Point(432, 10);
            this.b_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.b_Settings.Name = "b_Settings";
            this.b_Settings.Size = new System.Drawing.Size(64, 64);
            this.b_Settings.TabIndex = 4;
            this.b_Settings.UseVisualStyleBackColor = false;
            this.b_Settings.Click += new System.EventHandler(this.b_Settings_Click);
            // 
            // b_Info
            // 
            this.b_Info.BackColor = System.Drawing.Color.Transparent;
            this.b_Info.BackgroundImage = global::VarietyScreenRecorder.Properties.Resources.NotActiveButton_Info;
            this.b_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_Info.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_Info.FlatAppearance.BorderSize = 0;
            this.b_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.b_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Info.ForeColor = System.Drawing.Color.Transparent;
            this.b_Info.Location = new System.Drawing.Point(506, 10);
            this.b_Info.Margin = new System.Windows.Forms.Padding(0);
            this.b_Info.Name = "b_Info";
            this.b_Info.Size = new System.Drawing.Size(64, 64);
            this.b_Info.TabIndex = 5;
            this.b_Info.UseVisualStyleBackColor = false;
            this.b_Info.Click += new System.EventHandler(this.b_Info_Click);
            // 
            // l_VideoCamTime
            // 
            this.l_VideoCamTime.AutoSize = true;
            this.l_VideoCamTime.BackColor = System.Drawing.Color.Transparent;
            this.l_VideoCamTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_VideoCamTime.Location = new System.Drawing.Point(306, 28);
            this.l_VideoCamTime.Margin = new System.Windows.Forms.Padding(0);
            this.l_VideoCamTime.Name = "l_VideoCamTime";
            this.l_VideoCamTime.Size = new System.Drawing.Size(116, 28);
            this.l_VideoCamTime.TabIndex = 6;
            this.l_VideoCamTime.Text = "--:--:--";
            this.l_VideoCamTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // t_TimeLapseTimer
            // 
            this.t_TimeLapseTimer.Tick += new System.EventHandler(this.t_TimeLapseTimer_Tick);
            // 
            // t_VideoCamTimer
            // 
            this.t_VideoCamTimer.Tick += new System.EventHandler(this.t_VideoCamTimer_Tick);
            // 
            // WindowVSR_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 85);
            this.Controls.Add(this.l_VideoCamTime);
            this.Controls.Add(this.b_Info);
            this.Controls.Add(this.b_Settings);
            this.Controls.Add(this.b_VideoCam);
            this.Controls.Add(this.b_TimeLapse);
            this.Controls.Add(this.b_PhotoCamSized);
            this.Controls.Add(this.b_PhotoCam);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WindowVSR_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variety Screen Recorder";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowVSR_Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_PhotoCam;
        private System.Windows.Forms.Button b_PhotoCamSized;
        private System.Windows.Forms.Button b_TimeLapse;
        private System.Windows.Forms.Button b_VideoCam;
        private System.Windows.Forms.Button b_Settings;
        private System.Windows.Forms.Button b_Info;
        private System.Windows.Forms.Label l_VideoCamTime;
        private System.Windows.Forms.Timer t_TimeLapseTimer;
        private System.Windows.Forms.Timer t_VideoCamTimer;
    }
}