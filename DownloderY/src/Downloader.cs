using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Playlists;
using YoutubeExplode.Videos.Streams;

namespace DownloderY;
internal static class Downloader
{
    private static readonly string dirName = "DownloaderY";
    public static string defalutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),dirName);

    public static async void Download(string url,bool audioOnly,bool isPlaylist)
    {
        var youtube = new YoutubeClient();
        IReadOnlyList<IVideo>? videos=null;
        Playlist? playlist=null;
        IStreamInfo? streamInfo; 
        
        try
        {
            if (isPlaylist)
            {
                playlist = await youtube.Playlists.GetAsync(url);
                videos = await youtube.Playlists.GetVideosAsync(url);
            }
            else videos = [await youtube.Videos.GetAsync(url)];
        }
        catch (Exception e)
        {
            MessageBox.Show("Url is valid: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        VideoInfo videoProgres = new();
        videoProgres.Show();

        if (videos == null) return;
        if (playlist == null && isPlaylist) return;

        int index = 1;
        foreach (var item in videos)
        {
            // UI
            videoProgres.progressBar.Value = 0;
            videoProgres.progressBar.PerformStep();

            videoProgres.titleLabel.Text = item.Title;
            videoProgres.currentElementLabel.Text = $"{index} element of {videos.Count}";

            videoProgres.videoLenght.Text = item.Duration != null ? item.Duration.Value.ToString() : "";

            // downloading
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(item.Url);


            streamInfo = GetStreamInfo(streamManifest, audioOnly);
            videoProgres.progressBar.PerformStep();

            if (streamInfo == null)
            {
                MessageBox.Show("Valid stream info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            videoProgres.progressBar.PerformStep();


            if (playlist != null && isPlaylist) await youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(GetPath(playlist.Title.RemoveSpecialCharacters()), $"{item.Title.RemoveSpecialCharacters()}.{streamInfo.Container}"));
            else 
            { 
                string orginalFilePath = $"{item.Title.RemoveSpecialCharacters()}.{streamInfo.Container}"; 
                await youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(GetPath(), orginalFilePath)); 
            }
            videoProgres.progressBar.PerformStep();
            index++;
        }

        MessageBox.Show("All videos downloaded successfully", "Success");
        videoProgres.Close();
    }

    public static IStreamInfo GetStreamInfo(StreamManifest manifest,bool state) => state ? manifest.GetAudioOnlyStreams().GetWithHighestBitrate() : manifest.GetMuxedStreams().GetWithHighestVideoQuality();

    public static string GetPath(string addon="")
    {
        string path = Path.Combine(defalutPath, addon);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        return path;
    }
}
