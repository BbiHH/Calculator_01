using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace CalcualtorLog
{
    public class LogFile : ILog
    {
        private string _path = ConfigurationManager.AppSettings["calculatorlog"] ?? "calculator.log";

        /// <summary>
        /// 写日志方法
        /// </summary>
        /// <param name="contents">写入日志的内容</param>
        public void WriteLog(string contents)
        {
            //内容写入指定路径里面
            System.IO.File.AppendAllText(_path, contents);
        }

        /// <summary>
        /// 读日志方法
        /// </summary>

        public string Readlog()
        {
            return System.IO.File.ReadAllText(_path);
        }
    }
}