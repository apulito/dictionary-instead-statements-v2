using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.v2;

namespace Console.Switch.v2
{
    public class BasePointManager
    {
        private const int DoubleUp = 2;

        public BasePointManager() { }

        /// <summary>
        /// Execute calculation of hit points with switch statements
        /// </summary>
        /// <param name="pokemonType"></param>
        /// <param name="groundType"></param>
        /// <returns></returns>
        public int GetHitPoint(PokemonType pokemonType, FightingGroundType groundType)
        {
            var point = 0;

            switch (pokemonType)
            {
                case PokemonType.NORMAL:
                    point = GetHitPointForNormalType(groundType);
                    break;
                case PokemonType.GRASS:
                    point = GetHitPointForGrassType(groundType);
                    break;
                case PokemonType.ELECTRIC:
                    point = GetHitPointForElectricType(groundType);
                    break;
                case PokemonType.WATER:
                    point = GetHitPointForWaterType(groundType);
                    break;
                case PokemonType.FIRE:
                    point = GetHitPointForFireType(groundType);
                    break;
                case PokemonType.BUG:
                    point = GetHitPointForBugType(groundType);
                    break;

                // and soo on
            }

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
