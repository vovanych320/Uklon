using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uklon
{
    public class Solution2
    {
        public Solution2() { }

        public void toDo()
        {
            int[] arr = null;//error
            for (int i = 0; i <= 9; i++)
                arr[i] = i * 2;

            foreach (var value in arr)
                Console.WriteLine(value);
        }


        public static void TestTask2()
        {
            Solution2 b = new Solution2();
            b.toDo();
        }
    }



}
