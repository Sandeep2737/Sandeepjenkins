using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiceg
{
    class calculatoreg
    {
        float num1 = 100, num2 = 60;
        void Add()
        {
            Console.WriteLine("Addition is:{0}", (num1 + num2));
        }
        float Sub()
        {
            return (num1 - num2);
        }
        static void Main()
        {
            calculatoreg objcalci = new calculatoreg();
            objcalci.Add();
            float res = objcalci.Sub();
            Console.WriteLine("sub:{0}", res);
            Console.ReadKey();
                }
        }
    }

