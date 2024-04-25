namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ComputerHour = new Label();
            ComputerMinute = new Label();
            ComputerSecond = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            labelMin = new Label();
            labelSec = new Label();
            labelMS = new Label();
            buttonStartStop = new Button();
            label4 = new Label();
            button1 = new Button();
            timerColorClear = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerHour.Location = new Point(196, 421);
            ComputerHour.Margin = new Padding(4, 0, 4, 0);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(72, 55);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerMinute.Location = new Point(320, 421);
            ComputerMinute.Margin = new Padding(4, 0, 4, 0);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(72, 55);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerSecond.Location = new Point(449, 421);
            ComputerSecond.Margin = new Padding(4, 0, 4, 0);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(72, 55);
            ComputerSecond.TabIndex = 1;
            ComputerSecond.Text = "00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(366, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 55);
            label2.TabIndex = 5;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(258, 187);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 55);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // labelMin
            // 
            labelMin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMin.Location = new Point(178, 187);
            labelMin.Margin = new Padding(4, 0, 4, 0);
            labelMin.Name = "labelMin";
            labelMin.Padding = new Padding(10, 0, 0, 0);
            labelMin.Size = new Size(72, 55);
            labelMin.TabIndex = 7;
            labelMin.Text = "00";
            // 
            // labelSec
            // 
            labelSec.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSec.Location = new Point(289, 186);
            labelSec.Margin = new Padding(4, 0, 4, 0);
            labelSec.Name = "labelSec";
            labelSec.Padding = new Padding(10, 0, 0, 0);
            labelSec.Size = new Size(72, 55);
            labelSec.TabIndex = 8;
            labelSec.Text = "00";
            // 
            // labelMS
            // 
            labelMS.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelMS.Location = new Point(391, 187);
            labelMS.Margin = new Padding(4, 0, 4, 0);
            labelMS.Name = "labelMS";
            labelMS.Padding = new Padding(10, 0, 0, 0);
            labelMS.Size = new Size(72, 55);
            labelMS.TabIndex = 9;
            labelMS.Text = "00";
            // 
            // buttonStartStop
            // 
            buttonStartStop.Location = new Point(178, 279);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(115, 42);
            buttonStartStop.TabIndex = 10;
            buttonStartStop.Text = "Start/Stop";
            buttonStartStop.UseVisualStyleBackColor = true;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 79);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(197, 46);
            label4.TabIndex = 11;
            label4.Text = "Stopwatch";
            // 
            // button1
            // 
            button1.Location = new Point(348, 279);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 12;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timerColorClear
            // 
            timerColorClear.Interval = 500;
            timerColorClear.Tick += timerColorClear_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 554);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(buttonStartStop);
            Controls.Add(labelMS);
            Controls.Add(labelSec);
            Controls.Add(labelMin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(ComputerHour);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ComputerHour;
        private Label ComputerMinute;
        private Label ComputerSecond;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer;
        private Label labelMin;
        private Label labelSec;
        private Label labelMS;
        private Button buttonStartStop;
        private Label label4;
        private Button button1;
        private System.Windows.Forms.Timer timerColorClear;
    }
}
