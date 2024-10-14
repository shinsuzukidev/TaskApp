using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Console1
{
    public class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________________ start");

            //----
            //var h = new Hoge();
            //var t = h.Execute();
            //Console.WriteLine(t.Result);

            //---- 呼び出し
            //{
            //    Action action = () => { Console.WriteLine("task id: {0}", Task.CurrentId); };
            //    Task.Run(action);
            //}

            //---- 値を渡す
            //{
            //    Action<int> action = (value) =>
            //    {
            //        Console.WriteLine("task id: {0}, value:{1}", Task.CurrentId, value);
            //    };
            //    var t1 = new Task(action, 3);
            //    t1.Start();
            //}

            //---- 値を返す
            //{
            //    Func<int> f1 = () => { return 100; };
            //    Task<int> t2 = Task.Run(f1);
            //    Console.WriteLine("t2.Result: {0}", t2.Result);
            //}

            //---- 値を渡して返す
            //{
            //    Func<int, int> action = (value) => {
            //        return 100 + value;
            //    };

            //    Task.Run(action)
            //}


            //---- Action 
            new ActionSample().Execute();

            //---- Func
            new FuncSample().Execute();










            Console.WriteLine("________________________________________ end");
            Console.WriteLine("press return key to exit...");
            Console.ReadLine();


        }
    }
}
