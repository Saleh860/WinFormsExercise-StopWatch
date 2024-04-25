using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int min = 0, sec = 0, ms = 0;
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
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                buttonStartStop.BackColor = Color.White;
                buttonStartStop.ForeColor = Color.Black;
            }
            else
            {
                buttonStartStop.BackColor = Color.RoyalBlue;
                buttonStartStop.ForeColor = Color.White;
                timer.Enabled = true;
               

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ms += 1;
            if (ms == 100)
            {
                sec += 1;
                ms = 0;
            }
            if (sec == 60)
            {
                min += 1;
                ms = 0;
                sec = 0;
            }
            if (sec < 10)
            {
                labelSec.Text = $"0{sec}";
            }
            else
            {
                labelSec.Text = sec.ToString();
            }
            if (min < 10)
            {
                labelMin.Text = $"0{min}";
            }
            else
            {
                labelMin.Text = min.ToString();
            }
            labelMS.Text = ms.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms = 0;
            sec = 0;
            min = 0;
            labelMS.Text = $"0{ms}";
            labelMin.Text = $"0{min}";
            labelSec.Text = $"0{sec}";
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            timerColorClear.Enabled = true;
        }

        private void timerColorClear_Tick(object sender, EventArgs e)
        {
            button1.BackColor= Color.White;
            button1.ForeColor = Color.Black;
        }
    }
}
