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
        WaterCarbon,
        NA
    }

   
    public partial class Flashcard
    {
        public int ID { get; set; }
        public double Difficulty { get; set; } 
        public string Title { get; private set; }
        public string Answer { get; private set; }
        public Topic Topic { get; private set; }

        public Flashcard(int Id, string question, string answer, Topic topic)
        {
            ID = Id;
            Title = question;   
            Answer = answer;
            Topic = topic;

        }       
        public Flashcard(int Id, string question, string answer, Topic topic, double difficulty)
        {
            ID = Id;
            Title = question;
            Answer = answer;
            Topic = topic;
            Difficulty = difficulty;
        }
        
        
       
    }
   
}
