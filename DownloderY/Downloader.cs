using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Playlists;
using YoutubeExplode.Videos.Streams;
using System.Text.RegularExpressions;
using YoutubeExplode.Converter;

namespace DownloderY;
internal static class Downloader
{
    private static readonly string dirName = "DownloaderY";
    public static string defalutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), dirName);

    public static async void Download(string url, bool audioOnly, bool isPlaylist)
    {
        var youtube = new YoutubeClient();
        IReadOnlyList<IVideo>? videos;
        Playlist? playlist = null;
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

        VideoInfo videoProgress = new();
        videoProgress.Show();

        if (videos == null) return;
        if (playlist == null && isPlaylist) return;

        int index = 1;
        foreach (var item in videos)
        {
            // UI
            videoProgress.Set(new(item, index, videos.Count));

            // downloading stream manifest
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(item.Url);


            streamInfo = GetStreamInfo(streamManifest, audioOnly);
            videoProgress.Step();

            if (streamInfo == null)
            {
                MessageBox.Show("Valid stream info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            videoProgress.Step();


            string orginalFilePath = $"{item.Title.RemoveSpecialCharacters()}.{streamInfo.Container}";
            string path = playlist != null && isPlaylist ? Path.Combine(GetPath(playlist.Title.RemoveSpecialCharacters()), orginalFilePath) : Path.Combine(GetPath(), orginalFilePath);


            await youtube.Videos.Streams.DownloadAsync(streamInfo, path);


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

public static class Extensions
{
    public static string RemoveSpecialCharacters(this string str)
    {
        Regex regex = new("[^a-zA-Z0-9]");
        return regex.Replace(str, "");
    }
}
