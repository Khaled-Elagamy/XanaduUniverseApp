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
            url = "Assets/snore.mp3";
        }
        public override void Socialize()
        {
            base.Socialize();
        }
    }
    
    
}
