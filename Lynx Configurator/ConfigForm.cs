namespace Lynx_Configurator
{
    public partial class ConfigForm : Form
    {

        private LynxCfgEditor _cfgEditor;

        public ConfigForm()
        {
            InitializeComponent();
            // Add version to title
            Version? version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (version != null)
            {
                this.Text += " " + $"{version.Major}.{version.Minor}.{version.Build}";
            }
            _cfgEditor = new LynxCfgEditor(Properties.Settings.Default.LynxCfgPath);
            LoadSettings();
            LoadDataFromCfg();
        }

        private void LoadSettings()
        {
            baseFolderText.Text = Properties.Settings.Default.BaseFolder;
            backupBaseFolderText.Text = Properties.Settings.Default.BackupBaseFolder;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.BaseFolder = baseFolderText.Text;
            Properties.Settings.Default.BackupBaseFolder = backupBaseFolderText.Text;
            Properties.Settings.Default.Save();
        }

        private void LoadDataFromCfg()
        {
            eventFolderText.Text = _cfgEditor.getEventDirectory();
            dbInputFolderText.Text = _cfgEditor.getDatabaseFileDataInDir();
            dbOutputFolderText.Text = _cfgEditor.getDatabaseFileDataOutDir();
            backupFolderText.Text = _cfgEditor.getEventBackupDir();

            autoSaveLifNumber.Value = _cfgEditor.getDatabaseLIFAutoSave();
            overlayText.Text = _cfgEditor.getEventImageOverlayLinesFormat();
            idlynxOverlayText.Text = _cfgEditor.getEventImageOverlayIdLLinesFormat();

            createResultCheckBox.Checked = _cfgEditor.getLapTimeCreateResults();
            fillInTimeCheckBox.Checked = _cfgEditor.getLapTimeFillInTime();
            defaultLapsNumber.Value = _cfgEditor.getLapTimeTotalLaps();
            maskStartNumber.Value = _cfgEditor.getLapTimeStartMask();
            maskLapNumber.Value = _cfgEditor.getLapTimeDuplicateMask();
        }

        private string? BrowseForFolder(string? startingFolder)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a base folder where Lynx results are stored";
                folderDialog.ShowNewFolderButton = true; // Allow the user to create new folders

                if (startingFolder != null && !startingFolder.Equals(""))
                {
                    folderDialog.SelectedPath = startingFolder;
                }

                // Show the dialog and check if the user clicked OK
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedPath = folderDialog.SelectedPath;
                    return selectedPath;
                }

                return null;
            }
        }

        private void CheckDirectoriesExist()
        {
            if (!Directory.Exists(eventFolderText.Text))
            {
                // Create directory
                Directory.CreateDirectory(eventFolderText.Text);
            }
            if (!Directory.Exists(dbInputFolderText.Text))
            {
                Directory.CreateDirectory(dbInputFolderText.Text);
            }
            if (!Directory.Exists(dbOutputFolderText.Text))
            {
                Directory.CreateDirectory(dbOutputFolderText.Text);
            }
            if (!Directory.Exists(backupFolderText.Text))
            {
                Directory.CreateDirectory(backupFolderText.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();

            var changes = new List<string>();
            if (eventFolderText.Text != _cfgEditor.getEventDirectory())
            {
                _cfgEditor.setEventDirectory(eventFolderText.Text);
                changes.Add("Event Folder");
            }
            if (dbInputFolderText.Text != _cfgEditor.getDatabaseFileDataInDir())
            {
                _cfgEditor.setDatabaseFileDataInDir(dbInputFolderText.Text);
                changes.Add("Database Input Folder");
            }
            if (dbOutputFolderText.Text != _cfgEditor.getDatabaseFileDataOutDir())
            {
                _cfgEditor.setDatabaseFileDataOutDir(dbOutputFolderText.Text);
                changes.Add("Database Output Folder");
            }
            if (backupFolderText.Text != _cfgEditor.getEventBackupDir())
            {
                _cfgEditor.setEventBackupDir(backupFolderText.Text);
                changes.Add("Backup Folder");
            }
            if (autoSaveLifNumber.Value != _cfgEditor.getDatabaseLIFAutoSave())
            {
                _cfgEditor.setDatabaseLIFAutoSave((int)autoSaveLifNumber.Value);
                changes.Add("Auto Save LIF");
            }
            if (overlayText.Text != _cfgEditor.getEventImageOverlayLinesFormat())
            {
                _cfgEditor.setEventImageOverlayLinesFormat(overlayText.Text);
                changes.Add("Overlay Text");
            }
            if (idlynxOverlayText.Text != _cfgEditor.getEventImageOverlayIdLLinesFormat())
            {
                _cfgEditor.setEventImageOverlayIdLLinesFormat(idlynxOverlayText.Text);
                changes.Add("ID Lynx Overlay Text");
            }
            if (createResultCheckBox.Checked != _cfgEditor.getLapTimeCreateResults())
            {
                _cfgEditor.setLapTimeCreateResults(createResultCheckBox.Checked);
                changes.Add("Create Results");
            }
            if (fillInTimeCheckBox.Checked != _cfgEditor.getLapTimeFillInTime())
            {
                _cfgEditor.setLapTimeFillInTime(fillInTimeCheckBox.Checked);
                changes.Add("Fill In Time");
            }
            if (defaultLapsNumber.Value != _cfgEditor.getLapTimeTotalLaps())
            {
                _cfgEditor.setLapTimeTotalLaps((int)defaultLapsNumber.Value);
                changes.Add("Default Laps");
            }
            if (maskStartNumber.Value != _cfgEditor.getLapTimeStartMask())
            {
                _cfgEditor.setLapTimeStartMask((int)maskStartNumber.Value);
                changes.Add("Mask Start");
            }
            if (maskLapNumber.Value != _cfgEditor.getLapTimeDuplicateMask())
            {
                _cfgEditor.setLapTimeDuplicateMask((int)maskLapNumber.Value);
                changes.Add("Mask Lap");
            }

            if (changes.Count > 0)
            {
                var response = MessageBox.Show("These settings will be updated: \r\n  -" + string.Join("\r\n  -", changes), "Confirm Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (response == DialogResult.OK)
                {
                    _cfgEditor.Save();
                    CheckDirectoriesExist();
                    MessageBox.Show("Settings have been saved", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No settings have been changed", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void baseFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(baseFolderText.Text);
            if (folder != null)
            {
                baseFolderText.Text = folder;
            }
        }

        private void backupBaseFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(backupBaseFolderText.Text);
            if (folder != null)
            {
                backupBaseFolderText.Text = folder;
            }
        }

        private void eventFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(eventFolderText.Text);
            if (folder != null)
            {
                eventFolderText.Text = folder;
            }
        }

        private void dbInputFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(dbInputFolderText.Text);
            if (folder != null)
            {
                dbInputFolderText.Text = folder;
            }
        }

        private void dbOutputFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(dbOutputFolderText.Text);
            if (folder != null)
            {
                dbOutputFolderText.Text = folder;
            }
        }

        private void backupFolderChooseButton_Click(object sender, EventArgs e)
        {
            var folder = BrowseForFolder(backupFolderText.Text);
            if (folder != null)
            {
                backupFolderText.Text = folder;
            }
        }

        private void setAllFolderButton_Click(object sender, EventArgs e)
        {
            var eventNameDialog = new EventName();
            eventNameDialog.ShowDialog();
            var eventName = eventNameDialog.EventNameText;
            if (eventName != null)
            {
                eventFolderText.Text = System.IO.Path.Combine(baseFolderText.Text, eventName);
                dbInputFolderText.Text = System.IO.Path.Combine(baseFolderText.Text, eventName);
                dbOutputFolderText.Text = System.IO.Path.Combine(baseFolderText.Text, eventName);
                backupFolderText.Text = System.IO.Path.Combine(backupBaseFolderText.Text, eventName);
            }
        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            // Track Config

            // Disable Auto save LIF
            autoSaveLifNumber.Value = 0;

            // Set overlay to include lane number
            overlayText.Text = "#%6 %7 %8;%9";
            idlynxOverlayText.Text = "#%5 %7 %8;%9";

            // Set default laps to 0
            defaultLapsNumber.Value = 0;
        }

        private void xcButton_Click(object sender, EventArgs e)
        {
            // XC and road race config

            // Enable Auto save LIF
            autoSaveLifNumber.Value = 5;

            // Set overlay to include athlete ID
            overlayText.Text = "#%5 %7 %8;%9";
            idlynxOverlayText.Text = "#%5 %7 %8;%9";

            // Set default laps to 1
            defaultLapsNumber.Value = 1;
        }

        private void ttButton_Click(object sender, EventArgs e)
        {
            // Time trial

            // Enable Auto save LIF
            autoSaveLifNumber.Value = 5;

            // Set overlay to include athlete ID & lap count
            overlayText.Text = "#%5 %7 %8 (Lap %22);%9";
            idlynxOverlayText.Text = "#%5 %7 %8;%9";

            // Set default laps to 4
            defaultLapsNumber.Value = 4;

        }

    }
}
