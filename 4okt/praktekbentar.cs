using System;

class Status
{
    static void Main()
    {
        while(true) 
        {
        int hp = 100;
        bool nyawa = hp > 0;
        string hidup;
        
        if (nyawa == true)
        {
            hidup = "hidup";

        } else
        {
            hidup = "tewas";
        }

        Console.WriteLine("hp: " + hp);
        Console.WriteLine("status " + hidup);
        Console.WriteLine("");
        Console.WriteLine("1. serang");

        int pilih = Convert.ToInt32(Console.ReadLine());

        if (pilih == 1)
        {
            hp -= 10;
            Console.WriteLine(hp);
        }
        else if (pilih == 2)
            {
                    break;
            }

        }
        

    }
}