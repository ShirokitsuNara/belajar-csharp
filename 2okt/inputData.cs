using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baik
{
    public class InputData
    {
        static void Main()
        {
            Console.Write("masukan nama: ");
            string nama = Console.ReadLine();

            Console.Write("masukan umur:");
            int umur = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("nama: " + nama);
            Console.WriteLine("umur: " + umur);
            
        }
    }
}