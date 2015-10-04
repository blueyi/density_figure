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
;
            string manualTitle = "计算时间" + "," + "冰块数量" + "," + "密集度" + ","
                + "最大冰块面积" + "," + "最小冰块面积" + "," + "图像地址";
            if (!File.Exists(Application.StartupPath + @"\Datas\manual.csv"))
            {
                DataToFile.strToFile(Application.StartupPath + @"\Datas\manual.csv", manualTitle);
            }

            //创建自动计算文件
            if (!File.Exists(Application.StartupPath + @"\Datas\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv"))
            {
                DataToFile.strToFile(Application.StartupPath + @"\Datas\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv", manualTitle);
            }
        }

        string currentPic = "";  //文件路径
        Point start;//矩形起点
        Point end;//矩形终点
        Point autoStart;//自动计算的起点
        Point autoEnd;//自动计算的终点
        Graphics g;  //封装的绘图画面

        //Picture deal function
        public void allPicFunc(PictureBox picBox, string picName, Point start, Point end)
        {
            string cuttedPic = "";
            string grayedPic = "";
            if (picName.Length != 0)
            {
                cuttedPic = PicFunction.picCutFunction(originalPicBox, picName, start, end);
                if (cuttedPic.Length != 0)
                {
                    grayedPic = PicFunction.picGrayScale(cuttedPic, Convert.ToInt32(grayNum.Value));
                    if (grayedPic.Length != 0)
                    {

                        int iceBlockNum = 0;  //冰块总数
                        int maxIceArea = 0;  //最大冰块
                        int minIceArea = 0;  //最小冰块
                        double iceDensity = 0.0;  //密集度

                        PicFunction.picCalculate(grayedPic, ref iceBlockNum, ref iceDensity, ref maxIceArea, ref minIceArea);

                        iceDensityText.Text = iceDensity.ToString();
                        iceNumText.Text = iceBlockNum.ToString();
                        maxIceText.Text = maxIceArea.ToString();
                        minIceText.Text = minIceArea.ToString();
                        resultPanel.Refresh();
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
            folderDialog.Description = "请选择含有图像的文件夹";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderDialog.SelectedPath;
                dir = new DirectoryInfo(folderPath);
                fileInf = dir.GetFiles();
                picNames = new string[fileInf.Length];
                int i = 0;
                foreach (FileInfo finf in fileInf)
                {
                    if (finf.Extension.Equals(".jpg") || finf.Extension.Equals(".JPG") || finf.Extension.Equals(".bmp") || finf.Extension.Equals(".BMP") || finf.Extension.Equals(".PNG") || finf.Extension.Equals(".PNG"))
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
                    startPointText.Enabled = true;
                    endPointText.Enabled = true;
                    timeToCalue.Enabled = true;
                    isCycleCalculate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("此文件夹中没有图片，请重新设置！");
                    autoCalButton.Enabled = false;

                }
                return picNames;
            }
            else
            {
                MessageBox.Show("文件夹选择错误");
                return null;
            }
        }

        //修正矩形的起点和终点
        public void revisePoint(ref Point start, ref Point end)
        {
            int temp;
            if (start.X > end.X)
            {
                temp = start.X;
                start.X = end.X;
                end.X = temp;
            }
            if (start.Y > end.Y)
            {
                temp = start.Y;
                start.Y = end.Y;
                end.Y = temp;
            }
        }
        private void openPicButton_Click(object sender, EventArgs e)
        {
            currentPic = PicFunction.openPictFunction();
            if (currentPic != "")
            {
                originalPicBox.Image = new Bitmap(currentPic);
                originalPicBox.Refresh(); ;
            }
        }

        //----选择图片区域
        bool mouseInPicPress = false;  //表示鼠标被按下
        Point mouseMoveBorderStart;  //由mouseMove确定的边界起点，以用于当鼠标移出图像时的start
        Point mouseMoveBorderEnd;  //由mouseMove确定的边界终点，以用于当鼠标移出图像时的end
        //画出起点
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

                }
            }
        }

        //移动并选择计算区域
        private void originalPic_MouseUp(object sender, MouseEventArgs e)
        {

            if (originalPicBox.Image != null && mouseInPicPress)
            {

                mouseInPicPress = false;  //表示图片不需要重画，可以用于计算
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
                    end.X = e.X;
                    end.Y = e.Y;
                }
                else
                {
                    start.X = mouseMoveBorderStart.X;
                    start.Y = mouseMoveBorderStart.Y;
                    end.X = mouseMoveBorderEnd.X;
                    end.Y = mouseMoveBorderEnd.Y;
                }

                //修正矩形的起点和终点
                revisePoint(ref start, ref end);
                g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, end.X - start.X, end.Y - start.Y);

                autoStart = start;
                autoEnd = end;

                allPicFunc(originalPicBox, currentPic, start, end);

                string manualStr = DateTime.Now.ToString() + "," + iceNumText.Text + "," + iceDensityText.Text + ","
                    + maxIceText.Text + "," + minIceText.Text + "," + currentPic;
                DataToFile.strToFile(Application.StartupPath + @"\Datas\manual.csv", manualStr);

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

                double rate = (double)picShowHeight / (double)originalPicHeight;

                //if (rectangle.Contains(e.Location))  //这是一个更好的解决方式
                if ((e.X > picLeftWidth) && (e.X < picShowWidth + picLeftWidth) && (e.Y > picTopHeight) && (e.Y < picShowHeight + picTopHeight))
                {

                    picCoordinateTip.Active = true;
                    if (mouseInPicPress)  //重画
                    {
                        this.originalPicBox.Refresh();
                        end.X = e.X;
                        end.Y = e.Y;

                        Point tempStart = start;

                        //修正矩形的起点和终点
                        revisePoint(ref tempStart, ref end);
                        g.DrawRectangle(new Pen(Color.Red), tempStart.X, tempStart.Y, end.X - tempStart.X, end.Y - tempStart.Y);

                        mouseMoveBorderStart.X = tempStart.X;
                        mouseMoveBorderStart.Y = tempStart.Y;
                        mouseMoveBorderEnd.X = end.X;
                        mouseMoveBorderEnd.Y = end.Y;
                    }
                    //缩放图中鼠标的坐标
                    int zoom_x = e.X - picLeftWidth;
                    int zoom_y = e.Y - picTopHeight;

                    //原图中鼠标的坐标
                    int original_x = Convert.ToInt32((double)zoom_x / rate);
                    int original_y = Convert.ToInt32((double)zoom_y / rate);
                    if (original_x >= originalPicWidth)
                        original_x = originalPicWidth - 1;
                    if (original_y >= originalPicHeight)
                        original_y = originalPicHeight - 1;

                    Bitmap bm = (Bitmap)originalPicBox.Image;
                    Color color = bm.GetPixel(original_x, original_y);
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    picCoordinateTip.Show("（" + zoom_x + "," + zoom_y + "）" + gray, this.originalPicBox, new Point(e.X + 60, e.Y));
                }
                picCoordinateTip.Active = false;
            }
            else
            {
                MessageBox.Show("请选择图片用于计算!");
                currentPic = PicFunction.openPictFunction();
                if (currentPic != "")
                {
                    try
                    {
                        originalPicBox.Image = new Bitmap(currentPic);
                        originalPicBox.Refresh(); ;
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show("错误信息： " + err.Message + "\n该图像已损坏：" + currentPic + "\n点击\"确定\"重新选择图像!");
                    }
               }
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
                try
                {
                    originalPicBox.Image = new Bitmap(picNames[picNumToCyc]);
                    currentPic = picNames[picNumToCyc];
                    allPicFunc(originalPicBox, currentPic, autoStart, autoEnd);
                    currentPIcNumLabel.Text = (picNumToCyc + 1).ToString() + "/" + picNum.ToString();
                    currentPicNameLabel.Text = Path.GetFileName(currentPic);
                    picNumToCyc++;

                    string autoStr = DateTime.Now.ToString() + "," + iceNumText.Text + "," + iceDensityText.Text + ","
                    + maxIceText.Text + "," + minIceText.Text + "," + currentPic;
                    DataToFile.strToFile(Application.StartupPath + @"\Datas\" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv", autoStr);
                }
                catch(Exception err)
                {
                    timer.Stop();
                    MessageBox.Show("错误信息： " + err.Message + "\n该图像已损坏, 请删除：" + picNames[picNumToCyc] + "\n点击\"确定\"继续开始计算下一张图像!");
                    picNumToCyc++;
                    timer.Start();
                }
            }
            else
            {
                picNumToCyc = 0;
                if (!isCycleCalculate.Checked)
                {
                    timer.Stop();
                    stopCal = false;
                    openPicButton.Enabled = true;
                    autoCalButton.Text = "自动计算";
                    originalPicBox.Enabled = true;
                    setFolderButton.Enabled = true;
                    openPicButton.Enabled = true;
                    g = this.originalPicBox.CreateGraphics();
                    g.DrawRectangle(new Pen(Color.Red), autoStart.X, autoStart.Y, autoEnd.X - autoStart.X, autoEnd.Y - autoStart.Y);
                }
            }

        }

        private void startPointText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请使用鼠标在图片中选择自动计算区域");
        }

        private void endPointText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请使用鼠标在图片中选择自动计算区域");
        }

        private void openTempButton_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath; 
            if (path.EndsWith(@"\"))
                path = Application.StartupPath + @"Temp";
            else
                path = Application.StartupPath + @"\Temp";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void openDatasButton_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            if (path.EndsWith(@"\"))
                path = Application.StartupPath + @"Datas";
            else
                path = Application.StartupPath + @"\Datas";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            this.originalPicBox.Refresh();
        }

    }
}
