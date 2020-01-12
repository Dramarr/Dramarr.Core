using System;
using System.IO;
using System.Net;

namespace Dramarr.Core.Download
{
    public class DownloadHelpers
    {
        /// <summary>
        /// Downloads a file
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool DownloadFile(string url, string path, string filename)
        {
            try
            {
                Directory.CreateDirectory(path);

                var filepath = Path.Combine(path, filename);

                if (!File.Exists(filepath) || new FileInfo(filepath)?.Length < 1000000)
                {
                    using var wc = new WebClient();
                    wc.DownloadFile(url, filepath);
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
