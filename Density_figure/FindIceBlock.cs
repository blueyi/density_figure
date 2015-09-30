using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Density_figure
{
    class FindIceBlock
    {

        //遍历并标记所有冰块,返回冰块数目
        public int findIce(int[,] resultArr, int[] resultSum, int width, int height, int allIceNum)
        {

            int allIceNumHere = allIceNum;
            //            bool[] isChecked = new bool[allIceNum]; //检查该冰点是否已被标记
            int iceOrder = 1;  //冰块顺序
            int iceOrderSum = 0;   //当前冰块序号对应的冰块大小
            int[] currentCheckedIceIdx;   //用于存放当前检查过的像素索引
            int arrLength = width * height;
            int[] arrLine = new int[arrLength];  //存放一维化之后的数组
            int lastPoint = 0; //上一块冰的起点

            //将像素线性化
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    arrLine[j * width + i] = resultArr[i, j];
                }
            }

            while (allIceNumHere != 0)
            {
                int idxUp = 0;  //向上扫描的起始坐标
                int idxDown = 0;  //向下扫描的起始坐标
                int currentOrderStart = 0;  //记录当前序号冰块的检查起点

                currentCheckedIceIdx = new int[allIceNum];

                iceOrder++;
                iceOrderSum = 0;  //当前冰块序号对应的所有冰数量

                //找到需要标记的冰,即像素为1的点
                findFirstPoint(ref lastPoint, arrLine, arrLength);
                //                isAllCheckedInCurrentIce(resultArr, 1, ref idxUpX, ref idxUpY, ref idxDownX, ref idxDownY, width, height);
                //                idxDownX = idxUpX;
                //                idxDownY = idxUpY;
                idxDown = idxUp = lastPoint;

                //确定当前冰块的初始扫描行
                markIceLine(arrLine, iceOrder, ref iceOrderSum, idxUp, currentCheckedIceIdx, width, ref allIceNumHere);

                //检查是否当前连通块的冰全部标记完成
                while (!isAllCheckedInCurrentIceBlock(currentCheckedIceIdx, arrLine, ref currentOrderStart, ref idxUp, ref idxDown, width, height, iceOrderSum))
                {

                    //重要的边界------
                    while ((idxUp >= 0) && (arrLine[idxUp] == 1))
                    {
                        //                            markIceLine(resultArr, iceOrder, ref iceOrderSum, ref idxUpX, ref idxUpY, width, ref allIceNumHere);
                        //                            idxUpY--;
                        markIceLine(arrLine, iceOrder, ref iceOrderSum, idxUp, currentCheckedIceIdx, width, ref allIceNumHere);
                        idxUp = idxUp - width;
                    }

                    //重要的边界------
                    while ((idxDown / width < height) && (arrLine[idxDown] == 1))
                    {
                        markIceLine(arrLine, iceOrder, ref iceOrderSum, idxDown, currentCheckedIceIdx, width, ref allIceNumHere);
                        idxDown = idxDown + width;
                        // markIceLine(resultArr, iceOrder, ref iceOrderSum, ref idxDownX, ref idxDownY, width, ref allIceNumHere);
                        // idxDownY++;
                    }
                }
                resultSum[iceOrder] = iceOrderSum;
            }

            return iceOrder;
        }

        //标记当前行中所有需要标记的冰块
        public void markIceLine(int[] arrLine, int iceOrder, ref int iceOrderSum, int lastPoint, int[] currentCheckedIceIdx, int width, ref int allIceNumHere)
        {
            int leftX = lastPoint;
            int rightX = lastPoint + 1;
            while (true)
            {
                arrLine[leftX] = iceOrder;
                currentCheckedIceIdx[iceOrderSum] = leftX;  //记录当前冰块坐标
                iceOrderSum++;
                allIceNumHere--;
                leftX--;

                //重要的边界------
                //满足以下条件退出：超出图像左边界, 该位置不是冰，该文件是标记过的冰
                if ((leftX < 0) || (((leftX + 1) % width) == 0) || (arrLine[leftX] != 1))
                    break;
            }

            while (true)
            {
                //重要的边界------
                //满足以下条件退出：超出图像左边界, 该位置不是冰，该文件是标记过的冰
                if ((rightX > arrLine.Length) || ((rightX % width) == 0) || (arrLine[rightX] != 1))  //如果向右已经到达图像右边界，则直接退出
                    break;

                arrLine[rightX] = iceOrder;
                currentCheckedIceIdx[iceOrderSum] = rightX;  //记录当前冰块坐标
                iceOrderSum++;
                allIceNumHere--;
                rightX++;
            }

        }

        public int idxConvert(int x, int y, int width)
        {
            return (y * width + x);
        }

        //每块冰第一次被扫描到时，确定出它的初始位置
        public void findFirstPoint(ref int lastPoint, int[] arrLine, int arrLength)
        {
            int i = lastPoint;
            while (i < arrLength)
            {
                if (arrLine[i] == 1)
                    break;
                i++;
            }
            lastPoint = i;
        }

        //判断是否当前冰块中的所有像素都已经被扫描过, 如果不是，则确定出下一次需要扫描的起点
        public bool isAllCheckedInCurrentIceBlock(int[] currentCheckedIceIdx, int[] arrLine, ref int currentOrderStart, ref int idxUp, ref int idxDown, int width, int height, int iceOrderSum)
        {
            bool checkDone = true;
            int x, y;
            int idxX, idxY;
            idxX = idxY = 0;
            int idx = currentOrderStart;

            for (; idx < iceOrderSum; idx++)
            {
                x = currentCheckedIceIdx[idx] % width;
                y = currentCheckedIceIdx[idx] / width;
                if ((x - 1 >= 0) && arrLine[x - 1 + y * width] == 1)
                {
                    checkDone = false;
                    idxX = x - 1;
                    idxY = y;
                    break;
                }

                if ((x + 1 < width) && arrLine[x + 1 + y * width] == 1)
                {
                    checkDone = false;
                    idxX = x + 1;
                    idxY = y;
                    break;
                }

                if ((y - 1 >= 0) && arrLine[x + (y - 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x;
                    idxY = y - 1;
                    break;
                }

                if ((y + 1 < height) && arrLine[x + (y + 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x;
                    idxY = y + 1;
                    break;
                }

                if ((x - 1 >= 0) && (y - 1 >= 0) && arrLine[x - 1 + (y - 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x - 1;
                    idxY = y - 1;
                    break;
                }

                if ((x + 1 < width) && (y - 1 >= 0) && arrLine[x + 1 + (y - 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x + 1;
                    idxY = y - 1;
                    break;
                }

                if ((x + 1 < width) && (y + 1 < height) && arrLine[x + 1 + (y + 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x + 1;
                    idxY = y + 1;
                    break;
                }

                if ((x - 1 >= 0) && (y + 1 < height) && arrLine[x - 1 + (y + 1) * width] == 1)
                {
                    checkDone = false;
                    idxX = x - 1;
                    idxY = y + 1;
                    break;
                }

            }

            currentOrderStart = idx + 1;  //记录当前冰块中下一次的起点
            idxUp = idxY * width + idxX;
            idxDown = (idxY + 1) * width + idxX;
            return checkDone;
        }

    }
}
