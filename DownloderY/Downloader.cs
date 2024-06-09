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
        IReadOnlyList<PlaylistVideo>? playlistVideos=null;
        Playlist? playlist=null;
        Video? video = null;

        try
        {
            if (isPlaylist)
            {
                playlist = await youtube.Playlists.GetAsync(url);
                playlistVideos = await youtube.Playlists.GetVideosAsync(url);
            }
            else video = await youtube.Videos.GetAsync(url);
        }
        catch (Exception e)
        {
            MessageBox.Show("Url is valid: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        VideoInfo videoProgres = new VideoInfo();
        videoProgres.Show();


        if (isPlaylist)
        {
            if (playlistVideos == null) return;
            if (playlist == null) return;

            int index = 1;
            foreach(var item in playlistVideos)
            {
                videoProgres.progressBar.Value = 0;
                videoProgres.progressBar.PerformStep();

                videoProgres.titleLabel.Text = item.Title;
                videoProgres.currentElementLabel.Text = $"{index} element of {playlistVideos.Count}";
                if (item.Duration != null) videoProgres.videoLenght.Text = item.Duration.Value.ToString();
                else videoProgres.videoLenght.Text = "";

                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(item.Url);

                IStreamInfo? streamInfo = null;


                if (audioOnly)
                {
                    streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                }
                else
                {
                    streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                }
                videoProgres.progressBar.PerformStep();


                if (streamInfo == null)
                {
                    MessageBox.Show("Valid stream info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                videoProgres.progressBar.PerformStep();


                await youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(GetPath(playlist.Title.RemoveSpecialCharacters()), $"{item.Title.RemoveSpecialCharacters()}.{streamInfo.Container}"));
                videoProgres.progressBar.PerformStep();
                index++;
            }

            MessageBox.Show("Playlist has been downloaded", "Success");

            videoProgres.Close();



        }
        else
        {
            if (video == null) return;

            videoProgres.progressBar.PerformStep();


            videoProgres.titleLabel.Text = video.Title;
            videoProgres.currentElementLabel.Text = $"1 element of 1";
            if (video.Duration != null) videoProgres.videoLenght.Text = video.Duration.Value.ToString();
            else videoProgres.videoLenght.Text = "";

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            IStreamInfo? streamInfo = null;


            if (audioOnly)
            {
                streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            }
            else
            {
                streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            }
            videoProgres.progressBar.PerformStep();


            if (streamInfo == null)
            {
                MessageBox.Show("Valid stream info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
            videoProgres.progressBar.PerformStep();


            await youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(GetPath(), $"{video.Title.RemoveSpecialCharacters()}.{streamInfo.Container}"));
            videoProgres.progressBar.PerformStep();

            MessageBox.Show("Youtube video has been downloaded", "Success");

            videoProgres.Close();
        }
    }

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
