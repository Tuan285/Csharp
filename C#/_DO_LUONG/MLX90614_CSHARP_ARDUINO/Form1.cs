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

namespace MLX90614_CSHARP_ARDUINO
{
    public partial class Form1 : Form
    {
        String[] ports;
        String data_rev;
        Boolean ambient_obj = false;
        float min_obj, max_obj, min_ambient, max_ambient;
        public Form1()
        {
            InitializeComponent();
            getavaliableComPorts();
            foreach (string port in ports)
            {
                COM.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    COM.SelectedItem = ports[0];
                }
            }

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "37600", "115200" };
            BAUD.Items.AddRange(BaudRate); // Thiet lap cho combobox2
        }
        private void getavaliableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int Index = BAUD.SelectedIndex;
            String[] comlist = SerialPort.GetPortNames();
            int[] ComnumberList = new int[comlist.Length];
            for (int i = 0; i < comlist.Length; i++)
            {
                ComnumberList[i] = int.Parse(comlist[i].Substring(3));
            }
            if(ambient_obj == false)
            {
                BT_AMBIENT.Enabled = true;
                BT_OBJ.Enabled = false;
            }
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            rev_nhietdo_ambient.Value = 0;
            rev_nhietdo_ambient.Text = "0°C";
            rev_nhietdo_obj.Value = 0;
            rev_nhietdo_obj.Text = "0°C";
            textBox_min.Text = "30.15";
            textBox_max.Text = "40.15";
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.rev_nhietdo_ambient.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                String text1, text2;
                text = text.Trim();
                int text_num = text.IndexOf("/");
                if(text_num > 0)
                {
                    text1 = text.Substring(text_num+1);
                    text2 = text.Substring(0, text_num);
                }
                else
                {
                    text1 = text;
                    text2 = text;
                }
                decimal tmp1,tmp2;
                float storeId1 = decimal.TryParse(text1, out tmp1) ? (float)tmp1 : 0;
                float storeId2 = decimal.TryParse(text2, out tmp2) ? (float)tmp2 : 0;
                int ambient = (int)Convert.ToInt32(storeId1);
                int obj = (int)Convert.ToInt32(storeId2);

                this.rev_nhietdo_obj.Text = text2.ToString() + "°C";
                this.rev_nhietdo_obj.Value = obj;

                this.rev_nhietdo_ambient.Text = text1.ToString() + "°C";
                this.rev_nhietdo_ambient.Value = ambient;

                checkTemp_obj(storeId2, min_obj, max_obj);
                checkTemp_ambient(storeId1, min_ambient, max_ambient);
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_rev = serialPort1.ReadLine().ToString();
            SetText(data_rev);
            data_rev = "";
        }
        private void BT_CONNECT_DIS_Click(object sender, EventArgs e)
        {
            if (COM.Text == "")
            {
                MessageBox.Show("Vui Lòng chọn cổng COM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                BT_CONNECT_DIS.Text = "Kết Nối";
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                COM.Enabled = true;
                BAUD.Enabled = true;
                rev_nhietdo_ambient.Value = 0;
                rev_nhietdo_ambient.Text = "0°C";
                rev_nhietdo_obj.Value = 0;
                rev_nhietdo_obj.Text = "0°C";
                label3.Text = "Vui Lòng Kết Nối  !!!";
            }
            else
            {
                try
                {
                    serialPort1.PortName = COM.Text;
                    serialPort1.BaudRate = (int)Convert.ToInt32(BAUD.Text);
                    serialPort1.Open();
                    BT_CONNECT_DIS.Text = "Ngắt Kết Nối";
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    COM.Enabled = false;
                    BAUD.Enabled = false;
                    label3.Text = "Kết Nối Thành Công !!!";
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể mở cổng " + serialPort1.PortName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label4.ForeColor = Color.Blue;
            
            //pictureBox1.Visible = !pictureBox1.Visible;
            //pictureBox2.Show();
        }
        private void BT_COMFIRM_Click(object sender, EventArgs e)
        {
         
            String min_max, min, max;
            decimal tmp1, tmp2;
            min = textBox_min.Text.ToString().Trim();
            max = textBox_max.Text.ToString().Trim();
            if(ambient_obj == false)
            {
                stt_obj1.Show();
                stt_obj.Show();
                min_obj = decimal.TryParse(min, out tmp1) ? (float)tmp1 : 0;
                max_obj = decimal.TryParse(max, out tmp2) ? (float)tmp2 : 0;
                min_max = "obj" + "/" + min + "/" + max;
            }
            else
            {
                stt_ambient1.Show();
                stt_ambient.Show();
                min_ambient = decimal.TryParse(min, out tmp1) ? (float)tmp1 : 0;
                max_ambient = decimal.TryParse(max, out tmp2) ? (float)tmp2 : 0;               
                min_max = "ambient" + "/" + min + "/" + max;
            }
            serialPort1.WriteLine(min_max);
        }
        private async void Blink_obj(int tt)
        {
            while (true)
            {
                await Task.Delay(200);
                stt_obj.BackColor = stt_obj.BackColor == Color.Red ? Color.Green : Color.Red;
                if(tt == 1)
                {
                    break;
                }
            }
        }
        private async void Blink_ambient(int tt)
        {
            while (true)
            {
                await Task.Delay(200);
                stt_ambient.BackColor = stt_ambient.BackColor == Color.Red ? Color.Green : Color.Red;
                if (tt == 1)
                {
                    break;
                }
            }
        }
        private void checkTemp_obj(float temp_obj,  float temp_min_obj, float temp_max_obj)
        {
            
            if (temp_obj > temp_min_obj && temp_obj < temp_max_obj)
            {
                Blink_obj(1);
                stt_obj.Hide();
                stt_obj1.Show();
                stt_obj.Text = "";
                stt_obj1.Text = "Nhiệt độ ổn định";
            }
            if (temp_obj < temp_min_obj)
            {
                Blink_obj(0);
                stt_obj1.Hide();
                stt_obj.Show();
                stt_obj1.Text = "";
                stt_obj.Text = "Nhiệt độ quá thấp";
            }
            if(temp_obj > temp_max_obj)
            {
                Blink_obj(0);
                stt_obj1.Hide();
                stt_obj.Show();
                stt_obj1.Text = "";
                stt_obj.Text = "Nhiệt độ quá cao";
            }
        }
        private void checkTemp_ambient(float temp_ambient, float temp_min_ambient, float temp_max_ambient)
        {
            if (temp_ambient < temp_min_ambient)
            {
                Blink_ambient(0);
                stt_ambient1.Hide();
                stt_ambient.Show();
                stt_ambient1.Text = "";
                stt_ambient.Text = "Nhiệt độ quá thấp";
            }
            if (temp_ambient > temp_min_ambient && temp_ambient < temp_max_ambient)
            {
                Blink_ambient(1);
                stt_ambient.Hide();
                stt_ambient1.Show();
                stt_ambient.Text = "";
                stt_ambient1.Text = "Nhiệt độ ổn định";
            }
            if (temp_ambient > temp_max_ambient)
            {
                Blink_ambient(0);
                stt_ambient1.Hide();
                stt_ambient.Show();
                stt_ambient1.Text = "";
                stt_ambient.Text = "Nhiệt độ quá cao";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ambient_obj = false;
            if(ambient_obj == false)
            {

                BT_AMBIENT.Enabled= true;
                BT_OBJ.Enabled = false;
            }
        }

        private void BT_AMBIENT_Click(object sender, EventArgs e)
        {
            ambient_obj = true;
            if (ambient_obj == true)
            {
                BT_AMBIENT.Enabled = false;
                BT_OBJ.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Rev_nhietdo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    }
}
