using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add("Foo");
            myList.Add("Bar");
            myList.Add("Foo2");
            myList.Add("Bar2");
            Console.WriteLine("Capacity: {0}", myList.Count);
            Console.WriteLine(myList[3]);

            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "Bob");
            employees.Add(2, "Connor");
            employees.Add(3, "Jane");
            employees.Add(4, "Marley");
            employees.Add(5, "Shannon");

            foreach(object i in employees) {
                Console.WriteLine(i);
            }
        }
    }
}
