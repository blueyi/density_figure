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
        /// <summary>
        /// 将字符串str以UTF8格式追加写入到文件fileName中
        /// </summary>
        /// <param name="fileName">需要写入文件的完整路径</param>
        /// <param name="str">需要写入的字符串</param>
        public static void strToFile(string fileName, string str)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(str);
                sw.Flush();
                fs.Flush();
                sw.Close();
                fs.Close();
            }
            catch(System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("请先关闭正在打开的以下文件: " + fileName + "\n才能正常写入历史记录数据!");

            }
            catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show("错误信息： " + err.Message);
            }
       }
    }
}
