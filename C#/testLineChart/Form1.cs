using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testLineChart
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //string t = now.ToLongTimeString();
            double start = (now.AddSeconds(-5)).ToOADate();
            double end = (now.AddSeconds(5)).ToOADate();

            chart1.ChartAreas[0].AxisX.Minimum = start;
            chart1.ChartAreas[0].AxisX.Maximum = end;
            /*
            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(now.AddMinutes(-5));
            chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(now.AddMinutes(0));
            */
            chart1.Series[0].Points.AddXY(start, "10");
            //chart1.Series[0].Points.AddXY(end, "20");
            chart1.Series[0].Points.AddXY(end, "30");
            
        }
    }
}
