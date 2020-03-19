using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_rz43_CalcualtorLib.Calculators
{
    public class Div : ICalculator
    {
        public double Calcualtor(double var1, double var2)
        {
            if (var2 != 0)
            {
                double result = var1 / var2;
                return result;
            }
            else
                throw new Exception("除数不能为零...");
        }
    }
}