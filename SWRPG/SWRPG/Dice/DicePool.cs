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

        public void AddDie(DiceType type) => Pool.Add(new Die(type));

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
                switch (die.Type)
                {
                    case DiceType.Ability:
                        AbilityResult(result, ref resultPool);
                        break;
                    case DiceType.Boost:
                        BoostResult(result, ref resultPool);
                        break;
                    case DiceType.Challenge:
                        ChallengeResult(result, ref resultPool);
                        break;
                    case DiceType.Difficulty:
                        DifficultyResult(result, ref resultPool);
                        break;
                    case DiceType.Force:
                        ForceResult(result, ref resultPool);
                        break;
                    case DiceType.Proficiency:
                        ProficiencyResult(result, ref resultPool);
                        break;
                    case DiceType.Setback:
                        ProficiencyResult(result, ref resultPool);
                        break;
                    default:
                        break;
                }
            }

            return resultPool;
        }

        private Dictionary<ResultTypes, int> BuildResult()
        {
            Dictionary<ResultTypes, int> basePool = new Dictionary<ResultTypes, int>
            {
                { ResultTypes.Advantage, 0 },
                { ResultTypes.DarkPoint, 0 },
                { ResultTypes.Dispair, 0 },
                { ResultTypes.Failure, 0 },
                { ResultTypes.LightPoint, 0 },
                { ResultTypes.Success, 0 },
                { ResultTypes.Threat, 0 },
                { ResultTypes.Triumph, 0 }
            };
            return basePool;
        }

        private void AbilityResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
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
        }

        private void ProficiencyResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
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
        }

        private void BoostResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
        {
            switch (roll)
            {
                case 3:
                    resultPool[ResultTypes.Success] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.Success] += 1;
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                case 5:
                    resultPool[ResultTypes.Advantage] += 2;
                    break;
                case 6:
                    resultPool[ResultTypes.Advantage] += 1;
                    break;
                default:
                    break;
            }
        }

        private void DifficultyResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
        {
            switch (roll)
            {
                case 2:
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                case 3:
                    resultPool[ResultTypes.Failure] += 2;
                    break;
                case 4:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 5:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 6:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 7:
                    resultPool[ResultTypes.Threat] += 2;
                    break;
                case 8:
                    resultPool[ResultTypes.Failure] += 1;
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                default:
                    break;
            }
        }

        private void ChallengeResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
        {
            switch (roll)
            {
                case 2:
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                case 3:
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.Failure] += 2;
                    break;
                case 5:
                    resultPool[ResultTypes.Failure] += 2;
                    break;
                case 6:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 7:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 8:
                    resultPool[ResultTypes.Failure] += 1;
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 9:
                    resultPool[ResultTypes.Failure] += 1;
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 10:
                    resultPool[ResultTypes.Threat] += 2;
                    break;
                case 11:
                    resultPool[ResultTypes.Threat] += 2;
                    break;
                case 12:
                    resultPool[ResultTypes.Dispair] += 1;
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                default:
                    break;
            }
        }

        private void SetBackResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
        {
            switch (roll)
            {
                case 3:
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.Failure] += 1;
                    break;
                case 5:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                case 6:
                    resultPool[ResultTypes.Threat] += 1;
                    break;
                default:
                    break;
            }
        }

        private void ForceResult(int roll, ref Dictionary<ResultTypes, int> resultPool)
        {
            switch (roll)
            {
                case 1:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 2:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 3:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 4:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 5:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 6:
                    resultPool[ResultTypes.DarkPoint] += 1;
                    break;
                case 7:
                    resultPool[ResultTypes.DarkPoint] += 2;
                    break;
                case 8:
                    resultPool[ResultTypes.LightPoint] += 1;
                    break;
                case 9:
                    resultPool[ResultTypes.LightPoint] += 1;
                    break;
                case 10:
                    resultPool[ResultTypes.LightPoint] += 2;
                    break;
                case 11:
                    resultPool[ResultTypes.LightPoint] += 2;
                    break;
                case 12:
                    resultPool[ResultTypes.LightPoint] += 2;
                    break;
                default:
                    break;
            }
        }
    }
}
