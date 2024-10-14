using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Hoge
    {
        public async Task<int> Execute()
        {
            var val = await RunTaskA_Async();
            return val;
        }


        public async Task<int> RunTaskA_Async()
        {
            await Task.Delay(0);
            return 1 + 2 + 3;
        }

    }
}
