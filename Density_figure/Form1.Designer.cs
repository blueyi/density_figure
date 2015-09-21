namespace Density_figure
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picPanel = new System.Windows.Forms.Panel();
            this.originalPic = new System.Windows.Forms.PictureBox();
            this.iceNumLabel = new System.Windows.Forms.Label();
            this.iceDensityLabel = new System.Windows.Forms.Label();
            this.setFolderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.areaLevelNum = new System.Windows.Forms.NumericUpDown();
            this.areaSectionMax = new System.Windows.Forms.NumericUpDown();
            this.areaSectionMin = new System.Windows.Forms.NumericUpDown();
            this.grayNum = new System.Windows.Forms.NumericUpDown();
            this.areaSection = new System.Windows.Forms.Label();
            this.areaLevelLabel = new System.Windows.Forms.Label();
            this.grayLabel = new System.Windows.Forms.Label();
            this.autoNotifyLabel = new System.Windows.Forms.Label();
            this.openPicButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endPointText = new System.Windows.Forms.TextBox();
            this.startPointText = new System.Windows.Forms.TextBox();
            this.autoCalButton = new System.Windows.Forms.Button();
            this.timeToCalue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.iceNum = new System.Windows.Forms.Label();
            this.iceDensity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minIceLabel = new System.Windows.Forms.Label();
            this.maxIceLabel = new System.Windows.Forms.Label();
            this.minIce = new System.Windows.Forms.Label();
            this.maxIce = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentPIcNumLabel = new System.Windows.Forms.Label();
            this.currentAutoPathLabel = new System.Windows.Forms.Label();
            this.currentPicNameLabel = new System.Windows.Forms.Label();
            this.picCoordinateTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.otherTip = new System.Windows.Forms.ToolTip(this.components);
            this.picPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaLevelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayNum)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToCalue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPanel
            // 
            this.picPanel.AutoScroll = true;
            this.picPanel.Controls.Add(this.originalPic);
            this.picPanel.Location = new System.Drawing.Point(12, 12);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(715, 391);
            this.picPanel.TabIndex = 0;
            // 
            // originalPic
            // 
            this.originalPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.originalPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.originalPic.Location = new System.Drawing.Point(35, 7);
            this.originalPic.Name = "originalPic";
            this.originalPic.Size = new System.Drawing.Size(629, 360);
            this.originalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.originalPic.TabIndex = 0;
            this.originalPic.TabStop = false;
            this.originalPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseDown);
            this.originalPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseMove);
            this.originalPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseUp);
            // 
            // iceNumLabel
            // 
            this.iceNumLabel.AutoSize = true;
            this.iceNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iceNumLabel.Location = new System.Drawing.Point(3, 6);
            this.iceNumLabel.Name = "iceNumLabel";
            this.iceNumLabel.Size = new System.Drawing.Size(93, 16);
            this.iceNumLabel.TabIndex = 1;
            this.iceNumLabel.Text = "冰块数目：";
            // 
            // iceDensityLabel
            // 
            this.iceDensityLabel.AutoSize = true;
            this.iceDensityLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iceDensityLabel.Location = new System.Drawing.Point(153, 8);
            this.iceDensityLabel.Name = "iceDensityLabel";
            this.iceDensityLabel.Size = new System.Drawing.Size(76, 16);
            this.iceDensityLabel.TabIndex = 1;
            this.iceDensityLabel.Text = "密集度：";
            // 
            // setFolderButton
            // 
            this.setFolderButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setFolderButton.Location = new System.Drawing.Point(0, 3);
            this.setFolderButton.Name = "setFolderButton";
            this.setFolderButton.Size = new System.Drawing.Size(96, 54);
            this.setFolderButton.TabIndex = 0;
            this.setFolderButton.Text = "设置图像路径";
            this.otherTip.SetToolTip(this.setFolderButton, "点击选择用于自动计算的文件夹，文件夹内需要是jpg或者bmp图片");
            this.setFolderButton.UseVisualStyleBackColor = true;
            this.setFolderButton.Click += new System.EventHandler(this.setFileButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.areaLevelNum);
            this.panel2.Controls.Add(this.areaSectionMax);
            this.panel2.Controls.Add(this.areaSectionMin);
            this.panel2.Controls.Add(this.grayNum);
            this.panel2.Controls.Add(this.areaSection);
            this.panel2.Controls.Add(this.areaLevelLabel);
            this.panel2.Controls.Add(this.grayLabel);
            this.panel2.Controls.Add(this.autoNotifyLabel);
            this.panel2.Controls.Add(this.openPicButton);
            this.panel2.Location = new System.Drawing.Point(280, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 117);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // areaLevelNum
            // 
            this.areaLevelNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.areaLevelNum.Location = new System.Drawing.Point(343, 38);
            this.areaLevelNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.areaLevelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.areaLevelNum.Name = "areaLevelNum";
            this.areaLevelNum.Size = new System.Drawing.Size(51, 26);
            this.areaLevelNum.TabIndex = 4;
            this.areaLevelNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.areaLevelNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // areaSectionMax
            // 
            this.areaSectionMax.DecimalPlaces = 1;
            this.areaSectionMax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.areaSectionMax.Location = new System.Drawing.Point(262, 74);
            this.areaSectionMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.areaSectionMax.Name = "areaSectionMax";
            this.areaSectionMax.Size = new System.Drawing.Size(67, 26);
            this.areaSectionMax.TabIndex = 4;
            this.areaSectionMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.areaSectionMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            // 
            // areaSectionMin
            // 
            this.areaSectionMin.DecimalPlaces = 1;
            this.areaSectionMin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.areaSectionMin.Location = new System.Drawing.Point(172, 74);
            this.areaSectionMin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.areaSectionMin.Name = "areaSectionMin";
            this.areaSectionMin.Size = new System.Drawing.Size(67, 26);
            this.areaSectionMin.TabIndex = 4;
            this.areaSectionMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.areaSectionMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // grayNum
            // 
            this.grayNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grayNum.Location = new System.Drawing.Point(158, 38);
            this.grayNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.grayNum.Name = "grayNum";
            this.grayNum.Size = new System.Drawing.Size(67, 26);
            this.grayNum.TabIndex = 4;
            this.grayNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otherTip.SetToolTip(this.grayNum, "可以通过将鼠标悬停在图像上并移动，来选择合适的灰度值，\r\n图像中高于该灰度值的区域将被识别为冰块");
            this.grayNum.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // areaSection
            // 
            this.areaSection.AutoSize = true;
            this.areaSection.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.areaSection.Location = new System.Drawing.Point(97, 79);
            this.areaSection.Name = "areaSection";
            this.areaSection.Size = new System.Drawing.Size(76, 16);
            this.areaSection.TabIndex = 3;
            this.areaSection.Text = "面积区间";
            // 
            // areaLevelLabel
            // 
            this.areaLevelLabel.AutoSize = true;
            this.areaLevelLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.areaLevelLabel.Location = new System.Drawing.Point(229, 43);
            this.areaLevelLabel.Name = "areaLevelLabel";
            this.areaLevelLabel.Size = new System.Drawing.Size(110, 16);
            this.areaLevelLabel.TabIndex = 3;
            this.areaLevelLabel.Text = "冰块面积分级";
            // 
            // grayLabel
            // 
            this.grayLabel.AutoSize = true;
            this.grayLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grayLabel.Location = new System.Drawing.Point(97, 42);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(59, 16);
            this.grayLabel.TabIndex = 3;
            this.grayLabel.Text = "灰度值";
            // 
            // autoNotifyLabel
            // 
            this.autoNotifyLabel.AutoSize = true;
            this.autoNotifyLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoNotifyLabel.ForeColor = System.Drawing.Color.Red;
            this.autoNotifyLabel.Location = new System.Drawing.Point(165, 3);
            this.autoNotifyLabel.Name = "autoNotifyLabel";
            this.autoNotifyLabel.Size = new System.Drawing.Size(83, 12);
            this.autoNotifyLabel.TabIndex = 2;
            this.autoNotifyLabel.Text = "选择计算参数";
            // 
            // openPicButton
            // 
            this.openPicButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openPicButton.Location = new System.Drawing.Point(-2, -2);
            this.openPicButton.Name = "openPicButton";
            this.openPicButton.Size = new System.Drawing.Size(85, 117);
            this.openPicButton.TabIndex = 0;
            this.openPicButton.Text = "打开图像";
            this.otherTip.SetToolTip(this.openPicButton, "点击打开用于手动计算的jpg或者bmp图片");
            this.openPicButton.UseVisualStyleBackColor = true;
            this.openPicButton.Click += new System.EventHandler(this.openPicButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.startLabel);
            this.panel4.Controls.Add(this.endPointText);
            this.panel4.Controls.Add(this.startPointText);
            this.panel4.Controls.Add(this.autoCalButton);
            this.panel4.Controls.Add(this.setFolderButton);
            this.panel4.Controls.Add(this.timeToCalue);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.timeLabel);
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 117);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "终点:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(144, 44);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(35, 12);
            this.startLabel.TabIndex = 6;
            this.startLabel.Text = "起点:";
            // 
            // endPointText
            // 
            this.endPointText.Location = new System.Drawing.Point(186, 72);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(78, 21);
            this.endPointText.TabIndex = 5;
            this.otherTip.SetToolTip(this.endPointText, "设置完图片路径后使用鼠标在图中选择起点和终点");
            this.endPointText.Click += new System.EventHandler(this.endPointText_Click);
            // 
            // startPointText
            // 
            this.startPointText.Location = new System.Drawing.Point(185, 36);
            this.startPointText.Name = "startPointText";
            this.startPointText.Size = new System.Drawing.Size(78, 21);
            this.startPointText.TabIndex = 5;
            this.otherTip.SetToolTip(this.startPointText, "设置完图片路径后使用鼠标在图中选择起点和终点");
            this.startPointText.Click += new System.EventHandler(this.startPointText_Click);
            // 
            // autoCalButton
            // 
            this.autoCalButton.Enabled = false;
            this.autoCalButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoCalButton.Location = new System.Drawing.Point(0, 60);
            this.autoCalButton.Name = "autoCalButton";
            this.autoCalButton.Size = new System.Drawing.Size(96, 54);
            this.autoCalButton.TabIndex = 0;
            this.autoCalButton.Text = "自动计算";
            this.otherTip.SetToolTip(this.autoCalButton, "1. 点击自动计算前请先设置图像路径和计算区域\r\n2. 开始自动计算后可能通过点击停止来暂停自动计算并查看当前选择的自动计算区域");
            this.autoCalButton.UseVisualStyleBackColor = true;
            this.autoCalButton.Click += new System.EventHandler(this.autoCalButton_Click);
            // 
            // timeToCalue
            // 
            this.timeToCalue.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeToCalue.Location = new System.Drawing.Point(186, 3);
            this.timeToCalue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.timeToCalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeToCalue.Name = "timeToCalue";
            this.timeToCalue.Size = new System.Drawing.Size(43, 23);
            this.timeToCalue.TabIndex = 4;
            this.timeToCalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.otherTip.SetToolTip(this.timeToCalue, "设计自动计算的时间间隔");
            this.timeToCalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(235, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "秒";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(121, 10);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 12);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "时间间隔:";
            // 
            // iceNum
            // 
            this.iceNum.AutoSize = true;
            this.iceNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.iceNum.ForeColor = System.Drawing.Color.Red;
            this.iceNum.Location = new System.Drawing.Point(94, 6);
            this.iceNum.Name = "iceNum";
            this.iceNum.Size = new System.Drawing.Size(17, 16);
            this.iceNum.TabIndex = 6;
            this.iceNum.Text = "0";
            // 
            // iceDensity
            // 
            this.iceDensity.AutoSize = true;
            this.iceDensity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.iceDensity.ForeColor = System.Drawing.Color.Red;
            this.iceDensity.Location = new System.Drawing.Point(228, 8);
            this.iceDensity.Name = "iceDensity";
            this.iceDensity.Size = new System.Drawing.Size(35, 16);
            this.iceDensity.TabIndex = 6;
            this.iceDensity.Text = "0.0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.minIceLabel);
            this.panel3.Controls.Add(this.maxIceLabel);
            this.panel3.Controls.Add(this.iceDensityLabel);
            this.panel3.Controls.Add(this.minIce);
            this.panel3.Controls.Add(this.maxIce);
            this.panel3.Controls.Add(this.iceDensity);
            this.panel3.Controls.Add(this.iceNumLabel);
            this.panel3.Controls.Add(this.iceNum);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 31);
            this.panel3.TabIndex = 7;
            // 
            // minIceLabel
            // 
            this.minIceLabel.AutoSize = true;
            this.minIceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minIceLabel.Location = new System.Drawing.Point(462, 8);
            this.minIceLabel.Name = "minIceLabel";
            this.minIceLabel.Size = new System.Drawing.Size(127, 16);
            this.minIceLabel.TabIndex = 1;
            this.minIceLabel.Text = "最小冰块面积：";
            // 
            // maxIceLabel
            // 
            this.maxIceLabel.AutoSize = true;
            this.maxIceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxIceLabel.Location = new System.Drawing.Point(288, 8);
            this.maxIceLabel.Name = "maxIceLabel";
            this.maxIceLabel.Size = new System.Drawing.Size(127, 16);
            this.maxIceLabel.TabIndex = 1;
            this.maxIceLabel.Text = "最大冰块面积：";
            // 
            // minIce
            // 
            this.minIce.AutoSize = true;
            this.minIce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.minIce.ForeColor = System.Drawing.Color.Red;
            this.minIce.Location = new System.Drawing.Point(587, 8);
            this.minIce.Name = "minIce";
            this.minIce.Size = new System.Drawing.Size(35, 16);
            this.minIce.TabIndex = 6;
            this.minIce.Text = "0.0";
            // 
            // maxIce
            // 
            this.maxIce.AutoSize = true;
            this.maxIce.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.maxIce.ForeColor = System.Drawing.Color.Red;
            this.maxIce.Location = new System.Drawing.Point(414, 8);
            this.maxIce.Name = "maxIce";
            this.maxIce.Size = new System.Drawing.Size(35, 16);
            this.maxIce.TabIndex = 6;
            this.maxIce.Text = "0.0";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.currentPIcNumLabel);
            this.panel5.Controls.Add(this.currentAutoPathLabel);
            this.panel5.Controls.Add(this.currentPicNameLabel);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(12, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 200);
            this.panel5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "正在处理:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "当前自动计算的路径:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "None";
            // 
            // currentPIcNumLabel
            // 
            this.currentPIcNumLabel.AutoSize = true;
            this.currentPIcNumLabel.Location = new System.Drawing.Point(82, 162);
            this.currentPIcNumLabel.Name = "currentPIcNumLabel";
            this.currentPIcNumLabel.Size = new System.Drawing.Size(29, 12);
            this.currentPIcNumLabel.TabIndex = 7;
            this.currentPIcNumLabel.Text = "None";
            // 
            // currentAutoPathLabel
            // 
            this.currentAutoPathLabel.AutoSize = true;
            this.currentAutoPathLabel.Location = new System.Drawing.Point(134, 181);
            this.currentAutoPathLabel.Name = "currentAutoPathLabel";
            this.currentAutoPathLabel.Size = new System.Drawing.Size(29, 12);
            this.currentAutoPathLabel.TabIndex = 7;
            this.currentAutoPathLabel.Text = "None";
            // 
            // currentPicNameLabel
            // 
            this.currentPicNameLabel.AutoSize = true;
            this.currentPicNameLabel.Location = new System.Drawing.Point(154, 162);
            this.currentPicNameLabel.Name = "currentPicNameLabel";
            this.currentPicNameLabel.Size = new System.Drawing.Size(29, 12);
            this.currentPicNameLabel.TabIndex = 7;
            this.currentPicNameLabel.Text = "None";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // otherTip
            // 
            this.otherTip.AutoPopDelay = 5000;
            this.otherTip.InitialDelay = 50;
            this.otherTip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 611);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.picPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "冰密度计算";
            this.picPanel.ResumeLayout(false);
            this.picPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaLevelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayNum)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToCalue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.PictureBox originalPic;
        private System.Windows.Forms.Label iceNumLabel;
        private System.Windows.Forms.Label iceDensityLabel;
        private System.Windows.Forms.Button setFolderButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown grayNum;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.Label autoNotifyLabel;
        private System.Windows.Forms.Button openPicButton;
        private System.Windows.Forms.NumericUpDown areaLevelNum;
        private System.Windows.Forms.Label areaLevelLabel;
        private System.Windows.Forms.Label areaSection;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autoCalButton;
        private System.Windows.Forms.Label iceNum;
        private System.Windows.Forms.Label iceDensity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label minIceLabel;
        private System.Windows.Forms.Label maxIceLabel;
        private System.Windows.Forms.Label minIce;
        private System.Windows.Forms.Label maxIce;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown areaSectionMax;
        private System.Windows.Forms.NumericUpDown areaSectionMin;
        private System.Windows.Forms.ToolTip picCoordinateTip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown timeToCalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox endPointText;
        private System.Windows.Forms.TextBox startPointText;
        private System.Windows.Forms.ToolTip otherTip;
        private System.Windows.Forms.Label currentPIcNumLabel;
        private System.Windows.Forms.Label currentPicNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentAutoPathLabel;

    }
}

