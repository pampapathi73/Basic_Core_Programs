﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class CalculatePowerOf2
    {
        public int num = 0;
        public void CalcuOfPower()
        {

            Console.Write("Enter a number:");//input from User
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2; //num*2 if 2*2==4
            Console.WriteLine(result);//Op
            Console.ReadLine();
        }
        }
}
