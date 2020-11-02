using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopandcondtional
{
    class ifeg
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater:{0}", num1);
            }
              else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Num2 is greater:{0}", num2);
            }
           else
            {
                Console.WriteLine("Num3 is greater:{0}", num3);
            }
            Console.Read();
            
        }
    }
}
