using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    public class Student
    {
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string Form { get; private set; }
        public int ID { get; private set; }

        //public IList<Deck> currentDecks = new List<Deck>(); // temp change 
        public Student(string fname, string lname, string group, int id)
        {
            Fname = fname;
            Lname = lname;
            Form = group;
            ID = id;          
        }       
    }
}
