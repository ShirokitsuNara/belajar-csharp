using System;

class Program
{
    static void Main()
    {
        Console.Write("masukan nama: ");
        string nama = Console.ReadLine();

        Console.Write("masukan umur: ");
        string umur = Console.ReadLine();
        int usia = Convert.ToInt32(umur);

        Console.WriteLine($"nama: {nama}");
        Console.WriteLine($"usia: {usia}");

    }
}