using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loopandcondtional
{
    class foreg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine("Enter the table to be printed");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                int t = i * table;
                Console.WriteLine("{0} *{1}={2}",i, table, t);
                Console.WriteLine("............");

            }
            Console.Read();
        }
    }
}
