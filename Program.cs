using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5.Task_2;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            List<IDeveloper> list = new List<IDeveloper>();
            list.Add(new Builder("Knife"));
            list.Add(new Builder("Saw"));
            list.Add(new Programmer("C#"));
            list.Add(new Programmer("C++"));
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Info();
            }
             list.Sort();
            list.ForEach(l => Console.WriteLine(l.Tool));

            //Task-2
            Person person = new Person();
            person.FillingData();
            person.FindUserById();

            Console.ReadKey();
        }
    }
}
