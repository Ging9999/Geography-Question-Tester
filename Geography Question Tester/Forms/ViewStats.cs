using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Question_Tester.Forms
{
    public partial class ViewStats : Form
    {
        public ViewStats()
        {
            InitializeComponent();
            Loggedinas.Text = "Logged in as : " + MainMenu.CurrentStudent.Fname;
            StudentStatsBox.Text = MainMenu.CurrentStudent.Fname + " Statistics";
            LoadStats();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginMenu.BackStack.Pop().Show();
            this.Hide();
        }

        private void LoadStats()
        {
            double test = GetAverage();
            double test2 = GetTopic("NaturalHazards");
            Console.WriteLine(test);
            Console.WriteLine(test2);

        }
        public double GetAverage()
        {
            double sumofdiffculty = 0;
            string sSqlstring = "SELECT * FROM FlashCards";
            DataTable dt = DataBaseUtils.ExecuteSqlQuery(sSqlstring);
            foreach (DataRow row in dt.Rows)
            {
                string snum = row["Difficulty"].ToString();
                sumofdiffculty += Convert.ToDouble(snum);
            }
            return sumofdiffculty / dt.Rows.Count;
        }
        public double GetTopic(string topic)
        {
            double sumofdifficulty = 0;
            string sSqlstring = "SELECT * FROM FlashCards WHERE Topic = '" + topic + "'";
            DataTable dt = DataBaseUtils.ExecuteSqlQuery(sSqlstring);
            foreach (DataRow row in dt.Rows)
            {
                string snum = row["Difficulty"].ToString();
                sumofdifficulty += Convert.ToDouble(snum);
            }
            return sumofdifficulty / dt.Rows.Count;
        }
    }
}
