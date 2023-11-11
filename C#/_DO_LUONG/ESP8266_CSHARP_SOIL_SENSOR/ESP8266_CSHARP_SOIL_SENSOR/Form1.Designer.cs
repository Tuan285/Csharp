namespace ESP8266_CSHARP_SOIL_SENSOR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statusTemp = new System.Windows.Forms.Label();
            this.statusSoil = new System.Windows.Forms.Label();
            this.labelNhietdo = new System.Windows.Forms.Label();
            this.labelSoil = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMAXSOIL = new System.Windows.Forms.TextBox();
            this.textBoxMINSOIL = new System.Windows.Forms.TextBox();
            this.textBoxMAXTEMP = new System.Windows.Forms.TextBox();
            this.textBoxMINTEMP = new System.Windows.Forms.TextBox();
            this.comfirmTemp = new System.Windows.Forms.Button();
            this.comfirmSoil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.motor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.manual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.statusMQTT = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.lineChart = new MindFusion.Charting.WinForms.LineChart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 793);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lineChart);
            this.panel2.Location = new System.Drawing.Point(11, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 775);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusTemp);
            this.panel6.Controls.Add(this.statusSoil);
            this.panel6.Controls.Add(this.labelNhietdo);
            this.panel6.Controls.Add(this.labelSoil);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.textBoxMAXSOIL);
            this.panel6.Controls.Add(this.textBoxMINSOIL);
            this.panel6.Controls.Add(this.textBoxMAXTEMP);
            this.panel6.Controls.Add(this.textBoxMINTEMP);
            this.panel6.Controls.Add(this.comfirmTemp);
            this.panel6.Controls.Add(this.comfirmSoil);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(47, 597);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(901, 156);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // statusTemp
            // 
            this.statusTemp.AutoSize = true;
            this.statusTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTemp.ForeColor = System.Drawing.Color.Red;
            this.statusTemp.Location = new System.Drawing.Point(468, 132);
            this.statusTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusTemp.Name = "statusTemp";
            this.statusTemp.Size = new System.Drawing.Size(124, 25);
            this.statusTemp.TabIndex = 23;
            this.statusTemp.Text = "WARNING !!";
            // 
            // statusSoil
            // 
            this.statusSoil.AutoSize = true;
            this.statusSoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusSoil.ForeColor = System.Drawing.Color.Red;
            this.statusSoil.Location = new System.Drawing.Point(16, 132);
            this.statusSoil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusSoil.Name = "statusSoil";
            this.statusSoil.Size = new System.Drawing.Size(124, 25);
            this.statusSoil.TabIndex = 22;
            this.statusSoil.Text = "WARNING !!";
            // 
            // labelNhietdo
            // 
            this.labelNhietdo.AutoSize = true;
            this.labelNhietdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhietdo.Location = new System.Drawing.Point(680, 2);
            this.labelNhietdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNhietdo.Name = "labelNhietdo";
            this.labelNhietdo.Size = new System.Drawing.Size(0, 29);
            this.labelNhietdo.TabIndex = 21;
            // 
            // labelSoil
            // 
            this.labelSoil.AutoSize = true;
            this.labelSoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoil.Location = new System.Drawing.Point(105, 2);
            this.labelSoil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoil.Name = "labelSoil";
            this.labelSoil.Size = new System.Drawing.Size(0, 29);
            this.labelSoil.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(453, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "MAX :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "MAX :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "MIN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "MIN :";
            // 
            // textBoxMAXSOIL
            // 
            this.textBoxMAXSOIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMAXSOIL.Location = new System.Drawing.Point(108, 80);
            this.textBoxMAXSOIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMAXSOIL.Name = "textBoxMAXSOIL";
            this.textBoxMAXSOIL.Size = new System.Drawing.Size(173, 26);
            this.textBoxMAXSOIL.TabIndex = 15;
            this.textBoxMAXSOIL.Text = "19.4";
            this.textBoxMAXSOIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMINSOIL
            // 
            this.textBoxMINSOIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMINSOIL.Location = new System.Drawing.Point(108, 41);
            this.textBoxMINSOIL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMINSOIL.Name = "textBoxMINSOIL";
            this.textBoxMINSOIL.Size = new System.Drawing.Size(173, 26);
            this.textBoxMINSOIL.TabIndex = 14;
            this.textBoxMINSOIL.Text = "10.4";
            this.textBoxMINSOIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMAXTEMP
            // 
            this.textBoxMAXTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMAXTEMP.Location = new System.Drawing.Point(565, 80);
            this.textBoxMAXTEMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMAXTEMP.Name = "textBoxMAXTEMP";
            this.textBoxMAXTEMP.Size = new System.Drawing.Size(173, 26);
            this.textBoxMAXTEMP.TabIndex = 13;
            this.textBoxMAXTEMP.Text = "28.5";
            this.textBoxMAXTEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMINTEMP
            // 
            this.textBoxMINTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMINTEMP.Location = new System.Drawing.Point(565, 39);
            this.textBoxMINTEMP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMINTEMP.Name = "textBoxMINTEMP";
            this.textBoxMINTEMP.Size = new System.Drawing.Size(173, 26);
            this.textBoxMINTEMP.TabIndex = 12;
            this.textBoxMINTEMP.Text = "20.8";
            this.textBoxMINTEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comfirmTemp
            // 
            this.comfirmTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmTemp.Location = new System.Drawing.Point(761, 4);
            this.comfirmTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comfirmTemp.Name = "comfirmTemp";
            this.comfirmTemp.Size = new System.Drawing.Size(127, 117);
            this.comfirmTemp.TabIndex = 11;
            this.comfirmTemp.Text = "CONFIRM";
            this.comfirmTemp.UseVisualStyleBackColor = true;
            this.comfirmTemp.Click += new System.EventHandler(this.comfirmTemp_Click);
            // 
            // comfirmSoil
            // 
            this.comfirmSoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirmSoil.Location = new System.Drawing.Point(304, 6);
            this.comfirmSoil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comfirmSoil.Name = "comfirmSoil";
            this.comfirmSoil.Size = new System.Drawing.Size(127, 117);
            this.comfirmSoil.TabIndex = 10;
            this.comfirmSoil.Text = "CONFIRM";
            this.comfirmSoil.UseVisualStyleBackColor = true;
            this.comfirmSoil.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "TEMPERATURE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "SOIL :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.manual);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(700, 409);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 181);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.motor);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 86);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 91);
            this.panel5.TabIndex = 9;
            // 
            // motor
            // 
            this.motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motor.Location = new System.Drawing.Point(17, 33);
            this.motor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(356, 37);
            this.motor.TabIndex = 9;
            this.motor.Text = "ON/OFF";
            this.motor.UseVisualStyleBackColor = true;
            this.motor.Click += new System.EventHandler(this.motor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "MOTOR :";
            // 
            // manual
            // 
            this.manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual.Location = new System.Drawing.Point(29, 42);
            this.manual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(356, 37);
            this.manual.TabIndex = 8;
            this.manual.Text = "ON/OFF";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "MANUAL :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ESP8266_CSHARP_SOIL_SENSOR.Properties.Resources.logoUTH3;
            this.pictureBox1.Location = new System.Drawing.Point(951, 606);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.statusMQTT);
            this.panel3.Controls.Add(this.disconnect);
            this.panel3.Controls.Add(this.connect);
            this.panel3.Location = new System.Drawing.Point(47, 409);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 182);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "DISCONNECT !!!";
            // 
            // statusMQTT
            // 
            this.statusMQTT.AutoSize = true;
            this.statusMQTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMQTT.ForeColor = System.Drawing.Color.Red;
            this.statusMQTT.Location = new System.Drawing.Point(3, 155);
            this.statusMQTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusMQTT.Name = "statusMQTT";
            this.statusMQTT.Size = new System.Drawing.Size(169, 25);
            this.statusMQTT.TabIndex = 7;
            this.statusMQTT.Text = "STATUS MQTT :";
            // 
            // disconnect
            // 
            this.disconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(352, 42);
            this.disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(267, 81);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "DISCONNECT MQTT";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(21, 42);
            this.connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(267, 81);
            this.connect.TabIndex = 4;
            this.connect.Text = "CONNECT MQTT";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lineChart
            // 
            this.lineChart.LegendTitle = "Legend";
            this.lineChart.Location = new System.Drawing.Point(4, 4);
            this.lineChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineChart.Name = "lineChart";
            this.lineChart.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lineChart.ShowLegend = true;
            this.lineChart.Size = new System.Drawing.Size(1107, 410);
            this.lineChart.SubtitleFontName = null;
            this.lineChart.SubtitleFontSize = null;
            this.lineChart.SubtitleFontStyle = null;
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lineChart1";
            this.lineChart.Theme.AxisLabelsBrush = new MindFusion.Drawing.SolidBrush("#FFFF0000");
            this.lineChart.Theme.AxisStroke = new MindFusion.Drawing.SolidBrush("#FF00FF7F");
            this.lineChart.Theme.AxisTitleBrush = new MindFusion.Drawing.SolidBrush("#FF0078D7");
            this.lineChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            this.lineChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            this.lineChart.Theme.UniformSeriesStrokeThickness = 2D;
            this.lineChart.TitleFontName = null;
            this.lineChart.TitleFontSize = null;
            this.lineChart.TitleFontStyle = null;
            this.lineChart.DataItemClicked += new System.EventHandler<MindFusion.Charting.HitResult>(this.lineChart1_DataItemClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1152, 801);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ES8266";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MindFusion.Charting.WinForms.LineChart lineChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label statusMQTT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button motor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelNhietdo;
        private System.Windows.Forms.Label labelSoil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMAXSOIL;
        private System.Windows.Forms.TextBox textBoxMINSOIL;
        private System.Windows.Forms.TextBox textBoxMAXTEMP;
        private System.Windows.Forms.TextBox textBoxMINTEMP;
        private System.Windows.Forms.Button comfirmTemp;
        private System.Windows.Forms.Button comfirmSoil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statusTemp;
        private System.Windows.Forms.Label statusSoil;
    }
}

