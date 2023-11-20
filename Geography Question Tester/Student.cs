namespace Geography_Question_Tester
{
    class Student
    {
        public MyList<Deck> currentdecks = new MyList<Deck>();
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
