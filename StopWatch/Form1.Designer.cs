﻿namespace StopWatch
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
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F);
            label1.Location = new Point(196, 455);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 54);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F);
            ComputerHour.Location = new Point(196, 585);
            ComputerHour.Margin = new Padding(4, 0, 4, 0);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(72, 75);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F);
            ComputerMinute.Location = new Point(320, 585);
            ComputerMinute.Margin = new Padding(4, 0, 4, 0);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(72, 75);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F);
            ComputerSecond.Location = new Point(449, 585);
            ComputerSecond.Margin = new Padding(4, 0, 4, 0);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(72, 75);
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
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(196, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 75);
            label2.TabIndex = 2;
            label2.Text = "00";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(320, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 75);
            label3.TabIndex = 3;
            label3.Text = "00";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(449, 165);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 75);
            label4.TabIndex = 4;
            label4.Text = "00";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 20F);
            label5.Location = new Point(320, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 54);
            label5.TabIndex = 5;
            label5.Text = "Timer";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(124, 329);
            button1.Name = "button1";
            button1.Size = new Size(144, 79);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(449, 329);
            button2.Name = "button2";
            button2.Size = new Size(144, 79);
            button2.TabIndex = 7;
            button2.Text = "End";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 768);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(ComputerHour);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}
