using System;
using System.Collections.Generic;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = LinqTasks.Task1();
            TestIe(LinqTasks.Task11());

        }

         static void TestIe(IEnumerable<object> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
