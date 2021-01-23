using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamp4gun
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, int> dictonary = new MyDictonary<string, int>();

            dictonary.Add("Ceren", 1);
            dictonary.Add("Esra", 2);
            dictonary.Add("Melike",3);
            Console.WriteLine(dictonary.Count);
            Console.ReadKey();
        }
    }
}
