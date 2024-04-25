namespace StopWatch
{
    public partial class Form1 : Form
    {
        int timeh, timem, times;
        bool active;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComputerTime();
            timer1.Enabled = true;
            timer2.Enabled = true;
            ResetTime();
            active = false;
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

        private void ComputerHour_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (active)
            {
                times++;


                if (times > 60)
                {
                    timem++;
                    times = 0;
                    if (timeh > 60)
                    {
                        timeh++;
                        timem = 0;
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            label3.Text = timeh.ToString();
            label5.Text = timem.ToString();
            label4.Text = times.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            active = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            active = false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeh = 0;
            timem = 0;
            times = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            active = false;
        }
    }
}
