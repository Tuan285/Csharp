namespace MQTT_TEST
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_receiv = new System.Windows.Forms.TextBox();
            this.textBox_topic_pub = new System.Windows.Forms.TextBox();
            this.textBox_topic_sub = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SEND = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_receiv);
            this.panel1.Controls.Add(this.textBox_topic_pub);
            this.panel1.Controls.Add(this.textBox_topic_sub);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SEND);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 239);
            this.panel1.TabIndex = 0;
            // 
            // textBox_receiv
            // 
            this.textBox_receiv.Location = new System.Drawing.Point(157, 184);
            this.textBox_receiv.Name = "textBox_receiv";
            this.textBox_receiv.Size = new System.Drawing.Size(179, 20);
            this.textBox_receiv.TabIndex = 5;
            // 
            // textBox_topic_pub
            // 
            this.textBox_topic_pub.Location = new System.Drawing.Point(157, 119);
            this.textBox_topic_pub.Name = "textBox_topic_pub";
            this.textBox_topic_pub.Size = new System.Drawing.Size(179, 20);
            this.textBox_topic_pub.TabIndex = 4;
            this.textBox_topic_pub.TextChanged += new System.EventHandler(this.textBox_topic_pub_TextChanged);
            // 
            // textBox_topic_sub
            // 
            this.textBox_topic_sub.Location = new System.Drawing.Point(157, 51);
            this.textBox_topic_sub.Name = "textBox_topic_sub";
            this.textBox_topic_sub.Size = new System.Drawing.Size(179, 20);
            this.textBox_topic_sub.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "RECEIVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.receive_Click);
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(24, 51);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(75, 23);
            this.SEND.TabIndex = 1;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.sen_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 263);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_topic_pub;
        private System.Windows.Forms.TextBox textBox_topic_sub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_receiv;
    }
}

