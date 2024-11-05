namespace WinFormsApp1
{
    partial class MES_Form
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
            this.DailyReportButton = new System.Windows.Forms.Button();
            this.AssetListButton = new System.Windows.Forms.Button();
            this.DeviceFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DailyReportButton
            // 
            this.DailyReportButton.Location = new System.Drawing.Point(47, 58);
            this.DailyReportButton.Name = "DailyReportButton";
            this.DailyReportButton.Size = new System.Drawing.Size(135, 68);
            this.DailyReportButton.TabIndex = 0;
            this.DailyReportButton.Text = "Daily Report";
            this.DailyReportButton.UseVisualStyleBackColor = true;
            this.DailyReportButton.Click += new System.EventHandler(this.DailyReportButton_Click);
            // 
            // AssetListButton
            // 
            this.AssetListButton.Location = new System.Drawing.Point(47, 149);
            this.AssetListButton.Name = "AssetListButton";
            this.AssetListButton.Size = new System.Drawing.Size(135, 68);
            this.AssetListButton.TabIndex = 1;
            this.AssetListButton.Text = "Asset List";
            this.AssetListButton.UseVisualStyleBackColor = true;
            this.AssetListButton.Click += new System.EventHandler(this.AssetListButton_Click);
            // 
            // DeviceFormButton
            // 
            this.DeviceFormButton.Location = new System.Drawing.Point(47, 241);
            this.DeviceFormButton.Name = "DeviceFormButton";
            this.DeviceFormButton.Size = new System.Drawing.Size(135, 68);
            this.DeviceFormButton.TabIndex = 2;
            this.DeviceFormButton.Text = "Device Form";
            this.DeviceFormButton.UseVisualStyleBackColor = true;
            this.DeviceFormButton.Click += new System.EventHandler(this.DeviceFormButton_Click);
            // 
            // MES_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeviceFormButton);
            this.Controls.Add(this.AssetListButton);
            this.Controls.Add(this.DailyReportButton);
            this.Name = "MES_Form";
            this.Text = "MES Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button DailyReportButton;
        private Button AssetListButton;
        private Button DeviceFormButton;
    }
}