namespace BTLSCADA
{
    partial class giamsat3
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
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.butpage2 = new System.Windows.Forms.Button();
            this.butpage1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butpage2
            // 
            this.butpage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage2.Location = new System.Drawing.Point(1150, 25);
            this.butpage2.Name = "butpage2";
            this.butpage2.Size = new System.Drawing.Size(74, 43);
            this.butpage2.TabIndex = 129;
            this.butpage2.Text = "page 2";
            this.butpage2.UseVisualStyleBackColor = true;
            this.butpage2.Click += new System.EventHandler(this.butpage2_Click);
            // 
            // butpage1
            // 
            this.butpage1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butpage1.Location = new System.Drawing.Point(1060, 25);
            this.butpage1.Name = "butpage1";
            this.butpage1.Size = new System.Drawing.Size(74, 43);
            this.butpage1.TabIndex = 128;
            this.butpage1.Text = "page 1";
            this.butpage1.UseVisualStyleBackColor = true;
            this.butpage1.Click += new System.EventHandler(this.butpage1_Click);
            // 
            // giamsat3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 646);
            this.Controls.Add(this.butpage2);
            this.Controls.Add(this.butpage1);
            this.Name = "giamsat3";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button butpage2;
        private System.Windows.Forms.Button butpage1;
    }
}