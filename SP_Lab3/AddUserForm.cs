using System;
using System.Windows.Forms;

namespace SP_Lab3
{
    public partial class AddUserForm : Form
    {
        public User user = new User();
        public AddUserForm()
        {
            InitializeComponent();
        }

        public AddUserForm(User user1)
        {
            InitializeComponent();
            user = user1;
            nameTb.Text = user.Name;
            passTb.Text = new string(user.Password);
        }

        private void applyBt_Click(object sender, EventArgs e)
        {
           user = new User(nameTb.Text, passTb.Text.ToCharArray());
           DialogResult = DialogResult.Yes;
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}