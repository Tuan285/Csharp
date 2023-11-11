using System;

namespace ESP_MQTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_esp = new System.Windows.Forms.Panel();
            this.panel_sensor2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label_value_hum2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_value_temp2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.circularProgressBar_Humidity2 = new CircularProgressBar.CircularProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.circularProgressBar_Temperature2 = new CircularProgressBar.CircularProgressBar();
            this.panel_sensor1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_value_hum1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.circularProgressBar_Humidity1 = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label_value_temp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.circularProgressBar_Temp1 = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Disc = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_Port_Mqtt = new System.Windows.Forms.TextBox();
            this.textBox_addressMqtt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_esp.SuspendLayout();
            this.panel_sensor2.SuspendLayout();
            this.panel_sensor1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_esp);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel_log);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_esp
            // 
            this.panel_esp.Controls.Add(this.panel_sensor2);
            this.panel_esp.Controls.Add(this.panel_sensor1);
            resources.ApplyResources(this.panel_esp, "panel_esp");
            this.panel_esp.Name = "panel_esp";
            // 
            // panel_sensor2
            // 
            this.panel_sensor2.Controls.Add(this.label11);
            this.panel_sensor2.Controls.Add(this.label_value_hum2);
            this.panel_sensor2.Controls.Add(this.label13);
            this.panel_sensor2.Controls.Add(this.label14);
            this.panel_sensor2.Controls.Add(this.label_value_temp2);
            this.panel_sensor2.Controls.Add(this.label16);
            this.panel_sensor2.Controls.Add(this.circularProgressBar_Humidity2);
            this.panel_sensor2.Controls.Add(this.label18);
            this.panel_sensor2.Controls.Add(this.circularProgressBar_Temperature2);
            resources.ApplyResources(this.panel_sensor2, "panel_sensor2");
            this.panel_sensor2.Name = "panel_sensor2";
            this.panel_sensor2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sensor2_Paint);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label_value_hum2
            // 
            resources.ApplyResources(this.label_value_hum2, "label_value_hum2");
            this.label_value_hum2.Name = "label_value_hum2";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label_value_temp2
            // 
            resources.ApplyResources(this.label_value_temp2, "label_value_temp2");
            this.label_value_temp2.Name = "label_value_temp2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Gainsboro;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Name = "label16";
            // 
            // circularProgressBar_Humidity2
            // 
            this.circularProgressBar_Humidity2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Humidity2.AnimationSpeed = 500;
            this.circularProgressBar_Humidity2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar_Humidity2, "circularProgressBar_Humidity2");
            this.circularProgressBar_Humidity2.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Humidity2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Humidity2.InnerMargin = 2;
            this.circularProgressBar_Humidity2.InnerWidth = -1;
            this.circularProgressBar_Humidity2.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar_Humidity2.Name = "circularProgressBar_Humidity2";
            this.circularProgressBar_Humidity2.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar_Humidity2.OuterMargin = -10;
            this.circularProgressBar_Humidity2.OuterWidth = 10;
            this.circularProgressBar_Humidity2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.circularProgressBar_Humidity2.ProgressWidth = 10;
            this.circularProgressBar_Humidity2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_Humidity2.StartAngle = 270;
            this.circularProgressBar_Humidity2.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Humidity2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Humidity2.SubscriptText = ".23";
            this.circularProgressBar_Humidity2.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Humidity2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Humidity2.SuperscriptText = "°C";
            this.circularProgressBar_Humidity2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_Humidity2.Value = 10;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // circularProgressBar_Temperature2
            // 
            this.circularProgressBar_Temperature2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Temperature2.AnimationSpeed = 500;
            this.circularProgressBar_Temperature2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar_Temperature2, "circularProgressBar_Temperature2");
            this.circularProgressBar_Temperature2.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Temperature2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Temperature2.InnerMargin = 2;
            this.circularProgressBar_Temperature2.InnerWidth = -1;
            this.circularProgressBar_Temperature2.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar_Temperature2.Name = "circularProgressBar_Temperature2";
            this.circularProgressBar_Temperature2.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar_Temperature2.OuterMargin = -10;
            this.circularProgressBar_Temperature2.OuterWidth = 10;
            this.circularProgressBar_Temperature2.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar_Temperature2.ProgressWidth = 10;
            this.circularProgressBar_Temperature2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_Temperature2.StartAngle = 270;
            this.circularProgressBar_Temperature2.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Temperature2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Temperature2.SubscriptText = ".23";
            this.circularProgressBar_Temperature2.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Temperature2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Temperature2.SuperscriptText = "°C";
            this.circularProgressBar_Temperature2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_Temperature2.Value = 10;
            // 
            // panel_sensor1
            // 
            this.panel_sensor1.Controls.Add(this.label8);
            this.panel_sensor1.Controls.Add(this.label_value_hum1);
            this.panel_sensor1.Controls.Add(this.label10);
            this.panel_sensor1.Controls.Add(this.label17);
            this.panel_sensor1.Controls.Add(this.circularProgressBar_Humidity1);
            this.panel_sensor1.Controls.Add(this.label7);
            this.panel_sensor1.Controls.Add(this.label_value_temp);
            this.panel_sensor1.Controls.Add(this.label6);
            this.panel_sensor1.Controls.Add(this.circularProgressBar_Temp1);
            resources.ApplyResources(this.panel_sensor1, "panel_sensor1");
            this.panel_sensor1.Name = "panel_sensor1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label_value_hum1
            // 
            resources.ApplyResources(this.label_value_hum1, "label_value_hum1");
            this.label_value_hum1.Name = "label_value_hum1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Name = "label10";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // circularProgressBar_Humidity1
            // 
            this.circularProgressBar_Humidity1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Humidity1.AnimationSpeed = 500;
            this.circularProgressBar_Humidity1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar_Humidity1, "circularProgressBar_Humidity1");
            this.circularProgressBar_Humidity1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Humidity1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Humidity1.InnerMargin = 2;
            this.circularProgressBar_Humidity1.InnerWidth = -1;
            this.circularProgressBar_Humidity1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar_Humidity1.Name = "circularProgressBar_Humidity1";
            this.circularProgressBar_Humidity1.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar_Humidity1.OuterMargin = -10;
            this.circularProgressBar_Humidity1.OuterWidth = 10;
            this.circularProgressBar_Humidity1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.circularProgressBar_Humidity1.ProgressWidth = 10;
            this.circularProgressBar_Humidity1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_Humidity1.StartAngle = 270;
            this.circularProgressBar_Humidity1.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Humidity1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Humidity1.SubscriptText = ".23";
            this.circularProgressBar_Humidity1.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Humidity1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Humidity1.SuperscriptText = "°C";
            this.circularProgressBar_Humidity1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_Humidity1.Value = 10;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label_value_temp
            // 
            resources.ApplyResources(this.label_value_temp, "label_value_temp");
            this.label_value_temp.Name = "label_value_temp";
            this.label_value_temp.Click += new System.EventHandler(this.label_value_temp_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // circularProgressBar_Temp1
            // 
            this.circularProgressBar_Temp1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar_Temp1.AnimationSpeed = 500;
            this.circularProgressBar_Temp1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.circularProgressBar_Temp1, "circularProgressBar_Temp1");
            this.circularProgressBar_Temp1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar_Temp1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar_Temp1.InnerMargin = 2;
            this.circularProgressBar_Temp1.InnerWidth = -1;
            this.circularProgressBar_Temp1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar_Temp1.Name = "circularProgressBar_Temp1";
            this.circularProgressBar_Temp1.OuterColor = System.Drawing.Color.DarkGray;
            this.circularProgressBar_Temp1.OuterMargin = -10;
            this.circularProgressBar_Temp1.OuterWidth = 10;
            this.circularProgressBar_Temp1.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar_Temp1.ProgressWidth = 10;
            this.circularProgressBar_Temp1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar_Temp1.StartAngle = 270;
            this.circularProgressBar_Temp1.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Temp1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar_Temp1.SubscriptText = ".23";
            this.circularProgressBar_Temp1.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar_Temp1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar_Temp1.SuperscriptText = "°C";
            this.circularProgressBar_Temp1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar_Temp1.Value = 10;
            this.circularProgressBar_Temp1.Click += new System.EventHandler(this.circularProgressBar_Temp1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_Disc);
            this.panel3.Controls.Add(this.label_status);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button_connect);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // button_Disc
            // 
            resources.ApplyResources(this.button_Disc, "button_Disc");
            this.button_Disc.Name = "button_Disc";
            this.button_Disc.UseVisualStyleBackColor = true;
            this.button_Disc.Click += new System.EventHandler(this.button_Disc_Click_1);
            // 
            // label_status
            // 
            resources.ApplyResources(this.label_status, "label_status");
            this.label_status.Name = "label_status";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button_connect
            // 
            resources.ApplyResources(this.button_connect, "button_connect");
            this.button_connect.Name = "button_connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // panel_log
            // 
            this.panel_log.Controls.Add(this.label4);
            this.panel_log.Controls.Add(this.label3);
            this.panel_log.Controls.Add(this.label2);
            this.panel_log.Controls.Add(this.label1);
            this.panel_log.Controls.Add(this.textBox_pass);
            this.panel_log.Controls.Add(this.textBox_user);
            this.panel_log.Controls.Add(this.textBox_Port_Mqtt);
            this.panel_log.Controls.Add(this.textBox_addressMqtt);
            resources.ApplyResources(this.panel_log, "panel_log");
            this.panel_log.Name = "panel_log";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_pass
            // 
            resources.ApplyResources(this.textBox_pass, "textBox_pass");
            this.textBox_pass.Name = "textBox_pass";
            // 
            // textBox_user
            // 
            resources.ApplyResources(this.textBox_user, "textBox_user");
            this.textBox_user.Name = "textBox_user";
            // 
            // textBox_Port_Mqtt
            // 
            resources.ApplyResources(this.textBox_Port_Mqtt, "textBox_Port_Mqtt");
            this.textBox_Port_Mqtt.Name = "textBox_Port_Mqtt";
            // 
            // textBox_addressMqtt
            // 
            resources.ApplyResources(this.textBox_addressMqtt, "textBox_addressMqtt");
            this.textBox_addressMqtt.Name = "textBox_addressMqtt";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel_esp.ResumeLayout(false);
            this.panel_sensor2.ResumeLayout(false);
            this.panel_sensor2.PerformLayout();
            this.panel_sensor1.ResumeLayout(false);
            this.panel_sensor1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_Port_Mqtt;
        private System.Windows.Forms.TextBox textBox_addressMqtt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_esp;
        private System.Windows.Forms.Panel panel_sensor1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Disc;
        private CircularProgressBar.CircularProgressBar circularProgressBar_Temp1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_value_temp;
        private System.Windows.Forms.Panel panel_sensor2;
        private System.Windows.Forms.Label label18;
        private CircularProgressBar.CircularProgressBar circularProgressBar_Temperature2;
        private System.Windows.Forms.Label label17;
        private CircularProgressBar.CircularProgressBar circularProgressBar_Humidity1;
        private CircularProgressBar.CircularProgressBar circularProgressBar_Humidity2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_value_hum1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_value_hum2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_value_temp2;
        private System.Windows.Forms.Label label16;
    }
}

