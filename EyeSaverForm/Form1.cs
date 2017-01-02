using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EyeSaverForm
{
    public partial class Form1 : Form
    {
        private int _intervalTime;
        public Form1()
        {
            InitializeComponent();
            WorkPeriodBox.Left = (ClientSize.Width - WorkPeriodBox.Width) / 2;
            WorkPeriodBox.Top = (ClientSize.Height - WorkPeriodBox.Height) / 2;
        }

        private void startWorkButton_Click(object sender, EventArgs e)
        {
            SetupAndStartWorkIntervalTimer(WorkIntervalTextBox.Text);
            ShowCountdown("Countdown to break");
            WindowState = FormWindowState.Minimized;
        }

        //timer initiation for countdown display
        private void ShowCountdown(string labelText)
        {
            label1.Text = labelText;
            timer1.Enabled = true;
            DateTime startTime = DateTime.Now;
            timer1.Tick +=
                (obj, args) =>
                    label3.Text = (TimeSpan.FromMinutes(_intervalTime / 1000) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
            HideWorkPeriodBox();
            ShowWorkStartedBox();
        }

        private void HideWorkPeriodBox()
        {
            WorkPeriodBox.Visible = false;
        }

        private void ShowWorkStartedBox()
        {
            WorkStartedBox.Visible = true;
            WorkStartedBox.Left = (ClientSize.Width - WorkStartedBox.Width) / 2;
            WorkStartedBox.Top = (ClientSize.Height - WorkStartedBox.Height) / 2;
        }

        // iniates timer till next break
        private void SetupAndStartWorkIntervalTimer(string intervalPeriodMins)
        {
            timeTillBreakTimer.Tick += WorkBreakTimeEvent;
            timeTillBreakTimer.Enabled = true;
            _intervalTime = GetMilliseconds(intervalPeriodMins);
            timeTillBreakTimer.Interval = _intervalTime;
            timeTillBreakTimer.Start();
        }

        // break time! 
        private void WorkBreakTimeEvent(object sender, EventArgs eventInfo)
        {
            WindowState = FormWindowState.Maximized;
            ShowStartBreakBox();
            HideWorkStartedBox();
            timeTillBreakTimer.Stop();

        }

        private void ShowStartBreakBox()
        {
            StartBreakBox.Visible = true;
            StartBreakBox.Left = (ClientSize.Width - StartBreakBox.Width) / 2;
            StartBreakBox.Top = (ClientSize.Height - StartBreakBox.Height) / 2;


        }
        private void HideWorkStartedBox()
        {
            WorkStartedBox.Visible = false;
        }

        // star break - Yes
        private void StartBreakYes_Click(object sender, EventArgs e)
        {
            ShowBreakPeriodBox();
            HideStartBreakBox();
        }

        private void HideStartBreakBox()
        {
            StartBreakBox.Visible = false;
        }

        private void ShowBreakPeriodBox()
        {
            BreakPeriodBox.Visible = true;
            BreakPeriodBox.Left = (ClientSize.Width - BreakPeriodBox.Width) / 2;
            BreakPeriodBox.Top = (ClientSize.Height - BreakPeriodBox.Height) / 2;
        }

        // set break-time duration up
        private void StartBreakButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimerForBreak(BreakIntervalTextBox.Text);
            HideBreakPeriodBox();
            ShowCountdown("Count down to work");
            WindowState = FormWindowState.Minimized;
        }

        private void HideBreakPeriodBox()
        {
            BreakPeriodBox.Visible = false;
        }

        // initiates timer till work starts again 
        private void SetupAndStartIntervalTimerForBreak(string breakIntervalPeriodMins)
        {
            timeTillWorkTimer.Tick += BreakTimeEvent;
            timeTillWorkTimer.Enabled = true;
            _intervalTime = GetMilliseconds(breakIntervalPeriodMins);
            timeTillWorkTimer.Interval = _intervalTime;
            timeTillWorkTimer.Start();
        }

        // break time is over event
        private void BreakTimeEvent(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            HideBreakStartedBox();
            ShowStartWorkBox();
            HideWorkStartedBox();
            timeTillWorkTimer.Stop();
        }

        private void HideBreakStartedBox()
        {
            BreakStartedBox.Visible = false;
        }
        private void ShowStartWorkBox()
        {
            StartWorkBox.Visible = true;
            StartWorkBox.Left = (ClientSize.Width - StartWorkBox.Width) / 2;
            StartWorkBox.Top = (ClientSize.Height - StartWorkBox.Height) / 2;
        }

        // start work again set up
        private void StartWorkYes_Click(object sender, EventArgs e)
        {
            ShowWorkPeriodBox();
            HideStartWorkBox();
        }

        private void HideStartWorkBox()
        {
            StartWorkBox.Visible = false;
        }

        private void ShowWorkPeriodBox()
        {
            WorkPeriodBox.Visible = true;
            WorkPeriodBox.Left = (ClientSize.Width - WorkPeriodBox.Width) / 2;
            WorkPeriodBox.Top = (ClientSize.Height - WorkPeriodBox.Height) / 2;
        }

        //shared 
        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins) * 1000;
            return intervalInMilliseconds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IntervalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
