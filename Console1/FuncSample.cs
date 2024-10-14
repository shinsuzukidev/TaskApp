using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class FuncSample
    {
        public FuncSample()
        {
            
        }

        public void Execute()
        {
            // 引数:string,戻値:bool
            Func<string, bool> f1 = (string name) => { 
                return string.IsNullOrEmpty(name);
            };
            Console.WriteLine("Function - f1:" + f1("aoi")); 

            // 引数:string,string, 戻値:string
            Func<string, string, string> f2 = (string type, string name) => {
                return $"{type}-{name}";
            };
            Console.WriteLine("Function - f2:" + f2("attaker", "aoi"));

            // varを使用、引数:string, 戻値:bool
            var f3 = (string type) => {
                return string.IsNullOrEmpty(type);
            };
            Console.WriteLine("Function - f3:" + f3("aoi"));
            Console.WriteLine("Function - f3:" + f3(""));

        }
    }
}
