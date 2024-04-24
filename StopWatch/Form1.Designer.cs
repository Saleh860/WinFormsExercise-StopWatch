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
            timerMinu = new Label();
            timerSec = new Label();
            timerMicro = new Label();
            label2 = new Label();
            label3 = new Label();
            timerDown = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 364);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerHour.Location = new Point(157, 468);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(58, 61);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerMinute.Location = new Point(256, 468);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(58, 61);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerSecond.Location = new Point(359, 468);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(58, 61);
            ComputerSecond.TabIndex = 1;
            ComputerSecond.Text = "00";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // timerMinu
            // 
            timerMinu.BorderStyle = BorderStyle.FixedSingle;
            timerMinu.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timerMinu.Location = new Point(157, 206);
            timerMinu.Name = "timerMinu";
            timerMinu.Size = new Size(58, 61);
            timerMinu.TabIndex = 2;
            timerMinu.Text = "00";
            // 
            // timerSec
            // 
            timerSec.BorderStyle = BorderStyle.FixedSingle;
            timerSec.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timerSec.Location = new Point(256, 206);
            timerSec.Name = "timerSec";
            timerSec.Size = new Size(58, 61);
            timerSec.TabIndex = 3;
            timerSec.Text = "00";
            // 
            // timerMicro
            // 
            timerMicro.BorderStyle = BorderStyle.FixedSingle;
            timerMicro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            timerMicro.Location = new Point(359, 206);
            timerMicro.Name = "timerMicro";
            timerMicro.Size = new Size(58, 61);
            timerMicro.TabIndex = 4;
            timerMicro.Text = "00";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 207);
            label2.Name = "label2";
            label2.Size = new Size(21, 61);
            label2.TabIndex = 5;
            label2.Text = ":";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(221, 207);
            label3.Name = "label3";
            label3.Size = new Size(32, 61);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // timerDown
            // 
            timerDown.Interval = 1;
            timerDown.Tick += timerDown_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(237, 298);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Start/Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(timerMicro);
            Controls.Add(timerSec);
            Controls.Add(timerMinu);
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
        private Label timerMinu;
        private Label timerSec;
        private Label timerMicro;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timerDown;
        private Button button1;
    }
}
