using YoutubeExplode.Videos;

namespace DownloaderY;
public partial class VideoInfo : Form
{
    public VideoInfo()
    {
        InitializeComponent();
    }

    public void Set(IVideo item, int index, int videoCount, bool failed = false)
    {
        titleLabel.Text = failed? $"Failed to download {item.Title}" : item.Title;
        currentElementLabel.Text = $"{index} element of {videoCount}";

        videoLenght.Text = item.Duration != null ? item.Duration.Value.ToString() : "";
    }

    public void Step() => progressBar.PerformStep();
}
