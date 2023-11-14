using System;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    public partial class ReviseTopics : Form
    {
        Deck CurrentDeck = new Deck(10, MainMenu.CurrentStudent.ID);
        State state = State.Unassigned;
        int Difficulty;
        int currentquestion = 0;
        int guess = 0;
        public ReviseTopics()
        {
            InitializeComponent();
            this.LoggedIn.Text = "Logged in as : " + MainMenu.CurrentStudent.Fname;
            this.Guess1btn.Hide();
            this.Guess2btn.Hide();
            this.Guess3btn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.BackStack.Pop().Show();
        }

        private void LoggedIn_Click(object sender, EventArgs e)
        {

        }


        private void KeywordBtn_Click_1(object sender, EventArgs e)
        {
            state = State.Keyword;
        }

        private void LearnDefinitionBtn_Click(object sender, EventArgs e)
        {
            state = State.Definition;
        }

        private void EasyDifficultyBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 1;
        }

        private void MediumDifficultyBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 2;
        }

        private void HardDifficultyBtn_Click(object sender, EventArgs e)
        {
            Difficulty = 3;
        }

        private void GetFlashcardsBtn_Click(object sender, EventArgs e)
        {
            Topic wantedtopicvalue = (Topic)SelectTopicBox.SelectedIndex - 1;
            CurrentDeck = DataBaseUtils.GetQuestions(Difficulty, wantedtopicvalue, state);
            LearnDeck();

        }
        private void LearnDeck()
        {
            Guess1btn.Show();
            Guess2btn.Show();
            Guess3btn.Show();
            if (CurrentDeck.state == State.Keyword)
            {
                for (int i = 0; i < CurrentDeck.length; i++)
                {
                    Random rnd = new Random();
                    Flashcardtermordefinition.Text = CurrentDeck[i].Title;
                    int correctposition = rnd.Next(1, 3);
                    int tempfill;
                    MyList<int> fillerpos;
                    switch (correctposition)
                    {
                        case 1:
                            fillerpos = new MyList<int>(CurrentDeck.length);
                            for(int x =0; i < CurrentDeck.length; x++)
                            {
                                fillerpos.Add(i);
                            }
                            fillerpos.Remove(correctposition);
                            Guess1btn.Text = "1: " + CurrentDeck[i].Answer;
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess2btn.Text = "2: " + CurrentDeck[tempfill].Answer;
                            fillerpos.Remove(tempfill);
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess3btn.Text = "3: " + CurrentDeck[tempfill].Answer;
                            break;
                        case 2:
                            fillerpos = new MyList<int>(CurrentDeck.length);
                            for (int x = 0; i < CurrentDeck.length; x++)
                            {
                                fillerpos.Add(i);
                            }
                            fillerpos.Remove(correctposition);
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess1btn.Text = "1: " + CurrentDeck[tempfill].Answer;
                            fillerpos.Remove(tempfill);
                            Guess2btn.Text = "2: " + CurrentDeck[i].Answer;
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess2btn.Text = "3: " + CurrentDeck[tempfill];
                            break;
                        case 3:
                            fillerpos = new MyList<int>(CurrentDeck.length);
                            for (int x = 0; i < CurrentDeck.length; x++)
                            {
                                fillerpos.Add(i);
                            }
                            fillerpos.Remove(correctposition);
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess1btn.Text = "1: " + CurrentDeck[tempfill].Answer;
                            fillerpos.Remove(tempfill);
                            tempfill = rnd.Next(0, fillerpos.Count);
                            Guess2btn.Text = "2: " + CurrentDeck[tempfill].Answer;
                            Guess3btn.Text = "3: " + CurrentDeck[i].Answer;
                            break;
                    }
                }
            }
            if (CurrentDeck.state == State.Definition)
            {
                for (int i = 0; i < CurrentDeck.length; i++)
                {
                    Random rnd = new Random();
                    Flashcardtermordefinition.Text = CurrentDeck[i].Title;
                    int correctposition = rnd.Next(1, 3);
                    switch (correctposition)
                    {
                        case 1:               
                            Guess1btn.Text = "1: " + CurrentDeck[i].Answer;
                            Guess2btn.Text = "2: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)].Answer;
                            Guess3btn.Text = "3: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)].Answer;
                            break;
                        case 2:
                            Guess1btn.Text = "1: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)].Answer;
                            Guess2btn.Text = "2: " + CurrentDeck[i].Answer;
                            Guess2btn.Text = "3: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)];
                            break;
                        case 3:
                            Guess1btn.Text = "1: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)].Answer;
                            Guess2btn.Text = "2: " + CurrentDeck[rnd.Next(currentquestion+1, CurrentDeck.length)].Answer;
                            Guess3btn.Text = "3: " + CurrentDeck[i].Answer;
                            break;
                    }
                }
            }
        }

        
        private void Guess1btn_Click(object sender, EventArgs e)
        {
            guess = 1;
        }

        private void Guess2btn_Click(object sender, EventArgs e)
        {
            guess = 2;
        }

        private void Guess3btn_Click(object sender, EventArgs e)
        {
            guess = 3;
        }
    }
    
}

