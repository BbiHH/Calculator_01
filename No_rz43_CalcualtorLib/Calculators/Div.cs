using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_rz43_CalcualtorLib.Calculators
{
    public class Div : ICalculator
    {
        public int Calcualtor(int var1, int var2)
        {
            if (var2 != 0)
            {
                int result = var1  / var2;
                return result;
            }
            else
                throw new Exception("除数不能为零...");
        }

    }
}
