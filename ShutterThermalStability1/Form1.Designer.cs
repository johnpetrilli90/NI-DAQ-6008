namespace NiAnalogIn
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AnalogIn3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalogIn2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AnalogIn1 = new System.Windows.Forms.TextBox();
            this.AnalogIn0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startTest = new System.Windows.Forms.Button();
            this.stopTest = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(312, 19);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(75, 23);
            this.folderPath.TabIndex = 11;
            this.folderPath.Text = "Path";
            this.folderPath.UseVisualStyleBackColor = true;
            this.folderPath.Click += new System.EventHandler(this.folderPath_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderPath);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse Folder Path";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AnalogIn3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.AnalogIn2);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.AnalogIn1);
            this.groupBox5.Controls.Add(this.AnalogIn0);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(18, 61);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 158);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DAQ Settings";
            // 
            // AnalogIn3
            // 
            this.AnalogIn3.Location = new System.Drawing.Point(134, 105);
            this.AnalogIn3.Name = "AnalogIn3";
            this.AnalogIn3.Size = new System.Drawing.Size(100, 20);
            this.AnalogIn3.TabIndex = 15;
            this.AnalogIn3.Text = "dev2/ai3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Analog In 3";
            // 
            // AnalogIn2
            // 
            this.AnalogIn2.Location = new System.Drawing.Point(134, 81);
            this.AnalogIn2.Name = "AnalogIn2";
            this.AnalogIn2.Size = new System.Drawing.Size(100, 20);
            this.AnalogIn2.TabIndex = 13;
            this.AnalogIn2.Text = "dev2/ai2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Analog In 2";
            // 
            // AnalogIn1
            // 
            this.AnalogIn1.Location = new System.Drawing.Point(134, 55);
            this.AnalogIn1.Name = "AnalogIn1";
            this.AnalogIn1.Size = new System.Drawing.Size(100, 20);
            this.AnalogIn1.TabIndex = 11;
            this.AnalogIn1.Text = "dev2/ai1";
            // 
            // AnalogIn0
            // 
            this.AnalogIn0.Location = new System.Drawing.Point(134, 29);
            this.AnalogIn0.Name = "AnalogIn0";
            this.AnalogIn0.Size = new System.Drawing.Size(100, 20);
            this.AnalogIn0.TabIndex = 10;
            this.AnalogIn0.Text = "dev2/ai0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Analog In 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Analog In 0";
            // 
            // startTest
            // 
            this.startTest.Location = new System.Drawing.Point(17, 12);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(75, 33);
            this.startTest.TabIndex = 18;
            this.startTest.Text = "Start Test";
            this.startTest.UseVisualStyleBackColor = true;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // stopTest
            // 
            this.stopTest.Location = new System.Drawing.Point(107, 12);
            this.stopTest.Name = "stopTest";
            this.stopTest.Size = new System.Drawing.Size(75, 33);
            this.stopTest.TabIndex = 19;
            this.stopTest.Text = "Stop Test";
            this.stopTest.UseVisualStyleBackColor = true;
            this.stopTest.Click += new System.EventHandler(this.stopTest_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.fileName);
            this.groupBox6.Location = new System.Drawing.Point(293, 159);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 60);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "File Name";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(113, 19);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(121, 20);
            this.fileName.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 303);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.stopTest);
            this.Controls.Add(this.startTest);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "NI 6008 Analog Input Data Logger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderPath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox AnalogIn2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AnalogIn1;
        private System.Windows.Forms.TextBox AnalogIn0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.Button stopTest;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AnalogIn3;
        private System.Windows.Forms.Label label1;
    }
}

