using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace WinFormsApp1
{
    public partial class DailyReportView : Form
    {
        public static DataTable DailyReportTable;

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

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DailyReportCreate form2 = new DailyReportCreate();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                DataRow newRow = DailyReportTable.NewRow();
                newRow["Date"] = form2.DateData;
                newRow["Shift"] = form2.ShiftData;
                newRow["Line"] = form2.LineData;
                newRow["Station"] = form2.StationData;
                newRow["Start Time"] = form2.StartTimeData;
                newRow["End Time"] = form2.EndTimeData;
                newRow["Elapsed Time"] = form2.ElapsedTimeData;
                newRow["Category1"] = form2.Cat1Data;
                newRow["Category2"] = form2.Cat2Data;
                newRow["Device"] = form2.DeviceData;
                newRow["Problem Reason"] = form2.ProblemReasonData;
                newRow["Problem"] = form2.ProblemData;
                newRow["Action"] = form2.ActionData;
                newRow["Worker"] = form2.WorkerData;

                DailyReportTable.Rows.Add(newRow);

                // Debugging: Print the new row to the console
                Console.WriteLine("New row added:");
                foreach (var item in newRow.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                // Refresh the DataGridView
                rowCountLabel.Text = $"Number of rows: {dataGridView1.Rows.Count}";
                dataGridView1.Refresh();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                rowCountLabel.Text = $"Number of rows: {dataGridView1.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    DataTable dataTable = ImportExcelToDataTable(filePath);

                    // Ensure the DataTable is not read-only
                    dataTable.DefaultView.AllowNew = true;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        column.ReadOnly = false;
                    }

                    // Bind the DataTable to the BindingSource
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                    rowCountLabel.Text = $"Number of rows: {dataGridView1.Rows.Count}";
                }
            }
        }

        private DataTable ImportExcelToDataTable(string filePath, string password = null)
        {
            DailyReportTable = new DataTable();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = password == null ? new ExcelPackage(new FileInfo(filePath)) : new ExcelPackage(new FileInfo(filePath), password))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    if (worksheet.Dimension == null)
                    {
                        throw new Exception("Worksheet is empty.");
                    }

                    foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        DailyReportTable.Columns.Add(firstRowCell.Text);
                    }

                    for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                    {
                        var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                        bool isEmptyRow = true;
                        DataRow row = DailyReportTable.NewRow();

                        foreach (var cell in wsRow)
                        {
                            if (!string.IsNullOrEmpty(cell.Text.Trim()))
                            {
                                isEmptyRow = false;
                            }
                            row[cell.Start.Column - 1] = cell.Text.Trim();
                        }

                        // Debug statement to check if the row is empty
                        Console.WriteLine($"Row {rowNum} is empty: {isEmptyRow}");

                        if (!isEmptyRow)
                        {
                            DailyReportTable.Rows.Add(row);
                        }
                    }
                    NotificationLabel.Text = "Data loaded successfully!";
                    timer1.Start();
                }
            }
            catch (InvalidDataException ex)
            {
                NotificationLabel.Text = "The file is not valid. Please check the file format.";
                timer1.Start();
            }
            catch (Exception ex)
            {
                NotificationLabel.Text = $"An error occurred: {ex.Message}";
                timer1.Start();
            }

            return DailyReportTable;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SaveExcelToDesktop();
        }

        private void SaveExcelToDesktop()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Monthly-MES-Report_" + DateTime.Now.ToString("MMM_yyyy") + ".xlsx";
            string filePath = Path.Combine(desktopPath, fileName);

            DataTable dataTable = DailyReportTable;

            // Debug statement to check row count
            Console.WriteLine($"Row count before saving: {dataTable.Rows.Count}");

            SaveToExcel(filePath, dataTable);
        }

        private void SaveToExcel(string filePath, DataTable dataTable)
        {
            try
            {
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    NotificationLabel.Text = "No data to save.";
                    timer1.Start();
                    return;
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Add column headers
                    for (int col = 1; col <= dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col].Value = dataTable.Columns[col - 1].ColumnName;
                    }

                    // Add rows
                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                        }
                    }

                    // Save the Excel file
                    FileInfo fileInfo = new FileInfo(filePath);
                    package.SaveAs(fileInfo);
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            NotificationLabel.Text = string.Empty;
            timer1.Stop();
        }
    }
}