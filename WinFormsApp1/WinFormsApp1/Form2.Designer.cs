namespace WinFormsApp1
{
    partial class Form2
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
            this.CreateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CreateCancel = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.ShiftComboBox = new System.Windows.Forms.ComboBox();
            this.LineComboBox = new System.Windows.Forms.ComboBox();
            this.LineLabel = new System.Windows.Forms.Label();
            this.StationLabel = new System.Windows.Forms.Label();
            this.StationTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.Category1Label = new System.Windows.Forms.Label();
            this.Category2Label = new System.Windows.Forms.Label();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.ProblemTextLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.WorkerLabel = new System.Windows.Forms.Label();
            this.WorkerTextBox = new System.Windows.Forms.TextBox();
            this.ProblemTextBox = new System.Windows.Forms.TextBox();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.DeviceTextBox = new System.Windows.Forms.TextBox();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Category1ComboBox = new System.Windows.Forms.ComboBox();
            this.Category2ComboBox = new System.Windows.Forms.ComboBox();
            this.ProblemReasonTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Location = new System.Drawing.Point(238, 9);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(115, 15);
            this.CreateLabel.TabIndex = 100;
            this.CreateLabel.Text = "Create a New Report";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(90, 393);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 101;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CreateCancel
            // 
            this.CreateCancel.Location = new System.Drawing.Point(425, 393);
            this.CreateCancel.Name = "CreateCancel";
            this.CreateCancel.Size = new System.Drawing.Size(75, 23);
            this.CreateCancel.TabIndex = 102;
            this.CreateCancel.Text = "Cancel";
            this.CreateCancel.UseVisualStyleBackColor = true;
            this.CreateCancel.Click += new System.EventHandler(this.CreateCancel_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(90, 40);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(14, 46);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(31, 15);
            this.DateLabel.TabIndex = 110;
            this.DateLabel.Text = "Date";
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(14, 84);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(31, 15);
            this.ShiftLabel.TabIndex = 111;
            this.ShiftLabel.Text = "Shift";
            // 
            // ShiftComboBox
            // 
            this.ShiftComboBox.FormattingEnabled = true;
            this.ShiftComboBox.Location = new System.Drawing.Point(90, 81);
            this.ShiftComboBox.Name = "ShiftComboBox";
            this.ShiftComboBox.Size = new System.Drawing.Size(75, 23);
            this.ShiftComboBox.TabIndex = 2;
            // 
            // LineComboBox
            // 
            this.LineComboBox.FormattingEnabled = true;
            this.LineComboBox.Location = new System.Drawing.Point(90, 122);
            this.LineComboBox.Name = "LineComboBox";
            this.LineComboBox.Size = new System.Drawing.Size(75, 23);
            this.LineComboBox.TabIndex = 3;
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(14, 125);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(29, 15);
            this.LineLabel.TabIndex = 112;
            this.LineLabel.Text = "Line";
            // 
            // StationLabel
            // 
            this.StationLabel.AutoSize = true;
            this.StationLabel.Location = new System.Drawing.Point(14, 165);
            this.StationLabel.Name = "StationLabel";
            this.StationLabel.Size = new System.Drawing.Size(44, 15);
            this.StationLabel.TabIndex = 113;
            this.StationLabel.Text = "Station";
            // 
            // StationComboBox
            // 
            this.StationTextBox.Location = new System.Drawing.Point(90, 162);
            this.StationTextBox.Name = "StationTextBox";
            this.StationTextBox.Size = new System.Drawing.Size(121, 23);
            this.StationTextBox.TabIndex = 4;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(315, 46);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(60, 15);
            this.StartTimeLabel.TabIndex = 114;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(315, 84);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(56, 15);
            this.EndTimeLabel.TabIndex = 115;
            this.EndTimeLabel.Text = "End Time";
            // 
            // Category1Label
            // 
            this.Category1Label.AutoSize = true;
            this.Category1Label.Location = new System.Drawing.Point(315, 125);
            this.Category1Label.Name = "Category1Label";
            this.Category1Label.Size = new System.Drawing.Size(64, 15);
            this.Category1Label.TabIndex = 116;
            this.Category1Label.Text = "Category 1";
            // 
            // Category2Label
            // 
            this.Category2Label.AutoSize = true;
            this.Category2Label.Location = new System.Drawing.Point(315, 165);
            this.Category2Label.Name = "Category2Label";
            this.Category2Label.Size = new System.Drawing.Size(64, 15);
            this.Category2Label.TabIndex = 117;
            this.Category2Label.Text = "Category 2";
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(14, 203);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(42, 15);
            this.DeviceLabel.TabIndex = 118;
            this.DeviceLabel.Text = "Device";
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Location = new System.Drawing.Point(315, 203);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(93, 15);
            this.ProblemLabel.TabIndex = 119;
            this.ProblemLabel.Text = "Problem Reason";
            // 
            // ProblemTextLabel
            // 
            this.ProblemTextLabel.AutoSize = true;
            this.ProblemTextLabel.Location = new System.Drawing.Point(14, 242);
            this.ProblemTextLabel.Name = "ProblemTextLabel";
            this.ProblemTextLabel.Size = new System.Drawing.Size(52, 15);
            this.ProblemTextLabel.TabIndex = 129;
            this.ProblemTextLabel.Text = "Problem";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(14, 309);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(42, 15);
            this.ActionLabel.TabIndex = 121;
            this.ActionLabel.Text = "Action";
            // 
            // WorkerLabel
            // 
            this.WorkerLabel.AutoSize = true;
            this.WorkerLabel.Location = new System.Drawing.Point(315, 242);
            this.WorkerLabel.Name = "WorkerLabel";
            this.WorkerLabel.Size = new System.Drawing.Size(45, 15);
            this.WorkerLabel.TabIndex = 122;
            this.WorkerLabel.Text = "Worker";
            // 
            // WorkerTextBox
            // 
            this.WorkerTextBox.Location = new System.Drawing.Point(425, 239);
            this.WorkerTextBox.Name = "WorkerTextBox";
            this.WorkerTextBox.Size = new System.Drawing.Size(130, 23);
            this.WorkerTextBox.TabIndex = 11;
            // 
            // ProblemTextBox
            // 
            this.ProblemTextBox.Location = new System.Drawing.Point(14, 274);
            this.ProblemTextBox.Name = "ProblemTextBox";
            this.ProblemTextBox.Size = new System.Drawing.Size(541, 23);
            this.ProblemTextBox.TabIndex = 12;
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(14, 337);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(541, 23);
            this.ActionTextBox.TabIndex = 13;
            // 
            // DeviceTextBox
            // 
            this.DeviceTextBox.Location = new System.Drawing.Point(90, 200);
            this.DeviceTextBox.Name = "DeviceTextBox";
            this.DeviceTextBox.Size = new System.Drawing.Size(121, 23);
            this.DeviceTextBox.TabIndex = 5;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.CustomFormat = "HH:mm:00";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Location = new System.Drawing.Point(389, 40);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(166, 23);
            this.StartTimePicker.TabIndex = 6;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.CustomFormat = "HH:mm:00";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Location = new System.Drawing.Point(389, 78);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(166, 23);
            this.EndTimePicker.TabIndex = 7;
            // 
            // Category1ComboBox
            // 
            this.Category1ComboBox.FormattingEnabled = true;
            this.Category1ComboBox.Location = new System.Drawing.Point(425, 122);
            this.Category1ComboBox.Name = "Category1ComboBox";
            this.Category1ComboBox.Size = new System.Drawing.Size(130, 23);
            this.Category1ComboBox.TabIndex = 8;
            // 
            // Category2ComboBox
            // 
            this.Category2ComboBox.FormattingEnabled = true;
            this.Category2ComboBox.Location = new System.Drawing.Point(425, 162);
            this.Category2ComboBox.Name = "Category2ComboBox";
            this.Category2ComboBox.Size = new System.Drawing.Size(130, 23);
            this.Category2ComboBox.TabIndex = 9;
            // 
            // ProblemReasonComboBox
            // 
            this.ProblemReasonTextBox.Location = new System.Drawing.Point(425, 200);
            this.ProblemReasonTextBox.Name = "ProblemReasonTextBox";
            this.ProblemReasonTextBox.Size = new System.Drawing.Size(130, 23);
            this.ProblemReasonTextBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.ProblemReasonTextBox);
            this.Controls.Add(this.Category2ComboBox);
            this.Controls.Add(this.Category1ComboBox);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.DeviceTextBox);
            this.Controls.Add(this.ActionTextBox);
            this.Controls.Add(this.ProblemTextBox);
            this.Controls.Add(this.WorkerTextBox);
            this.Controls.Add(this.WorkerLabel);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.ProblemTextLabel);
            this.Controls.Add(this.ProblemLabel);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.Category2Label);
            this.Controls.Add(this.Category1Label);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.StationTextBox);
            this.Controls.Add(this.StationLabel);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.LineComboBox);
            this.Controls.Add(this.ShiftComboBox);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CreateCancel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CreateLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateLabel;
        private Button SubmitButton;
        private Button CreateCancel;
        private DateTimePicker DateTimePicker;
        private Label DateLabel;
        private Label ShiftLabel;
        private ComboBox ShiftComboBox;
        private Label LineLabel;
        private ComboBox LineComboBox;
        private Label StationLabel;
        private TextBox StationTextBox;
        private Label StartTimeLabel;
        private Label EndTimeLabel;
        private Label Category1Label;
        private Label Category2Label;
        private Label DeviceLabel;
        private Label ProblemLabel;
        private Label ProblemTextLabel;
        private Label ActionLabel;
        private Label WorkerLabel;
        private TextBox WorkerTextBox;
        private TextBox ProblemTextBox;
        private TextBox ActionTextBox;
        private TextBox DeviceTextBox;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private ComboBox Category1ComboBox;
        private ComboBox Category2ComboBox;
        private TextBox ProblemReasonTextBox;

        public EventHandler Form2_Load { get; private set; }
    }
}