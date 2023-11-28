using System;
using System.Windows.Forms;

namespace Geography_Question_Tester.Forms
{
    public partial class ReviseDecks : Form
    {
        private int currentcard = 0;
        private int currentdeck = 0;

        public ReviseDecks()
        {
            InitializeComponent();
            this.loggedinbtn.Text = MainMenu.CurrentStudent.Fname;
            for (int i = 0; i < MainMenu.CurrentStudent.currentdecks.Count; i++)
            {
                DeckComboBox.Items.Add(MainMenu.CurrentStudent.currentdecks[i].ownerID);
            }
            hideguess();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }
        private void hideguess()
        {
            EasyBtn.Hide();
            MediumBtn.Hide();
            HardBtn.Hide();
        }
        private void showguess()
        {
            EasyBtn.Show();
            MediumBtn.Show();
            HardBtn.Show();
        }

        private void EasyBtn_Click(object sender, EventArgs e)
        {
            DataBaseUtils.UpdateFlashcardDifficulty(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].ID, "Difficulty", MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty - 0.1);
            MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty = MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty - 0.1;
            currentcard++;
            if (currentcard > 9)
            {
                currentcard = 0;
                endofdeck();
            }
            else
            {
                showcard();
                hideguess();
            }
            
        }
        private void MediumBtn_Click(object sender, EventArgs e)
        {
            DataBaseUtils.UpdateFlashcardDifficulty(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].ID, "Difficulty", MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty + 0.1);
            MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty = MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty + 0.1;
            currentcard++;
            if (currentcard > 9)
            {
                currentcard = 0;
                endofdeck();
            }
            else
            {
                showcard();
                hideguess();
            }          
        }

        private void HardBtn_Click(object sender, EventArgs e)
        {
            DataBaseUtils.UpdateFlashcardDifficulty(MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].ID, "Difficulty", MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty + 0.2);
            MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty = MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Difficulty + 0.1;
            currentcard++;
            if (currentcard > 9)
            {
                currentcard = 0;
                endofdeck();
                
            }
            else
            {
                showcard();
                hideguess();
            }       
        }
        private void LoadDeck_Click(object sender, EventArgs e)
        {
            currentdeck = DeckComboBox.SelectedIndex;
            showcard();
        }
        private void endofdeck()
        {
            hideguess();
            DeckComboBox.Items.RemoveAt(DeckComboBox.SelectedIndex);
            Flashcardterm.Enabled = false;
            Flashcardterm.Text = "Please pick another deck";
        }

        private void showcard()
        {
            Flashcardterm.Enabled = true;
            Flashcardterm.Text = MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Title;
        }

        private void Flashcardterm_Click(object sender, EventArgs e)
        {
            Flashcardterm.Text = MainMenu.CurrentStudent.currentdecks[currentdeck][currentcard].Answer;
            Flashcardterm.Enabled = false;
            showguess();
        }
        //when it gets to the end of the deck it breaks;
    }
}
