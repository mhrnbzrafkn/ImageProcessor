namespace CNNTest
{
    partial class Form2
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
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.Conv_01 = new System.Windows.Forms.PictureBox();
            this.Conv_00 = new System.Windows.Forms.PictureBox();
            this.PollingKernelSize = new System.Windows.Forms.NumericUpDown();
            this.Matrix0_02 = new System.Windows.Forms.TextBox();
            this.Matrix0_01 = new System.Windows.Forms.TextBox();
            this.Matrix0_00 = new System.Windows.Forms.TextBox();
            this.Matrix0_22 = new System.Windows.Forms.TextBox();
            this.Matrix0_21 = new System.Windows.Forms.TextBox();
            this.Matrix0_20 = new System.Windows.Forms.TextBox();
            this.Matrix0_12 = new System.Windows.Forms.TextBox();
            this.Matrix0_11 = new System.Windows.Forms.TextBox();
            this.Matrix0_10 = new System.Windows.Forms.TextBox();
            this.ConvKernelSize = new System.Windows.Forms.NumericUpDown();
            this.Convert_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Height = new System.Windows.Forms.TextBox();
            this.Input_Width = new System.Windows.Forms.TextBox();
            this.ImageProcess_PB = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conv_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conv_00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PollingKernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvKernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPicture
            // 
            this.InputPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPicture.Location = new System.Drawing.Point(24, 172);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(306, 306);
            this.InputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputPicture.TabIndex = 0;
            this.InputPicture.TabStop = false;
            this.InputPicture.Tag = "";
            this.InputPicture.DoubleClick += new System.EventHandler(this.InputPicture_DoubleClick);
            // 
            // Conv_01
            // 
            this.Conv_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conv_01.Location = new System.Drawing.Point(495, 328);
            this.Conv_01.Name = "Conv_01";
            this.Conv_01.Size = new System.Drawing.Size(150, 150);
            this.Conv_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Conv_01.TabIndex = 2;
            this.Conv_01.TabStop = false;
            this.Conv_01.Click += new System.EventHandler(this.Conv_01_Click);
            // 
            // Conv_00
            // 
            this.Conv_00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Conv_00.Location = new System.Drawing.Point(495, 172);
            this.Conv_00.Name = "Conv_00";
            this.Conv_00.Size = new System.Drawing.Size(150, 150);
            this.Conv_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Conv_00.TabIndex = 4;
            this.Conv_00.TabStop = false;
            this.Conv_00.Click += new System.EventHandler(this.Conv_00_Click);
            // 
            // PollingKernelSize
            // 
            this.PollingKernelSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PollingKernelSize.Location = new System.Drawing.Point(198, 534);
            this.PollingKernelSize.Name = "PollingKernelSize";
            this.PollingKernelSize.Size = new System.Drawing.Size(82, 23);
            this.PollingKernelSize.TabIndex = 33;
            this.PollingKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PollingKernelSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PollingKernelSize.ValueChanged += new System.EventHandler(this.PollingKernelSize_ValueChanged);
            // 
            // Matrix0_02
            // 
            this.Matrix0_02.Location = new System.Drawing.Point(449, 284);
            this.Matrix0_02.Name = "Matrix0_02";
            this.Matrix0_02.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_02.TabIndex = 32;
            this.Matrix0_02.Text = "2";
            this.Matrix0_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_01
            // 
            this.Matrix0_01.Location = new System.Drawing.Point(418, 284);
            this.Matrix0_01.Name = "Matrix0_01";
            this.Matrix0_01.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_01.TabIndex = 31;
            this.Matrix0_01.Text = "-2";
            this.Matrix0_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_00
            // 
            this.Matrix0_00.Location = new System.Drawing.Point(387, 284);
            this.Matrix0_00.Name = "Matrix0_00";
            this.Matrix0_00.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_00.TabIndex = 30;
            this.Matrix0_00.Text = "-2";
            this.Matrix0_00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_22
            // 
            this.Matrix0_22.Location = new System.Drawing.Point(449, 342);
            this.Matrix0_22.Name = "Matrix0_22";
            this.Matrix0_22.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_22.TabIndex = 29;
            this.Matrix0_22.Text = "2";
            this.Matrix0_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_21
            // 
            this.Matrix0_21.Location = new System.Drawing.Point(418, 342);
            this.Matrix0_21.Name = "Matrix0_21";
            this.Matrix0_21.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_21.TabIndex = 28;
            this.Matrix0_21.Text = "2";
            this.Matrix0_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_20
            // 
            this.Matrix0_20.Location = new System.Drawing.Point(387, 342);
            this.Matrix0_20.Name = "Matrix0_20";
            this.Matrix0_20.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_20.TabIndex = 27;
            this.Matrix0_20.Text = "-2";
            this.Matrix0_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_12
            // 
            this.Matrix0_12.Location = new System.Drawing.Point(449, 313);
            this.Matrix0_12.Name = "Matrix0_12";
            this.Matrix0_12.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_12.TabIndex = 26;
            this.Matrix0_12.Text = "2";
            this.Matrix0_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_11
            // 
            this.Matrix0_11.Location = new System.Drawing.Point(418, 313);
            this.Matrix0_11.Name = "Matrix0_11";
            this.Matrix0_11.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_11.TabIndex = 25;
            this.Matrix0_11.Text = "0.2";
            this.Matrix0_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix0_10
            // 
            this.Matrix0_10.Location = new System.Drawing.Point(387, 313);
            this.Matrix0_10.Name = "Matrix0_10";
            this.Matrix0_10.Size = new System.Drawing.Size(25, 23);
            this.Matrix0_10.TabIndex = 24;
            this.Matrix0_10.Text = "-2";
            this.Matrix0_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvKernelSize
            // 
            this.ConvKernelSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ConvKernelSize.Location = new System.Drawing.Point(198, 505);
            this.ConvKernelSize.Name = "ConvKernelSize";
            this.ConvKernelSize.Size = new System.Drawing.Size(82, 23);
            this.ConvKernelSize.TabIndex = 23;
            this.ConvKernelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConvKernelSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ConvKernelSize.ValueChanged += new System.EventHandler(this.ConvKernelSize_ValueChanged);
            // 
            // Convert_Btn
            // 
            this.Convert_Btn.Location = new System.Drawing.Point(129, 575);
            this.Convert_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Convert_Btn.Name = "Convert_Btn";
            this.Convert_Btn.Size = new System.Drawing.Size(82, 22);
            this.Convert_Btn.TabIndex = 22;
            this.Convert_Btn.Text = "Convert";
            this.Convert_Btn.UseVisualStyleBackColor = true;
            this.Convert_Btn.Click += new System.EventHandler(this.Convert_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Convolution Kernel Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Max Polling Kernel Size";
            // 
            // SelectedImage
            // 
            this.SelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedImage.Location = new System.Drawing.Point(709, 76);
            this.SelectedImage.Name = "SelectedImage";
            this.SelectedImage.Size = new System.Drawing.Size(512, 512);
            this.SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedImage.TabIndex = 63;
            this.SelectedImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 67;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Resolotion:";
            // 
            // Input_Height
            // 
            this.Input_Height.Location = new System.Drawing.Point(215, 143);
            this.Input_Height.Name = "Input_Height";
            this.Input_Height.Size = new System.Drawing.Size(75, 23);
            this.Input_Height.TabIndex = 65;
            this.Input_Height.Text = "720";
            this.Input_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Input_Width
            // 
            this.Input_Width.Location = new System.Drawing.Point(114, 143);
            this.Input_Width.Name = "Input_Width";
            this.Input_Width.Size = new System.Drawing.Size(75, 23);
            this.Input_Width.TabIndex = 64;
            this.Input_Width.Text = "720";
            this.Input_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageProcess_PB
            // 
            this.ImageProcess_PB.Location = new System.Drawing.Point(709, 594);
            this.ImageProcess_PB.Name = "ImageProcess_PB";
            this.ImageProcess_PB.Size = new System.Drawing.Size(512, 23);
            this.ImageProcess_PB.TabIndex = 68;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ImageProcess_PB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Input_Height);
            this.Controls.Add(this.Input_Width);
            this.Controls.Add(this.SelectedImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PollingKernelSize);
            this.Controls.Add(this.Matrix0_02);
            this.Controls.Add(this.Matrix0_01);
            this.Controls.Add(this.Matrix0_00);
            this.Controls.Add(this.Matrix0_22);
            this.Controls.Add(this.Matrix0_21);
            this.Controls.Add(this.Matrix0_20);
            this.Controls.Add(this.Matrix0_12);
            this.Controls.Add(this.Matrix0_11);
            this.Controls.Add(this.Matrix0_10);
            this.Controls.Add(this.ConvKernelSize);
            this.Controls.Add(this.Convert_Btn);
            this.Controls.Add(this.Conv_00);
            this.Controls.Add(this.Conv_01);
            this.Controls.Add(this.InputPicture);
            this.Name = "Form2";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conv_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conv_00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PollingKernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvKernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox InputPicture;
        private PictureBox Conv_01;
        private PictureBox Conv_00;
        private NumericUpDown PollingKernelSize;
        private TextBox Matrix0_02;
        private TextBox Matrix0_01;
        private TextBox Matrix0_00;
        private TextBox Matrix0_22;
        private TextBox Matrix0_21;
        private TextBox Matrix0_20;
        private TextBox Matrix0_12;
        private TextBox Matrix0_11;
        private TextBox Matrix0_10;
        private NumericUpDown ConvKernelSize;
        private Button Convert_Btn;
        private Label label1;
        private Label label2;
        private PictureBox SelectedImage;
        private Label label3;
        private Label label4;
        private TextBox Input_Height;
        private TextBox Input_Width;
        private ProgressBar ImageProcess_PB;
    }
}