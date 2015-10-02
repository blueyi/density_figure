using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Density_figure
{
    class DataToFile
    {
        public static void strToFile(string fileName, string str)
        {
            FileStream fs;
            fs = new FileStream(fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
