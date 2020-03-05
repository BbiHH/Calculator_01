using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Factorys
{
    public class DivFactory : ICalculatorFactory
    {
        public ICalculator GetCalcualtor()
        {
            return new Div();
        }
    }
}
