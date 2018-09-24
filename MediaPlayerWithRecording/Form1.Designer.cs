namespace MediaPlayerWithRecording
{
    partial class FirstWindow
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
            this.ButtonOpenMp3File = new System.Windows.Forms.Button();
            this.ButtonPlayOrPause = new System.Windows.Forms.Button();
            this.ButtonConvertMp3ToWav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOpenMp3File
            // 
            this.ButtonOpenMp3File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOpenMp3File.FlatAppearance.BorderSize = 0;
            this.ButtonOpenMp3File.Location = new System.Drawing.Point(13, 30);
            this.ButtonOpenMp3File.Name = "ButtonOpenMp3File";
            this.ButtonOpenMp3File.Size = new System.Drawing.Size(385, 33);
            this.ButtonOpenMp3File.TabIndex = 0;
            this.ButtonOpenMp3File.Text = "Open Audio File";
            this.ButtonOpenMp3File.UseVisualStyleBackColor = false;
            this.ButtonOpenMp3File.Click += new System.EventHandler(this.ButtonOpenAudioFile_Click);
            // 
            // ButtonPlayOrPause
            // 
            this.ButtonPlayOrPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonPlayOrPause.Enabled = false;
            this.ButtonPlayOrPause.FlatAppearance.BorderSize = 0;
            this.ButtonPlayOrPause.Location = new System.Drawing.Point(12, 80);
            this.ButtonPlayOrPause.Name = "ButtonPlayOrPause";
            this.ButtonPlayOrPause.Size = new System.Drawing.Size(385, 33);
            this.ButtonPlayOrPause.TabIndex = 0;
            this.ButtonPlayOrPause.Text = "Play/Pause Audio";
            this.ButtonPlayOrPause.UseVisualStyleBackColor = false;
            this.ButtonPlayOrPause.Click += new System.EventHandler(this.ButtonPlayOrPause_Click);
            // 
            // ButtonConvertMp3ToWav
            // 
            this.ButtonConvertMp3ToWav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonConvertMp3ToWav.FlatAppearance.BorderSize = 0;
            this.ButtonConvertMp3ToWav.Location = new System.Drawing.Point(13, 132);
            this.ButtonConvertMp3ToWav.Name = "ButtonConvertMp3ToWav";
            this.ButtonConvertMp3ToWav.Size = new System.Drawing.Size(385, 33);
            this.ButtonConvertMp3ToWav.TabIndex = 0;
            this.ButtonConvertMp3ToWav.Text = "Convert MP3 to WAV";
            this.ButtonConvertMp3ToWav.UseVisualStyleBackColor = false;
            this.ButtonConvertMp3ToWav.Click += new System.EventHandler(this.ButtonConvertMp3ToWav_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 218);
            this.Controls.Add(this.ButtonPlayOrPause);
            this.Controls.Add(this.ButtonConvertMp3ToWav);
            this.Controls.Add(this.ButtonOpenMp3File);
            this.Name = "FirstWindow";
            this.Text = "First Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonOpenMp3File;
        private System.Windows.Forms.Button ButtonPlayOrPause;
        private System.Windows.Forms.Button ButtonConvertMp3ToWav;
    }
}

