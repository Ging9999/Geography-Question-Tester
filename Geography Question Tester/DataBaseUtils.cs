﻿using System;
using ADOX;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;

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
                + "CardID INT NOT NULL,"
                + "Title VARCHAR(60),"
                + "Answer VARCHAR(60),"
                + "Topic VARCHAR(10),"
                + "PRIMARY KEY(CardID)"
                + ")";
            ExecuteSqlQuery(sSqlString);
        }
        private static void CreateStudentTable()
        {
            string sSqlString;
            sSqlString = "CREATE TABLE Student(StudentID INT NOT NULL, Fname VARCHAR(10), Lname VARCHAR(10), Group VARCHAR(10), PRIMARY KEY(StudentID));";
            ExecuteSqlQuery(sSqlString);
        }
        public static void ExecuteSqlQuery(string sSqlString)
        {
            OleDbConnection connection = new OleDbConnection(_FLASHCARDCONNECTION_STRING);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sSqlString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void GetStudents()
        {
            string sSqlString = "SELECT * FROM Student";
            ExecuteSqlQuery(sSqlString);
        }
    }
}
