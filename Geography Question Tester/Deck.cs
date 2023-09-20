using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    class Deck
    {
        private MyList<Question> _questions = new MyList<Question>();
        public int Length { get { return _questions.Count; } }
        public Question GetQuestion() => _questions[0];    
        public void AddQuestion(Question question) => _questions.Add(question);
        public void RemoveQuestion(Question question) => _questions.Remove(question);
    }
}
