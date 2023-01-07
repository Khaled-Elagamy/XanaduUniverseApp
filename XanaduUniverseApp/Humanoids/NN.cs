using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XanaduUniverseApp
{
    class NN : ZZ, ICodeCSharp
    {
        public NN(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }
       
        public void WriteCode() 
        {
            Console.WriteLine("Get away its compiling");
        }
        public override void Socialize() 
        { 
            Sing();
        }
    }
}

