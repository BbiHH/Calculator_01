using CalcualtorLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcualtorUI
{
    public partial class Form2 : Form
    {
        private ILog log;

        public Form2(ILog log)
        {
            this.log = log;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = log.Readlog();
        }
    }
}