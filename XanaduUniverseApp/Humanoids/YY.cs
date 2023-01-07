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
            url = "Assets/elves_french.wav";
        }
        public void Sing()
        {
            url = "Assets/elves_sing.wav";
        }
        public void Eat()
        {
            url = "Assets/eating.mp4";
        }
        public override void Socialize()
        {
            url = "Assets/elves_socialize.wav";
        }
    }
}
