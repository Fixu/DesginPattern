﻿using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            cat.Add(new Walk());

            cat.Show();

            Console.ReadKey();
        }
    }
}
 