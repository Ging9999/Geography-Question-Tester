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
        int currentcorrectquestionbutton;
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
                currentcorrectquestionbutton = LearnKeyword(); //implement checking asnwer
            }
            if (CurrentDeck.state == State.Definition)
            {
                currentcorrectquestionbutton = LearnDefinition(); //implement checking answer
            }
        }
        private int LearnKeyword()
        {
            Random rnd = new Random();
            Flashcardtermordefinition.Text = CurrentDeck[currentquestion].Title;
            int correctposition = rnd.Next(1, 4);
            int tempfill1 = -1;
            int tempfill2 = -1;
            while (tempfill1 == currentquestion || tempfill1 == -1)
            {
                tempfill1 = rnd.Next(0, CurrentDeck.length);
            }

            while (tempfill2 == currentquestion || tempfill2 == -1 || tempfill1 == tempfill2)
            {
                tempfill2 = rnd.Next(0, CurrentDeck.length);
            }
            switch (correctposition)
            {
                case 1:
                    Guess1btn.Text = "1: " + CurrentDeck[currentquestion].Answer;
                    Guess2btn.Text = "2: " + CurrentDeck[tempfill1].Answer;
                    Guess3btn.Text = "3: " + CurrentDeck[tempfill2].Answer;
                    Console.WriteLine(currentquestion + " " + CurrentDeck[currentquestion].Answer);
                    Console.WriteLine(tempfill1 + " " + CurrentDeck[tempfill1].Answer);
                    Console.WriteLine(tempfill2 + " " + CurrentDeck[tempfill2].Answer);
                    break;
                case 2:
                    Guess1btn.Text = "1: " + CurrentDeck[tempfill1].Answer;
                    Guess2btn.Text = "2: " + CurrentDeck[currentquestion].Answer;
                    Guess3btn.Text = "3: " + CurrentDeck[tempfill2].Answer;
                    break;
                case 3:
                    Guess1btn.Text = "1: " + CurrentDeck[tempfill1].Answer;
                    Guess2btn.Text = "2: " + CurrentDeck[tempfill2].Answer;
                    Guess3btn.Text = "3: " + CurrentDeck[currentquestion].Answer;
                    break;
            }
            return correctposition;
        }
        private int LearnDefinition()
        {
            Random rnd = new Random();
            Flashcardtermordefinition.Text = CurrentDeck[currentquestion].Answer;
            int correctposition = rnd.Next(1, 4);
            int tempfill1 = -1;
            int tempfill2 = -1;
            while (tempfill1 == currentquestion || tempfill1 == -1)
            {
                tempfill1 = rnd.Next(0, CurrentDeck.length);
            }

            while (tempfill2 == currentquestion || tempfill2 == -1 || tempfill1 == tempfill2)
            {
                tempfill2 = rnd.Next(0, CurrentDeck.length);
            }
            switch (correctposition)
            {
                case 1:
                    Guess1btn.Text = "1: " + CurrentDeck[currentquestion].Title;
                    Guess2btn.Text = "2: " + CurrentDeck[tempfill1].Title;
                    Guess3btn.Text = "3: " + CurrentDeck[tempfill2].Title;
                    Console.WriteLine(currentquestion + " " + CurrentDeck[currentquestion].Title);
                    Console.WriteLine(tempfill1 + " " + CurrentDeck[tempfill1].Title);
                    Console.WriteLine(tempfill2 + " " + CurrentDeck[tempfill2].Title);
                    break;
                case 2:
                    Guess1btn.Text = "1: " + CurrentDeck[tempfill1].Title;
                    Guess2btn.Text = "2: " + CurrentDeck[currentquestion].Title;
                    Guess3btn.Text = "3: " + CurrentDeck[tempfill2].Title;
                    break;
                case 3:
                    Guess1btn.Text = "1: " + CurrentDeck[tempfill1].Title;
                    Guess2btn.Text = "2: " + CurrentDeck[tempfill2].Title;
                    Guess3btn.Text = "3: " + CurrentDeck[currentquestion].Title;
                    break;
            }
            return correctposition;
        }

        
        private void Guess1btn_Click(object sender, EventArgs e)
        {
            if(currentcorrectquestionbutton == 1)
            {
                CorrectAnswer();
            }
            else
            {
                Incorrect();
            }
        }

        private void Guess2btn_Click(object sender, EventArgs e)
        {
            if (currentcorrectquestionbutton == 2)
            {
                CorrectAnswer();
            }
            else
            {
                Incorrect();
            }
        }

        private void Guess3btn_Click(object sender, EventArgs e)
        {
            if (currentcorrectquestionbutton == 3)
            {
                CorrectAnswer();
            }
            else
            {
                Incorrect();
            }
        }
        private void CorrectAnswer()
        {
            Console.WriteLine("Correct");
        }
        private void Incorrect()
        {
            Console.WriteLine("Incorrect");
        }
    }
    
}

