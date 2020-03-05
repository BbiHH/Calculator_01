using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_rz43_CalcualtorLib.Calculators
{
    public class Add: ICalculator
    {
        public int Calcualtor(int var1, int var2)
        {
            var result = var1 + var2;
            return result;
        }
    }
}
