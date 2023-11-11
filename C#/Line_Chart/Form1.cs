using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisY.Minimum = -50;
            objChart.AxisY.Maximum = 50;

            chart1.Series.Clear();

            Random random= new Random();

            foreach (CLASS_CHART t in cLASSCHARTBindingSource.DataSource as List<CLASS_CHART>)
            {
                chart1.Series.Add(t.Lacation);
                chart1.Series[t.Lacation].Color= Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[t.Lacation].Legend = "Legend1";
                chart1.Series[t.Lacation].ChartArea = "ChartArea1";
                chart1.Series[t.Lacation].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i  = 1; i <= 12; i++)
                {
                    chart1.Series[t.Lacation].Points.AddXY(i, Convert.ToInt32(t[$"M{i}"]));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cLASSCHARTBindingSource.DataSource= new List<CLASS_CHART>();
        }
    }
}
