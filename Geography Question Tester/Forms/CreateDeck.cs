using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester.Forms
{
    public partial class CreateDeck : Form
    {
        private const string _FLASHCARDDB = "FlashcardDatabase.mdb";
        private const string _FLASHCARDCONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + _FLASHCARDDB + ";";
        private MyList<Flashcard> WantedDeckIds = new MyList<Flashcard>();
        
        public CreateDeck()
        {
            InitializeComponent();
            loaddatagrid();
        }

        
        private void loaddatagrid()
        {
            string query = "SELECT * From FlashCards";
            using (OleDbConnection conn = new OleDbConnection(_FLASHCARDCONNECTION_STRING))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            Flashcard tempcard = DataBaseUtils.GetFlashcard(id);
            WantedDeckIds.Add(tempcard);
            MessageBox.Show("Added", "done", MessageBoxButtons.OK);
        }

        private void CrtDeckBtn_Click(object sender, EventArgs e)
        {
            if(nameOfdeck.Text != null)
            {
                MainMenu.CurrentStudent.currentdecks.Add(WantedDeckIds);
                // make the list into a deck

            }
        }
    }
}
