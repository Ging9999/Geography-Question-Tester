using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System;
using System.Windows.Forms;

namespace Geography_Question_Tester
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            DataBaseUtils.CreateDB();
            Application.Run(new MainMenu());       
        }
        public static void TopicChooser(Student student)
        {
            bool running = true;
            do
            {
                Console.WriteLine("Please enter a topic you would like to do : ");
                string topic = Console.ReadLine();
                if (IsTopic(topic) == true)
                {

                }
                else
                {
                    Console.WriteLine("Please enter a valid topic");
                }

            }
            while (!running);
        }
        private static bool IsTopic(string SomeTopic)
        {
            string[] ListOfTopics = Enum.GetNames(typeof(Topic));
            if (ListOfTopics.Contains(SomeTopic))
            {
                return true;
            }
            return false;
        }

        public static Student Login(IList<Student> CurrentStudents)
        {
            Console.WriteLine("Please enter your First Name");
            string Fname = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name");
            string Lname = Console.ReadLine();
            for(int i = 0; i < CurrentStudents.Count; i++)
            {
                if (CurrentStudents[i].Fname == Fname && CurrentStudents[i].Lname == Lname)
                {
                    return CurrentStudents[i];
                }
            }
            return null;         
        }

        public static Student CreateStudent(IList<Student> CurrentStudents)
        {            
            Console.WriteLine("Please enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Please enter your class");
            string group = Console.ReadLine();
            int id = CurrentStudents.Count;
            Student student = new Student(fname, lname, group, id);   
            return student;
        }
            
    }
}
