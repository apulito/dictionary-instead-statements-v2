using Domain.v2;

namespace Console.Dictionary.v2;

public class BasePointManager
{
    private readonly Dictionary<PokemonType, Func<FightingGroundType, int>> _basePointMapDelegates = new Dictionary<PokemonType, Func<FightingGroundType, int>>
    {
        { PokemonType.NORMAL, GetHitPointForNormalType },
        { PokemonType.GRASS, GetHitPointForGrassType },
        { PokemonType.ELECTRIC, GetHitPointForElectricType },
        { PokemonType.WATER, GetHitPointForWaterType },
        { PokemonType.FIRE, GetHitPointForFireType },
        { PokemonType.BUG, GetHitPointForBugType }
    };

    /// <summary>
    /// Execute calculation of hit points with dictionary
    /// </summary>
    /// <param name="pokemonType"></param>
    /// <param name="groundType"></param>
    /// <returns></returns>
    public int GetHitPoint(PokemonType pokemonType, FightingGroundType groundType)
    {
        return _basePointMapDelegates.ContainsKey(pokemonType) ? _basePointMapDelegates[pokemonType].Invoke(groundType) : 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForBugType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)(groundType == FightingGroundType.AIR ? HitType.WEAK : HitType.SUPER_EFFECTIVE);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForFireType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)(groundType == FightingGroundType.GROUND  || groundType == FightingGroundType.WATER ? HitType.SUPER_WEAK : HitType.SUPER_EFFECTIVE);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForWaterType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)(groundType == FightingGroundType.GROUND ? HitType.WEAK : HitType.SUPER_EFFECTIVE);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForElectricType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)(groundType == FightingGroundType.GROUND ? HitType.WEAK : HitType.EFFECTIVE);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForGrassType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)(groundType == FightingGroundType.AIR ? HitType.SUPER_WEAK : HitType.EFFECTIVE);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int GetHitPointForNormalType(FightingGroundType groundType)
    {
        // Do some stuff and return value
        return (int)HitType.WEAK;
    }
}