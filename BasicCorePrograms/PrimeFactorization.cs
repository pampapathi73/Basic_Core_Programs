using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactorization
    {
        public int Var_j = 0;
        public int num = 0;
        public int factorial = 1;
        public void CalcSFactorialSeries()
        {
            Console.Write("Calculate the factorial of a given number:"); //Input From User
            num = Convert.ToInt32(Console.ReadLine());//reading input form user
            for (Var_j = 1; Var_j <= num; Var_j++) //Checking var_j is <= num example(1<5) and den incrementing it by 1 
                factorial *= Var_j; //ca;lculate  factorial = factorial * var_j example (factroial = 1*1 or 2*2 or 5*5)
            Console.Write("The Factorial of {0} is: {1}\n", num, factorial); //op
        }
    }
}