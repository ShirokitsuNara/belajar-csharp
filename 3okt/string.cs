using System;

namespace StringLearn
{
    class Strings
    {
        public static void Main()
        {
            string Fn = "nara";
            string Ln = "nabil";

            string name = string.Concat(Fn, Ln);
            Console.WriteLine(name);
        }
    }
}