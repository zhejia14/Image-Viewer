namespace _winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Image_Input = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Image_Save = new System.Windows.Forms.Button();
            this.pic1X = new System.Windows.Forms.Label();
            this.pic1Y = new System.Windows.Forms.Label();
            this.ROI_Area = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GS = new System.Windows.Forms.Label();
            this.ROI_Open = new System.Windows.Forms.Button();
            this.ROI_Close = new System.Windows.Forms.Button();
            this.ROI_Rotate = new System.Windows.Forms.Button();
            this.OpenKernelSize = new System.Windows.Forms.NumericUpDown();
            this.CloseKernelSize = new System.Windows.Forms.NumericUpDown();
            this.AngleValue = new System.Windows.Forms.NumericUpDown();
            this.GainValue = new System.Windows.Forms.NumericUpDown();
            this.Gain = new System.Windows.Forms.Label();
            this.ROI_Original = new System.Windows.Forms.Button();
            this.Thres_Hold = new System.Windows.Forms.Button();
            this.ThrseHoldValue = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenKernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseKernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrseHoldValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(11, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 428);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Image_Input
            // 
            this.Image_Input.Location = new System.Drawing.Point(11, 457);
            this.Image_Input.Name = "Image_Input";
            this.Image_Input.Size = new System.Drawing.Size(64, 35);
            this.Image_Input.TabIndex = 1;
            this.Image_Input.Text = "Image";
            this.Image_Input.UseVisualStyleBackColor = true;
            this.Image_Input.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Image_Save
            // 
            this.Image_Save.Location = new System.Drawing.Point(81, 457);
            this.Image_Save.Name = "Image_Save";
            this.Image_Save.Size = new System.Drawing.Size(64, 35);
            this.Image_Save.TabIndex = 2;
            this.Image_Save.Text = "Save";
            this.Image_Save.UseVisualStyleBackColor = true;
            this.Image_Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic1X
            // 
            this.pic1X.AutoSize = true;
            this.pic1X.Location = new System.Drawing.Point(333, 438);
            this.pic1X.Name = "pic1X";
            this.pic1X.Size = new System.Drawing.Size(17, 13);
            this.pic1X.TabIndex = 3;
            this.pic1X.Text = "X:";
            // 
            // pic1Y
            // 
            this.pic1Y.AutoSize = true;
            this.pic1Y.Location = new System.Drawing.Point(389, 438);
            this.pic1Y.Name = "pic1Y";
            this.pic1Y.Size = new System.Drawing.Size(17, 13);
            this.pic1Y.TabIndex = 4;
            this.pic1Y.Text = "Y:";
            // 
            // ROI_Area
            // 
            this.ROI_Area.Location = new System.Drawing.Point(458, 191);
            this.ROI_Area.Name = "ROI_Area";
            this.ROI_Area.Size = new System.Drawing.Size(64, 35);
            this.ROI_Area.TabIndex = 5;
            this.ROI_Area.Text = "ROIArea";
            this.ROI_Area.UseVisualStyleBackColor = true;
            this.ROI_Area.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(542, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 421);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // GS
            // 
            this.GS.AutoSize = true;
            this.GS.Location = new System.Drawing.Point(450, 438);
            this.GS.Name = "GS";
            this.GS.Size = new System.Drawing.Size(59, 13);
            this.GS.TabIndex = 7;
            this.GS.Text = "GrayScale:";
            // 
            // ROI_Open
            // 
            this.ROI_Open.Location = new System.Drawing.Point(920, 156);
            this.ROI_Open.Name = "ROI_Open";
            this.ROI_Open.Size = new System.Drawing.Size(64, 35);
            this.ROI_Open.TabIndex = 8;
            this.ROI_Open.Text = "Open";
            this.ROI_Open.UseVisualStyleBackColor = true;
            this.ROI_Open.Click += new System.EventHandler(this.ROI_Open_Click);
            // 
            // ROI_Close
            // 
            this.ROI_Close.Location = new System.Drawing.Point(920, 197);
            this.ROI_Close.Name = "ROI_Close";
            this.ROI_Close.Size = new System.Drawing.Size(64, 35);
            this.ROI_Close.TabIndex = 9;
            this.ROI_Close.Text = "Close";
            this.ROI_Close.UseVisualStyleBackColor = true;
            this.ROI_Close.Click += new System.EventHandler(this.ROI_Close_Click);
            // 
            // ROI_Rotate
            // 
            this.ROI_Rotate.Location = new System.Drawing.Point(920, 238);
            this.ROI_Rotate.Name = "ROI_Rotate";
            this.ROI_Rotate.Size = new System.Drawing.Size(64, 35);
            this.ROI_Rotate.TabIndex = 10;
            this.ROI_Rotate.Text = "Rotate";
            this.ROI_Rotate.UseVisualStyleBackColor = true;
            this.ROI_Rotate.Click += new System.EventHandler(this.ROI_Rotate_Click);
            // 
            // OpenKernelSize
            // 
            this.OpenKernelSize.Location = new System.Drawing.Point(990, 165);
            this.OpenKernelSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.OpenKernelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OpenKernelSize.Name = "OpenKernelSize";
            this.OpenKernelSize.Size = new System.Drawing.Size(36, 20);
            this.OpenKernelSize.TabIndex = 11;
            this.OpenKernelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CloseKernelSize
            // 
            this.CloseKernelSize.Location = new System.Drawing.Point(990, 206);
            this.CloseKernelSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CloseKernelSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CloseKernelSize.Name = "CloseKernelSize";
            this.CloseKernelSize.Size = new System.Drawing.Size(36, 20);
            this.CloseKernelSize.TabIndex = 12;
            this.CloseKernelSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AngleValue
            // 
            this.AngleValue.Location = new System.Drawing.Point(990, 247);
            this.AngleValue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.AngleValue.Name = "AngleValue";
            this.AngleValue.Size = new System.Drawing.Size(36, 20);
            this.AngleValue.TabIndex = 13;
            // 
            // GainValue
            // 
            this.GainValue.DecimalPlaces = 1;
            this.GainValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GainValue.Location = new System.Drawing.Point(990, 289);
            this.GainValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GainValue.Name = "GainValue";
            this.GainValue.Size = new System.Drawing.Size(36, 20);
            this.GainValue.TabIndex = 14;
            this.GainValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GainValue.ValueChanged += new System.EventHandler(this.GainValue_ValueChanged);
            // 
            // Gain
            // 
            this.Gain.AutoSize = true;
            this.Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gain.Location = new System.Drawing.Point(932, 290);
            this.Gain.Name = "Gain";
            this.Gain.Size = new System.Drawing.Size(41, 16);
            this.Gain.TabIndex = 15;
            this.Gain.Text = "Gain :";
            // 
            // ROI_Original
            // 
            this.ROI_Original.Location = new System.Drawing.Point(920, 114);
            this.ROI_Original.Name = "ROI_Original";
            this.ROI_Original.Size = new System.Drawing.Size(64, 35);
            this.ROI_Original.TabIndex = 16;
            this.ROI_Original.Text = "Original";
            this.ROI_Original.UseVisualStyleBackColor = true;
            this.ROI_Original.Click += new System.EventHandler(this.ROI_Original_Click);
            // 
            // Thres_Hold
            // 
            this.Thres_Hold.Location = new System.Drawing.Point(920, 322);
            this.Thres_Hold.Name = "Thres_Hold";
            this.Thres_Hold.Size = new System.Drawing.Size(64, 35);
            this.Thres_Hold.TabIndex = 18;
            this.Thres_Hold.Text = "ThresHold";
            this.Thres_Hold.UseVisualStyleBackColor = true;
            this.Thres_Hold.Click += new System.EventHandler(this.Thres_Hold_Click);
            // 
            // ThrseHoldValue
            // 
            this.ThrseHoldValue.Location = new System.Drawing.Point(990, 331);
            this.ThrseHoldValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThrseHoldValue.Name = "ThrseHoldValue";
            this.ThrseHoldValue.Size = new System.Drawing.Size(45, 20);
            this.ThrseHoldValue.TabIndex = 19;
            this.ThrseHoldValue.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binary",
            "BinaryINV",
            "Tozero",
            "TozeroINV"});
            this.comboBox1.Location = new System.Drawing.Point(920, 357);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 504);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ThrseHoldValue);
            this.Controls.Add(this.Thres_Hold);
            this.Controls.Add(this.ROI_Original);
            this.Controls.Add(this.Gain);
            this.Controls.Add(this.GainValue);
            this.Controls.Add(this.AngleValue);
            this.Controls.Add(this.CloseKernelSize);
            this.Controls.Add(this.OpenKernelSize);
            this.Controls.Add(this.ROI_Rotate);
            this.Controls.Add(this.ROI_Close);
            this.Controls.Add(this.ROI_Open);
            this.Controls.Add(this.GS);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ROI_Area);
            this.Controls.Add(this.pic1Y);
            this.Controls.Add(this.pic1X);
            this.Controls.Add(this.Image_Save);
            this.Controls.Add(this.Image_Input);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenKernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseKernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrseHoldValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Image_Input;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Image_Save;
        private System.Windows.Forms.Label pic1X;
        private System.Windows.Forms.Label pic1Y;
        private System.Windows.Forms.Button ROI_Area;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label GS;
        private System.Windows.Forms.Button ROI_Open;
        private System.Windows.Forms.Button ROI_Close;
        private System.Windows.Forms.Button ROI_Rotate;
        private System.Windows.Forms.NumericUpDown OpenKernelSize;
        private System.Windows.Forms.NumericUpDown CloseKernelSize;
        private System.Windows.Forms.NumericUpDown AngleValue;
        private System.Windows.Forms.NumericUpDown GainValue;
        private System.Windows.Forms.Label Gain;
        private System.Windows.Forms.Button ROI_Original;
        private System.Windows.Forms.Button Thres_Hold;
        private System.Windows.Forms.NumericUpDown ThrseHoldValue;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

