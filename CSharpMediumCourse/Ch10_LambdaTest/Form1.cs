using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch10_LambdaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate int FN(int a);

        private void Form1_Load(object sender, EventArgs e)
        {
            // 무명메서드를 람다식으로
            //button1.Click += delegate (object s, EventArgs ea)
            //{
            //    MessageBox.Show("Done");
            //}

            button1.Click += (s, ea) => MessageBox.Show("Done");

            // 람다식을 델리게이트에 할당
            FN sqr = (x) => x * x; 
            int res = sqr(4);
            Debug.WriteLine(res);

            Func<int, int> sq = (x) => x * x;
            int result_sq = sq(5);
            Debug.WriteLine(result_sq);

            Func<double, double, decimal> f = (x, y) => (decimal)(x + y);
            decimal result_anoFunc = f(5, 5);
            Debug.WriteLine(result_anoFunc);

            // 람다식을 메서드의 파라미터로 전달
            GetData(p => p.StartsWith("A"));
            GetData(p => p.Contains("an"));
            GetData(p => p.Substring(0, 1) == "P" && p.Substring(2, 1) == "n");

            // LINQ
            var list = data.Where(name => name.StartsWith("A"));
        }

        private List<string> data = new List<string> { "Alexa", "Pane", "Jane", "Alex" };

        private void GetData(Func<string, bool> filterCondition)
        {
            foreach (var item in data)
            {
                if(filterCondition(item))
                {
                    Debug.WriteLine(item);
                }
            }
        }
    }
}
