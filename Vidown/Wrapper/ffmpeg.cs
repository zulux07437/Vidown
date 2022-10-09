using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidown.Wrapper
{
    /// <summary>
    /// ffmpeg.exe Wrapper
    /// </summary>
    public class ffmpeg
    {
        /// <summary>
        /// Extension Conversion with ffmpeg.exe
        /// </summary>
        /// <param name="input">Input</param>
        /// <param name="output">Output</param>
        /// <param name="outputExtension">Output Extension</param>
        public static void ExtensionConversion(string input, string output, YTDownload.Extensions outputExtension)
        {
            string extensionText = null;
            if (outputExtension == YTDownload.Extensions.OGG)
                extensionText = "ogg";
            else if (outputExtension == YTDownload.Extensions.WebmVideo)
                extensionText = "webm";
            else if (outputExtension == YTDownload.Extensions.MP3)
                extensionText = "mp3";
            else if (outputExtension == YTDownload.Extensions.MP4)
                extensionText = "mp4";

            ProcessStartInfo psi = new()
            {
                FileName = @"bin\ffmpeg.exe",
                Arguments = $"-i \"{input}\" \"{output}.{extensionText}\""
            };

            Process p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
