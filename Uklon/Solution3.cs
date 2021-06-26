using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uklon
{
    public class Solution3
    {
        public Solution3(){}

        public void toDo()
        {
            StringBuilder sb = new StringBuilder(15, 15);
            sb.Append("Substring num1 ");
            sb.Insert(0, "Substring num2 ", 1);
        }


        public static void TestTask3()
        {
            Solution3 c = new Solution3();
            c.toDo();
        }
    }
}
