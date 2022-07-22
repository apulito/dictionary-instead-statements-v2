using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.v2;

namespace Console.IfElse.v2
{
    public class BasePointManager
    {
        public BasePointManager() { }

        /// <summary>
        /// Execute calculation of hit points with if-else ladder
        /// </summary>
        /// <param name="pokemonType"></param>
        /// <param name="groundType"></param>
        /// <returns></returns>
        public int GetHitPoint(PokemonType pokemonType, FightingGroundType groundType)
        {
            var point = 0;

            if (pokemonType == PokemonType.NORMAL)
            {
                point = GetHitPointForNormalType(groundType);
            }
            else if (pokemonType == PokemonType.GRASS)
            {
                point = GetHitPointForGrassType(groundType);
            }
            else if (pokemonType == PokemonType.ELECTRIC)
            {
                point = GetHitPointForElectricType(groundType);
            }
            else if (pokemonType == PokemonType.WATER)
            {
                point = GetHitPointForWaterType(groundType);
            }
            else if (pokemonType == PokemonType.FIRE)
            {
                point = GetHitPointForFireType(groundType);
            }
            else if (pokemonType == PokemonType.BUG)
            {
                point = GetHitPointForBugType(groundType);
            }

            // and soo on

            return point;
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
            return (int)(groundType == FightingGroundType.GROUND || groundType == FightingGroundType.WATER ? HitType.SUPER_WEAK : HitType.SUPER_EFFECTIVE);
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
}
