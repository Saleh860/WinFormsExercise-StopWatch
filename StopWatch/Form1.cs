namespace StopWatch
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private bool isRunning;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComputerTime();
            timer1.Enabled = true;
            timer2.Enabled = true;
            ClearStopwatch();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer2.Stop();
                isRunning = false;

            }
            else
            {
                startTime = DateTime.Now;
                timer2.Start();
                isRunning = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearStopwatch();
        }
        private void ClearStopwatch()
        {
            timer2.Stop();

            label4.Text = "00";
            label3.Text = "00";
            label2.Text = "00";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            label4.Text = elapsedTime.Hours.ToString("00");
            label3.Text = elapsedTime.Minutes.ToString("00");
            label2.Text = elapsedTime.Seconds.ToString("00");
        }
    }
}
