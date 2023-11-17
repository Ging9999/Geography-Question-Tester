using Geography_Question_Tester.Forms;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    public partial class MainMenu : Form
    {
        public static Student CurrentStudent { get;  private set; }
        public MainMenu(Student currentstudent)
        {
            CurrentStudent = currentstudent;
            InitializeComponent();
            this.LoggedIn.Text = "Logged in as : " + CurrentStudent.Fname;
            //load decks of student
        }

        private void BtnReviseTopics_Click(object sender, EventArgs e)
        {
            new ReviseTopics().Show();
            this.Hide();
            LoginMenu.BackStack.Push(this);
        }
        private void BtnReviseDecks_Click(object sender, EventArgs e)
        {
            new ReviseDecks().Show();
            LoginMenu.BackStack.Push(this);
            this.Hide();
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
            this.Close();
            LoginMenu.BackStack.Pop().Show();
        }
    }
}
