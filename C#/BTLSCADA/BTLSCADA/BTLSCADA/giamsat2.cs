using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLSCADA
{
    public partial class giamsat2 : Form
    {
        int stateLed, stateBomOxi, stateLocNuoc;
        string COMStr = "COM7";
        string modeLed = "A", modeBomOxi = "A", modeLocNuoc = "A";
        string[] uploc = { "6h/18h", "6h/10h/14h/18h", "6h/8h/10h/14h/16h/18h", "4h/6h/8h/10h/14h/16h/18h/20h" };
        string[] upoxi = { "6-8h", "6-8h / 18-20h", "6-8h / 12-14h / 18-20h", "6-8h / 12-14h / 18-20h / 21-23h" };
        public giamsat2()
        {
            InitializeComponent();
            
            cbooxi.Items.AddRange(upoxi);
            cbooxi.Text = upoxi[0];
            
            cboloc.Items.AddRange(uploc);
            cboloc.Text = "6h/18h";
            
        }
        private void butpage1_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            this.Hide();
            giamsat1 f = new giamsat1();
            f.ShowDialog();
            f = null;
            this.Show();
            
        }

        private void butpage3_Click(object sender, EventArgs e)
        {
            this.Hide();
            giamsat3 f = new giamsat3();
            f.ShowDialog();
            f = null;
            this.Show();
        }
        private void serCOM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        //led
        private void butLed_on_Click(object sender, EventArgs e)
        {
            stateLed = 1;
            if (serCOM.IsOpen)
            {
                string data = "L/" + modeLed + "/" + stateLed.ToString() + "\n";
                serCOM.Write(data);
            }
        }

        private void butLed_off_Click(object sender, EventArgs e)
        {
            stateLed = 0;
            if (serCOM.IsOpen)
            {
                string data = "L/" + modeLed + "/" + stateLed.ToString() + "\n";
                serCOM.Write(data);
            }
        }
        bool  onoffAutoLed = true;
        private void butLed_auto_Click(object sender, EventArgs e)
        {
            
            if(onoffAutoLed  == false)
            {
                modeLed = "A";
                onoffAutoLed = true;
                butLed_on.Enabled = false;
                butLed_off.Enabled = false;

                txtledoff_up.Enabled = true;
                txtledon_up.Enabled = true;
            }
            else
            { 
                butLed_on.Enabled = true;
                butLed_off.Enabled = true;

                txtledoff_up.Enabled = false;
                txtledon_up.Enabled = false;
                modeLed = "M";
                onoffAutoLed = false;
            }
            
        }
        private void txtledon_up_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtledoff_up_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void butLed_up_Click(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)
            {
                if (modeLed == "M")
                {
                    string data = "L/" + modeLed +"/" + stateLed.ToString() + "\n";
                    serCOM.Write(data);
                }else
                {
                    string begin = txtledon_up.Text.ToString();
                    string end = txtledoff_up.Text.ToString();
                    string data = "L/" + modeLed + "/" + begin + "/" + end + "\n";
                    serCOM.Write(data);
                }
            }  
        }
    //bơm oxi
        private void butoxi_on_Click(object sender, EventArgs e)
        {
            stateBomOxi = 1;
            if (serCOM.IsOpen)
            {
                string data = "B/" + modeBomOxi + "/" + stateBomOxi.ToString() + "\n";
                serCOM.Write(data);
            }
        }

        private void butoxi_off_Click(object sender, EventArgs e)
        {
            stateBomOxi = 0;
            if (serCOM.IsOpen)
            {
                string data = "B/" + modeBomOxi + "/" + stateBomOxi.ToString() + "\n";
                serCOM.Write(data);
            }
        }
        bool onoffAutoOxi = true;
        private void butoxi_auto_Click(object sender, EventArgs e)
        {
            if(onoffAutoOxi == false)
            {
                modeBomOxi = "A";
                onoffAutoOxi = true;
                
                cbooxi.Enabled  = true;
                butoxi_off.Enabled = false;
                butoxi_on.Enabled = false;
            }
            else
            {
                modeBomOxi = "M";
                cbooxi.Enabled = false;
                butoxi_off.Enabled = true;
                butoxi_on.Enabled = true;
                onoffAutoOxi = false;
            }
        }

        private void cbooxi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        string timeBomoxi;
        private void butoxi_up_Click(object sender, EventArgs e)
        {
            
            if (serCOM.IsOpen)
            {
                if (modeLed == "M")
                {
                    string data = "B/" + modeBomOxi + "/" + stateBomOxi.ToString() + "\n";
                    serCOM.Write(data);
                }
                else
                {
                    for(int i = 0;i < 4; i++)
                    {
                        if(cbooxi.Text == upoxi[i])
                        {
                            timeBomoxi = i.ToString();
                        }
                    }
                    string data = "B/" + modeBomOxi + "/" + timeBomoxi + "\n";
                    serCOM.Write(data);
                }
            }
        }
    //máy lọc
        private void butloc_on_Click(object sender, EventArgs e)
        {
            stateLocNuoc = 1;
            if (serCOM.IsOpen)
            {
                string data = "N/" + modeLocNuoc + "/" + stateLocNuoc.ToString() + "\n";
                serCOM.Write(data);
            }
        }

        private void butloc_off_Click(object sender, EventArgs e)
        {
            stateLocNuoc = 0;
            if (serCOM.IsOpen)
            {
                string data = "N/" + modeLocNuoc + "/" + stateLocNuoc.ToString() + "\n";
                serCOM.Write(data);
            }
        }

        bool onoffAutoLoc = true;

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void giamsat2_Load(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {

                serCOM.PortName = COMStr;;
                serCOM.BaudRate = Convert.ToInt32(9600);
                serCOM.Open();
            }
            else
            {
                serCOM.Close();
            }
        }

        private void butloc_auto_Click(object sender, EventArgs e)
        {
            if (onoffAutoLoc == false)
            {
                modeLocNuoc = "A";
                onoffAutoLoc = true;

                cboloc.Enabled = true;
                butloc_off.Enabled = false;
                butloc_on.Enabled = false;
            }
            else
            {
                modeLocNuoc = "M";
                cboloc.Enabled = false;
                butloc_off.Enabled = true;
                butloc_on.Enabled = true;
                onoffAutoLoc = false;
            }
        }

        private void cboloc_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }
        string timeLocNuoc;
        private void butloc_up_Click(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)
            {
                if (modeLed == "M")
                {
                    string data = "N/" + modeLocNuoc + "/" + stateLocNuoc.ToString() + "\n";
                    serCOM.Write(data);
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (cboloc.Text == uploc[i])
                        {
                            timeLocNuoc = i.ToString();
                        }
                    }
                    string data = "N/" + modeLocNuoc + "/" + timeLocNuoc + "\n";
                    serCOM.Write(data);
                }
            }
        }

        
    }
}
