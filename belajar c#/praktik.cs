using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baik
{
    public class praktik
    {
        static void Main()
        {
            Console.Write("masukan angka x ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukan angka y ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. penjumlahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");

            Console.WriteLine("pilih operasi: ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                int hasil = x + y;
                Console.WriteLine(x + " ditambah " + y + " sama dengan " + hasil);
            }
            else if (pilih == 2)
            {
                int hasil = x - y;
                Console.WriteLine(x + " dikurangi " + y + " sama dengan " + hasil);

            }
            else if (pilih == 3)
            {
                int hasil = x * y;
                Console.WriteLine(x + " dikali " + y + " sama dengan " + hasil);
            }
            else if (pilih == 4)
            {
                int hasil = x / y;
                Console.WriteLine(x + " dibagi " + y + " sama dengan " + hasil);
            }
            else
            {
                Console.WriteLine("input salah sayang");
            }

        }
    }
}