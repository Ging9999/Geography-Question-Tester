using ADOX;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    internal class DataBaseUtils
    {
        private const string _FLASHCARDDB = "FlashcardDatabase.mdb";
        private const string _FLASHCARDCONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + _FLASHCARDDB + ";";
        public static void CreateDB()
        {
            try
            {
                if (!File.Exists(_FLASHCARDDB))
                {
                    CatalogClass db = new CatalogClass();
                    db.Create(_FLASHCARDCONNECTION_STRING);
                    CreateStudentTable();
                    CreateTopicTable();
                    AddStudent(1, "Admin", "", "123");
                    DataBaseUtils.AddFlashcard(1, "Volcano", "Large flume of lava", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(2, "Storm", "Large storm", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(3, "eqrthquake", "tectonic plates moving", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(4, "landslip", "the land slipping", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(5, "liquification", "the ground turns into liquid", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(6, "Epicentre", "the epicentre of an earthquake", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(7, "focus", "the focus", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(8, "fatalism", "the idea to give in", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(9, "aid", "giving aid", Topic.NaturalHazards, 2.5);
                    DataBaseUtils.AddFlashcard(10, "HIC", "Higher income country", Topic.NaturalHazards, 2.5);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private static void CreateTopicTable()
        {
            string sSqlString;
            sSqlString = "CREATE TABLE " + "FlashCards" + "("
                + "CardID SHORT NOT NULL,"
                + "Title VARCHAR(60),"
                + "Answer VARCHAR(60),"
                + "Topic VARCHAR(14),"
                + "Difficulty DOUBLE,"
                + "PRIMARY KEY(CardID)"
                + ")";
            ExecuteSqlNonQuery(sSqlString);
        }
        private static void CreateStudentTable()
        {
            string _sSqlString;
            _sSqlString = "CREATE TABLE Student("
                            + "StudentId SHORT NOT NULL,"
                            + "Fname VARCHAR(30),"
                            + "Lname VARCHAR(13),"
                            + "Form VARCHAR(13),"
                            + "PRIMARY KEY(StudentId)"
                            + ")";
            ExecuteSqlNonQuery(_sSqlString);
        }
        public static void ExecuteSqlNonQuery(string sSqlString)
        {
            OleDbConnection connection = new OleDbConnection(_FLASHCARDCONNECTION_STRING);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sSqlString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable ExecuteSqlQuery(String sSqlString)
        {
            DataTable dt = new DataTable();
            OleDbConnection connection = new OleDbConnection(_FLASHCARDCONNECTION_STRING);
            OleDbCommand command = new OleDbCommand(sSqlString, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            try
            {
                connection.Open();
                adapter.Fill(dt);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static void AddFlashcard(int cardID, string Title, string Answer, Topic Topic, double Difficulty)
        {
            string enumTopic = Topic.GetType().ToString();
            string sSqlString;
            sSqlString = "INSERT INTO FlashCards(CardID, Title, Answer, Topic, Difficulty) " +
               "Values(" + cardID + ", '" + Title + "', '" + Answer + "', '" + Topic.ToString() + "', '" + Convert.ToInt32(Difficulty) + "')";
            ExecuteSqlNonQuery(sSqlString);
        }
        public static void AddStudent(int StudentID, string Fname, string Lname, string Form)
        {
            string sSqlString;
            sSqlString = "INSERT INTO Student(StudentID, Fname, Lname, Form) " +
               "Values('" + StudentID + "', '" + Fname + "', '" + Lname + "', '" + Form + "')";
            ExecuteSqlNonQuery(sSqlString);
        }
        public static Flashcard GetFlashcard(int id)
        {
            string sSqlString;
            sSqlString = "SELECT * FROM FlashCards WHERE CardID = " + id + ";";
            DataTable sqldata = ExecuteSqlQuery(sSqlString);
            MyList<Flashcard> flashcards = new MyList<Flashcard>(id);
            foreach (DataRow row in sqldata.Rows)
            {
                string Title = row["Title"].ToString();
                string Answer = row["Answer"].ToString();
                string topic = row["Topic"].ToString();
                Topic _topic = Topic.NA;
                string[] ListOfTopics = Enum.GetNames(typeof(Topic));
                for (int i = 0; i < ListOfTopics.Length; i++)
                {
                    if (ListOfTopics[i] == topic)
                    {
                        Enum.TryParse(topic, out _topic);
                    }
                }
                Flashcard flashcard = new Flashcard(id, Title, Answer, _topic);
                flashcards.Add(flashcard);
            }
            return flashcards[0];
        }
        public static Student GetStudent(int id)
        {
            string sSqlString = "SELECT * FROM Student WHERE StudentID = " + id + ";";
            DataTable sqldata = ExecuteSqlQuery(sSqlString);
            MyList<Student> students = new MyList<Student>();
            foreach (DataRow row in sqldata.Rows)
            {
                string Fname = row["Fname"].ToString();
                string Lname = row["Lname"].ToString();
                string Form = row["Form"].ToString();
                Student student = new Student(Fname, Lname, Form, id);
                students.Add(student);
            }
            return students[0];
        }
        public static int GetNumberofcards()
        {
            string sSqlsting = "SELECT * FROM FlashCards";
            DataTable numberofcardstb = ExecuteSqlQuery(sSqlsting);
            int numberofcards = numberofcardstb.Rows.Count;
            return numberofcards;

        }
        public static void UpdateFlashcardDifficulty(int Id, string attribute, double value)
        {
            string sSqlString = "UPDATE Flashcards SET " + attribute + " = " + value + " WHERE CardID =" + Id.ToString() + ";";
            ExecuteSqlNonQuery(sSqlString);
        }
        public static void UpdateStudent(int StudentId, string attribute, string value)
        {
            string sSqlString = "UPDATE Student SET " + attribute + " = '" + value.ToString() + "' WHERE StudentID =" + StudentId.ToString() + ";";
            ExecuteSqlNonQuery(sSqlString);
        }
        public static Deck GetQuestions(int difficulty, Topic topic)
        {
            string topicstring = topic.ToString();
            string sSqlString = "SELECT * FROM FlashCards WHERE Topic = '" + topicstring + "' AND Difficulty <= " + difficulty.ToString() + " ;";
            DataTable sqldata = ExecuteSqlQuery(sSqlString);
            Deck MyDeck = new Deck(10, MainMenu.CurrentStudent.ID);
            foreach(DataRow row in sqldata.Rows)
            {
                int id = Convert.ToInt32(row["CardID"]);
                string Keyword = row["Title"].ToString();
                string Definition = row["Answer"].ToString();
                string Stopic = row["Topic"].ToString();
                Topic _topic = Topic.NA;
                string[] ListOfTopics = Enum.GetNames(typeof(Topic));
                for (int i = 0; i < ListOfTopics.Length; i++)
                {
                    if (ListOfTopics[i] == Stopic)
                    {
                        Enum.TryParse(Stopic, out _topic);
                    }
                }
                int Difficulty = Convert.ToInt32(row["Difficulty"]);
                Flashcard flashcard = new Flashcard(id, Keyword, Definition, _topic,Difficulty);
                MyDeck.AddQuestion(flashcard);
            }
            return MyDeck;

        }
        
        public static void WriteDecks(MyList<Deck> studentscurrentdecks)
        {
            string fileName = "Decks.txt";
            try
            {
                using (StreamWriter SW = new StreamWriter(fileName))
                {
                    for (int x = 0; x < studentscurrentdecks.Count; x++)
                    {
                        SW.Write(studentscurrentdecks[x].ownerID + " ");
                        for (int y = 0; y < studentscurrentdecks[x].length; y++)
                        {
                            SW.Write(studentscurrentdecks[x][y].ID + " ");
                        }
                        SW.WriteLine("");
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        public static int CreateIDs(string Fname, string Lname)
        {
            int id = (Fname.Length * Lname.Length) + Fname.Length + Lname.Length;
            return id;
        }
        

        public static MyList<Deck> loaddecks(int studentid)
        {
            string filename = "Decks.txt";
            MyList<Deck> listofcurrentdecks = new MyList<Deck>();
            string[] lines = File.ReadAllLines(filename);         
            foreach (string line in lines)
            {
                char assumedid = Convert.ToChar(line[0]);
                int currentline = int.Parse(assumedid.ToString());
                if(currentline == studentid)
                {
                    Deck currentdeck = new Deck(10, studentid);
                    string[] splitstring = line.Split(' ');
                    for(int i = 1; i < splitstring.Length - 1; i++)
                    {
                        Console.WriteLine(splitstring[i]);
                        Flashcard currentflashcard = DataBaseUtils.GetFlashcard(Convert.ToInt32(splitstring[i]));
                        Console.WriteLine(currentflashcard.Answer);
                        currentdeck.AddQuestion(currentflashcard);                        
                    }
                    listofcurrentdecks.Add(currentdeck);
                }
            }
            return listofcurrentdecks;
        }
        
    }


}



