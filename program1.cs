using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 2, 5, 6, 2, 6, 5, 7 };
            int[] B = { 3, 4, 7, 1, 5, 6 };
            int[] C = { 3, 4, 7, 1, 5, 6 };
            var D = new int[] { 1, 2, 3 }; 

            int unpairedNumber = OddOccurrencesInArray(A);
            Console.WriteLine(unpairedNumber);
            Console.ReadLine();



            int mis = FindMissingelement(B);
            Console.WriteLine(mis);
            Console.ReadLine();



            OrderNumbers(C);

            Console.WriteLine();
            D[1] = 50;
            for (int i = 0; i < D.Length; i++)
            {
                
                Console.WriteLine(D[i]);

            }
            Console.ReadLine();



        }

        public static int OddOccurrencesInArray(int[] A)
        {
            if (A.Length > 1)
            {
                int xor = A[0];

                for (int i = 1; i < A.Length; i++)
                {
                    xor = xor ^ A[i];
                }
                return xor;
            }
            else
            {
                return A[0];
            }
        }

        private static int FindMissingelement(int[] B)
        {

            var missingElement = B[0] ^ 1;

            for (int i = 1; i < B.Length; i++)
            {
                missingElement = missingElement ^ B[i] ^ (i + 1);
            }
            return missingElement ^ (B.Length + 1);

        }

        public static int OrderNumbers(int[] C)

        {
            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine(C[i]);
            }

            Console.WriteLine();
            Array.Sort(C);
            int[] D = new int[6];
            for (int i = 0; i < C.Length; i++)
            {
                D[i] = C[i];
                //                Console.WriteLine(C[i]);
                Console.WriteLine(D[i]);
                //                Console.ReadLine();
            }
            return D[0];


        }

    }
}
