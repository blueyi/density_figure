using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.InteropServices;

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
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("请先关闭正在打开的以下文件: " + fileName + "\n才能正常写入历史记录数据!");

            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("错误信息： " + err.Message);
            }
        }


        [DllImport("kernel32.dll")]
        public static extern IntPtr _lopen(string lpPathName, int iReadWrite);
        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);
        public const int OF_READWRITE = 2;
        public const int OF_SHARE_DENY_NONE = 0x40;
        public static readonly IntPtr HFILE_ERROR = new IntPtr(-1);

        public static bool isFileInUsed(string fileName)
        {
            IntPtr vHandle = _lopen(fileName, OF_READWRITE | OF_SHARE_DENY_NONE);
            if (vHandle == HFILE_ERROR)
            {
                return true;
            }
            CloseHandle(vHandle);
            return false;
        }
    }
}
