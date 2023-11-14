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
            Application.Run(new LoginMenu());

        }
        
        
            
    }
}
