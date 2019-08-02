using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace ComputePi.ComputePiClass
{
    class PiClass
    {
        public static double ComputePi()
        {
            {

                var sum = 0.0;

                var step = 1e-9;

                for (var i = 0; i < 1000000000; i++)

                {

                    var x = (i + 0.5) * step;

                    sum = sum + 4.0 / (1.0 + x * x);

                }

                return sum * step;

            }
        }
       
        public static Task<double> ComputePiAsync()
        {
            return Task.Factory.StartNew(() => ComputePi());
        }        
    }
}
