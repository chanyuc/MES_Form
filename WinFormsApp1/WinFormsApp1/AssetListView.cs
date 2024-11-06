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
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace WinFormsApp1
{
    public partial class AssetListView : Form
    {
        public static DataTable PPCTable;
        public static DataTable IPCTable;
        public static DataTable PrinterTableMerged;

        public AssetListView()
        {
            InitializeComponent();
            InitializeTables();
        }

        private void InitializeTables()
        {
            PPCTable = new DataTable();

            PPCTable.Columns.Add("Asset #", typeof(string));
            PPCTable.Columns.Add("Serial", typeof(string));
            PPCTable.Columns.Add("SAP", typeof(string));
            PPCTable.Columns.Add("IP Address", typeof(string));
            PPCTable.Columns.Add("Model", typeof(string));
            PPCTable.Columns.Add("Location", typeof(string));
            PPCTable.Columns.Add("Station", typeof(string));
            PPCTable.Columns.Add("CPU", typeof(string));
            PPCTable.Columns.Add("RAM", typeof(string));
            PPCTable.Columns.Add("OS", typeof(string));
            PPCTable.Columns.Add("Disk Space", typeof(string));
            PPCTable.Columns.Add("PPC Program", typeof(string));
            PPCTable.Columns.Add("Image Version", typeof(string));
            PPCTable.Columns.Add("Install Date", typeof(string));
            PPCTable.Columns.Add("Notes", typeof(string));

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridView1.DataSource = PPCTable;

            dataGridView1.Columns["Asset #"].Width = 80;
            dataGridView1.Columns["Serial"].Width = 80;
            dataGridView1.Columns["SAP"].Width = 50;
            dataGridView1.Columns["IP Address"].Width = 100;
            dataGridView1.Columns["Model"].Width = 80;
            dataGridView1.Columns["Location"].Width = 60;
            dataGridView1.Columns["Station"].Width = 60;
            dataGridView1.Columns["CPU"].Width = 100;
            dataGridView1.Columns["RAM"].Width = 50;
            dataGridView1.Columns["OS"].Width = 50;
            dataGridView1.Columns["Disk Space"].Width = 50;
            dataGridView1.Columns["PPC Program"].Width = 80;
            dataGridView1.Columns["Image Version"].Width = 50;
            dataGridView1.Columns["Install Date"].Width = 50;
            dataGridView1.Columns["Notes"].Width = 100;


            IPCTable = new DataTable();

            IPCTable.Columns.Add("Asset #", typeof(string));
            IPCTable.Columns.Add("Serial", typeof(string));
            IPCTable.Columns.Add("SAP", typeof(string));
            IPCTable.Columns.Add("IP Address", typeof(string));
            IPCTable.Columns.Add("Model", typeof(string));
            IPCTable.Columns.Add("Location", typeof(string));
            IPCTable.Columns.Add("Purpose", typeof(string));
            IPCTable.Columns.Add("CPU", typeof(string));
            IPCTable.Columns.Add("RAM", typeof(string));
            IPCTable.Columns.Add("OS", typeof(string));
            IPCTable.Columns.Add("System Type", typeof(string));
            IPCTable.Columns.Add("Disk Space", typeof(string));
            IPCTable.Columns.Add("Install Date", typeof(string));
            IPCTable.Columns.Add("Notes", typeof(string));

            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.AllowUserToDeleteRows = true;
            dataGridView2.ReadOnly = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridView2.DataSource = IPCTable;

            dataGridView2.Columns["Asset #"].Width = 80;
            dataGridView2.Columns["Serial"].Width = 80;
            dataGridView2.Columns["SAP"].Width = 50;
            dataGridView2.Columns["IP Address"].Width = 100;
            dataGridView2.Columns["Model"].Width = 80;
            dataGridView2.Columns["Location"].Width = 60;
            dataGridView2.Columns["Purpose"].Width = 60;
            dataGridView2.Columns["CPU"].Width = 100;
            dataGridView2.Columns["RAM"].Width = 50;
            dataGridView2.Columns["OS"].Width = 50;
            dataGridView2.Columns["System Type"].Width = 50;
            dataGridView2.Columns["Disk Space"].Width = 80;
            dataGridView2.Columns["Install Date"].Width = 50;
            dataGridView2.Columns["Notes"].Width = 100;


            PrinterTableMerged = new DataTable();

            PrinterTableMerged.Columns.Add("Asset #", typeof(string));
            PrinterTableMerged.Columns.Add("Serial", typeof(string));
            PrinterTableMerged.Columns.Add("SAP", typeof(string));
            PrinterTableMerged.Columns.Add("IP Address", typeof(string));
            PrinterTableMerged.Columns.Add("Model", typeof(string));
            PrinterTableMerged.Columns.Add("Location", typeof(string));
            PrinterTableMerged.Columns.Add("IPC", typeof(string));
            PrinterTableMerged.Columns.Add("SysCode", typeof(string));
            PrinterTableMerged.Columns.Add("SysName", typeof(string));
            PrinterTableMerged.Columns.Add("Install Date", typeof(string));
            PrinterTableMerged.Columns.Add("Notes", typeof(string));

            dataGridView3.AllowUserToAddRows = true;
            dataGridView3.AllowUserToDeleteRows = true;
            dataGridView3.ReadOnly = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridView3.DataSource = PrinterTableMerged;

            dataGridView3.Columns["Asset #"].Width = 80;
            dataGridView3.Columns["Serial"].Width = 80;
            dataGridView3.Columns["SAP"].Width = 50;
            dataGridView3.Columns["IP Address"].Width = 100;
            dataGridView3.Columns["Model"].Width = 80;
            dataGridView3.Columns["Location"].Width = 60;
            dataGridView3.Columns["IPC"].Width = 60;
            dataGridView3.Columns["SysCode"].Width = 100;
            dataGridView3.Columns["SysName"].Width = 50;
            dataGridView3.Columns["Install Date"].Width = 50;
            dataGridView3.Columns["Notes"].Width = 100;
        }

        private void AssetImportButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    PPCTable = ImportExcelToDataTable(filePath, "PPC");
                    IPCTable = ImportExcelToDataTable(filePath, "IPC&PC");
                    DataTable PrinterTable1 = ImportExcelToDataTable(filePath, "P8000 | HP Printer");
                    DataTable PrinterTable2 = ImportExcelToDataTable(filePath, "Label Printer");

                    PrinterTableMerged = MergeDataTables(PrinterTable1, PrinterTable2);

                    dataGridView1.DataSource = PPCTable;
                    dataGridView2.DataSource = IPCTable;
                    dataGridView3.DataSource = PrinterTableMerged;

                    dataGridView1.Refresh();
                    dataGridView2.Refresh();
                    dataGridView3.Refresh();

                    rowCountLabel.Text = $"PPC Rows: {dataGridView1.Rows.Count}, IPC Rows: {dataGridView2.Rows.Count}, Printer Rows: {dataGridView3.Rows.Count}";
                }
            }
        }

        private DataTable ImportExcelToDataTable(string filePath, string sheetName, string password = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = password == null ? new ExcelPackage(new FileInfo(filePath)) : new ExcelPackage(new FileInfo(filePath), password))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];
                    foreach (var firstRowCell in worksheet.Cells[3, 1, 3, worksheet.Dimension.End.Column])
                    {
                        dataTable.Columns.Add(firstRowCell.Text);
                    }

                    for (int rowNum = 4; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                    {
                        var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                        DataRow row = dataTable.NewRow();
                        foreach (var cell in wsRow)
                        {
                            row[cell.Start.Column - 1] = cell.Text;
                        }
                        dataTable.Rows.Add(row);
                    }
                    AssetActionNotification.Text = "Data loaded successfully!";
                    timer1.Start();
                }
            }
            catch (InvalidDataException ex)
            {
                AssetActionNotification.Text = "The file is not a valid Excel package. Please check the file format and try again.";
                timer1.Start();
            }
            catch (Exception ex)
            {
                AssetActionNotification.Text = $"An error occurred: {ex.Message}";
                timer1.Start();
            }

            return dataTable;
        }

        private DataTable MergeDataTables(DataTable table1, DataTable table2)
        {
            DataTable mergedTable = table1.Copy();
            foreach (DataRow row in table2.Rows)
            {
                mergedTable.ImportRow(row);
            }
            return mergedTable;
        }

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            // Add asset logic here
        }

        private void RemoveAssetButton_Click(object sender, EventArgs e)
        {
            if (AssetListTab.SelectedTab == PPCTab)
            {
                RemoveSelectedRows(dataGridView1);
            }
            else if (AssetListTab.SelectedTab == IPCTab)
            {
                RemoveSelectedRows(dataGridView2);
            }
            else if (AssetListTab.SelectedTab == PrinterTab)
            {
                RemoveSelectedRows(dataGridView3);
            }
            else
            {
                MessageBox.Show("Please select a tab with rows to delete.");
            }
        }

        private void RemoveSelectedRows(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.Remove(row);
                }
                rowCountLabel.Text = $"Number of rows: {dataGridView.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ModifyAssetButton_Click(object sender, EventArgs e)
        {
            // Modify asset logic here
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AssetActionNotification.Text = string.Empty;
            timer1.Stop();
        }
    }
}
