namespace DownloderY
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
            progressBar.ForeColor = Color.Red;
            progressBar.Location = new Point(0, 174);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(596, 23);
            progressBar.Step = 25;
            progressBar.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 22);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title";
            // 
            // videoLenght
            // 
            videoLenght.AutoSize = true;
            videoLenght.Dock = DockStyle.Top;
            videoLenght.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            videoLenght.ForeColor = Color.White;
            videoLenght.Location = new Point(0, 22);
            videoLenght.Name = "videoLenght";
            videoLenght.Size = new Size(70, 22);
            videoLenght.TabIndex = 3;
            videoLenght.Text = "Lenght";
            // 
            // currentElementLabel
            // 
            currentElementLabel.AutoSize = true;
            currentElementLabel.Dock = DockStyle.Bottom;
            currentElementLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            currentElementLabel.ForeColor = Color.White;
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
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(596, 197);
            ControlBox = false;
            Controls.Add(currentElementLabel);
            Controls.Add(videoLenght);
            Controls.Add(titleLabel);
            Controls.Add(progressBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VideoInfo";
            ShowInTaskbar = false;
            Text = "Video download status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal ProgressBar progressBar;
        internal Label titleLabel;
        internal Label videoLenght;
        internal Label currentElementLabel;
    }
}