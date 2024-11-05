using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MES_Form : Form
    {
        public MES_Form()
        {
            InitializeComponent();
        }

        private void DailyReportButton_Click(object sender, EventArgs e)
        {
            DailyReportView reportView = new DailyReportView();
            reportView.Show();
        }


        private void AssetListButton_Click(object sender, EventArgs e)
        {
            AssetListView assetView = new AssetListView();
            assetView.Show();
        }

        private void DeviceFormButton_Click(object sender, EventArgs e)
        {

        }
    }
}
