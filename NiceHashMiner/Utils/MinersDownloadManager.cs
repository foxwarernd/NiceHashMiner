using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;
using System.Windows.Forms;
using NiceHashMiner.Interfaces;
using System.Threading;
using NiceHashMiner.Configs;
using NiceHashMiner.Devices;

namespace NiceHashMiner.Utils {
    public static class MinersDownloadManager {
        public static DownloadSetup StandardDlSetup = new DownloadSetup(
            "https://github.com/gacopl/NiceHashMiner/releases/download/1.7.5.13-gaco-mod/bin.zip",
            "bins.zip",
            "bin");

        public static DownloadSetup ThirdPartyDlSetup = new DownloadSetup(
            "https://github.com/gacopl/NiceHashMiner/releases/download/1.7.5.13-gaco-mod/bin_3rdparty.zip",
            "bins_3rdparty.zip",
            "bin_3rdparty");
    }
}
