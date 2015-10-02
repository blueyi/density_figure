using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;  //文件，openPictButton_Click
using System.Drawing.Imaging;  //图形 picCut
using System.Reflection; //可以使用PropertyInfo

namespace Density_figure
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\Temp\"))
                Directory.CreateDirectory(Application.StartupPath + @"\Temp\");
        }


        string currentPic = "";  //文件路径
        string shortName = "";
        int sWidth;
        int sHeight;//载入图片的宽度和高度
        Point start;//矩形起点
        Point end;//矩形终点

        Point autoStart;//自动计算的起点
        Point autoEnd;//自动计算的终点

        int[,] board;  //存储图片宽和高
        bool blnDraw;  //鼠标被按下时为真，表示此时区域已经选择，可以重新选择区域

        Graphics g;  //封装的绘图画面


        //Picture deal function

        //------Picture cut


        public string picCutFunction(PictureBox picBox, string picName, Point start, Point end)
        {
            //-------debug-----
            //            MessageBox.Show(start.ToString() + "  end:"  + end.ToString());
            try
            {
                if (start.X <= end.X && start.Y <= end.Y)
                {
                    Bitmap pic = new Bitmap(picName);
                    sWidth = pic.Width;
                    sHeight = pic.Height;
                    int xa = start.X * sWidth / picBox.Width;
                    int xb = end.X * sWidth / picBox.Width;
                    int ya = start.Y * sHeight / picBox.Height;
                    int yb = end.Y * sHeight / picBox.Height;

                    Rectangle rec = new Rectangle(0, 0, pic.Width, pic.Height);
                    BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    IntPtr ptr = bd.Scan0;
                    int bytes = bd.Stride * bd.Height;
                    byte[] rgbvalues = new byte[bytes];
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);
                    board = new int[bd.Width, bd.Height];
                    int w;
                    int h;
                    w = xb - xa + 1;
                    h = yb - ya;
                    Bitmap pic1 = new Bitmap(w, h + 1);// (Application.StartupPath + @"\11.jpg");
                    Rectangle rec6 = new Rectangle(0, 0, w, h + 1);
                    BitmapData bd6 = pic1.LockBits(rec6, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    IntPtr ptr6 = bd6.Scan0;
                    int bytes6 = bd6.Stride * bd6.Height;
                    byte[] rgbvalues6 = new byte[bytes6];
                    System.Runtime.InteropServices.Marshal.Copy(ptr6, rgbvalues6, 0, bytes6);
                    int k = 0;
                    int t = 0;

                    for (int i = xa; i < xb; i++)
                    {
                        for (int j = ya; j <= yb; j++)
                        {
                            if (t < h)
                            {
                                if (k > w)
                                    k = w;
                                rgbvalues6[t * bd6.Stride + k * 3] = rgbvalues[j * bd.Stride + i * 3];
                                rgbvalues6[t * bd6.Stride + k * 3 + 1] = rgbvalues[j * bd.Stride + i * 3 + 1];
                                rgbvalues6[t * bd6.Stride + k * 3 + 2] = rgbvalues[j * bd.Stride + i * 3 + 2];
                                t++;
                            }
                            else if ((t == h) & (k <= w))
                            {
                                rgbvalues6[t * bd6.Stride + k * 3] = rgbvalues[j * bd.Stride + i * 3];
                                rgbvalues6[t * bd6.Stride + k * 3 + 1] = rgbvalues[j * bd.Stride + i * 3 + 1];
                                rgbvalues6[t * bd6.Stride + k * 3 + 2] = rgbvalues[j * bd.Stride + i * 3 + 2];
                                k++;
                                t = 0;
                            }
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
                MessageBox.Show("系统出错，请重试!---1" + err.Message);
                return "";
            }
        }


        //picture to grayscale
        public string picGrayScale(string picName, int grayValue)
        {
            try
            {
                Bitmap pic = new Bitmap(picName);
                int size = grayValue;
                int width = pic.Width;
                int height = pic.Height;
                sWidth = width;
                sHeight = height;
                //                        cnt2 = 1;
                Rectangle rec = new Rectangle(0, 0, pic.Width, pic.Height);
                BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr ptr = bd.Scan0;
                int bytes = bd.Stride * bd.Height;
                byte[] rgbvalues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);
                board = new int[bd.Width, bd.Height];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (rgbvalues[j * bd.Stride + i * 3 + 2] > size)
                        {
                            board[i, j] = 3;
                        }
                        else
                        {

                            board[i, j] = 2;
                        }
                    }
                }
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (board[i, j] == 3)
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
        public void picCalculate(string picName, int areaLevel, int areaMin, int areaMax)
        {

            try
            {
                int minlh = (int)Convert.ToDouble(areaMin) * 22 / 50 * 22 / 50;
                int maxlh = (int)Convert.ToDouble(areaMax) * 22 / 50 * 22 / 50;
                int cntlh = Convert.ToInt32(areaLevel);
                int steplh = (maxlh - minlh) / cntlh;
                int icenum = 0;
                Bitmap pic = new Bitmap(picName);
                // Bitmap bgr = new Bitmap(longName3);

                sWidth = pic.Width;
                sHeight = pic.Height;
                board = new int[sWidth, sHeight];
                // int a = sWidth * sHeight;

                Rectangle rec = new Rectangle(0, 0, sWidth, sHeight);
                BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr ptr = bd.Scan0;
                int bytes = bd.Stride * bd.Height;
                byte[] Trgbvalues;
                Trgbvalues = new byte[bytes];
                //Trgbvalues1 = new byte[bytes];
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
                int iceBlockNum = 0;  //冰块总数
                int maxIceArea = 0;  //最大冰块
                int minIceArea = 0;  //最小冰块

                //if (icenum > 1)
                    iceBlockNum = FindIceBlock.findIce(board, resultIceSum, sWidth, sHeight, icenum, ref maxIceArea, ref minIceArea) - 1;
                //else
                //{
                //    iceBlockNum = 1;
                //    maxIceArea = minIceArea = 1;
                //}




                int icesum = sWidth * sHeight;
                double mjd = Convert.ToDouble(icenum) / Convert.ToDouble(icesum);
                double de = Math.Round(mjd, 4);//将小数值舍入到指定精度
                iceDensityText.Text = de.ToString();
                //  textBox5.Text = mjd.ToString();
                iceNumText.Text = iceBlockNum.ToString();
                maxIceText.Text = maxIceArea.ToString();
                minIceText.Text = minIceArea.ToString();
                panel3.Refresh();

                //                    cnt2 = 0;


                pic.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("系统出错，请重试!---3 " + err.Message);
            }
        }


        public void allPicFunc(PictureBox picBox, string picName, Point start, Point end)
        {
            string cuttedPic = "";
            string grayedPic = "";
            if (picName.Length != 0)
            {

                //  MessageBox.Show(originalPic.ImageLocation);   //如何获取picturebox中的图像路径
                cuttedPic = picCutFunction(originalPicBox, picName, start, end);
                if (cuttedPic.Length != 0)
                {
                    grayedPic = picGrayScale(cuttedPic, Convert.ToInt32(grayNum.Value));
                    if (grayedPic.Length != 0)
                    {
                        picCalculate(grayedPic, Convert.ToInt32(areaLevelNum.Value), Convert.ToInt32(areaSectionMin.Value), Convert.ToInt32(areaSectionMax.Value));
                    }
                    else
                        MessageBox.Show("数据处理未完成!---No grayedPic");
                }
                else
                    MessageBox.Show("数据处理未完成!---No cuttedPic");
            }
            else
                MessageBox.Show("数据处理未完成!---No originalPic");

            //---debug---
            //if (File.Exists(cuttedPic))
            //    File.Delete(cuttedPic);
            //if (File.Exists(grayedPic))
            //    File.Delete(grayedPic);
        }


        //----选择图片函数
        public void openPictFunction()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\File\Images";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "请选择图片";
            openFileDialog1.DefaultExt = "*.jpg";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPG files(*.jpg)|*.jpg|BMP files(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentPic = openFileDialog1.FileName;
                    shortName = Path.GetFileNameWithoutExtension(currentPic);
                    //Bitmap pic = new Bitmap(currentPic);
                    originalPicBox.Image = new Bitmap(currentPic);
                    originalPicBox.Refresh();
                    //picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // button16.Enabled = true;
                    //                    button22.Enabled = true;
                }

                catch (Exception err)
                {
                    MessageBox.Show("系统出错，请重试!---5" + err.Message);
                    //                    button6.Enabled = false;
                }
            }
        }

        //设置自动计算文件夹
        string folderPath = "";
        DirectoryInfo dir;
        FileInfo[] fileInf;
        string[] picNames;
        int picNum = 0;
        int picNumToCyc = 0; //循环处理的当前图片数
        public string[] selectPicFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "请选择含有图片的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderDialog.SelectedPath;
                dir = new DirectoryInfo(folderPath);
                fileInf = dir.GetFiles();
                picNames = new string[fileInf.Length];
                int i = 0;
                foreach (FileInfo finf in fileInf)
                {
                    if (finf.Extension.Equals(".jpg") || finf.Extension.Equals(".JPG") || finf.Extension.Equals(".bmp") || finf.Extension.Equals(".BMP"))
                        picNames[i++] = finf.FullName;
                }
                picNum = i;
                if (picNum > 0)
                {
                    MessageBox.Show("此文件夹中有" + picNum + "张图片！");
                    originalPicBox.Image = new Bitmap(picNames[0]);
                    currentPic = picNames[0];
                    currentAutoPathLabel.Text = folderPath;
                    currentPicNameLabel.Text = Path.GetFileName(currentPic);
                    currentPIcNumLabel.Text = picNumToCyc.ToString() + "/" + picNum.ToString();
                    picNumToCyc = 0;
                }
                else
                    MessageBox.Show("此文件夹中没有图片，请重新设置！");
                return picNames;
            }
            else
            {
                MessageBox.Show("文件夹选择错误");
                return null;
            }
        }

        private void openPicButton_Click(object sender, EventArgs e)
        {
            openPictFunction();
        }

        //----选择图片区域

        //画出起点

        bool mouseInPicPress = false;
        private void originalPic_MouseDown(object sender, MouseEventArgs e)
        {
            if (originalPicBox.Image != null)
            {

                //原图大小
                int originalPicWidth = this.originalPicBox.Image.Width;
                int originalPicHeight = this.originalPicBox.Image.Height;
                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = originalPicBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(originalPicBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == this.originalPicBox.Width) ? 0 : (this.originalPicBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == this.originalPicBox.Height) ? 0 : (this.originalPicBox.Height - picShowHeight) / 2;

                //图片的缩放比例
                double rate = (double)picShowHeight / (double)originalPicHeight;

                //缩放图中鼠标的坐标
                int zoom_x = e.X - picLeftWidth;
                int zoom_y = e.Y - picTopHeight;

                //原图中鼠标的坐标
                int original_x = Convert.ToInt32((double)zoom_x / rate);
                int original_y = Convert.ToInt32((double)zoom_y / rate); 
                
                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    mouseInPicPress = true;
                    start = new Point();
                    end = new Point();
                    //            button7.Enabled = true;  //表示图片已经可以开始通过点击显示来截取
                    g = this.originalPicBox.CreateGraphics();
                    start.X = e.X;
                    start.Y = e.Y;
                    end.X = e.X;
                    end.Y = e.Y;
                    g.DrawLine(new Pen(Color.Red), new Point(start.X, start.Y), new Point(start.X + 2, start.Y));
                    //g.DrawRectangle(new Pen(Color.Red), e.X,e.Y,e.X ,e.Y );
                    blnDraw = true;

                }
            }
        }

        //移动并选择计算区域
        private void originalPic_MouseUp(object sender, MouseEventArgs e)
        {

            if (originalPicBox.Image != null && blnDraw)
            {
                //原图大小
                int originalPicWidth = this.originalPicBox.Image.Width;
                int originalPicHeight = this.originalPicBox.Image.Height;
                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = originalPicBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(originalPicBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == this.originalPicBox.Width) ? 0 : (this.originalPicBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == this.originalPicBox.Height) ? 0 : (this.originalPicBox.Height - picShowHeight) / 2;

                //图片的缩放比例
                double rate = (double)picShowHeight / (double)originalPicHeight;

                //缩放图中鼠标的坐标
                int zoom_x = e.X - picLeftWidth;
                int zoom_y = e.Y - picTopHeight;

                //原图中鼠标的坐标
                int original_x = Convert.ToInt32((double)zoom_x / rate);
                int original_y = Convert.ToInt32((double)zoom_y / rate); 

                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                }
                
                //if (e.X <= (originalPic.Location.X + originalPic.Image.Width) && e.Y <= (originalPic.Location.Y + originalPic.Image.Height))
                //    g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                //else
                //    g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, end.X - start.X - 1, end.Y - start.Y - 1);


                blnDraw = false;  //表示图片不需要重画，可以用于计算

                autoStart = start;
                autoEnd = end;

                allPicFunc(originalPicBox, currentPic, start, end);

                //设置自动计算的坐标
                if (picNames != null)
                {
                    startPointText.Text = "(" + autoStart.X.ToString() + "," + autoStart.Y.ToString() + ")";
                    endPointText.Text = "(" + autoEnd.X.ToString() + "," + autoEnd.Y.ToString() + ")";
                    startPointText.Refresh();
                    endPointText.Refresh();
                }

                //----------debug------------
                //                grayedPic = Application.StartupPath + @"\Temp\" + "first1.jpg";

            }
        }
        private void originalPic_MouseMove(object sender, MouseEventArgs e)
        {
            //            Rectangle rectangle = originalPic.RectangleToClient(this.ClientRectangle);
            if (originalPicBox.Image != null)
            {
                //原图大小
                int originalPicWidth = this.originalPicBox.Image.Width;
                int originalPicHeight = this.originalPicBox.Image.Height; 
                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = originalPicBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(originalPicBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;  
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == this.originalPicBox.Width) ? 0 : (this.originalPicBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == this.originalPicBox.Height) ? 0 : (this.originalPicBox.Height - picShowHeight) / 2;

                //图片的缩放比例
                double rate = (double)picShowHeight / (double)originalPicHeight;

                //缩放图中鼠标的坐标
                int zoom_x = e.X - picLeftWidth;
                int zoom_y = e.Y - picTopHeight;

                //原图中鼠标的坐标
                int original_x = Convert.ToInt32((double)zoom_x / rate);
                int original_y = Convert.ToInt32((double)zoom_y / rate);  

                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    if (blnDraw)
                    {
                        this.originalPicBox.Refresh();
                        end.X = e.X;
                        end.Y = e.Y;

                        g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                    }
                   picCoordinateTip.Show("（" + original_x + ";" + original_y + " ）", this.originalPicBox, new Point(e.X + 100, e.Y));

                  //  Bitmap bm = (Bitmap)originalPicBox.Image;
                  //  Color color = bm.GetPixel(e.X, e.Y);
                  //  int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                  //  picCoordinateTip.Show("（" + e.X + ";" + e.Y + " ）" + gray, this.originalPicBox, new Point(e.X + 100, e.Y));

                }


                /*
                if (blnDraw)
                {
                    //先擦除

                    //g.DrawRectangle(new Pen(Color.White), start.X, start.Y, end.X - start.X, end.Y - start.Y);
                    this.originalPicBox.Refresh();
                    if (mouseInPicPress && (e.X > (originalPicBox.Location.X + originalPicBox.Image.Width)))
                    {
                        end.X = originalPicBox.Image.Width;
                    }
                    else
                        end.X = e.X;

                    if (mouseInPicPress && (e.Y > (originalPicBox.Location.Y + originalPicBox.Image.Height)))
                        end.Y = originalPicBox.Image.Height;
                    else
                        end.Y = e.Y;
                    //再画

                    if (e.X <= (originalPicBox.Location.X + originalPicBox.Image.Width) && e.Y <= (originalPicBox.Location.Y + originalPicBox.Image.Height))
                        g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                    else
                        g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, end.X - start.X - 1, end.Y - start.Y - 1);
                }
                */

                /*
                double heigh = originalPicBox.Image.Height;
                double width = originalPicBox.Image.Width;
                double h = (double)originalPicBox.Height / heigh;
                double w = (double)originalPicBox.Width / width;
                if (h <= w)
                {
                    double wid = ((double)originalPicBox.Width - originalPicBox.Image.Width * h) / 2;
                    if ((int)wid < e.X && e.X < (int)(originalPicBox.Width - wid))
                    {
                        int x = (int)(e.X - wid);
                        Bitmap bm = (Bitmap)originalPicBox.Image;
                        //label1.Text = string.Format("当前坐标点：（{0}，{1}） 灰度值：{2}", x, e.Y, bm.GetPixel(x, e.Y));

                        int x1 = (int)(x / h);
                        int y1 = (int)(e.Y / h);
                        if (x1 < originalPicBox.Image.Width && x1 >= 0)
                        {
                            if (y1 >= 0 && y1 < originalPicBox.Image.Height)
                            {
                                Color color = bm.GetPixel(x1, y1);
                                int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                                // if (rectangle.Contains(MousePosition))
                                picCoordinateTip.Show("（" + x + ";" + e.Y + " ）" + gray, this.originalPicBox, new Point(e.X + 100, e.Y));
                                //  else
                                //  picCoordinateTip.Hide(originalPic);
                                //picCoordinateTip.Show("("+x+";"+e.Y+")"+gray);
                                //textBox19.Text = string.Format("灰度值{0}", gray);
                            }
                        }
                    }
                }
                else
                {
                    double hei = ((double)originalPicBox.Height - originalPicBox.Image.Height * w) / 2;
                    if ((int)hei < e.Y && e.Y < (int)(originalPicBox.Height - hei))
                    {
                        int y = (int)(e.Y - hei);
                        Bitmap bm = (Bitmap)originalPicBox.Image;
                        //label1.Text = string.Format("当前坐标点：（{0}，{1}） 灰度值：{2}", e.X, y, bm.GetPixel(e.X, y));

                        int x1 = (int)(e.X / w);
                        int y1 = (int)(y / w);
                        if (x1 < originalPicBox.Image.Width && x1 >= 0)
                        {
                            if (y1 >= 0 && y1 < originalPicBox.Image.Height)
                            {
                                Color color = bm.GetPixel(x1, y1);
                                int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                                //textBox19.Text = string.Format("灰度值{0}", gray);
                                //                                if (rectangle.Contains(MousePosition))
                                picCoordinateTip.Show("" + e.X + ";" + y + " (" + gray + ")", this.originalPicBox, new Point(e.X + 120, e.Y));
                                //                                else
                                //                                    picCoordinateTip.Hide(originalPic);

                            }
                        }
                    }

                }
                 */

            }
            else
            {
                MessageBox.Show("请选择图片用于计算!");
                openPictFunction();
            }
        }


        private void setFileButton_Click(object sender, EventArgs e)
        {
            originalPicBox.Enabled = false;
            selectPicFolder();
            autoCalButton.Enabled = true;
            originalPicBox.Enabled = true;
        }

        bool stopCal = false;
        private void autoCalButton_Click(object sender, EventArgs e)
        {
            if (startPointText.Text.Length < 6 || endPointText.Text.Length < 6)
            {
                MessageBox.Show("请先使用鼠标选择计算区域！");
            }
            else
            {
                openPicButton.Enabled = false;
                if (!stopCal)
                {
                    timer.Interval = Convert.ToInt32(timeToCalue.Value) * 1000;
                    timer.Start();
                    stopCal = (!stopCal);
                }
                else
                {
                    timer.Stop();
                    stopCal = (!stopCal);
                    openPicButton.Enabled = true;
                    originalPicBox.Enabled = true;
                }
                if (timer.Enabled)
                {
                    autoCalButton.Text = "停止自动计算";
                    originalPicBox.Enabled = false;
                    setFolderButton.Enabled = false;
                }
                else
                {
                    autoCalButton.Text = "自动计算";
                    originalPicBox.Enabled = true;
                    setFolderButton.Enabled = true;
                    g = this.originalPicBox.CreateGraphics();
                    g.DrawRectangle(new Pen(Color.Red), autoStart.X, autoStart.Y, autoEnd.X - autoStart.X, autoEnd.Y - autoStart.Y);
                }
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (picNumToCyc < picNum)
            {
                originalPicBox.Image = new Bitmap(picNames[picNumToCyc]);
                currentPic = picNames[picNumToCyc];
                allPicFunc(originalPicBox, currentPic, autoStart, autoEnd);
                currentPIcNumLabel.Text = (picNumToCyc + 1).ToString() + "/" + picNum.ToString();
                currentPicNameLabel.Text = Path.GetFileName(currentPic);
                picNumToCyc++;
            }
            else
                picNumToCyc = 0;
            // -----------debug-------
            //            if (timer.Enabled)
            //            {
            //                g = this.originalPic.CreateGraphics();
            //                g.DrawRectangle(new Pen(Color.Red), autoStart.X, autoStart.Y, autoEnd.X - autoStart.X, autoEnd.Y - autoStart.Y);
            //            }
        }

        private void startPointText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请使用鼠标在图片中选择自动计算区域");
        }

        private void endPointText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请使用鼠标在图片中选择自动计算区域");
        }

    }
}
