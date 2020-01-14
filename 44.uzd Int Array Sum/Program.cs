using System;

namespace _44.uzd_Int_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 26, 8, 9, 10, 32, 18, 24 };

            var sum = 0;

            foreach (var number in numbers)
            {
                if (number > 10)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);

        }
    }
}
// Definēt int tipa masīvu ar 8 elementiem. Sasummēt tikai tos elementus, kuru vērtība ir lielāka par 10.