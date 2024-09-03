using System;
using System.Collections.Generic;
using System.Linq;

public class Program{
    public static void Main(){
        List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};

        List<int> numerosPares = numeros.Where(nameof => nameof % 2 == 0).ToList();

        Console.WriteLine("Números Pares: ");
        numerosPares.ForEach(n=> Console.WriteLine(n));

        List<string> frutas = new List<string> {"Maçã", "Banana", "Manga", "Abacaxi", "Melancia", "Morango"};

        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas que começam com 'M': ");
        frutasComM.ForEach(f => Console.WriteLine(f));
    }
}