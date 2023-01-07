using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XanaduUniverseApp
{
    class DD : NN, ISnore 
    {
        public DD(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }
        public void Snore() 
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZ");
        }
        public override void Socialize()
        {
            base.Socialize();
        }
    }
    
    
}
