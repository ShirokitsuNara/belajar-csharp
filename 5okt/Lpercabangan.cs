using System;

namespace latihanPercabangan
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("--SELAMAT DATANG DI PENGHITUNG NILAI--");
                Console.WriteLine("1. hitung total nilai");
                Console.WriteLine("2. hitung rata-rata nilai");
                Console.WriteLine("3. hitung grade total nilai");
                Console.WriteLine("4. keluar");
                int pilih = Convert.ToInt16(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.Write("masukan nilai mtk: ");
                    int x = Convert.ToInt16(Console.ReadLine());

                    Console.Write("masukan nilai b.indo: ");
                    int y = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai b.inggris: ");
                    int z = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai ipa: ");
                    int n = Convert.ToInt16(Console.ReadLine());

                    int total = x + y + z + n;
                    Console.WriteLine($"nilai total: {total}");
                    Console.ReadLine();
                }
                else if (pilih == 2)
                {
                    Console.Write("masukan nilai mtk: ");
                    int x = Convert.ToInt16(Console.ReadLine());

                    Console.Write("masukan nilai b.indo: ");
                    int y = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai b.inggris: ");
                    int z = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai ipa: ");
                    int n = Convert.ToInt16(Console.ReadLine());

                    int total1 = x + y + z + n;
                    int total2 = total1 / 4;

                    Console.WriteLine($"Nilai rata-rata: {total2}");
                    Console.ReadLine();
                }
                else if (pilih == 3)
                {
                    Console.Write("masukan nilai mtk: ");
                    int x = Convert.ToInt16(Console.ReadLine());

                    Console.Write("masukan nilai b.indo: ");
                    int y = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai b.inggris: ");
                    int z = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("masukan nilai ipa: ");
                    int n = Convert.ToInt16(Console.ReadLine());

                    int total1 = x + y + z + n;
                    int total2 = total1 / 4;

                    if (total2 < 60)
                    {
                        Console.WriteLine($"nilai rata-ratamu: {total2}, grademu: D");
                    }
                    else if (total2 < 80)
                    {
                        Console.WriteLine($"nilai rata-ratamu: {total2}, grademu: C");
                    }
                    else if (total2 < 90)
                    {
                        Console.WriteLine($"nilai rata-ratamu: {total2}, grademu: B");
                    }
                    else if (total2 <= 100)
                    {
                        Console.WriteLine($"nilai rata-ratamu: {total2}, grademu: A");
                    }
                    Console.ReadLine();
                }
                else if (pilih == 4)
                {
                    break;
                }
            }
        }
    }
}