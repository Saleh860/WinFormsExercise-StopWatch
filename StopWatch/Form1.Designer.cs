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
            label4 = new Label();
            label2 = new Label();
            label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            button1 = new Button();
            button = new Button();
            l2 = new Label();
            l3 = new Label();
            l1 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 449);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 0;
            label1.Text = "Computer Clock";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 529);
            label4.Name = "label4";
            label4.Size = new Size(58, 61);
            label4.TabIndex = 1;
            label4.Text = "00";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 529);
            label2.Name = "label2";
            label2.Size = new Size(58, 61);
            label2.TabIndex = 1;
            label2.Text = "00";
            // 
            // label
            // 
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(359, 529);
            label.Name = "label";
            label.Size = new Size(58, 61);
            label.TabIndex = 1;
            label.Text = "00";
            label.Click += ComputerSecond_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 211);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 3;
            label3.Text = "stop watch";
            // 
            // button1
            // 
            button1.Location = new Point(231, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "start/stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button
            // 
            button.Location = new Point(231, 417);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 5;
            button.Text = "clear";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // l2
            // 
            l2.BorderStyle = BorderStyle.FixedSingle;
            l2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            l2.Location = new Point(253, 273);
            l2.Name = "l2";
            l2.Size = new Size(58, 61);
            l2.TabIndex = 8;
            l2.Text = "00";
            // 
            // l3
            // 
            l3.BorderStyle = BorderStyle.FixedSingle;
            l3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            l3.Location = new Point(134, 273);
            l3.Name = "l3";
            l3.Size = new Size(58, 61);
            l3.TabIndex = 9;
            l3.Text = "00";
            l3.Click += l3_Click;
            // 
            // l1
            // 
            l1.BorderStyle = BorderStyle.FixedSingle;
            l1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            l1.Location = new Point(359, 273);
            l1.Name = "l1";
            l1.Size = new Size(58, 61);
            l1.TabIndex = 10;
            l1.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 550);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 294);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 13;
            label8.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(326, 550);
            label9.Name = "label9";
            label9.Size = new Size(12, 20);
            label9.TabIndex = 14;
            label9.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(326, 297);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 15;
            label10.Text = ":";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(l1);
            Controls.Add(l3);
            Controls.Add(l2);
            Controls.Add(button);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label4);
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
        private Label label4;
        private Label label2;
        private Label label;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Button button1;
        private Button button;
        private Label l2;
        private Label l3;
        private Label l1;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private System.Windows.Forms.Timer timer2;
    }
}
