using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            int selection = Convert.ToInt32(Console.ReadLine());

            // user selection

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinHeadOrTail FlipCoin = new FlipCoinHeadOrTail();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    //CheckLeapYearOrNot
                    CheckLeapYearOrNot LeapYearOrNot = new CheckLeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 10");
                    break;
            }
            Console.ReadLine();

        }
    }
}
