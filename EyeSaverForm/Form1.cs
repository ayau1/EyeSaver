using System;
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
                    label3.Text = (TimeSpan.FromMinutes(_intervalTime) - (DateTime.Now - startTime)).ToString("mm\\:ss");//ToString("hh\\:mm\\:ss");
            HideBox(WorkPeriodBox);
            ShowBox(WorkStartedBox);
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
            ShowBox(StartBreakBox);
            HideBox(WorkStartedBox);
            timeTillBreakTimer.Stop();

        }
        // star break - Yes
        private void StartBreakYes_Click(object sender, EventArgs e)
        {
            ShowBox(BreakPeriodBox);
            HideBox(StartBreakBox);          
        }
        // set break-time duration up
        private void StartBreakButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimerForBreak(BreakIntervalTextBox.Text);
            HideBox(BreakPeriodBox);
            ShowCountdown("Count down to work");
            WindowState = FormWindowState.Minimized;
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
            WindowState = FormWindowState.Maximized;;
            HideBox(BreakStartedBox);
            ShowBox(StartWorkBox);
            HideBox(WorkStartedBox);
            timeTillWorkTimer.Stop();
        }
        // start work again set up
        private void StartWorkYes_Click(object sender, EventArgs e)
        {
            ShowBox(WorkPeriodBox);
            HideBox(StartWorkBox);
        }
        //shared 
        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins) * 60000;
            return intervalInMilliseconds;
        }

        private void ShowBox(GroupBox box)
        {
            box.Visible = true;
            box.Left = (ClientSize.Width - WorkStartedBox.Width) / 2;
            box.Top = (ClientSize.Height - WorkStartedBox.Height) / 2;
        }

        private void HideBox(GroupBox box)
        {
            box.Visible = false;
        }
    }
}
