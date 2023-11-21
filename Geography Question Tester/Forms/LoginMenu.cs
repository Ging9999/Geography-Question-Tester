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
    public partial class LoginMenu : Form
    {
        public static MyStack<Form> BackStack = new MyStack<Form>();
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void CreateAccountbtn_Click(object sender, EventArgs e)
        {
            new CreateAccountMenu().Show();
            BackStack.Push(this);
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Student CurrentStudent = DataBaseUtils.GetStudent(int.Parse(PasswordTxtBox.Text));
                new MainMenu(CurrentStudent).Show();
                Hide();
                LoginMenu.BackStack.Push(this);
                if (CurrentStudent.Fname.Trim() + " " + CurrentStudent.Lname.Trim() != UsernameTxtBox.Text)
                {
                    MessageBox.Show("Inccorect Username", "error", MessageBoxButtons.OK);
                }
                else
                {
                   new MainMenu(CurrentStudent).Show();
                   Hide();
                   LoginMenu.BackStack.Push(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect Username or password", "error", MessageBoxButtons.OK);
                Console.WriteLine(ex);
            }
            
        }
        

    }
}
