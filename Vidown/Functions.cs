using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

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
        /// <summary>
        /// Download YouTube video
        /// </summary>
        /// <param name="path">Output path</param>
        /// <param name="progress">Progress</param>
        /// <param name="quality">Video Quality</param>
        /// <returns></returns>
        public async Task<bool> DownloadVideo(string path, IProgress<double> progress = null, string quality = "720p")
        {
            try
            {
                MuxedStreamInfo stream = manifest.GetMuxedStreams()
                    .First(s => s.VideoQuality.Label == quality);

                await client.Videos.Streams.DownloadAsync(stream, path + $@"\p.{stream.Container}", progress);
                /* IStreamInfo audioStream = info.GetAudioOnlyStreams().GetWithHighestBitrate();
                await client.Videos.Streams.DownloadAsync(audioStream, path + @"\temp.webm", progress); */

                return true;
            }
            #region catches
            catch (System.UnauthorizedAccessException) // Access denied
            {
                MessageBox.Show($"Access denied\nCan't access this path: {path}\nRequires Administrator privileges", "Access denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (System.Reflection.TargetInvocationException ex) // Quality not found
            {// Actually it may not be the quality not found error
                MessageBox.Show(ex.Message, "Quality not found",
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
    }
}
