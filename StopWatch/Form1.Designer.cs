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
            Seconds = new Label();
            Minutes = new Label();
            Hours = new Label();
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(157, 364);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F);
            ComputerHour.Location = new Point(157, 468);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(58, 61);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F);
            ComputerMinute.Location = new Point(256, 468);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(58, 61);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F);
            ComputerSecond.Location = new Point(359, 468);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(58, 61);
            ComputerSecond.TabIndex = 1;
            ComputerSecond.Text = "00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Seconds
            // 
            Seconds.BorderStyle = BorderStyle.FixedSingle;
            Seconds.Font = new Font("Segoe UI", 20F);
            Seconds.Location = new Point(355, 118);
            Seconds.Name = "Seconds";
            Seconds.Size = new Size(62, 51);
            Seconds.TabIndex = 2;
            Seconds.Text = "00";
            // 
            // Minutes
            // 
            Minutes.BorderStyle = BorderStyle.FixedSingle;
            Minutes.Font = new Font("Segoe UI", 20F);
            Minutes.Location = new Point(256, 118);
            Minutes.Name = "Minutes";
            Minutes.Size = new Size(58, 51);
            Minutes.TabIndex = 3;
            Minutes.Text = "00";
            // 
            // Hours
            // 
            Hours.BorderStyle = BorderStyle.FixedSingle;
            Hours.Font = new Font("Segoe UI", 20F);
            Hours.Location = new Point(153, 118);
            Hours.Name = "Hours";
            Hours.Size = new Size(58, 51);
            Hours.TabIndex = 4;
            Hours.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.Location = new Point(174, 39);
            label2.Name = "label2";
            label2.Size = new Size(212, 46);
            label2.TabIndex = 0;
            label2.Text = "stop  watch";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(220, 212);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 5;
            button1.Text = "Start/Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 286);
            button2.Name = "button2";
            button2.Size = new Size(105, 39);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Seconds);
            Controls.Add(Minutes);
            Controls.Add(Hours);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(ComputerHour);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label Seconds;
        private Label Minutes;
        private Label Hours;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
    }
}
