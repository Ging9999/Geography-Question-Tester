using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Geography_Question_Tester
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            /*IList<Student> CurrentStudents = new List<Student>();         
            if (CurrentStudents.Count == 0)
            {
                Student student = CreateStudent(CurrentStudents);
                CurrentStudents.Add(student);
            }
            else
            {
                
            }
            switch (MainMenu())
            {
                case 1:
                    {
                        GeographyQuestionTester geographyQuestionTester = new GeographyQuestionTester();
                        geographyQuestionTester.StartTester();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
            }
            */
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList[3]);
            
            Console.ReadLine();




        }
        /*public static int MainMenu()
        {
            /*Console.WriteLine("Please enter what you would like to do : ");
            Console.WriteLine("1. Question Tester");
            Console.WriteLine("2. Flash Cards");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
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
            */
    }
}
