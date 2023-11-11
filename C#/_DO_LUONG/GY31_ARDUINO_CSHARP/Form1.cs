using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GY31_ARDUINO_CSHARP
{
    public partial class Form1 : Form
    {
        String[] ports;
        String dataReceive;
        int value_R, value_G, value_B;
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_com.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox_com.SelectedItem = ports[0];
                }
            }
            string[] BaudRate = { "9600", "19200", "38400", "37600", "115200" };
            comboBox_baud.Items.AddRange(BaudRate);
            comboBox_baud.Text = BaudRate[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Index = comboBox_baud.SelectedIndex;
            String[] list_com = SerialPort.GetPortNames();
            int[] ComnumberList = new int[list_com.Length];
            for (int i = 0; i < list_com.Length; i++)
            {
                ComnumberList[i] = int.Parse(list_com[i].Substring(3));
            }
            label3.Text = "Ngắt Kết Nối Thành Công !";
            label3.ForeColor = Color.Red;
            groupBox2.Enabled = false;
            button_connect.Enabled = true;
            button_disc.Enabled = false;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox_com.Text;
                    serialPort1.BaudRate = (int)Convert.ToInt32(comboBox_baud.Text);
                    serialPort1.Open();
                    label3.Text = "Kết Nối Thành Công !";
                    label3.ForeColor = Color.Green;
                    button_connect.Enabled = false;
                    button_disc.Enabled = true;
                    groupBox2.Enabled=true;
                }
            }
            catch {
                label3.Text = "DisConnected !";
                label3.ForeColor = Color.Red;
            }
        }

        private void button_disc_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                label3.Text = "Ngắt Kết Nối Thành Công !";
                label3.ForeColor = Color.Red;
                groupBox2.Enabled = false;
                button_connect.Enabled = true;
                button_disc.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) // nhan du lieu
        {
            dataReceive = serialPort1.ReadLine().ToString();    // 20R30G255
            Print_Text(dataReceive);
            dataReceive = "";
        }
        delegate void SetTextCallback(string text);
        private void Print_Text(string text)
        {
            if (this.label_R.InvokeRequired || this.label_G.InvokeRequired || this.label_B.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Print_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {  
                int indexR = text.IndexOf('R');     //20R30G255 -> 2 
                int indexG = text.IndexOf('G');     //20R30G255 -> 5

                string valueR = text.Substring(0, indexR);
                string valueG = text.Substring(indexR + 1, indexG - indexR -1);
                string valueB = text.Substring(indexG + 1);
                value_R = (int)Convert.ToInt32(valueR);
                value_G = (int)Convert.ToInt32(valueG);
                value_B = (int)Convert.ToInt32(valueB);
                label_R.Text = "R :" + valueR; 
                label_G.Text = "G :" + valueG; 
                label_B.Text = "B :" + valueB;
                if(value_R <= 0)
                {
                    value_R = 0;
                }
                else if(value_R >= 255) 
                {
                    value_R = 255;
                }
                if (value_G <= 0)
                {
                    value_R = 0;
                }
                else if (value_G >= 255)
                {
                    value_R = 255;
                }
                if (value_B <= 0)
                {
                    value_R = 0;
                }
                else if (value_B >= 255)
                {
                    value_R = 255;
                }                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(value_R, value_G, value_B);
            panel1.BackColor = color;
        }
    }
}
