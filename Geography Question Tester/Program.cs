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
using System.Net.Http.Headers;

namespace Geography_Question_Tester
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            DataBaseUtils.CreateDB();
            DataBaseUtils.AddFlashcard(1, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            DataBaseUtils.AddFlashcard(2, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            DataBaseUtils.AddFlashcard(3, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            DataBaseUtils.AddFlashcard(4, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            DataBaseUtils.AddFlashcard(5, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            DataBaseUtils.AddFlashcard(6, "Volcano", "Large flume of lava", Topic.NaturalHazards, 1);
            Application.Run(new LoginMenu());

        }
        
        
            
    }
}
