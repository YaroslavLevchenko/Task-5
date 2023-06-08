using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        void Info();
        string Tool { get; set; }
    }
}
