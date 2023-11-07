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
            LoginMenu.BackStack.Pop();
        }
        private void OnShow() => LoginMenu.BackStack.Push(this);
    }
}
