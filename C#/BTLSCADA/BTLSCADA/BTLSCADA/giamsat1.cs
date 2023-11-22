using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace BTLSCADA
{
    public partial class giamsat1 : Form
    {
        string COMStr = "COM7";
        public bool isThoat = true;
        String dataReceive;
        int tempCdata;
        int nhietdoThap, nhietdoCao;
        string[] luongthucan = { "Ít", "Vừa", "Nhiều" };
        String tempC_str, canhBaoThucAn;
        public giamsat1()
        {
            InitializeComponent();

            
            cboluongthucan.Items.AddRange(luongthucan);
            cboluongthucan.Text = "Vừa";

            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            chart1.ChartAreas[0].AxisY.Maximum = 50;
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.Title = "TIME";
            chart1.ChartAreas[0].AxisY.Title = "TEMPERATURE";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font(chart1.ChartAreas[0].AxisX.TitleFont.FontFamily, 12f);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font(chart1.ChartAreas[0].AxisY.TitleFont.FontFamily, 12f);
            chart1.Series[0].LegendText = "TEMPERATURE";
            timer1.Start();

            

        }
        private void giamsat1_Load(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                serCOM.PortName = COMStr ;
                serCOM.BaudRate = Convert.ToInt32(9600);

                serCOM.Open();
            }
            else
            {
                serCOM.Close();
            }
        }
        public event EventHandler dangxuat;
        private void butdangxuat_Click(object sender, EventArgs e)
        {
            dangxuat(this, new EventArgs());            
        }

        private void giamsat1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            this.Hide();
            giamsat2 f = new giamsat2();
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

        private void butConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            serCOM.Close();
        }

        delegate void SetTextCallback(string text);

        private void Print_Text(string text)
        {
            if (this.chart1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Print_Text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                
                text = text.Trim();
                string[] text_num = text.Split('/');
                tempC_str = text_num[0].ToString();
                canhBaoThucAn = text_num[1].ToString();

                decimal tmp1;
                float store_Valuex = decimal.TryParse(tempC_str, out tmp1) ? (float)tmp1 : 0;
                
                tempCdata = (int)Convert.ToInt32(store_Valuex);
                txtTemp.Text = tempC_str;

                nhietdoThap = (int)Convert.ToInt32(txtnhietdothap_up.Text);
                nhietdoCao = (int)Convert.ToInt32(txtnhietdocao_up.Text);
                if (canhBaoThucAn == "1")
                {
                    txtthucan_hienthi.Text = "Hết Thức Ăn";
                }else
                {
                    txtthucan_hienthi.Text = "Còn Thức Ăn";
                }

                if(tempCdata < nhietdoThap)
                {
                    label15.Text = "Nhiệt Độ Thấp";
                    lbtrangthai.Text = "Bật Máy Sưởi";
                }
                else if (tempCdata > nhietdoCao)
                {
                    label15.Text = "Nhiệt Độ Cao";
                    lbtrangthai.Text = "Bật Sò Lạnh";
                }
                else
                {
                    label15.Text = "Nhiệt Độ Bình Thường";
                    lbtrangthai.Text = "Bình Thường";
                }
                

            }
        }

        private void serCOM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            dataReceive = serCOM.ReadLine().ToString();
            Print_Text(dataReceive);
            dataReceive = "";
        }


        private void lbtrangthai_Click(object sender, EventArgs e)
        {

        }
        private void txtthucan_hienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboluongthucan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtgiochoan_up_TextChanged(object sender, EventArgs e)
        {

        }
        string luongThucAn;
        string gioChoCaAn;
        private void butthucan_up_Click(object sender, EventArgs e)
        {
            gioChoCaAn = txtgiochoan_up.Text;
            
            for (int i = 0; i < 3; i++)
            {
                if(cboluongthucan.Text == luongthucan[i])
                {
                    luongThucAn = i.ToString();
                }
            }
            String data = "M/" + gioChoCaAn + "/" + luongThucAn + "\n";
            serCOM.Write(data);

        }

        private void txtnhietdo_hienthi_TextChanged(object sender, EventArgs e)
        {

        }
              
        private void txtnhietdocao_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnhietdothap_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void butnhietdo_up_Click(object sender, EventArgs e)
        {
            string beginTempC = txtnhietdothap_up.Text;
            string endTempC = txtnhietdocao_up.Text;

            string data = "S/" + beginTempC + "/" + endTempC + "\n";
            serCOM.Write(data);
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            // khởi tạo biểu đồ
        }

        public void draw(double line)
        {
        }
        List<DateTime> TimeList = new List<DateTime>();
        List<double> bufferTempC = new List<double>();
        List<CamBien_ThucAn> data = new List<CamBien_ThucAn>();
        BindingList<CamBien_ThucAn> datalichsu = new BindingList<CamBien_ThucAn>();
        float value;
        int rowIndex;
        string thucAnStr;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)
            {
                
                if(canhBaoThucAn == "1")
                {
                    thucAnStr = "Hết Thức Ăn";
                }
                else
                {
                    thucAnStr = "Còn Thức Ăn";
                }
                datalichsu.Add(new CamBien_ThucAn { ThoiGian = DateTime.Now.ToLongTimeString(), ds18b20 = tempC_str, thucAn = thucAnStr });
                dataGridView1.DataSource = datalichsu;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một DataTable (hoặc lấy dữ liệu từ nguồn dữ liệu khác)
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Thời gian", typeof(String));
            dataTable.Columns.Add("Nhiệt độ", typeof(float));
            dataTable.Columns.Add("Thức Ăn", typeof(string));
            for (int i = 0; i < datalichsu.Count; i++)
            {
                dataTable.Rows.Add(datalichsu[i].ThoiGian, datalichsu[i].ds18b20, datalichsu[i].thucAn);
            }
            // Tạo một tệp Excel mới
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Danhdachlichsu");

            // Tạo tiêu đề cột
            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                headerRow.CreateCell(i).SetCellValue(dataTable.Columns[i].ColumnName);
            }

            // Thêm dữ liệu từ DataTable vào tệp Excel
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                IRow excelRow = sheet.CreateRow(row + 1);
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    excelRow.CreateCell(col).SetCellValue(dataTable.Rows[row][col].ToString());
                }
            }
            using (FileStream fileStream = new FileStream("LichSuNhietdo&Thucan.xlsx", FileMode.Create))
            {
                workbook.Write(fileStream);
            }
            MessageBox.Show("XUẤT FILE THÀNH CÔNG", "THÔNG BÁO");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            /*
            Random ran = new Random();
            value = (ran.Next(0, 100));
            */
            DateTime now = DateTime.Now;
            TimeList.Add(now);

            bufferTempC.Add(tempCdata);
            int maxbufferPoints = 50;

            if (chart1.Series[0].Points.Count > maxbufferPoints)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }
            chart1.Series[0].Points.Clear();
            int startIndex = Math.Max(0, TimeList.Count - maxbufferPoints);

            for (int j = startIndex; j < TimeList.Count; j++)
            {
                chart1.Series[0].Points.AddXY(TimeList[j], bufferTempC[j]);

            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
