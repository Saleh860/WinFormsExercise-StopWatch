namespace StopWatch
{
    public partial class Form1 : Form
    {
        private bool isRunning;
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComputerTime();
            timer1.Enabled = true;
            isRunning = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                timer1.Stop();
                UpdateComputerTime();
            }
            else
            {
                isRunning = true;
                startTime = DateTime.Now;
                timer1.Start();
            }
        }
        private void ComputerHour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current hour is: " + ComputerHour.Text);
        }

        private void ComputerMinute_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current minute is: " + ComputerMinute.Text);
        }

        private void ComputerSecond_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current minute is: " + ComputerMinute.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label4 was clicked!");
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Label4 was clicked!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateComputerTime();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
        private void label3_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Label3 was clicked!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (isRunning)
            {
                isRunning = false;
                timer1.Stop();
                UpdateComputerTime();
            }
            else
            {
                isRunning = true;
                startTime = DateTime.Now;
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            isRunning = false;
            timer1.Stop(); 
            ComputerHour.Text = "00";
            ComputerMinute.Text = "00";
            ComputerSecond.Text = "00";
        }
    }
      
}