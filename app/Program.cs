using System;
using omopcdmlib;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new Start();
        
            Console.WriteLine(string.Format("Hello World! {0}", start.Add(2, 2)));
        }
    }
}
