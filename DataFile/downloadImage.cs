using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZerochanImageSelenium.DataFile
{
    internal class downloadImage
    {
        downloadImage(string url,string finalFilePath)
        {
            using(WebClient client = new WebClient())
            {
                client.DownloadDataAsync(new Uri(url), finalFilePath);
            }
        }
    }
}
