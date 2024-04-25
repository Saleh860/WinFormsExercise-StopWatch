using System.Runtime.CompilerServices;

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ComputerHour_Click(object sender, EventArgs e)
        {

        }

        private void ComputerMinute_Click(object sender, EventArgs e)
        {

        }

        private void ComputerSecond_Click(object sender, EventArgs e)
        {

        }

        private void swH_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {



            int x = int.Parse(swS.Text) + 1;
            swS.Text = x.ToString();
            if (x == 60)
            {
                swS.Text = "0";
                int y = int.Parse(swM.Text) + 1;
                swM.Text = y.ToString();
                if (y == 60)
                {
                    swM.Text = "0";
                    int z = int.Parse(swH.Text) + 1;
                    swH.Text = z.ToString();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            swH.Text = "0".ToString();
            swM.Text = "0".ToString();
            swS.Text = "0".ToString();
        }

        private void swS_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { if (timer2.Enabled)
            timer2.Enabled= false;
        else 
                    {
                timer2.Enabled = true;
            }

        }
    }
}
