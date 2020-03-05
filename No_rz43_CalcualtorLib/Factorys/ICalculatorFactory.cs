using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No_rz43_CalcualtorLib.Calculators;

namespace No_rz43_CalcualtorLib.Factorys
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalcualtor();
    }
}
