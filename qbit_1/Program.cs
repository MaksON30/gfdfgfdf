using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qbit_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine()); //price
            int P = Int32.Parse(Console.ReadLine());//percent
            int M = Int32.Parse(Console.ReadLine()); //money
            double doublePersent;
            double newMoney;
            double res;
           
            doublePersent = (double)(P / 100.0);
            newMoney = N * doublePersent;
            double item = N + newMoney;
            res = M / item;
            decimal dRes = Convert.ToDecimal(res);
            Console.WriteLine(Math.Truncate(dRes));
           // Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
