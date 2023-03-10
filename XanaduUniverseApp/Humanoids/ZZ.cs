using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using XanaduUniverseApp;

namespace XanaduUniverseApp
{
    class ZZ : Humanoid, ISpeakFrench, ICanDance
    {
        public string url;

        public ZZ(string myName, string myAncestorName) : base(myName, myAncestorName)
        {
        }
        public void Speak()
        {
            url = "Assets/broken/broken_french.wav";
        }
        public void Sing()
        {
            url = "Assets/broken/broken_sing.mp3";

        }
        public virtual void Dance()
        {
            url = "Assets/dance.mp4";
        }
        public override void Socialize()
        {
            url = "Assets/broken/broken_socialize.wav";
        }
    }


}
