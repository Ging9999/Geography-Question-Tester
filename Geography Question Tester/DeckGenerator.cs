using Geography_Question_Tester.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class DeckGenerator
    {
        public MyList<Deck> easymediumhard = new MyList<Deck>();
        private int shift = 0;
        
        public DeckGenerator()
        {
            for(int i = 0; i < 4; i++)
            {
                Deck deck = new Deck(10, MainMenu.CurrentStudent.ID);
                easymediumhard.Add(deck);
            }
            string sSqlstring = "SELECT CardId FROM FlashCards";
            DataTable dt = DataBaseUtils.ExecuteSqlQuery(sSqlstring);
            for(int x = 0; x < 10; x++)
            {
                Random rnd = new Random();
                Flashcard flashcard = DataBaseUtils.GetFlashcard(rnd.Next(dt.Columns.Count));
                easymediumhard[0].AddQuestion(flashcard);
            }
        }
        public void easy(Flashcard flashcard)
        {
            try
            {
                easymediumhard[3 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID - 0.1);
            }
            catch
            {
                Deck deck = new Deck(10, MainMenu.CurrentStudent.ID);
                easymediumhard.Insert(3, deck);
                shift++;
                easymediumhard[3 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID - 0.1);
            }
        }
        public void medium(Flashcard flashcard)
        {
            try
            {
                easymediumhard[2 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID + 0.1);
            }
            catch
            {
                Deck deck = new Deck(10, MainMenu.CurrentStudent.ID);
                easymediumhard.Insert(3, deck);
                shift++;
                easymediumhard[2 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID + 0.1);
            }
        }
        public void hard(Flashcard flashcard)
        {
            try
            {
                easymediumhard[1 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID + 0.2);
            }
            catch
            {
                Deck deck = new Deck(10, MainMenu.CurrentStudent.ID);
                easymediumhard.Insert(3, deck);
                shift++;
                easymediumhard[1 + shift].AddQuestion(flashcard);
                DataBaseUtils.UpdateFlashcardDifficulty(flashcard.ID, "Difficulty", flashcard.ID + 0.2);
            }
        }
        private void finished()
        {
            for(int i =0; i < easymediumhard.Count; i++)
            {
                if (easymediumhard[i].length == 10)
                {
                    MainMenu.CurrentStudent.currentdecks.Add(easymediumhard[i]);
                }
            }
        }
        
        // create an alorithm in which creates decks based of how you awnser them, how many times its been done. sm-2
        // create a stats viewer to show the current stats of a person - compare against people standard deviation etc

    }
}
