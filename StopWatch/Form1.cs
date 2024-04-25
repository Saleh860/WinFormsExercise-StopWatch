namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComputerTime();
            timer1.Enabled = true;
        }

        private void UpdateComputerTime()
        {
            DateTime Now = DateTime.Now;
            ComputerHour.Text = Now.Hour.ToString();
            ComputerMinute.Text = Now.Minute.ToString();
            ComputerSecond.Text = Now.Second.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateComputerTime();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Threading.Timer x = new System.Threading.Timer();
            label3_Click.Text = x.Minute.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Threading.Timer x = new();
            label2_Click.Text = x.Second.ToString();

        }
        private void label4_Click(object sender, EventArgs e)
        {

            Timer x = new System.Threading.Timer();
            label4_Click.Text = x.Hour.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ComputerMinute_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }