﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vidown.Common
{
    public static class Informations
    {
        private static readonly FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        public static readonly string Copyright = fvi.LegalCopyright;
        public static readonly string Creator = "zulux07437";
    }
}
