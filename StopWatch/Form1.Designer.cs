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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            ComputerHour.Click += ComputerHour_Click;
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
            ComputerMinute.Click += ComputerMinute_Click;
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
            ComputerSecond.Click += ComputerSecond_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(200, 210);
            button1.Name = "button1";
            button1.Size = new Size(172, 48);
            button1.TabIndex = 2;
            button1.Text = "Start / Dtop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 282);
            button2.Name = "button2";
            button2.Size = new Size(172, 49);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F);
            label2.Location = new Point(41, 32);
            label2.Name = "label2";
            label2.Size = new Size(199, 46);
            label2.TabIndex = 4;
            label2.Text = "Stop Wach";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(157, 108);
            label3.Name = "label3";
            label3.Size = new Size(58, 61);
            label3.TabIndex = 5;
            label3.Text = " 0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(256, 108);
            label4.Name = "label4";
            label4.Size = new Size(58, 61);
            label4.TabIndex = 6;
            label4.Text = " 0";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(359, 108);
            label5.Name = "label5";
            label5.Size = new Size(58, 61);
            label5.TabIndex = 7;
            label5.Text = " 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 615);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
