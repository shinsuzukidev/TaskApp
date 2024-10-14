using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class ActionSample
    {
        public ActionSample()
        {
                
        }

        public void Execute()
        {
            // デリゲートを使用1
            Action a1 = new Action(delegate () { Console.WriteLine("action a1"); });
            a1();

            // デリゲートを使用2
            Action a2 = delegate () { Console.WriteLine("action a2"); };
            a2();

            // ラムダ式Action
            Action a3 = new Action(() => { Console.WriteLine("action a3"); });
            a3();

            // ラムダ式Action
            Action a4 = () => { Console.WriteLine("action - ramda - a4"); };
            a4();

            // 引数が一つあり、
            Action<int, string> a5 = (int v1, string s1) => { Console.WriteLine("action - ramda - a5 - p:{0},{1}", v1, s1); };
            a5(100, "hello");

            // varを使用、引数が複数あり
            var a6 = (int v1, int v2) => { Console.WriteLine("action - ramda - a6 - p:{0},{1}", v1, v2); };
            a6(100, 200);

        }

    }
}
