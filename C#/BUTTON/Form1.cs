namespace BUTTON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        void addButton()
        {
            Random random = new Random();
            Button btn = new Button(); 
            btn.Text = i.ToString();
            btn.Location = new Point(random.Next(0,this.Size.Width),random.Next(0,this.Size.Height));   //vi tri random theo khung form, vi tri khoi tao bang thuoc tinh Point
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            i++;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addButton();
        }
    }
}