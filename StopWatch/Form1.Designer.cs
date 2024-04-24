
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
            Minute = new Label();
            Sec = new Label();
            Msec = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
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
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Minute
            // 
            Minute.BorderStyle = BorderStyle.FixedSingle;
            Minute.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Minute.Location = new Point(137, 106);
            Minute.Name = "Minute";
            Minute.Size = new Size(51, 46);
            Minute.TabIndex = 1;
            Minute.Text = "00";
            // 
            // Sec
            // 
            Sec.BorderStyle = BorderStyle.FixedSingle;
            Sec.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Sec.Location = new Point(224, 106);
            Sec.Name = "Sec";
            Sec.Size = new Size(51, 46);
            Sec.TabIndex = 1;
            Sec.Text = "00";
            // 
            // Msec
            // 
            Msec.BorderStyle = BorderStyle.FixedSingle;
            Msec.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Msec.Location = new Point(314, 106);
            Msec.Name = "Msec";
            Msec.Size = new Size(51, 46);
            Msec.TabIndex = 1;
            Msec.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(212, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Start / Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 205);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 46);
            label5.Name = "label5";
            label5.Size = new Size(164, 37);
            label5.TabIndex = 0;
            label5.Text = "Stop watch";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 434);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ComputerSecond);
            Controls.Add(ComputerMinute);
            Controls.Add(Msec);
            Controls.Add(Sec);
            Controls.Add(Minute);
            Controls.Add(ComputerHour);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label ComputerHour;
        private Label ComputerMinute;
        private Label ComputerSecond;
        private System.Windows.Forms.Timer timer1;
        private Label Minute;
        private Label Sec;
        private Label Msec;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}
