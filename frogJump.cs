using System;

namespace MyApp; // FrogJump solution in C#

class Program
{
    static void Main(String[] args)
    {

        var sol = new Solution();
        Console.WriteLine(sol.solution(10, 85, 30));
        Console.ReadLine();


    }
    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            double result = ((double)Y - (double)X) / (double)D;
            var count = result % 1 == 0 ? (int)result : result + 1;
            return (int)count;
        }

    }


};
