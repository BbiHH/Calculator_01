using CalcualtorLog;
using No_rz43_CalcualtorLib.Calculators;
using No_rz43_CalcualtorLib.Factorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcualtorUI
{
    public partial class Form1 : Form
    {
        //操作数
        private double dataX;

        private double dataY;
        private string op;
        private double result;
        private ICalculator cal;
        private ILog log;
        private Boolean FinishFlag = false;

        public Form1(ILog log)
        {
            InitializeComponent();
            this.log = log;
        }

        private void ZeroCheck()
        {
            if (tb_in.Text == "0")
            {
                tb_in.Text = "";
            }
            if (tb_out.Text == "None")
            {
                tb_out.Text = "";
            }
        }

        private void ZeroAdd()
        {
            tb_in.Text = "0";
            tb_out.Text = "None";
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            if (FinishFlag)
            {
                tb_in.ForeColor = Color.Black;
                tb_in.Text = "";
                tb_out.Text = "";
                FinishFlag = false;
            }
            ZeroCheck();
            tb_out.Text += ((Button)sender).Text;
            tb_in.Text += ((Button)sender).Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (tb_out.Text.Length > 0)
            {
                var str_in = tb_out.Text.Remove(tb_out.Text.Length - 1, 1);
                tb_out.Text = str_in;
            }
            else if (tb_out.Text.Length == 0)
            {
                ZeroAdd();
            }
            if (tb_in.Text.Length > 1)
            {
                var str_out = tb_in.Text.Remove(tb_in.Text.Length - 1, 1);
                tb_in.Text = str_out;
            }
            else if (tb_in.Text.Length == 1 && tb_out.Text.Length == 1)
            {
                ZeroAdd();
            }
        }

        private void btn_aclear_Click(object sender, EventArgs e)
        {
            ZeroAdd();
            dataX = 0;
            dataY = 0;
        }

        private void btnOps_Click(object sender, EventArgs e)
        {
            dataX = double.Parse(tb_in.Text);
            tb_out.Text += ((Button)sender).Text;
            tb_in.Text = "0";

            #region 使用配置文件和反射机制，按照所按操作符获取运算 cal

            //利用配置文件管理工具配置文件
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string factoryname = conf.AppSettings.Settings[((Button)sender).Text].Value;
            op = ((Button)sender).Text;
            //用反射机制
            //当前程序集
            //Type type = Type.GetType(factoryname);
            //type.Assembly.CreateInstance(factoryname);
            Assembly ass = Assembly.Load("No_rz43_CalcualtorLib");
            ICalculatorFactory ft = (ICalculatorFactory)ass.CreateInstance(factoryname);
            cal = ft.GetCalcualtor();

            #endregion 使用配置文件和反射机制，按照所按操作符获取运算 cal
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dataY = double.Parse(tb_in.Text);
            result = cal.Calcualtor(dataX, dataY);
            tb_in.ForeColor = Color.Red;
            tb_in.Text = result.ToString();
            if (dataY == 0)
            {
                tb_out.Text += "0";
            }
            tb_out.Text += "=";
            FinishFlag = true;
        }

        private void 日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //构建日志
            string contents = String.Format("{0} => {1}{2}{3}={4}\n",
                DateTime.Now.ToString(),
                dataX,
                op,
                dataY,
                result
                );
            //LogFile log = new LogFile();
            log.WriteLog(contents);
        }

        private void 读取日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(log);
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}