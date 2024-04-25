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
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            ComputerHour.Click += ComputerHour_Click;
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
            ComputerSecond.Click += ComputerSecond_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(220, 195);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Start/Stop";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(220, 243);
            button2.Name = "button2";
            button2.Size = new Size(94, 27);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Stop Watch";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(359, 49);
            label4.Name = "label4";
            label4.Size = new Size(58, 61);
            label4.TabIndex = 8;
            label4.Text = "00";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(256, 49);
            label3.Name = "label3";
            label3.Size = new Size(58, 61);
            label3.TabIndex = 9;
            label3.Text = "00";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 61);
            label2.TabIndex = 10;
            label2.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
