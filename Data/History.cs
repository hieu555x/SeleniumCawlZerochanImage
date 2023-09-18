using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerochanImageSelenium.Data
{
    internal class History
    {
        public History(string path)
        {
            using (var stream = File.Open(path, FileMode.OpenOrCreate))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
            }

        }
        public string[] readFile(string path)
        {
            using (var stream = File.OpenRead(path))
            {
                string[] file = File.ReadAllLines(path);
                return file;
            }
            return null;
        }
        public void writeFile(string path, string[] data)
        {
            using (var stream = File.OpenRead(path))
            {
                File.WriteAllLines(path, data);
            }
        }

    }
}
