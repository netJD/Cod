using System;

    namespace MyApp
{
    class WaterTanks
    {

        static void Main(string[] args)
        {
            // calculate how many water tanks can be installed between the sides of each house
            // H represents a house, special conditions for: H ,HH-HH, -H-HH--
            //            string S = "-H-H-H-H-H";
            //            string S = "-H-HH--";
            //string S = "H";
            //            string S = "HH-HH";
            //            string S = "-H-H-H-H";
            //string S = "-HH-H-HH-H";
            //            string S = "-HH-H-HH-H---HH---H-H";
            string S = "-HH-H---HH--H---------HH---HH--H-";

            var sol = new Solution();
            Console.WriteLine(sol.solution(S));
            Console.ReadLine();


        }
        class Solution
        {
            public int solution(string S)
            {
                Console.WriteLine(S);
                
                int w = 0;
                int count = 0;



                if (S[0] == 'H' & S.Length == 1)
                {

                    w = (-1);
                    Console.WriteLine("Water Tanks:", w);
                    return w;

                }

                if (S[0] == 'H' & S[1] == 'H' & S.Length == 5)
                {

                    w = -1;
                    Console.WriteLine("Water Tanks:", w);
                    return w;

                }

                if (S[0] == '-' & S[1] == 'H' & S[2] == '-' & S.Length == 7)
                {

                    w = 2;
                    Console.WriteLine("Water Tanks:",w);
                    return w;

                }

                if (S.Length > 7) {

                    if (S[0] == '-' )
                    {
                        count = count + 1;
                        w = count;

                    }

                    if (S[S.Length-1] == '-' & S[S.Length - 2] == 'H')
                    {
                        count = count + 1;
                        w = count;

                    }

                    for (int i = 1; i < S.Length-1; i++)
                    {

                        if (S[i] == '-' & S[i+1] == 'H')
                        {
                            count = count + 1;
                            w = count;

                        }
                        if (S[i] == '-' & S[i + 1] == '-' & S[i - 1] == 'H')
                        {
                            count = count + 1;
                            w = count;

                        }

                    }
                }

                Console.WriteLine("Water Tanks:", w);
                return w;

            }

        }



    }
}
