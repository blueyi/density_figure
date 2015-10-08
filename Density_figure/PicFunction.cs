using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace Density_figure
{
    class PicFunction
    {
        /// <summary>
        /// 根据给定的图像及起点坐标和终点坐标截取图像，并储存,返回截取后的图像路径
        /// </summary>
        /// <param name="picBox">存放被截图像的PictureBox</param>
        /// <param name="picName">图像路径</param>
        /// <param name="start">起点</param>
        /// <param name="end">终点,起点必须在终点上方</param>
        /// <returns>返回截取后的图像路径</returns>
        public static string picCutFunction(PictureBox picBox, string picName, Point start, Point end)
        {
            //-------debug-----
            //            MessageBox.Show(start.ToString() + "  end:"  + end.ToString());
            try
            {
                //原图高
                int originalPicHeight = picBox.Image.Height;
                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = picBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(picBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == picBox.Width) ? 0 : (picBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == picBox.Height) ? 0 : (picBox.Height - picShowHeight) / 2;

                //图片的缩放比例
                double rate = (double)picShowHeight / (double)originalPicHeight;

                //将显示坐标转换为原图坐标
                start.X = Convert.ToInt32((double)(start.X - picLeftWidth) / rate);
                start.Y = Convert.ToInt32((double)(start.Y - picTopHeight) / rate);
                end.X = Convert.ToInt32((double)(end.X - picLeftWidth) / rate);
                end.Y = Convert.ToInt32((double)(end.Y - picTopHeight) / rate);

                if (start.X < end.X && start.Y < end.Y)
                {
                    Bitmap pic = new Bitmap(picName);
                    int xa = start.X;
                    int xb = end.X;
                    int ya = start.Y;
                    int yb = end.Y;

                    Rectangle rec = new Rectangle(0, 0, pic.Width, pic.Height);
                    BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    IntPtr ptr = bd.Scan0;
                    int bytes = bd.Stride * bd.Height;
                    byte[] rgbvalues = new byte[bytes];
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);
                    int w;
                    int h;
                    w = xb - xa;
                    h = yb - ya;
                    Bitmap pic1 = new Bitmap(w, h);// (Application.StartupPath + @"\11.jpg");
                    Rectangle rec6 = new Rectangle(0, 0, w, h);
                    BitmapData bd6 = pic1.LockBits(rec6, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    IntPtr ptr6 = bd6.Scan0;
                    int bytes6 = bd6.Stride * bd6.Height;
                    byte[] rgbvalues6 = new byte[bytes6];
                    System.Runtime.InteropServices.Marshal.Copy(ptr6, rgbvalues6, 0, bytes6);

                    for (int i = xa; i < xb; i++)
                    {
                        for (int j = ya; j < yb; j++)
                        {
                            rgbvalues6[(j - ya) * bd6.Stride + (i - xa) * 3] = rgbvalues[j * bd.Stride + i * 3];
                            rgbvalues6[(j - ya) * bd6.Stride + (i - xa) * 3 + 1] = rgbvalues[j * bd.Stride + i * 3 + 1];
                            rgbvalues6[(j - ya) * bd6.Stride + (i - xa) * 3 + 2] = rgbvalues[j * bd.Stride + i * 3 + 2];
                        }
                    }

                    System.Runtime.InteropServices.Marshal.Copy(rgbvalues6, 0, ptr6, bytes6);
                    pic1.UnlockBits(bd6);
                    pic1.Save(Application.StartupPath + @"\Temp\" + Path.GetFileNameWithoutExtension(picName) + "_cuted.jpg");  //存储剪切后的图片
                    pic1.Dispose();

                    return Application.StartupPath + @"\Temp\" + Path.GetFileNameWithoutExtension(picName) + "_cuted.jpg";
                }
                else
                {
                    MessageBox.Show("划线未完成，请重新划线！");
                    return "";

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("系统出错，请重试!---1 " + err.Message + "\n当前处理图片： " + picName);
                return "";
            }
        }


        /// <summary>
        /// 将给定的图像根据，给定的居度值作灰度化处理并存储,返回灰度化处理后的图像路径
        /// </summary>
        /// <param name="picName">需要灰度化的图像路径</param>
        /// <param name="grayValue">灰度值</param>
        /// <returns>返回灰度处理后的图像路径</returns>
        public static string picGrayScale(string picName, int grayValue)
        {
            try
            {
                Bitmap pic = new Bitmap(picName);
                int size = grayValue;
                int width = pic.Width;
                int height = pic.Height;
                Rectangle rec = new Rectangle(0, 0, pic.Width, pic.Height);
                BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr ptr = bd.Scan0;
                int bytes = bd.Stride * bd.Height;
                byte[] rgbvalues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (rgbvalues[j * bd.Stride + i * 3 + 2] > size)
                        {
                            rgbvalues[j * bd.Stride + i * 3] = 255;
                            rgbvalues[j * bd.Stride + i * 3 + 1] = 255;
                            rgbvalues[j * bd.Stride + i * 3 + 2] = 255;
                        }
                        else
                        {
                            rgbvalues[j * bd.Stride + i * 3] = 0;
                            rgbvalues[j * bd.Stride + i * 3 + 1] = 0;
                            rgbvalues[j * bd.Stride + i * 3 + 2] = 0;
                        }
                    }
                }

                System.Runtime.InteropServices.Marshal.Copy(rgbvalues, 0, ptr, bytes);
                pic.UnlockBits(bd);
                pic.Save(Application.StartupPath + @"\Temp\" + Path.GetFileNameWithoutExtension(picName) + "_Grayed.jpg");
                pic.Dispose();

                return Application.StartupPath + @"\Temp\" + Path.GetFileNameWithoutExtension(picName) + "_Grayed.jpg";
            }
            catch (Exception err)
            {
                MessageBox.Show("系统出错，请重试!---2" + err.Message);
                return "";
            }
        }

        //grayscale to calculate
        /// <summary>
        /// 根据给给定的灰度图像计算出该图像中的所有白色连通区域，并计算连通区域个数，白色区域密集度，最大连通区域及最小连通区域大小
        /// </summary>
        /// <param name="picName">灰度图像路径</param>
        /// <param name="iceBlockNum">白色区域数量</param>
        /// <param name="iceDensity">密集度</param>
        /// <param name="maxIceArea">最大连通区域面积</param>
        /// <param name="minIceArea">最小连通区域面积</param>
        public static void picCalculate(string picName, ref int iceBlockNum, ref double iceDensity, ref int maxIceArea, ref int minIceArea)
        {
            try
            {
                int icenum = 0;
                Bitmap pic = new Bitmap(picName);

                int sWidth = pic.Width;
                int sHeight = pic.Height;
                int[,] board = new int[sWidth, sHeight]; //存储图片宽和高

                Rectangle rec = new Rectangle(0, 0, sWidth, sHeight);
                BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr ptr = bd.Scan0;
                int bytes = bd.Stride * bd.Height;
                byte[] Trgbvalues;
                Trgbvalues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, Trgbvalues, 0, bytes);

                for (int i = 0; i < sWidth; i++)
                {
                    for (int j = 0; j < sHeight; j++)
                    {
                        if (Trgbvalues[j * bd.Stride + i * 3] == 255 && Trgbvalues[j * bd.Stride + i * 3 + 1] == 255 && Trgbvalues[j * bd.Stride + i * 3 + 2] == 255)
                        {
                            icenum++;
                            board[i, j] = 1;
                        }
                        else
                            board[i, j] = 0;
                    }
                }
                int[] resultIceSum = new int[icenum + 2];  //存放所有冰块的大小

                //board 等于原来里面的board，iceBlockNum等于原来的nstep，resultIceSum等于numstep1
                iceBlockNum = FindIceBlock.findIce(board, resultIceSum, sWidth, sHeight, icenum, ref maxIceArea, ref minIceArea) - 3;

                iceDensity = Math.Round(Convert.ToDouble(icenum) / Convert.ToDouble(sWidth * sHeight), 4);//将小数值舍入到指定精度

                pic.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("系统出错，请重试!---3 " + err.Message);
            }
        }

        /// <summary>
        /// 打开文件浏览对话框，返回选择的图像路径
        /// </summary>
        /// <returns>返回选择的图像路径</returns>
        public static string openPictFunction()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\File\Images";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "请选择图片";
            openFileDialog1.DefaultExt = "*.jpg";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPG files(*.jpg)|*.jpg|BMP files(*.bmp)|*.bmp|PNG files(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return openFileDialog1.FileName;
                }
                catch (Exception err)
                {
                    MessageBox.Show("系统出错，请重试!---5" + err.Message);
                    return "";
                }
            }
            else
                return "";

        }

    }
}
