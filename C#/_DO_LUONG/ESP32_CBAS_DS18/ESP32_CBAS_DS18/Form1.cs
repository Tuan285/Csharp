using DevExpress.Data.Browsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Color = System.Drawing.Color;

namespace ESP32_CBAS_DS18
{
    public partial class Form1 : Form
    {
        int ttTime;
        static MqttClient mqttClient;

        float DataTemp, DataLux, DataGas, DataHumidity;

        int minTemp, maxTemp;
        int minHumi, maxHumi;
        int minLux, maxLux;
        int minGas, maxGas;
        public Form1()
        {
            InitializeComponent();
            connectMQTT();

            string[] minLux = { "10", "20", "30", "40", "50", "60", "70", "80" };
            string[] maxLux = { "20", "30", "40", "50", "60", "70", "80", "90" };

            string[] minTemp = { "10", "20", "30", "40", "50", "60", "70", "80" };
            string[] maxTemp = { "20", "30", "40", "50", "60", "70", "80", "90" };

            string[] minHumi = { "10", "20", "30", "40", "50", "60", "70", "80" };
            string[] maxHumi = { "20", "30", "40", "50", "60", "70", "80", "90" };

            string[] minGas = { "10", "20", "30", "40" , "50", "60", "70", "80" };
            string[] maxGas = { "20", "30", "40", "50" , "60", "70", "80" , "90"};

            comboBoxMinTemp.Items.AddRange(minTemp);
            comboBoxMaxTemp.Items.AddRange(maxTemp);

            comboBoxMinLux.Items.AddRange(minLux);
            comboBoxMaxLux.Items.AddRange(maxLux);

            comboBoxMinHumi.Items.AddRange(minLux);
            comboBoxMaxHumi.Items.AddRange(maxLux);

            comboBoxMinGas.Items.AddRange(minLux);
            comboBoxMaxGas.Items.AddRange(maxLux);

            /*
            comboBoxMinLux.Text = minLux[0];
            comboBoxMaxLux.Text = maxLux[2];

            comboBoxMinTemp.Text = minTemp[0];
            comboBoxMaxTemp.Text = maxTemp[2];

            comboBoxMinHumi.Text = minHumi[0];
            comboBoxMaxHumi.Text = maxHumi[2];

            comboBoxMinGas.Text = minGas[0];
            comboBoxMaxGas.Text = maxGas[2];
            */
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            // this sets the type of the X-Axis values
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.Title = "TIME";
            chart1.ChartAreas[0].AxisY.Title = "DATA";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font(chart1.ChartAreas[0].AxisX.TitleFont.FontFamily, 12f);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font(chart1.ChartAreas[0].AxisY.TitleFont.FontFamily, 12f);
            chart1.Series[0].LegendText = "Temperature"; 
            chart1.Series[1].LegendText = "Lux";
            chart1.Series[2].LegendText = "Gas";
            chart1.Series[3].LegendText = "Humidity";
            timer1.Start();
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
        float humi_s;
        void Receive(string message, string topic)
        {
            if (topic == "TEMPC")
            {
                tempC.Text = message.ToString();
                DataTemp = (int)float.Parse(message.ToString()) / 100;
            }
            else if (topic == "LUX")
            {
                lux.Text = message.ToString();
                DataLux = (int)float.Parse(message.ToString());

            }
            if (topic == "GAS")
            {
                GAS.Text = message.ToString();
                DataGas = (int)float.Parse(message.ToString());
            }
            else if (topic == "HUMIDITY")
            {
                HUMI.Text = message.ToString();
                if (message == "nan")
                {
                    DataHumidity = humi_s;
                }
                else
                {
                    
                    DataHumidity = (int)float.Parse(message.ToString()) / 100;
                    humi_s = DataHumidity;
                }
            }
            else if (topic == "AUTO")
            {
                int auto = Int16.Parse(message);
                if(auto == 1)
                {
                    onOffAuto = true;
                }else if(auto == 0)
                {
                    onOffAuto = false;
                }
            }
            else if (topic == "LIGHT")
            {
                int light = Int16.Parse(message);
                if (light == 1)
                {
                    onOffRelay = true;
                }
                else if (light == 0)
                {
                    onOffRelay = false;
                }
            }
            else if (topic == "MINTEMP")
            {
                minTemp = Int16.Parse(message);
                comboBoxMinTemp.Text = message.ToString();
            }
            else if (topic == "MAXTEMP")
            {
                maxTemp = Int16.Parse(message);
                comboBoxMaxTemp.Text = message.ToString();
            }
            else if (topic == "MINLUX")
            {
                minLux = Int16.Parse(message);
                comboBoxMinLux.Text = message.ToString();
            }
            else if (topic == "MAXLUX")
            {
                maxLux = Int16.Parse(message);
                comboBoxMaxLux.Text = message.ToString();
            }
            else if (topic == "MINHUMI")
            {
                minHumi = Int16.Parse(message);
                comboBoxMinHumi.Text = message.ToString();
            }
            else if (topic == "MAXHUMI")
            {
                maxHumi = Int16.Parse(message);
                comboBoxMaxHumi.Text = message.ToString();
            }
            else if (topic == "MINGAS")
            {
                minGas = Int16.Parse(message);
                comboBoxMinGas.Text = message.ToString();
            }
            else if (topic == "MAXGAS")
            {
                maxGas = Int16.Parse(message);
                comboBoxMaxGas.Text = message.ToString();
            }
        }
        private void connectMQTT()
        {
            try
            {
                mqttClient = new MqttClient("test.mosquitto.org", 1883, false, MqttSslProtocols.None, null, null);
                mqttClient.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                mqttClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                byte auth = mqttClient.Connect(Guid.NewGuid().ToString());
                if (auth == 0)
                {
                    mqttClient.Subscribe(new string[] { "LIGHT" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "AUTO" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                    mqttClient.Subscribe(new string[] { "GAS" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINGAS" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXGAS" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                    mqttClient.Subscribe(new string[] { "HUMIDITY" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINHUMIDITY" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXHUMIDITY`" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                    mqttClient.Subscribe(new string[] { "TEMPC" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINTEMPC" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXTEMPC" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                    mqttClient.Subscribe(new string[] { "LUX" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MINLUX" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttClient.Subscribe(new string[] { "MAXLUX" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                }
                
                if (mqttClient.IsConnected)
                {
                    statusMQTT.Text = "CONNECTED !";
                    statusMQTT.ForeColor = Color.Green;
                    panel4.Show();
                    //panel4.Hide();
                    
                }
                else if (!mqttClient.IsConnected)
                {
                    statusMQTT.Text = "NO CONNECTED !";
                    statusMQTT.ForeColor = Color.Red;
                }
                
            }
            catch 
            {
                statusMQTT.Text = "NO CONNECTED !";
                statusMQTT.ForeColor = Color.Red;
            }

        }

        int i = 0;
        List<DateTime> TimeList = new List<DateTime>();
        List<double> DataListTemp = new List<double>();
        List<double> DataListLux = new List<double>();
        List<double> DataListGas = new List<double>();
        List<double> DataListHumidity = new List<double>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttTime++;
            if (ttTime == 2)
            {
                timer1.Interval = 500;
            }
            DateTime now = DateTime.Now;
            TimeList.Add(now);
            Random random = new Random();
            DataListTemp.Add(DataTemp);
            DataListLux.Add(DataLux);
            DataListGas.Add(DataGas);
            DataListHumidity.Add(DataHumidity);
            // Giới hạn số lượng điểm dữ liệu trên biểu đồ
            int maxDataPoints = 50;
            if (chart1.Series[0].Points.Count > maxDataPoints 
                || chart1.Series[1].Points.Count > maxDataPoints 
                || chart1.Series[2].Points.Count > maxDataPoints 
                || chart1.Series[3].Points.Count > maxDataPoints)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Series[2].Points.RemoveAt(0);
                chart1.Series[3].Points.RemoveAt(0);
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            // Thêm lại các điểm dữ liệu trong khoảng 30 giây gần nhất
            int startIndex = Math.Max(0, TimeList.Count - maxDataPoints);
            for (int j = startIndex; j < TimeList.Count; j++)
            {
                chart1.Series[0].Points.AddXY(TimeList[j], DataListTemp[j]);
                chart1.Series[1].Points.AddXY(TimeList[j], DataListLux[j]);
                chart1.Series[2].Points.AddXY(TimeList[j], DataListGas[j]);
                chart1.Series[3].Points.AddXY(TimeList[j], DataListHumidity[j]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mqttClient.IsConnected)
            {
                mqttClient.Disconnect();
            }
            Application.Exit();
        }
        bool onOffRelay = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (onOffRelay == true)
            {
                mqttClient.Publish("LIGHT", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                onOffRelay = false;
            }
            else if (onOffRelay == false)
            {
                mqttClient.Publish("LIGHT", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                onOffRelay = true;
            }
        }

        bool onOffAuto = true;

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (onOffAuto == true)
            {
                mqttClient.Publish("AUTO", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                onOffAuto = false;
            }
            else if (onOffAuto == false)
            {
                mqttClient.Publish("AUTO", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                onOffAuto = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINHUMI", Encoding.UTF8.GetBytes(comboBoxMinHumi.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXHUMI", Encoding.UTF8.GetBytes(comboBoxMaxHumi.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINGAS", Encoding.UTF8.GetBytes(comboBoxMinGas.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXGAS", Encoding.UTF8.GetBytes(comboBoxMaxGas.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINTEMPC", Encoding.UTF8.GetBytes(comboBoxMinTemp.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXTEMPC", Encoding.UTF8.GetBytes(comboBoxMaxTemp.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mqttClient.Publish("MINLUX", Encoding.UTF8.GetBytes(comboBoxMinLux.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            mqttClient.Publish("MAXLUX", Encoding.UTF8.GetBytes(comboBoxMaxLux.Text.ToString()), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss");
            if (mqttClient.IsConnected)
            {
                if (onOffAuto == true)
                {
                    panel4.Enabled = false;
                    panel2.Enabled = true;
                    Bitmap auto = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-on.png");
                    pictureBox3.Image = (Image)auto;
                }
                else if (onOffAuto == false)
                {
                    panel4.Enabled = true;
                    panel2.Enabled = false;
                    Bitmap auto = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-off.png");
                    pictureBox3.Image = (Image)auto;
                }
                if (onOffRelay == true)
                {
                    Bitmap light = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\idea-bulbon.png");
                    Bitmap button = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-on.png");
                    pictureBox1.Image = (Image)light;
                    pictureBox2.Image = (Image)button;
                }
                else if (onOffRelay == false)
                {
                    Bitmap light = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\idea-bulboff.png");
                    Bitmap button = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-off.png");
                    pictureBox1.Image = (Image)light;
                    pictureBox2.Image = (Image)button;
                }
                if (onOffRelay == true)
                {
                    Bitmap light = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\idea-bulbon.png");
                    Bitmap button = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-on.png");
                    pictureBox1.Image = (Image)light;
                    pictureBox2.Image = (Image)button;

                }
                else if (onOffRelay == false)
                {
                    Bitmap light = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\idea-bulboff.png");
                    Bitmap button = new Bitmap("D:\\C#\\_DO_LUONG\\ESP32_CBAS_DS18\\switch-off.png");
                    pictureBox1.Image = (Image)light;
                    pictureBox2.Image = (Image)button;
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void statusMQTT_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}