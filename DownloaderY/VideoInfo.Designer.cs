namespace DownloaderY
{
    partial class VideoInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoInfo));
            progressBar = new ProgressBar();
            titleLabel = new Label();
            videoLenght = new Label();
            currentElementLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(25, 25, 25);
            progressBar.Dock = DockStyle.Bottom;
            progressBar.ForeColor = Color.DarkRed;
            progressBar.Location = new Point(0, 174);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(596, 23);
            progressBar.Step = 25;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 0;
            progressBar.Value = 25;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(110, 22);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Loading...";
            // 
            // videoLenght
            // 
            videoLenght.AutoSize = true;
            videoLenght.Dock = DockStyle.Top;
            videoLenght.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            videoLenght.Location = new Point(0, 22);
            videoLenght.Name = "videoLenght";
            videoLenght.Size = new Size(50, 22);
            videoLenght.TabIndex = 3;
            videoLenght.Text = "0:00";
            // 
            // currentElementLabel
            // 
            currentElementLabel.AutoSize = true;
            currentElementLabel.Dock = DockStyle.Bottom;
            currentElementLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            currentElementLabel.Location = new Point(0, 152);
            currentElementLabel.Name = "currentElementLabel";
            currentElementLabel.Size = new Size(150, 22);
            currentElementLabel.TabIndex = 4;
            currentElementLabel.Text = "0 element of 0";
            // 
            // VideoInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 197);
            Controls.Add(currentElementLabel);
            Controls.Add(videoLenght);
            Controls.Add(titleLabel);
            Controls.Add(progressBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VideoInfo";
            Text = "Video download status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label titleLabel;
        private Label videoLenght;
        private Label currentElementLabel;
    }
}