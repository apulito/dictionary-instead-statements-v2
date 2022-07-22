using Domain.v2;

namespace Console.IfElse.v2;

internal class Program
{
    static void Main()
    {
        var result = new BasePointManager().GetHitPoint(pokemonType: PokemonType.ELECTRIC, groundType: FightingGroundType.AIR);
        System.Console.WriteLine($"The result of the operation managed with ifelse ladder is {result}");
        System.Console.ReadKey();
    }
}