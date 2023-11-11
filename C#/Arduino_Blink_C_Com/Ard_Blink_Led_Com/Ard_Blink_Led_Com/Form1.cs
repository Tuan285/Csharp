using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//them thu vien cua Port
using System.IO;
using System.IO.Ports;
using System.Xml;

namespace Ard_Blink_Led_Com
{
    public partial class Form1 : Form
    {

        static SerialPort serialPort;       // khoi tao "bien" cong COM

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbPort.DataSource = SerialPort.GetPortNames();
            string[] BaudRate = { "4800", "9600", "19200", "38400", "57600", "74880", "115200" };
            cbBaud.Items.AddRange(BaudRate);
        }

        private void checkConnect ()
        {
            if (serialPort.IsOpen)
            {
                trangThai.Text = ("Da ket noi !");
                btConnect.Enabled = false;
                btDisconnect.Enabled = true;
            }
            else
            {
                trangThai.Text = ("Chua ket noi !");
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //serialPort.PortName = cbPort.Text;
            //serialPort.BaudRate = Convert.ToInt32(cbBaud.Text);
            serialPort = new SerialPort(cbPort.Text, Convert.ToInt32(cbBaud.Text)); // khoi tao "cong" COM
            serialPort.Open();
            checkConnect();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            checkConnect();
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("1");
        }
         

        private void btOff_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("0");
        }
    }
}
