using System.Data;

namespace WinFormsApp1
{
    public partial class DailyReportView : Form
    {
        private DataTable DailyReportTable;

        public DailyReportView()
        {
            InitializeComponent();
            InitializeDailyReportTable();
            dataGridView1.DataSource = DailyReportTable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            timer1.Interval = 5000; // 5 seconds
            timer1.Tick += Timer1_Tick;

            this.SuspendLayout();
        }

        private void InitializeDailyReportTable()
        {
            DailyReportTable = new DataTable();

            // Define columns
            DailyReportTable.Columns.Add("Date", typeof(string));
            DailyReportTable.Columns.Add("Shift", typeof(string));
            DailyReportTable.Columns.Add("Line", typeof(string));
            DailyReportTable.Columns.Add("Station", typeof(string));
            DailyReportTable.Columns.Add("Start Time", typeof(string));
            DailyReportTable.Columns.Add("End Time", typeof(string));
            DailyReportTable.Columns.Add("Elapsed Time", typeof(string));
            DailyReportTable.Columns.Add("Category1", typeof(string));
            DailyReportTable.Columns.Add("Category2", typeof(string));
            DailyReportTable.Columns.Add("Device", typeof(string));
            DailyReportTable.Columns.Add("Problem Reason", typeof(string));
            DailyReportTable.Columns.Add("Problem", typeof(string));
            DailyReportTable.Columns.Add("Action", typeof(string));
            DailyReportTable.Columns.Add("Worker", typeof(string));

            dataGridView1.DataSource = DailyReportTable;

            dataGridView1.Columns["Date"].Width = 85;
            dataGridView1.Columns["Shift"].Width = 50;
            dataGridView1.Columns["Line"].Width = 50;
            dataGridView1.Columns["Station"].Width = 50;
            dataGridView1.Columns["Start Time"].Width = 60;
            dataGridView1.Columns["End Time"].Width = 60;
            dataGridView1.Columns["Elapsed Time"].Width = 60;
            dataGridView1.Columns["Category1"].Width = 50;
            dataGridView1.Columns["Category2"].Width = 50;
            dataGridView1.Columns["Device"].Width = 50;
            dataGridView1.Columns["Problem Reason"].Width = 50;
            dataGridView1.Columns["Problem"].Width = 150;
            dataGridView1.Columns["Action"].Width = 150;
            dataGridView1.Columns["Worker"].Width = 50;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DailyReportCreate form2 = new DailyReportCreate();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                DailyReportTable.Rows.Add(form2.DateData, form2.ShiftData, form2.LineData, form2.StationData,
                    form2.StartTimeData, form2.EndTimeData, form2.ElapsedTimeData, form2.Cat1Data, form2.Cat2Data,
                    form2.DeviceData, form2.ProblemReasonData, form2.ProblemData, form2.ActionData, form2.WorkerData);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // SaveCsvToDesktop(); // not sure about auto-save ATM
        }

        private void SaveCsvToDesktop()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Monthly-MES-Report_" + DateTime.Now.ToString("MMM_yyyy") + ".csv";
            string filePath = Path.Combine(desktopPath, fileName);
            SaveToCsv(filePath, DailyReportTable);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCsvToDesktop();
        }

        private void SaveToCsv(string filePath, DataTable dataTable)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write column headers
                    IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    writer.WriteLine(string.Join(",", columnNames));

                    // Write rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        writer.WriteLine(string.Join(",", fields));
                    }
                }
                NotificationLabel.Text = "Data saved successfully!";
                timer1.Start();
            }
            catch (Exception ex)
            {
                NotificationLabel.Text = "Error saving data: " + ex.Message;
                timer1.Start();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadCsvFromDesktop()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Monthly-MES-Report_" + DateTime.Now.ToString("MMM_yyyy") + ".csv";
            string filePath = Path.Combine(desktopPath, fileName);

            MessageBox.Show($"Checking for file at: {filePath}");

            if (File.Exists(filePath))
            {
                DailyReportTable = ReadFromCsv(filePath);
                dataGridView1.DataSource = DailyReportTable;
                NotificationLabel.Text = "Data loaded successfully!";
                timer1.Start();
            }
            else
            {
                InitializeDailyReportTable();
                NotificationLabel.Text = "Error loading data.";
                timer1.Start();
            }
        }

        private DataTable ReadFromCsv(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }
                while (!reader.EndOfStream)
                {
                    string[] rows = reader.ReadLine().Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadCsvFromDesktop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            NotificationLabel.Text = string.Empty;
            timer1.Stop();
        }
    }
}