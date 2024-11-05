using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Playlists;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Exceptions;
using System.Text.RegularExpressions;


namespace DownloderY;
public static class Downloader
{
    private const string dirName = "DownloaderY";
    public static readonly string defalutPath  = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), dirName);

    public static async void Download(string url, bool audioOnly, bool isPlaylist, FileFormat fileFormat)
    {
        var client = new YoutubeClient();
        IReadOnlyList<IVideo>? videos;
        Playlist? playlist = null;
        IStreamInfo? streamInfo;

        try
        {
            if (isPlaylist)
            {
                playlist = await client.Playlists.GetAsync(url);
                videos = await client.Playlists.GetVideosAsync(url);
            }
            else videos = [await client.Videos.GetAsync(url)];
        }
        catch (Exception e)
        {
            MessageBox.Show("Url is valid: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // creating video progress window
        VideoInfo videoProgress = new();
        videoProgress.Show();


        if (videos == null) throw new Exception("There's no videos to download");
        if (playlist == null && isPlaylist) throw new Exception("There's no playlist to download");

        int index = 1;
        foreach (var item in videos)
        {
            // UI
            videoProgress.Set(new(item, index, videos.Count));

            // downloading stream manifest
            var streamManifest = await client.Videos.Streams.GetManifestAsync(item.Url);
            streamInfo = GetStreamInfo(streamManifest, audioOnly);


            videoProgress.Step();

            if (streamInfo == null)
                throw new YoutubeExplodeException("Valid stream info");


            var stream = await client.Videos.Streams.GetAsync(streamInfo);
            videoProgress.Step();

            // creating path
            string format = fileFormat switch 
            {
                FileFormat.Defalut => streamInfo.Container.ToString(),
                FileFormat.Mp4 => "mp4",
                FileFormat.Mp3 => "mp3",
                FileFormat.WebM => "webm",
                FileFormat.Wav => "wav",
                _ => streamInfo.Container.ToString()
            };

            string orginalFilePath = $"{item.Title.RemoveSpecialCharacters()}.{format}";
            string path = playlist != null && isPlaylist ? Path.Combine(GetPath(playlist.Title.RemoveSpecialCharacters()), orginalFilePath) : Path.Combine(GetPath(), orginalFilePath);

            // downloading video
            await client.Videos.Streams.DownloadAsync(streamInfo, path);

            // ending sequence
            videoProgress.Step();
            index++;
        }
        MessageBox.Show("All videos downloaded successfully", "Success");
        videoProgress.Close();
    }

    public static IStreamInfo GetStreamInfo(StreamManifest manifest, bool state) =>
        state ? manifest.GetAudioOnlyStreams().GetWithHighestBitrate() : manifest.GetMuxedStreams().GetWithHighestVideoQuality();

    public static string GetPath(string addon = "")
    {
        string path = Path.Combine(defalutPath, addon);
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path;
    }
}
public enum FileFormat
{
    Defalut,
    Mp4,
    Mp3,
    WebM,
    Wav,
}
public static class Extensions
{
    public static string RemoveSpecialCharacters(this string str)
    {
        Regex regex = new("[^a-zA-Z0-9]");
        return regex.Replace(str, "");
    }
}
