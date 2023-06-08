using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Builder:IDeveloper, IComparable<IDeveloper>
    {
        string tool;

        public Builder(string toolName) => Tool = toolName;
        public string Tool
        {
            get => tool;
            set => tool = value;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
        public void Info()
        {
            Console.WriteLine("Builder is using: " + $"{Tool}");
        }
    }
}
