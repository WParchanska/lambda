using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prośba o wprowadzenie listy liczb całkowitych
        Console.WriteLine("Wprowadź listę liczb całkowitych, oddzielając je przecinkami:");
        string input = Console.ReadLine();

        // Rozdzielanie wprowadzonego ciągu znaków na pojedyncze liczby całkowite
        int[] numbers = input.Split(',').Select(int.Parse).ToArray();

        // Sprawdzenie, czy każda liczba jest parzysta czy nieparzysta za pomocą wyrażeń lambda
        var result = numbers.Select(n => new { Number = n, IsEven = n % 2 == 0 });

        // Wyświetlenie wyników
        Console.WriteLine("Wyniki:");

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Number} jest {(item.IsEven ? "parzysta" : "nieparzysta")}");
        }
    }
}
