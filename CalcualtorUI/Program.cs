using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Autofac.Configuration;
using CalcualtorLog;

namespace CalcualtorUI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //IContainer container;
            //ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<LogFile>().As<ILog>();
            //container = builder.Build();
            //var log = container.Resolve<ILog>();

            IContainer container;
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            container = builder.Build();
            var log = container.Resolve<ILog>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(log));
        }
    }
}