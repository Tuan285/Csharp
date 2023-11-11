using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Timers;

namespace Arduino_Com
{
    public partial class Form1 : Form
    {
        String receive;
        String send;
        String[] ports;
        int[] bauds = { 9600, 115200 };
        //SerialPort port;
        
        
        public Form1()
        {
            InitializeComponent();
            BT_DISC.Enabled = false;
            BT_CONNECT.Enabled = true;
            getAvailablePort();
            foreach (String port in ports)
            {
                comboBox_Ports.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox_Ports.SelectedItem = ports[0];
                }
            }
            foreach (int baud in bauds)
            {
                comboBox_Baud.Items.Add(baud);
            }
            comboBox_Baud.SelectedItem = bauds[0];
            panel_send_receive.Enabled = false;
        }

        private void getAvailablePort()
        {
            ports = SerialPort.GetPortNames();
        }
        
        private void BT_CONNECT_Click(object sender, EventArgs e)
        {
            connectPort();
            stt.Text = "Connected !";
            BT_CONNECT.Enabled = false;
            BT_DISC.Enabled = true;
            comboBox_Baud.Enabled = false;
            comboBox_Ports.Enabled  = false;
            panel_send_receive.Enabled = true;
        }

        private void connectPort()
        {
            //string selectPort = comboBox_Ports.GetItemText(comboBox_Ports.SelectedItem);
            serialPort1.PortName = comboBox_Ports.Text;
            serialPort1.BaudRate = (int)Convert.ToUInt32(comboBox_Baud.Text);
            serialPort1.Open(); 
        }

        private void BT_DISC_Click(object sender, EventArgs e)
        {
            discPorr();
            stt.Text = "DisConnected !";
            BT_CONNECT.Enabled = true;
            BT_DISC.Enabled = false;
            comboBox_Baud.Enabled = true;
            comboBox_Ports.Enabled = true;
            panel_send_receive.Enabled = false;
        }

        private void discPorr()
        {
            serialPort1.Close();
            BT_CONNECT.Enabled = true;
            BT_DISC.Enabled = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox_receive.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox_receive.Text = text;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SetText("");
            receive += serialPort1.ReadExisting().ToString();
            SetText(receive.ToString());
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BT_send_Click(object sender, EventArgs e)
        {
            send = textBox_send.Text.ToString();
            serialPort1.Write(send);
            textBox_send.Text = "";
        }

        private void textBox_send_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
