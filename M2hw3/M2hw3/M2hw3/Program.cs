using System;

namespace M2hw3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var present = new Present();
            present.Print();
            present.PrintSortArray();
            var x = present.TakeCandy("Black Chocolate Candies with nuts");
            Console.WriteLine(x);
            Console.WriteLine("---------------------------");
            var chocolateCandies = new ChocolateCandies();
            chocolateCandies.Messege();
            var blackChocolateCandies = new BlackChocolateCandies();
            blackChocolateCandies.Messege();
            var blackChocolateCandiesWithNuts = new BlackChocolateCandiesWithNuts();
            blackChocolateCandiesWithNuts.Messege();
            var aeratedBlackChocolatesCandiesWithNuts = new AeratedBlackChocolatesCandiesWithNuts();
            aeratedBlackChocolatesCandiesWithNuts.Messege();
        }
    }
}
