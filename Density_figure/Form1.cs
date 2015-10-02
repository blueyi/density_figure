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
            //创建临时图片存放文件夹
            if (!Directory.Exists(Application.StartupPath + @"\Temp\"))
                Directory.CreateDirectory(Application.StartupPath + @"\Temp\");

            //创建计算数据存放文件夹
            if (!Directory.Exists(Application.StartupPath + @"\Datas\"))
                Directory.CreateDirectory(Application.StartupPath + @"\Datas\");

            //创建手动计算文件
            FileStream fs;
            StreamWriter sw;
            string manualTitle = "计算时间" + "\t" + "冰块数量" + "\t" + "密集度" + "\t"
                + "最大冰块面积" + "\t" + "最小冰块面积" + "\t" + "图像地址";  
            fs = new FileStream(Application.StartupPath + @"\Datas\manual.txt", FileMode.Append);
            sw = new StreamWriter(fs);
            sw.WriteLine(manualTitle);
            sw.Flush();
            sw.Close();
            fs.Close();

            //创建自动计算文件
            fs = new FileStream(Application.StartupPath + @"\Datas\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Append);
            sw = new StreamWriter(fs);
            sw.WriteLine(manualTitle);
            sw.Flush();
            sw.Close();
            fs.Close();

        }


        string currentPic = "";  //文件路径
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
                //原图大小
                int originalPicWidth = picBox.Image.Width;
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
                    sWidth = pic.Width;
                    sHeight = pic.Height;
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
                    board = new int[bd.Width, bd.Height];
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

                iceBlockNum = FindIceBlock.findIce(board, resultIceSum, sWidth, sHeight, icenum, ref maxIceArea, ref minIceArea) - 1;

                int icesum = sWidth * sHeight;
                double mjd = Convert.ToDouble(icenum) / Convert.ToDouble(icesum);
                double de = Math.Round(mjd, 4);//将小数值舍入到指定精度
                iceDensityText.Text = de.ToString();
                iceNumText.Text = iceBlockNum.ToString();
                maxIceText.Text = maxIceArea.ToString();
                minIceText.Text = minIceArea.ToString();
                panel3.Refresh();



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

            if (!isDeleteTempPic.Checked)
            {
                if (File.Exists(cuttedPic))
                    File.Delete(cuttedPic);
                if (File.Exists(grayedPic))
                    File.Delete(grayedPic);
            }
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
                    originalPicBox.Image = new Bitmap(currentPic);
                    originalPicBox.Refresh();
                }

                catch (Exception err)
                {
                    MessageBox.Show("系统出错，请重试!---5" + err.Message);
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
                    autoCalButton.Enabled = true;
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

                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = originalPicBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(originalPicBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == this.originalPicBox.Width) ? 0 : (this.originalPicBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == this.originalPicBox.Height) ? 0 : (this.originalPicBox.Height - picShowHeight) / 2;

                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    mouseInPicPress = true;
                    start = new Point();
                    end = new Point();
                    g = this.originalPicBox.CreateGraphics();
                    start.X = e.X;
                    start.Y = e.Y;
                    end.X = e.X;
                    end.Y = e.Y;
                    g.DrawLine(new Pen(Color.Red), new Point(start.X, start.Y), new Point(start.X + 2, start.Y));
                    blnDraw = true;

                }
            }
        }

        //移动并选择计算区域
        private void originalPic_MouseUp(object sender, MouseEventArgs e)
        {

            if (originalPicBox.Image != null && blnDraw)
            {
                //获取图片缩放后的大小
                PropertyInfo rectangleProperty = originalPicBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
                Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(originalPicBox, null);
                //图片显示的宽度
                int picShowWidth = rectangle.Width;
                int picShowHeight = rectangle.Height;
                //图片左边或者上边空白的宽度
                int picLeftWidth = (picShowWidth == this.originalPicBox.Width) ? 0 : (this.originalPicBox.Width - picShowWidth) / 2;
                int picTopHeight = (picShowHeight == this.originalPicBox.Height) ? 0 : (this.originalPicBox.Height - picShowHeight) / 2;

                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                }
                
                blnDraw = false;  //表示图片不需要重画，可以用于计算

                autoStart = start;
                autoEnd = end;

                allPicFunc(originalPicBox, currentPic, start, end);

                string manualStr = DateTime.Now.ToString() + "\t" + iceNumText.Text + "\t" + iceDensityText.Text + "\t"
                    + maxIceText.Text + "\t" + minIceText.Text + "\t" + currentPic;

                FileStream fs = new FileStream(Application.StartupPath + @"\Datas\manual.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(manualStr);
                sw.Flush();
                sw.Close();
                fs.Close();

                //设置自动计算的坐标
                if (picNames != null)
                {
                    startPointText.Text = "(" + (autoStart.X - picLeftWidth).ToString() + "," + (autoStart.Y - picTopHeight).ToString() + ")";
                    endPointText.Text = "(" + (autoEnd.X - picLeftWidth).ToString() + "," + (autoEnd.Y - picTopHeight).ToString() + ")";
                    startPointText.Refresh();
                    endPointText.Refresh();
                }
            }
        }
        private void originalPic_MouseMove(object sender, MouseEventArgs e)
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
                double rate_Width = (double)picShowWidth / (double)originalPicWidth;
                double rate_Height = (double)picShowHeight / (double)originalPicHeight;
               // picCoordinateTip.Show("（" + rate_Width.ToString() + ";" + rate_Height.ToString() + " ）", this.originalPicBox, new Point(e.X + 100, e.Y));

                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {
                    if (blnDraw)  //重画
                    {
                        this.originalPicBox.Refresh();
                        end.X = e.X;
                        end.Y = e.Y;

                        g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                    }
                    //缩放图中鼠标的坐标
                    int zoom_x = e.X - picLeftWidth;
                    int zoom_y = e.Y - picTopHeight;

                    //原图中鼠标的坐标
                    int original_x = Convert.ToInt32((double)zoom_x / rate_Height);
                    int original_y = Convert.ToInt32((double)zoom_y / rate_Height);
                    if (original_x >= originalPicWidth)
                        original_x = originalPicWidth - 1;
                    if (original_y >= originalPicHeight)
                        original_y = originalPicHeight - 1;

                    Bitmap bm = (Bitmap)originalPicBox.Image;
                    Color color = bm.GetPixel(original_x, original_y);
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    picCoordinateTip.Show("（" + zoom_x + ";" + zoom_y + " ）" + gray, this.originalPicBox, new Point(e.X + 100, e.Y));

                }
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

                string autoStr = DateTime.Now.ToString() + "\t" + iceNumText.Text + "\t" + iceDensityText.Text + "\t"
                    + maxIceText.Text + "\t" + minIceText.Text + "\t" + currentPic;
                FileStream fs = new FileStream(Application.StartupPath + @"\Datas\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(autoStr);
                sw.Flush();
                sw.Close();
                fs.Close();

            }
            else
                picNumToCyc = 0;

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
