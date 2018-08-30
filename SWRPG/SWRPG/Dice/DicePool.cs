using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    public class DicePool
    {
        public List<Die> Pool { get; set; }

        public DicePool()
        {

        }

        public void AddDie(DiceType type, int sides) => Pool.Add(new Die(sides, type));

        public void RemoveDie(DiceType type) => Pool.Remove(Pool.FirstOrDefault(d => d.Type == type));

        public void ClearPool() => Pool.Clear();

        public Dictionary<ResultTypes, int> Roll()
        {
            Dictionary<ResultTypes, int> resultPool = BuildResult();

            if(Pool.Capacity < 1)
            {
                return resultPool;
            }

            foreach(var die in Pool)
            {
                var result = die.Roll();
                
            }
        }

        private Dictionary<ResultTypes, int> BuildResult()
        {
            Dictionary<ResultTypes, int> basePool = new Dictionary<ResultTypes, int>();
            basePool.Add(ResultTypes.Advantage, 0);
            basePool.Add(ResultTypes.DarkPoint, 0);
            basePool.Add(ResultTypes.Dispair, 0);
            basePool.Add(ResultTypes.Failure, 0);
            basePool.Add(ResultTypes.LightPoint, 0);
            basePool.Add(ResultTypes.Success, 0);
            basePool.Add(ResultTypes.Threat, 0);
            basePool.Add(ResultTypes.Triumph, 0);
            return basePool;
        }

        private Dictionary<ResultTypes, int> AbilityResult(int roll, Dictionary<ResultTypes, int> resultPool)
        {
            switch(roll)
            {
                case 2:
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 3:
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.Success] += 2;
                    break;
                case 5:
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                case 6:
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                case 7:
                    resultPool[ResultTypes.Advantage] += 1;
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 8:
                    resultPool[ResultTypes.Advantage] += 2;
                    break;
                default:
                    break;
            }

            return resultPool;
        }

        private Dictionary<ResultTypes, int> Proficiency(int roll, Dictionary<ResultTypes, int> resultPool)
        {
            switch(roll)
            {
                case 2:
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 3:
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.Success] += 2;
                    break;
                case 5:
                    resultPool[ResultTypes.Success] += 2;
                    break;
                case 6:
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                case 7:
                    resultPool[ResultTypes.Advantage] += 1;
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 8:
                    resultPool[ResultTypes.Advantage] += 1;
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 9:
                    resultPool[ResultTypes.Advantage] += 1;
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 10:
                    resultPool[ResultTypes.Advantage] += 2;
                    break;
                case 11:
                    resultPool[ResultTypes.Advantage] += 2;
                    break;
                case 12:
                    resultPool[ResultTypes.Triumph] += 1;
                    resultPool[ResultTypes.Success] += 1;
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                default:
                    break;
            }

            return resultPool;
        }
    }
}
