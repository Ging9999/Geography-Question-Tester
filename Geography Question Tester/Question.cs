using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    public enum Topic
    {
        ChangingPlaces,
        NaturalHazards,
        HotDeserts,
        WaterCarbon
    }

   
    internal class Question
    {
        public int Difficulty { get; set; } 
        public int Marks { get; private set; }
        public string Title { get; private set; }
        public string Answer { get; private set; }
        public Topic Topic { get; private set; }

        public Question(int marks, string question, string answer, Topic topic)
        {
            Marks = marks;
            Title = question;   
            Answer = answer;
            Topic = topic;
        }       
    }
    
}
