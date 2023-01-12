using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XanaduUniverseApp
{
   
    public interface ISpeakFrench
    {
        void Speak();
        void Sing();
    }
    public interface ICanEat
    {
        void Eat();
    }
    public interface ICanDance
    {
        void Dance();
    }
    interface ISnore
    {
        void Snore();
    }
    interface ICodeCSharp
    {
        void WriteCode();
    }
    abstract class Humanoid
    {
       private string Name;
       private string Ancestor;
        public Humanoid(string myName, string myAncestorName)
        {
            this.Name = myName;
            this.Ancestor = myAncestorName;
        }
        public abstract void Socialize();
    }

}
