namespace Lynx_Configurator
{
    partial class EventName
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            includeDateCheckBox = new CheckBox();
            eventNameTextBox = new TextBox();
            datePicker = new DateTimePicker();
            okButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(includeDateCheckBox, 1, 1);
            tableLayoutPanel1.Controls.Add(eventNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(datePicker, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 13);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(374, 105);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 0;
            label1.Text = "Event Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 1;
            label2.Text = "Include Date?";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(41, 35);
            label3.TabIndex = 2;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // includeDateCheckBox
            // 
            includeDateCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            includeDateCheckBox.AutoSize = true;
            includeDateCheckBox.Checked = true;
            includeDateCheckBox.CheckState = CheckState.Checked;
            includeDateCheckBox.Location = new Point(123, 38);
            includeDateCheckBox.Name = "includeDateCheckBox";
            includeDateCheckBox.Size = new Size(15, 29);
            includeDateCheckBox.TabIndex = 3;
            includeDateCheckBox.UseVisualStyleBackColor = true;
            includeDateCheckBox.CheckedChanged += includeDateCheckBox_CheckedChanged;
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            eventNameTextBox.Location = new Point(123, 3);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(248, 27);
            eventNameTextBox.TabIndex = 4;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(123, 73);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 27);
            datePicker.TabIndex = 5;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            okButton.Location = new Point(3, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 33);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.Location = new Point(103, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 33);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(okButton, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Location = new Point(97, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(200, 39);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // EventName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 175);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventName";
            Text = "Set Folder Names";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox includeDateCheckBox;
        private TextBox eventNameTextBox;
        private DateTimePicker datePicker;
        private Button okButton;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel2;
    }
}