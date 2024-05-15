using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Exercise
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private Timer timer;
        public Form1()
        {

            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.MinValue;
            UpdateTimerLabels();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            UpdateTimerLabels();

        }
        private void UpdateTimerLabels()
        {
            TimeSpan span = DateTime.Now - startTime;
            lblHours.Text = span.Hours.ToString("D2");
            lblMinutes.Text = span.Minutes.ToString("D2");
            lblSeconds.Text = span.Seconds.ToString("D2");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                // Stop the stopwatch
                timer.Stop();
            }
            else
            {
                // Start or resume the stopwatch
                if (startTime == DateTime.MinValue)
                    startTime = DateTime.Now;
                timer.Start();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the stopwatch
            timer1.Stop();
            lblHours.Text = "00";
            lblMinutes.Text = "00";
            lblSeconds.Text = "00";
        }

    }
}

