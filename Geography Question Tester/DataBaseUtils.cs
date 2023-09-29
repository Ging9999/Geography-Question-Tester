using System;
using ADOX;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlTypes;

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
            catch(Exception ex)
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
            ExecuteSqlQuery(sSqlString);
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
            ExecuteSqlQuery(_sSqlString);
        }
        public static void ExecuteSqlQuery(string sSqlString)
        {
            OleDbConnection connection = new OleDbConnection(_FLASHCARDCONNECTION_STRING);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sSqlString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void AddFlashCard(int cardID, string Title, string Answer, Topic Topic)
        {
            string sSqlString;
            sSqlString = "INSERT INTO FlashCards(CardID, Title, Answer, Topic) " +
               "Values('" + cardID + "', '" + Title + "', '" + Answer + "', '" + Topic + "')";
            ExecuteSqlQuery(sSqlString);
        }
        public static void AddStudent(int StudentID, string Fname, string Lname, string Form)
        {
            string sSqlString;
            sSqlString = "INSERT INTO Student(StudentID, Fname, Lname, Form) " +
               "Values('" + StudentID + "', '" + Fname + "', '" + Lname + "', '" + Form + "')";
            ExecuteSqlQuery(sSqlString);
        }


    }
}
