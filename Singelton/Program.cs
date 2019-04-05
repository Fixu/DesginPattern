﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = SingletonFactory.CreateInstance();
            singleton.Show();

            var sec = SingletonFactorySec.CreateInstance();
            sec.Show();
            Console.ReadKey();
        }
    }
}
