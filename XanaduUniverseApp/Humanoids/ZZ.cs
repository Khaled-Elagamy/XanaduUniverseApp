using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XanaduUniverseApp;

namespace XanaduUniverseApp
{
    class ZZ : Humanoid, ISpeakFrench, ICanDance
    {
        public ZZ(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }
        public void Speak()
        {
            Console.WriteLine("We cant speak French");

        }
        public void Sing()
        {
            Console.WriteLine("hohoho");

        }
        public void Dance()
        {
            Console.WriteLine("We are dancing");

        }
        public override void Socialize()
        {
            Dance();
            Sing();
        }
    }


}
