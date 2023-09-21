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

namespace Geography_Question_Tester
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            bool running = true;
            while(running == true)
            {
                switch (MainMenu())
                {
                    case 1:
                        {
                            
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            running = false;
                            break;
                        }
                }
            }                
        }
        public static int MainMenu()
        {
            Console.WriteLine("Please enter what you would like to do : ");
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
            
    }
}
