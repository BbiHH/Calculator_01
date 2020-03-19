using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_rz43_CalcualtorLib.Calculators
{
    public class Add : ICalculator
    {
        public double Calcualtor(double var1, double var2)
        {
            var result = var1 + var2;
            return result;
        }
    }
}