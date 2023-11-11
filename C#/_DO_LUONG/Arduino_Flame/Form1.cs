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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Arduino_Flame
{
    public partial class Form1 : Form
    {
        String[] ports;
        String data_rev;
        Boolean tt, tt_click = false;
        Boolean flameDO;
        int SensorFlame;
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_Com.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox_Com.SelectedItem = ports[0];
                }
            }

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "37600", "115200" };
            comboBox_Baud.Items.AddRange(BaudRate); // Thiet lap cho combobox2
            comboBox_Baud.Text = BaudRate[3];
            //timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int Index = comboBox_Baud.SelectedIndex;
            String[] comlist = SerialPort.GetPortNames();
            int[] ComnumberList = new int[comlist.Length];
            for (int i = 0; i < comlist.Length; i++)
            {
                ComnumberList[i] = int.Parse(comlist[i].Substring(3));
            }
            label3.ForeColor = Color.Red;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Text = "0";
            groupBox2.Enabled = false;
            label6.Text = "Đang bật cảnh báo !!";
            label6.ForeColor = Color.Green;
            textBox_value_warning.Text = "600";
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
                String text1, text2;
                text = text.Trim();
                int text_num = text.IndexOf("/");
                if (text_num > 0)
                {
                    text1 = text.Substring(0, text_num);
                    text2 = text.Substring(text_num+1);
                    text1.Trim();
                    text2.Trim();
                }
                else
                {
                    text1 = text;
                    text2 = text;
                    text1.Trim();
                    text2.Trim();
                }
                decimal tmp1;
                float storeId1 = decimal.TryParse(text2, out tmp1) ? (float)tmp1 : 0;
                SensorFlame = (int)Convert.ToInt32(storeId1);
                this.circularProgressBar1.Text = text2;
                this.circularProgressBar1.Value = SensorFlame;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SetText("");
            data_rev = serialPort1.ReadLine().ToString();
            SetText(data_rev);
            data_rev = "";
        }
        private void button_KetNoi_Click(object sender, EventArgs e)
        {
            if (comboBox_Com.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button_KetNoi.Text = "Kết Nối";
                label3.Text = "Vui Lòng Kết Nối !";
                label3.ForeColor = Color.Red;
                circularProgressBar1.Text = "0";
                circularProgressBar1.Value = 0;
                groupBox2.Enabled = false;
                tt_click = false;
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBox_Com.Text;
                    serialPort1.BaudRate = (int)Convert.ToInt32(comboBox_Baud.Text);
                    serialPort1.Open();
                    
                    button_KetNoi.Text = "Ngắt Kết Nối";
                    label3.Text = "Kết Nối Thành Công !";
                    label3.ForeColor = Color.Green;
                    groupBox2.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể mở cổng " + serialPort1.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            String data_textbox;
            label5.Text = DateTime.Now.ToLongTimeString();
            label5.ForeColor = Color.Blue;           
            if (serialPort1.IsOpen)
            {
                data_textbox = textBox_value_warning.Text.ToString();
                String data_rx = tt_click.ToString().Trim() + "/" + data_textbox;
                serialPort1.WriteLine(data_rx);
            }
            int max_value = (int)Convert.ToInt32(textBox_value_warning.Text.ToString());
            check(SensorFlame, max_value);
        }
        private void check(int value, int max)
        {
            if ( value >= max && tt_click == false && serialPort1.IsOpen)
            {
                //pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox1.Visible = !pictureBox1.Visible;
            }
            else
            {
                pictureBox2.Show();
                pictureBox1.Hide();
            }
        }
        private void button_on_off_warning_Click(object sender, EventArgs e)
        {
            tt_click = !tt_click;
            if (tt_click == false)
            {
                button_on_off_warning.Text = "WARING OFF";
                label6.Text = "Đang bật cảnh báo !!";
                label6.ForeColor = Color.Green;
            }
            else
            {
                button_on_off_warning.Text = "WARING ON";
                label6.Text = "Đang tắt cảnh báo !!";
                label6.ForeColor = Color.Red;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
