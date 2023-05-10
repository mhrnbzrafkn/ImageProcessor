namespace CNNTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_box_1 = new System.Windows.Forms.PictureBox();
            this.pic_box_2 = new System.Windows.Forms.PictureBox();
            this.Convert_Btn = new System.Windows.Forms.Button();
            this.File_Btn = new System.Windows.Forms.Button();
            this.Path_TXT = new System.Windows.Forms.Label();
            this.KernelSizeCounter = new System.Windows.Forms.NumericUpDown();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Matrix_10 = new System.Windows.Forms.TextBox();
            this.Matrix_11 = new System.Windows.Forms.TextBox();
            this.Matrix_12 = new System.Windows.Forms.TextBox();
            this.Matrix_20 = new System.Windows.Forms.TextBox();
            this.Matrix_21 = new System.Windows.Forms.TextBox();
            this.Matrix_22 = new System.Windows.Forms.TextBox();
            this.Matrix_00 = new System.Windows.Forms.TextBox();
            this.Matrix_01 = new System.Windows.Forms.TextBox();
            this.Matrix_02 = new System.Windows.Forms.TextBox();
            this.Width_txt = new System.Windows.Forms.TextBox();
            this.Height_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PollingMaxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KernelSizeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PollingMaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box_1
            // 
            this.pic_box_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box_1.Location = new System.Drawing.Point(12, 82);
            this.pic_box_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_box_1.Name = "pic_box_1";
            this.pic_box_1.Size = new System.Drawing.Size(512, 512);
            this.pic_box_1.TabIndex = 0;
            this.pic_box_1.TabStop = false;
            // 
            // pic_box_2
            // 
            this.pic_box_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box_2.Location = new System.Drawing.Point(740, 82);
            this.pic_box_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_box_2.Name = "pic_box_2";
            this.pic_box_2.Size = new System.Drawing.Size(512, 512);
            this.pic_box_2.TabIndex = 1;
            this.pic_box_2.TabStop = false;
            // 
            // Convert_Btn
            // 
            this.Convert_Btn.Location = new System.Drawing.Point(592, 254);
            this.Convert_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Convert_Btn.Name = "Convert_Btn";
            this.Convert_Btn.Size = new System.Drawing.Size(82, 22);
            this.Convert_Btn.TabIndex = 2;
            this.Convert_Btn.Text = "Convert";
            this.Convert_Btn.UseVisualStyleBackColor = true;
            this.Convert_Btn.Click += new System.EventHandler(this.Convert_Btn_Click);
            // 
            // File_Btn
            // 
            this.File_Btn.Location = new System.Drawing.Point(424, 52);
            this.File_Btn.Name = "File_Btn";
            this.File_Btn.Size = new System.Drawing.Size(100, 25);
            this.File_Btn.TabIndex = 3;
            this.File_Btn.Text = "Open Image";
            this.File_Btn.UseVisualStyleBackColor = true;
            this.File_Btn.Click += new System.EventHandler(this.File_Btn_Click);
            // 
            // Path_TXT
            // 
            this.Path_TXT.AutoSize = true;
            this.Path_TXT.Location = new System.Drawing.Point(12, 599);
            this.Path_TXT.Name = "Path_TXT";
            this.Path_TXT.Size = new System.Drawing.Size(48, 15);
            this.Path_TXT.TabIndex = 4;
            this.Path_TXT.Text = "./Path...";
            // 
            // KernelSizeCounter
            // 
            this.KernelSizeCounter.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KernelSizeCounter.Location = new System.Drawing.Point(574, 281);
            this.KernelSizeCounter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KernelSizeCounter.Name = "KernelSizeCounter";
            this.KernelSizeCounter.Size = new System.Drawing.Size(120, 23);
            this.KernelSizeCounter.TabIndex = 5;
            this.KernelSizeCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KernelSizeCounter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KernelSizeCounter.ValueChanged += new System.EventHandler(this.KernelSizeCounter_ValueChanged);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(1144, 646);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(108, 23);
            this.Save_Btn.TabIndex = 7;
            this.Save_Btn.Text = "Save Output";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Matrix_10
            // 
            this.Matrix_10.Location = new System.Drawing.Point(590, 402);
            this.Matrix_10.Name = "Matrix_10";
            this.Matrix_10.Size = new System.Drawing.Size(25, 23);
            this.Matrix_10.TabIndex = 8;
            this.Matrix_10.Text = "1";
            this.Matrix_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_11
            // 
            this.Matrix_11.Location = new System.Drawing.Point(621, 402);
            this.Matrix_11.Name = "Matrix_11";
            this.Matrix_11.Size = new System.Drawing.Size(25, 23);
            this.Matrix_11.TabIndex = 9;
            this.Matrix_11.Text = "0";
            this.Matrix_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_12
            // 
            this.Matrix_12.Location = new System.Drawing.Point(652, 402);
            this.Matrix_12.Name = "Matrix_12";
            this.Matrix_12.Size = new System.Drawing.Size(25, 23);
            this.Matrix_12.TabIndex = 10;
            this.Matrix_12.Text = "-1";
            this.Matrix_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_20
            // 
            this.Matrix_20.Location = new System.Drawing.Point(590, 431);
            this.Matrix_20.Name = "Matrix_20";
            this.Matrix_20.Size = new System.Drawing.Size(25, 23);
            this.Matrix_20.TabIndex = 11;
            this.Matrix_20.Text = "1";
            this.Matrix_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_21
            // 
            this.Matrix_21.Location = new System.Drawing.Point(621, 431);
            this.Matrix_21.Name = "Matrix_21";
            this.Matrix_21.Size = new System.Drawing.Size(25, 23);
            this.Matrix_21.TabIndex = 12;
            this.Matrix_21.Text = "0";
            this.Matrix_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_22
            // 
            this.Matrix_22.Location = new System.Drawing.Point(652, 431);
            this.Matrix_22.Name = "Matrix_22";
            this.Matrix_22.Size = new System.Drawing.Size(25, 23);
            this.Matrix_22.TabIndex = 13;
            this.Matrix_22.Text = "-1";
            this.Matrix_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_00
            // 
            this.Matrix_00.Location = new System.Drawing.Point(590, 373);
            this.Matrix_00.Name = "Matrix_00";
            this.Matrix_00.Size = new System.Drawing.Size(25, 23);
            this.Matrix_00.TabIndex = 14;
            this.Matrix_00.Text = "1";
            this.Matrix_00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_01
            // 
            this.Matrix_01.Location = new System.Drawing.Point(621, 373);
            this.Matrix_01.Name = "Matrix_01";
            this.Matrix_01.Size = new System.Drawing.Size(25, 23);
            this.Matrix_01.TabIndex = 15;
            this.Matrix_01.Text = "0";
            this.Matrix_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Matrix_02
            // 
            this.Matrix_02.Location = new System.Drawing.Point(652, 373);
            this.Matrix_02.Name = "Matrix_02";
            this.Matrix_02.Size = new System.Drawing.Size(25, 23);
            this.Matrix_02.TabIndex = 16;
            this.Matrix_02.Text = "-1";
            this.Matrix_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Width_txt
            // 
            this.Width_txt.Location = new System.Drawing.Point(166, 54);
            this.Width_txt.Name = "Width_txt";
            this.Width_txt.Size = new System.Drawing.Size(75, 23);
            this.Width_txt.TabIndex = 17;
            this.Width_txt.Text = "256";
            this.Width_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Height_txt
            // 
            this.Height_txt.Location = new System.Drawing.Point(267, 54);
            this.Height_txt.Name = "Height_txt";
            this.Height_txt.Size = new System.Drawing.Size(75, 23);
            this.Height_txt.TabIndex = 18;
            this.Height_txt.Text = "256";
            this.Height_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Resolotion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "X";
            // 
            // PollingMaxValue
            // 
            this.PollingMaxValue.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PollingMaxValue.Location = new System.Drawing.Point(574, 310);
            this.PollingMaxValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PollingMaxValue.Name = "PollingMaxValue";
            this.PollingMaxValue.Size = new System.Drawing.Size(120, 23);
            this.PollingMaxValue.TabIndex = 21;
            this.PollingMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PollingMaxValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PollingMaxValue.ValueChanged += new System.EventHandler(this.PollingMaxValue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PollingMaxValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Height_txt);
            this.Controls.Add(this.Width_txt);
            this.Controls.Add(this.Matrix_02);
            this.Controls.Add(this.Matrix_01);
            this.Controls.Add(this.Matrix_00);
            this.Controls.Add(this.Matrix_22);
            this.Controls.Add(this.Matrix_21);
            this.Controls.Add(this.Matrix_20);
            this.Controls.Add(this.Matrix_12);
            this.Controls.Add(this.Matrix_11);
            this.Controls.Add(this.Matrix_10);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.KernelSizeCounter);
            this.Controls.Add(this.Path_TXT);
            this.Controls.Add(this.File_Btn);
            this.Controls.Add(this.Convert_Btn);
            this.Controls.Add(this.pic_box_2);
            this.Controls.Add(this.pic_box_1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KernelSizeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PollingMaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_box_1;
        private PictureBox pic_box_2;
        private Button Convert_Btn;
        private Button File_Btn;
        private Label Path_TXT;
        private NumericUpDown KernelSizeCounter;
        private Button Save_Btn;
        private TextBox Matrix_10;
        private TextBox Matrix_11;
        private TextBox Matrix_12;
        private TextBox Matrix_20;
        private TextBox Matrix_21;
        private TextBox Matrix_22;
        private TextBox Matrix_00;
        private TextBox Matrix_01;
        private TextBox Matrix_02;
        private TextBox Width_txt;
        private TextBox Height_txt;
        private Label label1;
        private Label label2;
        private NumericUpDown PollingMaxValue;
    }
}