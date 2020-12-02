using System;
using System.Windows.Forms;

namespace SP_Lab3
{
    public partial class AddProgramForm : Form
    {
        public UserProgram program;
        public AddProgramForm()
        {
            InitializeComponent();
            osCb.Items.AddRange(new Object[]{OS.Android, OS.Linux, OS.Windows, OS.IOS, OS.MacOS});
            osCb.SelectedIndex = 0;
            
        }

        public AddProgramForm(UserProgram program1)
        {
            InitializeComponent();
            osCb.Items.AddRange(new Object[]{OS.Android, OS.Linux, OS.Windows, OS.IOS, OS.MacOS});
            program = program1;
            if (program != null)
            {
                nameTb.Text = program.Name;
                osCb.SelectedItem = program._os;
                companyTb.Text = program.Company;
                dateTime.Value = program.Installed;
                versionNum.Value = (decimal)program.Version;
                ramNum.Value = program.RAMRequire;
                cpuNum.Value = program.CPUFrequency;
                hddNum.Value = program.HDDStore;
            }
        }

        private void applyBt_Click(object sender, EventArgs e)
        {
            program = new UserProgram(nameTb.Text, (OS) Enum.Parse(typeof(OS), osCb.Text, true), companyTb.Text,
                dateTime.Value, (float) versionNum.Value, (int) ramNum.Value, (int) cpuNum.Value, (int) hddNum.Value);
            DialogResult = DialogResult.Yes;
        }
        
        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}