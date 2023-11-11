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

namespace RS485_ARDUINO
{
    public partial class Form1 : Form
    {
        string[] ports;

        byte[] addressSlave = { 0x01 , 0x02, 0x03};

        byte[] TxRx = { 0x05 , 0x06};

        byte[] DataTx = { 0x00, 0x01 };

        byte[] buffer;

        
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
            comboBoxBaud.Text = BaudRate[7];
        }
        bool ready;
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
                    if(serialPort.IsOpen)
                    {
                        label3.Text = "CONNECTED !";
                        buttonConnect.Text = "DISCONNECTED";
                        buttonConnect.BackColor = Color.Red;
                    }
                    if (serialPort.IsOpen)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            var data = new byte[] { addressSlave[i], TxRx[0], DataTx[0] };
                            serialPort.Write(data, 0, 3);
                        }
                    }
                    
                }
                else if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    label3.Text = "DISCONNECTED !";
                    buttonConnect.Text = "CONNECTED";
                    buttonConnect.BackColor = Color.Green;
                }
            }
            catch 
            {
                label3.Text = "DISCONNECTED";
                buttonConnect.BackColor = Color.Red;
            }
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
        bool onOffSlave1 = true;
        private void buttonSlave_Click(object sender, EventArgs e)
        {
            if (onOffSlave1 == true)
            {
                var data = new byte[] { addressSlave[0], TxRx[0], DataTx[1] };
                serialPort.Write(data, 0, 3);
                onOffSlave1 = false;
            }
            else if (onOffSlave1 == false)
            {
                var data = new byte[] { addressSlave[0], TxRx[0], DataTx[0] };
                serialPort.Write(data, 0, 3);
                onOffSlave1 = true;
            }
        }

        bool onOffSlave2 = true;
        private void buttonSlave2_Click(object sender, EventArgs e)
        {
            if (onOffSlave2 == true)
            {
                var data = new byte[] { addressSlave[1], TxRx[0], DataTx[1] };
                serialPort.Write(data, 0, 3);
                onOffSlave2 = false;
            }
            else if (onOffSlave2 == false)
            {
                var data = new byte[] { addressSlave[1], TxRx[0], DataTx[0] };
                serialPort.Write(data, 0, 3);
                onOffSlave2 = true;
            }
        }
        bool onOffSlave3 = true;
        private void buttonSlave3_Click(object sender, EventArgs e)
        {
            if (onOffSlave3 == true)
            {
                var data = new byte[] { addressSlave[2], TxRx[0], DataTx[1] };
                serialPort.Write(data, 0, 3);
                onOffSlave3 = false;
            }
            else if (onOffSlave3 == false) 
            {
                var data = new byte[] { addressSlave[2], TxRx[0], DataTx[0] };
                serialPort.Write(data, 0, 3);
                onOffSlave3 = true;
            }
            
        }
        float myFloatSlave1, myFloatSlave2, myFloatSlave3;
        bool onOffLed1;
        bool onOffLed2;
        bool onOffLed3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxSlave1.Text = myFloatSlave1.ToString("F");
            textBoxSlave2.Text = myFloatSlave2.ToString("F");
            textBoxSlave3.Text = myFloatSlave3.ToString("F");
            if (serialPort.IsOpen)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                label3.Text = "CONNECTED !";
                buttonConnect.Text = "DISCONNECTED";
                buttonConnect.BackColor = Color.Red;
                if (ready == true)
                {
                    try
                    {

                        if (onOffLed1 == true)
                        {
                            buttonSlave.Text = "OFF";
                        }
                        else if (onOffLed1 == false)
                        {
                            buttonSlave.Text = "ON";
                        }

                        if (onOffLed2 == true)
                        {
                            buttonSlave2.Text = "OFF";
                        }
                        else if (onOffLed2 == false)
                        {
                            buttonSlave2.Text = "ON";
                        }

                    }
                    catch { }
                }
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                label3.Text = "DISCONNECTED !";
                buttonConnect.Text = "CONNECTED";
                buttonConnect.BackColor = Color.Green;
            }
            
        }
        
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = serialPort.BytesToRead;
            buffer = new byte[len];
            serialPort.Read(buffer, 0, len);
            checkData(buffer);
        }
        private void checkData(byte[] data)
        {
            try
            {
                for (int i = 0; i < addressSlave.Length; i++)
                {
                    if (data[0] == addressSlave[i])
                    {
                        if (data[1] == TxRx[1])
                        {
                            if (data[2] == DataTx[0])
                            {
                                Bitmap off = new Bitmap("D:\\C#\\RS485_ARDUINO\\lightOFF.png");
                                if (addressSlave[i] == addressSlave[0])
                                {
                                    onOffLed1 = false;
                                    pictureBoxSlave1.Image = (Image)off;
                                    
                                }
                                else if (addressSlave[i] == addressSlave[1])
                                {
                                    onOffLed2 = false;
                                    pictureBoxSlave2.Image = (Image)off;
                                }
                                else if (addressSlave[i] == addressSlave[2])
                                {
                                    onOffLed3 = false;
                                    pictureBoxSlave3.Image = (Image)off;
                                }
                                
                            }
                            else if (data[2] == DataTx[1])
                            {
                                Bitmap on = new Bitmap("D:\\C#\\RS485_ARDUINO\\lightON.png");
                                if (addressSlave[i] == addressSlave[0])
                                {
                                    onOffLed1 = true;
                                    pictureBoxSlave1.Image = (Image)on;
                                }
                                else if (addressSlave[i] == addressSlave[1])
                                {
                                    onOffLed2 = true;
                                    pictureBoxSlave2.Image = (Image)on;
                                }
                                else if (addressSlave[i] == addressSlave[2])
                                {
                                    onOffLed3 = true;
                                    pictureBoxSlave3.Image = (Image)on;
                                }

                                ready = true;
                            }
                            if (data[2] == 0x03)
                            {
                                if (data[0] == addressSlave[0])
                                {
                                    myFloatSlave1 = BitConverter.ToSingle(data, 3);
                                }
                                if (data[0] == addressSlave[1])
                                {
                                    myFloatSlave2 = BitConverter.ToSingle(data, 3);
                                }
                                if (data[0] == addressSlave[2])
                                {
                                    myFloatSlave3 = BitConverter.ToSingle(data, 3);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}
