﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    public partial class Deck
    {
        public int size;
        public string deckname { get; set; }
        public int ownerID { get;  private set; }
        public Deck(int Size, int OwnerID)
        {
            size = Size;
            ownerID = OwnerID;
        }
        
        private MyQueue<Flashcard> _questions = new MyQueue<Flashcard>(); // change to queue
        
        public int length { get { return _questions.Count; } }
        public Flashcard GetQuestion() => _questions[0];    
        public void AddQuestion(Flashcard question) => _questions.Add(question);
        public void RemoveQuestion(Flashcard question) => _questions.Remove(question);
        public Flashcard this[int index]
        {
            get
            {
                if (index > size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _questions[index];
            }
        }
    }
    public enum State
    {
        Keyword,
        Definition,
        Unassigned
    }
}
