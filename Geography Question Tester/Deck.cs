using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    internal class Deck
    {
        private IList<Question> _questions = new List<Question>();
        public int Length { get { return _questions.Count; } }
        public Question GetQuestion() => _questions.FirstOrDefault();        
        public void AddQuestion(Question question) => _questions.Add(question);
        public void RemoveQuestion(Question question) => _questions.Remove(question);
    }
}
