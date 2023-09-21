using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class Deck
    {
        private MyList<Flashcard> _questions = new MyList<Flashcard>();
        public int Length { get { return _questions.Count; } }
        public Flashcard GetQuestion() => _questions[0];    
        public void AddQuestion(Flashcard question) => _questions.Add(question);
        public void RemoveQuestion(Flashcard question) => _questions.Remove(question);
    }
}
