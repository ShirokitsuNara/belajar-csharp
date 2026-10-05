using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace loop
{
    class Program
    {
        static void Main()
        {
            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while(i <= 5);
            // int i = 0;
            
            // do
            // {
            //     Console.WriteLine("please deposit five coin");
            //     i++;
            // } while(i <= 10);

            // if (i > 10)
            // {
            //     for (int x = 0; x < 5; x++)
            //     {
            //         Console.WriteLine("please deposit--");
            //     }
            // }

            // for (int i = 0; i <= 2; ++i)
            // {
            //     for (int j = 0; j <= 3; ++j)
            //     {
            //         int k = 0;
            //         do
            //         {
            //             Console.WriteLine(k);
            //             k++;
            //         } while(k < 5);
                    
            //     }
            // }

            // string[] member = {"rusdi", "amba", "siimut"};
            // foreach (string i in member)
            // {
            //     Console.WriteLine(i);
            // }

            int i = 0;
            int j = 0;

            do
            {
                Console.WriteLine($"i: {i}");
                i++;
                Console.WriteLine($"j: {j}");
                j++;
            } while (i <= 5 && j <= 5);
        }
    }
}