using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Density_figure
{
    public class FileInfoSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            FileInfo xInfo = (FileInfo)x;
            FileInfo yInfo = (FileInfo)y;
            //按名称排序
            return xInfo.Name.CompareTo(yInfo.Name);//递增     
            //return yInfo.Name.CompareTo(xInfo.Name);//递減     

            //依修改日期排序     
            //return xInfo.LastWriteTime.CompareTo(yInfo.LastWriteTime);//递增     
            //return yInfo.LastWriteTime.CompareTo(xInfo.LastWriteTime);//递減   
        }

    }
}
