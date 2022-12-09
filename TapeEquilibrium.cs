using System;
namespace MyApp
{
    class TapeEquilibrium
    {
        static void Main(String[] args)
        {
            int[] input = { 3, 1, 2, 4, 3 };

            int TapEquilibrium = Equilibrium(input);
            Console.WriteLine(TapEquilibrium);
            Console.ReadLine();

        }
        private static int Equilibrium(int[] A)
        {
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum+= A[i];
            }
            var sumTillCurrentIndex = A[0];
            var minDifference = Math.Abs(A[0] - (sum - A[0]));
            sum -= A[0];

            for (int p = 2; p < A.Length; p++)
            {
                sumTillCurrentIndex += A[p - 1];
                sum -= A[p-1];
                if (minDifference > Math.Abs(sum - sumTillCurrentIndex))
                {
                    minDifference = Math.Abs(sum - sumTillCurrentIndex);
                } 
            }
            return minDifference;
        }
    }
}
