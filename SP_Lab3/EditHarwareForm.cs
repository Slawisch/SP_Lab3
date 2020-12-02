using System;
using System.Windows.Forms;

namespace SP_Lab3
{
    public partial class EditHarwareForm : Form
    {
        private ProgramManager programManager;
        public EditHarwareForm()
        {
            osCb.Items.AddRange(new Object[]{OS.Android, OS.Linux, OS.Windows, OS.IOS, OS.MacOS});
            InitializeComponent();
        }
        
        public EditHarwareForm(ProgramManager programManager)
        {
            InitializeComponent();
            this.programManager = programManager;
            osCb.Items.AddRange(new Object[]{OS.Android, OS.Linux, OS.Windows, OS.IOS, OS.MacOS});
            osCb.SelectedItem = programManager.Os;
            cpuNum.Value = programManager.CPUFrequency;
            ramNum.Value = programManager.RAM;
            hddNum.Value = programManager.HDD;
        }


        private void applyBt_Click(object sender, EventArgs e)
        {
            programManager.Os = (OS) Enum.Parse(typeof(OS), osCb.Text, true);
            programManager.CPUFrequency = (int)cpuNum.Value;
            programManager.RAM = (int)ramNum.Value;
            programManager.HDD = (int)hddNum.Value;
            DialogResult = DialogResult.Yes;
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}