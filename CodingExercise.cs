using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RtsLabsCodingExercise
{
    public class CodingExercise
    {
        public AboveBelowResult AboveBelow(int[] list, int comparisonValue)
        {
            int aboveCount = 0;
            int belowCount = 0;

            foreach(var i in list)
            {
                if (i > comparisonValue)
                {
                    aboveCount++;
                }
                else if (i < comparisonValue)
                {
                    belowCount++;
                }
            }

            return new AboveBelowResult
            {
                Above = aboveCount,
                Below = belowCount
            };
        }
        public string StringRotation(string str, uint rotationAmount)
        {
            if (rotationAmount > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(rotationAmount), "rotationAmount can not be greater than string length.");
            }

            int ra = str.Length - (int)rotationAmount;

            return str.Substring(ra, str.Length - ra) + str.Substring(0, ra);
        }
    }
    public class AboveBelowResult
    {
        public int Above { get; set; }
        public int Below { get; set; }
    }
}
