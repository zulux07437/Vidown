using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using Vidown.CliProcessWrap;

namespace Vidown
{
    public class Functions
    {
        private YoutubeClient client;
        private StreamManifest manifest;
        public VideoQuality[] Qualities = null;

        /// <summary>
        /// Get YouTube video manifest
        /// </summary>
        /// <param name="videoid">YouTube Video ID or URL</param>
        /// <returns></returns>
        public async Task<bool> GetVideo(string videoid)
        {
            try
            {
                client = new();
                manifest = await client.Videos.Streams.GetManifestAsync(videoid);
                Qualities = manifest.GetVideoStreams().Select(s => s.VideoQuality).Distinct().ToArray();

                return true;
            }
            #region catches
            catch (ArgumentException ex) // Unknown ID or URL
            {
                MessageBox.Show(ex.Message, "Unknown ID or URL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex) // Unexpected error
            {
                MessageBox.Show($"Please report this error to the author:\n\n{ex.Message}", "Unexpected Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            #endregion
        }

        public async Task<string> DownloadVideo(string path, string quality = "720p", IProgress<double> progress = null)
        {
            string inputName = null;
            try
            {
                MuxedStreamInfo stream = manifest.GetMuxedStreams().First(s => s.VideoQuality.Label == quality);
                inputName = $"input.{stream.Container}";
                await client.Videos.Streams.DownloadAsync(stream, path + @"\" + inputName, progress);

                return inputName;
            }
            #region catches
            catch (System.UnauthorizedAccessException) // Access denied
            {
                MessageBox.Show($"Access denied\nCan't access this path: {path}\nRequires Administrator privileges", "Access denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Reflection.TargetInvocationException ex) // Quality not found
            {// Actually it may not be the quality not found error
                MessageBox.Show(ex.Message, "Quality not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Unexpected error
            {
                MessageBox.Show($"Please report this error to the author:\n\n{ex.Message}", "Unexpected Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
            #endregion
        }
        public async Task<string> DownloadAudio(string path, IProgress<double> progress = null)
        {
            string inputName = null;
            try
            {
                IStreamInfo stream = manifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                inputName = $"input.{stream.Container}";
                await client.Videos.Streams.DownloadAsync(stream, path + @"\" + inputName, progress);

                return inputName;
            }
            #region catches
            catch (System.UnauthorizedAccessException) // Access denied
            {
                MessageBox.Show($"Access denied\nCan't access this path: {path}\nRequires Administrator privileges", "Access denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Unexpected error
            {
                MessageBox.Show($"Please report this error to the author:\n\n{ex.Message}", "Unexpected Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
            #endregion
        }
        public enum Extensions
        {
            WebmAudio, WebmVideo, MP3, MP4
        }
    }
}
