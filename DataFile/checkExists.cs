using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerochanImageSelenium.DataFile
{
    internal class checkExists
    {
        public checkExists() { }

        public bool check(string filePath,string fileName)
        {
            string[] allChildFile = Directory.GetFiles("E:\\Picture\\MyWaifu","*.*",SearchOption.AllDirectories);
            foreach(string name in allChildFile)
            {
                if (String.Compare(Path.GetFileName(name),fileName)==0)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}
