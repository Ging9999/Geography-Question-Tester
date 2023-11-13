using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    public partial class ReviseTopics : Form
    {
        Deck CurrentDeck = new Deck(10, MainMenu.CurrentStudent.ID);
        State state = State.Unassigned;
        int Difficulty;
        public ReviseTopics()
        {
            InitializeComponent();
            this.LoggedIn.Text = "Logged in as : " + MainMenu.CurrentStudent.Fname;
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
            Topic tempTopic = Topic.NA;
            string wantedtopicvalue = SelectTopicBox.SelectedItem.ToString();
            switch (wantedtopicvalue)
            {
                case ("Changing Places"):
                    tempTopic = Topic.ChangingPlaces;
                    break;
                case ("Water and Carbon"):
                    tempTopic = Topic.WaterCarbon;
                    break;
                case ("Hazards"):
                    tempTopic = Topic.NaturalHazards;
                    break;
                case ("Hot Deserts"):
                    tempTopic = Topic.HotDeserts;
                    break;
            }
            
            CurrentDeck = DataBaseUtils.GetQuestions(Difficulty, tempTopic);
        }
    }
}
