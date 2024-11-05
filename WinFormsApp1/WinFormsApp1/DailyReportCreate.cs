using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class DailyReportCreate : Form
    {
        public string DateData { get; private set; }
        public string ShiftData { get; private set; }
        public string LineData { get; private set; }
        public string StationData { get; private set; }
        public string StartTimeData { get; private set; }
        public string EndTimeData { get; private set; }
        public string ElapsedTimeData { get; private set; }
        public string Cat1Data { get; private set; }
        public string Cat2Data { get; private set; }
        public string DeviceData { get; private set; }
        public string ProblemReasonData { get; private set; }
        public string ProblemData { get; private set; }
        public string ActionData { get; private set; }
        public string WorkerData { get; private set; }


        public DailyReportCreate()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            ShiftComboBox.Items.Add("1");
            ShiftComboBox.Items.Add("2");
            ShiftComboBox.Items.Add("3");
            ShiftComboBox.SelectedIndex = 0; // Set default selected item

            LineComboBox.Items.Add("ENG");
            LineComboBox.Items.Add("FCM");
            LineComboBox.Items.Add("FCM Trolley");
            LineComboBox.Items.Add("RCM");
            LineComboBox.Items.Add("PER");
            LineComboBox.Items.Add("CPM");
            LineComboBox.Items.Add("IP Sub");
            LineComboBox.Items.Add("CPM Trolley #1");
            LineComboBox.Items.Add("CPM Trolley #2");
            LineComboBox.Items.Add("FEM");
            LineComboBox.Items.Add("FEM Trolley");
            LineComboBox.Items.Add("BF");
            LineComboBox.Items.Add("BR");
            LineComboBox.Items.Add("CCR");
            LineComboBox.SelectedIndex = 0;

            Category1ComboBox.Items.Add("MES");
            Category1ComboBox.Items.Add("Line");
            Category1ComboBox.SelectedIndex = 0;

            Category2ComboBox.Items.Add("H/W");
            Category2ComboBox.Items.Add("Program");
            Category2ComboBox.Items.Add("Line Support");
            Category2ComboBox.Items.Add("Data");
            Category2ComboBox.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = StartTimePicker.Value;
            DateTime endTime = EndTimePicker.Value;
            TimeSpan elapsedTime = endTime - startTime;

            DateData = DateTimePicker.Value.ToString("yyyy-MM-dd");
            ShiftData = ShiftComboBox.SelectedItem.ToString();
            LineData = LineComboBox.SelectedItem.ToString();
            StationData = StationTextBox.Text.ToString();
            StartTimeData = StartTimePicker.Value.ToString("HH:MM:00");
            EndTimeData = EndTimePicker.Value.ToString("HH:MM:00");
            ElapsedTimeData = elapsedTime.ToString(@"hh\:mm\:ss");
            Cat1Data = Category1ComboBox.SelectedItem.ToString();
            Cat2Data = Category2ComboBox.SelectedItem.ToString();
            DeviceData = DeviceTextBox.Text.ToString();
            ProblemReasonData = ProblemReasonTextBox.Text.ToString();
            ProblemData = ProblemTextBox.Text.ToString();
            ActionData = ActionTextBox.Text.ToString();
            WorkerData = WorkerTextBox.Text.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
