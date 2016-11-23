using System;
using System.Windows.Forms;

namespace EyeSaverForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimer(IntervalTextBox.Text);
        }

        private void SetupAndStartIntervalTimer(string intervalPeriodMins)
        {
            intervalTimer.Tick += BreakTimeEvent;
            intervalTimer.Enabled = true;
            intervalTimer.Interval = GetMilliseconds(intervalPeriodMins);
            intervalTimer.Start();
        }

        private int GetMilliseconds(string intervalPeriodMins)
        {
            int intervalInMilliseconds = int.Parse(intervalPeriodMins)*1000;
            return intervalInMilliseconds;
        }

        private void BreakTimeEvent(object sender, EventArgs eventInfo)
        {
            ShowBreakForm();
            Hide();
            intervalTimer.Stop();
        }

        private void ShowBreakForm()
        {
            var form2 = new Form2();
            form2.Show();
            form2.WindowState = FormWindowState.Normal;
            form2.BringToFront();
            form2.TopMost = true;
            form2.Focus();
        }
    }
}
