using System.Diagnostics;

namespace DownloderY;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void DownloadBtn(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(urlBox.Text)) { MessageBox.Show("Url field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        Downloader.Download(urlBox.Text, audioOnlyBtn.Checked, isPlaylistBtn.Checked,(FileFormat)fileFormatComboBox.SelectedIndex);
    }

    private void PasteBtn(object sender, EventArgs e)
    {
        urlBox.Clear();
        urlBox.Paste();
    }
    private void ClearBtn(object sender, EventArgs e)
    {
        urlBox.Clear();
    }
    private void OpenFolderBtn(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", $"{Downloader.defalutPath}");
    }
    private void AboutBtn(object sender, EventArgs e)
    {
        MessageBox.Show("Author: BiznesBear\nSpecial Thanks to Youtube Explode nuget package", "About");
    }
}
