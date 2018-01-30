using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detyra2
{
    class SingingEasy
    {
        int[,] matrixR = new int[2000, 2000];

        public int solve(int[] pitch)
        {
            int arrLength = pitch.Length;
            if (arrLength < 3)
            {
                return 0;
            }

            for (int a = 2; a <= arrLength; a++)
            {
                matrixR[a, 0] = matrixR[a - 1, 0] + Math.Abs(pitch[a - 2] - pitch[a - 1]);
            }

            for (int i = 3; i <= arrLength; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i - j >= 2)
                    {
                        matrixR[i, j] = matrixR[i - 1, j] + Math.Abs(pitch[i - 2] - pitch[i - 1]);
                    }
                    else
                    {
                        int tempResult = 1000000;
                        for (int k = 1; k < j; k++)
                        {
                            tempResult = Math.Min(tempResult, matrixR[j, k] + Math.Abs(pitch[i - 1] - pitch[k - 1]));
                        }
                        matrixR[i, j] = Math.Min(tempResult, matrixR[j, 0]);
                    }
                }
            }

            int result = matrixR[arrLength, 0];
            for (int i = 1; i < arrLength; ++i)
            {
                result = Math.Min(result, matrixR[arrLength, i]);
            }
            return result;
        }
    }
}
