﻿using ADOX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Text;
using System.IO;
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
                + "PRIMARY KEY(CardID)"
                + ")";
            ExecuteSqlNonQuery(sSqlString);
        }
        private static void CreateStudentTable()
        {
            string _sSqlString;
            _sSqlString = "CREATE TABLE Student("
                            + "StudentId SHORT NOT NULL,"
                            + "Fname CHAR(30),"
                            + "Lname CHAR(13),"
                            + "Form CHAR(13),"
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
        public static void AddFlashcard(int cardID, string Title, string Answer, Topic Topic)
        {
            string enumTopic = Topic.GetType().ToString();
            string sSqlString;
            sSqlString = "INSERT INTO FlashCards(CardID, Title, Answer, Topic) " +
               "Values(" + cardID + ", '" + Title + "', '" + Answer + "', '" + Topic.ToString() + "')";
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
        public static void UpdateFlashcard(int Id, string attribute, string value)
        {
            string sSqlString = "UPDATE Flashcards SET " + attribute + " = '" + value.ToString() + "' WHERE CardID =" + Id.ToString() + ";";
            ExecuteSqlNonQuery(sSqlString);
        }
        public static void UpdateStudent(int StudentId, string attribute, string value)
        {
            string sSqlString = "UPDATE Student SET " + attribute + " = '" + value.ToString() + "' WHERE StudentID =" + StudentId.ToString() + ";";
            ExecuteSqlNonQuery(sSqlString);
        }
        private MyList<Deck> LoadDecks(MyList<int[]> ListOfcardID, int[] owners)
        {
            MyList<Deck> ListOfDecks = new MyList<Deck>(ListOfcardID.Count);
            for (int y = 0; y < ListOfDecks.Count; y++)
            {
                Deck currentdeck = new Deck(ListOfcardID[y].Length,owners[y]);
                for (int x = 0; x < ListOfcardID[y].Length; x++)
                {
                    Flashcard currentflashcard = GetFlashcard(ListOfcardID[y][x]);
                    currentdeck.AddQuestion(currentflashcard);
                }
                ListOfDecks.Add(currentdeck);
            }
            return ListOfDecks;
        }
        public static void SaveDecks(MyList<Deck> listofdecks)
        {
            string fileName = "Decks.txt";
            try
            {
                using (StreamWriter SR = new StreamWriter(fileName))
                {
                    for (int x = 0; x < listofdecks.Count; x++)
                    {
                        SR.Write(listofdecks[x].ownerID + " ");
                        for(int y = 0; y < listofdecks[x].length; y++)
                        {
                            for(int x = 0; y < listofdecks[x])
                        }
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

            


     }


}
    //load decks - create function which writes owner of deck then the ids of the flashcards


