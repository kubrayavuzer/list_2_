using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kullanıcıdan 5 kahve ismi alarak bir liste oluştur
        List<string> kahveListesi = new List<string>();

        Console.WriteLine("Lütfen 5 kahve ismi girin:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahve = Console.ReadLine();
            kahveListesi.Add(kahve);
        }

        Console.WriteLine("\nGirdiğiniz kahveler:");
        foreach (string kahve in kahveListesi)
        {
            Console.WriteLine("- " + kahve);
        }
    }
}
