using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EyeSaverForm
{
    public partial class Form1 : Form
    {
        private int _workTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimer(IntervalTextBox.Text);
            //WindowState = FormWindowState.Minimized;
            ShowWorkStarted();
        }

        private void ShowWorkStarted()
        {

            timer1.Enabled = true;
            DateTime startTime  = DateTime.Now;
            timer1.Tick +=
                (obj, args) =>
                    label3.Text = (TimeSpan.FromMinutes(_workTime/1000) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
            WorkPeriodBox.Visible = false;
            WorkStartedBox.Visible = true;

        }
        private void SetupAndStartIntervalTimer(string intervalPeriodMins)
        {
            

            intervalTimer.Tick += BreakTimeEvent;
            intervalTimer.Enabled = true;
            _workTime = GetMilliseconds(intervalPeriodMins);
            intervalTimer.Interval = _workTime;
            intervalTimer.Start();
        }

        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins)*1000;
            return intervalInMilliseconds;
        }

        private void BreakTimeEvent(object sender, EventArgs eventInfo)
        {
            ShowStartBreakBox();
            HideWorkStartedBox();
            intervalTimer.Stop();
            
        }

        private void HideWorkStartedBox()
        {
            WorkStartedBox.Visible = false;
        }

        private void ShowStartBreakBox()
        {
            StartBreakBox.Visible = true;

        }

    }
}
