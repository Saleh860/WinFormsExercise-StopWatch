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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(137, 273);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F);
            ComputerHour.Location = new Point(137, 351);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(51, 46);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F);
            ComputerMinute.Location = new Point(224, 351);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(51, 46);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F);
            ComputerSecond.Location = new Point(314, 351);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(51, 46);
            ComputerSecond.TabIndex = 1;
            ComputerSecond.Text = "00";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(200, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "start/stop";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 711);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 73);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 4;
            label3.Text = "L2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 73);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 5;
            label4.Text = "L3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 73);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 6;
            label5.Text = "L1";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(200, 166);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(ComputerHour);
            Controls.Add(label1);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}
