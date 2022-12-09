using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 2, 5, 6, 8, 4 };
            solution(A, 3);
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadLine();  

        }

        public static int solution(int[] A, int K)
        {
            if (A.Length > 1)
            {
                for (int j = 0; j < K; j++)
                {
                    var current = A[0];
                    var next = A[1];
                    for (int i = 0; i < A.Length -1; i++)
                    {
                        next = A[i + 1];
                        A[i + 1] = current;
                        current = next;
                    }
                    A[0] = next;
                }

            }
            return A[0];


        }


    }
}
