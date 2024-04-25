namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //load method enable you to star the clock dirictly when run the program 

        //timer enable you to chang seconds whith out for loop . but you have to enable it and 
        //set the modifer to 1 second
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComputerTime();
            timer1.Enabled = true;
            UpdateStopWatch();
            timer2.Enabled = true;
        }

        private void UpdateStopWatch()
        {
            DateTime Now = DateTime.Now;
            label3.Text = Now.Second.ToString();
            label4.Text = Now.Second.ToString();
            label5.Text = Now.Second.ToString();
        }
        //



        //
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

        private void ComputerHour_Click(object sender, EventArgs e)
        {

        }

        private void HourStop(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ComputerMinute_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void ComputerSecond_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateStopWatch();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
