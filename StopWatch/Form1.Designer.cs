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
            swS = new Label();
            swM = new Label();
            swH = new Label();
            label5 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 273);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            // 
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerHour.Location = new Point(137, 351);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(51, 46);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
            ComputerHour.Click += ComputerHour_Click;
            // 
            // ComputerMinute
            // 
            ComputerMinute.BorderStyle = BorderStyle.FixedSingle;
            ComputerMinute.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerMinute.Location = new Point(224, 351);
            ComputerMinute.Name = "ComputerMinute";
            ComputerMinute.Size = new Size(51, 46);
            ComputerMinute.TabIndex = 1;
            ComputerMinute.Text = "00";
            ComputerMinute.Click += ComputerMinute_Click;
            // 
            // ComputerSecond
            // 
            ComputerSecond.BorderStyle = BorderStyle.FixedSingle;
            ComputerSecond.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ComputerSecond.Location = new Point(314, 351);
            ComputerSecond.Name = "ComputerSecond";
            ComputerSecond.Size = new Size(51, 46);
            ComputerSecond.TabIndex = 1;
            ComputerSecond.Text = "00";
            ComputerSecond.Click += ComputerSecond_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // swS
            // 
            swS.BorderStyle = BorderStyle.FixedSingle;
            swS.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            swS.Location = new Point(305, 139);
            swS.Name = "swS";
            swS.Size = new Size(49, 46);
            swS.TabIndex = 2;
            swS.Text = "00";
            swS.Click += swS_Click;
            // 
            // swM
            // 
            swM.BorderStyle = BorderStyle.FixedSingle;
            swM.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            swM.Location = new Point(215, 139);
            swM.Name = "swM";
            swM.Size = new Size(51, 46);
            swM.TabIndex = 3;
            swM.Text = "00";
            // 
            // swH
            // 
            swH.BorderStyle = BorderStyle.FixedSingle;
            swH.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            swH.Location = new Point(137, 139);
            swH.Name = "swH";
            swH.Size = new Size(51, 46);
            swH.TabIndex = 4;
            swH.Text = "00";
            swH.Click += swH_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(215, 61);
            label5.Name = "label5";
            label5.Size = new Size(139, 37);
            label5.TabIndex = 5;
            label5.Text = "stopwatch";
            label5.Click += label5_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(215, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 227);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 416);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(swS);
            Controls.Add(swM);
            Controls.Add(swH);
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
        private Label swS;
        private Label swM;
        private Label swH;
        private Label label5;
        private System.Windows.Forms.Timer timer2;
        private Button button1;
        private Button button2;
    }
}
