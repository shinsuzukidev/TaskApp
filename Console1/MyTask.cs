using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class MyTask
    {
        public MyTask()
        {
                
        }

        public void Execute1()
        {
            Console.WriteLine("Execute1 - start");

            //---- Task.Run引数なし
            Task.Run(() => {
                Console.WriteLine("task - start");
                Thread.Sleep(2000);
                Console.WriteLine("task - end");
            });

            Console.WriteLine("Execute1 - end");
        }


        public void Execute2()
        {
            Console.WriteLine("Execute2 - start");

            //---- Task.Run引数あり
            //Task.Run(() => { DoHeayWork("aoi"); });
            //Task.Run(() => { DoHeayWork("kii"); });

            //---- Task.Run引数あり、wait all
            var t1 = Task.Run(() => { DoHeayWork("aoi"); });
            var t2 = Task.Run(() => { DoHeayWork("kii"); });
            Task.WaitAll(t1, t2);

            Console.WriteLine("Execute2 - all finish.");
            Console.WriteLine("Execute2 - end");
        }

        public void DoHeayWork(string name)
        {
            Console.WriteLine($"{name} DoHeayWork - start");
            Thread.Sleep(1000);
            Console.WriteLine($"{name} is woking.");
            Thread.Sleep(1000);
            Console.WriteLine($"{name} DoHeayWork - end");
        }

        public void Execute3()
        {
            Console.WriteLine($"Execute3 - start");

            var t1 = Task.Run(() => {
                Console.WriteLine("hevy work - start");
                Thread.Sleep(2000);
                Console.WriteLine("hevy work - end");
                return true;
            });

            Console.WriteLine($"Execute3 - Result:{t1.Result}");     // 同期
            Console.WriteLine($"Execute3 - finish");
        }

        public void Execute4()
        {
            Console.WriteLine($"Execute4 - start");

            var tasks = new List<Task<Tuple<int, bool>>>();

            for (int i = 0; i < 3; i++) {
                var index = i;
                var task = Task <Tuple<int, bool>>.Run(() => TaskProc(index));
                tasks.Add(task);
            }

            Task.WaitAll([.. tasks]);

            foreach (var t1 in tasks)
            {
                Console.WriteLine($"task.Result: {t1.Result.Item1},{t1.Result.Item2 }");
            }

            Console.WriteLine($"Execute4 - finish");
        }


        public Tuple<int, bool> TaskProc(int index) {
            Console.WriteLine($"hevy work({index}) - start");
            Thread.Sleep(2000);
            Console.WriteLine($"$hevy work({index}) - end");
            return new Tuple<int, bool>(index, true) ;
        }
}
}
