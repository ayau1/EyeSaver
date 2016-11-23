using System;
using System.Windows.Forms;

namespace EyeSaverForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void minutesToWorkSubmitButton_Click(object sender, EventArgs e)
        {
            SetupAndStartIntervalTimer(numberOfMinsToWorkTextBox.Text);
        }

        private void SetupAndStartIntervalTimer(string numberOfMinsToWork)
        {
            breakTimer.Tick += BackToWorkTimeEvent;
            breakTimer.Enabled = true;
            breakTimer.Interval = GetMilliseconds(numberOfMinsToWork);
            breakTimer.Start();
        }

        private int GetMilliseconds(string numberOfMinsToWork)
        {
            int intervalInMilliseconds = int.Parse(numberOfMinsToWork)*1000;
            return intervalInMilliseconds;
        }

        private void BackToWorkTimeEvent(object sender, EventArgs eventInfo)
        {
            ShowWorkForm();
            Hide();
            breakTimer.Stop();
        }

        private void ShowWorkForm()
        {
            var form1 = new Form1();
            form1.Show();
            form1.WindowState = FormWindowState.Normal;
            form1.BringToFront();
            form1.TopMost = true;
            form1.Focus();
        }
    }
}
