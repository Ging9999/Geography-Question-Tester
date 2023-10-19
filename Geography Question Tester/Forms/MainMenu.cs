using Geography_Question_Tester.Forms;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnReviseTopics_Click(object sender, EventArgs e)
        {
            new ReviseTopics().Show();
            this.Hide();
        }
        private void BtnReviseDecks_Click(object sender, EventArgs e)
        {
            new ReviseDecks().Show();
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
            this.Hide();
        }
    }
}
