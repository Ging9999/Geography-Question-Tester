﻿using System;
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
        public string Title { get; private set; }
        public string Answer { get; private set; }
        public Topic Topic { get; private set; }

        public Question(string question, string answer, Topic topic)
        {
            Title = question;   
            Answer = answer;
            Topic = topic;
        }       
        
    }
    
}
