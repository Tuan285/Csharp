namespace textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int binh_PHuong = 0, num = 0 ;
            if(Int32.TryParse(txbVa.Text, out num))     /// ktra xem có phải number ko 
            {
                binh_PHuong = num * num;
                text.Text = binh_PHuong.ToString();
            }
            else
            {
                text.Text = "Please Input Number !!";
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}