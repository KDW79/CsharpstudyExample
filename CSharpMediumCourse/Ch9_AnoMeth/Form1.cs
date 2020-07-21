using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_AnoMeth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void RunDelegate(int p);
        delegate int Expr(int a, int b);


        private void Form1_Load(object sender, EventArgs e)
        {
            // 무명메서드
            // delegate (int p) { /* ... */ };
            RunDelegate r = delegate (int p) { MessageBox.Show(p.ToString()); };
            r(123);

            Expr expr = delegate (int a, int b)
            {
                return 2 * a + b;
            };
            int result = expr(1, 2);
            MessageBox.Show(result.ToString());

            button1.Click += delegate (object s, EventArgs ea)
            {
                MessageBox.Show("Button1");
            };

        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Button1");
        //}
    }
}
