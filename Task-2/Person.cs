using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Task_2
{
    public class Person:IPerson
    {
        int id;
        string name;
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public void FillingData()
        {
            Console.WriteLine("Please, type ID and Name 7 times");
            for(int i = 0; i< 7; i++)
            {
                Id = int.Parse(Console.ReadLine());
                Name = Console.ReadLine();
                myDictionary.Add(Id, Name);
            }
        }

        public void FindUserById()
        {
            Console.WriteLine("Type the relevant ID to find the person: ");
            int inputID = int.Parse(Console.ReadLine());
            var value = myDictionary.FirstOrDefault(x => x.Key == inputID);
            if (value.Value != null) Console.WriteLine("The name is: " + $"{value.Value}");
            else Console.WriteLine("User doesn't exist");
        }
    }
}
