using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ComputePi.ComputePiClass
{
    class Test
    {
        public static void Showcase()
        {
            Console.WriteLine("Compute Pi (sync)");
            Measure(() => PiClass.ComputePi());
            Console.WriteLine("Compute Pi (async)");
            Measure(() => PiClass.ComputePiAsync().Wait());
        }

        static void Measure(Action action)
        {
            var sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("Time = {0} ms", sw.ElapsedMilliseconds.ToString());
        }
    }
}
