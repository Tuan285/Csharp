using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS485_ARDUINOV1
{
    public partial class Form1 : Form
    {
        string[] ports;

        byte[] slaveAdress  = {0x01, 0x02, 0x03};

        byte[] Enable_Tx_Rx = { 0x03, 0x04 };

        byte[] formData = { 0x05, 0x06 };

        byte[] dataOnOff = { 0x00, 0x01 };

        // frame onOff 0x10 0xFF 0x50 0x00
        // frame Value 0x10 0xFF 0x60 VALUE

        int valueSlave1 = 10, valueSlave2= 20, valueSlave3 = 30;

        byte[] bufferData;
        string linkOn = "D:\\C#\\RS485_ARDUINOV1\\light_on1.png";
        string linkOff = "D:\\C#\\RS485_ARDUINOV1\\light_off.png";
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxCom.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBoxCom.SelectedItem = ports[0];
                }
            }

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "37600", "115200" };
            comboBoxBaud.Items.AddRange(BaudRate);
            comboBoxBaud.Text = BaudRate[3];
            buttonConnect.Text = "CONNECT";
            buttonConnect.BackColor = Color.Green;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] list_com = SerialPort.GetPortNames();
            int[] ComnumberList = new int[list_com.Length];
            for (int i = 0; i < list_com.Length; i++)
            {
                ComnumberList[i] = int.Parse(list_com[i].Substring(3));
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBoxCom.Text;
                    serialPort.BaudRate = (int)Convert.ToInt32(comboBoxBaud.Text);
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.Open();

                }
                else
                {
                    serialPort.Close();
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                label6.Text = "Disconnect";
                buttonConnect.Text = "CONNECT";
                buttonConnect.BackColor = Color.Green;
            }
            if (serialPort.IsOpen)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                label6.Text = "Connect";
                buttonConnect.Text = "DISCONNECT";
                buttonConnect.BackColor = Color.Red;
            }

            circularProgressBarSlave1.Value = valueSlave1;
            circularProgressBarSlave1.Text = valueSlave1.ToString();
            
            circularProgressBarSlave2.Value = valueSlave2;
            circularProgressBarSlave2.Text = valueSlave2.ToString();

            circularProgressBarSlave3.Value = valueSlave3;
            circularProgressBarSlave3.Text = valueSlave3.ToString();
        }
        
        

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = serialPort.BytesToRead;
            bufferData = new byte[len];
            serialPort.Read(bufferData, 0, len);
            FormData(bufferData);
        }

        private void FormData(byte[] data)
        {
            for (int i = 0; i < slaveAdress.Length; i++)
            {
                try
                {
                    if (data[0] == slaveAdress[i])
                    {
                        if (data[1] == Enable_Tx_Rx[1])
                        {
                            if (data[2] == formData[1])         // value
                            {
                                if (data[0] == slaveAdress[0])
                                {
                                    valueSlave1 = BitConverter.ToInt16(data, 3);
                                }
                                else if (data[0] == slaveAdress[1])
                                {
                                    valueSlave2 = BitConverter.ToInt16(data, 3);
                                }
                                else if (data[0] == slaveAdress[2])
                                {
                                    valueSlave2 = BitConverter.ToInt16(data, 3);
                                }
                            }
                            if (data[2] == formData[0]) // on off
                            {
                                if (data[0] == slaveAdress[0])
                                {
                                    if (data[3] == dataOnOff[0])
                                    {
                                        Bitmap off = new Bitmap(linkOff);
                                        pictureBoxSlave1.Image = (Image)off;
                                        onOffSlave1 = false;

                                    }
                                    if (data[3] == dataOnOff[1])
                                    {
                                        Bitmap on = new Bitmap(linkOn);
                                        pictureBoxSlave1.Image = (Image)on;
                                        onOffSlave1 = true;
                                    }
                                }
                                if (data[0] == slaveAdress[1])
                                {
                                    if (data[3] == dataOnOff[0])
                                    {
                                        Bitmap off = new Bitmap(linkOff);
                                        pictureBoxSlave2.Image = (Image)off;
                                        onOffSlave2 = false;
                                    }
                                    if (data[3] == dataOnOff[1])
                                    {
                                        Bitmap on = new Bitmap(linkOn);
                                        pictureBoxSlave2.Image = (Image)on;
                                        onOffSlave2 = true;
                                    }
                                }
                                if (data[0] == slaveAdress[2])
                                {
                                    if (data[3] == dataOnOff[0])
                                    {
                                        Bitmap off = new Bitmap(linkOff);
                                        pictureBoxSlave3.Image = (Image)off;
                                        onOffSlave3 = false;
                                    }
                                    if (data[3] == dataOnOff[1])
                                    {
                                        Bitmap on = new Bitmap(linkOn);
                                        pictureBoxSlave3.Image = (Image)on;
                                        onOffSlave3 = true;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }
        //byte[] Enable_Tx_Rx = { 0x0F, 0x0A };
        bool onOffSlave1 = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (onOffSlave1 == false)
            {
                var data = new byte[] { slaveAdress[0], Enable_Tx_Rx[0], formData[0], dataOnOff[1] };
                serialPort.Write(data, 0, 4);
                onOffSlave1 = true;
            }
            else if (onOffSlave1 == true)
            {
                var data = new byte[] { slaveAdress[0], Enable_Tx_Rx[0], formData[0], dataOnOff[0] };
                serialPort.Write(data, 0, 4);
                onOffSlave1 = false;
            }
        }


        bool onOffSlave2 = false;
        private void pictureBoxSlave2_Click(object sender, EventArgs e)
        {
            if (onOffSlave2 == false)
            {
                var data = new byte[] { slaveAdress[1], Enable_Tx_Rx[0], formData[0], dataOnOff[1] };
                serialPort.Write(data, 0, 4);
                onOffSlave2 = true;
            }
            else if (onOffSlave2 == true)
            {
                var data = new byte[] { slaveAdress[1], Enable_Tx_Rx[0], formData[0], dataOnOff[0] };
                serialPort.Write(data, 0, 4);
                onOffSlave2 = false;
            }
        }

        bool onOffSlave3 = false;
        private void pictureBoxSlave3_Click(object sender, EventArgs e)
        {
            if (onOffSlave3 == false)
            {
                var data = new byte[] { slaveAdress[2], Enable_Tx_Rx[0], formData[0], dataOnOff[1] };
                serialPort.Write(data, 0, 4);
                onOffSlave3 = true;
            }
            else if (onOffSlave3 == true)
            {
                var data = new byte[] { slaveAdress[2], Enable_Tx_Rx[0], formData[0], dataOnOff[0] };
                serialPort.Write(data, 0, 4);
                onOffSlave3 = false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
