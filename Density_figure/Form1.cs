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

namespace Density_figure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string longName = "";  //文件路径
        string shortName = "";
        int sWidth;
        int sHeight;//载入图片的宽度和高度
        Point start;//矩形起点
        Point end;//矩形终点

        int[,] board;  //存储图片宽和高
        bool blnDraw;  //鼠标被按下时为真，表示此时区域已经选择，可以重新选择区域

        Graphics g;  //封装的绘图画面





        //Picture deal function

        //------Picture cut
        public void picCut(PictureBox picBox)
        {
            try
            {
                if (start.X <= end.X && start.Y <= end.Y)
                {
                    Bitmap pic = new Bitmap(longName);
                    sWidth = pic.Width;
                    sHeight = pic.Height;
                    int xa = start.X * sWidth / picBox.Width;
                    int xb = end.X * sWidth / picBox.Width;
                    int ya = start.Y * sHeight / picBox.Height;
                    int yb = end.Y * sHeight / picBox.Height;

                    int width = pic.Width;
                    int height = pic.Height;
                    //int newwidth;
                    //int newheigh;
                    Rectangle rec = new Rectangle(0, 0, pic.Width, pic.Height);
                    BitmapData bd = pic.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    IntPtr ptr = bd.Scan0;
                    int bytes = bd.Stride * bd.Height;
                    byte[] rgbvalues = new byte[bytes];
                    System.Runtime.InteropServices.Marshal.Copy(ptr, rgbvalues, 0, bytes);
                    board = new int[bd.Width, bd.Height];
                    //for (int i = 0; i < width; i++)
                    //{
                    //    for (int j = 0; j < height; j++)
                    //    {
                    //        if (i < xa || i > xb || j < ya || j > yb)
                    //        {
                    //            board[i, j] = 2;
                    //        }
                    //    }
                    //}

                    //for (int i = 0; i < width; i++)
                    //{
                    //    for (int j = 0; j < height; j++)
                    //    {
                    //        if (board[i, j] == 2)
                    //        {
                    //            rgbvalues[j * bd.Stride + i * 3] = 0;
                    //            rgbvalues[j * bd.Stride + i * 3 + 1] = 0;
                    //            rgbvalues[j * bd.Stride + i * 3 + 2] = 0;
                    //        }
                    //    }
                    //}
                    //System.Runtime.InteropServices.Marshal.Copy(rgbvalues, 0, ptr, bytes);
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
                    //// board = new int[bd.Width, bd.Height];
                    //// //Bitmap resizedBmp = new Bitmap(w, h);
                    ////// Graphics g = Graphics.FromImage(resizedBmp);
                    ////// g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    //// //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                    //// //g.DrawImage(image_dest, new Rectangle(0, 0, w, h), new Rectangle(0, 0, image_dest.Width, image_dest.Height), GraphicsUnit.Pixel);
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

                            //if (board[i, j] != 2)
                            //{
                            //    if ((t == h - 1) & (k < w))
                            //    {
                            //        rgbvalues6[t * bd6.Stride + k * 3] = rgbvalues[j * bd.Stride + i * 3];
                            //        rgbvalues6[t * bd6.Stride + k * 3 + 1] = rgbvalues[j * bd.Stride + i * 3 + 1];
                            //        rgbvalues6[t * bd6.Stride + k * 3 + 2] = rgbvalues[j * bd.Stride + i * 3 + 2];
                            //        t = 0;
                            //        k = k + 1;
                            //    }
                            //    else
                            //        if (k < w)
                            //        {
                            //            rgbvalues6[t * bd6.Stride + k * 3] = rgbvalues[j * bd.Stride + i * 3];
                            //            rgbvalues6[t * bd6.Stride + k * 3 + 1] = rgbvalues[j * bd.Stride + i * 3 + 1];
                            //            rgbvalues6[t * bd6.Stride + k * 3 + 2] = rgbvalues[j * bd.Stride + i * 3 + 2];
                            //            t++;
                            //        }

                            //}
                        }
                    }
                    System.Runtime.InteropServices.Marshal.Copy(rgbvalues6, 0, ptr6, bytes6);
                    pic1.UnlockBits(bd6);
                    pic1.Save(Application.StartupPath + "\\Temp" + "\\fit.jpg");  //存储处理后的图片

                    //显示处理后的图片
                    /*
                    pictureBox3.Image = new Bitmap(Application.StartupPath + "\\fit.jpg");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    // pictureBox3.Refresh();
                    button7.Enabled = false;
                    button16.Enabled = true;
                    longName3 = Application.StartupPath + "\\fit.jpg";
                    //System.Runtime.InteropServices.Marshal.Copy(rgbvalues, 0, ptr, bytes);
                    //pic.UnlockBits(bd);
                    //pic.Save(Application.StartupPath + "\\fit.jpg");
                    //pictureBox3.Image = new Bitmap(Application.StartupPath + "\\fit.jpg");
                    //pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

                    ////// vScrollBar1.Maximum = tableLayoutPanel9.Height;
                    //////vScrollBar1.Value = 800;
                    //////panel1.VerticalScroll.Value = panel1.VerticalScroll.Value + picBox.Height * 2;
                    panel1.VerticalScroll.Value = picBox.Height * 2 + 100;
                    //panel1.VerticalScroll.Value + picBox.Height * 2;   */
                }

                else
                {
                    //                    cnt1 = 0;
                    panel1.VerticalScroll.Value = 450;
                    panel1.VerticalScroll.Value = 0;
                    MessageBox.Show("划线未完成，请重新划线！");

                }
                //                button8.Enabled = true;
                //                button3.Enabled = true;
                //                button4.Enabled = true;
                //                button13.Enabled = true;
            }
            catch
            {
                MessageBox.Show("系统出错，请退出!");
            }
        }



        //----选择图片函数
        public void openPictFunction()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\File\Images";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = "*.jpg";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPG files(*.jpg)|*.jpg|BMP files(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    longName = openFileDialog1.FileName;
                    shortName = Path.GetFileNameWithoutExtension(longName);
                    //Bitmap pic = new Bitmap(longName);
                    originalPic.Image = new Bitmap(longName);
                    //picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // button16.Enabled = true;
                    //                    button22.Enabled = true;
                }

                catch
                {
                    MessageBox.Show("没打开文件，请重试！");
                    //                    button6.Enabled = false;
                }
            }
        }

        private void openPicButton_Click(object sender, EventArgs e)
        {
            openPictFunction();
        }

        //----选择图片区域

        //写出起点
        private void originalPic_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point();
            end = new Point();
            //            button7.Enabled = true;  //表示图片已经可以开始通过点击显示来截取
            blnDraw = false;
            g = this.originalPic.CreateGraphics();
            start.X = e.X;
            start.Y = e.Y;
            end.X = e.X;
            end.Y = e.Y;
            g.DrawLine(new Pen(Color.Red), new Point(start.X, start.Y), new Point(start.X + 2, start.Y));
            //g.DrawRectangle(new Pen(Color.Red), e.X,e.Y,e.X ,e.Y );
            blnDraw = true;
        }

        //移动并选择计算区域
        private void originalPic_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, e.X - start.X, e.Y - start.Y);
            blnDraw = false;
        }
        private void originalPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnDraw)
            {
                //先擦除

                //g.DrawRectangle(new Pen(Color.White), start.X, start.Y, end.X - start.X, end.Y - start.Y);
                this.originalPic.Refresh();
                end.X = e.X;
                end.Y = e.Y;
                //再画
                g.DrawRectangle(new Pen(Color.Red), start.X, start.Y, end.X - start.X, end.Y - start.Y);
            }
        
            if (originalPic.Image != null)
            {
                double heigh = originalPic.Image.Height;
                double width = originalPic.Image.Width;
                double h = (double)originalPic.Height / heigh;
                double w = (double)originalPic.Width / width;
                if (h <= w)
                {
                    double wid = ((double)originalPic.Width - originalPic.Image.Width * h) / 2;
                    if ((int)wid < e.X && e.X < (int)(originalPic.Width - wid))
                    {
                        int x = (int)(e.X - wid);
                        Bitmap bm = (Bitmap)originalPic.Image;
                        //label1.Text = string.Format("当前坐标点：（{0}，{1}） 灰度值：{2}", x, e.Y, bm.GetPixel(x, e.Y));

                        int x1 = (int)(x / h);
                        int y1 = (int)(e.Y / h);
                        if (x1 <= originalPic.Image.Width && x1 >= 0)
                        {
                            if (y1 >= 0 && y1 <= originalPic.Image.Height)
                            {
                                Color color = bm.GetPixel(x1, y1);
                                int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                                picCoordinateTip.Show("（" + x + ";" + e.Y + " ）" + gray, this, new Point(e.X + 120, e.Y));
                                //picCoordinateTip.Show("("+x+";"+e.Y+")"+gray);
                                //textBox19.Text = string.Format("灰度值{0}", gray);
                            }
                        }
                    }

                }
                else
                {
                    double hei = ((double)originalPic.Height - originalPic.Image.Height * w) / 2;
                    if ((int)hei < e.Y && e.Y < (int)(originalPic.Height - hei))
                    {
                        int y = (int)(e.Y - hei);
                        Bitmap bm = (Bitmap)originalPic.Image;
                        //label1.Text = string.Format("当前坐标点：（{0}，{1}） 灰度值：{2}", e.X, y, bm.GetPixel(e.X, y));

                        int x1 = (int)(e.X / w);
                        int y1 = (int)(y / w);
                        if (x1 <= originalPic.Image.Width && x1 >= 0)
                        {
                            if (y1 >= 0 && y1 <= originalPic.Image.Height)
                            {
                                Color color = bm.GetPixel(x1, y1);
                                int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                                //textBox19.Text = string.Format("灰度值{0}", gray);
                                picCoordinateTip.Show("" + e.X + ";" + y + " (" + gray + ")", this, new Point(e.X + 120, e.Y));

                            }
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Please select picture to calculate!");
                openPictFunction();
            } 

        }
    }
}
