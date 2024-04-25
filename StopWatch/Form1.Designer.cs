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
            lable3 = new Label();
            lable2 = new Label();
            labal1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            L1 = new Label();
            L2 = new Label();
            L3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            // lable3
            // 
            lable3.BorderStyle = BorderStyle.FixedSingle;
            lable3.Font = new Font("Segoe UI", 20F);
            lable3.Location = new Point(157, 468);
            lable3.Name = "lable3";
            lable3.Size = new Size(58, 61);
            lable3.TabIndex = 1;
            lable3.Text = "00";
            // 
            // lable2
            // 
            lable2.BorderStyle = BorderStyle.FixedSingle;
            lable2.Font = new Font("Segoe UI", 20F);
            lable2.Location = new Point(256, 468);
            lable2.Name = "lable2";
            lable2.Size = new Size(58, 61);
            lable2.TabIndex = 1;
            lable2.Text = "00";
            lable2.Click += lable2_Click;
            // 
            // labal1
            // 
            labal1.BorderStyle = BorderStyle.FixedSingle;
            labal1.Font = new Font("Segoe UI", 20F);
            labal1.Location = new Point(350, 468);
            labal1.Name = "labal1";
            labal1.Size = new Size(58, 61);
            labal1.TabIndex = 1;
            labal1.Text = "00";
            labal1.Click += ComputerSecond_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // L1
            // 
            L1.BorderStyle = BorderStyle.FixedSingle;
            L1.Font = new Font("Segoe UI", 20F);
            L1.Location = new Point(350, 167);
            L1.Name = "L1";
            L1.Size = new Size(58, 61);
            L1.TabIndex = 2;
            L1.Text = "00";
            // 
            // L2
            // 
            L2.BorderStyle = BorderStyle.FixedSingle;
            L2.Font = new Font("Segoe UI", 20F);
            L2.Location = new Point(256, 167);
            L2.Name = "L2";
            L2.Size = new Size(58, 61);
            L2.TabIndex = 3;
            L2.Text = "00";
            // 
            // L3
            // 
            L3.BorderStyle = BorderStyle.FixedSingle;
            L3.Font = new Font("Segoe UI", 20F);
            L3.Location = new Point(157, 167);
            L3.Name = "L3";
            L3.Size = new Size(58, 61);
            L3.TabIndex = 4;
            L3.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(236, 315);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(236, 264);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Start/stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 489);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 7;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 489);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 8;
            label6.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 188);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 9;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 188);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 10;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 114);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Stop Wath";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 615);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(L3);
            Controls.Add(L2);
            Controls.Add(L1);
            Controls.Add(labal1);
            Controls.Add(lable2);
            Controls.Add(lable3);
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
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lable3;
        private Label lable2;
        private Label labal1;
        private Label L1;
        private Label L2;
        private Label L3;
    }
}
