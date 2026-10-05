using System;

namespace IfElse
{
    class Program
    {
        static void Main()
        {
            int x = 80;

            string remidi = (x > 70) ? "lulus" : "remidi";
            Console.WriteLine(remidi);

            if (x < 60 )
            {
                Console.WriteLine("D");
            }
            else if (x < 80 )
            {
                Console.WriteLine("C");
            }
            else if (x < 90 )
            {
                Console.WriteLine("B");
            }
            else if (x < 95 )
            {
                Console.WriteLine("A");
            }
        }
    }
}