using System.Diagnostics;

namespace DownloaderY;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        RefreshHistory();
    }

    private async void DownloadBtn(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(urlBox.Text))
            MessageBox.Show("Url field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
        {
            await Downloader.Download(urlBox.Text, audioOnlyBtn.Checked, isPlaylistBtn.Checked, (FileFormat)fileFormatComboBox.SelectedIndex);
            RefreshHistory();
        }
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

    private void HistoryListBox_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (historyListBox.SelectedItem != null) // Sprawdza, czy coœ jest zaznaczone
        {
            string selectedItem = historyListBox.SelectedItem.ToString() ?? throw new FileNotFoundException("Can't find selected file");
            Process.Start(new ProcessStartInfo($"{Downloader.defalutPath}\\{selectedItem}") { UseShellExecute = true });
        }
    }
    public void RefreshHistory()
    {
        historyListBox.Items.Clear();
        string[] files = Directory.GetFiles(Downloader.defalutPath);
        foreach (string file in files)
            historyListBox.Items.Add(Path.GetFileName(file));
    }
}
