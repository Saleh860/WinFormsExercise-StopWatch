namespace StopWatch;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    int s = 00, m = 00, h = 00;
    bool isactive;
    //load method enable you to star the clock dirictly when run the program 

    //timer enable you to chang seconds whith out for loop . but you have to enable it and 
    //set the modifer to 1 second
    private void Form1_Load(object sender, EventArgs e)
    {
        resettime();
        UpdateComputerTime();
        timer1.Enabled = true;
        timer2.Enabled = true;
        isactive = false;
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
        isactive = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        isactive = true;

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
        if (isactive)
        {
            s++;
            if (s == 60)
            {
                m++;
                s = 0;
                if (m == 60)
                {
                    h++;
                    m = 0;
                }

            }

        }
        drwtime();
    }

    private void drwtime()
    {
        label5.Text = s.ToString();
        label4.Text = m.ToString();
        label3.Text = h.ToString();

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        isactive = false;
        resettime();
    }

    private void resettime()
    {
        s = 00;
        m = 00;
        h = 00;

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}
