﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class SwapNumber
    {
        public void Calculation()
        {
            int temp = 0;
            Console.WriteLine("Enter the 1st Number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            temp = numOne;
            numOne = numTwo;
            numTwo = temp;
            Console.WriteLine($" numOne :{numOne}");
            Console.WriteLine($" numTwo :{numTwo}");
        }
    }
}