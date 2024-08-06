namespace DownloderY
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            urlBox = new TextBox();
            menuStrip = new MenuStrip();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            downloadBtn = new Button();
            isPlaylistBtn = new CheckBox();
            audioOnlyBtn = new CheckBox();
            panel = new Panel();
            settingsBox = new GroupBox();
            menuStrip.SuspendLayout();
            panel.SuspendLayout();
            settingsBox.SuspendLayout();
            SuspendLayout();
            // 
            // urlBox
            // 
            urlBox.AllowDrop = true;
            urlBox.BackColor = Color.FromArgb(20, 20, 20);
            urlBox.BorderStyle = BorderStyle.FixedSingle;
            urlBox.Dock = DockStyle.Top;
            urlBox.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            urlBox.ForeColor = Color.FromArgb(88, 101, 242);
            urlBox.Location = new Point(0, 27);
            urlBox.Margin = new Padding(5);
            urlBox.MaxLength = 100;
            urlBox.Name = "urlBox";
            urlBox.PlaceholderText = "Paste video url here";
            urlBox.ScrollBars = ScrollBars.Vertical;
            urlBox.Size = new Size(587, 30);
            urlBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(25, 25, 25);
            menuStrip.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuStrip.Items.AddRange(new ToolStripItem[] { pasteToolStripMenuItem, clearToolStripMenuItem, openFolderToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(587, 27);
            menuStrip.TabIndex = 4;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor = Color.FromArgb(25, 25, 25);
            pasteToolStripMenuItem.ForeColor = Color.White;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(66, 23);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.ToolTipText = "Pastes the url";
            pasteToolStripMenuItem.Click += PasteBtn;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.ForeColor = Color.White;
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(66, 23);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.ToolTipText = "Clears the url";
            clearToolStripMenuItem.Click += ClearBtn;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.ForeColor = Color.White;
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(120, 23);
            openFolderToolStripMenuItem.Text = "Open folder";
            openFolderToolStripMenuItem.ToolTipText = "Opens folder with all of the videos";
            openFolderToolStripMenuItem.Click += OpenFolderBtn;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(66, 23);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutBtn;
            // 
            // downloadBtn
            // 
            downloadBtn.BackColor = Color.FromArgb(88, 101, 242);
            downloadBtn.Dock = DockStyle.Bottom;
            downloadBtn.FlatStyle = FlatStyle.Popup;
            downloadBtn.ForeColor = SystemColors.Window;
            downloadBtn.Location = new Point(0, 250);
            downloadBtn.Margin = new Padding(6);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(587, 34);
            downloadBtn.TabIndex = 3;
            downloadBtn.Text = "Download";
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += DownloadBtn;
            // 
            // isPlaylistBtn
            // 
            isPlaylistBtn.AutoSize = true;
            isPlaylistBtn.Location = new Point(12, 65);
            isPlaylistBtn.Name = "isPlaylistBtn";
            isPlaylistBtn.Size = new Size(161, 28);
            isPlaylistBtn.TabIndex = 6;
            isPlaylistBtn.Text = "Is playlist";
            isPlaylistBtn.UseVisualStyleBackColor = true;
            // 
            // audioOnlyBtn
            // 
            audioOnlyBtn.AutoSize = true;
            audioOnlyBtn.Location = new Point(12, 31);
            audioOnlyBtn.Name = "audioOnlyBtn";
            audioOnlyBtn.Size = new Size(173, 28);
            audioOnlyBtn.TabIndex = 7;
            audioOnlyBtn.Text = "Audio format";
            audioOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            panel.Controls.Add(settingsBox);
            panel.Controls.Add(downloadBtn);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 57);
            panel.Name = "panel";
            panel.Size = new Size(587, 284);
            panel.TabIndex = 3;
            // 
            // settingsBox
            // 
            settingsBox.Controls.Add(isPlaylistBtn);
            settingsBox.Controls.Add(audioOnlyBtn);
            settingsBox.Dock = DockStyle.Fill;
            settingsBox.FlatStyle = FlatStyle.Flat;
            settingsBox.ForeColor = Color.White;
            settingsBox.Location = new Point(0, 0);
            settingsBox.Margin = new Padding(6);
            settingsBox.Name = "settingsBox";
            settingsBox.Size = new Size(587, 250);
            settingsBox.TabIndex = 8;
            settingsBox.TabStop = false;
            settingsBox.Text = "Settings";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(587, 341);
            Controls.Add(panel);
            Controls.Add(urlBox);
            Controls.Add(menuStrip);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Downloader Y";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel.ResumeLayout(false);
            settingsBox.ResumeLayout(false);
            settingsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private Button downloadBtn;
        private CheckBox isPlaylistBtn;
        private CheckBox audioOnlyBtn;
        private Panel panel;
        private ToolStripMenuItem clearToolStripMenuItem;
        private GroupBox settingsBox;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
