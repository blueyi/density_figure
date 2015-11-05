﻿namespace Density_figure
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picPanel = new System.Windows.Forms.Panel();
            this.originalPicBox = new System.Windows.Forms.PictureBox();
            this.iceNumLabel = new System.Windows.Forms.Label();
            this.iceDensityLabel = new System.Windows.Forms.Label();
            this.setFolderButton = new System.Windows.Forms.Button();
            this.manualButtonPanel = new System.Windows.Forms.Panel();
            this.isCalRealAreaCheckBox = new System.Windows.Forms.CheckBox();
            this.grayNum = new System.Windows.Forms.NumericUpDown();
            this.grayLabel = new System.Windows.Forms.Label();
            this.realAreaLabel = new System.Windows.Forms.Label();
            this.autoNotifyLabel = new System.Windows.Forms.Label();
            this.realAreaTextBox = new System.Windows.Forms.TextBox();
            this.squareCentLabel = new System.Windows.Forms.Label();
            this.openDatasButton = new System.Windows.Forms.Button();
            this.openTempButton = new System.Windows.Forms.Button();
            this.openPicButton = new System.Windows.Forms.Button();
            this.autoButtonPanel = new System.Windows.Forms.Panel();
            this.isRecursionCheckBox = new System.Windows.Forms.CheckBox();
            this.isCycleCalculate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endPointText = new System.Windows.Forms.TextBox();
            this.startPointText = new System.Windows.Forms.TextBox();
            this.timeToCalue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.autoCalButton = new System.Windows.Forms.Button();
            this.iceNumText = new System.Windows.Forms.Label();
            this.iceDensityText = new System.Windows.Forms.Label();
            this.minIceLabel = new System.Windows.Forms.Label();
            this.maxIceLabel = new System.Windows.Forms.Label();
            this.minIceText = new System.Windows.Forms.Label();
            this.maxIceText = new System.Windows.Forms.Label();
            this.bottomAllPanel = new System.Windows.Forms.Panel();
            this.optionButtonTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentPicNameLabel = new System.Windows.Forms.Label();
            this.currentAutoPathLabel = new System.Windows.Forms.Label();
            this.currentPIcNumLabel = new System.Windows.Forms.Label();
            this.currentDealLabel = new System.Windows.Forms.Label();
            this.currentAutoCalPathLabel = new System.Windows.Forms.Label();
            this.RBPanel = new System.Windows.Forms.Panel();
            this.isDeleteTempPic = new System.Windows.Forms.CheckBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.resultTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.picCoordinateTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.otherTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.PRICPicBox = new System.Windows.Forms.PictureBox();
            this.NMEFCPicBox = new System.Windows.Forms.PictureBox();
            this.dlutPicBox = new System.Windows.Forms.PictureBox();
            this.picPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPicBox)).BeginInit();
            this.manualButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayNum)).BeginInit();
            this.autoButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToCalue)).BeginInit();
            this.bottomAllPanel.SuspendLayout();
            this.optionButtonTablePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RBPanel.SuspendLayout();
            this.resultTablePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRICPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMEFCPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picPanel
            // 
            this.picPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPanel.AutoScroll = true;
            this.picPanel.Controls.Add(this.originalPicBox);
            this.picPanel.Location = new System.Drawing.Point(150, 3);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(629, 449);
            this.picPanel.TabIndex = 0;
            // 
            // originalPicBox
            // 
            this.originalPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.originalPicBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.originalPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPicBox.Location = new System.Drawing.Point(0, 0);
            this.originalPicBox.Name = "originalPicBox";
            this.originalPicBox.Size = new System.Drawing.Size(629, 449);
            this.originalPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPicBox.TabIndex = 0;
            this.originalPicBox.TabStop = false;
            this.originalPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseDown);
            this.originalPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseMove);
            this.originalPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originalPic_MouseUp);
            // 
            // iceNumLabel
            // 
            this.iceNumLabel.AutoSize = true;
            this.iceNumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iceNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iceNumLabel.Location = new System.Drawing.Point(3, 0);
            this.iceNumLabel.Name = "iceNumLabel";
            this.iceNumLabel.Size = new System.Drawing.Size(85, 37);
            this.iceNumLabel.TabIndex = 1;
            this.iceNumLabel.Text = "冰块数目:";
            this.iceNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iceDensityLabel
            // 
            this.iceDensityLabel.AutoSize = true;
            this.iceDensityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iceDensityLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iceDensityLabel.Location = new System.Drawing.Point(137, 0);
            this.iceDensityLabel.Name = "iceDensityLabel";
            this.iceDensityLabel.Size = new System.Drawing.Size(68, 37);
            this.iceDensityLabel.TabIndex = 1;
            this.iceDensityLabel.Text = "密集度:";
            this.iceDensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setFolderButton
            // 
            this.setFolderButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setFolderButton.Location = new System.Drawing.Point(3, 8);
            this.setFolderButton.Name = "setFolderButton";
            this.setFolderButton.Size = new System.Drawing.Size(96, 45);
            this.setFolderButton.TabIndex = 1;
            this.setFolderButton.Text = "设置图像路径";
            this.otherTip.SetToolTip(this.setFolderButton, "点击选择用于自动计算的文件夹，文件夹内需要是jpg、bmp或者png图片\r\n可以自动识别文件名称中的数字序号，并按照数字序号进行计算");
            this.setFolderButton.UseVisualStyleBackColor = true;
            this.setFolderButton.Click += new System.EventHandler(this.setFileButton_Click);
            // 
            // manualButtonPanel
            // 
            this.manualButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualButtonPanel.Controls.Add(this.isCalRealAreaCheckBox);
            this.manualButtonPanel.Controls.Add(this.grayNum);
            this.manualButtonPanel.Controls.Add(this.grayLabel);
            this.manualButtonPanel.Controls.Add(this.realAreaLabel);
            this.manualButtonPanel.Controls.Add(this.autoNotifyLabel);
            this.manualButtonPanel.Controls.Add(this.realAreaTextBox);
            this.manualButtonPanel.Controls.Add(this.squareCentLabel);
            this.manualButtonPanel.Location = new System.Drawing.Point(478, 3);
            this.manualButtonPanel.Name = "manualButtonPanel";
            this.manualButtonPanel.Size = new System.Drawing.Size(264, 112);
            this.manualButtonPanel.TabIndex = 4;
            // 
            // isCalRealAreaCheckBox
            // 
            this.isCalRealAreaCheckBox.AutoSize = true;
            this.isCalRealAreaCheckBox.Location = new System.Drawing.Point(5, 64);
            this.isCalRealAreaCheckBox.Name = "isCalRealAreaCheckBox";
            this.isCalRealAreaCheckBox.Size = new System.Drawing.Size(120, 16);
            this.isCalRealAreaCheckBox.TabIndex = 8;
            this.isCalRealAreaCheckBox.Text = "是否启用比例换算";
            this.otherTip.SetToolTip(this.isCalRealAreaCheckBox, "如果启用该选项，则必须输入所截取区域的真实面积！");
            this.isCalRealAreaCheckBox.UseVisualStyleBackColor = true;
            this.isCalRealAreaCheckBox.CheckedChanged += new System.EventHandler(this.isCalRealAreaCheckBox_CheckedChanged);
            // 
            // grayNum
            // 
            this.grayNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grayNum.Location = new System.Drawing.Point(63, 29);
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
            // grayLabel
            // 
            this.grayLabel.AutoSize = true;
            this.grayLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grayLabel.Location = new System.Drawing.Point(6, 39);
            this.grayLabel.Name = "grayLabel";
            this.grayLabel.Size = new System.Drawing.Size(47, 12);
            this.grayLabel.TabIndex = 3;
            this.grayLabel.Text = "灰度值:";
            // 
            // realAreaLabel
            // 
            this.realAreaLabel.AutoSize = true;
            this.realAreaLabel.Enabled = false;
            this.realAreaLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.realAreaLabel.Location = new System.Drawing.Point(4, 95);
            this.realAreaLabel.Name = "realAreaLabel";
            this.realAreaLabel.Size = new System.Drawing.Size(59, 12);
            this.realAreaLabel.TabIndex = 6;
            this.realAreaLabel.Text = "真实面积:";
            // 
            // autoNotifyLabel
            // 
            this.autoNotifyLabel.AutoSize = true;
            this.autoNotifyLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoNotifyLabel.ForeColor = System.Drawing.Color.Red;
            this.autoNotifyLabel.Location = new System.Drawing.Point(97, 4);
            this.autoNotifyLabel.Name = "autoNotifyLabel";
            this.autoNotifyLabel.Size = new System.Drawing.Size(83, 12);
            this.autoNotifyLabel.TabIndex = 2;
            this.autoNotifyLabel.Text = "选择计算参数";
            // 
            // realAreaTextBox
            // 
            this.realAreaTextBox.Enabled = false;
            this.realAreaTextBox.Location = new System.Drawing.Point(66, 87);
            this.realAreaTextBox.Name = "realAreaTextBox";
            this.realAreaTextBox.Size = new System.Drawing.Size(99, 21);
            this.realAreaTextBox.TabIndex = 5;
            this.realAreaTextBox.Text = "0.0";
            // 
            // squareCentLabel
            // 
            this.squareCentLabel.AutoSize = true;
            this.squareCentLabel.Enabled = false;
            this.squareCentLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.squareCentLabel.Location = new System.Drawing.Point(166, 92);
            this.squareCentLabel.Name = "squareCentLabel";
            this.squareCentLabel.Size = new System.Drawing.Size(53, 12);
            this.squareCentLabel.TabIndex = 3;
            this.squareCentLabel.Text = "平方厘米";
            // 
            // openDatasButton
            // 
            this.openDatasButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openDatasButton.Location = new System.Drawing.Point(3, 80);
            this.openDatasButton.Name = "openDatasButton";
            this.openDatasButton.Size = new System.Drawing.Size(85, 32);
            this.openDatasButton.TabIndex = 3;
            this.openDatasButton.Text = "数据文件夹";
            this.otherTip.SetToolTip(this.openDatasButton, "打开存放有历史计算数据的文件夹，手动计算历史数据存放在manual.csv中\r\n自动计算的历史数据存放在以计算日期为文件名的csv文件中，该csv文件可以\r\n直接" +
        "使用excel打开并进行数据分析");
            this.openDatasButton.UseVisualStyleBackColor = true;
            this.openDatasButton.Click += new System.EventHandler(this.openDatasButton_Click);
            // 
            // openTempButton
            // 
            this.openTempButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openTempButton.Location = new System.Drawing.Point(3, 40);
            this.openTempButton.Name = "openTempButton";
            this.openTempButton.Size = new System.Drawing.Size(85, 33);
            this.openTempButton.TabIndex = 2;
            this.openTempButton.Text = "临时文件夹";
            this.otherTip.SetToolTip(this.openTempButton, "打开用于存放中间图片的文件夹");
            this.openTempButton.UseVisualStyleBackColor = true;
            this.openTempButton.Click += new System.EventHandler(this.openTempButton_Click);
            // 
            // openPicButton
            // 
            this.openPicButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openPicButton.Location = new System.Drawing.Point(3, 1);
            this.openPicButton.Name = "openPicButton";
            this.openPicButton.Size = new System.Drawing.Size(85, 34);
            this.openPicButton.TabIndex = 0;
            this.openPicButton.Text = "打开图像";
            this.otherTip.SetToolTip(this.openPicButton, "点击打开用于手动计算的jpg或者bmp图片");
            this.openPicButton.UseVisualStyleBackColor = true;
            this.openPicButton.Click += new System.EventHandler(this.openPicButton_Click);
            // 
            // autoButtonPanel
            // 
            this.autoButtonPanel.Controls.Add(this.isRecursionCheckBox);
            this.autoButtonPanel.Controls.Add(this.isCycleCalculate);
            this.autoButtonPanel.Controls.Add(this.label4);
            this.autoButtonPanel.Controls.Add(this.startLabel);
            this.autoButtonPanel.Controls.Add(this.endPointText);
            this.autoButtonPanel.Controls.Add(this.startPointText);
            this.autoButtonPanel.Controls.Add(this.timeToCalue);
            this.autoButtonPanel.Controls.Add(this.label3);
            this.autoButtonPanel.Controls.Add(this.timeLabel);
            this.autoButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoButtonPanel.Location = new System.Drawing.Point(202, 3);
            this.autoButtonPanel.Name = "autoButtonPanel";
            this.autoButtonPanel.Size = new System.Drawing.Size(173, 112);
            this.autoButtonPanel.TabIndex = 5;
            // 
            // isRecursionCheckBox
            // 
            this.isRecursionCheckBox.AutoSize = true;
            this.isRecursionCheckBox.Location = new System.Drawing.Point(8, 74);
            this.isRecursionCheckBox.Name = "isRecursionCheckBox";
            this.isRecursionCheckBox.Size = new System.Drawing.Size(120, 16);
            this.isRecursionCheckBox.TabIndex = 8;
            this.isRecursionCheckBox.Text = "是否包括子文件夹";
            this.isRecursionCheckBox.UseVisualStyleBackColor = true;
            // 
            // isCycleCalculate
            // 
            this.isCycleCalculate.AutoSize = true;
            this.isCycleCalculate.Enabled = false;
            this.isCycleCalculate.Location = new System.Drawing.Point(8, 93);
            this.isCycleCalculate.Name = "isCycleCalculate";
            this.isCycleCalculate.Size = new System.Drawing.Size(144, 16);
            this.isCycleCalculate.TabIndex = 8;
            this.isCycleCalculate.Text = "是否循环计算该文件夹";
            this.isCycleCalculate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "终点坐标:";
            this.otherTip.SetToolTip(this.label4, "设置完图片路径后，使用鼠标在图中选择起点和终点");
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(5, 34);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(59, 12);
            this.startLabel.TabIndex = 6;
            this.startLabel.Text = "起点坐标:";
            this.otherTip.SetToolTip(this.startLabel, "设置完图片路径后，使用鼠标在图中选择起点和终点");
            // 
            // endPointText
            // 
            this.endPointText.Enabled = false;
            this.endPointText.Location = new System.Drawing.Point(67, 51);
            this.endPointText.Name = "endPointText";
            this.endPointText.Size = new System.Drawing.Size(78, 21);
            this.endPointText.TabIndex = 5;
            this.otherTip.SetToolTip(this.endPointText, "设置完图片路径后，使用鼠标在图中选择起点和终点");
            this.endPointText.Click += new System.EventHandler(this.endPointText_Click);
            // 
            // startPointText
            // 
            this.startPointText.Enabled = false;
            this.startPointText.Location = new System.Drawing.Point(67, 26);
            this.startPointText.Name = "startPointText";
            this.startPointText.Size = new System.Drawing.Size(78, 21);
            this.startPointText.TabIndex = 5;
            this.otherTip.SetToolTip(this.startPointText, "设置完图片路径后使用鼠标在图中选择起点和终点");
            this.startPointText.Click += new System.EventHandler(this.startPointText_Click);
            // 
            // timeToCalue
            // 
            this.timeToCalue.Enabled = false;
            this.timeToCalue.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeToCalue.Location = new System.Drawing.Point(68, 0);
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
            this.otherTip.SetToolTip(this.timeToCalue, "设置完图像路径后，设置自动计算的时间间隔\r\n");
            this.timeToCalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(117, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "秒";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(7, 7);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(59, 12);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "时间间隔:";
            this.otherTip.SetToolTip(this.timeLabel, "设置完图像路径后，设置自动计算的时间间隔");
            // 
            // autoCalButton
            // 
            this.autoCalButton.Enabled = false;
            this.autoCalButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoCalButton.Location = new System.Drawing.Point(2, 63);
            this.autoCalButton.Name = "autoCalButton";
            this.autoCalButton.Size = new System.Drawing.Size(96, 43);
            this.autoCalButton.TabIndex = 4;
            this.autoCalButton.Text = "自动计算";
            this.otherTip.SetToolTip(this.autoCalButton, "1. 点击自动计算前请先设置图像路径和计算区域\r\n2. 开始自动计算后可能通过点击停止来暂停自动计算并查看当前选择的自动计算区域");
            this.autoCalButton.UseVisualStyleBackColor = true;
            this.autoCalButton.Click += new System.EventHandler(this.autoCalButton_Click);
            // 
            // iceNumText
            // 
            this.iceNumText.AutoSize = true;
            this.iceNumText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iceNumText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.iceNumText.ForeColor = System.Drawing.Color.Red;
            this.iceNumText.Location = new System.Drawing.Point(94, 0);
            this.iceNumText.Name = "iceNumText";
            this.iceNumText.Size = new System.Drawing.Size(17, 37);
            this.iceNumText.TabIndex = 6;
            this.iceNumText.Text = "0";
            this.iceNumText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iceDensityText
            // 
            this.iceDensityText.AutoSize = true;
            this.iceDensityText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iceDensityText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.iceDensityText.ForeColor = System.Drawing.Color.Red;
            this.iceDensityText.Location = new System.Drawing.Point(211, 0);
            this.iceDensityText.Name = "iceDensityText";
            this.iceDensityText.Size = new System.Drawing.Size(35, 37);
            this.iceDensityText.TabIndex = 6;
            this.iceDensityText.Text = "0.0";
            this.iceDensityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minIceLabel
            // 
            this.minIceLabel.AutoSize = true;
            this.minIceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minIceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minIceLabel.Location = new System.Drawing.Point(458, 0);
            this.minIceLabel.Name = "minIceLabel";
            this.minIceLabel.Size = new System.Drawing.Size(119, 37);
            this.minIceLabel.TabIndex = 1;
            this.minIceLabel.Text = "最小冰块面积:";
            this.minIceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxIceLabel
            // 
            this.maxIceLabel.AutoSize = true;
            this.maxIceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxIceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxIceLabel.Location = new System.Drawing.Point(272, 0);
            this.maxIceLabel.Name = "maxIceLabel";
            this.maxIceLabel.Size = new System.Drawing.Size(119, 37);
            this.maxIceLabel.TabIndex = 1;
            this.maxIceLabel.Text = "最大冰块面积:";
            this.maxIceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minIceText
            // 
            this.minIceText.AutoSize = true;
            this.minIceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minIceText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.minIceText.ForeColor = System.Drawing.Color.Red;
            this.minIceText.Location = new System.Drawing.Point(583, 0);
            this.minIceText.Name = "minIceText";
            this.minIceText.Size = new System.Drawing.Size(183, 37);
            this.minIceText.TabIndex = 6;
            this.minIceText.Text = "0.0";
            this.minIceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxIceText
            // 
            this.maxIceText.AutoSize = true;
            this.maxIceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxIceText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.maxIceText.ForeColor = System.Drawing.Color.Red;
            this.maxIceText.Location = new System.Drawing.Point(397, 0);
            this.maxIceText.Name = "maxIceText";
            this.maxIceText.Size = new System.Drawing.Size(35, 37);
            this.maxIceText.TabIndex = 6;
            this.maxIceText.Text = "0.0";
            this.maxIceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomAllPanel
            // 
            this.bottomAllPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomAllPanel.Controls.Add(this.optionButtonTablePanel);
            this.bottomAllPanel.Controls.Add(this.panel1);
            this.bottomAllPanel.Controls.Add(this.RBPanel);
            this.bottomAllPanel.Controls.Add(this.resultTablePanel);
            this.bottomAllPanel.Location = new System.Drawing.Point(2, 458);
            this.bottomAllPanel.Name = "bottomAllPanel";
            this.bottomAllPanel.Size = new System.Drawing.Size(778, 199);
            this.bottomAllPanel.TabIndex = 9;
            // 
            // optionButtonTablePanel
            // 
            this.optionButtonTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionButtonTablePanel.ColumnCount = 6;
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.optionButtonTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.optionButtonTablePanel.Controls.Add(this.panel2, 1, 0);
            this.optionButtonTablePanel.Controls.Add(this.panel3, 3, 0);
            this.optionButtonTablePanel.Controls.Add(this.autoButtonPanel, 2, 0);
            this.optionButtonTablePanel.Controls.Add(this.manualButtonPanel, 4, 0);
            this.optionButtonTablePanel.Location = new System.Drawing.Point(3, 43);
            this.optionButtonTablePanel.Name = "optionButtonTablePanel";
            this.optionButtonTablePanel.RowCount = 1;
            this.optionButtonTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionButtonTablePanel.Size = new System.Drawing.Size(768, 118);
            this.optionButtonTablePanel.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.setFolderButton);
            this.panel2.Controls.Add(this.autoCalButton);
            this.panel2.Location = new System.Drawing.Point(95, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 112);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.openTempButton);
            this.panel3.Controls.Add(this.openPicButton);
            this.panel3.Controls.Add(this.openDatasButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(381, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 112);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentPicNameLabel);
            this.panel1.Controls.Add(this.currentAutoPathLabel);
            this.panel1.Controls.Add(this.currentPIcNumLabel);
            this.panel1.Controls.Add(this.currentDealLabel);
            this.panel1.Controls.Add(this.currentAutoCalPathLabel);
            this.panel1.Location = new System.Drawing.Point(3, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 36);
            this.panel1.TabIndex = 1;
            // 
            // currentPicNameLabel
            // 
            this.currentPicNameLabel.AutoSize = true;
            this.currentPicNameLabel.Location = new System.Drawing.Point(150, 4);
            this.currentPicNameLabel.Name = "currentPicNameLabel";
            this.currentPicNameLabel.Size = new System.Drawing.Size(29, 12);
            this.currentPicNameLabel.TabIndex = 7;
            this.currentPicNameLabel.Text = "None";
            // 
            // currentAutoPathLabel
            // 
            this.currentAutoPathLabel.AutoSize = true;
            this.currentAutoPathLabel.Location = new System.Drawing.Point(130, 21);
            this.currentAutoPathLabel.Name = "currentAutoPathLabel";
            this.currentAutoPathLabel.Size = new System.Drawing.Size(29, 12);
            this.currentAutoPathLabel.TabIndex = 7;
            this.currentAutoPathLabel.Text = "None";
            // 
            // currentPIcNumLabel
            // 
            this.currentPIcNumLabel.AutoSize = true;
            this.currentPIcNumLabel.Location = new System.Drawing.Point(78, 4);
            this.currentPIcNumLabel.Name = "currentPIcNumLabel";
            this.currentPIcNumLabel.Size = new System.Drawing.Size(29, 12);
            this.currentPIcNumLabel.TabIndex = 7;
            this.currentPIcNumLabel.Text = "None";
            // 
            // currentDealLabel
            // 
            this.currentDealLabel.AutoSize = true;
            this.currentDealLabel.Location = new System.Drawing.Point(5, 4);
            this.currentDealLabel.Name = "currentDealLabel";
            this.currentDealLabel.Size = new System.Drawing.Size(59, 12);
            this.currentDealLabel.TabIndex = 7;
            this.currentDealLabel.Text = "正在处理:";
            // 
            // currentAutoCalPathLabel
            // 
            this.currentAutoCalPathLabel.AutoSize = true;
            this.currentAutoCalPathLabel.Location = new System.Drawing.Point(5, 21);
            this.currentAutoCalPathLabel.Name = "currentAutoCalPathLabel";
            this.currentAutoCalPathLabel.Size = new System.Drawing.Size(119, 12);
            this.currentAutoCalPathLabel.TabIndex = 7;
            this.currentAutoCalPathLabel.Text = "当前自动计算的路径:";
            // 
            // RBPanel
            // 
            this.RBPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBPanel.Controls.Add(this.isDeleteTempPic);
            this.RBPanel.Controls.Add(this.versionLabel);
            this.RBPanel.Location = new System.Drawing.Point(618, 161);
            this.RBPanel.Name = "RBPanel";
            this.RBPanel.Size = new System.Drawing.Size(155, 37);
            this.RBPanel.TabIndex = 1;
            // 
            // isDeleteTempPic
            // 
            this.isDeleteTempPic.AutoSize = true;
            this.isDeleteTempPic.Location = new System.Drawing.Point(7, 3);
            this.isDeleteTempPic.Name = "isDeleteTempPic";
            this.isDeleteTempPic.Size = new System.Drawing.Size(120, 16);
            this.isDeleteTempPic.TabIndex = 8;
            this.isDeleteTempPic.Text = "是否保留临时文件";
            this.otherTip.SetToolTip(this.isDeleteTempPic, "勾选该选项后可以在程序所在文件夹下Temp文件夹中查看当前所处理图像的中间图像\r\n勾选该选项后会额外占用较多磁盘空间，需要用户手动删除");
            this.isDeleteTempPic.UseVisualStyleBackColor = true;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(5, 19);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(125, 12);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "当前程序版本: V1.2.0";
            // 
            // resultTablePanel
            // 
            this.resultTablePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultTablePanel.AutoSize = true;
            this.resultTablePanel.ColumnCount = 11;
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultTablePanel.Controls.Add(this.iceNumLabel, 0, 0);
            this.resultTablePanel.Controls.Add(this.iceDensityLabel, 3, 0);
            this.resultTablePanel.Controls.Add(this.iceNumText, 1, 0);
            this.resultTablePanel.Controls.Add(this.maxIceLabel, 6, 0);
            this.resultTablePanel.Controls.Add(this.iceDensityText, 4, 0);
            this.resultTablePanel.Controls.Add(this.maxIceText, 7, 0);
            this.resultTablePanel.Controls.Add(this.minIceText, 10, 0);
            this.resultTablePanel.Controls.Add(this.minIceLabel, 9, 0);
            this.resultTablePanel.Location = new System.Drawing.Point(2, 4);
            this.resultTablePanel.Name = "resultTablePanel";
            this.resultTablePanel.RowCount = 1;
            this.resultTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resultTablePanel.Size = new System.Drawing.Size(769, 37);
            this.resultTablePanel.TabIndex = 9;
            // 
            // picCoordinateTip
            // 
            this.picCoordinateTip.AutoPopDelay = 5000;
            this.picCoordinateTip.InitialDelay = 50;
            this.picCoordinateTip.ReshowDelay = 100;
            this.picCoordinateTip.UseAnimation = false;
            this.picCoordinateTip.UseFading = false;
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
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.logoPanel);
            this.mainPanel.Controls.Add(this.picPanel);
            this.mainPanel.Controls.Add(this.bottomAllPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 662);
            this.mainPanel.TabIndex = 10;
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logoPanel.Controls.Add(this.PRICPicBox);
            this.logoPanel.Controls.Add(this.NMEFCPicBox);
            this.logoPanel.Controls.Add(this.dlutPicBox);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(150, 453);
            this.logoPanel.TabIndex = 10;
            // 
            // PRICPicBox
            // 
            this.PRICPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PRICPicBox.Image = global::Density_figure.Properties.Resources.PRIC_logo;
            this.PRICPicBox.Location = new System.Drawing.Point(2, 301);
            this.PRICPicBox.Name = "PRICPicBox";
            this.PRICPicBox.Size = new System.Drawing.Size(145, 145);
            this.PRICPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PRICPicBox.TabIndex = 0;
            this.PRICPicBox.TabStop = false;
            // 
            // NMEFCPicBox
            // 
            this.NMEFCPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEFCPicBox.Image = global::Density_figure.Properties.Resources.NFMC_logo;
            this.NMEFCPicBox.Location = new System.Drawing.Point(0, 151);
            this.NMEFCPicBox.Name = "NMEFCPicBox";
            this.NMEFCPicBox.Size = new System.Drawing.Size(145, 145);
            this.NMEFCPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NMEFCPicBox.TabIndex = 0;
            this.NMEFCPicBox.TabStop = false;
            // 
            // dlutPicBox
            // 
            this.dlutPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dlutPicBox.Image = global::Density_figure.Properties.Resources.dlut_logo;
            this.dlutPicBox.Location = new System.Drawing.Point(0, 0);
            this.dlutPicBox.Name = "dlutPicBox";
            this.dlutPicBox.Size = new System.Drawing.Size(145, 145);
            this.dlutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dlutPicBox.TabIndex = 0;
            this.dlutPicBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "冰密集度计算";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.picPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalPicBox)).EndInit();
            this.manualButtonPanel.ResumeLayout(false);
            this.manualButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayNum)).EndInit();
            this.autoButtonPanel.ResumeLayout(false);
            this.autoButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToCalue)).EndInit();
            this.bottomAllPanel.ResumeLayout(false);
            this.bottomAllPanel.PerformLayout();
            this.optionButtonTablePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RBPanel.ResumeLayout(false);
            this.RBPanel.PerformLayout();
            this.resultTablePanel.ResumeLayout(false);
            this.resultTablePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PRICPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMEFCPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlutPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.PictureBox originalPicBox;
        private System.Windows.Forms.Label iceNumLabel;
        private System.Windows.Forms.Label iceDensityLabel;
        private System.Windows.Forms.Button setFolderButton;
        private System.Windows.Forms.Panel manualButtonPanel;
        private System.Windows.Forms.NumericUpDown grayNum;
        private System.Windows.Forms.Label grayLabel;
        private System.Windows.Forms.Label autoNotifyLabel;
        private System.Windows.Forms.Button openPicButton;
        private System.Windows.Forms.Panel autoButtonPanel;
        private System.Windows.Forms.Button autoCalButton;
        private System.Windows.Forms.Label iceNumText;
        private System.Windows.Forms.Label iceDensityText;
        private System.Windows.Forms.Label minIceLabel;
        private System.Windows.Forms.Label maxIceLabel;
        private System.Windows.Forms.Label minIceText;
        private System.Windows.Forms.Label maxIceText;
        private System.Windows.Forms.Panel bottomAllPanel;
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
        private System.Windows.Forms.Label currentDealLabel;
        private System.Windows.Forms.Label currentAutoCalPathLabel;
        private System.Windows.Forms.Label currentAutoPathLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox isDeleteTempPic;
        private System.Windows.Forms.Button openDatasButton;
        private System.Windows.Forms.Button openTempButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox isCycleCalculate;
        private System.Windows.Forms.CheckBox isRecursionCheckBox;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox PRICPicBox;
        private System.Windows.Forms.PictureBox NMEFCPicBox;
        private System.Windows.Forms.PictureBox dlutPicBox;
        private System.Windows.Forms.CheckBox isCalRealAreaCheckBox;
        private System.Windows.Forms.Label realAreaLabel;
        private System.Windows.Forms.TextBox realAreaTextBox;
        private System.Windows.Forms.Label squareCentLabel;
        private System.Windows.Forms.TableLayoutPanel resultTablePanel;
        private System.Windows.Forms.Panel RBPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel optionButtonTablePanel;
        private System.Windows.Forms.Panel panel3;

    }
}

