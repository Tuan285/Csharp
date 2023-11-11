using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms.DataVisualization.Charting;

namespace ARDUINO_RS485
{
    public partial class Form1 : Form
    {
        float bufferSlave1, bufferSlave2 , bufferSlave3;

        string[] ComPort;

        byte[] Adress = { 0x01, 0x02, 0x03 };

        byte[] Enable_Tx_Rx = { 0x05, 0x06 };

        byte[] bufferOnOff = { 0x00, 0x01 };

        byte[] bufferbuffer;
        string linkOn = "D:\\C#\\ARDUINO_RS485\\idea-bulbon.png";
        string linkOff = "D:\\C#\\ARDUINO_RS485\\idea-bulboff.png";
        public Form1()
        {
            InitializeComponent();

            ComPort = SerialPort.GetPortNames();
            foreach (string port in ComPort)
            {
                comboBoxCom.Items.Add(port);
                Console.WriteLine(port);
                if (ComPort[0] != null)
                {
                    comboBoxCom.SelectedItem = ComPort[0];
                }
            }

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "37600", "115200" };
            comboBoxBaud.Items.AddRange(BaudRate);
            comboBoxBaud.Text = BaudRate[7];

            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.Title = "TIME";
            chart1.ChartAreas[0].AxisY.Title = "DATA SLAVE";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font(chart1.ChartAreas[0].AxisX.TitleFont.FontFamily, 12f);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font(chart1.ChartAreas[0].AxisY.TitleFont.FontFamily, 12f);
            chart1.Series[0].LegendText = "DATA SLAVE 1";
            chart1.Series[1].LegendText = "DATA SLAVE 2";
            chart1.Series[2].LegendText = "DATA SLAVE 3";
            timer1.Start();
        }
        
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }



        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxCom.Text;
                    serialPort.BaudRate = (int)Convert.ToInt32(comboBoxBaud.Text);
                    serialPort.Parity = Parity.None;
                    serialPort.DataBits = 8;

                    //serialPort.StopBits = StopBits.None;
                    serialPort.Open();

                }
                else if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch
            {
            }
        }

        bool onOffSlave1, onOffSlave2, onOffSlave3;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                buttonConnect.Text = "DISCONNECTED";
                buttonConnect.BackColor = Color.Red;
            }else if( !serialPort.IsOpen)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                buttonConnect.Text = "CONNECTED";
                buttonConnect.BackColor = Color.Green;
            }


            if (onOffSlave1 == true)
            {
                Bitmap on = new Bitmap(linkOn);
                pictureBoxSlave1.Image = (Image)on;
            }
            else if (onOffSlave1 == false)
            {
                Bitmap off = new Bitmap(linkOff);
                pictureBoxSlave1.Image = (Image)off;
            }

            if (onOffSlave2 == true)
            {
                Bitmap on = new Bitmap(linkOn);
                pictureBoxSlave2.Image = (Image)on;
            }
            else if (onOffSlave2 == false)
            {
                Bitmap off = new Bitmap(linkOff);
                pictureBoxSlave2.Image = (Image)off;
            }

            if (onOffSlave3 == true)
            {
                Bitmap on = new Bitmap(linkOn);
                pictureBoxSlave3.Image = (Image)on;
            }
            else if (onOffSlave3 == false)
            {
                Bitmap off = new Bitmap(linkOff);
                pictureBoxSlave3.Image = (Image)off;
            }
        }
        bool controlSlave1;

        private void pictureBoxSlave1_Click(object sender, EventArgs e)
        {
            if (controlSlave1 == true)
            {
                var buffer = new byte[] { Adress[0], Enable_Tx_Rx[0],  bufferOnOff[0] };
                serialPort.Write(buffer, 0, 3);
                controlSlave1 = false;
            }
            else if (controlSlave1 == false)
            {
                var buffer = new byte[] { Adress[0], Enable_Tx_Rx[0], bufferOnOff[1] };
                serialPort.Write(buffer, 0, 3);
                controlSlave1 = true;
            }
        }
        bool controlSlave2;

        private void pictureBoxSlave2_Click(object sender, EventArgs e)
        {
            if (controlSlave2 == true)
            {
                var buffer = new byte[] { Adress[1], Enable_Tx_Rx[0], bufferOnOff[0] };
                serialPort.Write(buffer, 0, 3);
                controlSlave2 = false;
            }
            else if (controlSlave2 == false)
            {
                var buffer = new byte[] { Adress[1], Enable_Tx_Rx[0], bufferOnOff[1] };
                serialPort.Write(buffer, 0, 3);
                controlSlave2 = true;
            }
        }

        bool controlSlave3;
        private void pictureBoxSlave3_Click(object sender, EventArgs e)
        {
            if (controlSlave3 == true)
            {
                var buffer = new byte[] { Adress[2], Enable_Tx_Rx[0], bufferOnOff[0] };
                serialPort.Write(buffer, 0, 3);
                controlSlave3 = false;
            }
            else if (controlSlave3 == false)
            {   
                var buffer = new byte[] { Adress[2], Enable_Tx_Rx[0], bufferOnOff[1] };
                serialPort.Write(buffer, 0, 3);
                controlSlave3 = true;
            }
        }


        float floatSlave1, floatSlave2, floatSlave3;

        private void formbuffer(byte[] buffer)
        {
            try
            {
                for (int i = 0; i < Adress.Length; i++)
                {
                    if (buffer[0] == Adress[i])
                    {
                        if (buffer[1] == Enable_Tx_Rx[1])
                        {
                            if (buffer[2] == bufferOnOff[0])
                            {
                                Bitmap off = new Bitmap("D:\\C#\\RS485_ARDUINO\\lightOFF.png");
                                if (Adress[i] == Adress[0])
                                {
                                    onOffSlave1 = false;
                                    pictureBoxSlave1.Image = (Image)off;

                                }
                                else if (Adress[i] == Adress[1])
                                {
                                    onOffSlave2 = false;
                                    pictureBoxSlave2.Image = (Image)off;
                                }
                                else if (Adress[i] == Adress[2])
                                {
                                    onOffSlave3 = false;
                                    pictureBoxSlave3.Image = (Image)off;
                                }

                            }
                            else if (buffer[2] == bufferOnOff[1])
                            {
                                Bitmap on = new Bitmap("D:\\C#\\RS485_ARDUINO\\lightON.png");
                                if (Adress[i] == Adress[0])
                                {
                                    onOffSlave1 = true;
                                    pictureBoxSlave1.Image = (Image)on;
                                }
                                else if (Adress[i] == Adress[1])
                                {
                                    onOffSlave2 = true;
                                    pictureBoxSlave2.Image = (Image)on;
                                }
                                else if (Adress[i] == Adress[2])
                                {
                                    onOffSlave3 = true;
                                    pictureBoxSlave3.Image = (Image)on;
                                }

                                //ready = true;
                            }
                            if (buffer[2] == 0x03)
                            {
                                if (buffer[0] == Adress[0])
                                {
                                    floatSlave1 = BitConverter.ToSingle(buffer, 3);
                                }
                                if (buffer[0] == Adress[1])
                                {
                                    floatSlave2 = BitConverter.ToSingle(buffer, 3);
                                }
                                if (buffer[0] == Adress[2])
                                {
                                    floatSlave3 = BitConverter.ToSingle(buffer, 3);
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }
        List<DateTime> TimeList = new List<DateTime>();

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = serialPort.BytesToRead;
            bufferbuffer = new byte[len];
            serialPort.Read(bufferbuffer, 0, len);
            formbuffer(bufferbuffer);
        }

        List<double> bufferListslave1 = new List<double>();
        List<double> bufferListslave2 = new List<double>();
        List<double> bufferListslave3 = new List<double>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random1 = new Random();
            bufferSlave1 = (float)floatSlave1;
            bufferSlave2 = (float)floatSlave2;
            bufferSlave3 = (float)floatSlave3;

            DateTime now = DateTime.Now;
            TimeList.Add(now);

            Random random = new Random();
            bufferListslave1.Add(bufferSlave1);
            bufferListslave2.Add(bufferSlave2);
            bufferListslave3.Add(bufferSlave3);
            
            int maxbufferPoints = 50;
            if (chart1.Series[0].Points.Count > maxbufferPoints
                || chart1.Series[1].Points.Count > maxbufferPoints
                || chart1.Series[2].Points.Count > maxbufferPoints)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            
            int startIndex = Math.Max(0, TimeList.Count - maxbufferPoints);
            for (int j = startIndex; j < TimeList.Count; j++)
            {
                chart1.Series[0].Points.AddXY(TimeList[j], bufferListslave1[j]);
                chart1.Series[1].Points.AddXY(TimeList[j], bufferListslave2[j]);
                chart1.Series[2].Points.AddXY(TimeList[j], bufferListslave3[j]);
            }
        }
    }
}
