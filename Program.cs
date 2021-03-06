﻿using System;
using System.Diagnostics;
using Advent._2020.Week1;
using Advent._2020.Week2;
using Advent._2020.Week3;
using Advent._2020.Week4;

namespace Advent._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();

            Day25.Execute();

            s.Stop();
            Console.WriteLine($"\n\nTime Elapsed: {s.ElapsedMilliseconds}ms");
        }
    }
}