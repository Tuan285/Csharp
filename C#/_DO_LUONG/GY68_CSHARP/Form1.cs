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

namespace GY68_CSHARP
{
    public partial class Form1 : Form
    {
        String[] ports;
        String data_rev;
        int value, values;
        int min, max, mins, maxs;
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
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "37600", "115200" };
            comboBox_baud.Items.AddRange(BaudRate);
            comboBox_baud.Text = BaudRate[3];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Index = comboBox_baud.SelectedIndex;
            String[] comlist = SerialPort.GetPortNames();
            int[] ComnumberList = new int[comlist.Length];
            for (int i = 0; i < comlist.Length; i++)
            {
                ComnumberList[i] = int.Parse(comlist[i].Substring(3));
            }
            textBox_min.Text = "100000";
            textBox_max.Text = "101400";
            circularProgressBar1.Text = "0";
            circularProgressBar1.Value = 0;
            button_con.Text = "Connect";
            pictureBox2.Hide();
            pictureBox1.Show();
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_rev = serialPort1.ReadLine().ToString();
            SetText(data_rev);
            data_rev = "";
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.circularProgressBar1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                value = (int)Convert.ToInt32(text.ToString());
                this.circularProgressBar1.Text = text;
                this.circularProgressBar1.Value = value;
            }
        }

        private void button_con_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                button_con.Text = "Connect";
                serialPort1.Close();
                circularProgressBar1.Text = "0";
                circularProgressBar1.Value = 0;
                button_con.BackColor = Color.SeaGreen;
                panel2.Enabled = false;
                panel1.Enabled = true;
                comboBox_baud.Enabled = true;
                comboBox_com.Enabled = true;
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox_com.Text;
                    serialPort1.BaudRate = (int)Convert.ToInt32(comboBox_baud.Text);
                    serialPort1.Open();
                    min = (int)Convert.ToInt32(textBox_min.Text.ToString());
                    max = (int)Convert.ToInt32(textBox_max.Text.ToString());
                    string data = min.ToString() + "/" + max.ToString();
                    serialPort1.WriteLine(data);
                    button_con.Text = "DisConnect";
                    button_con.BackColor = Color.Red;
                    comboBox_baud.Enabled = false;
                    comboBox_com.Enabled = false;
                    panel2.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Không thể mở cổng " + serialPort1.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            min = (int)Convert.ToInt32(textBox_min.Text.ToString().Trim());
            max = (int)Convert.ToInt32(textBox_max.Text.ToString().Trim());
            string data = min.ToString() + "/" + max.ToString();
            serialPort1.WriteLine(data);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                check(value, min, max);
            }
        }

        private void check(int value , int min , int max)
        {
            if(value >= max || value <= min)
            {
                pictureBox1.Hide();
                pictureBox2.Visible = !pictureBox2.Visible;
            }
            else
            {
                pictureBox2.Hide();
                pictureBox1.Show();
            }
        }
    }
}
