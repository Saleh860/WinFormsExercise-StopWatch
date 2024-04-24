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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            timerMicro.Text = Now.Microsecond.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timerDown.Enabled)
            {
            timerDown.Enabled = false;
            }
            else
            {
                timerDown.Enabled = true;
            }
        }
    }
}
