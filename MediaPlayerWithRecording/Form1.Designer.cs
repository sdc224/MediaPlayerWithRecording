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
            this.ButtonOpenWavFile = new System.Windows.Forms.Button();
            this.ButtonPlayOrPause = new System.Windows.Forms.Button();
            this.ButtonOpenMp3File = new System.Windows.Forms.Button();
            this.ButtonPlayOrPauseMp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonOpenWavFile
            // 
            this.ButtonOpenWavFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOpenWavFile.FlatAppearance.BorderSize = 0;
            this.ButtonOpenWavFile.Location = new System.Drawing.Point(13, 13);
            this.ButtonOpenWavFile.Name = "ButtonOpenWavFile";
            this.ButtonOpenWavFile.Size = new System.Drawing.Size(385, 33);
            this.ButtonOpenWavFile.TabIndex = 0;
            this.ButtonOpenWavFile.Text = "Open WAV File";
            this.ButtonOpenWavFile.UseVisualStyleBackColor = false;
            this.ButtonOpenWavFile.Click += new System.EventHandler(this.ButtonOpenWavFile_Click);
            // 
            // ButtonPlayOrPause
            // 
            this.ButtonPlayOrPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonPlayOrPause.Enabled = false;
            this.ButtonPlayOrPause.FlatAppearance.BorderSize = 0;
            this.ButtonPlayOrPause.Location = new System.Drawing.Point(12, 61);
            this.ButtonPlayOrPause.Name = "ButtonPlayOrPause";
            this.ButtonPlayOrPause.Size = new System.Drawing.Size(385, 33);
            this.ButtonPlayOrPause.TabIndex = 0;
            this.ButtonPlayOrPause.Text = "Play/Pause WAV";
            this.ButtonPlayOrPause.UseVisualStyleBackColor = false;
            this.ButtonPlayOrPause.Click += new System.EventHandler(this.ButtonPlayOrPause_Click);
            // 
            // ButtonOpenMp3File
            // 
            this.ButtonOpenMp3File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonOpenMp3File.FlatAppearance.BorderSize = 0;
            this.ButtonOpenMp3File.Location = new System.Drawing.Point(13, 110);
            this.ButtonOpenMp3File.Name = "ButtonOpenMp3File";
            this.ButtonOpenMp3File.Size = new System.Drawing.Size(385, 33);
            this.ButtonOpenMp3File.TabIndex = 0;
            this.ButtonOpenMp3File.Text = "Open MP3 File";
            this.ButtonOpenMp3File.UseVisualStyleBackColor = false;
            this.ButtonOpenMp3File.Click += new System.EventHandler(this.ButtonOpenMp3File_Click);
            // 
            // ButtonPlayOrPauseMp3
            // 
            this.ButtonPlayOrPauseMp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonPlayOrPauseMp3.Enabled = false;
            this.ButtonPlayOrPauseMp3.FlatAppearance.BorderSize = 0;
            this.ButtonPlayOrPauseMp3.Location = new System.Drawing.Point(12, 160);
            this.ButtonPlayOrPauseMp3.Name = "ButtonPlayOrPauseMp3";
            this.ButtonPlayOrPauseMp3.Size = new System.Drawing.Size(385, 33);
            this.ButtonPlayOrPauseMp3.TabIndex = 0;
            this.ButtonPlayOrPauseMp3.Text = "Play/Pause MP3";
            this.ButtonPlayOrPauseMp3.UseVisualStyleBackColor = false;
            this.ButtonPlayOrPauseMp3.Click += new System.EventHandler(this.ButtonPlayOrPause_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 268);
            this.Controls.Add(this.ButtonPlayOrPauseMp3);
            this.Controls.Add(this.ButtonPlayOrPause);
            this.Controls.Add(this.ButtonOpenMp3File);
            this.Controls.Add(this.ButtonOpenWavFile);
            this.Name = "FirstWindow";
            this.Text = "First Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenWavFile;
        private System.Windows.Forms.Button ButtonPlayOrPause;
        private System.Windows.Forms.Button ButtonOpenMp3File;
        private System.Windows.Forms.Button ButtonPlayOrPauseMp3;
    }
}

