namespace RadioBt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void returnResult (Label label, Panel pn)
        {
            RadioButton rb = null;

            foreach( RadioButton radioButton in pn.Controls)
            {
                if (rb == null)
                {
                    if (radioButton.Checked)
                    {
                        rb = radioButton;
                        break;
                    }
                }
            }
            if (rb != null)
            {
                label.Text = rb.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            returnResult(label1, panel1);
            returnResult(label2, panel2);
            returnResult(label3, panel3);
        }
    }
}
