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
            Console.WriteLine("Hello World " + getString() + ".");
            Console.WriteLine(DisplayDateTime());
            Console.WriteLine(DisplayJustDate());
            Console.ReadLine();
        }

        private static string getString()
        {
            int versionNum = 6;
            return "Bug branch version " + versionNum;
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
