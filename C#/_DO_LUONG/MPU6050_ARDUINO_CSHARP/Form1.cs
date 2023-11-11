using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MPU6050_ARDUINO_CSHARP
{
    public partial class Form1 : Form
    {
        private const int min_value_circulat = -11;
        private const int max_value_circulat = 11;
        int value_X, value_Y, value_Z;
        int min_x, min_y, min_z;
        int max_x, max_y, max_z;
        int valuex, valuey, valuez;
        String[] ports;
        String dataReceive;
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_COM.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox_COM.SelectedItem = ports[0];
                }
            }
            string[] BaudRate = {"9600", "19200", "38400", "37600", "115200" };
            comboBox_BAUD.Items.AddRange(BaudRate);
            comboBox_BAUD.Text = BaudRate[0];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int Index = comboBox_BAUD.SelectedIndex;
            String[] list_com = SerialPort.GetPortNames();
            int[] ComnumberList = new int[list_com.Length];
            for (int i = 0; i < list_com.Length; i++)
            {
                ComnumberList[i] = int.Parse(list_com[i].Substring(3));
            }

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            BT_DISC.Enabled = false;
            BT_CONNECT.Enabled = true;
            BT_CONNECT.BackColor = Color.Green;
            BT_DISC.BackColor = Color.White;
            STATUS_COM.Text = "DisConnected !";
            STATUS_COM.ForeColor = Color.Red;
        }
        private void BT_DISC_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                BT_CONNECT.Enabled= true;
                BT_DISC.Enabled = false;
                STATUS_COM.Text = "DisConnected !";
                STATUS_COM.ForeColor = Color.Red;
                comboBox_COM.Enabled = true;
                comboBox_BAUD.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
        }
        private void BT_CONNECT_Click(object sender, EventArgs e)
        {
            try {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = comboBox_COM.Text;
                    serialPort.BaudRate = (int)Convert.ToInt32(comboBox_BAUD.Text);
                    serialPort.Open();
                    STATUS_COM.Text = "Connected !";
                    STATUS_COM.ForeColor = Color.Green;
                    min_x = -10;
                    min_y = -10;
                    min_z = -10;
                    max_x = 10;
                    max_y = 10;
                    max_z = 10;
                    textBox_MINX.Text = min_x.ToString();
                    textBox_MINY.Text = min_y.ToString();
                    textBox_MINZ.Text = min_z.ToString();
                    textBox_MAX_X.Text = max_x.ToString();
                    textBox_MAX_Y.Text = max_y.ToString();
                    textBox_MAX_Z.Text = max_z.ToString();

                    comboBox_COM.Enabled = false;
                    comboBox_BAUD.Enabled = false;
                    BT_CONNECT.Enabled = false;
                    BT_DISC.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                }
            }
            catch
            {
                STATUS_COM.Text = "DisConnected !";
                STATUS_COM.ForeColor = Color.Red;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceive = serialPort.ReadLine().ToString();
            Print_Text(dataReceive);
            dataReceive = "";
        }

        delegate void SetTextCallback(string text);
        private void Print_Text(string text)
        {
            if (this.label_value_x.InvokeRequired || this.label_value_y.InvokeRequired || this.label_value_z.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Print_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {   
                String str_valuex, str_valuey, str_valuez;
                text = text.Trim();
                string[] text_num = text.Split('/');    
                str_valuex = text_num[0].ToString();
                str_valuey = text_num[1].ToString();
                str_valuez = text_num[2].ToString();
                decimal tmp1, tmp2, tmp3;
                float store_Valuex = decimal.TryParse(str_valuex, out tmp1) ? (float)tmp1 : 0;
                float store_Valuey = decimal.TryParse(str_valuey, out tmp2) ? (float)tmp2 : 0;
                float store_Valuez = decimal.TryParse(str_valuez, out tmp3) ? (float)tmp3 : 0;
                valuex = (int)Convert.ToInt32(store_Valuex);
                valuey = (int)Convert.ToInt32(store_Valuey);
                valuez = (int)Convert.ToInt32(store_Valuez);
                //set_min_value(valuex, valuey, valuez);
                //circularProgressBar_ANGLE_X.Value = valuex;
                //circularProgressBar_ANGLE_Y.Value = valuey;
                //circularProgressBar_ANGLE_Z.Value = valuez;
                label_value_x.Text = str_valuex;
                label_value_y.Text= str_valuey;
                label_value_z.Text = str_valuez;

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                BT_DISC.BackColor = Color.Red;
                BT_CONNECT.BackColor = Color.White;
                check_X(valuex, min_x, max_x);
                check_Y(valuey, min_y, max_y);
                check_Z(valuez, min_z, max_z);
                
            }
            else if(!serialPort.IsOpen)
            {
                BT_CONNECT.BackColor = Color.Green;
                BT_DISC.BackColor = Color.White;
                //SerialPort.GetPortNames();
            }
        }
        private void CONFIRM_Z_Click(object sender, EventArgs e)
        {
            min_z = Convert.ToInt32(textBox_MINZ.Text.ToString());
            max_z = Convert.ToInt32(textBox_MAX_Z.Text.ToString());
        }
        private void CONFIRM_Y_Click(object sender, EventArgs e)
        {
            min_y = Convert.ToInt32(textBox_MINY.Text.ToString());
            max_y = Convert.ToInt32(textBox_MAX_Y.Text.ToString());
        }

        private void CONFIRM_X_Click(object sender, EventArgs e)
        {
            min_x = Convert.ToInt32(textBox_MINX.Text.ToString());
            max_x = Convert.ToInt32(textBox_MAX_X.Text.ToString());
        }
        private void check_X(int value, int min, int max)
        {
            if(value < min || value > max)
            {
                WARNING_X.Text = "WARNING ANGLE X";
                WARNING_X.Visible = !WARNING_X.Visible;
                WARNING_X.ForeColor = Color.Red;
            }
            else
            {
                WARNING_X.Text = "NORMAL ANGLE X";
                WARNING_X.ForeColor = Color.Green;
                WARNING_X.Visible = true;
            }
        }
        private void check_Y(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                WARNING_Y.Text = "WARNING ANGLE Y";
                WARNING_Y.Visible = !WARNING_Y.Visible;
                WARNING_Y.ForeColor = Color.Red;
            }
            else
            {
                WARNING_Y.Text = "NORMAL ANGLE Y";
                WARNING_Y.ForeColor = Color.Green;
                WARNING_Y.Visible = true;
            }
        }
        private void check_Z(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                WARNING_Z.Text = "WARNING ANGLE Z";
                WARNING_Z.Visible =!WARNING_Z.Visible;
                WARNING_Z.ForeColor = Color.Red;
            }
            else
            {
                WARNING_Z.Text = "NORMAL ANGLE Z";
                WARNING_Z.ForeColor = Color.Green;
                WARNING_Z.Visible = true;
            }
        }

    }
}
