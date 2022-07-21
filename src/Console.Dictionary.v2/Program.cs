﻿using Domain.v2;

namespace Console.Dictionary.v2
{
    internal class Program
    {
        static void Main()
        {
            var result = new BasePointManager().GetHitPoint(type: PokemonType.ELECTRIC, hasBonus: true);
            System.Console.WriteLine($"The result of the operation managed with dictionary is {result}");
            System.Console.ReadKey();
        }
    }
}
