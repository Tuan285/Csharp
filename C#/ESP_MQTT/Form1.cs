using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ESP_MQTT
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button_connect.Click += Button_connect_Click;
            button_Disc.Click += Button_Disc_Click;
            //panel_log.Enabled = true;
        }
        static MqttClient mqttClient;
        private void Form1_Load(object sender, EventArgs e)
        {
            reset_data();
            button_connect.Enabled = true;
            button_Disc.Enabled = false;
            panel_esp.Enabled = false;
            panel_sensor1.Enabled = false;
            panel_sensor2.Enabled = false;
        }
        private void Button_Disc_Click(object sender, EventArgs e)
        {
            try
            {
                if (mqttClient.IsConnected)
                {
                    reset_data();
                    mqttClient.Disconnect();
                    button_Disc.Enabled = false;
                    button_connect.Enabled = true;
                    label_status.Text = "Disconnect !";
                    panel_esp.Enabled = false;
                    panel_log.Enabled = true;
                    panel_sensor1.Enabled = false;
                    panel_sensor2.Enabled = false;
                }
            }
            catch { }
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                mqttClient = new MqttClient(
                    textBox_addressMqtt.Text,
                    int.Parse(textBox_Port_Mqtt.Text),
                    false,
                    MqttSslProtocols.None,
                    null,
                    null
                    );
                mqttClient.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte auth = mqttClient.Connect(Guid.NewGuid().ToString(), textBox_user.Text, textBox_pass.Text);
                if (auth == 0)
                {
                    button_Disc.Enabled = true;
                    panel_log.Enabled = false;
                    button_connect.Enabled = false;
                    panel_esp.Enabled = true;
                    panel_sensor1.Enabled = true;
                    panel_sensor2.Enabled = true;
                    label_status.Text = "Connected !!";

                    mqttClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    // subcribe topic
                    mqttClient.Subscribe(
                        new string[] {
                            "MQTT_ESP32_LORA/NODE1/TEMPERATURE",
                            "MQTT_ESP32_LORA/NODE1/HUMIDITY",
                            "MQTT_ESP32_LORA/NODE2/TEMPERATURE",
                            "MQTT_ESP32_LORA/NODE2/HUMIDITY",
                        },
                        new byte[] { 0, 0, 0, 0 });
                    // we need arrays as parameters because we can subscribe to different topics with one call
                    // publish topic
                    mqttClient.Publish("esp/LedControl", Encoding.UTF8.GetBytes("@" + 0));

                }
                else
                {
                    label_status.Text = "Connect Failed !!";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(this, Exception);
            }
        }
        private void reset_data()
        {
            label_value_temp.Text = "";
            circularProgressBar_Temp1.Value = 0;
            label_value_hum1.Text = "";
            circularProgressBar_Humidity1.Value = 0;
            label_value_temp2.Text = "";
            circularProgressBar_Temperature2.Value = 0;
            label_value_hum2.Text = "";
            circularProgressBar_Humidity2.Value = 0;
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
            if (topic == "MQTT_ESP32_LORA/NODE1/TEMPERATURE")
            {
                label_value_temp.Text = message.ToString();
                circularProgressBar_Temp1.Value = (int)float.Parse(message);
            }
            if (topic == "MQTT_ESP32_LORA/NODE1/HUMIDITY")
            {
                label_value_hum1.Text = message.ToString();
                circularProgressBar_Humidity1.Value = (int)float.Parse(message);
            }
            if (topic == "MQTT_ESP32_LORA/NODE2/TEMPERATURE")
            {
                label_value_temp2.Text = message.ToString();
                circularProgressBar_Temperature2.Value = (int)float.Parse(message);
            }
            if (topic == "MQTT_ESP32_LORA/NODE2/HUMIDITY")
            {
                label_value_hum2.Text = message.ToString();
                circularProgressBar_Humidity2.Value = (int)float.Parse(message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            mqttClient.Disconnect();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button_Disc_Click_1(object sender, EventArgs e)
        {
            
        }
        
        private void button_connect_Click(object sender, EventArgs e)
        {
            
        }
        

        private void circularProgressBar_Temp1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label_value_temp_Click(object sender, EventArgs e)
        {

        }

        private void panel_sensor2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label11_Click(object sender, EventArgs e)
        {


        }
    }
}
