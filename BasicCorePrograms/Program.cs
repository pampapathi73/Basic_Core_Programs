using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            int selection = Convert.ToInt32(Console.ReadLine());

            // user selection

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinHeadOrTail FlipCoin = new FlipCoinHeadOrTail();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 10");
                    break;
            }
            Console.ReadLine();

        }
    }
}
