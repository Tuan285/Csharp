using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Brush = MindFusion.Drawing.Brush;
using SolidBrush = MindFusion.Drawing.SolidBrush;
using MindFusion.Charting;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ESP8266_CSHARP_SOIL_SENSOR
{

    public partial class Form1 : Form
    {
        Timer myTimer = new Timer();
        Random random = new Random();
        MyDateTimeSeries series1, series2;

        float temp, soil, temp2, soil2;
        float minTemp, maxTemp;
        float minSoil, maxSoil;

        Boolean enableData;
        static MqttClient mqttClient;
        string clientID;
        Boolean checkConnectMQTT;

        int buttonManual = 0, buttonMotor = 0;
        public Form1()
        {
            InitializeComponent();

            label3.Text = "DISCONNECT !!!";
            label3.ForeColor = Color.Red;

            connect.Enabled = true;
            disconnect.Enabled = false;
            panel4.Enabled = false;
            panel6.Enabled = false;
            manual.Text = "ON";
            manual.BackColor = Color.Green;

            motor.Text = "ON";
            motor.BackColor = Color.Green;
            timer1.Enabled = true;
            enableData = false;
            checkConnectMQTT = false;
            initChart();

        }
        void initChart()
        {
            ObservableCollection<Series> data = new ObservableCollection<Series>();

            //lineChart.LicenseKey = "license key stays here";

            series1 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series1.DateTimeFormat = DateTimeFormat.LongTime;
            series1.DateTimeFormat = DateTimeFormat.CustomDateTime;
            series1.CustomDateTimeFormat = "hh:mm:ss";
            //how many values will be added before a time stamp is rendered at the axis
            series1.LabelInterval = 10;
            series1.MinValue = 0;
            series1.MaxValue = 120;
            series1.Title = "TEMPERATURE";
            series1.SupportedLabels = LabelKinds.XAxisLabel;

            series2 = new MyDateTimeSeries(DateTime.Now, DateTime.Now, DateTime.Now.AddMinutes(1));
            series2.DateTimeFormat = DateTimeFormat.LongTime;
            series2.LabelInterval = 10;
            series2.MinValue = 0;
            series2.MaxValue = 120;
            series2.Title = "SOIL";
            series2.SupportedLabels = LabelKinds.None;


            // setup chart
            lineChart.Series.Add(series1);
            lineChart.Series.Add(series2);
            lineChart.Title = "GROUP 1";
            lineChart.ShowXCoordinates = false;
            lineChart.ShowLegendTitle = false;
            lineChart.LayoutPanel.Margin = new Margins(0, 0, 20, 0);

            lineChart.XAxis.Title = "";
            lineChart.XAxis.MinValue = 0;
            lineChart.XAxis.MaxValue = 120;
            lineChart.XAxis.Interval = 10;
            lineChart.YAxis.Title = "Time";

            lineChart.YAxis.MinValue = 0;
            lineChart.YAxis.MaxValue = 150;
            lineChart.YAxis.Interval = 10;
            lineChart.YAxis.Title = "Data";

            List<Brush> brushes = new List<Brush>()
            {
                new SolidBrush(Color.BlueViolet),
                new SolidBrush(Color.Red),
            };

            List<double> thicknesses = new List<double>() { 2 };

            PerSeriesStyle style = new PerSeriesStyle(brushes, brushes, thicknesses, null);
            lineChart.Plot.SeriesStyle = style;
            lineChart.Theme.PlotBackground = new SolidBrush(Color.White);
            lineChart.Theme.GridLineColor = Color.LightGray;
            lineChart.Theme.GridLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            lineChart.TitleMargin = new Margins(10);
            lineChart.GridType = GridType.Horizontal;
        }


        Action<string, string> ReceiveAction;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }
        void Receive(string message, string topic)
        {
            if (topic == "TEMPERATURE")
            {
                labelNhietdo.Text = message.ToString();
                temp = (int)float.Parse(message) / 100;
                temp2 = (int)float.Parse(message) /10;
            }
            else if (topic == "SOIL")
            {
                labelSoil.Text = message.ToString();
                soil = (int)float.Parse(message) / 100;
                soil2 = (int)float.Parse(message) / 10;
            }
            else if (topic == "MANUAL")
            {
                buttonManual = Int32.Parse(message);
                if (buttonManual == 0)
                {
                    panel5.Show();
                    manual.Text = "ON";
                    manual.BackColor = Color.Green;

                }
                else if (buttonManual == 1)
                {
                    panel5.Hide();
                    manual.Text = "OFF";
                    manual.BackColor = Color.Red;

                }
            }
            else if (topic == "CONTROL")
            {
                buttonMotor = Int32.Parse(message);
                if (buttonMotor == 0)
                {
                    motor.Text = "ON";
                    motor.BackColor = Color.Green;

                }
                else if (buttonMotor == 1)
                {
                    motor.Text = "OFF";
                    motor.BackColor = Color.Red;

                }
            }
            else if (topic == "MINTEMP")
            {
                minTemp = (int)float.Parse(message);
                textBoxMINTEMP.Text = minTemp.ToString();
            }
            else if (topic == "MAXTEMP")
            {
                maxTemp = (int)float.Parse(message);
                textBoxMAXTEMP.Text = maxTemp.ToString();
            }
            else if (topic == "MINSOIL")
            {
                minSoil = (int)float.Parse(message);
                textBoxMINSOIL.Text = minSoil.ToString();
            }
            else if (topic == "MAXSOIL")
            {
                maxSoil = (int)float.Parse(message);
                textBoxMAXSOIL.Text = maxSoil.ToString();
            }
        }
        void connectMQTT()
        {
            try
            {


                mqttClient = new MqttClient("test.mosquitto.org", 1883, false, MqttSslProtocols.None, null, null);
                mqttClient.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                mqttClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                byte auth = mqttClient.Connect(Guid.NewGuid().ToString());
                if (auth == 0)
                {
                    mqttClient.Subscribe(new string[] { "TEMPERATURE" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "SOIL" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "CONTROL" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MANUAL" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINTEMP" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXTEMP" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINSOIL" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXSOIL" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                }
                if (mqttClient.IsConnected)
                {
                    checkConnectMQTT = true;
                    enableData = true;
                    label3.Text = "CONNECT !!!";
                    label3.ForeColor = Color.Green;
                    connect.Enabled = false;
                    disconnect.Enabled = true;
                    panel4.Enabled = true;
                    panel6.Enabled = true;
                }
            }
            catch
            {
                label3.Text = "DISCONNECT !!!";
                label3.ForeColor = Color.Green;
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                mqttClient.Disconnect();
                enableData = false;
                label3.Text = "DISCONNECT !!!";
                label3.ForeColor = Color.Red;
                connect.Enabled = true;
                disconnect.Enabled = false;
                panel4.Enabled = false;
                panel6.Enabled = false;
                checkConnectMQTT = false;
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connectMQTT();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (enableData == true)
            {
                series1.addValue(temp);

                series2.addValue(soil);

            }
            else
            {
                double val = 0;
                series1.addValue(val);

                val = 0;
                series2.addValue(val);
            }
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
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            

            if (checkConnectMQTT == true)
            {
                if (buttonManual == 1)
                {
                    panel6.Enabled = true;
                    
                }
                else if (buttonManual == 0)
                {
                    panel6.Enabled = false;
                    
                }
                Boolean tempError, soilError;
                minTemp = (int)float.Parse(textBoxMINTEMP.Text.ToString());
                maxTemp = (int)float.Parse(textBoxMAXTEMP.Text.ToString());
                tempError = checkData(temp2, minTemp, maxTemp);


                minSoil = (int)float.Parse(textBoxMINSOIL.Text.ToString());
                maxSoil = (int)float.Parse(textBoxMAXSOIL.Text.ToString());
                soilError = checkData(soil2, minSoil, maxSoil);

                if (tempError == true)
                {
                    statusTemp.Text = "WARNING !!";
                    statusTemp.ForeColor = statusTemp.ForeColor == Color.Red ? Color.Green : Color.Red;
                }
                else if (tempError == false)
                {
                    statusTemp.Text = "NORMAL !!";
                    statusTemp.ForeColor = Color.Green;
                }

                if (soilError == true)
                {
                    statusSoil.Text = "WARNING !!";
                    statusSoil.ForeColor = statusSoil.ForeColor == Color.Red ? Color.Green : Color.Red;
                }
                else if (soilError == false)
                {
                    statusSoil.Text = "NORMAL !!";
                    statusSoil.ForeColor = Color.Green;
                }


                if (buttonMotor == 0)
                {
                    motor.Text = "ON";
                    motor.BackColor = Color.Green;
                    
                }
                else if (buttonMotor == 1)
                {
                    motor.Text = "OFF";
                    motor.BackColor = Color.Red;
                    
                }

                if (buttonManual == 0)
                {
                    panel5.Show();
                    manual.Text = "ON";
                    manual.BackColor = Color.Green;
                    
                }
                else if (buttonManual == 1)
                {
                    panel5.Hide();
                    manual.Text = "OFF";
                    manual.BackColor = Color.Red;
                    
                }
            }
        }

        
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (buttonManual == 1)
            {
                mqttClient.Publish("MANUAL", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                buttonManual = 0;
            } else if (buttonManual == 0)
            {
                mqttClient.Publish("MANUAL", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                buttonManual = 1;
            }


        }
        
        private void motor_Click(object sender, EventArgs e)
        {
            if (buttonMotor == 1)
            {
                mqttClient.Publish("CONTROL", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                buttonMotor = 0;
            }
            else if (buttonMotor == 0)
            {
                mqttClient.Publish("CONTROL", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                buttonMotor = 1;
            }

        }

        Boolean checkData(float value, float min, float max)
        {
            Boolean error;
            if (value < min || value > max)
            {

                error = true;
            }
            else
            {
                error = false;
            }
            return error;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINSOIL", Encoding.UTF8.GetBytes(textBoxMINSOIL.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXSOIL", Encoding.UTF8.GetBytes(textBoxMAXSOIL.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }
        private void comfirmTemp_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINTEMP", Encoding.UTF8.GetBytes(textBoxMINTEMP.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXTEMP", Encoding.UTF8.GetBytes(textBoxMAXTEMP.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }
        private void lineChart1_DataItemClicked(object sender, MindFusion.Charting.HitResult e)
        {

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) 
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
