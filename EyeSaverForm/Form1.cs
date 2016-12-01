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
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimer(WorkIntervalTextBox.Text);
            //WindowState = FormWindowState.Minimized;
            ShowWorkStarted();
        }

        private void ShowWorkStarted()
        {

            timer1.Enabled = true;
            DateTime startTime  = DateTime.Now;
            timer1.Tick +=
                (obj, args) =>
                    label3.Text = (TimeSpan.FromMinutes(_intervalTime/1000) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
            WorkPeriodBox.Visible = false;
            WorkStartedBox.Visible = true;

        }
        private void SetupAndStartIntervalTimer(string intervalPeriodMins)
        {
            

            intervalTimer.Tick += BreakTimeEvent;
            intervalTimer.Enabled = true;
            _intervalTime = GetMilliseconds(intervalPeriodMins);
            intervalTimer.Interval = _intervalTime;
            intervalTimer.Start();
        }

        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins)*1000;
            return intervalInMilliseconds;
        }

        private void BreakTimeEvent(object sender, EventArgs eventInfo)
        {
            if (BreakStartedBox.Visible)
            {
                ShowStartWorkBox();
                HideBreakStartedBox();               
            }
            else
            {
                ShowStartBreakBox();
                HideWorkStartedBox();
            }
            

            intervalTimer.Stop();

        }

        private void ShowStartWorkBox()
        {
            StartWorkBox.Visible = true;
        }

        private void HideBreakStartedBox()
        {
            BreakStartedBox.Visible = false;
        }

        private void HideWorkStartedBox()
        {
            WorkStartedBox.Visible = false;
        }

        private void ShowStartBreakBox()
        {
            StartBreakBox.Visible = true;

        }

        private void StartBreakYes_Click(object sender, EventArgs e)
        {
            BreakPeriodBox.Visible = true;
            StartBreakBox.Visible = false;

        }

        private void ShowBreakStarted()
        {
            timer1.Enabled = true;
            DateTime startTime = DateTime.Now;
            timer1.Tick +=
                (obj, args) =>
                    label6.Text = (TimeSpan.FromMinutes(_intervalTime / 1000) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss");
            BreakPeriodBox.Visible = false;
            BreakStartedBox.Visible = true;
        }

        private void StartBreakButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimer(BreakIntervalTextBox.Text);
            //WindowState = FormWindowState.Minimized;
            ShowBreakStarted();
        }

        private void StartWorkYes_Click(object sender, EventArgs e)
        {
            WorkPeriodBox.Visible = true;
            StartWorkBox.Visible = false;
        }
    }
}
