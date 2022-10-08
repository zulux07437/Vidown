using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidown.Wrapper
{
    public class ffmpeg
    {
        public static void ExtensionConversion(string input, string output, Functions.Extensions outputExtension)
        {
            string extensionText = null;
            if (outputExtension == Functions.Extensions.OGG)
                extensionText = "ogg";
            else if (outputExtension == Functions.Extensions.WebmVideo)
                extensionText = "webm";
            else if (outputExtension == Functions.Extensions.MP3)
                extensionText = "mp3";
            else if (outputExtension == Functions.Extensions.MP4)
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
