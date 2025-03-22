using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Playlists;
using YoutubeExplode.Converter;
using System.Text.RegularExpressions;

namespace DownloaderY;

public static class Downloader
{
    private const string dirName = "DownloaderY";
    public static readonly string defalutPath  = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), dirName);

    public static async Task Download(string url, FileFormat fileFormat)
    {
        VideoInfo videoProgress = new();
        videoProgress.Show();

        var client = new YoutubeClient();
        IReadOnlyList<IVideo>? videos;
        Playlist? playlist = null;
        var isPlaylist = url.Contains("playlist?");

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
        

        if (videos == null) 
            throw new Exception("There's no videos to download");
        if (playlist == null && isPlaylist) 
            throw new Exception("There's no playlist to download");

        int index = 1;
        foreach (var video in videos)
        {
            // UI
            videoProgress.Set(video, index, videos.Count);

            // creating path
            string format = fileFormat switch 
            {
                FileFormat.Mp4 => "mp4",
                FileFormat.WebM => "webm",
                FileFormat.Wav => "wav",
                FileFormat.Mp3 or _ => "mp3",
            };

            string orginalFilePath = $"{video.Title.RemoveSpecialCharacters()}.{format}";
            string path = playlist != null && isPlaylist ? Path.Combine(GetPath(playlist.Title.RemoveSpecialCharacters()), orginalFilePath) : Path.Combine(GetPath(), orginalFilePath);

            // downloading video
            try
            {
                await client.Videos.DownloadAsync(video.Id, path);
            }
            catch
            {
                videoProgress.Set(video, index, videos.Count, true);
                Thread.Sleep(1000);
            }

            // ending sequence
            index++;
        }

        MessageBox.Show("All videos downloaded successfully", "Success");
        videoProgress.Close();
    }

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
    Mp3,
    Mp4,
    WebM,
    Wav,
}

public static partial class Extensions
{
    public static string RemoveSpecialCharacters(this string str)
    {
        Regex regex = SpecialCharacters();
        return regex.Replace(str, "");
    }

    [GeneratedRegex("[^a-zA-Z0-9]")]
    private static partial Regex SpecialCharacters();
}