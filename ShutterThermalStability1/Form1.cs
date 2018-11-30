using System;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using System.IO;

namespace NiAnalogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitParam();
        }

        public struct Parameters
        {
            public double AnalogValue1;
            public double AnalogValue2;
            public double AnalogValue3;
            public double AnalogValue4;
            public string filePath;
            public string fileName;
            
            public void Init()
            {
                this.AnalogValue1 = 0;
                this.AnalogValue2 = 0;
                this.AnalogValue3 = 0;
                this.AnalogValue4 = 0;
                this.fileName = string.Empty;
                this.filePath = string.Empty;
            }
        }

        Parameters param = new Parameters();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            getData();
            WriteDataToFile();           
        }

        private void getData()
        {
            //Init NI DAQ
            NationalInstruments.DAQmx.Task AnalogIn0Task = new NationalInstruments.DAQmx.Task();
            NationalInstruments.DAQmx.Task AnalogIn1Task = new NationalInstruments.DAQmx.Task();
            NationalInstruments.DAQmx.Task AnalogIn2Task = new NationalInstruments.DAQmx.Task();
            NationalInstruments.DAQmx.Task AnalogIn3Task = new NationalInstruments.DAQmx.Task();
            AIChannel Ai0, Ai1, Ai2, Ai3;
            Ai0 = AnalogIn0Task.AIChannels.CreateVoltageChannel(AnalogIn0.Text, "Ai0", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            Ai1 = AnalogIn1Task.AIChannels.CreateVoltageChannel(AnalogIn1.Text, "Ai1", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            Ai2 = AnalogIn2Task.AIChannels.CreateVoltageChannel(AnalogIn2.Text, "Ai2", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            Ai3 = AnalogIn3Task.AIChannels.CreateVoltageChannel(AnalogIn3.Text, "Ai3", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader0 = new AnalogSingleChannelReader(AnalogIn0Task.Stream);
            AnalogSingleChannelReader reader1 = new AnalogSingleChannelReader(AnalogIn1Task.Stream);
            AnalogSingleChannelReader reader2 = new AnalogSingleChannelReader(AnalogIn2Task.Stream);
            AnalogSingleChannelReader reader3 = new AnalogSingleChannelReader(AnalogIn3Task.Stream);

            param.AnalogValue1 = reader0.ReadSingleSample();
            param.AnalogValue2 = reader1.ReadSingleSample();
            param.AnalogValue3 = reader2.ReadSingleSample();
            param.AnalogValue4 = reader3.ReadSingleSample();
        }

        private void WriteDataToFile()
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string path = @param.filePath + @"\" + @param.fileName + @".txt";

            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Time Stamp, LaserIn, LaserOut, MDin, MDout");
                        sw.WriteLine(timeStamp + ", " + param.AnalogValue1.ToString() + ", " + param.AnalogValue2.ToString()
                                     +", " + param.AnalogValue3.ToString() + ", " + param.AnalogValue4.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to Create Report");
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(timeStamp + ", " + param.AnalogValue1.ToString() + ", " + param.AnalogValue2.ToString()
                                         + ", " + param.AnalogValue3.ToString() + ", " + param.AnalogValue4.ToString());
                    }
                }
                catch
                {

                }
            }

        }

        private void InitParam()
        {
            param.Init();
        }

        private void folderPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            //
            param.fileName = fileName.Text;
            param.filePath = textBox1.Text;

            //start the timer 
            timer1.Start();                 //Start the timer
            timer1.Interval = 5000;
        }

        private void stopTest_Click(object sender, EventArgs e)
        {
            //stop the timer 
            timer1.Stop();                 //Stop the timer
        }
    }
}
