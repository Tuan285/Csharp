using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChart
{
    public partial class Form1 : Form
    {
        private ChartValues<double> dataValues;
        private ChartValues<DateTime> timeValues;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu cho biểu đồ
            dataValues = new ChartValues<double>();
            timeValues = new ChartValues<DateTime>();

            // Thiết lập loại giá trị trục X là DateTime
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Thời gian",
                Labels = new string[] { },
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),

                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            // Thiết lập giá trị trục Y
            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            // Gán dữ liệu cho biểu đồ
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Dữ liệu",
                    Values = dataValues,
                    PointGeometrySize = 0,
                    

                }
            };
            cartesianChart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));

            // Khởi động timer để cập nhật dữ liệu
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            double dataValue = random.Next(0,30);
            DateTime currentTime = DateTime.Now;

            dataValues.Add(dataValue);
            timeValues.Add(currentTime);

            // Limit the number of data points on the chart
            const int maxDataPoints = 10;
            if (dataValues.Count > maxDataPoints)
            {
                dataValues.RemoveAt(0);
                timeValues.RemoveAt(0);
            }

            // Update the labels on the X-axis
            string[] labels = new string[timeValues.Count];
            for (int j = 0; j < timeValues.Count; j++)
            {
                labels[j] = timeValues[j].ToString("HH:mm");
            }
            cartesianChart1.AxisX[0].Labels = labels;

            // Update the chart
            cartesianChart1.Update();

            i += 2;

        }
    }
}
