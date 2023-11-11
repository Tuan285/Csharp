namespace textBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbVa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbVa
            // 
            this.txbVa.Location = new System.Drawing.Point(49, 80);
            this.txbVa.Multiline = true;
            this.txbVa.Name = "txbVa";
            this.txbVa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbVa.Size = new System.Drawing.Size(100, 28);
            this.txbVa.TabIndex = 0;
            this.txbVa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ClickMe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(204, 93);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(13, 15);
            this.text.TabIndex = 2;
            this.text.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 267);
            this.Controls.Add(this.text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbVa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbVa;
        private Button button1;
        private Label text;
    }
}