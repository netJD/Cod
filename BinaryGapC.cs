using System;

namespace MyApp; // BinaryGap solution in C#

    class Program
{
    static void Main(String[] args)
    {

        var sol = new Solution();
        Console.WriteLine(sol.solution(1041));
        Console.ReadLine();


    }
    class Solution
    {
        public int solution(int N)
        {
            string binary = Convert.ToString(N, 2);
            int maxGap = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                for (int j = 0; j < binary.Length; j++)
                {
                    if ((binary[i] == '1') & (binary[j] == '1'))
                    {
                        if (maxGap < j - i - 1)
                        {
                            maxGap = j - i - 1;
                        }
                        i = j;
                    }
                }

            }
            return maxGap;
        }

    }


};
