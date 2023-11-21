using Geography_Question_Tester.Forms;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    partial class MainMenu : Form
    {
        public static Student CurrentStudent;
        public MainMenu(Student currentstudent)
        {
            CurrentStudent = currentstudent;
            InitializeComponent();
            this.LoggedIn.Text = "Logged in as : " + CurrentStudent.Fname;
            CurrentStudent.currentdecks = DataBaseUtils.loaddecks(currentstudent.ID);
            //Console.WriteLine(CurrentStudent.currentdecks[0][0].Answer);
        }

        private void BtnReviseTopics_Click(object sender, EventArgs e)
        {
            new ReviseTopics().Show();
            this.Hide();
            LoginMenu.BackStack.Push(this);
        }
        private void BtnReviseDecks_Click(object sender, EventArgs e)
        {
            if(CurrentStudent.currentdecks.Count == 0)
            {
                MessageBox.Show("Please revise some topics before generating decks", "Revise Decks", MessageBoxButtons.OK);
            }
            else
            {
                new ReviseDecks().Show();
                LoginMenu.BackStack.Push(this);
                this.Hide();
            }          
        }
        private void BtnViewStats_Click(object sender, EventArgs e)
        {
            new ViewStats().Show();
            this.Hide();
        }

        private void BtnAddFlashCard_Click(object sender, EventArgs e)
        {
            new AddFlashard().Show();
            LoginMenu.BackStack.Push(this);
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DataBaseUtils.WriteDecks(CurrentStudent.currentdecks);
            this.Close();
            LoginMenu.BackStack.Pop().Show();
        }
    }
}
