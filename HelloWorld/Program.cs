using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Dev Branch Test.");
            Console.WriteLine(DisplayDateTime());
            Console.WriteLine(DisplayJustDate());
            Console.ReadLine();
        }

        private static string getString()
        {
            return "New string";
        }

        static string DisplayDateTime()
        {
            return DateTime.UtcNow.ToString();
        }

        static string DisplayJustDate()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
