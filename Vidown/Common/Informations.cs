using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vidown.Common
{
    /// <summary>
    /// Informations
    /// </summary>
    public static class Informations
    {
        private static readonly FileVersionInfo s_fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        public static readonly string Copyright = s_fvi.LegalCopyright;
        public static readonly string Creator = "zulux07437";
    }
}
