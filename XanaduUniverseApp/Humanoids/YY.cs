using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XanaduUniverseApp
{

    class YY : Humanoid, ISpeakFrench, ICanEat
    {
        public string url;

        public YY(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }

        public void Speak()
        {

            url = "Assets/rick.mp4";
            Console.WriteLine("You wanna haer some french ...Bonjour à tous nous aimons l'humain");
        }
        public void Sing()
        {
            Console.WriteLine("OH sorry we can't sing");
        }
        public void Eat()
        {
            Console.WriteLine("I can eat,,yummy");
        }
        public override void Socialize()
        {
            Console.WriteLine("OH sorry we dont't socialize");
        }
    }
}
