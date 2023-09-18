using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerochanImageSelenium.Data
{
    internal class ListLink
    {
        public string fileName { get; set; }
        public string urlFile { get; set; }
        public ListLink(string fileName, string urlFile)
        {
            this.fileName = fileName;
            this.urlFile = urlFile;
        }
    }
}
