using Domain.v2;

namespace Console.Dictionary.v2;

public class BasePointManager
{
    private const int DoubleUp = 2;

    private readonly Dictionary<PokemonType, Func<bool, int>> _basePointMapDelegates = new Dictionary<PokemonType, Func<bool, int>>
    {
        { PokemonType.NORMAL, GetHitPointForNormalType },
        { PokemonType.GRASS, GetHitPointForGrassType },
        { PokemonType.ELECTRIC, GetHitPointForElectricType },
        { PokemonType.WATER, GetHitPointForWaterType },
        { PokemonType.FIRE, GetHitPointForFireType },
        { PokemonType.BUG, GetHitPointForBugType }
    };

    public BasePointManager() {}

    /// <summary>
    /// Execute calculation of hit points with dictionary
    /// </summary>
    /// <param name="type"></param>
    /// <param name="hasBonus"></param>
    /// <returns></returns>
    public int GetHitPoint(PokemonType type, bool hasBonus = false)
    {
        return _basePointMapDelegates.ContainsKey(type) ? _basePointMapDelegates[type].Invoke(hasBonus) : 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForBugType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? 6 * DoubleUp : 6;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForFireType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? 5 * DoubleUp : 5;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForWaterType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? 4 * DoubleUp : 4;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForElectricType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? 3 * DoubleUp : 3;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForGrassType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? 2 * DoubleUp : 2;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForNormalType(bool hasBonus)
    {
        // Do some stuff and return value
        return hasBonus ? DoubleUp : 1;
    }
}