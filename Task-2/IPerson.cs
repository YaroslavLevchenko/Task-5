using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Task_2
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        void FillingData();
        void FindUserById();
    }
}
