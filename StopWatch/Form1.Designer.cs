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
            startstop = new Button();
            clearb = new Button();
            hourview = new Label();
            minuteview = new Label();
            secondview = new Label();
            label3 = new Label();
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
            label1.Click += label1_Click;
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
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // startstop
            // 
            startstop.Font = new Font("Segoe UI", 22F);
            startstop.Location = new Point(184, 299);
            startstop.Name = "startstop";
            startstop.Size = new Size(214, 62);
            startstop.TabIndex = 2;
            startstop.Text = "start/stop";
            startstop.UseVisualStyleBackColor = true;
            // 
            // clearb
            // 
            clearb.Font = new Font("Segoe UI", 20F);
            clearb.Location = new Point(226, 217);
            clearb.Name = "clearb";
            clearb.Size = new Size(126, 60);
            clearb.TabIndex = 3;
            clearb.Text = "clear";
            clearb.UseVisualStyleBackColor = true;
            clearb.Click += clearb_Click;
            // 
            // hourview
            // 
            hourview.AutoSize = true;
            hourview.Font = new Font("Segoe UI", 22F);
            hourview.Location = new Point(87, 118);
            hourview.Name = "hourview";
            hourview.Size = new Size(62, 50);
            hourview.TabIndex = 4;
            hourview.Text = "00";
            hourview.Click += label2_Click;
            // 
            // minuteview
            // 
            minuteview.AutoSize = true;
            minuteview.Font = new Font("Segoe UI", 22F);
            minuteview.Location = new Point(256, 118);
            minuteview.Name = "minuteview";
            minuteview.Size = new Size(62, 50);
            minuteview.TabIndex = 5;
            minuteview.Text = "00";
            // 
            // secondview
            // 
            secondview.AutoSize = true;
            secondview.Font = new Font("Segoe UI", 22F);
            secondview.Location = new Point(418, 118);
            secondview.Name = "secondview";
            secondview.Size = new Size(62, 50);
            secondview.TabIndex = 6;
            secondview.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(87, 31);
            label3.Name = "label3";
            label3.Size = new Size(265, 67);
            label3.TabIndex = 7;
            label3.Text = "stopwatch:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 547);
            Controls.Add(label3);
            Controls.Add(secondview);
            Controls.Add(minuteview);
            Controls.Add(hourview);
            Controls.Add(clearb);
            Controls.Add(startstop);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(ComputerHour);
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
        private Button startstop;
        private Button clearb;
        private Label hourview;
        private Label minuteview;
        private Label secondview;
        private Label label3;
    }
}
