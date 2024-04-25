namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }
        button_start start = null;

        bool timar = false;
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

            if (timar)
            {
                Update_Timar();
            }
        }

        private void Update_Timar()
        {
            DateTime New = DateTime.Now;

            int sec = int.Parse(label4.Text);
            sec++;

            int huo = int.Parse(label2.Text);
            

            int min = int.Parse(label3.Text);
           

            string n_hour = New.Hour.ToString();

            if(n_hour != start.s_huor)
            {
                
                huo++;

            }
            string n_mint = New.Hour.ToString();

            if (n_mint != start.s_mint)
            {
                min++;

            }

            

            label2.Text = huo.ToString();

            label3.Text = min.ToString();

            label4.Text = sec.ToString();



        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "0";

        }

        private void label3_Click(object sender, EventArgs e)
        {

            label3.Text = "0";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timar = true;

            DateTime Now = DateTime.Now;

            string s_huor = Now.Hour.ToString();

            string s_mint = Now.Minute.ToString();

             start = new button_start(s_huor,s_mint);



        }

        class button_start
        {
            public string s_huor {  get; set; }

            public string s_mint {  get; set; }

            public  button_start(string Huor, string Mint)
            {
                s_huor = Huor;

                s_mint = Mint;
            }


        }

    }
}
