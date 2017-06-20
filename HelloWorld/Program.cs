using CsvHelper.Configuration;
using System;

namespace HelloWorld
{
    class Program
    {
        private static CsvConfiguration config;

        static void Main(string[] args)
        {
            config = new CsvConfiguration();

            config.Delimiter = "||";
            config.HasHeaderRecord = true;
            config.WillThrowOnMissingField = false;
            config.IsHeaderCaseSensitive = false;
            config.TrimFields = false;
            config.AllowComments = false;

            Console.WriteLine("Hello World " + getString() + ".");
            Console.WriteLine(DisplayDateTime());
            Console.WriteLine(DisplayJustDate());
            Console.ReadLine();
        }

        private static string getString()
        {
            int versionNum = 7;
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
