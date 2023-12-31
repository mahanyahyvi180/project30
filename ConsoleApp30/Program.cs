﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Time1();

            Console.WriteLine($"The initial universal time is:{time.ToUniversalString()}");

            Console.WriteLine($"The initial standard time is:{time.ToString()}");

            Console.WriteLine();

            time.SetTime(13, 27, 6);

            Console.WriteLine($"Universal time after SetTime is:{time.ToUniversalString()}");
            Console.WriteLine($"Standard time after SetTime is:{time.ToString()}");

            Console.WriteLine();

            try
            {
                time.SetTime(99, 99, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("After attemptig invalid settings:");
            Console.WriteLine($"Universal time:{time.ToUniversalString()}");
            Console.WriteLine($"Standard time:{time.ToString()}");
            Console.ReadLine();
        }
        }
    
}
