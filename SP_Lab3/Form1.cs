using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Lab3
{
    public partial class Form1 : Form
    {
        ProgramManager _programManager = new ProgramManager();
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {   
            var font = new Font(FontFamily.GenericSerif, 8, FontStyle.Regular);
            e.Graphics.DrawString(_programManager.ToString(), font, new SolidBrush(Color.Black), 10, 402);
        }

        private void addProgramBt_Click(object sender, EventArgs e)
        {
            var addProg = new AddProgramForm();
            addProg.ShowDialog();
            if (addProg.DialogResult == DialogResult.Yes)
            {
                _programManager.AddProgram(addProg.program);
            }
            UpdateProgramListBox();
            Update();
        }

        private void UpdProgramBt_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0) return;
            _programManager.UpdateProgram(listBox1.SelectedIndex, (listBox1.SelectedItem as UserProgram).Version + 1);
            UpdateProgramListBox();
            Update();
        }

        private void delProgramBt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            _programManager.DelProgram(listBox1.SelectedIndex);
            UpdateProgramListBox();
            Update();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox2.SelectedIndex < 0)
                return;
            var addingProgram = _programManager.Programs[listBox1.SelectedIndex];
            var addingUser = listBox2.SelectedItem as User;
            if (!addingUser.AvailablePrograms.Contains(addingProgram))
                addingUser.AvailablePrograms.Add(addingProgram);
            UpdateUserListBox();
            Update();
        }

        private void delProgramUserBt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox2.SelectedIndex < 0)
                return;
            var addingProgram = _programManager.Programs[listBox1.SelectedIndex];
            var addingUser = listBox2.SelectedItem as User;
            if (addingUser.AvailablePrograms.Contains(addingProgram))
                addingUser.AvailablePrograms.Remove(addingProgram);
            UpdateUserListBox();
            Update();
        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            var addUser = new AddUserForm();
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.Yes)
            {
                _programManager.AddUser(addUser.user);
            }
            UpdateUserListBox();
            Update();
        }

        private void delUserBt_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0)
                return;
            _programManager.DelUser(listBox2.SelectedItem as User);
            UpdateUserListBox();
            Update();
        }

        private void compUserBt_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex < 0)
                return;
            
            string result;

            if ((listBox1.SelectedItem as UserProgram) > _programManager.Programs[0])
                result = "This user has more available programs";
            else
                result = "This user has less available programs";

            MessageBox.Show(result);
        }

        private void editParamsBt_Click(object sender, EventArgs e)
        {
            var editHard = new EditHarwareForm(_programManager);
            editHard.ShowDialog();
            Invalidate();
        }

        private void compProgramsBt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            
            string result;

            if ((listBox1.SelectedItem as UserProgram) > _programManager.Programs[0])
                result = "This program requires better CPU";
            else
                result = "This program doesn't require better CPU";

            MessageBox.Show(result);
        }

        private void UpdateProgramListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(_programManager.Programs.ToArray());
        }
        
        private void UpdateUserListBox()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(_programManager.Users.Values.ToArray());
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var addProg = new AddProgramForm(listBox1.SelectedItem as UserProgram);
            addProg.ShowDialog();
            if (addProg.DialogResult == DialogResult.Yes)
            {
                _programManager.ReplaceProgram(addProg.program, listBox1.SelectedIndex);
            }
            UpdateProgramListBox();
            Update();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            var addUser = new AddUserForm((listBox2.SelectedItem as User));
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.Yes)
            {
                _programManager.ReplaceUser(addUser.user);
            }
            UpdateUserListBox();
            Update();
        }
    }
}