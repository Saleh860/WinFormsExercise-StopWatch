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

        private void ComputerMinute_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
