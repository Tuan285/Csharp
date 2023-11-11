namespace bai1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, tong = 0;
            a = Convert.ToInt32(number_1.Text);
            b = Convert.ToInt32(number_2.Text);

            tong = a + b;
            result.Text = tong.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(number_1.Text);
            b = Convert.ToInt32(number_2.Text);

            int tru = a - b;
            result.Text = tru.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a, b ;
            a = Convert.ToInt32(number_1.Text);
            b = Convert.ToInt32(number_2.Text);

            int nhan = a * b;
            result.Text = nhan.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button1.Enabled = true;
                checkBox1.Enabled = false;
                radioButton1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                checkBox1.Enabled = true;
                radioButton1.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button1.Enabled = false;
                checkBox1.Enabled = true;
                radioButton1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                checkBox1.Enabled = true;
                radioButton1.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                button1.Enabled = false;
                checkBox1.Enabled = false;
                radioButton1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                checkBox1.Enabled = true;
                radioButton1.Enabled = true;
            }
        }
    }
}