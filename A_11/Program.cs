using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź ciąg znaków i naciśnij enter.");
            string abc = Console.ReadLine();
            Console.WriteLine(abc.ToLower());
            Console.ReadKey();
        }
    }
}
