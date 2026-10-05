using System;

namespace latihan
{
    class Program
    {
        static void Main()
        {
            Console.Write("---Masukan Biodata---");
            Console.ReadLine();

            Console.Write("Masukan Nama: ");
            string nama = Console.ReadLine(); //ini praktek input

            Console.Write("Masukan absen: ");
            int absen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Kelas: ");
            string kelas = Console.ReadLine();

            // disini, mulai maksa keluar semua pembelajaran
            Console.WriteLine($"selamat datang {nama} ({absen}) dari kelas {kelas}"); //interpolation strings

            Console.WriteLine("---rincian---");
            int jmlhhrf = nama.Length;
            char Fchar = nama[0];
            int inis = nama.IndexOf(Fchar);
            string Fn = nama.Substring(inis);
            
            Console.WriteLine(Fn);
            string[] pernama = nama.Split(" ");
            // aku nyerah deh bagian ini, intinya udah selesai disini.

        }
    }
}