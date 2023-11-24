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
    public partial class ReviseDecks : Form
    {
        private DeckGenerator DeckGenerator = new DeckGenerator();
        private int currentcard = 0;
        private int currentdeck = 0;
        private string _choice = "";
        public ReviseDecks()
        {
            InitializeComponent();
            this.loggedinbtn.Text = MainMenu.CurrentStudent.Fname;
            for(int i = 0; i < MainMenu.CurrentStudent.currentdecks.Count; i++)
            {
                DeckComboBox.Items.Add(MainMenu.CurrentStudent.currentdecks[i].ownerID);
            }
            
            
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }
        private void start()
        {
            
        }

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            DeckGenerator.easy(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard]);
        }

        private void MediumBtn_Click(object sender, EventArgs e)
        {
            DeckGenerator.medium(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard]);
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            DeckGenerator.hard(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard]);
        }

        private void DefinitionBtn_Click(object sender, EventArgs e)
        {
            _choice = "Definition";
        }

        private void Keywordtbn_Click(object sender, EventArgs e)
        {
            _choice = "Keyword";
        }
        private void run()
        {

        }
    }
}
