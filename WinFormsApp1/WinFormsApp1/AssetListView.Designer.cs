namespace WinFormsApp1
{
    partial class AssetListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AssetListTab = new System.Windows.Forms.TabControl();
            this.PPCTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IPCTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PrinterTab = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.AddAssetButton = new System.Windows.Forms.Button();
            this.RemoveAssetButton = new System.Windows.Forms.Button();
            this.AssetActionNotification = new System.Windows.Forms.Label();
            this.AssetImportButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.ModifyAssetButton = new System.Windows.Forms.Button();
            this.AssetListTab.SuspendLayout();
            this.PPCTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.IPCTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.PrinterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // AssetListTab
            // 
            this.AssetListTab.Controls.Add(this.PPCTab);
            this.AssetListTab.Controls.Add(this.IPCTab);
            this.AssetListTab.Controls.Add(this.PrinterTab);
            this.AssetListTab.Location = new System.Drawing.Point(12, 43);
            this.AssetListTab.Name = "AssetListTab";
            this.AssetListTab.SelectedIndex = 0;
            this.AssetListTab.Size = new System.Drawing.Size(776, 395);
            this.AssetListTab.TabIndex = 0;
            // 
            // PPCTab
            // 
            this.PPCTab.Controls.Add(this.dataGridView1);
            this.PPCTab.Location = new System.Drawing.Point(4, 24);
            this.PPCTab.Name = "PPCTab";
            this.PPCTab.Padding = new System.Windows.Forms.Padding(3);
            this.PPCTab.Size = new System.Drawing.Size(768, 367);
            this.PPCTab.TabIndex = 0;
            this.PPCTab.Text = "PPC";
            this.PPCTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(762, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // IPCTab
            // 
            this.IPCTab.Controls.Add(this.dataGridView2);
            this.IPCTab.Location = new System.Drawing.Point(4, 24);
            this.IPCTab.Name = "IPCTab";
            this.IPCTab.Padding = new System.Windows.Forms.Padding(3);
            this.IPCTab.Size = new System.Drawing.Size(768, 367);
            this.IPCTab.TabIndex = 1;
            this.IPCTab.Text = "IPC & PC";
            this.IPCTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(762, 361);
            this.dataGridView2.TabIndex = 1;
            // 
            // PrinterTab
            // 
            this.PrinterTab.Controls.Add(this.dataGridView3);
            this.PrinterTab.Location = new System.Drawing.Point(4, 24);
            this.PrinterTab.Name = "PrinterTab";
            this.PrinterTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrinterTab.Size = new System.Drawing.Size(768, 367);
            this.PrinterTab.TabIndex = 2;
            this.PrinterTab.Text = "Printers";
            this.PrinterTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(762, 361);
            this.dataGridView3.TabIndex = 1;
            // 
            // AddAssetButton
            // 
            this.AddAssetButton.Location = new System.Drawing.Point(19, 12);
            this.AddAssetButton.Name = "AddAssetButton";
            this.AddAssetButton.Size = new System.Drawing.Size(75, 23);
            this.AddAssetButton.TabIndex = 1;
            this.AddAssetButton.Text = "Add";
            this.AddAssetButton.UseVisualStyleBackColor = true;
            this.AddAssetButton.Click += new System.EventHandler(this.AddAssetButton_Click);
            // 
            // RemoveAssetButton
            // 
            this.RemoveAssetButton.Location = new System.Drawing.Point(181, 12);
            this.RemoveAssetButton.Name = "RemoveAssetButton";
            this.RemoveAssetButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAssetButton.TabIndex = 2;
            this.RemoveAssetButton.Text = "Remove";
            this.RemoveAssetButton.UseVisualStyleBackColor = true;
            this.RemoveAssetButton.Click += new System.EventHandler(this.RemoveAssetButton_Click);
            // 
            // AssetActionNotification
            // 
            this.AssetActionNotification.AutoSize = true;
            this.AssetActionNotification.Location = new System.Drawing.Point(19, 437);
            this.AssetActionNotification.Name = "AssetActionNotification";
            this.AssetActionNotification.Size = new System.Drawing.Size(0, 15);
            this.AssetActionNotification.TabIndex = 3;
            // 
            // AssetImportButton
            // 
            this.AssetImportButton.Location = new System.Drawing.Point(706, 12);
            this.AssetImportButton.Name = "AssetImportButton";
            this.AssetImportButton.Size = new System.Drawing.Size(75, 23);
            this.AssetImportButton.TabIndex = 4;
            this.AssetImportButton.Text = "Import";
            this.AssetImportButton.UseVisualStyleBackColor = true;
            this.AssetImportButton.Click += new System.EventHandler(this.AssetImportButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(511, 434);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(0, 15);
            this.rowCountLabel.TabIndex = 5;
            // 
            // ModifyAssetButton
            // 
            this.ModifyAssetButton.Location = new System.Drawing.Point(100, 12);
            this.ModifyAssetButton.Name = "ModifyAssetButton";
            this.ModifyAssetButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyAssetButton.TabIndex = 6;
            this.ModifyAssetButton.Text = "Edit";
            this.ModifyAssetButton.UseVisualStyleBackColor = true;
            this.ModifyAssetButton.Click += new System.EventHandler(this.ModifyAssetButton_Click);
            // 
            // AssetListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyAssetButton);
            this.Controls.Add(this.rowCountLabel);
            this.Controls.Add(this.AssetImportButton);
            this.Controls.Add(this.AssetActionNotification);
            this.Controls.Add(this.RemoveAssetButton);
            this.Controls.Add(this.AddAssetButton);
            this.Controls.Add(this.AssetListTab);
            this.Name = "AssetListView";
            this.Text = "Asset List View";
            this.AssetListTab.ResumeLayout(false);
            this.PPCTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.IPCTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.PrinterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl AssetListTab;
        private TabPage PPCTab;
        private TabPage IPCTab;
        private TabPage PrinterTab;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button AddAssetButton;
        private Button RemoveAssetButton;
        private Label AssetActionNotification;
        private Button AssetImportButton;
        private System.Windows.Forms.Timer timer1;
        private Label rowCountLabel;
        private Button ModifyAssetButton;
    }
}