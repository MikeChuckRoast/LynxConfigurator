namespace Lynx_Configurator
{
    partial class ConfigForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            baseFolderText = new TextBox();
            baseFolderLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            baseFolderChooseButton = new Button();
            eventFolderChooseButton = new Button();
            eventFolderLabel = new Label();
            eventFolderText = new TextBox();
            dbInputFolderChooseButton = new Button();
            dbInputFolderLabel = new Label();
            dbInputFolderText = new TextBox();
            dbOutputFolderChooseButton = new Button();
            dbOutputFolderLabel = new Label();
            dbOutputFolderText = new TextBox();
            backupBaseFolderChooseButton = new Button();
            backupBaseFolderLabel = new Label();
            backupBaseFolderText = new TextBox();
            backupFolderChooseButton = new Button();
            backupFolderLabel = new Label();
            backupFolderText = new TextBox();
            setAllFolderButton = new Button();
            label8 = new Label();
            autoSaveLifLabel = new Label();
            overlayLabel = new Label();
            idlynxOverlayLabel = new Label();
            label12 = new Label();
            createResultLabel = new Label();
            fillInTimeLabel = new Label();
            defaultLapsLabel = new Label();
            maskStartLabel = new Label();
            maskLapLabel = new Label();
            autoSaveLifNumber = new NumericUpDown();
            overlayText = new TextBox();
            idlynxOverlayText = new TextBox();
            createResultCheckBox = new CheckBox();
            fillInTimeCheckBox = new CheckBox();
            defaultLapsNumber = new NumericUpDown();
            maskStartNumber = new NumericUpDown();
            toolTip = new ToolTip(components);
            trackButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            maskLapNumber = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            saveButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            xcButton = new Button();
            ttButton = new Button();
            ((System.ComponentModel.ISupportInitialize)autoSaveLifNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)defaultLapsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maskStartNumber).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maskLapNumber).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 34);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Folders";
            // 
            // baseFolderText
            // 
            baseFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            baseFolderText.Location = new Point(123, 3);
            baseFolderText.Name = "baseFolderText";
            baseFolderText.Size = new Size(333, 27);
            baseFolderText.TabIndex = 1;
            // 
            // baseFolderLabel
            // 
            baseFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            baseFolderLabel.AutoSize = true;
            baseFolderLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            baseFolderLabel.Location = new Point(3, 0);
            baseFolderLabel.Name = "baseFolderLabel";
            baseFolderLabel.Size = new Size(88, 35);
            baseFolderLabel.TabIndex = 2;
            baseFolderLabel.Text = "Base Folder";
            baseFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // baseFolderChooseButton
            // 
            baseFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            baseFolderChooseButton.Location = new Point(462, 3);
            baseFolderChooseButton.Name = "baseFolderChooseButton";
            baseFolderChooseButton.Size = new Size(75, 29);
            baseFolderChooseButton.TabIndex = 3;
            baseFolderChooseButton.Text = "Choose...";
            baseFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // eventFolderChooseButton
            // 
            eventFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            eventFolderChooseButton.Location = new Point(462, 38);
            eventFolderChooseButton.Name = "eventFolderChooseButton";
            eventFolderChooseButton.Size = new Size(75, 29);
            eventFolderChooseButton.TabIndex = 6;
            eventFolderChooseButton.Text = "Choose...";
            eventFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // eventFolderLabel
            // 
            eventFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            eventFolderLabel.AutoSize = true;
            eventFolderLabel.Location = new Point(3, 35);
            eventFolderLabel.Name = "eventFolderLabel";
            eventFolderLabel.Size = new Size(91, 35);
            eventFolderLabel.TabIndex = 5;
            eventFolderLabel.Text = "Event Folder";
            eventFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eventFolderText
            // 
            eventFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eventFolderText.Location = new Point(123, 38);
            eventFolderText.Name = "eventFolderText";
            eventFolderText.Size = new Size(333, 27);
            eventFolderText.TabIndex = 4;
            // 
            // dbInputFolderChooseButton
            // 
            dbInputFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dbInputFolderChooseButton.Location = new Point(462, 73);
            dbInputFolderChooseButton.Name = "dbInputFolderChooseButton";
            dbInputFolderChooseButton.Size = new Size(75, 29);
            dbInputFolderChooseButton.TabIndex = 9;
            dbInputFolderChooseButton.Text = "Choose...";
            dbInputFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // dbInputFolderLabel
            // 
            dbInputFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dbInputFolderLabel.AutoSize = true;
            dbInputFolderLabel.Location = new Point(3, 70);
            dbInputFolderLabel.Name = "dbInputFolderLabel";
            dbInputFolderLabel.Size = new Size(67, 35);
            dbInputFolderLabel.TabIndex = 8;
            dbInputFolderLabel.Text = "DB Input";
            dbInputFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dbInputFolderText
            // 
            dbInputFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbInputFolderText.Location = new Point(123, 73);
            dbInputFolderText.Name = "dbInputFolderText";
            dbInputFolderText.Size = new Size(333, 27);
            dbInputFolderText.TabIndex = 7;
            // 
            // dbOutputFolderChooseButton
            // 
            dbOutputFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dbOutputFolderChooseButton.Location = new Point(462, 108);
            dbOutputFolderChooseButton.Name = "dbOutputFolderChooseButton";
            dbOutputFolderChooseButton.Size = new Size(75, 29);
            dbOutputFolderChooseButton.TabIndex = 12;
            dbOutputFolderChooseButton.Text = "Choose...";
            dbOutputFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // dbOutputFolderLabel
            // 
            dbOutputFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dbOutputFolderLabel.AutoSize = true;
            dbOutputFolderLabel.Location = new Point(3, 105);
            dbOutputFolderLabel.Name = "dbOutputFolderLabel";
            dbOutputFolderLabel.Size = new Size(79, 35);
            dbOutputFolderLabel.TabIndex = 11;
            dbOutputFolderLabel.Text = "DB Output";
            dbOutputFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dbOutputFolderText
            // 
            dbOutputFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbOutputFolderText.Location = new Point(123, 108);
            dbOutputFolderText.Name = "dbOutputFolderText";
            dbOutputFolderText.Size = new Size(333, 27);
            dbOutputFolderText.TabIndex = 10;
            // 
            // backupBaseFolderChooseButton
            // 
            backupBaseFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            backupBaseFolderChooseButton.Location = new Point(462, 143);
            backupBaseFolderChooseButton.Name = "backupBaseFolderChooseButton";
            backupBaseFolderChooseButton.Size = new Size(75, 29);
            backupBaseFolderChooseButton.TabIndex = 15;
            backupBaseFolderChooseButton.Text = "Choose...";
            backupBaseFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // backupBaseFolderLabel
            // 
            backupBaseFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            backupBaseFolderLabel.AutoSize = true;
            backupBaseFolderLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backupBaseFolderLabel.Location = new Point(3, 140);
            backupBaseFolderLabel.Name = "backupBaseFolderLabel";
            backupBaseFolderLabel.Size = new Size(96, 35);
            backupBaseFolderLabel.TabIndex = 14;
            backupBaseFolderLabel.Text = "Backup Base";
            backupBaseFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backupBaseFolderText
            // 
            backupBaseFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backupBaseFolderText.Location = new Point(123, 143);
            backupBaseFolderText.Name = "backupBaseFolderText";
            backupBaseFolderText.Size = new Size(333, 27);
            backupBaseFolderText.TabIndex = 13;
            // 
            // backupFolderChooseButton
            // 
            backupFolderChooseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            backupFolderChooseButton.Location = new Point(462, 178);
            backupFolderChooseButton.Name = "backupFolderChooseButton";
            backupFolderChooseButton.Size = new Size(75, 29);
            backupFolderChooseButton.TabIndex = 18;
            backupFolderChooseButton.Text = "Choose...";
            backupFolderChooseButton.UseVisualStyleBackColor = true;
            // 
            // backupFolderLabel
            // 
            backupFolderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            backupFolderLabel.AutoSize = true;
            backupFolderLabel.Location = new Point(3, 175);
            backupFolderLabel.Name = "backupFolderLabel";
            backupFolderLabel.Size = new Size(103, 35);
            backupFolderLabel.TabIndex = 17;
            backupFolderLabel.Text = "Backup Folder";
            backupFolderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backupFolderText
            // 
            backupFolderText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backupFolderText.Location = new Point(123, 178);
            backupFolderText.Name = "backupFolderText";
            backupFolderText.Size = new Size(333, 27);
            backupFolderText.TabIndex = 16;
            // 
            // setAllFolderButton
            // 
            setAllFolderButton.Location = new Point(116, 34);
            setAllFolderButton.Name = "setAllFolderButton";
            setAllFolderButton.Size = new Size(75, 29);
            setAllFolderButton.TabIndex = 19;
            setAllFolderButton.Text = "Set All";
            setAllFolderButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 334);
            label8.Margin = new Padding(3, 6, 3, 3);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 20;
            label8.Text = "Options";
            // 
            // autoSaveLifLabel
            // 
            autoSaveLifLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoSaveLifLabel.AutoSize = true;
            autoSaveLifLabel.Location = new Point(3, 0);
            autoSaveLifLabel.Name = "autoSaveLifLabel";
            autoSaveLifLabel.Size = new Size(98, 35);
            autoSaveLifLabel.TabIndex = 21;
            autoSaveLifLabel.Text = "Auto Save LIF";
            autoSaveLifLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(autoSaveLifLabel, "Time (seconds) to auto save LIF file.\r\n0 to disable auto-save.\r\n5 is typical when enabled.\r\n");
            // 
            // overlayLabel
            // 
            overlayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            overlayLabel.AutoSize = true;
            overlayLabel.Location = new Point(3, 35);
            overlayLabel.Name = "overlayLabel";
            overlayLabel.Size = new Size(59, 35);
            overlayLabel.TabIndex = 22;
            overlayLabel.Text = "Overlay";
            overlayLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(overlayLabel, "Image overlay string for main camera");
            // 
            // idlynxOverlayLabel
            // 
            idlynxOverlayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            idlynxOverlayLabel.AutoSize = true;
            idlynxOverlayLabel.Location = new Point(3, 70);
            idlynxOverlayLabel.Name = "idlynxOverlayLabel";
            idlynxOverlayLabel.Size = new Size(106, 35);
            idlynxOverlayLabel.TabIndex = 23;
            idlynxOverlayLabel.Text = "IDLynx Overlay";
            idlynxOverlayLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(idlynxOverlayLabel, "Image overlay string for ID Lynx camera");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(37, 474);
            label12.Margin = new Padding(3, 6, 3, 3);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 24;
            label12.Text = "Lap Settings";
            // 
            // createResultLabel
            // 
            createResultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createResultLabel.AutoSize = true;
            createResultLabel.Location = new Point(3, 0);
            createResultLabel.Name = "createResultLabel";
            createResultLabel.Size = new Size(96, 35);
            createResultLabel.TabIndex = 25;
            createResultLabel.Text = "Create Result";
            createResultLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(createResultLabel, "Typically off for all event types.\r\nAdds entries to event list if a lap is found for an ID which is not in the start list.");
            // 
            // fillInTimeLabel
            // 
            fillInTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            fillInTimeLabel.AutoSize = true;
            fillInTimeLabel.Location = new Point(3, 35);
            fillInTimeLabel.Name = "fillInTimeLabel";
            fillInTimeLabel.Size = new Size(81, 35);
            fillInTimeLabel.TabIndex = 27;
            fillInTimeLabel.Text = "Fill In Time";
            fillInTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(fillInTimeLabel, "Typically on.\r\nAutomatically populate overall time based on last lap time.");
            // 
            // defaultLapsLabel
            // 
            defaultLapsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            defaultLapsLabel.AutoSize = true;
            defaultLapsLabel.Location = new Point(3, 70);
            defaultLapsLabel.Name = "defaultLapsLabel";
            defaultLapsLabel.Size = new Size(92, 35);
            defaultLapsLabel.TabIndex = 28;
            defaultLapsLabel.Text = "Default Laps";
            defaultLapsLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(defaultLapsLabel, "Default number of laps for new events.");
            // 
            // maskStartLabel
            // 
            maskStartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            maskStartLabel.AutoSize = true;
            maskStartLabel.Location = new Point(3, 105);
            maskStartLabel.Name = "maskStartLabel";
            maskStartLabel.Size = new Size(78, 35);
            maskStartLabel.TabIndex = 29;
            maskStartLabel.Text = "Mask Start";
            maskStartLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(maskStartLabel, "Time to ignore lap reads after start.");
            // 
            // maskLapLabel
            // 
            maskLapLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            maskLapLabel.AutoSize = true;
            maskLapLabel.Location = new Point(3, 140);
            maskLapLabel.Name = "maskLapLabel";
            maskLapLabel.Size = new Size(71, 36);
            maskLapLabel.TabIndex = 30;
            maskLapLabel.Text = "Mask Lap";
            maskLapLabel.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(maskLapLabel, "Time to ignore lap reads after last lap read for an athlete.");
            // 
            // autoSaveLifNumber
            // 
            autoSaveLifNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            autoSaveLifNumber.Location = new Point(123, 3);
            autoSaveLifNumber.Name = "autoSaveLifNumber";
            autoSaveLifNumber.Size = new Size(54, 27);
            autoSaveLifNumber.TabIndex = 31;
            toolTip.SetToolTip(autoSaveLifNumber, "Seconds to auto save LIF file.\r\n0 to disable.\r\n5 is typical when enabled.");
            // 
            // overlayText
            // 
            overlayText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            overlayText.Location = new Point(123, 38);
            overlayText.Name = "overlayText";
            overlayText.Size = new Size(269, 27);
            overlayText.TabIndex = 32;
            toolTip.SetToolTip(overlayText, "Overlay string for main camera");
            // 
            // idlynxOverlayText
            // 
            idlynxOverlayText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            idlynxOverlayText.Location = new Point(123, 73);
            idlynxOverlayText.Name = "idlynxOverlayText";
            idlynxOverlayText.Size = new Size(269, 27);
            idlynxOverlayText.TabIndex = 33;
            toolTip.SetToolTip(idlynxOverlayText, "Overlay string for ID Lynx camera");
            // 
            // createResultCheckBox
            // 
            createResultCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            createResultCheckBox.AutoSize = true;
            createResultCheckBox.Location = new Point(123, 3);
            createResultCheckBox.Name = "createResultCheckBox";
            createResultCheckBox.Size = new Size(15, 29);
            createResultCheckBox.TabIndex = 34;
            createResultCheckBox.UseVisualStyleBackColor = true;
            // 
            // fillInTimeCheckBox
            // 
            fillInTimeCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            fillInTimeCheckBox.AutoSize = true;
            fillInTimeCheckBox.Checked = true;
            fillInTimeCheckBox.CheckState = CheckState.Checked;
            fillInTimeCheckBox.Location = new Point(123, 38);
            fillInTimeCheckBox.Name = "fillInTimeCheckBox";
            fillInTimeCheckBox.Size = new Size(15, 29);
            fillInTimeCheckBox.TabIndex = 36;
            fillInTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultLapsNumber
            // 
            defaultLapsNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            defaultLapsNumber.Location = new Point(123, 73);
            defaultLapsNumber.Name = "defaultLapsNumber";
            defaultLapsNumber.Size = new Size(54, 27);
            defaultLapsNumber.TabIndex = 37;
            // 
            // maskStartNumber
            // 
            maskStartNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            maskStartNumber.Location = new Point(123, 108);
            maskStartNumber.Name = "maskStartNumber";
            maskStartNumber.Size = new Size(54, 27);
            maskStartNumber.TabIndex = 38;
            maskStartNumber.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // trackButton
            // 
            trackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackButton.Location = new Point(3, 3);
            trackButton.Name = "trackButton";
            trackButton.Size = new Size(189, 39);
            trackButton.TabIndex = 0;
            trackButton.Text = "Track";
            toolTip.SetToolTip(trackButton, "Apply track defaults");
            trackButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(maskLapNumber, 1, 4);
            tableLayoutPanel1.Controls.Add(createResultLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(createResultCheckBox, 1, 0);
            tableLayoutPanel1.Controls.Add(fillInTimeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(defaultLapsLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(maskStartLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(maskLapLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(fillInTimeCheckBox, 1, 1);
            tableLayoutPanel1.Controls.Add(defaultLapsNumber, 1, 2);
            tableLayoutPanel1.Controls.Add(maskStartNumber, 1, 3);
            tableLayoutPanel1.Location = new Point(75, 505);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(296, 176);
            tableLayoutPanel1.TabIndex = 40;
            // 
            // maskLapNumber
            // 
            maskLapNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            maskLapNumber.Location = new Point(123, 143);
            maskLapNumber.Name = "maskLapNumber";
            maskLapNumber.Size = new Size(54, 27);
            maskLapNumber.TabIndex = 41;
            maskLapNumber.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.Controls.Add(baseFolderChooseButton, 2, 0);
            tableLayoutPanel2.Controls.Add(eventFolderChooseButton, 2, 1);
            tableLayoutPanel2.Controls.Add(dbInputFolderChooseButton, 2, 2);
            tableLayoutPanel2.Controls.Add(dbOutputFolderChooseButton, 2, 3);
            tableLayoutPanel2.Controls.Add(backupBaseFolderChooseButton, 2, 4);
            tableLayoutPanel2.Controls.Add(backupFolderChooseButton, 2, 5);
            tableLayoutPanel2.Controls.Add(baseFolderText, 1, 0);
            tableLayoutPanel2.Controls.Add(eventFolderText, 1, 1);
            tableLayoutPanel2.Controls.Add(dbInputFolderText, 1, 2);
            tableLayoutPanel2.Controls.Add(dbOutputFolderText, 1, 3);
            tableLayoutPanel2.Controls.Add(backupBaseFolderText, 1, 4);
            tableLayoutPanel2.Controls.Add(backupFolderText, 1, 5);
            tableLayoutPanel2.Controls.Add(baseFolderLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(dbOutputFolderLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(eventFolderLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(dbInputFolderLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(backupFolderLabel, 0, 5);
            tableLayoutPanel2.Controls.Add(backupBaseFolderLabel, 0, 4);
            tableLayoutPanel2.Location = new Point(75, 65);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.Size = new Size(549, 210);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(overlayText, 1, 1);
            tableLayoutPanel3.Controls.Add(autoSaveLifLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(overlayLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(idlynxOverlayLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(idlynxOverlayText, 1, 2);
            tableLayoutPanel3.Controls.Add(autoSaveLifNumber, 1, 0);
            tableLayoutPanel3.Location = new Point(75, 365);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.Size = new Size(395, 105);
            tableLayoutPanel3.TabIndex = 42;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel4.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel4.Location = new Point(12, 693);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(643, 45);
            tableLayoutPanel4.TabIndex = 43;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.BackColor = Color.FromArgb(0, 192, 0);
            saveButton.Location = new Point(3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(315, 39);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.BackColor = Color.Red;
            cancelButton.Location = new Point(324, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(316, 39);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.Controls.Add(trackButton, 0, 0);
            tableLayoutPanel5.Controls.Add(xcButton, 1, 0);
            tableLayoutPanel5.Controls.Add(ttButton, 2, 0);
            tableLayoutPanel5.Location = new Point(37, 281);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(587, 45);
            tableLayoutPanel5.TabIndex = 44;
            // 
            // xcButton
            // 
            xcButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xcButton.Location = new Point(198, 3);
            xcButton.Name = "xcButton";
            xcButton.Size = new Size(189, 39);
            xcButton.TabIndex = 1;
            xcButton.Text = "XC / RR";
            xcButton.UseVisualStyleBackColor = true;
            // 
            // ttButton
            // 
            ttButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ttButton.Location = new Point(393, 3);
            ttButton.Name = "ttButton";
            ttButton.Size = new Size(191, 39);
            ttButton.TabIndex = 2;
            ttButton.Text = "TT";
            ttButton.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 750);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(setAllFolderButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConfigForm";
            Text = "Lynx Configurator";
            ((System.ComponentModel.ISupportInitialize)autoSaveLifNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)defaultLapsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)maskStartNumber).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maskLapNumber).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox baseFolderText;
        private Label baseFolderLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button baseFolderChooseButton;
        private Button eventFolderChooseButton;
        private Label eventFolderLabel;
        private TextBox eventFolderText;
        private Button dbInputFolderChooseButton;
        private Label dbInputFolderLabel;
        private TextBox dbInputFolderText;
        private Button dbOutputFolderChooseButton;
        private Label dbOutputFolderLabel;
        private TextBox dbOutputFolderText;
        private Button backupBaseFolderChooseButton;
        private Label backupBaseFolderLabel;
        private TextBox backupBaseFolderText;
        private Button backupFolderChooseButton;
        private Label backupFolderLabel;
        private TextBox backupFolderText;
        private Button setAllFolderButton;
        private Label label8;
        private Label autoSaveLifLabel;
        private Label overlayLabel;
        private Label idlynxOverlayLabel;
        private Label label12;
        private Label createResultLabel;
        private Label fillInTimeLabel;
        private Label defaultLapsLabel;
        private Label maskStartLabel;
        private Label maskLapLabel;
        private NumericUpDown autoSaveLifNumber;
        private TextBox overlayText;
        private TextBox idlynxOverlayText;
        private CheckBox createResultCheckBox;
        private CheckBox fillInTimeCheckBox;
        private NumericUpDown defaultLapsNumber;
        private NumericUpDown maskStartNumber;
        private ToolTip toolTip;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown maskLapNumber;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button saveButton;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Button trackButton;
        private Button xcButton;
        private Button ttButton;
    }
}