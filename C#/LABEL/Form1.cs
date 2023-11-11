namespace LABEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "hong nhen be oi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "HELLO NHAA";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}