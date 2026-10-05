using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace castingData
{
    class CastingData
    {
        static void Main()
        {
            float angka1 = 10.99f;
            int angka2 = (int) angka1;
            string angka3;
            angka3 = Convert.ToString(angka2);

            Console.WriteLine(angka2);
            Console.WriteLine(angka3);

            string tulis = Console.ReadLine();
            bool ngecek = int.TryParse(tulis, out int hasil);

            if (ngecek)
            {
                Console.Write(hasil);
            }
            else
            {
                Console.Write("anjay");
            }
        }
    }
}