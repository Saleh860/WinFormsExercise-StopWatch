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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ComputerHour = new System.Windows.Forms.Label();
            this.ComputerMinute = new System.Windows.Forms.Label();
            this.ComputerSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.partofsec = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            this.ComputerHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerHour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputerHour.Location = new System.Drawing.Point(157, 468);
            this.ComputerHour.Name = "ComputerHour";
            this.ComputerHour.Size = new System.Drawing.Size(58, 61);
            this.ComputerHour.TabIndex = 1;
            this.ComputerHour.Text = "00";
            // 
            // ComputerMinute
            // 
            this.ComputerMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerMinute.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputerMinute.Location = new System.Drawing.Point(256, 468);
            this.ComputerMinute.Name = "ComputerMinute";
            this.ComputerMinute.Size = new System.Drawing.Size(58, 61);
            this.ComputerMinute.TabIndex = 1;
            this.ComputerMinute.Text = "00";
            // 
            // ComputerSecond
            // 
            this.ComputerSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerSecond.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputerSecond.Location = new System.Drawing.Point(359, 468);
            this.ComputerSecond.Name = "ComputerSecond";
            this.ComputerSecond.Size = new System.Drawing.Size(58, 61);
            this.ComputerSecond.TabIndex = 1;
            this.ComputerSecond.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // partofsec
            // 
            this.partofsec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partofsec.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partofsec.Location = new System.Drawing.Point(359, 182);
            this.partofsec.Name = "partofsec";
            this.partofsec.Size = new System.Drawing.Size(58, 61);
            this.partofsec.TabIndex = 2;
            this.partofsec.Text = "00";
            // 
            // sec
            // 
            this.sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sec.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sec.Location = new System.Drawing.Point(256, 182);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(58, 61);
            this.sec.TabIndex = 3;
            this.sec.Text = "00";
            // 
            // min
            // 
            this.min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.min.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.min.Location = new System.Drawing.Point(157, 182);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(58, 61);
            this.min.TabIndex = 4;
            this.min.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(230, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(333, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(333, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = ":";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(231, 286);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(122, 29);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "start / stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(230, 321);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(122, 29);
            this.reset.TabIndex = 10;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 615);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.min);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.partofsec);
            this.Controls.Add(this.ComputerSecond);
            this.Controls.Add(this.ComputerMinute);
            this.Controls.Add(this.ComputerHour);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label ComputerHour;
        private Label ComputerMinute;
        private Label ComputerSecond;
        private System.Windows.Forms.Timer timer1;
        private Label partofsec;
        private Label sec;
        private Label min;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button stopButton;
        private Button reset;
    }
}
