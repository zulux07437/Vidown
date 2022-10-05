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
        /// <summary>
        /// Download a YouTube video with webm
        /// </summary>
        /// <param name="videoid">Video ID</param>
        /// <param name="path">Output path</param>
        public static async Task<bool> DownloadWebm(string videoid, string path, IProgress<double> progress)
        {
            try
            {
                YoutubeClient client = new YoutubeClient();
                StreamManifest info = await client.Videos.Streams.GetManifestAsync(videoid);
                IStreamInfo audioStream = info.GetAudioOnlyStreams().GetWithHighestBitrate();
                await client.Videos.Streams.DownloadAsync(audioStream, path + @"\temp.webm", progress);

                return true;
            }
            catch (System.UnauthorizedAccessException) // Access denied
            {
                MessageBox.Show($"Access denied\nCan't access this path: {path}\nRequires Administrator privileges", "Access denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex) // Unexpected error
            {
                MessageBox.Show($"Please report this error to the author:\n\n{ex.Message}", "Unexpected Error!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
