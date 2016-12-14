﻿using System;
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
            WorkPeriodBox.Visible = false;
            WorkStartedBox.Visible = true;
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

        }
        private void HideWorkStartedBox()
        {
            WorkStartedBox.Visible = false;
        }

        // star break - Yes
        private void StartBreakYes_Click(object sender, EventArgs e)
        {
            BreakPeriodBox.Visible = true;
            StartBreakBox.Visible = false;
          
        }

        // set break-time duration up
        private void StartBreakButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimerForBreak(BreakIntervalTextBox.Text);
            BreakPeriodBox.Visible = false;
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
        }

        // start work again set up
        private void StartWorkYes_Click(object sender, EventArgs e)
        {
            WorkPeriodBox.Visible = true;
            StartWorkBox.Visible = false;
        }

        //shared 
        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins) * 1000;
            return intervalInMilliseconds;
        }

    }
}
