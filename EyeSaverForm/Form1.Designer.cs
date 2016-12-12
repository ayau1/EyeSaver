namespace EyeSaverForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.WorkIntervalTextBox = new System.Windows.Forms.TextBox();
            this.startWorkButton = new System.Windows.Forms.Button();
            this.timeTillBreakTimer = new System.Windows.Forms.Timer(this.components);
            this.WorkPeriodBox = new System.Windows.Forms.GroupBox();
            this.WorkStartedBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBreakBox = new System.Windows.Forms.GroupBox();
            this.StartBreakYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BreakPeriodBox = new System.Windows.Forms.GroupBox();
            this.StartBreakButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BreakIntervalTextBox = new System.Windows.Forms.TextBox();
            this.BreakStartedBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartWorkBox = new System.Windows.Forms.GroupBox();
            this.StartWorkYes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timeTillWorkTimer = new System.Windows.Forms.Timer(this.components);
            this.WorkPeriodBox.SuspendLayout();
            this.WorkStartedBox.SuspendLayout();
            this.StartBreakBox.SuspendLayout();
            this.BreakPeriodBox.SuspendLayout();
            this.BreakStartedBox.SuspendLayout();
            this.StartWorkBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(22, 20);
            this.IntervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(140, 13);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Enter work period in minutes";
            // 
            // WorkIntervalTextBox
            // 
            this.WorkIntervalTextBox.Location = new System.Drawing.Point(25, 67);
            this.WorkIntervalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkIntervalTextBox.Name = "WorkIntervalTextBox";
            this.WorkIntervalTextBox.Size = new System.Drawing.Size(68, 20);
            this.WorkIntervalTextBox.TabIndex = 1;
            // 
            // startWorkButton
            // 
            this.startWorkButton.Location = new System.Drawing.Point(25, 110);
            this.startWorkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startWorkButton.Name = "startWorkButton";
            this.startWorkButton.Size = new System.Drawing.Size(73, 24);
            this.startWorkButton.TabIndex = 2;
            this.startWorkButton.Text = "Start work";
            this.startWorkButton.UseVisualStyleBackColor = true;
            this.startWorkButton.Click += new System.EventHandler(this.startWorkButton_Click);
            // 
            // WorkPeriodBox
            // 
            this.WorkPeriodBox.Controls.Add(this.IntervalLabel);
            this.WorkPeriodBox.Controls.Add(this.startWorkButton);
            this.WorkPeriodBox.Controls.Add(this.WorkIntervalTextBox);
            this.WorkPeriodBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WorkPeriodBox.Location = new System.Drawing.Point(61, 2);
            this.WorkPeriodBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkPeriodBox.Name = "WorkPeriodBox";
            this.WorkPeriodBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkPeriodBox.Size = new System.Drawing.Size(189, 148);
            this.WorkPeriodBox.TabIndex = 3;
            this.WorkPeriodBox.TabStop = false;
            // 
            // WorkStartedBox
            // 
            this.WorkStartedBox.Controls.Add(this.label3);
            this.WorkStartedBox.Controls.Add(this.label1);
            this.WorkStartedBox.Location = new System.Drawing.Point(61, 154);
            this.WorkStartedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkStartedBox.Name = "WorkStartedBox";
            this.WorkStartedBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkStartedBox.Size = new System.Drawing.Size(189, 131);
            this.WorkStartedBox.TabIndex = 4;
            this.WorkStartedBox.TabStop = false;
            this.WorkStartedBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "WorkStopwatch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work started";
            // 
            // StartBreakBox
            // 
            this.StartBreakBox.Controls.Add(this.StartBreakYes);
            this.StartBreakBox.Controls.Add(this.label2);
            this.StartBreakBox.Location = new System.Drawing.Point(61, 289);
            this.StartBreakBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBreakBox.Name = "StartBreakBox";
            this.StartBreakBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBreakBox.Size = new System.Drawing.Size(183, 133);
            this.StartBreakBox.TabIndex = 5;
            this.StartBreakBox.TabStop = false;
            this.StartBreakBox.Visible = false;
            // 
            // StartBreakYes
            // 
            this.StartBreakYes.Location = new System.Drawing.Point(21, 55);
            this.StartBreakYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBreakYes.Name = "StartBreakYes";
            this.StartBreakYes.Size = new System.Drawing.Size(37, 25);
            this.StartBreakYes.TabIndex = 1;
            this.StartBreakYes.Text = "YES";
            this.StartBreakYes.UseVisualStyleBackColor = true;
            this.StartBreakYes.Click += new System.EventHandler(this.StartBreakYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start break ?";
            // 
            // BreakPeriodBox
            // 
            this.BreakPeriodBox.Controls.Add(this.StartBreakButton);
            this.BreakPeriodBox.Controls.Add(this.label4);
            this.BreakPeriodBox.Controls.Add(this.BreakIntervalTextBox);
            this.BreakPeriodBox.Location = new System.Drawing.Point(61, 426);
            this.BreakPeriodBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakPeriodBox.Name = "BreakPeriodBox";
            this.BreakPeriodBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakPeriodBox.Size = new System.Drawing.Size(189, 143);
            this.BreakPeriodBox.TabIndex = 6;
            this.BreakPeriodBox.TabStop = false;
            this.BreakPeriodBox.Visible = false;
            // 
            // StartBreakButton
            // 
            this.StartBreakButton.Location = new System.Drawing.Point(25, 81);
            this.StartBreakButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBreakButton.Name = "StartBreakButton";
            this.StartBreakButton.Size = new System.Drawing.Size(89, 22);
            this.StartBreakButton.TabIndex = 2;
            this.StartBreakButton.Text = "Start break";
            this.StartBreakButton.UseVisualStyleBackColor = true;
            this.StartBreakButton.Click += new System.EventHandler(this.StartBreakButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter break period in minutes";
            // 
            // BreakIntervalTextBox
            // 
            this.BreakIntervalTextBox.Location = new System.Drawing.Point(25, 47);
            this.BreakIntervalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakIntervalTextBox.Name = "BreakIntervalTextBox";
            this.BreakIntervalTextBox.Size = new System.Drawing.Size(68, 20);
            this.BreakIntervalTextBox.TabIndex = 0;
            // 
            // BreakStartedBox
            // 
            this.BreakStartedBox.Controls.Add(this.label6);
            this.BreakStartedBox.Controls.Add(this.label5);
            this.BreakStartedBox.Location = new System.Drawing.Point(81, 685);
            this.BreakStartedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakStartedBox.Name = "BreakStartedBox";
            this.BreakStartedBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BreakStartedBox.Size = new System.Drawing.Size(189, 113);
            this.BreakStartedBox.TabIndex = 7;
            this.BreakStartedBox.TabStop = false;
            this.BreakStartedBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Break Stopwatch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Break started";
            // 
            // StartWorkBox
            // 
            this.StartWorkBox.Controls.Add(this.StartWorkYes);
            this.StartWorkBox.Controls.Add(this.label7);
            this.StartWorkBox.Location = new System.Drawing.Point(267, 297);
            this.StartWorkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartWorkBox.Name = "StartWorkBox";
            this.StartWorkBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartWorkBox.Size = new System.Drawing.Size(158, 125);
            this.StartWorkBox.TabIndex = 8;
            this.StartWorkBox.TabStop = false;
            this.StartWorkBox.Visible = false;
            // 
            // StartWorkYes
            // 
            this.StartWorkYes.Location = new System.Drawing.Point(19, 47);
            this.StartWorkYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartWorkYes.Name = "StartWorkYes";
            this.StartWorkYes.Size = new System.Drawing.Size(41, 25);
            this.StartWorkYes.TabIndex = 1;
            this.StartWorkYes.Text = "YES";
            this.StartWorkYes.UseVisualStyleBackColor = true;
            this.StartWorkYes.Click += new System.EventHandler(this.StartWorkYes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start work ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 567);
            this.Controls.Add(this.StartWorkBox);
            this.Controls.Add(this.BreakStartedBox);
            this.Controls.Add(this.BreakPeriodBox);
            this.Controls.Add(this.StartBreakBox);
            this.Controls.Add(this.WorkStartedBox);
            this.Controls.Add(this.WorkPeriodBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WorkPeriodBox.ResumeLayout(false);
            this.WorkPeriodBox.PerformLayout();
            this.WorkStartedBox.ResumeLayout(false);
            this.WorkStartedBox.PerformLayout();
            this.StartBreakBox.ResumeLayout(false);
            this.StartBreakBox.PerformLayout();
            this.BreakPeriodBox.ResumeLayout(false);
            this.BreakPeriodBox.PerformLayout();
            this.BreakStartedBox.ResumeLayout(false);
            this.BreakStartedBox.PerformLayout();
            this.StartWorkBox.ResumeLayout(false);
            this.StartWorkBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox WorkIntervalTextBox;
        private System.Windows.Forms.Button startWorkButton;
        private System.Windows.Forms.Timer timeTillBreakTimer;
        private System.Windows.Forms.GroupBox WorkPeriodBox;
        private System.Windows.Forms.GroupBox WorkStartedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StartBreakBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartBreakYes;
        private System.Windows.Forms.GroupBox BreakPeriodBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BreakIntervalTextBox;
        private System.Windows.Forms.Button StartBreakButton;
        private System.Windows.Forms.GroupBox BreakStartedBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox StartWorkBox;
        private System.Windows.Forms.Button StartWorkYes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timeTillWorkTimer;
    }
}

