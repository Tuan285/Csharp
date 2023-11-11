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

namespace MQTT_TEST
{
    public partial class Form1 : Form
    {
        MqttClient client;
        string clientId;
        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "test.mosquitto.org";

            client = new MqttClient(BrokerAddress);

            // register a callback-function (we have to implement, see below) which is called by the library when a message was received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            // use a unique id as client id, each time we start the application
            clientId = Guid.NewGuid().ToString();

            client.Connect(clientId);
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);

            textBox_receiv.Invoke((MethodInvoker)(() => textBox_receiv.Text = ReceivedMessage));
        }
        private void sen_Click(object sender, EventArgs e)
        {
            if (textBox_topic_sub.Text != "")
            {
                // whole topic
                string Topic = "/test1";

                // subscribe to the topic with QoS 2
                client.Subscribe(new string[] { Topic }, new byte[] { 0 });   // we need arrays as parameters because we can subscribe to different topics with one call
                textBox_receiv.Text = "";
            }
            else
            {
                //System.Windows.MessageBox.Show("You have to enter a topic to subscribe!");
            }
        }

        private void receive_Click(object sender, EventArgs e)
        {
            if (textBox_topic_pub.Text != "")
            {
                // whole topic
                string Topic = "/test1";

                // publish a message with QoS 2
                client.Publish(Topic, Encoding.UTF8.GetBytes(textBox_topic_pub.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
            else
            {
                //System.Windows.MessageBox.Show("You have to enter a topic to publish!");
            }
        }

        private void textBox_topic_pub_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
