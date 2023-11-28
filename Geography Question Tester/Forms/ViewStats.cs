using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester.Forms
{
    public partial class ViewStats : Form
    {
        public ViewStats()
        {
            InitializeComponent();
            Loggedinas.Text = "Logged in as : " + MainMenu.CurrentStudent.Fname;
            StudentStatsBox.Text = MainMenu.CurrentStudent.Fname + " Statistics";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }

        private void LoadStats()
        {

        }
        public void GetAverage()
        {
            string sSqlstring = "SELECT * FROM FlashCards"
        }
    }
}
