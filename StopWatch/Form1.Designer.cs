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
            Hour = new Label();
            Minute = new Label();
            secand = new Label();
            Stop = new Button();
            Clear = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
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
            // ComputerHour
            // 
            ComputerHour.BorderStyle = BorderStyle.FixedSingle;
            ComputerHour.Font = new Font("Segoe UI", 20F);
            ComputerHour.Location = new Point(157, 468);
            ComputerHour.Name = "ComputerHour";
            ComputerHour.Size = new Size(58, 61);
            ComputerHour.TabIndex = 1;
            ComputerHour.Text = "00";
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
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 181);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // Hour
            // 
            Hour.BorderStyle = BorderStyle.FixedSingle;
            Hour.Font = new Font("Segoe UI", 20F);
            Hour.Location = new Point(157, 86);
            Hour.Name = "Hour";
            Hour.Size = new Size(58, 61);
            Hour.TabIndex = 3;
            Hour.Text = "00";
            // 
            // Minute
            // 
            Minute.BorderStyle = BorderStyle.FixedSingle;
            Minute.Font = new Font("Segoe UI", 20F);
            Minute.Location = new Point(256, 86);
            Minute.Name = "Minute";
            Minute.Size = new Size(58, 61);
            Minute.TabIndex = 4;
            Minute.Text = "00";
            // 
            // secand
            // 
            secand.BorderStyle = BorderStyle.FixedSingle;
            secand.Font = new Font("Segoe UI", 20F);
            secand.Location = new Point(359, 86);
            secand.Name = "secand";
            secand.Size = new Size(58, 61);
            secand.TabIndex = 5;
            secand.Text = "00";
            // 
            // Stop
            // 
            Stop.Location = new Point(189, 201);
            Stop.Name = "Stop";
            Stop.Size = new Size(137, 34);
            Stop.TabIndex = 6;
            Stop.Text = "Start\\stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            Clear.Location = new Point(189, 269);
            Clear.Name = "Clear";
            Clear.Size = new Size(137, 29);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(Clear);
            Controls.Add(Stop);
            Controls.Add(secand);
            Controls.Add(Minute);
            Controls.Add(Hour);
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
        private Label Hour;
        private Label Minute;
        private Label secand;
        private Button Stop;
        private Button Clear;
        private System.Windows.Forms.Timer timer2;
    }
}
