﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDI_Page_70
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 4;
            bool isSixMore = 6 > value;
            Console.WriteLine("When value is {0} isSixMore is {1}",
                value, isSixMore);
            value = 35;
            isSixMore = 6 > value;
            Console.WriteLine("When value is {0} isSixMore is {1}",
                value, isSixMore);
        }
    }
}
