using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VAC
{
    public static class ConsoleHelper
    {
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Clear()
        {
            Thread.Sleep(250);
            Console.Clear();
        }

        public static void Dedected(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Title(string Title)
        {
            Console.Title = Title;
        }

        public static void BadTitle(string Title, string CurrentTime)
        {
            Console.Title = Title + " - " + CurrentTime;
        }

        public static bool DisplayCheckResult(string process, string status)
        {
            Console.WriteLine(process + "..." + status);

            return false;
        }
    }
}
