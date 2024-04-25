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

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x = int.Parse(Seconds.Text);
            int y = int.Parse(Minutes.Text);
            int z = int.Parse(Hours.Text);
            if (x < 59 )
          
                Seconds.Text= (x+1).ToString();
            else
            {
                Seconds.Text= "0";
                if (y < 59)
                    Minutes.Text = (y + 1).ToString();
                else
                {
                    Minutes.Text = "0";
                    if (z < 23 )
                        Hours.Text = (z + 1).ToString();
                    else
                    {
                        Hours.Text = "0";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
            timer2.Enabled = false;
            else
            {
                timer2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hours.Text = "0";
            Minutes.Text = "0";
            Seconds.Text = "0";

        }
    }
}
