using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    public partial class ReviseTopics : Form
    {
        Deck CurrentDeck = new Deck(10, MainMenu.CurrentStudent.ID);
        string state;
        int Difficulty;
        int currentquestion = 0;
        int currentcorrectquestionbutton;
        Double difficultymodifier;
        public ReviseTopics()
        {
            InitializeComponent();
            this.LoggedIn.Text = "Logged in as : " + MainMenu.CurrentStudent.Fname;
            this.Guess1btn.Hide();
            this.Guess2btn.Hide();
            this.Guess3btn.Hide();
            this.incorrectcorrectlbl.Hide();
            this.NextQuestionBtn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu.BackStack.Pop().Show();
        }

        private void LoggedIn_Click(object sender, EventArgs e)
        {

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
            CurrentDeck = DataBaseUtils.GetQuestions(Difficulty, wantedtopicvalue);
            string DeckName = wantedtopicvalue.GetType().ToString();
            CurrentDeck.deckname = DeckName + "Deck";
            MainMenu.CurrentStudent.currentdecks.Add(CurrentDeck);
            currentquestion = 0;
            LearnDeck();
        }
        private void LearnDeck()
        {
            Guess1btn.Show();
            Guess2btn.Show();
            Guess3btn.Show();
            if (state == "Keyword")
            {
                currentcorrectquestionbutton = LearnKeyword(); //implement checking asnwer
            }
            if (state == "Definition")
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
            Flashcardtermordefinition.Show();
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
            if (currentcorrectquestionbutton == 1)
            {
                CorrectAnswer();
            }
            else
            {
                Incorrect();
                Console.WriteLine(Guess1btn.Text);

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
                Console.WriteLine(Guess2btn.Text);
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
                Console.WriteLine(Guess3btn.Text);
            }
        }
        private void CorrectAnswer()
        {
            incorrectcorrectlbl.Show();
            Console.WriteLine("Correct");
            if (difficultymodifier == 0)
            {
                difficultymodifier = difficultymodifier - 0.1;
            }
            incorrectcorrectlbl.ForeColor = Color.Green;
            incorrectcorrectlbl.Text = "Correct";
            DataBaseUtils.UpdateFlashcardDifficulty(CurrentDeck[currentquestion].ID, "Difficulty", CurrentDeck[currentquestion].Difficulty + difficultymodifier);
            Console.WriteLine("Updated Attribute : Difficulty");
            if (currentquestion < CurrentDeck.length - 1)
            {
                currentquestion++;
                NextQuestionBtn.Show();
            }
            else
            {
                finishedlbl.AutoSize = false;
                finishedlbl.ForeColor = Color.Green;
                finishedlbl.Show();
                finishedlbl.Text = "Finished Deck create new one";
                Flashcardtermordefinition.Hide();
                Guess1btn.Hide();
                Guess2btn.Hide();
                Guess3btn.Hide();
                NextQuestionBtn.Hide();
                incorrectcorrectlbl.Hide();
            }

        }
        private void Incorrect()
        {
            incorrectcorrectlbl.Show();
            Console.WriteLine("Incorrect");
            difficultymodifier = difficultymodifier - 0.2;
            incorrectcorrectlbl.ForeColor = Color.Red;
            incorrectcorrectlbl.Text = "Incorrect";
        }

        private void NextQuestionBtn_Click(object sender, EventArgs e)
        {
            LearnDeck();
            NextQuestionBtn.Hide();
            incorrectcorrectlbl.Hide();
        }

        private void KeywordBtn_Click(object sender, EventArgs e)
        {
            state = "Keyword";
        }

        private void LearnDefinitionBtn_Click(object sender, EventArgs e)
        {
            state = "Definition";
        }
    }

}

