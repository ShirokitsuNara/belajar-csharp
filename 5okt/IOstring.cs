using System;
using System.ComponentModel;

namespace Anjay
{
    class Program
    {
    static void Main() 
        {
        string nama = "Amba Tukam";
        
        int jmlhhrf = nama.Length;
        Console.WriteLine($"jumlah huruf: {jmlhhrf}");

        int charPos = nama.IndexOf("T");

        string Ln = nama.Substring(charPos);

        Console.WriteLine($"last name: {Ln}");

        bool amba = nama.Contains("Amba");
        Console.WriteLine($"ambatukam is {amba}");

        string namabaru = nama.Replace("Amba", "Reza");
        Console.WriteLine(namabaru);
        }
    }
}

