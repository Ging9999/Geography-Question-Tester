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
    public partial class AddFlashard : Form
    {
        //take average card rating and then compare against class
        public AddFlashard()
        {
            InitializeComponent();
            Currentuserbtn.Text = "Current user : " + MainMenu.CurrentStudent.Fname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }

        private void SubmitFlashcardBtn_Click(object sender, EventArgs e)
        {
            if(Keywordtxtbox.Text == "" || Definitiontxtbox.Text == "" || Topiccombobox.SelectedIndex == -1)
            {
                MessageBox.Show("please enter in every input", "", MessageBoxButtons.OK);
            }
            else
            {
                int id = DataBaseUtils.GetNumberofcards() + 1;
                Topic wanted = (Topic)Topiccombobox.SelectedIndex;
                DataBaseUtils.AddFlashcard(id, Keywordtxtbox.Text, Definitiontxtbox.Text, wanted, 2);
                Keywordtxtbox.Clear();
                Definitiontxtbox.Clear();
                Topiccombobox.SelectedIndex = -1;
            }          
        }
    }
}
