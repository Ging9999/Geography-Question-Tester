﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    internal class Student
    {
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string Group { get; private set; }
        public int ID { get; private set; }

        public IList<Deck> _currentDecks = new List<Deck>(); // temp change 
        public Student(string fname, string lname, string group, int id)
        {
            Fname = fname;
            Lname = lname;
            Group = group;
            ID = id;          
        }       
    }
}
