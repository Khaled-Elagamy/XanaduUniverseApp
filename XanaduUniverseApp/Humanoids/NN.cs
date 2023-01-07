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
            url = "Assets/code.mp4";
        }
        public override void Socialize() 
        {
            url = "Assets/gnoll/Gnoll_Socialize.mp3";
        }
    }
}

