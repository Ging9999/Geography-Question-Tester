using System;
using ADOX;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Geography_Question_Tester
{
    internal class DataBaseUtils
    {
        private const string _FLASHCARDDB = "FlashcardDatabase.mdb";
        private const string _FLASHCARDCONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + _FLASHCARDDB + ";";
        public static void CreateDB()
        {
            if (!File.Exists(_FLASHCARDDB))
            {
                CatalogClass db = new CatalogClass();
                db.Create(_FLASHCARDCONNECTION_STRING);
                string[] topics = { "ChangingPlaces", "NaturalHazards", "HotDeserts", "WaterCarbon" };
                foreach(string topic in topics)
                {
                    CreateTable(topic);
                }
            }
        }
        private static void CreateTable(string title)
        {
            string sSqlString;
            sSqlString = "CREATE TABLE " + title + "("
                + "CardID INT NOT NULL,"
                + "Title VARCHAR(60),"
                + "Answer VARCHAR(60),"
                + "Topic VARCHAR(10),"
                + "PRIMARY KEY(CardID)"
                + ")";
            ExecureSqlQuery(sSqlString);
        }
        public static void ExecureSqlQuery(string sSqlString)
        {
            OleDbConnection connection = new OleDbConnection(_FLASHCARDCONNECTION_STRING);
            connection.Open();
            OleDbCommand command = new OleDbCommand(sSqlString, connection);
            connection.Close();
        }
    }
}
