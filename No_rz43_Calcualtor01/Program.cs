using No_rz43_CalcualtorLib;
using No_rz43_CalcualtorLib.Calculators;
using No_rz43_CalcualtorLib.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace No_rz43_CalClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            var result = 0.0;
            string op;
            Console.WriteLine("$-:欢迎使用四则运算1.0.0版本！");
            Console.WriteLine("$-:请输入运算式:");
            Console.Write("$-:  var1:     ");
            var1 = Int32.Parse(Console.ReadLine());
            Console.Write("$-:  op:       ");
            op = Console.ReadLine();
            Console.Write("$-:  var2      ");
            var2 = Int32.Parse(Console.ReadLine());

            //利用配置文件管理工具配置文件
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string factoryname = conf.AppSettings.Settings[op].Value;
            //用反射机制
            //当前程序集 
            //Type type = Type.GetType(factoryname);
            //type.Assembly.CreateInstance(factoryname);
            Assembly ass = Assembly.Load("No_rz43_CalcualtorLib");
            ICalculatorFactory ft = (ICalculatorFactory)ass.CreateInstance(factoryname);
            ICalculator cal = ft.GetCalcualtor();
            result = cal.Calcualtor(var1, var2);

            Console.WriteLine("$-:result:     {0}{1}{2}={3}", var1, op, var2, result);
            Console.ReadKey();
        }
    }
}
