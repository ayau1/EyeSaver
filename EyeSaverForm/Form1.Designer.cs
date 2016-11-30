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
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.WorkPeriodBox = new System.Windows.Forms.GroupBox();
            this.WorkStartedBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBreakBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WorkPeriodBox.SuspendLayout();
            this.WorkStartedBox.SuspendLayout();
            this.StartBreakBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(33, 31);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(209, 20);
            this.IntervalLabel.TabIndex = 0;
            this.IntervalLabel.Text = "Enter work period in minutes";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(37, 103);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(100, 26);
            this.IntervalTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(37, 170);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 37);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // WorkPeriodBox
            // 
            this.WorkPeriodBox.Controls.Add(this.IntervalLabel);
            this.WorkPeriodBox.Controls.Add(this.submitButton);
            this.WorkPeriodBox.Controls.Add(this.IntervalTextBox);
            this.WorkPeriodBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WorkPeriodBox.Location = new System.Drawing.Point(121, 39);
            this.WorkPeriodBox.Name = "WorkPeriodBox";
            this.WorkPeriodBox.Size = new System.Drawing.Size(284, 228);
            this.WorkPeriodBox.TabIndex = 3;
            this.WorkPeriodBox.TabStop = false;
            // 
            // WorkStartedBox
            // 
            this.WorkStartedBox.Controls.Add(this.label3);
            this.WorkStartedBox.Controls.Add(this.label1);
            this.WorkStartedBox.Location = new System.Drawing.Point(121, 298);
            this.WorkStartedBox.Name = "WorkStartedBox";
            this.WorkStartedBox.Size = new System.Drawing.Size(284, 202);
            this.WorkStartedBox.TabIndex = 4;
            this.WorkStartedBox.TabStop = false;
            this.WorkStartedBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work started";
            // 
            // StartBreakBox
            // 
            this.StartBreakBox.Controls.Add(this.label2);
            this.StartBreakBox.Location = new System.Drawing.Point(130, 559);
            this.StartBreakBox.Name = "StartBreakBox";
            this.StartBreakBox.Size = new System.Drawing.Size(275, 205);
            this.StartBreakBox.TabIndex = 5;
            this.StartBreakBox.TabStop = false;
            this.StartBreakBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Break";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 953);
            this.Controls.Add(this.StartBreakBox);
            this.Controls.Add(this.WorkStartedBox);
            this.Controls.Add(this.WorkPeriodBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WorkPeriodBox.ResumeLayout(false);
            this.WorkPeriodBox.PerformLayout();
            this.WorkStartedBox.ResumeLayout(false);
            this.WorkStartedBox.PerformLayout();
            this.StartBreakBox.ResumeLayout(false);
            this.StartBreakBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.GroupBox WorkPeriodBox;
        private System.Windows.Forms.GroupBox WorkStartedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StartBreakBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

