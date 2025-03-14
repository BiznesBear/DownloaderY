using YoutubeExplode.Videos;

namespace DownloaderY;
public record ProgresInfo(IVideo Item, int Index, int VideoCount);
public partial class VideoInfo : Form
{
    public VideoInfo()
    {
        InitializeComponent();
    }

    public void Set(ProgresInfo info)
    {
        progressBar.Value = 0;
        progressBar.PerformStep();

        titleLabel.Text = info.Item.Title;
        currentElementLabel.Text = $"{info.Index} element of {info.VideoCount}";

        videoLenght.Text = info.Item.Duration != null ? info.Item.Duration.Value.ToString() : "";
    }
    public void Step() => progressBar.PerformStep();
}
