using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uklon
{
    public class Solution1
    {

        public Solution1() { }


        public int MaxPrybutok(int[] prices)
        {
            int purchasePrice = prices[0];
            int purchaseDay = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < purchasePrice)
                {
                    purchasePrice = prices[i];
                    purchaseDay = i;
                }
            }

            if (prices.Last() == purchasePrice)
            {
                return -1 * purchasePrice;
            }


            int sellPrice = prices[purchaseDay + 1];
            for (int i = purchaseDay + 1; i < prices.Length; i++)
            {
                if (prices[i] > sellPrice)
                {
                    sellPrice = prices[i];
                }
            }
            return (sellPrice - purchasePrice);


        }


        public static void TestTask1()
        {
            int[] input = { 7, 2, 3, 1, 12, 5, 3, 14, -2, 6, -5, -113 };

            Solution1 a = new Solution1();

            Console.WriteLine(a.MaxPrybutok(input));
        }
    }
}
