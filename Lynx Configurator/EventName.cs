namespace Lynx_Configurator
{
    public partial class EventName : Form
    {
        public string? EventNameText
        {
            get
            {
                if (_cancelled)
                {
                    return null;
                }
                var eventName = eventNameTextBox.Text;
                if (includeDateCheckBox.Checked)
                {
                    eventName = datePicker.Value.ToString("yyyy-MM-dd ") + eventName;
                }
                return eventName;
            }

        }
        private bool _cancelled = false;

        public EventName()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void includeDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.datePicker.Enabled = this.includeDateCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _cancelled = true;
            this.Close();
        }
    }
}
