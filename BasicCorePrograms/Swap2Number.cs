using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Swap2Number
    {
        public int NumberOne;
        public int NumberTwo;
        public int temp = 0;
        public void SwapTwoNumber()
        {

            Console.Write("\nInput the First Number : "); //Input from user
            NumberOne = Convert.ToInt32(Console.ReadLine());//Read 1st Number
            Console.Write("\nInput the Second Number : "); //Input from User
            NumberTwo = Convert.ToInt32(Console.ReadLine());//Read @nd Number
            temp = NumberOne; // ( storing numTwo in temp )
            NumberOne = NumberTwo; //(in numOne Storing NumberTwo)
            NumberTwo = temp; //(storing Temp value in Number 2)
            Console.Write("\nAfter Swapping : "); //for show
            Console.Write("\nFirst Number : " + NumberOne); //Op After swaping
            Console.Write("\nSecond Number : " + NumberTwo);//Op after swaping
            Console.Read();
        }
    }
}