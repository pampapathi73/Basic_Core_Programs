﻿using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factors of number");
            Console.WriteLine("6 For: Select Quotient and Remainder");
            Console.WriteLine("7 For: Select Swap the Numbers");
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
                case 3:
                    //Power Of 2
                    CalculatePowerOf2 CalPower = new CalculatePowerOf2();
                    CalPower.CalcuOfPower();
                    break;
                case 4:
                    //Harmonic Series
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                case 5:
                    //Prime Factor
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                case 6:
                    //  quotient remainder
                    QusRemaindercs QuesRem = new QusRemaindercs();
                    QuesRem.QuotientRemainder();
                    break;
                case 7:
                    //Swap 2 number
                    Swap2Number SwapTwoNo = new Swap2Number();
                    SwapTwoNo.SwapTwoNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in Between 1 to 10");
                    break;
            }
            Console.ReadLine();

        }
    }
}
