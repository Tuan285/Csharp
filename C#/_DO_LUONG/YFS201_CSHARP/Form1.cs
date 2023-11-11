using MindFusion.Charting.WinForms;
using MindFusion.Charting;
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

namespace YFS201_CSHARP
{
    public partial class Form1 : Form
    {

        Timer myTimer = new Timer();
        Random random = new Random();
        MyDateTimeSeries series1;
        string[] ports;
        string data_rev;
        double value_rx;
        string data_tx;
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

            series1 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(2));
            series1.DateTimeFormat = DateTimeFormat.LongTime;
            series1.DateTimeFormat = DateTimeFormat.CustomDateTime;
            series1.CustomDateTimeFormat = "hh:mm:ss";
            //how many values will be added before a time stamp is rendered at the axis
            series1.LabelInterval = 10;
            series1.MinValue = 0;
            series1.MaxValue = 120;

            series1.SupportedLabels = LabelKinds.XAxisLabel;
            // setup chart
            lineChart.Series.Add(series1);
            lineChart.ShowXCoordinates = false;
            lineChart.ShowLegendTitle = false;
            lineChart.LayoutPanel.Margin = new Margins(0, 0, 0, 0);

            lineChart.XAxis.Title = "Time";
            lineChart.XAxis.MinValue = 0;
            lineChart.XAxis.MaxValue = 30;
            lineChart.XAxis.Interval = 5;

            lineChart.YAxis.Title = "Data";
            lineChart.YAxis.MinValue = 0;
            lineChart.YAxis.MaxValue = 120;
            lineChart.YAxis.Interval = 10;

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            // Sets the timer interval to half a seconds.
            myTimer.Interval = 500;
            myTimer.Start();
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            if (serialPort1.IsOpen)
            {
                //double value_rx = random.NextDouble() * 10 + 10;
                series1.addValue(value_rx);

                if (series1.Size > 1)
                {
                    double currVal = series1.GetValue(series1.Size - 1, 0);

                    if (currVal > lineChart.XAxis.MaxValue)
                    {
                        double span = currVal - series1.GetValue(series1.Size - 2, 0);
                        lineChart.XAxis.MinValue += span;
                        lineChart.XAxis.MaxValue += span;
                    }
                    lineChart.ChartPanel.InvalidateLayout();
                }
                label3.Text = value_rx.ToString();
                data_tx = textBox_tx.Text.ToString();
                int max_value = (int)Convert.ToInt32(data_tx.ToString());
                check_data(value_rx, max_value);
                serialPort1.WriteLine(data_tx);
            }
        }
        private void check_data(double value, int max)
        {
            if(value >= max)
            {
                label4.Text = "Warning !!!";
                label4.BackColor = Color.Red;
                label4.Visible = !label4.Visible;
            }
            else
            {
                label4.Text = "Very Good !!!";
                label4.BackColor = Color.Green;
            }
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
            button1.Text = "CONNECT";
            button1.BackColor= Color.Green;
            panel1.Enabled= false;
            panel3.Enabled= false;
            label3.Text = "0";
            textBox_tx.Text = "10";
            label4.Text = "Very Good !!!";
            label4.BackColor= Color.Green;
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
            if (this.label3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                value_rx = ConvertToDouble(text.ToString());
            }
        }
        public static double ConvertToDouble(string Value)
        {
            if (Value == null)
            {
                return 0;
            }
            else
            {
                double OutVal;
                double.TryParse(Value, out OutVal);

                if (double.IsNaN(OutVal) || double.IsInfinity(OutVal))
                {
                    return 0;
                }
                return OutVal;
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Text = "CONNECT";
                button1.BackColor = Color.Green;
                panel1.Enabled = false;
                panel3.Enabled = false;
                panel3.Enabled = false;
                comboBox_baud.Enabled = true;
                comboBox_com.Enabled = true;
                label3.Text = "0";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox_com.Text;
                    serialPort1.BaudRate = (int)Convert.ToInt32(comboBox_baud.Text);
                    serialPort1.Open();
                    button1.Text = "DISCONNECT";
                    button1.BackColor = Color.Red;
                    panel3.Enabled= true;
                    panel1.Enabled = true;
                    panel3.Enabled = true;
                    comboBox_baud.Enabled = false;
                    comboBox_com.Enabled = false;
                }
                catch
                {
                    button1.Text = "DISCONNECT";
                    button1.BackColor = Color.Red;
                }
            }
        }
    }
}
