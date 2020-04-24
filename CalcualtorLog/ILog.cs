using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcualtorLog
{
    public interface ILog
    {
        void WriteLog(string contents);

        string Readlog();
    }
}