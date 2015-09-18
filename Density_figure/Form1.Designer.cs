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
            this.picPanel = new System.Windows.Forms.Panel();
            this.originalPic = new System.Windows.Forms.PictureBox();
            this.iceNumLabel = new System.Windows.Forms.Label();
            this.iceDensityLabel = new System.Windows.Forms.Label();
            this.setFileButton = new System.Windows.Forms.Button();
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
            this.autoCalButton = new System.Windows.Forms.Button();
            this.iceNum = new System.Windows.Forms.Label();
            this.iceDensity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minIceLabel = new System.Windows.Forms.Label();
            this.maxIceLabel = new System.Windows.Forms.Label();
            this.minIce = new System.Windows.Forms.Label();
            this.maxIce = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picCoordinateTip = new System.Windows.Forms.ToolTip(this.components);
            this.picPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaLevelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaSectionMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayNum)).BeginInit();
            this.panel4.SuspendLayout();
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
            // setFileButton
            // 
            this.setFileButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setFileButton.Location = new System.Drawing.Point(0, 3);
            this.setFileButton.Name = "setFileButton";
            this.setFileButton.Size = new System.Drawing.Size(96, 54);
            this.setFileButton.TabIndex = 0;
            this.setFileButton.Text = "设置图像路径";
            this.setFileButton.UseVisualStyleBackColor = true;
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
            this.panel2.Location = new System.Drawing.Point(219, 42);
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
            this.openPicButton.UseVisualStyleBackColor = true;
            this.openPicButton.Click += new System.EventHandler(this.openPicButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.autoCalButton);
            this.panel4.Controls.Add(this.setFileButton);
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 117);
            this.panel4.TabIndex = 5;
            // 
            // autoCalButton
            // 
            this.autoCalButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoCalButton.Location = new System.Drawing.Point(0, 60);
            this.autoCalButton.Name = "autoCalButton";
            this.autoCalButton.Size = new System.Drawing.Size(96, 54);
            this.autoCalButton.TabIndex = 0;
            this.autoCalButton.Text = "自动计算";
            this.autoCalButton.UseVisualStyleBackColor = true;
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
            this.panel3.Size = new System.Drawing.Size(641, 31);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "提示：选择计算参数后，设置图像路径，点击自动计算,则对应文件夹下的图像会自动被计算。打开图像则选择\r\n单张图片进行计算。鼠标置于图片上时显示的参数为(坐标), 灰" +
    "度值，以便参考设置需要的灰度值";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(47, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(651, 171);
            this.panel5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 622);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPanel);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.PictureBox originalPic;
        private System.Windows.Forms.Label iceNumLabel;
        private System.Windows.Forms.Label iceDensityLabel;
        private System.Windows.Forms.Button setFileButton;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minIceLabel;
        private System.Windows.Forms.Label maxIceLabel;
        private System.Windows.Forms.Label minIce;
        private System.Windows.Forms.Label maxIce;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown areaSectionMax;
        private System.Windows.Forms.NumericUpDown areaSectionMin;
        private System.Windows.Forms.ToolTip picCoordinateTip;

    }
}

