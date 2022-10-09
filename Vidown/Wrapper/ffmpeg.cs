﻿using System;
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
        public static void ExtensionConversion(string input, string output, YouTubeDonwload.Extensions outputExtension)
        {
            string extensionText = null;
            if (outputExtension == YouTubeDonwload.Extensions.OGG)
                extensionText = "ogg";
            else if (outputExtension == YouTubeDonwload.Extensions.WebmVideo)
                extensionText = "webm";
            else if (outputExtension == YouTubeDonwload.Extensions.MP3)
                extensionText = "mp3";
            else if (outputExtension == YouTubeDonwload.Extensions.MP4)
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
