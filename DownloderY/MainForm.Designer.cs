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
            fileFormatLabel = new Label();
            fileFormatComboBox = new ComboBox();
            menuStrip.SuspendLayout();
            panel.SuspendLayout();
            settingsBox.SuspendLayout();
            SuspendLayout();
            // 
            // urlBox
            // 
            urlBox.AllowDrop = true;
            urlBox.BorderStyle = BorderStyle.FixedSingle;
            urlBox.Dock = DockStyle.Top;
            urlBox.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            urlBox.ForeColor = Color.FromArgb(88, 101, 242);
            urlBox.Location = new Point(0, 27);
            urlBox.Margin = new Padding(5);
            urlBox.MaxLength = 100;
            urlBox.Name = "urlBox";
            urlBox.PlaceholderText = "Paste video url here";
            urlBox.ScrollBars = ScrollBars.Horizontal;
            urlBox.Size = new Size(629, 30);
            urlBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuStrip.Items.AddRange(new ToolStripItem[] { pasteToolStripMenuItem, clearToolStripMenuItem, openFolderToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(629, 27);
            menuStrip.TabIndex = 4;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(66, 23);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.ToolTipText = "Pastes the url";
            pasteToolStripMenuItem.Click += PasteBtn;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(66, 23);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.ToolTipText = "Clears the url";
            clearToolStripMenuItem.Click += ClearBtn;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(120, 23);
            openFolderToolStripMenuItem.Text = "Open folder";
            openFolderToolStripMenuItem.ToolTipText = "Opens folder with all of the videos";
            openFolderToolStripMenuItem.Click += OpenFolderBtn;
            // 
            // aboutToolStripMenuItem
            // 
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
            downloadBtn.Image = (Image)resources.GetObject("downloadBtn.Image");
            downloadBtn.ImageAlign = ContentAlignment.MiddleLeft;
            downloadBtn.Location = new Point(0, 190);
            downloadBtn.Margin = new Padding(6, 6, 6, 60);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Padding = new Padding(0, 0, 30, 0);
            downloadBtn.Size = new Size(629, 34);
            downloadBtn.TabIndex = 3;
            downloadBtn.Text = "Download";
            downloadBtn.TextAlign = ContentAlignment.MiddleRight;
            downloadBtn.UseVisualStyleBackColor = false;
            downloadBtn.Click += DownloadBtn;
            // 
            // isPlaylistBtn
            // 
            isPlaylistBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            isPlaylistBtn.AutoSize = true;
            isPlaylistBtn.Location = new Point(192, 38);
            isPlaylistBtn.Name = "isPlaylistBtn";
            isPlaylistBtn.Size = new Size(161, 28);
            isPlaylistBtn.TabIndex = 6;
            isPlaylistBtn.Text = "Is playlist";
            isPlaylistBtn.UseVisualStyleBackColor = false;
            // 
            // audioOnlyBtn
            // 
            audioOnlyBtn.AutoSize = true;
            audioOnlyBtn.Location = new Point(13, 38);
            audioOnlyBtn.Name = "audioOnlyBtn";
            audioOnlyBtn.Size = new Size(149, 28);
            audioOnlyBtn.TabIndex = 7;
            audioOnlyBtn.Text = "Only audio";
            audioOnlyBtn.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            panel.Controls.Add(settingsBox);
            panel.Controls.Add(downloadBtn);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 57);
            panel.Name = "panel";
            panel.Size = new Size(629, 224);
            panel.TabIndex = 3;
            // 
            // settingsBox
            // 
            settingsBox.Controls.Add(fileFormatLabel);
            settingsBox.Controls.Add(fileFormatComboBox);
            settingsBox.Controls.Add(isPlaylistBtn);
            settingsBox.Controls.Add(audioOnlyBtn);
            settingsBox.Dock = DockStyle.Fill;
            settingsBox.FlatStyle = FlatStyle.Flat;
            settingsBox.Location = new Point(0, 0);
            settingsBox.Margin = new Padding(10);
            settingsBox.Name = "settingsBox";
            settingsBox.Padding = new Padding(10);
            settingsBox.Size = new Size(629, 190);
            settingsBox.TabIndex = 8;
            settingsBox.TabStop = false;
            settingsBox.Text = "Settings";
            // 
            // fileFormatLabel
            // 
            fileFormatLabel.AutoSize = true;
            fileFormatLabel.Location = new Point(13, 72);
            fileFormatLabel.Name = "fileFormatLabel";
            fileFormatLabel.Size = new Size(154, 24);
            fileFormatLabel.TabIndex = 9;
            fileFormatLabel.Text = "File format:";
            // 
            // fileFormatComboBox
            // 
            fileFormatComboBox.FlatStyle = FlatStyle.System;
            fileFormatComboBox.FormattingEnabled = true;
            fileFormatComboBox.Items.AddRange(new object[] { "Defalut", ".mp4", ".mp3", ".webm", ".wav" });
            fileFormatComboBox.Location = new Point(173, 69);
            fileFormatComboBox.Name = "fileFormatComboBox";
            fileFormatComboBox.Size = new Size(165, 32);
            fileFormatComboBox.TabIndex = 8;
            fileFormatComboBox.Text = "Defalut";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 281);
            Controls.Add(panel);
            Controls.Add(urlBox);
            Controls.Add(menuStrip);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5);
            MinimumSize = new Size(436, 264);
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
        private ComboBox fileFormatComboBox;
        private Label fileFormatLabel;
    }
}
