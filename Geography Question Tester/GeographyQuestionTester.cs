using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geography_Question_Tester
{
    internal class GeographyQuestionTester
    {
        public static void StartTester(Student student)
        {
            bool running = true;
            do
            {
                Console.WriteLine("Please enter a topic you would like to do : ");
                string topic = Console.ReadLine();
                if(IsTopic(topic) == true)
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
        
        
    }
}
