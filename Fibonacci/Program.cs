﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci {
    internal class Program {
        public static ulong fibonacci(int darab) {
            if ((darab == 0) || (darab == 1)) {
                return Convert.ToUInt64(darab);
            } else {
                return fibonacci(darab - 1) + fibonacci(darab - 2);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Adja meg hány számot akar látni");
            ulong darab = Convert.ToUInt64(Console.ReadLine());
          
            ulong a = 0, b = 1, szamlalo = 0;
            while (szamlalo++ < darab) {
                b += a;
                a = b - a;

                Console.WriteLine(b);
            }
          
            Console.ReadKey();
        }
    }
}
