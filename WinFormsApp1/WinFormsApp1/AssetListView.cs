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
        public static DataTable AssetListTable;

        public AssetListView()
        {
            InitializeComponent();
        }

        private void AssetImportButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    DataTable dataTable = ImportExcelToDataTable(filePath);

                    AssetListView.AssetListTable = dataTable;
                    // dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                    rowCountLabel.Text = $"Number of rows: {dataGridView1.Rows.Count}";
                }
            }
        }

        private DataTable ImportExcelToDataTable(string filePath, string password = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = password == null ? new ExcelPackage(new FileInfo(filePath)) : new ExcelPackage(new FileInfo(filePath), password))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
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

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            // Add asset logic here
        }

        private void RemoveAssetButton_Click(object sender, EventArgs e)
        {
            // Remove asset logic here
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AssetActionNotification.Text = string.Empty;
            timer1.Stop();
        }
    }
}
