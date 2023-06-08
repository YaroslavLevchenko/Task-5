using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Programmer:IDeveloper, IComparable<IDeveloper>
    {
        string language;

        public Programmer(string progLanguage) => Tool = progLanguage;
        public string Tool
        {
            get => language;
            set => language = value;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
        public void Info()
        {
            Console.WriteLine("Developer is using: " + $"{Tool}");
        }


    }
}
