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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            ComputerMinute.Click += ComputerMinute_Click;
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
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(359, 153);
            label2.Name = "label2";
            label2.Size = new Size(58, 61);
            label2.TabIndex = 2;
            label2.Text = "00";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 153);
            label3.Name = "label3";
            label3.Size = new Size(58, 61);
            label3.TabIndex = 3;
            label3.Text = "00";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(157, 153);
            label4.Name = "label4";
            label4.Size = new Size(58, 61);
            label4.TabIndex = 4;
            label4.Text = "00";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(134, 284);
            label5.Name = "label5";
            label5.Size = new Size(0, 46);
            label5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(134, 284);
            label6.Name = "label6";
            label6.Size = new Size(0, 46);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(168, 68);
            label7.Name = "label7";
            label7.Size = new Size(213, 46);
            label7.TabIndex = 7;
            label7.Text = "Stop Watch";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(228, 249);
            button1.Name = "button1";
            button1.Size = new Size(116, 46);
            button1.TabIndex = 8;
            button1.Text = "Start/Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 301);
            button2.Name = "button2";
            button2.Size = new Size(116, 45);
            button2.TabIndex = 9;
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
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}
