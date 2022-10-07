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
        public static void ExtensionConversion(string input, string output)
        {
            ProcessStartInfo psi = new()
            {
                FileName = @"bin\ffmpeg.exe",
                Arguments = $"-i \"{input}\" \"{output}\""
            };

            Process p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
