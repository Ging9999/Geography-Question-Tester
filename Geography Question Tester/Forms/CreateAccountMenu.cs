using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    public partial class CreateAccountMenu : Form
    {
        public CreateAccountMenu()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.BackStack.Pop().Show();
        }

        private void TutorGroupLbl_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            DataBaseUtils.AddStudent(DataBaseUtils.CreateIDs(FirstNameBox.Text, LastNameBox.Text), FirstNameBox.Text, LastNameBox.Text, TutorGroupBox.Text);
            MessageBox.Show("Your ID is : " + DataBaseUtils.CreateIDs(FirstNameBox.Text, LastNameBox.Text), "ID", MessageBoxButtons.OK);
            this.Hide();
            LoginMenu.BackStack.Pop().Show();
        }
    }
}
